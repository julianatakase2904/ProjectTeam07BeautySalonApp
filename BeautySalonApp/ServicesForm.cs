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

            InitializeDataGridView<ServicesView>(dataGridViewInventory);
            // new string[] { "ServiceId","ProductId","Appointments" }

            buttonNewEntry.Click += ButtonNewEntry_Click;
            buttonDeleteEntry.Click += ButtonDeleteEntry_Click;
            buttonUpdateEntry.Click += ButtonUpdateEntry_Click;
        }

        private void ButtonUpdateEntry_Click(object sender, EventArgs e)
        {
            AddServiceForm addServiceForm = new AddServiceForm();
            addServiceForm.Show();
        }

        private void ButtonDeleteEntry_Click(object sender, EventArgs e)
        {
            AddServiceForm addServiceForm = new AddServiceForm();
            addServiceForm.Show();
        }

        private void ButtonNewEntry_Click(object sender, EventArgs e)
        {
            AddServiceForm addServiceForm = new AddServiceForm();
            addServiceForm.Show();
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
