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
using System.Diagnostics;



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
            buttonAppointmentsUpdateClient.Click += ButtonAppointmentsUpdateClient_Click;
            buttonAppointmentsSaveAppointment.Click += ButtonAppointmentsSaveAppointment_Click;

            // When the client is selected event handler
            listBoxAppointmentsClients.SelectedIndexChanged += (s, e) => GetClients();
        }

        private void ButtonAppointmentsSaveAppointment_Click(object sender, EventArgs e)
        {
            // Select ClientID
            if (!(listBoxAppointmentsClients.SelectedItem is Client client))
            {
                MessageBox.Show("Please select a Client");
                return;
            }
            int clientId = client.ClientId;
            // Select Professional/EmployeeID
            if (!(listBoxAppointmentsProfessionals.SelectedItem is Employee professional))
            {
                MessageBox.Show("Please select a Professional");
                return;
            }
            int professionalId = professional.EmployeeId;
            // Select ServiceID
            if (!(listBoxAppointmentsSelectService.SelectedItem is Service service))
            {
                MessageBox.Show("Please select a Service");
                return;
            }
            int serviceId = service.ServiceId;
            // Select Date
            string date = dateTimePickerAppointmentsDate.Text;
            // Select time
            string time = listBoxAppointmentsSelectTime.SelectedItem.ToString();

            // Create an appointment
            Appointment appointment = new Appointment()
            {
                AppointmentDate = date,
                AppointmentTime = time,
                ClientId = clientId,
                EmployeeId = professionalId,
                ServiceId = serviceId
            };

            // Add the appointment to DB
            if (Controller<BeautySalonEntities, Appointment>.AddEntity(appointment) == null)
            {
                MessageBox.Show("Cannot add Appointment to database");
                return;
            }
            // Reload gridview
            dataGridViewAppointmentsOfTheDay.DataSource = Controller<BeautySalonEntities, Appointment>.SetBindingList();
            dataGridViewAppointmentsOfTheDay.Refresh();
            
        }


        /// <summary>
        /// Updatin a client to the DB
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonAppointmentsUpdateClient_Click(object sender, EventArgs e)
        {
            if (!(listBoxAppointmentsClients.SelectedItem is Client client)) 
            {
                MessageBox.Show("Client to be updated must be selected");
                return;
            }
            client.ClientFirstName = textBoxAppointmentsClientFirstName.Text;
            client.ClientLastName = textBoxAppointmentsClientLastName.Text;
            client.ClientPhoneNumber = textBoxAppointmentsClientPhoneNumber.Text;
            // Check validity
            if(client.InfoIsValid())
            {
                MessageBox.Show("Client information is missing");
                return;
            }
            // Check if client already exists
            // Store first and last name into string to check if already exits. 
            string clientFirstName = client.ClientFirstName;
            string clientLastName = client.ClientLastName;
            if (clientFirstName != client.ClientFirstName && clientLastName != client.ClientLastName && client.ClientExists())
            {
                MessageBox.Show("Client already exists: " + client.ClientLastName + ", " + client.ClientFirstName);
                return;
            }
            // Update the db
            if(Controller<BeautySalonEntities, Client>.UpdateEntity(client) == false)
            {
                MessageBox.Show("Cannot update client to database");
                return;
            }
            // Reload the listbox again with the updated client
            // Bind the listbox of clients to Clients table
            listBoxAppointmentsClients.DataSource = Controller<BeautySalonEntities, Client>.SetBindingList();
            // No client selected to start
            listBoxAppointmentsClients.SelectedIndex = -1;
            // Reset the clients textbox to blank
            textBoxAppointmentsClientFirstName.ResetText();
            textBoxAppointmentsClientLastName.ResetText();
            textBoxAppointmentsClientPhoneNumber.ResetText();
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
                MessageBox.Show("This client already exits: " + client.ClientLastName + ", " + client.ClientFirstName);
                return;
            }
            // Add the client to DB
            if(Controller<BeautySalonEntities, Client>.AddEntity(client) == null)
            {
                MessageBox.Show("Cannot add client to database");
                return;
            }
            // Reload the listbox again with the new client
            // Bind the listbox of clients to Clients table
            listBoxAppointmentsClients.DataSource = Controller<BeautySalonEntities, Client>.SetBindingList();
            // No client selected to start
            listBoxAppointmentsClients.SelectedIndex = -1;
            // Reset the clients textbox to blank
            textBoxAppointmentsClientFirstName.ResetText();
            textBoxAppointmentsClientLastName.ResetText();
            textBoxAppointmentsClientPhoneNumber.ResetText();
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

            // ** SERVICES listBox
            // Bind the listbox of Services to Service table
            listBoxAppointmentsSelectService.DataSource = Controller<BeautySalonEntities, Service>.SetBindingList();
            // No service selected to start
            listBoxAppointmentsSelectService.SelectedIndex = -1;

            // ** APPOINTMENTS gridview
            InitializeDataGridView<Appointment>(dataGridViewAppointmentsOfTheDay);
            dataGridViewAppointmentsOfTheDay.Columns["Service"].Visible = false;
            dataGridViewAppointmentsOfTheDay.Columns["Payments"].Visible = false;
            dataGridViewAppointmentsOfTheDay.Columns["Client"].Visible = false;
            dataGridViewAppointmentsOfTheDay.Columns["Employee"].Visible = false;

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
            gridView.AllowUserToDeleteRows = true;
            gridView.ReadOnly = true;
            gridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // Set event handler to delete row
            gridView.UserDeletingRow += (s, e) => DeletingRow<T>(s as DataGridView, e);

            // Binding the data
            gridView.DataSource = Controller<BeautySalonEntities, T>.SetBindingList();

            foreach(string column in columnsToHide)
            {
                gridView.Columns[column].Visible = false;
            }

        }

        /// <summary>
        /// This method allow user to delete rows from DataGridView
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="dataGridView"></param>
        /// <param name="e"></param>
        private void DeletingRow<T>(DataGridView dataGridView, DataGridViewRowCancelEventArgs e) where T : class
        {
            // Get item
            T item = e.Row.DataBoundItem as T;

            // Debug
            Debug.WriteLine("Deleting Row: " + e.Row.Index + ", entity: " + typeof(T) + " " + item);

            // Delete item in the DB.
            Controller<BeautySalonEntities, T>.DeleteEntity(item);
            dataGridView.Refresh();
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

        /// <summary>
        /// Find the client ID with 
        /// </summary>
        /// <param name="context"></param>
        /// <param name="clientFirstName"></param>
        /// <param name="clientLastName"></param>
        /// <returns></returns>
        private static Client FindClientId(BeautySalonEntities context, string clientFirstName, string clientLastName, string clientPhoneNumber)
        {
            Client client = context.Clients
                .Where(c => c.ClientFirstName == clientFirstName)
                .Where(c => c.ClientLastName == clientLastName)
                .Where(c => c.ClientPhoneNumber == clientPhoneNumber)
                .FirstOrDefault();
            return client;
        }
    }

    
}
