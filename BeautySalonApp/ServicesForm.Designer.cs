namespace BeautySalonApp
{
    partial class ServicesForm
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
            this.labelFormName = new System.Windows.Forms.Label();
            this.labelSystemName = new System.Windows.Forms.Label();
            this.dataGridViewInventory = new System.Windows.Forms.DataGridView();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.buttonDeleteEntry = new System.Windows.Forms.Button();
            this.buttonUpdateEntry = new System.Windows.Forms.Button();
            this.buttonNewEntry = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInventory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // labelFormName
            // 
            this.labelFormName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelFormName.AutoSize = true;
            this.labelFormName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFormName.Location = new System.Drawing.Point(654, 166);
            this.labelFormName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelFormName.Name = "labelFormName";
            this.labelFormName.Size = new System.Drawing.Size(132, 29);
            this.labelFormName.TabIndex = 21;
            this.labelFormName.Text = "SERVICES";
            // 
            // labelSystemName
            // 
            this.labelSystemName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelSystemName.AutoSize = true;
            this.labelSystemName.Font = new System.Drawing.Font("Mistral", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSystemName.Location = new System.Drawing.Point(417, 85);
            this.labelSystemName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelSystemName.Name = "labelSystemName";
            this.labelSystemName.Size = new System.Drawing.Size(576, 57);
            this.labelSystemName.TabIndex = 20;
            this.labelSystemName.Text = "Beauty Salon - Management System";
            // 
            // dataGridViewInventory
            // 
            this.dataGridViewInventory.AllowUserToAddRows = false;
            this.dataGridViewInventory.AllowUserToDeleteRows = false;
            this.dataGridViewInventory.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dataGridViewInventory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewInventory.Location = new System.Drawing.Point(313, 261);
            this.dataGridViewInventory.Name = "dataGridViewInventory";
            this.dataGridViewInventory.RowTemplate.Height = 28;
            this.dataGridViewInventory.Size = new System.Drawing.Size(791, 435);
            this.dataGridViewInventory.TabIndex = 22;
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.Image = global::BeautySalonApp.Properties.Resources.BeautySalon12;
            this.pictureBoxLogo.Location = new System.Drawing.Point(68, 60);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(120, 135);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxLogo.TabIndex = 19;
            this.pictureBoxLogo.TabStop = false;
            // 
            // buttonDeleteEntry
            // 
            this.buttonDeleteEntry.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonDeleteEntry.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonDeleteEntry.Location = new System.Drawing.Point(954, 712);
            this.buttonDeleteEntry.Name = "buttonDeleteEntry";
            this.buttonDeleteEntry.Size = new System.Drawing.Size(150, 50);
            this.buttonDeleteEntry.TabIndex = 28;
            this.buttonDeleteEntry.Text = "Delete Entry";
            this.buttonDeleteEntry.UseVisualStyleBackColor = false;
            // 
            // buttonUpdateEntry
            // 
            this.buttonUpdateEntry.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonUpdateEntry.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonUpdateEntry.Location = new System.Drawing.Point(798, 712);
            this.buttonUpdateEntry.Name = "buttonUpdateEntry";
            this.buttonUpdateEntry.Size = new System.Drawing.Size(150, 50);
            this.buttonUpdateEntry.TabIndex = 27;
            this.buttonUpdateEntry.Text = "Update Entry";
            this.buttonUpdateEntry.UseVisualStyleBackColor = false;
            // 
            // buttonNewEntry
            // 
            this.buttonNewEntry.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonNewEntry.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonNewEntry.Location = new System.Drawing.Point(642, 712);
            this.buttonNewEntry.Name = "buttonNewEntry";
            this.buttonNewEntry.Size = new System.Drawing.Size(150, 50);
            this.buttonNewEntry.TabIndex = 26;
            this.buttonNewEntry.Text = "New Entry";
            this.buttonNewEntry.UseVisualStyleBackColor = false;
            // 
            // ServicesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(1395, 943);
            this.Controls.Add(this.buttonDeleteEntry);
            this.Controls.Add(this.buttonUpdateEntry);
            this.Controls.Add(this.buttonNewEntry);
            this.Controls.Add(this.dataGridViewInventory);
            this.Controls.Add(this.labelFormName);
            this.Controls.Add(this.labelSystemName);
            this.Controls.Add(this.pictureBoxLogo);
            this.Name = "ServicesForm";
            this.Text = "ServicesForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInventory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelFormName;
        private System.Windows.Forms.Label labelSystemName;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.DataGridView dataGridViewInventory;
        private System.Windows.Forms.Button buttonDeleteEntry;
        private System.Windows.Forms.Button buttonUpdateEntry;
        private System.Windows.Forms.Button buttonNewEntry;
    }
}