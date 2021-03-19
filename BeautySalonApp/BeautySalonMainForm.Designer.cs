
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
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBoxAppointmentsClients = new System.Windows.Forms.GroupBox();
            this.labelAppointmentsForm = new System.Windows.Forms.Label();
            this.labelAppointmentsClientFirstName = new System.Windows.Forms.Label();
            this.textBoxAppointmentsClientFirstName = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.labelAppointmentsClientLastName = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.labelAppointmentsClientPhoneNumber = new System.Windows.Forms.Label();
            this.buttonAppointmentsAddClient = new System.Windows.Forms.Button();
            this.buttonAppointmentsSearchClient = new System.Windows.Forms.Button();
            this.labelAppointmentsSelectProfessional = new System.Windows.Forms.Label();
            this.listBoxAppointmentsProfessionals = new System.Windows.Forms.ListBox();
            this.dateTimePickerAppointmentsDate = new System.Windows.Forms.DateTimePicker();
            this.labelAppointmentsSelectDate = new System.Windows.Forms.Label();
            this.labelAppointmentsSelectTime = new System.Windows.Forms.Label();
            this.listBoxAppointmentsSelectTime = new System.Windows.Forms.ListBox();
            this.labelAppointmentsOfTheDay = new System.Windows.Forms.Label();
            this.dataGridViewAppointmentsOfTheDay = new System.Windows.Forms.DataGridView();
            this.buttonAppointmentsSaveAppointment = new System.Windows.Forms.Button();
            this.buttonAppointmentsNextDay = new System.Windows.Forms.Button();
            this.buttonAppointmentsPreviousDay = new System.Windows.Forms.Button();
            this.tabControlBeautySalonApp.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBoxAppointmentsClients.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAppointmentsOfTheDay)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControlBeautySalonApp
            // 
            this.tabControlBeautySalonApp.Controls.Add(this.tabPage1);
            this.tabControlBeautySalonApp.Controls.Add(this.tabPage2);
            this.tabControlBeautySalonApp.Location = new System.Drawing.Point(3, 2);
            this.tabControlBeautySalonApp.Name = "tabControlBeautySalonApp";
            this.tabControlBeautySalonApp.SelectedIndex = 0;
            this.tabControlBeautySalonApp.Size = new System.Drawing.Size(933, 526);
            this.tabControlBeautySalonApp.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.PaleTurquoise;
            this.tabPage1.Controls.Add(this.buttonAppointmentsPreviousDay);
            this.tabPage1.Controls.Add(this.buttonAppointmentsNextDay);
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
            this.tabPage1.Controls.Add(this.groupBoxAppointmentsClients);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(925, 500);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Appointments";
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(989, 500);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBoxAppointmentsClients
            // 
            this.groupBoxAppointmentsClients.Controls.Add(this.buttonAppointmentsSearchClient);
            this.groupBoxAppointmentsClients.Controls.Add(this.buttonAppointmentsAddClient);
            this.groupBoxAppointmentsClients.Controls.Add(this.textBox2);
            this.groupBoxAppointmentsClients.Controls.Add(this.labelAppointmentsClientPhoneNumber);
            this.groupBoxAppointmentsClients.Controls.Add(this.textBox1);
            this.groupBoxAppointmentsClients.Controls.Add(this.labelAppointmentsClientLastName);
            this.groupBoxAppointmentsClients.Controls.Add(this.textBoxAppointmentsClientFirstName);
            this.groupBoxAppointmentsClients.Controls.Add(this.labelAppointmentsClientFirstName);
            this.groupBoxAppointmentsClients.Location = new System.Drawing.Point(31, 64);
            this.groupBoxAppointmentsClients.Name = "groupBoxAppointmentsClients";
            this.groupBoxAppointmentsClients.Size = new System.Drawing.Size(247, 152);
            this.groupBoxAppointmentsClients.TabIndex = 0;
            this.groupBoxAppointmentsClients.TabStop = false;
            this.groupBoxAppointmentsClients.Text = "CLIENTS";
            // 
            // labelAppointmentsForm
            // 
            this.labelAppointmentsForm.AutoSize = true;
            this.labelAppointmentsForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAppointmentsForm.Location = new System.Drawing.Point(27, 24);
            this.labelAppointmentsForm.Name = "labelAppointmentsForm";
            this.labelAppointmentsForm.Size = new System.Drawing.Size(132, 20);
            this.labelAppointmentsForm.TabIndex = 1;
            this.labelAppointmentsForm.Text = "APPOINTMENTS";
            // 
            // labelAppointmentsClientFirstName
            // 
            this.labelAppointmentsClientFirstName.AutoSize = true;
            this.labelAppointmentsClientFirstName.Location = new System.Drawing.Point(6, 30);
            this.labelAppointmentsClientFirstName.Name = "labelAppointmentsClientFirstName";
            this.labelAppointmentsClientFirstName.Size = new System.Drawing.Size(57, 13);
            this.labelAppointmentsClientFirstName.TabIndex = 0;
            this.labelAppointmentsClientFirstName.Text = "First Name";
            // 
            // textBoxAppointmentsClientFirstName
            // 
            this.textBoxAppointmentsClientFirstName.Location = new System.Drawing.Point(9, 47);
            this.textBoxAppointmentsClientFirstName.Name = "textBoxAppointmentsClientFirstName";
            this.textBoxAppointmentsClientFirstName.Size = new System.Drawing.Size(100, 20);
            this.textBoxAppointmentsClientFirstName.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(131, 47);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 3;
            // 
            // labelAppointmentsClientLastName
            // 
            this.labelAppointmentsClientLastName.AutoSize = true;
            this.labelAppointmentsClientLastName.Location = new System.Drawing.Point(128, 30);
            this.labelAppointmentsClientLastName.Name = "labelAppointmentsClientLastName";
            this.labelAppointmentsClientLastName.Size = new System.Drawing.Size(58, 13);
            this.labelAppointmentsClientLastName.TabIndex = 2;
            this.labelAppointmentsClientLastName.Text = "Last Name";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(9, 100);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 5;
            // 
            // labelAppointmentsClientPhoneNumber
            // 
            this.labelAppointmentsClientPhoneNumber.AutoSize = true;
            this.labelAppointmentsClientPhoneNumber.Location = new System.Drawing.Point(6, 83);
            this.labelAppointmentsClientPhoneNumber.Name = "labelAppointmentsClientPhoneNumber";
            this.labelAppointmentsClientPhoneNumber.Size = new System.Drawing.Size(78, 13);
            this.labelAppointmentsClientPhoneNumber.TabIndex = 4;
            this.labelAppointmentsClientPhoneNumber.Text = "Phone Number";
            // 
            // buttonAppointmentsAddClient
            // 
            this.buttonAppointmentsAddClient.Location = new System.Drawing.Point(145, 81);
            this.buttonAppointmentsAddClient.Name = "buttonAppointmentsAddClient";
            this.buttonAppointmentsAddClient.Size = new System.Drawing.Size(86, 23);
            this.buttonAppointmentsAddClient.TabIndex = 6;
            this.buttonAppointmentsAddClient.Text = "Add Client";
            this.buttonAppointmentsAddClient.UseVisualStyleBackColor = true;
            // 
            // buttonAppointmentsSearchClient
            // 
            this.buttonAppointmentsSearchClient.Location = new System.Drawing.Point(145, 110);
            this.buttonAppointmentsSearchClient.Name = "buttonAppointmentsSearchClient";
            this.buttonAppointmentsSearchClient.Size = new System.Drawing.Size(86, 25);
            this.buttonAppointmentsSearchClient.TabIndex = 7;
            this.buttonAppointmentsSearchClient.Text = "Search Client";
            this.buttonAppointmentsSearchClient.UseVisualStyleBackColor = true;
            // 
            // labelAppointmentsSelectProfessional
            // 
            this.labelAppointmentsSelectProfessional.AutoSize = true;
            this.labelAppointmentsSelectProfessional.Location = new System.Drawing.Point(329, 64);
            this.labelAppointmentsSelectProfessional.Name = "labelAppointmentsSelectProfessional";
            this.labelAppointmentsSelectProfessional.Size = new System.Drawing.Size(97, 13);
            this.labelAppointmentsSelectProfessional.TabIndex = 2;
            this.labelAppointmentsSelectProfessional.Text = "Select Professional";
            // 
            // listBoxAppointmentsProfessionals
            // 
            this.listBoxAppointmentsProfessionals.FormattingEnabled = true;
            this.listBoxAppointmentsProfessionals.Location = new System.Drawing.Point(332, 82);
            this.listBoxAppointmentsProfessionals.Name = "listBoxAppointmentsProfessionals";
            this.listBoxAppointmentsProfessionals.Size = new System.Drawing.Size(126, 134);
            this.listBoxAppointmentsProfessionals.TabIndex = 3;
            // 
            // dateTimePickerAppointmentsDate
            // 
            this.dateTimePickerAppointmentsDate.Location = new System.Drawing.Point(525, 82);
            this.dateTimePickerAppointmentsDate.Name = "dateTimePickerAppointmentsDate";
            this.dateTimePickerAppointmentsDate.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerAppointmentsDate.TabIndex = 4;
            // 
            // labelAppointmentsSelectDate
            // 
            this.labelAppointmentsSelectDate.AutoSize = true;
            this.labelAppointmentsSelectDate.Location = new System.Drawing.Point(522, 64);
            this.labelAppointmentsSelectDate.Name = "labelAppointmentsSelectDate";
            this.labelAppointmentsSelectDate.Size = new System.Drawing.Size(97, 13);
            this.labelAppointmentsSelectDate.TabIndex = 5;
            this.labelAppointmentsSelectDate.Text = "Select Professional";
            // 
            // labelAppointmentsSelectTime
            // 
            this.labelAppointmentsSelectTime.AutoSize = true;
            this.labelAppointmentsSelectTime.Location = new System.Drawing.Point(793, 64);
            this.labelAppointmentsSelectTime.Name = "labelAppointmentsSelectTime";
            this.labelAppointmentsSelectTime.Size = new System.Drawing.Size(63, 13);
            this.labelAppointmentsSelectTime.TabIndex = 6;
            this.labelAppointmentsSelectTime.Text = "Select Time";
            // 
            // listBoxAppointmentsSelectTime
            // 
            this.listBoxAppointmentsSelectTime.FormattingEnabled = true;
            this.listBoxAppointmentsSelectTime.Location = new System.Drawing.Point(796, 82);
            this.listBoxAppointmentsSelectTime.Name = "listBoxAppointmentsSelectTime";
            this.listBoxAppointmentsSelectTime.Size = new System.Drawing.Size(86, 134);
            this.listBoxAppointmentsSelectTime.TabIndex = 7;
            // 
            // labelAppointmentsOfTheDay
            // 
            this.labelAppointmentsOfTheDay.AutoSize = true;
            this.labelAppointmentsOfTheDay.Location = new System.Drawing.Point(37, 242);
            this.labelAppointmentsOfTheDay.Name = "labelAppointmentsOfTheDay";
            this.labelAppointmentsOfTheDay.Size = new System.Drawing.Size(159, 13);
            this.labelAppointmentsOfTheDay.TabIndex = 8;
            this.labelAppointmentsOfTheDay.Text = "APPOINTMENTS OF THE DAY";
            // 
            // dataGridViewAppointmentsOfTheDay
            // 
            this.dataGridViewAppointmentsOfTheDay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAppointmentsOfTheDay.Location = new System.Drawing.Point(40, 281);
            this.dataGridViewAppointmentsOfTheDay.Name = "dataGridViewAppointmentsOfTheDay";
            this.dataGridViewAppointmentsOfTheDay.Size = new System.Drawing.Size(735, 197);
            this.dataGridViewAppointmentsOfTheDay.TabIndex = 9;
            // 
            // buttonAppointmentsSaveAppointment
            // 
            this.buttonAppointmentsSaveAppointment.Location = new System.Drawing.Point(806, 290);
            this.buttonAppointmentsSaveAppointment.Name = "buttonAppointmentsSaveAppointment";
            this.buttonAppointmentsSaveAppointment.Size = new System.Drawing.Size(91, 38);
            this.buttonAppointmentsSaveAppointment.TabIndex = 10;
            this.buttonAppointmentsSaveAppointment.Text = "Save Appointments";
            this.buttonAppointmentsSaveAppointment.UseVisualStyleBackColor = true;
            // 
            // buttonAppointmentsNextDay
            // 
            this.buttonAppointmentsNextDay.Location = new System.Drawing.Point(806, 347);
            this.buttonAppointmentsNextDay.Name = "buttonAppointmentsNextDay";
            this.buttonAppointmentsNextDay.Size = new System.Drawing.Size(91, 37);
            this.buttonAppointmentsNextDay.TabIndex = 11;
            this.buttonAppointmentsNextDay.Text = ">> Next Day";
            this.buttonAppointmentsNextDay.UseVisualStyleBackColor = true;
            // 
            // buttonAppointmentsPreviousDay
            // 
            this.buttonAppointmentsPreviousDay.Location = new System.Drawing.Point(806, 404);
            this.buttonAppointmentsPreviousDay.Name = "buttonAppointmentsPreviousDay";
            this.buttonAppointmentsPreviousDay.Size = new System.Drawing.Size(91, 38);
            this.buttonAppointmentsPreviousDay.TabIndex = 12;
            this.buttonAppointmentsPreviousDay.Text = "<< Previous Day";
            this.buttonAppointmentsPreviousDay.UseVisualStyleBackColor = true;
            // 
            // BeautySalonMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(939, 531);
            this.Controls.Add(this.tabControlBeautySalonApp);
            this.Name = "BeautySalonMainForm";
            this.Text = "Form1";
            this.tabControlBeautySalonApp.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBoxAppointmentsClients.ResumeLayout(false);
            this.groupBoxAppointmentsClients.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAppointmentsOfTheDay)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlBeautySalonApp;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox groupBoxAppointmentsClients;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button buttonAppointmentsPreviousDay;
        private System.Windows.Forms.Button buttonAppointmentsNextDay;
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
        private System.Windows.Forms.Button buttonAppointmentsSearchClient;
        private System.Windows.Forms.Button buttonAppointmentsAddClient;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label labelAppointmentsClientPhoneNumber;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label labelAppointmentsClientLastName;
        private System.Windows.Forms.TextBox textBoxAppointmentsClientFirstName;
        private System.Windows.Forms.Label labelAppointmentsClientFirstName;
    }
}

