using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EFControllerUtilities;
using BeautySalonCodeFirstFromDB;
using System.Diagnostics;

namespace BeautySalonApp
{
    public partial class DeleteAppointmentsForm : Form
    {
        public DeleteAppointmentsForm()
        {
            InitializeComponent();

            // Register the event handlers
            this.Load += DeleteAppointmentsForm_Load;
            buttonDeleteAppointment.Click += ButtonDeleteAppointment_Click;

            listBoxAppointments.SelectedIndexChanged += (s, e) => GetAppointments();
        }

        private void ButtonDeleteAppointment_Click(object sender, EventArgs e)
        {
            BeautySalonEntities context = new BeautySalonEntities();
            if(!(listBoxAppointments.SelectedItem is Appointment appointment))
            {
                MessageBox.Show("Please select an appointment to delete.");
                return;
            }
            
            //context.Payments.Remove(context.Payments.Find(appointment.AppointmentId));
            //context.Appointments.Remove(context.Appointments.Find(appointment.AppointmentId));
            if (Controller<BeautySalonEntities, Appointment>.DeleteEntity(appointment) == false)
            {
                MessageBox.Show("Cannot delete appointment from DataBase");
                return;
            }
            this.DialogResult = DialogResult.OK;
            Close();
        }

        private void DeleteAppointmentsForm_Load(object sender, EventArgs e)
        {
            // Bind the listbox with the appointments
            listBoxAppointments.DataSource = Controller<BeautySalonEntities, Appointment>.SetBindingList();

            // No appointment is selected to start
            listBoxAppointments.SelectedIndex = -1;
        }

        private void GetAppointments()
        {
            if (!(listBoxAppointments.SelectedItem is Appointment appointment))
                return;
        }
    }
}
