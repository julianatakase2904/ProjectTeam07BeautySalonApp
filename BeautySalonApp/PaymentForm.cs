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
    public partial class PaymentForm : Form
    {
        public PaymentForm()
        {
            InitializeComponent();

            this.TopLevel = false;
            this.FormBorderStyle = FormBorderStyle.None;
            this.Visible = true;
            this.Dock = DockStyle.Fill;

            InitializeDataGridView<Payment>(dataGridViewPayment,new string[] { "PaymentId", "EmployeeId", "AppointmentId" });

            buttonNewPayment.Click += ButtonNewPayment_Click;
            buttonDeletePayment.Click += ButtonDeletePayment_Click;
            buttonUpdatePayment.Click += ButtonUpdatePayment_Click;

        }

        private void ButtonUpdatePayment_Click(object sender, EventArgs e)
        {
            var row = dataGridViewPayment.CurrentRow;
            if (row == null) return;

            Payment payment = new Payment()
            {
                PaymentId = (int)row.Cells[10].Value,
                Tax = (decimal)row.Cells[8].Value,
                Paid = (decimal)row.Cells[9].Value,
            };

            AddOrUpdatePaymentForm addUpdatePaymentForm = new AddOrUpdatePaymentForm(payment);
            addUpdatePaymentForm.ShowDialog();

            dataGridViewPayment.DataSource = Controller<BeautySalonEntities, PaymentsView>.GetEntitiesNoTracking();
            dataGridViewPayment.Refresh();
        }

        private void ButtonDeletePayment_Click(object sender, EventArgs e)
        {
            var row = dataGridViewPayment.CurrentRow;
            if (row == null) return;

            DialogResult ret = MessageBox.Show("Are you sure to delete this record?", "Beauty Salon", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (ret != DialogResult.Yes) return;

            Payment payment = new Payment()
            {
                PaymentId = (int)row.Cells[10].Value,
                Tax = (decimal)row.Cells[8].Value,
                Paid = (decimal)row.Cells[9].Value,
            };

            if (!Controller<BeautySalonEntities, Payment>.DeleteEntity(payment))
            {
                MessageBox.Show("Unable to delete product from database");
            } 
            else
            {
                dataGridViewPayment.DataSource = Controller<BeautySalonEntities, PaymentsView>.GetEntitiesNoTracking();
                dataGridViewPayment.Refresh();
            }
        }

        private void ButtonNewPayment_Click(object sender, EventArgs e)
        {
            AddOrUpdatePaymentForm addPaymentForm = new AddOrUpdatePaymentForm();
            addPaymentForm.ShowDialog();

            dataGridViewPayment.DataSource = Controller<BeautySalonEntities, PaymentsView>.GetEntitiesNoTracking();
            dataGridViewPayment.Refresh();
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

            //dataGridViewPayment.DataSource = Controller<BeautySalonEntities, T>.SetBindingList();
            //dataGridViewPayment.Refresh();

            dataGridViewPayment.DataSource = Controller<BeautySalonEntities, PaymentsView>.GetEntitiesNoTracking();
            dataGridViewPayment.Refresh();

        }

        private void PaymentForm_Load(object sender, EventArgs e)
        {

        }
    }
}
