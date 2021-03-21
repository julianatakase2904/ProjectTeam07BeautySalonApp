
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
            this.buttonAppointmentsPreviousDay = new System.Windows.Forms.Button();
            this.buttonAppointmentsNextDay = new System.Windows.Forms.Button();
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
            this.groupBoxAppointmentsClients = new System.Windows.Forms.GroupBox();
            this.listBoxAppointmentsClients = new System.Windows.Forms.ListBox();
            this.buttonAppointmentsUpdateClient = new System.Windows.Forms.Button();
            this.buttonAppointmentsAddClient = new System.Windows.Forms.Button();
            this.textBoxAppointmentsClientPhoneNumber = new System.Windows.Forms.TextBox();
            this.labelAppointmentsClientPhoneNumber = new System.Windows.Forms.Label();
            this.textBoxAppointmentsClientLastName = new System.Windows.Forms.TextBox();
            this.labelAppointmentsClientLastName = new System.Windows.Forms.Label();
            this.textBoxAppointmentsClientFirstName = new System.Windows.Forms.TextBox();
            this.labelAppointmentsClientFirstName = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabControlBeautySalonApp.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAppointmentsOfTheDay)).BeginInit();
            this.groupBoxAppointmentsClients.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlBeautySalonApp
            // 
            this.tabControlBeautySalonApp.Controls.Add(this.tabPage1);
            this.tabControlBeautySalonApp.Controls.Add(this.tabPage2);
            this.tabControlBeautySalonApp.Location = new System.Drawing.Point(3, 2);
            this.tabControlBeautySalonApp.Name = "tabControlBeautySalonApp";
            this.tabControlBeautySalonApp.SelectedIndex = 0;
            this.tabControlBeautySalonApp.Size = new System.Drawing.Size(933, 580);
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
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tabPage1.Size = new System.Drawing.Size(925, 554);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Appointments";
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
            // buttonAppointmentsNextDay
            // 
            this.buttonAppointmentsNextDay.Location = new System.Drawing.Point(806, 347);
            this.buttonAppointmentsNextDay.Name = "buttonAppointmentsNextDay";
            this.buttonAppointmentsNextDay.Size = new System.Drawing.Size(91, 37);
            this.buttonAppointmentsNextDay.TabIndex = 11;
            this.buttonAppointmentsNextDay.Text = ">> Next Day";
            this.buttonAppointmentsNextDay.UseVisualStyleBackColor = true;
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
            // dataGridViewAppointmentsOfTheDay
            // 
            this.dataGridViewAppointmentsOfTheDay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAppointmentsOfTheDay.Location = new System.Drawing.Point(31, 317);
            this.dataGridViewAppointmentsOfTheDay.Name = "dataGridViewAppointmentsOfTheDay";
            this.dataGridViewAppointmentsOfTheDay.RowHeadersWidth = 123;
            this.dataGridViewAppointmentsOfTheDay.Size = new System.Drawing.Size(735, 197);
            this.dataGridViewAppointmentsOfTheDay.TabIndex = 9;
            // 
            // labelAppointmentsOfTheDay
            // 
            this.labelAppointmentsOfTheDay.AutoSize = true;
            this.labelAppointmentsOfTheDay.Location = new System.Drawing.Point(28, 290);
            this.labelAppointmentsOfTheDay.Name = "labelAppointmentsOfTheDay";
            this.labelAppointmentsOfTheDay.Size = new System.Drawing.Size(159, 13);
            this.labelAppointmentsOfTheDay.TabIndex = 8;
            this.labelAppointmentsOfTheDay.Text = "APPOINTMENTS OF THE DAY";
            // 
            // listBoxAppointmentsSelectTime
            // 
            this.listBoxAppointmentsSelectTime.FormattingEnabled = true;
            this.listBoxAppointmentsSelectTime.Location = new System.Drawing.Point(796, 82);
            this.listBoxAppointmentsSelectTime.Name = "listBoxAppointmentsSelectTime";
            this.listBoxAppointmentsSelectTime.Size = new System.Drawing.Size(86, 134);
            this.listBoxAppointmentsSelectTime.TabIndex = 7;
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
            // labelAppointmentsSelectDate
            // 
            this.labelAppointmentsSelectDate.AutoSize = true;
            this.labelAppointmentsSelectDate.Location = new System.Drawing.Point(522, 64);
            this.labelAppointmentsSelectDate.Name = "labelAppointmentsSelectDate";
            this.labelAppointmentsSelectDate.Size = new System.Drawing.Size(97, 13);
            this.labelAppointmentsSelectDate.TabIndex = 5;
            this.labelAppointmentsSelectDate.Text = "Select Professional";
            // 
            // dateTimePickerAppointmentsDate
            // 
            this.dateTimePickerAppointmentsDate.Location = new System.Drawing.Point(525, 82);
            this.dateTimePickerAppointmentsDate.Name = "dateTimePickerAppointmentsDate";
            this.dateTimePickerAppointmentsDate.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerAppointmentsDate.TabIndex = 4;
            // 
            // listBoxAppointmentsProfessionals
            // 
            this.listBoxAppointmentsProfessionals.FormattingEnabled = true;
            this.listBoxAppointmentsProfessionals.Location = new System.Drawing.Point(525, 133);
            this.listBoxAppointmentsProfessionals.Name = "listBoxAppointmentsProfessionals";
            this.listBoxAppointmentsProfessionals.Size = new System.Drawing.Size(126, 134);
            this.listBoxAppointmentsProfessionals.TabIndex = 3;
            // 
            // labelAppointmentsSelectProfessional
            // 
            this.labelAppointmentsSelectProfessional.AutoSize = true;
            this.labelAppointmentsSelectProfessional.Location = new System.Drawing.Point(522, 115);
            this.labelAppointmentsSelectProfessional.Name = "labelAppointmentsSelectProfessional";
            this.labelAppointmentsSelectProfessional.Size = new System.Drawing.Size(97, 13);
            this.labelAppointmentsSelectProfessional.TabIndex = 2;
            this.labelAppointmentsSelectProfessional.Text = "Select Professional";
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
            // groupBoxAppointmentsClients
            // 
            this.groupBoxAppointmentsClients.Controls.Add(this.listBoxAppointmentsClients);
            this.groupBoxAppointmentsClients.Controls.Add(this.buttonAppointmentsUpdateClient);
            this.groupBoxAppointmentsClients.Controls.Add(this.buttonAppointmentsAddClient);
            this.groupBoxAppointmentsClients.Controls.Add(this.textBoxAppointmentsClientPhoneNumber);
            this.groupBoxAppointmentsClients.Controls.Add(this.labelAppointmentsClientPhoneNumber);
            this.groupBoxAppointmentsClients.Controls.Add(this.textBoxAppointmentsClientLastName);
            this.groupBoxAppointmentsClients.Controls.Add(this.labelAppointmentsClientLastName);
            this.groupBoxAppointmentsClients.Controls.Add(this.textBoxAppointmentsClientFirstName);
            this.groupBoxAppointmentsClients.Controls.Add(this.labelAppointmentsClientFirstName);
            this.groupBoxAppointmentsClients.Location = new System.Drawing.Point(31, 64);
            this.groupBoxAppointmentsClients.Name = "groupBoxAppointmentsClients";
            this.groupBoxAppointmentsClients.Size = new System.Drawing.Size(404, 203);
            this.groupBoxAppointmentsClients.TabIndex = 0;
            this.groupBoxAppointmentsClients.TabStop = false;
            this.groupBoxAppointmentsClients.Text = "CLIENTS";
            // 
            // listBoxAppointmentsClients
            // 
            this.listBoxAppointmentsClients.FormattingEnabled = true;
            this.listBoxAppointmentsClients.Location = new System.Drawing.Point(257, 14);
            this.listBoxAppointmentsClients.Name = "listBoxAppointmentsClients";
            this.listBoxAppointmentsClients.Size = new System.Drawing.Size(128, 173);
            this.listBoxAppointmentsClients.TabIndex = 8;
            // 
            // buttonAppointmentsUpdateClient
            // 
            this.buttonAppointmentsUpdateClient.Location = new System.Drawing.Point(131, 144);
            this.buttonAppointmentsUpdateClient.Name = "buttonAppointmentsUpdateClient";
            this.buttonAppointmentsUpdateClient.Size = new System.Drawing.Size(86, 25);
            this.buttonAppointmentsUpdateClient.TabIndex = 7;
            this.buttonAppointmentsUpdateClient.Text = "Update Client";
            this.buttonAppointmentsUpdateClient.UseVisualStyleBackColor = true;
            // 
            // buttonAppointmentsAddClient
            // 
            this.buttonAppointmentsAddClient.Location = new System.Drawing.Point(131, 101);
            this.buttonAppointmentsAddClient.Name = "buttonAppointmentsAddClient";
            this.buttonAppointmentsAddClient.Size = new System.Drawing.Size(86, 23);
            this.buttonAppointmentsAddClient.TabIndex = 6;
            this.buttonAppointmentsAddClient.Text = "Add Client";
            this.buttonAppointmentsAddClient.UseVisualStyleBackColor = true;
            // 
            // textBoxAppointmentsClientPhoneNumber
            // 
            this.textBoxAppointmentsClientPhoneNumber.Location = new System.Drawing.Point(9, 128);
            this.textBoxAppointmentsClientPhoneNumber.Name = "textBoxAppointmentsClientPhoneNumber";
            this.textBoxAppointmentsClientPhoneNumber.Size = new System.Drawing.Size(100, 20);
            this.textBoxAppointmentsClientPhoneNumber.TabIndex = 5;
            // 
            // labelAppointmentsClientPhoneNumber
            // 
            this.labelAppointmentsClientPhoneNumber.AutoSize = true;
            this.labelAppointmentsClientPhoneNumber.Location = new System.Drawing.Point(6, 111);
            this.labelAppointmentsClientPhoneNumber.Name = "labelAppointmentsClientPhoneNumber";
            this.labelAppointmentsClientPhoneNumber.Size = new System.Drawing.Size(78, 13);
            this.labelAppointmentsClientPhoneNumber.TabIndex = 4;
            this.labelAppointmentsClientPhoneNumber.Text = "Phone Number";
            // 
            // textBoxAppointmentsClientLastName
            // 
            this.textBoxAppointmentsClientLastName.Location = new System.Drawing.Point(131, 47);
            this.textBoxAppointmentsClientLastName.Name = "textBoxAppointmentsClientLastName";
            this.textBoxAppointmentsClientLastName.Size = new System.Drawing.Size(100, 20);
            this.textBoxAppointmentsClientLastName.TabIndex = 3;
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
            // textBoxAppointmentsClientFirstName
            // 
            this.textBoxAppointmentsClientFirstName.Location = new System.Drawing.Point(9, 47);
            this.textBoxAppointmentsClientFirstName.Name = "textBoxAppointmentsClientFirstName";
            this.textBoxAppointmentsClientFirstName.Size = new System.Drawing.Size(100, 20);
            this.textBoxAppointmentsClientFirstName.TabIndex = 1;
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
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tabPage2.Size = new System.Drawing.Size(925, 500);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // BeautySalonMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(939, 585);
            this.Controls.Add(this.tabControlBeautySalonApp);
            this.Name = "BeautySalonMainForm";
            this.Text = "Form1";
            this.tabControlBeautySalonApp.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAppointmentsOfTheDay)).EndInit();
            this.groupBoxAppointmentsClients.ResumeLayout(false);
            this.groupBoxAppointmentsClients.PerformLayout();
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
        private System.Windows.Forms.Button buttonAppointmentsUpdateClient;
        private System.Windows.Forms.Button buttonAppointmentsAddClient;
        private System.Windows.Forms.TextBox textBoxAppointmentsClientPhoneNumber;
        private System.Windows.Forms.Label labelAppointmentsClientPhoneNumber;
        private System.Windows.Forms.TextBox textBoxAppointmentsClientLastName;
        private System.Windows.Forms.Label labelAppointmentsClientLastName;
        private System.Windows.Forms.TextBox textBoxAppointmentsClientFirstName;
        private System.Windows.Forms.Label labelAppointmentsClientFirstName;
        private System.Windows.Forms.ListBox listBoxAppointmentsClients;
    }
}

