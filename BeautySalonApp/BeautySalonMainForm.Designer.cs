
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
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabControlBeautySalonApp.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAppointmentsOfTheDay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControlBeautySalonApp
            // 
            this.tabControlBeautySalonApp.Controls.Add(this.tabPage1);
            this.tabControlBeautySalonApp.Controls.Add(this.tabPage2);
            this.tabControlBeautySalonApp.Location = new System.Drawing.Point(3, 2);
            this.tabControlBeautySalonApp.Name = "tabControlBeautySalonApp";
            this.tabControlBeautySalonApp.SelectedIndex = 0;
            this.tabControlBeautySalonApp.Size = new System.Drawing.Size(950, 671);
            this.tabControlBeautySalonApp.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.PaleTurquoise;
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
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tabPage1.Size = new System.Drawing.Size(942, 645);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Appointments";
            // 
            // labelSystemName
            // 
            this.labelSystemName.AutoSize = true;
            this.labelSystemName.Font = new System.Drawing.Font("Mistral", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSystemName.Location = new System.Drawing.Point(283, 44);
            this.labelSystemName.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.labelSystemName.Name = "labelSystemName";
            this.labelSystemName.Size = new System.Drawing.Size(385, 38);
            this.labelSystemName.TabIndex = 16;
            this.labelSystemName.Text = "Beauty Salon - Management System";
            // 
            // listBoxAppointmentsClients
            // 
            this.listBoxAppointmentsClients.FormattingEnabled = true;
            this.listBoxAppointmentsClients.Location = new System.Drawing.Point(48, 189);
            this.listBoxAppointmentsClients.Name = "listBoxAppointmentsClients";
            this.listBoxAppointmentsClients.Size = new System.Drawing.Size(167, 186);
            this.listBoxAppointmentsClients.TabIndex = 15;
            // 
            // listBoxAppointmentsSelectService
            // 
            this.listBoxAppointmentsSelectService.FormattingEnabled = true;
            this.listBoxAppointmentsSelectService.Location = new System.Drawing.Point(740, 190);
            this.listBoxAppointmentsSelectService.Name = "listBoxAppointmentsSelectService";
            this.listBoxAppointmentsSelectService.Size = new System.Drawing.Size(141, 186);
            this.listBoxAppointmentsSelectService.TabIndex = 14;
            // 
            // buttonAppointmentsAddOrUpdateClient
            // 
            this.buttonAppointmentsAddOrUpdateClient.Location = new System.Drawing.Point(233, 275);
            this.buttonAppointmentsAddOrUpdateClient.Name = "buttonAppointmentsAddOrUpdateClient";
            this.buttonAppointmentsAddOrUpdateClient.Size = new System.Drawing.Size(86, 43);
            this.buttonAppointmentsAddOrUpdateClient.TabIndex = 6;
            this.buttonAppointmentsAddOrUpdateClient.Text = "Add or Update Client";
            this.buttonAppointmentsAddOrUpdateClient.UseVisualStyleBackColor = true;
            // 
            // labelAppointmentsSelectService
            // 
            this.labelAppointmentsSelectService.AutoSize = true;
            this.labelAppointmentsSelectService.Location = new System.Drawing.Point(737, 173);
            this.labelAppointmentsSelectService.Name = "labelAppointmentsSelectService";
            this.labelAppointmentsSelectService.Size = new System.Drawing.Size(76, 13);
            this.labelAppointmentsSelectService.TabIndex = 13;
            this.labelAppointmentsSelectService.Text = "Select Service";
            // 
            // buttonAppointmentsSaveAppointment
            // 
            this.buttonAppointmentsSaveAppointment.Location = new System.Drawing.Point(819, 500);
            this.buttonAppointmentsSaveAppointment.Name = "buttonAppointmentsSaveAppointment";
            this.buttonAppointmentsSaveAppointment.Size = new System.Drawing.Size(91, 38);
            this.buttonAppointmentsSaveAppointment.TabIndex = 10;
            this.buttonAppointmentsSaveAppointment.Text = "Save Appointments";
            this.buttonAppointmentsSaveAppointment.UseVisualStyleBackColor = true;
            // 
            // dataGridViewAppointmentsOfTheDay
            // 
            this.dataGridViewAppointmentsOfTheDay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAppointmentsOfTheDay.Location = new System.Drawing.Point(31, 424);
            this.dataGridViewAppointmentsOfTheDay.Name = "dataGridViewAppointmentsOfTheDay";
            this.dataGridViewAppointmentsOfTheDay.RowHeadersWidth = 24;
            this.dataGridViewAppointmentsOfTheDay.Size = new System.Drawing.Size(764, 197);
            this.dataGridViewAppointmentsOfTheDay.TabIndex = 9;
            // 
            // labelAppointmentsOfTheDay
            // 
            this.labelAppointmentsOfTheDay.AutoSize = true;
            this.labelAppointmentsOfTheDay.Location = new System.Drawing.Point(28, 397);
            this.labelAppointmentsOfTheDay.Name = "labelAppointmentsOfTheDay";
            this.labelAppointmentsOfTheDay.Size = new System.Drawing.Size(159, 13);
            this.labelAppointmentsOfTheDay.TabIndex = 8;
            this.labelAppointmentsOfTheDay.Text = "APPOINTMENTS OF THE DAY";
            // 
            // listBoxAppointmentsSelectTime
            // 
            this.listBoxAppointmentsSelectTime.FormattingEnabled = true;
            this.listBoxAppointmentsSelectTime.Location = new System.Drawing.Point(575, 190);
            this.listBoxAppointmentsSelectTime.Name = "listBoxAppointmentsSelectTime";
            this.listBoxAppointmentsSelectTime.Size = new System.Drawing.Size(75, 186);
            this.listBoxAppointmentsSelectTime.TabIndex = 7;
            // 
            // labelAppointmentsSelectTime
            // 
            this.labelAppointmentsSelectTime.AutoSize = true;
            this.labelAppointmentsSelectTime.Location = new System.Drawing.Point(572, 173);
            this.labelAppointmentsSelectTime.Name = "labelAppointmentsSelectTime";
            this.labelAppointmentsSelectTime.Size = new System.Drawing.Size(63, 13);
            this.labelAppointmentsSelectTime.TabIndex = 6;
            this.labelAppointmentsSelectTime.Text = "Select Time";
            // 
            // labelAppointmentsSelectDate
            // 
            this.labelAppointmentsSelectDate.AutoSize = true;
            this.labelAppointmentsSelectDate.Location = new System.Drawing.Point(366, 173);
            this.labelAppointmentsSelectDate.Name = "labelAppointmentsSelectDate";
            this.labelAppointmentsSelectDate.Size = new System.Drawing.Size(97, 13);
            this.labelAppointmentsSelectDate.TabIndex = 5;
            this.labelAppointmentsSelectDate.Text = "Select Professional";
            // 
            // dateTimePickerAppointmentsDate
            // 
            this.dateTimePickerAppointmentsDate.CustomFormat = "dd-MMM-yyyy";
            this.dateTimePickerAppointmentsDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerAppointmentsDate.Location = new System.Drawing.Point(369, 190);
            this.dateTimePickerAppointmentsDate.Name = "dateTimePickerAppointmentsDate";
            this.dateTimePickerAppointmentsDate.Size = new System.Drawing.Size(124, 20);
            this.dateTimePickerAppointmentsDate.TabIndex = 4;
            // 
            // listBoxAppointmentsProfessionals
            // 
            this.listBoxAppointmentsProfessionals.FormattingEnabled = true;
            this.listBoxAppointmentsProfessionals.Location = new System.Drawing.Point(369, 241);
            this.listBoxAppointmentsProfessionals.Name = "listBoxAppointmentsProfessionals";
            this.listBoxAppointmentsProfessionals.Size = new System.Drawing.Size(124, 134);
            this.listBoxAppointmentsProfessionals.TabIndex = 3;
            // 
            // labelAppointmentsSelectProfessional
            // 
            this.labelAppointmentsSelectProfessional.AutoSize = true;
            this.labelAppointmentsSelectProfessional.Location = new System.Drawing.Point(366, 223);
            this.labelAppointmentsSelectProfessional.Name = "labelAppointmentsSelectProfessional";
            this.labelAppointmentsSelectProfessional.Size = new System.Drawing.Size(97, 13);
            this.labelAppointmentsSelectProfessional.TabIndex = 2;
            this.labelAppointmentsSelectProfessional.Text = "Select Professional";
            // 
            // labelAppointmentsForm
            // 
            this.labelAppointmentsForm.AutoSize = true;
            this.labelAppointmentsForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAppointmentsForm.Location = new System.Drawing.Point(412, 117);
            this.labelAppointmentsForm.Name = "labelAppointmentsForm";
            this.labelAppointmentsForm.Size = new System.Drawing.Size(132, 20);
            this.labelAppointmentsForm.TabIndex = 1;
            this.labelAppointmentsForm.Text = "APPOINTMENTS";
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tabPage2.Size = new System.Drawing.Size(942, 645);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::BeautySalonApp.Properties.Resources.BeautySalon12;
            this.pictureBox1.Location = new System.Drawing.Point(110, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(120, 135);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // BeautySalonMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(957, 677);
            this.Controls.Add(this.tabControlBeautySalonApp);
            this.Name = "BeautySalonMainForm";
            this.Text = "Form1";
            this.tabControlBeautySalonApp.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAppointmentsOfTheDay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlBeautySalonApp;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
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
    }
}

