using System;
using System.Data;
using System.Windows.Forms;
using EFControllerUtilities;
using BeautySalonCodeFirstFromDB;
using DataTableAccessLayer;

namespace BeautySalonApp
{
    public partial class BackUpForm : Form
    {
        // Access Layer
        private SqlDataTableAccessLayer beautySalonDB;
        // Dataset
        private DataSet beautySalonDataset;

        public BackUpForm()
        {
            InitializeComponent();

            // Load gridviews
            this.Load += BackUpForm_Load;

            beautySalonDB = new SqlDataTableAccessLayer();

            beautySalonDataset = new DataSet()
            {
                DataSetName = "BeautySalonDataSet",
            };

            //get the connection
            string connectionString = beautySalonDB.GetConnectionString("BeautySalonConnection");
            beautySalonDB.OpenConnection(connectionString);

            buttonBackup.Click += (s, e) => beautySalonDB.BackupDataSetToXML(beautySalonDataset);

            this.FormClosing += (s, e) => beautySalonDB.CloseConnection();
            beautySalonDB.CloseConnection();
        }

        private void BackUpForm_Load(object sender, EventArgs e)
        {
            using (BeautySalonEntities context = new BeautySalonEntities())
            {
                context.SeedDatabase();
            }

            InitializeDataGridView<Client>(dataGridViewClients, "Appointments");
            InitializeDataGridView<Employee>(dataGridViewEmployees, "Appointments", "Payments");
            InitializeDataGridView<Inventory>(dataGridViewInventory, "Services");
            InitializeDataGridView<Service>(dataGridViewServices, "Appointments", "Inventory");
            InitializeDataGridView<AppointmentsView>(dataGridViewAppointments);
            //InitializeDataGridView<Payment>(dataGridViewPayments);

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

            /*            // Set event handler to delete row
                        gridView.UserDeletingRow += (s, e) => DeletingRow<T>(s as DataGridView, e);*/

            // Binding the data
            gridView.DataSource = Controller<BeautySalonEntities, T>.SetBindingList();

            foreach (string column in columnsToHide)
            {
                gridView.Columns[column].Visible = false;
            }

        }
    }
}
