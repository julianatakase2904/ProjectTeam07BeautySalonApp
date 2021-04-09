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

            InitializeDataGridView<Inventory>(dataGridViewInventory,new string[] {"ProductId","Services"});

            buttonNewProduct.Click += ButtonNewProduct_Click;
            buttonDeleteProduct.Click += ButtonDeleteProduct_Click;
            buttonUpdateProduct.Click += ButtonUpdateProduct_Click;

        }

        private void ButtonUpdateProduct_Click(object sender, EventArgs e)
        {
            var row = dataGridViewInventory.CurrentRow;

            Inventory product = new Inventory()
            {
                ProductId = (int)row.Cells[0].Value,
                ProductName = (string)row.Cells[1].Value,
                ProductQuantity = (int)row.Cells[2].Value
            };

            AddOrUpdateInventoryProductForm addInventoryProductForm = new AddOrUpdateInventoryProductForm(product);
            addInventoryProductForm.Show();

            dataGridViewInventory.DataSource = Controller<BeautySalonEntities, Inventory>.SetBindingList();
            dataGridViewInventory.Refresh();

        }

        private void ButtonDeleteProduct_Click(object sender, EventArgs e)
        {

            var row = dataGridViewInventory.CurrentRow;

            Inventory product = new Inventory()
            {
                ProductId = (int)row.Cells[0].Value,
                ProductName = (string)row.Cells[1].Value,
                ProductQuantity = (int)row.Cells[2].Value
            };

            if (!Controller<BeautySalonEntities, Inventory>.DeleteEntity(product))
            {
                MessageBox.Show("Unable to delete product from database");
            } else
            {

                dataGridViewInventory.DataSource = Controller<BeautySalonEntities, Inventory>.SetBindingList();
                dataGridViewInventory.Refresh();

            }

            //List[0].Cells.List[x].Value
            //0 - productID
            //1 - productName
            //2 - productQuantity


        }

        private void ButtonNewProduct_Click(object sender, EventArgs e)
        {
            AddOrUpdateInventoryProductForm addInventoryProductForm = new AddOrUpdateInventoryProductForm();
            addInventoryProductForm.ShowDialog();

            dataGridViewInventory.DataSource = Controller<BeautySalonEntities, Inventory>.SetBindingList();
            dataGridViewInventory.Refresh();
        }

        //EVENT HANDLERS


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
    }
}
