
namespace BeautySalonApp
{
    partial class BeautySalonMainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControlBeautySalonApp = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.buttonAppointmentsDeleteAppointment = new System.Windows.Forms.Button();
            this.labelAppointmentsInstructions = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelSystemName = new System.Windows.Forms.Label();
            this.listBoxAppointmentsClients = new System.Windows.Forms.ListBox();
            this.listBoxAppointmentsSelectService = new System.Windows.Forms.ListBox();
            this.buttonAppointmentsAddOrUpdateClient = new System.Windows.Forms.Button();
            this.labelAppointmentsSelectService = new System.Windows.Forms.Label();
            this.buttonAppointmentsSaveAppointment = new System.Windows.Forms.Button();
            this.dataGridViewAppointmentsOfTheDay = new System.Windows.Forms.DataGridView();
            this.labelAppointmentsOfTheDay = new System.Windows.Forms.Label();
            this.listBoxAppointmentsSelectTime = new System.Windows.Forms.ListBox();
            this.labelAppointmentsSelectTime = new System.Windows.Forms.Label();
            this.labelAppointmentsSelectDate = new System.Windows.Forms.Label();
            this.dateTimePickerAppointmentsDate = new System.Windows.Forms.DateTimePicker();
            this.listBoxAppointmentsProfessionals = new System.Windows.Forms.ListBox();
            this.labelAppointmentsSelectProfessional = new System.Windows.Forms.Label();
            this.labelAppointmentsForm = new System.Windows.Forms.Label();
            this.tabPageInventory = new System.Windows.Forms.TabPage();
            this.tabPageServices = new System.Windows.Forms.TabPage();
            this.tabControlBeautySalonApp.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAppointmentsOfTheDay)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControlBeautySalonApp
            // 
            this.tabControlBeautySalonApp.Controls.Add(this.tabPage1);
            this.tabControlBeautySalonApp.Controls.Add(this.tabPageInventory);
            this.tabControlBeautySalonApp.Controls.Add(this.tabPageServices);
            this.tabControlBeautySalonApp.Location = new System.Drawing.Point(4, 3);
            this.tabControlBeautySalonApp.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabControlBeautySalonApp.Name = "tabControlBeautySalonApp";
            this.tabControlBeautySalonApp.SelectedIndex = 0;
            this.tabControlBeautySalonApp.Size = new System.Drawing.Size(1425, 1032);
            this.tabControlBeautySalonApp.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.PaleTurquoise;
            this.tabPage1.Controls.Add(this.buttonAppointmentsDeleteAppointment);
            this.tabPage1.Controls.Add(this.labelAppointmentsInstructions);
            this.tabPage1.Controls.Add(this.pictureBox1);
            this.tabPage1.Controls.Add(this.labelSystemName);
            this.tabPage1.Controls.Add(this.listBoxAppointmentsClients);
            this.tabPage1.Controls.Add(this.listBoxAppointmentsSelectService);
            this.tabPage1.Controls.Add(this.buttonAppointmentsAddOrUpdateClient);
            this.tabPage1.Controls.Add(this.labelAppointmentsSelectService);
            this.tabPage1.Controls.Add(this.buttonAppointmentsSaveAppointment);
            this.tabPage1.Controls.Add(this.dataGridViewAppointmentsOfTheDay);
            this.tabPage1.Controls.Add(this.labelAppointmentsOfTheDay);
            this.tabPage1.Controls.Add(this.listBoxAppointmentsSelectTime);
            this.tabPage1.Controls.Add(this.labelAppointmentsSelectTime);
            this.tabPage1.Controls.Add(this.labelAppointmentsSelectDate);
            this.tabPage1.Controls.Add(this.dateTimePickerAppointmentsDate);
            this.tabPage1.Controls.Add(this.listBoxAppointmentsProfessionals);
            this.tabPage1.Controls.Add(this.labelAppointmentsSelectProfessional);
            this.tabPage1.Controls.Add(this.labelAppointmentsForm);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage1.Size = new System.Drawing.Size(1417, 999);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Appointments";
            // 
            // buttonAppointmentsDeleteAppointment
            // 
            this.buttonAppointmentsDeleteAppointment.Location = new System.Drawing.Point(1234, 842);
            this.buttonAppointmentsDeleteAppointment.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonAppointmentsDeleteAppointment.Name = "buttonAppointmentsDeleteAppointment";
            this.buttonAppointmentsDeleteAppointment.Size = new System.Drawing.Size(136, 58);
            this.buttonAppointmentsDeleteAppointment.TabIndex = 19;
            this.buttonAppointmentsDeleteAppointment.Text = "Delete Appointments";
            this.buttonAppointmentsDeleteAppointment.UseVisualStyleBackColor = true;
            // 
            // labelAppointmentsInstructions
            // 
            this.labelAppointmentsInstructions.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelAppointmentsInstructions.Location = new System.Drawing.Point(1196, 92);
            this.labelAppointmentsInstructions.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelAppointmentsInstructions.Name = "labelAppointmentsInstructions";
            this.labelAppointmentsInstructions.Size = new System.Drawing.Size(154, 114);
            this.labelAppointmentsInstructions.TabIndex = 18;
            this.labelAppointmentsInstructions.Text = "To Save an Appointment, select a client, date, Professional Name, Time, and Servi" +
    "ce. ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::BeautySalonApp.Properties.Resources.BeautySalon12;
            this.pictureBox1.Location = new System.Drawing.Point(165, 29);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(120, 135);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // labelSystemName
            // 
            this.labelSystemName.AutoSize = true;
            this.labelSystemName.Font = new System.Drawing.Font("Mistral", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSystemName.Location = new System.Drawing.Point(424, 68);
            this.labelSystemName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelSystemName.Name = "labelSystemName";
            this.labelSystemName.Size = new System.Drawing.Size(576, 57);
            this.labelSystemName.TabIndex = 16;
            this.labelSystemName.Text = "Beauty Salon - Management System";
            // 
            // listBoxAppointmentsClients
            // 
            this.listBoxAppointmentsClients.FormattingEnabled = true;
            this.listBoxAppointmentsClients.ItemHeight = 20;
            this.listBoxAppointmentsClients.Location = new System.Drawing.Point(72, 291);
            this.listBoxAppointmentsClients.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.listBoxAppointmentsClients.Name = "listBoxAppointmentsClients";
            this.listBoxAppointmentsClients.Size = new System.Drawing.Size(248, 284);
            this.listBoxAppointmentsClients.TabIndex = 15;
            // 
            // listBoxAppointmentsSelectService
            // 
            this.listBoxAppointmentsSelectService.FormattingEnabled = true;
            this.listBoxAppointmentsSelectService.ItemHeight = 20;
            this.listBoxAppointmentsSelectService.Location = new System.Drawing.Point(1110, 292);
            this.listBoxAppointmentsSelectService.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.listBoxAppointmentsSelectService.Name = "listBoxAppointmentsSelectService";
            this.listBoxAppointmentsSelectService.Size = new System.Drawing.Size(210, 284);
            this.listBoxAppointmentsSelectService.TabIndex = 14;
            // 
            // buttonAppointmentsAddOrUpdateClient
            // 
            this.buttonAppointmentsAddOrUpdateClient.Location = new System.Drawing.Point(350, 423);
            this.buttonAppointmentsAddOrUpdateClient.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonAppointmentsAddOrUpdateClient.Name = "buttonAppointmentsAddOrUpdateClient";
            this.buttonAppointmentsAddOrUpdateClient.Size = new System.Drawing.Size(129, 66);
            this.buttonAppointmentsAddOrUpdateClient.TabIndex = 6;
            this.buttonAppointmentsAddOrUpdateClient.Text = "Add or Update Client";
            this.buttonAppointmentsAddOrUpdateClient.UseVisualStyleBackColor = true;
            // 
            // labelAppointmentsSelectService
            // 
            this.labelAppointmentsSelectService.AutoSize = true;
            this.labelAppointmentsSelectService.Location = new System.Drawing.Point(1106, 266);
            this.labelAppointmentsSelectService.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelAppointmentsSelectService.Name = "labelAppointmentsSelectService";
            this.labelAppointmentsSelectService.Size = new System.Drawing.Size(110, 20);
            this.labelAppointmentsSelectService.TabIndex = 13;
            this.labelAppointmentsSelectService.Text = "Select Service";
            // 
            // buttonAppointmentsSaveAppointment
            // 
            this.buttonAppointmentsSaveAppointment.Location = new System.Drawing.Point(1234, 708);
            this.buttonAppointmentsSaveAppointment.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonAppointmentsSaveAppointment.Name = "buttonAppointmentsSaveAppointment";
            this.buttonAppointmentsSaveAppointment.Size = new System.Drawing.Size(136, 58);
            this.buttonAppointmentsSaveAppointment.TabIndex = 10;
            this.buttonAppointmentsSaveAppointment.Text = "Save Appointments";
            this.buttonAppointmentsSaveAppointment.UseVisualStyleBackColor = true;
            // 
            // dataGridViewAppointmentsOfTheDay
            // 
            this.dataGridViewAppointmentsOfTheDay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAppointmentsOfTheDay.Location = new System.Drawing.Point(46, 652);
            this.dataGridViewAppointmentsOfTheDay.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridViewAppointmentsOfTheDay.Name = "dataGridViewAppointmentsOfTheDay";
            this.dataGridViewAppointmentsOfTheDay.RowHeadersWidth = 24;
            this.dataGridViewAppointmentsOfTheDay.Size = new System.Drawing.Size(1146, 303);
            this.dataGridViewAppointmentsOfTheDay.TabIndex = 9;
            // 
            // labelAppointmentsOfTheDay
            // 
            this.labelAppointmentsOfTheDay.AutoSize = true;
            this.labelAppointmentsOfTheDay.Location = new System.Drawing.Point(42, 611);
            this.labelAppointmentsOfTheDay.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelAppointmentsOfTheDay.Name = "labelAppointmentsOfTheDay";
            this.labelAppointmentsOfTheDay.Size = new System.Drawing.Size(232, 20);
            this.labelAppointmentsOfTheDay.TabIndex = 8;
            this.labelAppointmentsOfTheDay.Text = "APPOINTMENTS OF THE DAY";
            // 
            // listBoxAppointmentsSelectTime
            // 
            this.listBoxAppointmentsSelectTime.FormattingEnabled = true;
            this.listBoxAppointmentsSelectTime.ItemHeight = 20;
            this.listBoxAppointmentsSelectTime.Location = new System.Drawing.Point(862, 292);
            this.listBoxAppointmentsSelectTime.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.listBoxAppointmentsSelectTime.Name = "listBoxAppointmentsSelectTime";
            this.listBoxAppointmentsSelectTime.Size = new System.Drawing.Size(110, 284);
            this.listBoxAppointmentsSelectTime.TabIndex = 7;
            // 
            // labelAppointmentsSelectTime
            // 
            this.labelAppointmentsSelectTime.AutoSize = true;
            this.labelAppointmentsSelectTime.Location = new System.Drawing.Point(858, 266);
            this.labelAppointmentsSelectTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelAppointmentsSelectTime.Name = "labelAppointmentsSelectTime";
            this.labelAppointmentsSelectTime.Size = new System.Drawing.Size(92, 20);
            this.labelAppointmentsSelectTime.TabIndex = 6;
            this.labelAppointmentsSelectTime.Text = "Select Time";
            // 
            // labelAppointmentsSelectDate
            // 
            this.labelAppointmentsSelectDate.AutoSize = true;
            this.labelAppointmentsSelectDate.Location = new System.Drawing.Point(549, 266);
            this.labelAppointmentsSelectDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelAppointmentsSelectDate.Name = "labelAppointmentsSelectDate";
            this.labelAppointmentsSelectDate.Size = new System.Drawing.Size(93, 20);
            this.labelAppointmentsSelectDate.TabIndex = 5;
            this.labelAppointmentsSelectDate.Text = "Select Date";
            // 
            // dateTimePickerAppointmentsDate
            // 
            this.dateTimePickerAppointmentsDate.CustomFormat = "dd-MMM-yyyy";
            this.dateTimePickerAppointmentsDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerAppointmentsDate.Location = new System.Drawing.Point(554, 292);
            this.dateTimePickerAppointmentsDate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dateTimePickerAppointmentsDate.Name = "dateTimePickerAppointmentsDate";
            this.dateTimePickerAppointmentsDate.Size = new System.Drawing.Size(184, 26);
            this.dateTimePickerAppointmentsDate.TabIndex = 4;
            // 
            // listBoxAppointmentsProfessionals
            // 
            this.listBoxAppointmentsProfessionals.FormattingEnabled = true;
            this.listBoxAppointmentsProfessionals.ItemHeight = 20;
            this.listBoxAppointmentsProfessionals.Location = new System.Drawing.Point(554, 371);
            this.listBoxAppointmentsProfessionals.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.listBoxAppointmentsProfessionals.Name = "listBoxAppointmentsProfessionals";
            this.listBoxAppointmentsProfessionals.Size = new System.Drawing.Size(184, 204);
            this.listBoxAppointmentsProfessionals.TabIndex = 3;
            // 
            // labelAppointmentsSelectProfessional
            // 
            this.labelAppointmentsSelectProfessional.AutoSize = true;
            this.labelAppointmentsSelectProfessional.Location = new System.Drawing.Point(549, 343);
            this.labelAppointmentsSelectProfessional.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelAppointmentsSelectProfessional.Name = "labelAppointmentsSelectProfessional";
            this.labelAppointmentsSelectProfessional.Size = new System.Drawing.Size(145, 20);
            this.labelAppointmentsSelectProfessional.TabIndex = 2;
            this.labelAppointmentsSelectProfessional.Text = "Select Professional";
            // 
            // labelAppointmentsForm
            // 
            this.labelAppointmentsForm.AutoSize = true;
            this.labelAppointmentsForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAppointmentsForm.Location = new System.Drawing.Point(597, 146);
            this.labelAppointmentsForm.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelAppointmentsForm.Name = "labelAppointmentsForm";
            this.labelAppointmentsForm.Size = new System.Drawing.Size(205, 29);
            this.labelAppointmentsForm.TabIndex = 1;
            this.labelAppointmentsForm.Text = "APPOINTMENTS";
            // 
            // tabPageInventory
            // 
            this.tabPageInventory.Location = new System.Drawing.Point(4, 29);
            this.tabPageInventory.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPageInventory.Name = "tabPageInventory";
            this.tabPageInventory.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPageInventory.Size = new System.Drawing.Size(1417, 999);
            this.tabPageInventory.TabIndex = 1;
            this.tabPageInventory.Text = "Inventory";
            this.tabPageInventory.UseVisualStyleBackColor = true;
            // 
            // tabPageServices
            // 
            this.tabPageServices.Location = new System.Drawing.Point(4, 29);
            this.tabPageServices.Name = "tabPageServices";
            this.tabPageServices.Size = new System.Drawing.Size(1417, 999);
            this.tabPageServices.TabIndex = 2;
            this.tabPageServices.Text = "Services";
            this.tabPageServices.UseVisualStyleBackColor = true;
            // 
            // BeautySalonMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1436, 1042);
            this.Controls.Add(this.tabControlBeautySalonApp);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "BeautySalonMainForm";
            this.Text = "Form1";
            this.tabControlBeautySalonApp.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAppointmentsOfTheDay)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlBeautySalonApp;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPageInventory;
        private System.Windows.Forms.Button buttonAppointmentsSaveAppointment;
        private System.Windows.Forms.DataGridView dataGridViewAppointmentsOfTheDay;
        private System.Windows.Forms.Label labelAppointmentsOfTheDay;
        private System.Windows.Forms.ListBox listBoxAppointmentsSelectTime;
        private System.Windows.Forms.Label labelAppointmentsSelectTime;
        private System.Windows.Forms.Label labelAppointmentsSelectDate;
        private System.Windows.Forms.DateTimePicker dateTimePickerAppointmentsDate;
        private System.Windows.Forms.ListBox listBoxAppointmentsProfessionals;
        private System.Windows.Forms.Label labelAppointmentsSelectProfessional;
        private System.Windows.Forms.Label labelAppointmentsForm;
        private System.Windows.Forms.ListBox listBoxAppointmentsSelectService;
        private System.Windows.Forms.Label labelAppointmentsSelectService;
        private System.Windows.Forms.Button buttonAppointmentsAddOrUpdateClient;
        private System.Windows.Forms.ListBox listBoxAppointmentsClients;
        private System.Windows.Forms.Label labelSystemName;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelAppointmentsInstructions;
        private System.Windows.Forms.Button buttonAppointmentsDeleteAppointment;
        private System.Windows.Forms.TabPage tabPageServices;
    }
}

