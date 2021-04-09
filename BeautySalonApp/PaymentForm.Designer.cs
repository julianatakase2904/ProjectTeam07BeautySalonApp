namespace BeautySalonApp
{
    partial class PaymentForm
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
            this.buttonNewPayment = new System.Windows.Forms.Button();
            this.labelSystemName = new System.Windows.Forms.Label();
            this.labelFormName = new System.Windows.Forms.Label();
            this.buttonUpdatePayment = new System.Windows.Forms.Button();
            this.buttonDeletePayment = new System.Windows.Forms.Button();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.dataGridViewPayment = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPayment)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonNewPayment
            // 
            this.buttonNewPayment.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonNewPayment.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonNewPayment.Location = new System.Drawing.Point(323, 400);
            this.buttonNewPayment.Margin = new System.Windows.Forms.Padding(2);
            this.buttonNewPayment.Name = "buttonNewPayment";
            this.buttonNewPayment.Size = new System.Drawing.Size(100, 32);
            this.buttonNewPayment.TabIndex = 1;
            this.buttonNewPayment.Text = "New Payment";
            this.buttonNewPayment.UseVisualStyleBackColor = false;
            // 
            // labelSystemName
            // 
            this.labelSystemName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelSystemName.AutoSize = true;
            this.labelSystemName.Font = new System.Drawing.Font("Mistral", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSystemName.Location = new System.Drawing.Point(278, 55);
            this.labelSystemName.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.labelSystemName.Name = "labelSystemName";
            this.labelSystemName.Size = new System.Drawing.Size(385, 38);
            this.labelSystemName.TabIndex = 17;
            this.labelSystemName.Text = "Beauty Salon - Management System";
            // 
            // labelFormName
            // 
            this.labelFormName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelFormName.AutoSize = true;
            this.labelFormName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFormName.Location = new System.Drawing.Point(423, 108);
            this.labelFormName.Name = "labelFormName";
            this.labelFormName.Size = new System.Drawing.Size(85, 20);
            this.labelFormName.TabIndex = 18;
            this.labelFormName.Text = "PAYMENT";
            // 
            // buttonUpdatePayment
            // 
            this.buttonUpdatePayment.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonUpdatePayment.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonUpdatePayment.Location = new System.Drawing.Point(427, 400);
            this.buttonUpdatePayment.Margin = new System.Windows.Forms.Padding(2);
            this.buttonUpdatePayment.Name = "buttonUpdatePayment";
            this.buttonUpdatePayment.Size = new System.Drawing.Size(100, 32);
            this.buttonUpdatePayment.TabIndex = 20;
            this.buttonUpdatePayment.Text = "Update Payment";
            this.buttonUpdatePayment.UseVisualStyleBackColor = false;
            // 
            // buttonDeletePayment
            // 
            this.buttonDeletePayment.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonDeletePayment.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonDeletePayment.Location = new System.Drawing.Point(531, 400);
            this.buttonDeletePayment.Margin = new System.Windows.Forms.Padding(2);
            this.buttonDeletePayment.Name = "buttonDeletePayment";
            this.buttonDeletePayment.Size = new System.Drawing.Size(100, 32);
            this.buttonDeletePayment.TabIndex = 21;
            this.buttonDeletePayment.Text = "Delete Payment";
            this.buttonDeletePayment.UseVisualStyleBackColor = false;
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.Image = global::BeautySalonApp.Properties.Resources.BeautySalon12;
            this.pictureBoxLogo.Location = new System.Drawing.Point(45, 39);
            this.pictureBoxLogo.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(120, 135);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxLogo.TabIndex = 2;
            this.pictureBoxLogo.TabStop = false;
            // 
            // dataGridViewPayment
            // 
            this.dataGridViewPayment.AllowUserToAddRows = false;
            this.dataGridViewPayment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPayment.Location = new System.Drawing.Point(12, 219);
            this.dataGridViewPayment.Name = "dataGridViewPayment";
            this.dataGridViewPayment.ReadOnly = true;
            this.dataGridViewPayment.Size = new System.Drawing.Size(909, 150);
            this.dataGridViewPayment.TabIndex = 23;
            // 
            // PaymentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(930, 613);
            this.Controls.Add(this.dataGridViewPayment);
            this.Controls.Add(this.buttonDeletePayment);
            this.Controls.Add(this.buttonUpdatePayment);
            this.Controls.Add(this.labelFormName);
            this.Controls.Add(this.labelSystemName);
            this.Controls.Add(this.pictureBoxLogo);
            this.Controls.Add(this.buttonNewPayment);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "PaymentForm";
            this.Text = "PaymentForm";
            this.Load += new System.EventHandler(this.PaymentForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPayment)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonNewPayment;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.Label labelSystemName;
        private System.Windows.Forms.Label labelFormName;
        private System.Windows.Forms.Button buttonUpdatePayment;
        private System.Windows.Forms.Button buttonDeletePayment;
        private System.Windows.Forms.DataGridView dataGridViewPayment;
    }
}