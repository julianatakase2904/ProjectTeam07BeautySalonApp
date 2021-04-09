using System;
using System.Data;
using System.Windows.Forms;
using EFControllerUtilities;
using BeautySalonCodeFirstFromDB;
using DataTableAccessLayer;
using System.Data.Entity.Infrastructure.Pluralization;

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


            beautySalonDB = new SqlDataTableAccessLayer();

            beautySalonDataset = new DataSet()
            {
                DataSetName = "BeautySalonDataSet",
            };

            //get the connection
            string connectionString = beautySalonDB.GetConnectionString("BeautySalonConnection");
            beautySalonDB.OpenConnection(connectionString);

            // Load gridviews
            this.Load += BackUpForm_Load;

            buttonBackup.Click += (s, e) => beautySalonDB.BackupDataSetToXML(beautySalonDataset);

            this.FormClosing += (s, e) => beautySalonDB.CloseConnection();

        }

        private void BackUpForm_Load(object sender, EventArgs e)
        {
            InitializeDataGridView<Client>(dataGridViewClients, beautySalonDataset, "Appointments");
            InitializeDataGridView<Employee>(dataGridViewEmployees, beautySalonDataset, "Appointments", "Payments");
            InitializeDataGridView<Inventory>(dataGridViewInventory, beautySalonDataset, "Services");
            InitializeDataGridView<Service>(dataGridViewServices, beautySalonDataset, "Appointments", "Inventory");
            InitializeDataGridView<AppointmentsView>(dataGridViewAppointments, beautySalonDataset);
            InitializeDataGridView<Payment>(dataGridViewPaymentsReport, beautySalonDataset, "Appointment", "Employee");
            //InitializeDataGridView<Payment>(dataGridViewPayments);

        }

        /// <summary>
        /// Generic Method to initialize the gridview
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="gridView"></param>
        /// <param name="columnsToHide"></param>
        private void InitializeDataGridView<T>(DataGridView gridView, DataSet dataSet, params string[] columnsToHide) where T : class
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

            string tableName;

            switch (typeof(T).Name)
            {
                case "Inventory":
                    tableName = "Inventory";
                    break;
                case "AppointmentsView":
                    tableName = "AppointmentsView";
                    break;

                default:
                    EnglishPluralizationService pluralize = new EnglishPluralizationService();
                    tableName = pluralize.Pluralize(typeof(T).Name);
                    break;
            }

            DataTable table = beautySalonDB.GetDataTable(tableName);

            dataSet.Tables.Add(table);

        }
    }
}
