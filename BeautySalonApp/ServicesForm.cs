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
    public partial class ServicesForm : Form
    {
        public ServicesForm()
        {
            InitializeComponent();

            this.TopLevel = false;
            this.FormBorderStyle = FormBorderStyle.None;
            this.Visible = true;
            this.Dock = DockStyle.Fill;

            InitializeDataGridView<ServiceInventoryView>(dataGridViewInventory, "ServiceId", "ProductId", "ProductQuantity");

            buttonNewEntry.Click += ButtonNewEntry_Click;
            buttonDeleteEntry.Click += ButtonDeleteEntry_Click;
            buttonUpdateEntry.Click += ButtonUpdateEntry_Click;
        }

        //EVENT HANDLERS

        private void ButtonUpdateEntry_Click(object sender, EventArgs e)
        {
            try
            {
                var row = dataGridViewInventory.CurrentRow;

                if (row == null)
                {
                    throw new Exception("Please select an entry to update");
                }
                else
                {
                    Service service = new Service()
                    {
                        ServiceId = (int)row.Cells[0].Value,
                        ServiceName = (string)row.Cells[1].Value,
                        ServicePrice = (decimal)row.Cells[2].Value,
                        ProductId = (int)row.Cells[3].Value
                    };

                    AddOrUpdateServiceForm updateServiceForm = new AddOrUpdateServiceForm(service);
                    HandleForm(updateServiceForm);
                }
            }
            catch (Exception err)
            {

                MessageBox.Show(err.Message);
            }

        }
        private void ButtonNewEntry_Click(object sender, EventArgs e)
        {
            AddOrUpdateServiceForm addServiceForm = new AddOrUpdateServiceForm();
            HandleForm(addServiceForm);
        }

        private void ButtonDeleteEntry_Click(object sender, EventArgs e)
        {
            try
            {
                //grab the selected row
                var row = dataGridViewInventory.CurrentRow;

                if (row == null)
                {
                    throw new Exception("Please select an entry to update");
                }

                //create a service object form the selected datagrid row
                Service service = new Service()
                {
                    ServiceId = (int)row.Cells[0].Value,
                    ServiceName = (string)row.Cells[1].Value,
                    ServicePrice = (decimal)row.Cells[2].Value,
                    ProductId = (int)row.Cells[3].Value
                };

                if (!Controller<BeautySalonEntities, Service>.DeleteEntity(service))
                {
                    throw new Exception("Unable to delete product from database");
                }
                else
                {
                    //successfully deleted service, refresh the data grid view
                    dataGridViewInventory.DataSource = Controller<BeautySalonEntities, ServiceInventoryView>.SetBindingList();
                    dataGridViewInventory.Refresh();

                }
            }
            catch (Exception err)
            {

                MessageBox.Show(err.Message);
            }


        }



        //PRIVATE METHODS

        private void InitializeDataGridView<T>(DataGridView gridView, params string[] columnsToHide) where T : class
        {
            // gridview options
            gridView.ReadOnly = true;
            gridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            gridView.MultiSelect = false;
            gridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            gridView.AllowUserToAddRows = false;
            gridView.AllowUserToDeleteRows = false;
            gridView.AllowUserToResizeRows = false;
            gridView.AllowUserToResizeColumns = false;


            // bind data from db to gridview
            gridView.DataSource = Controller<BeautySalonEntities, T>.SetBindingList();

            foreach (string column in columnsToHide)
            {
                gridView.Columns[column].Visible = false;
            }

            dataGridViewInventory.DataSource = Controller<BeautySalonEntities, T>.SetBindingList();
            dataGridViewInventory.Refresh();

        }

        private void HandleForm(Form form)
        {

            var result = form.ShowDialog();

            // update the inventory grid
            if (result == DialogResult.OK)
            {
                dataGridViewInventory.DataSource = Controller<BeautySalonEntities, ServiceInventoryView>.GetEntitiesNoTracking();
                dataGridViewInventory.Refresh();
            }

            form.Hide();

        }
    }

}
