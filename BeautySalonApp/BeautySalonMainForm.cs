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
using BeautySalonValidation;



namespace BeautySalonApp
{
    public partial class BeautySalonMainForm : Form
    {
        public BeautySalonMainForm()
        {
            InitializeComponent();

            // Set the application name
            this.Text = "Beauty Salon Application";

            // Register event handlers
            this.Load += BeautySalonMainForm_Load;
            buttonAppointmentsAddClient.Click += ButtonAppointmentsAddClient_Click;

            // When the client is selected event handler
            listBoxAppointmentsClients.SelectedIndexChanged += (s, e) => GetClients();
        }

        /// <summary>
        /// Adding a new client to the DB
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonAppointmentsAddClient_Click(object sender, EventArgs e)
        {
            // Getting input from textbox and creating a new client object
            Client client = new Client()
            {
                ClientFirstName = textBoxAppointmentsClientFirstName.Text,
                ClientLastName = textBoxAppointmentsClientLastName.Text,
                ClientPhoneNumber = textBoxAppointmentsClientPhoneNumber.Text
            };

            // Check validity
            if(client.InfoIsValid())
            {
                MessageBox.Show("Client Information is Missing");
                return;
            }
            // Check if the Client already exists
            if(client.ClientExists())
            {
                MessageBox.Show("This client already exits: " + client.ClientLastName + ", " + client.ClientLastName);
                return;
            }
            // Add the client to DB
            if(Controller<BeautySalonEntities, Client>.AddEntity(client) == null)
            {
                MessageBox.Show("Cannot add client to database");
                return;
            }

        }

        /// <summary>
        /// This method will load the controls
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void BeautySalonMainForm_Load(object sender, EventArgs e)
        {
            using (BeautySalonEntities context = new BeautySalonEntities())
            {
                context.SeedDatabase();
            }

            // ** CLIENTS Search and Add
            // Bind the listbox of clients to Clients table
            listBoxAppointmentsClients.DataSource = Controller<BeautySalonEntities, Client>.SetBindingList();
            // No client selected to start
            listBoxAppointmentsClients.SelectedIndex = -1;
            // Reset the clients textbox to blank
            textBoxAppointmentsClientFirstName.ResetText();
            textBoxAppointmentsClientLastName.ResetText();
            textBoxAppointmentsClientPhoneNumber.ResetText();

            // ** PROFESSIONALS/EMPLOYEES listBox
            // Bind the listbox of professionals/employees to Employees table
            listBoxAppointmentsProfessionals.DataSource = Controller<BeautySalonEntities, Employee>.SetBindingList();
            // No professional/employee selected to start
            listBoxAppointmentsProfessionals.SelectedIndex = -1;

            // ** APPOINTMENT TIME listBox
            // Declare array of appointmentTimes
            string[] appointmentTimes = {"9:00am", "10:00am", "11:00am", "12:00am", "1:00pm",
            "2:00pm", "3:00pm", "4:00pm", "5:00pm", "6:00pm", "7:00pm"};
            // Add array elements to listbox
            listBoxAppointmentsSelectTime.Items.Clear();
            for (int i = 0; i < appointmentTimes.Length; i++)
            {
                listBoxAppointmentsSelectTime.Items.Add(appointmentTimes[i]);
            }
        }

        /// <summary>
        /// This method gets the selected client and fill the textbox with client's info
        /// </summary>
        private void GetClients()
        {
            if(!(listBoxAppointmentsClients.SelectedItem is Client client))
            {
                return;
            }
            textBoxAppointmentsClientFirstName.Text = client.ClientFirstName;
            textBoxAppointmentsClientLastName.Text = client.ClientLastName;
            textBoxAppointmentsClientPhoneNumber.Text = client.ClientPhoneNumber;
        }
    }

    
}
