
namespace BeautySalonApp
{
    partial class BackUpForm
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
            this.dataGridViewClients = new System.Windows.Forms.DataGridView();
            this.dataGridViewInventory = new System.Windows.Forms.DataGridView();
            this.dataGridViewAppointments = new System.Windows.Forms.DataGridView();
            this.dataGridViewServices = new System.Windows.Forms.DataGridView();
            this.dataGridViewEmployees = new System.Windows.Forms.DataGridView();
            this.labelClients = new System.Windows.Forms.Label();
            this.labelEmployees = new System.Windows.Forms.Label();
            this.labelInventory = new System.Windows.Forms.Label();
            this.labelServices = new System.Windows.Forms.Label();
            this.labelAppointments = new System.Windows.Forms.Label();
            this.buttonBackup = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClients)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInventory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAppointments)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewServices)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmployees)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewClients
            // 
            this.dataGridViewClients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewClients.Location = new System.Drawing.Point(42, 54);
            this.dataGridViewClients.Name = "dataGridViewClients";
            this.dataGridViewClients.Size = new System.Drawing.Size(331, 139);
            this.dataGridViewClients.TabIndex = 0;
            // 
            // dataGridViewInventory
            // 
            this.dataGridViewInventory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewInventory.Location = new System.Drawing.Point(42, 228);
            this.dataGridViewInventory.Name = "dataGridViewInventory";
            this.dataGridViewInventory.Size = new System.Drawing.Size(331, 139);
            this.dataGridViewInventory.TabIndex = 1;
            // 
            // dataGridViewAppointments
            // 
            this.dataGridViewAppointments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAppointments.Location = new System.Drawing.Point(42, 408);
            this.dataGridViewAppointments.Name = "dataGridViewAppointments";
            this.dataGridViewAppointments.Size = new System.Drawing.Size(699, 139);
            this.dataGridViewAppointments.TabIndex = 2;
            // 
            // dataGridViewServices
            // 
            this.dataGridViewServices.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewServices.Location = new System.Drawing.Point(410, 228);
            this.dataGridViewServices.Name = "dataGridViewServices";
            this.dataGridViewServices.Size = new System.Drawing.Size(331, 139);
            this.dataGridViewServices.TabIndex = 4;
            // 
            // dataGridViewEmployees
            // 
            this.dataGridViewEmployees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEmployees.Location = new System.Drawing.Point(410, 54);
            this.dataGridViewEmployees.Name = "dataGridViewEmployees";
            this.dataGridViewEmployees.Size = new System.Drawing.Size(331, 139);
            this.dataGridViewEmployees.TabIndex = 3;
            // 
            // labelClients
            // 
            this.labelClients.AutoSize = true;
            this.labelClients.Location = new System.Drawing.Point(39, 38);
            this.labelClients.Name = "labelClients";
            this.labelClients.Size = new System.Drawing.Size(38, 13);
            this.labelClients.TabIndex = 6;
            this.labelClients.Text = "Clients";
            // 
            // labelEmployees
            // 
            this.labelEmployees.AutoSize = true;
            this.labelEmployees.Location = new System.Drawing.Point(407, 38);
            this.labelEmployees.Name = "labelEmployees";
            this.labelEmployees.Size = new System.Drawing.Size(58, 13);
            this.labelEmployees.TabIndex = 7;
            this.labelEmployees.Text = "Employees";
            // 
            // labelInventory
            // 
            this.labelInventory.AutoSize = true;
            this.labelInventory.Location = new System.Drawing.Point(39, 212);
            this.labelInventory.Name = "labelInventory";
            this.labelInventory.Size = new System.Drawing.Size(51, 13);
            this.labelInventory.TabIndex = 8;
            this.labelInventory.Text = "Inventory";
            // 
            // labelServices
            // 
            this.labelServices.AutoSize = true;
            this.labelServices.Location = new System.Drawing.Point(407, 212);
            this.labelServices.Name = "labelServices";
            this.labelServices.Size = new System.Drawing.Size(48, 13);
            this.labelServices.TabIndex = 9;
            this.labelServices.Text = "Services";
            // 
            // labelAppointments
            // 
            this.labelAppointments.AutoSize = true;
            this.labelAppointments.Location = new System.Drawing.Point(39, 392);
            this.labelAppointments.Name = "labelAppointments";
            this.labelAppointments.Size = new System.Drawing.Size(71, 13);
            this.labelAppointments.TabIndex = 10;
            this.labelAppointments.Text = "Appointments";
            // 
            // buttonBackup
            // 
            this.buttonBackup.Location = new System.Drawing.Point(354, 563);
            this.buttonBackup.Name = "buttonBackup";
            this.buttonBackup.Size = new System.Drawing.Size(75, 23);
            this.buttonBackup.TabIndex = 12;
            this.buttonBackup.Text = "BackUp";
            this.buttonBackup.UseVisualStyleBackColor = true;
            // 
            // BackUpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(775, 608);
            this.Controls.Add(this.buttonBackup);
            this.Controls.Add(this.labelAppointments);
            this.Controls.Add(this.labelServices);
            this.Controls.Add(this.labelInventory);
            this.Controls.Add(this.labelEmployees);
            this.Controls.Add(this.labelClients);
            this.Controls.Add(this.dataGridViewServices);
            this.Controls.Add(this.dataGridViewEmployees);
            this.Controls.Add(this.dataGridViewAppointments);
            this.Controls.Add(this.dataGridViewInventory);
            this.Controls.Add(this.dataGridViewClients);
            this.Name = "BackUpForm";
            this.Text = "BackUpForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClients)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInventory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAppointments)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewServices)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmployees)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewClients;
        private System.Windows.Forms.DataGridView dataGridViewInventory;
        private System.Windows.Forms.DataGridView dataGridViewAppointments;
        private System.Windows.Forms.DataGridView dataGridViewServices;
        private System.Windows.Forms.DataGridView dataGridViewEmployees;
        private System.Windows.Forms.Label labelClients;
        private System.Windows.Forms.Label labelEmployees;
        private System.Windows.Forms.Label labelInventory;
        private System.Windows.Forms.Label labelServices;
        private System.Windows.Forms.Label labelAppointments;
        private System.Windows.Forms.Button buttonBackup;
    }
}