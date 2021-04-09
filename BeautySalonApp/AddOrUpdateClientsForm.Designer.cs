
namespace BeautySalonApp
{
    partial class AddOrUpdateClientsForm
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
            this.listBoxClients = new System.Windows.Forms.ListBox();
            this.labelClientsListBox = new System.Windows.Forms.Label();
            this.labelClientsFirstName = new System.Windows.Forms.Label();
            this.labelClientLastName = new System.Windows.Forms.Label();
            this.labelClientPhoneNumber = new System.Windows.Forms.Label();
            this.textBoxClientFirstName = new System.Windows.Forms.TextBox();
            this.textBoxClientLastName = new System.Windows.Forms.TextBox();
            this.textBoxClientPhoneNumber = new System.Windows.Forms.TextBox();
            this.buttonAddClient = new System.Windows.Forms.Button();
            this.buttonUpdateClient = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBoxClients
            // 
            this.listBoxClients.FormattingEnabled = true;
            this.listBoxClients.Location = new System.Drawing.Point(126, 28);
            this.listBoxClients.Name = "listBoxClients";
            this.listBoxClients.Size = new System.Drawing.Size(196, 186);
            this.listBoxClients.TabIndex = 0;
            // 
            // labelClientsListBox
            // 
            this.labelClientsListBox.AutoSize = true;
            this.labelClientsListBox.Location = new System.Drawing.Point(56, 28);
            this.labelClientsListBox.Name = "labelClientsListBox";
            this.labelClientsListBox.Size = new System.Drawing.Size(38, 13);
            this.labelClientsListBox.TabIndex = 1;
            this.labelClientsListBox.Text = "Clients";
            // 
            // labelClientsFirstName
            // 
            this.labelClientsFirstName.AutoSize = true;
            this.labelClientsFirstName.Location = new System.Drawing.Point(56, 240);
            this.labelClientsFirstName.Name = "labelClientsFirstName";
            this.labelClientsFirstName.Size = new System.Drawing.Size(86, 13);
            this.labelClientsFirstName.TabIndex = 2;
            this.labelClientsFirstName.Text = "Client First Name";
            // 
            // labelClientLastName
            // 
            this.labelClientLastName.AutoSize = true;
            this.labelClientLastName.Location = new System.Drawing.Point(56, 280);
            this.labelClientLastName.Name = "labelClientLastName";
            this.labelClientLastName.Size = new System.Drawing.Size(87, 13);
            this.labelClientLastName.TabIndex = 3;
            this.labelClientLastName.Text = "Client Last Name";
            // 
            // labelClientPhoneNumber
            // 
            this.labelClientPhoneNumber.AutoSize = true;
            this.labelClientPhoneNumber.Location = new System.Drawing.Point(56, 322);
            this.labelClientPhoneNumber.Name = "labelClientPhoneNumber";
            this.labelClientPhoneNumber.Size = new System.Drawing.Size(107, 13);
            this.labelClientPhoneNumber.TabIndex = 4;
            this.labelClientPhoneNumber.Text = "Client Phone Number";
            // 
            // textBoxClientFirstName
            // 
            this.textBoxClientFirstName.Location = new System.Drawing.Point(172, 237);
            this.textBoxClientFirstName.Name = "textBoxClientFirstName";
            this.textBoxClientFirstName.Size = new System.Drawing.Size(150, 20);
            this.textBoxClientFirstName.TabIndex = 5;
            // 
            // textBoxClientLastName
            // 
            this.textBoxClientLastName.Location = new System.Drawing.Point(172, 277);
            this.textBoxClientLastName.Name = "textBoxClientLastName";
            this.textBoxClientLastName.Size = new System.Drawing.Size(150, 20);
            this.textBoxClientLastName.TabIndex = 6;
            // 
            // textBoxClientPhoneNumber
            // 
            this.textBoxClientPhoneNumber.Location = new System.Drawing.Point(172, 319);
            this.textBoxClientPhoneNumber.Name = "textBoxClientPhoneNumber";
            this.textBoxClientPhoneNumber.Size = new System.Drawing.Size(150, 20);
            this.textBoxClientPhoneNumber.TabIndex = 7;
            // 
            // buttonAddClient
            // 
            this.buttonAddClient.Location = new System.Drawing.Point(99, 378);
            this.buttonAddClient.Name = "buttonAddClient";
            this.buttonAddClient.Size = new System.Drawing.Size(75, 23);
            this.buttonAddClient.TabIndex = 8;
            this.buttonAddClient.Text = "Add";
            this.buttonAddClient.UseVisualStyleBackColor = true;
            // 
            // buttonUpdateClient
            // 
            this.buttonUpdateClient.Location = new System.Drawing.Point(224, 378);
            this.buttonUpdateClient.Name = "buttonUpdateClient";
            this.buttonUpdateClient.Size = new System.Drawing.Size(75, 23);
            this.buttonUpdateClient.TabIndex = 9;
            this.buttonUpdateClient.Text = "Update";
            this.buttonUpdateClient.UseVisualStyleBackColor = true;
            // 
            // AddOrUpdateClientsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(385, 450);
            this.Controls.Add(this.buttonUpdateClient);
            this.Controls.Add(this.buttonAddClient);
            this.Controls.Add(this.textBoxClientPhoneNumber);
            this.Controls.Add(this.textBoxClientLastName);
            this.Controls.Add(this.textBoxClientFirstName);
            this.Controls.Add(this.labelClientPhoneNumber);
            this.Controls.Add(this.labelClientLastName);
            this.Controls.Add(this.labelClientsFirstName);
            this.Controls.Add(this.labelClientsListBox);
            this.Controls.Add(this.listBoxClients);
            this.Name = "AddOrUpdateClientsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddOrUpdateClientsForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxClients;
        private System.Windows.Forms.Label labelClientsListBox;
        private System.Windows.Forms.Label labelClientsFirstName;
        private System.Windows.Forms.Label labelClientLastName;
        private System.Windows.Forms.Label labelClientPhoneNumber;
        private System.Windows.Forms.TextBox textBoxClientFirstName;
        private System.Windows.Forms.TextBox textBoxClientLastName;
        private System.Windows.Forms.TextBox textBoxClientPhoneNumber;
        private System.Windows.Forms.Button buttonAddClient;
        private System.Windows.Forms.Button buttonUpdateClient;
    }
}