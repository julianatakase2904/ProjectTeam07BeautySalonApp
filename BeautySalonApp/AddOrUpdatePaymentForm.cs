using System;
using BeautySalonCodeFirstFromDB;
using EFControllerUtilities;
using BeautySalonValidation;
using System.Diagnostics;
using System.Windows.Forms;
using System.Collections.Generic;

namespace BeautySalonApp
{
    public partial class AddOrUpdatePaymentForm : Form
    {
        private Payment mPayment = null;

        public AddOrUpdatePaymentForm()
        {
            InitializeComponent();
        }

        public AddOrUpdatePaymentForm(Payment payment)
        {
            InitializeComponent();
            mPayment = payment;
            this.Text = "Update Payment";
            textBoxTax.Text = payment.Tax.ToString();
        }

        private void AddOrUpdatePaymentForm_Load(object sender, EventArgs e)
        {
            InitializeDataGridView<Appointment>(dataGridViewAppointmentsOfTheDay);
        }

        /// <summary>
        /// Generic Method to initialize the gridview
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="gridView"></param>
        /// <param name="columnsToHide"></param>
        private void InitializeDataGridView<T>(DataGridView gridView, params string[] columnsToHide) where T : class
        {
            // Set up gridview
            gridView.AllowUserToAddRows = false;
            gridView.AllowUserToDeleteRows = false;
            gridView.ReadOnly = true;
            gridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            /*  // Set event handler to delete row
            gridView.UserDeletingRow += (s, e) => DeletingRow<T>(s as DataGridView, e);*/

            // Binding the data
            gridView.DataSource = Controller<BeautySalonEntities, T>.SetBindingList();

            foreach (string column in columnsToHide)
            {
                gridView.Columns[column].Visible = false;
            }

            dataGridViewAppointmentsOfTheDay.DataSource = Controller<BeautySalonEntities, AppointmentsView>.GetEntitiesNoTracking();
            dataGridViewAppointmentsOfTheDay.Refresh();

        }

        private void btnOkay_Click(object sender, EventArgs e)
        {
            if (dataGridViewAppointmentsOfTheDay.SelectedRows.Count < 1) return;

            int nRow = dataGridViewAppointmentsOfTheDay.SelectedRows[0].Index;
            List<AppointmentsView> appointmentLists = dataGridViewAppointmentsOfTheDay.DataSource as List<AppointmentsView>;
            AppointmentsView appointment = appointmentLists[nRow];

            int AppointmentId = appointment.AppointmentId;
            int EmployeeId = appointment.EmployeeId;
            
            decimal tax = 0;
            try
            {
                tax = Convert.ToDecimal(textBoxTax.Text);
            } catch(Exception)
            {
                MessageBox.Show("Please input valid value for tax!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            decimal serviceFee = appointment.ServicePrice;
            // Create a payment
            Payment payment = new Payment()
            {
                EmployeeId = EmployeeId,
                AppointmentId = AppointmentId,
                Tax = tax,
                Paid = serviceFee + tax
            };

            if (mPayment == null)
            {
                if (payment.PaymentExists())
                {
                    MessageBox.Show("There is a payment already exists.");
                    return;
                }

                // Add the appointment to DB
                if (Controller<BeautySalonEntities, Payment>.AddEntity(payment) == null)
                {
                    MessageBox.Show("Cannot add a payment to database");
                    return;
                }
            } else // modify
            {
                payment.PaymentId = mPayment.PaymentId;
                if (!Controller<BeautySalonEntities, Payment>.UpdateEntity(payment))
                {
                    MessageBox.Show("Error adding product to Database");
                }
            }

            // Close the form
            this.DialogResult = DialogResult.OK;
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            // Close the form
            this.DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
