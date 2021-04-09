using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BeautySalonCodeFirstFromDB;
using EFControllerUtilities;

namespace BeautySalonApp
{
    public partial class InventoryForm : Form
    {
        public InventoryForm()
        {
            InitializeComponent();

            this.TopLevel = false;
            this.FormBorderStyle = FormBorderStyle.None;
            this.Visible = true;
            this.Dock = DockStyle.Fill;
            this.Load += InventoryForm_Load;

            InitializeDataGridView<Inventory>(dataGridViewInventory, new string[] { "ProductId", "Services" });
            dataGridViewInventory.DataSource = Controller<BeautySalonEntities, Inventory>.SetBindingList();
            dataGridViewInventory.Refresh();

            AddOrUpdateInventoryProductForm addInventoryProductForm = new AddOrUpdateInventoryProductForm();

            buttonNewProduct.Click += ButtonNewProduct_Click;
            buttonDeleteProduct.Click += ButtonDeleteProduct_Click;
            buttonUpdateProduct.Click += ButtonUpdateProduct_Click;

        }

        private void InventoryForm_Load(object sender, EventArgs e)
        {

        }


        //EVENT HANDLERS

        private void ButtonUpdateProduct_Click(object sender, EventArgs e)
        {

            try
            {
                var row = dataGridViewInventory.CurrentRow;

                if (row == null)
                {
                    throw new Exception("Please select an entry to update");
                }

                Inventory product = new Inventory()
                {
                    ProductId = (int)row.Cells[0].Value,
                    ProductName = (string)row.Cells[1].Value,
                    ProductQuantity = (int)row.Cells[2].Value
                };

                AddOrUpdateInventoryProductForm updateInventoryProductForm = new AddOrUpdateInventoryProductForm(product);
                HandleForm(updateInventoryProductForm);

            }
            catch (Exception err)
            {

                MessageBox.Show(err.Message);
            }

        }

        private void ButtonDeleteProduct_Click(object sender, EventArgs e)
        {
            try
            {
                var row = dataGridViewInventory.CurrentRow;

                if (row == null)
                {
                    throw new Exception("Please select an entry to update");
                }

                Inventory product = new Inventory()
                {
                    ProductId = (int)row.Cells[0].Value,
                    ProductName = (string)row.Cells[1].Value,
                    ProductQuantity = (int)row.Cells[2].Value
                };

                if (!Controller<BeautySalonEntities, Inventory>.DeleteEntity(product))
                {
                    MessageBox.Show("Unable to delete product from database");
                }
                else
                {

                    dataGridViewInventory.DataSource = Controller<BeautySalonEntities, Inventory>.SetBindingList();
                    dataGridViewInventory.Refresh();

                }

            }
            catch (Exception err)
            {

                MessageBox.Show(err.Message);
            }

        }

        private void ButtonNewProduct_Click(object sender, EventArgs e)
        {

            AddOrUpdateInventoryProductForm addInventoryProductForm = new AddOrUpdateInventoryProductForm();
            HandleForm(addInventoryProductForm);

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
                dataGridViewInventory.DataSource = Controller<BeautySalonEntities, Inventory>.GetEntitiesNoTracking();
                dataGridViewInventory.Refresh();
            }

            form.Hide();

        }

    }
}
