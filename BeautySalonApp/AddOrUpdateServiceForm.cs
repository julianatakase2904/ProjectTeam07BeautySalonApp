using BeautySalonCodeFirstFromDB;
using EFControllerUtilities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BeautySalonApp
{
    public partial class AddOrUpdateServiceForm : Form
    {

        private Service selectedService;
        private Inventory selectedInventoryProduct;

        public AddOrUpdateServiceForm()
        {
            InitializeComponent();

            listBoxInventory.SelectedIndexChanged += ListBoxInventory_SelectedIndexChanged;
            this.Load += AddServiceForm_Load;

            selectedService = null;

            this.Text = "Add Service";
            buttonSubmit.Text = "Add Service";

            buttonSubmit.Click += ButtonSubmit_Click;
        }

        public AddOrUpdateServiceForm(Service service)
        {
            InitializeComponent();
            listBoxInventory.SelectedIndexChanged += ListBoxInventory_SelectedIndexChanged;
            this.Load += AddServiceForm_Load;

            this.selectedService = Controller<BeautySalonEntities, Service>.FindEntity(service.ServiceId);
            this.selectedInventoryProduct = Controller<BeautySalonEntities, Inventory>.FindEntity(service.ProductId);

            this.Text = "Update Service";
            buttonSubmit.Text = "Update Service";

            textBoxServiceName.Text = service.ServiceName;
            textBoxServicePrice.Text = service.ServicePrice.ToString();

            //Event handler
            buttonSubmit.Click += ButtonSubmit_Click;

        }

        private void ButtonSubmit_Click(object sender, EventArgs e)
        {

            try
            {
                bool validNumber = decimal.TryParse(textBoxServicePrice.Text, out decimal servicePrice);

                if (!validNumber)
                {
                    throw new Exception("Enter a vaild number");
                }

                if (servicePrice < 0)
                {
                    throw new Exception("Enter a number greater than 0");
                }

                var selectedInventoryItem = (Inventory)listBoxInventory.SelectedItem;


                //get data from form inputs
                Service service = new Service()
                {
                    ServiceName = textBoxServiceName.Text,
                    ServicePrice = servicePrice,
                    ProductId = selectedInventoryItem.ProductId
                };


                if (this.selectedService == null)
                {
                    AddService(service);
                }
                else
                {
                    //add the serviceId of the service to be updated
                    service.ServiceId = this.selectedService.ServiceId;
                    UpdateService(service, selectedInventoryItem.ProductId);
                }

                this.DialogResult = DialogResult.OK;
                Close();

            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            };

        }

        private void UpdateService(Service service, int newInventoryProductID)
        {

            //if the previous inventory is the same as the selected do nothing
            if (selectedService.ProductId != newInventoryProductID)
            {

                try
                {
                    //increase the previous by 1 
                    Inventory previousProduct = Controller<BeautySalonEntities, Inventory>.FindEntity(selectedInventoryProduct.ProductId);

                    previousProduct.ProductQuantity += 1;
                    Controller<BeautySalonEntities, Inventory>.UpdateEntity(previousProduct);

                    //decrease the new inventory by 1
                    Inventory currentProduct = Controller<BeautySalonEntities, Inventory>.FindEntity(selectedInventoryProduct.ProductId);

                    currentProduct.ProductQuantity -= 1;
                    Controller<BeautySalonEntities, Inventory>.UpdateEntity(currentProduct);

                }
                catch (Exception)
                {
                    throw new Exception("Error updating inventory previously attached to this service; Unable to update service");
                }

            }

            //update the service
            if (!Controller<BeautySalonEntities, Service>.UpdateEntity(service))
            {
                throw new Exception("Error adding updated service to the Database");
            }
        }

        private void AddService(Service service)
        {
            Inventory product = Controller<BeautySalonEntities, Inventory>.FindEntity(service.ProductId);
            //decrease the previous inventory by 1
            if (product != null)
            {
                product.ProductQuantity -= 1;
                Controller<BeautySalonEntities, Inventory>.UpdateEntity(product);
            }
            else
            {
                throw new Exception("Error updating inventory attached to this service");
            }

            if (Controller<BeautySalonEntities, Service>.AddEntity(service) == null)
            {
                throw new Exception("Error adding service to Database");
            }
        }

        private void AddServiceForm_Load(object sender, EventArgs e)
        {
            // bind the listbox with inventory product 
            listBoxInventory.DataSource = Controller<BeautySalonEntities, Inventory>.SetBindingList();
        }

        private void ListBoxInventory_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxInventory.SelectedItem is Inventory product)
            {
                selectedInventoryProduct = product;
            }
        }
    }
}
