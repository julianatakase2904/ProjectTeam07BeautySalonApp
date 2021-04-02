using System;
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

            dataGridViewInventory.DataSource = Controller<BeautySalonEntities, Inventory>.GetEntitiesNoTracking();

        }
    }
}
