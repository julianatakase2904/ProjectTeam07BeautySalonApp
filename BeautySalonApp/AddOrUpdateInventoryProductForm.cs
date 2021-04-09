using BeautySalonCodeFirstFromDB;
using EFControllerUtilities;
using System;
using System.Windows.Forms;

namespace BeautySalonApp
{
    public partial class AddOrUpdateInventoryProductForm : Form
    {
        private Inventory inventoryProduct;

        public AddOrUpdateInventoryProductForm()
        {
            InitializeComponent();

            buttonAddProduct.Text = "Add Product";

            //Event handler
            buttonAddProduct.Click += ButtonAddProduct_Click;
        }

        public AddOrUpdateInventoryProductForm(Inventory product)
        {
            InitializeComponent();

            this.inventoryProduct = product;
            this.Text = "Update Product";
            buttonAddProduct.Text = "Update Product";
            textBoxProductName.Text = product.ProductName;
            textBoxProductQuantity.Text = product.ProductQuantity.ToString();

            //Event handler
            buttonAddProduct.Click += ButtonAddProduct_Click;

        }


        private void ButtonAddProduct_Click(object sender, EventArgs e)
        {

            try
            {
                bool validNumber = int.TryParse(textBoxProductQuantity.Text, out int productQuantity);

                if (!validNumber)
                {
                    throw new Exception("Enter a vaild number");
                }

                if (productQuantity < 0)
                {
                    throw new Exception("Enter a number greater than 0");
                }

                //get data from form inputs
                Inventory product = new Inventory()
                {
                    ProductName = textBoxProductName.Text,
                    ProductQuantity = productQuantity
                };

                if (this.inventoryProduct == null)
                {
                    AddInventoryProduct(product);
                }
                else
                {
                    //add the productId of the product to be updated in the database
                    product.ProductId = this.inventoryProduct.ProductId;
                    UpdateInventoryProduct(product);
                }

                Close();

            }
            catch (Exception err)
            {

                MessageBox.Show(err.Message);
            };

        }

        private void AddInventoryProduct(Inventory product)
        {

            if (Controller<BeautySalonEntities, Inventory>.AddEntity(product) == null)
            {
                throw new Exception("Error adding product to Database");
            }

        }

        private void UpdateInventoryProduct(Inventory product)
        {

            if (!Controller<BeautySalonEntities, Inventory>.UpdateEntity(product))
            {
                MessageBox.Show("Error adding product to Database");
            }
        }
    }
}
