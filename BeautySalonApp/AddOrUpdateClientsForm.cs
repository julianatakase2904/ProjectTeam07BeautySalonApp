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
using BeautySalonValidation;

namespace BeautySalonApp
{
    public partial class AddOrUpdateClientsForm : Form
    {
        public AddOrUpdateClientsForm()
        {
            InitializeComponent();

            // Register the event handlers
            this.Load += AddOrUpdateClientsForm_Load;
            buttonAddClient.Click += ButtonAddClient_Click;
            buttonUpdateClient.Click += ButtonUpdateClient_Click;

            // Event Handler for listbox
            listBoxClients.SelectedIndexChanged += (s, e) => GetClients();
        }

        /// <summary>
        /// Updates the client into DB
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonUpdateClient_Click(object sender, EventArgs e)
        {
            // The client must be selected
            if (!(listBoxClients.SelectedItem is Client client))
            {
                MessageBox.Show("Client must be selected.");
                return;
            }

            // Update client
            client.ClientFirstName = textBoxClientFirstName.Text;
            client.ClientLastName = textBoxClientLastName.Text;
            client.ClientPhoneNumber = textBoxClientPhoneNumber.Text;
            
            // Validade
            if(client.InfoIsValid())
            {
                MessageBox.Show("Client information is missing. Phone number must have 10 digits.");
                return;
            }

            // Update the DB
            if(Controller<BeautySalonEntities, Client>.UpdateEntity(client) == false)
            {
                MessageBox.Show("Cannot update client to Database.");
                return;
            }

            this.DialogResult = DialogResult.OK;
            Close();
        }

        /// <summary>
        /// Add a client to DB
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonAddClient_Click(object sender, EventArgs e)
        {
            // Get client information from textboxes
            Client client = new Client()
            {
                ClientFirstName = textBoxClientFirstName.Text,
                ClientLastName = textBoxClientLastName.Text,
                ClientPhoneNumber = textBoxClientPhoneNumber.Text
            };

            // Validate
            if (client.InfoIsValid())
            {
                MessageBox.Show("Client Information is missing.");
                return;
            }

            // Register client to DB
            if(Controller<BeautySalonEntities, Client>.AddEntity(client) == null)
            {
                MessageBox.Show("Cannot add client to Database.");
                return;
            }

            this.DialogResult = DialogResult.OK;
            Close();
        }

        /// <summary>
        /// Initially creates the form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddOrUpdateClientsForm_Load(object sender, EventArgs e)
        {
            // Bind the listbox of clients to Clients table
            listBoxClients.DataSource = Controller<BeautySalonEntities, Client>.SetBindingList();
            // No client selected to start
            listBoxClients.SelectedIndex = -1;
            // Set the textboxes to blank
            textBoxClientFirstName.ResetText();
            textBoxClientLastName.ResetText();
            textBoxClientPhoneNumber.ResetText();
        }

        /// <summary>
        /// Get the selected client from listbox
        /// </summary>
        private void GetClients()
        {
            if (!(listBoxClients.SelectedItem is Client client))
                return;
            textBoxClientFirstName.Text = client.ClientFirstName;
            textBoxClientLastName.Text = client.ClientLastName;
            textBoxClientPhoneNumber.Text = client.ClientPhoneNumber;
        }
    }
}
