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
    public partial class SalesForm : Form
    {
        public SalesForm()
        {
            InitializeComponent();

            this.TopLevel = false;
            this.FormBorderStyle = FormBorderStyle.None;
            this.Visible = true;
            this.Dock = DockStyle.Fill;

            InitializeDataGridView<SalesView>(dataGridViewSales, new string[] { "ProductId" });
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
            //gridView.DataSource = Controller<BeautySalonEntities, T>.SetBindingList();

            //dataGridViewPayment.DataSource = Controller<BeautySalonEntities, T>.SetBindingList();
            //dataGridViewPayment.Refresh();

            dataGridViewSales.DataSource = Controller<BeautySalonEntities, SalesView>.GetEntitiesNoTracking();
            dataGridViewSales.Refresh();

            foreach (string column in columnsToHide)
            {
                gridView.Columns[column].Visible = false;
            }
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            dataGridViewSales.DataSource = Controller<BeautySalonEntities, SalesView>.GetEntitiesNoTracking();
            dataGridViewSales.Refresh();
        }
    }
}
