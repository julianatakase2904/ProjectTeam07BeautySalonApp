namespace BeautySalonApp
{
    partial class InventoryForm
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
            this.dataGridViewInventory = new System.Windows.Forms.DataGridView();
            this.buttonNewProduct = new System.Windows.Forms.Button();
            this.labelSystemName = new System.Windows.Forms.Label();
            this.labelFormName = new System.Windows.Forms.Label();
            this.buttonUpdateProduct = new System.Windows.Forms.Button();
            this.buttonDeleteProduct = new System.Windows.Forms.Button();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInventory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.SuspendLayout();
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
            this.dataGridViewInventory.TabIndex = 0;
            // 
            // buttonNewProduct
            // 
            this.buttonNewProduct.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonNewProduct.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonNewProduct.Location = new System.Drawing.Point(642, 712);
            this.buttonNewProduct.Name = "buttonNewProduct";
            this.buttonNewProduct.Size = new System.Drawing.Size(150, 50);
            this.buttonNewProduct.TabIndex = 1;
            this.buttonNewProduct.Text = "New Product";
            this.buttonNewProduct.UseVisualStyleBackColor = false;
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
            this.labelSystemName.TabIndex = 17;
            this.labelSystemName.Text = "Beauty Salon - Management System";
            // 
            // labelFormName
            // 
            this.labelFormName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelFormName.AutoSize = true;
            this.labelFormName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFormName.Location = new System.Drawing.Point(635, 166);
            this.labelFormName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelFormName.Name = "labelFormName";
            this.labelFormName.Size = new System.Drawing.Size(154, 29);
            this.labelFormName.TabIndex = 18;
            this.labelFormName.Text = "INVENTORY";
            // 
            // buttonUpdateProduct
            // 
            this.buttonUpdateProduct.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonUpdateProduct.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonUpdateProduct.Location = new System.Drawing.Point(798, 712);
            this.buttonUpdateProduct.Name = "buttonUpdateProduct";
            this.buttonUpdateProduct.Size = new System.Drawing.Size(150, 50);
            this.buttonUpdateProduct.TabIndex = 20;
            this.buttonUpdateProduct.Text = "Update Product";
            this.buttonUpdateProduct.UseVisualStyleBackColor = false;
            // 
            // buttonDeleteProduct
            // 
            this.buttonDeleteProduct.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonDeleteProduct.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonDeleteProduct.Location = new System.Drawing.Point(954, 712);
            this.buttonDeleteProduct.Name = "buttonDeleteProduct";
            this.buttonDeleteProduct.Size = new System.Drawing.Size(150, 50);
            this.buttonDeleteProduct.TabIndex = 21;
            this.buttonDeleteProduct.Text = "Delete Product";
            this.buttonDeleteProduct.UseVisualStyleBackColor = false;
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.Image = global::BeautySalonApp.Properties.Resources.BeautySalon12;
            this.pictureBoxLogo.Location = new System.Drawing.Point(68, 60);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(120, 135);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxLogo.TabIndex = 2;
            this.pictureBoxLogo.TabStop = false;
            // 
            // InventoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(1395, 943);
            this.Controls.Add(this.buttonDeleteProduct);
            this.Controls.Add(this.buttonUpdateProduct);
            this.Controls.Add(this.labelFormName);
            this.Controls.Add(this.labelSystemName);
            this.Controls.Add(this.pictureBoxLogo);
            this.Controls.Add(this.buttonNewProduct);
            this.Controls.Add(this.dataGridViewInventory);
            this.Name = "InventoryForm";
            this.Text = "InventoryForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInventory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewInventory;
        private System.Windows.Forms.Button buttonNewProduct;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.Label labelSystemName;
        private System.Windows.Forms.Label labelFormName;
        private System.Windows.Forms.Button buttonUpdateProduct;
        private System.Windows.Forms.Button buttonDeleteProduct;
    }
}