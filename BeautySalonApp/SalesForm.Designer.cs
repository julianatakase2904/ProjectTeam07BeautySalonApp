namespace BeautySalonApp
{
    partial class SalesForm
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
            this.labelSystemName = new System.Windows.Forms.Label();
            this.labelFormName = new System.Windows.Forms.Label();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.dataGridViewSales = new System.Windows.Forms.DataGridView();
            this.btnReload = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSales)).BeginInit();
            this.SuspendLayout();
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
            this.labelFormName.Size = new System.Drawing.Size(62, 20);
            this.labelFormName.TabIndex = 18;
            this.labelFormName.Text = "SALES";
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
            // dataGridViewSales
            // 
            this.dataGridViewSales.AllowUserToAddRows = false;
            this.dataGridViewSales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSales.Location = new System.Drawing.Point(12, 219);
            this.dataGridViewSales.Name = "dataGridViewSales";
            this.dataGridViewSales.ReadOnly = true;
            this.dataGridViewSales.Size = new System.Drawing.Size(909, 261);
            this.dataGridViewSales.TabIndex = 23;
            // 
            // btnReload
            // 
            this.btnReload.Location = new System.Drawing.Point(427, 502);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(75, 23);
            this.btnReload.TabIndex = 24;
            this.btnReload.Text = "Reload";
            this.btnReload.UseVisualStyleBackColor = true;
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
            // 
            // SalesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(930, 613);
            this.Controls.Add(this.btnReload);
            this.Controls.Add(this.dataGridViewSales);
            this.Controls.Add(this.labelFormName);
            this.Controls.Add(this.labelSystemName);
            this.Controls.Add(this.pictureBoxLogo);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "SalesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SalesForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSales)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.Label labelSystemName;
        private System.Windows.Forms.Label labelFormName;
        private System.Windows.Forms.DataGridView dataGridViewSales;
        private System.Windows.Forms.Button btnReload;
    }
}