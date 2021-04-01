
namespace BeautySalonApp
{
    partial class DeleteAppointmentsForm
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
            this.listBoxAppointments = new System.Windows.Forms.ListBox();
            this.labelAppointmentToDelete = new System.Windows.Forms.Label();
            this.buttonDeleteAppointment = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBoxAppointments
            // 
            this.listBoxAppointments.FormattingEnabled = true;
            this.listBoxAppointments.ItemHeight = 37;
            this.listBoxAppointments.Location = new System.Drawing.Point(416, 117);
            this.listBoxAppointments.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.listBoxAppointments.Name = "listBoxAppointments";
            this.listBoxAppointments.Size = new System.Drawing.Size(1049, 522);
            this.listBoxAppointments.TabIndex = 0;
            // 
            // labelAppointmentToDelete
            // 
            this.labelAppointmentToDelete.Location = new System.Drawing.Point(127, 117);
            this.labelAppointmentToDelete.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.labelAppointmentToDelete.Name = "labelAppointmentToDelete";
            this.labelAppointmentToDelete.Size = new System.Drawing.Size(239, 101);
            this.labelAppointmentToDelete.TabIndex = 1;
            this.labelAppointmentToDelete.Text = "Appointments To Delete";
            // 
            // buttonDeleteAppointment
            // 
            this.buttonDeleteAppointment.Location = new System.Drawing.Point(671, 752);
            this.buttonDeleteAppointment.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.buttonDeleteAppointment.Name = "buttonDeleteAppointment";
            this.buttonDeleteAppointment.Size = new System.Drawing.Size(238, 65);
            this.buttonDeleteAppointment.TabIndex = 2;
            this.buttonDeleteAppointment.Text = "Delete";
            this.buttonDeleteAppointment.UseVisualStyleBackColor = true;
            // 
            // DeleteAppointmentsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1568, 928);
            this.Controls.Add(this.buttonDeleteAppointment);
            this.Controls.Add(this.labelAppointmentToDelete);
            this.Controls.Add(this.listBoxAppointments);
            this.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.Name = "DeleteAppointmentsForm";
            this.Text = "DeleteAppointmentsForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxAppointments;
        private System.Windows.Forms.Label labelAppointmentToDelete;
        private System.Windows.Forms.Button buttonDeleteAppointment;
    }
}