namespace BeautySalonApp
{
    partial class AddOrUpdateServiceForm
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
            this.labelServiceName = new System.Windows.Forms.Label();
            this.listBoxInventory = new System.Windows.Forms.ListBox();
            this.textBoxServiceName = new System.Windows.Forms.TextBox();
            this.textBoxServicePrice = new System.Windows.Forms.TextBox();
            this.labelServicePrice = new System.Windows.Forms.Label();
            this.buttonSubmit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelServiceName
            // 
            this.labelServiceName.AutoSize = true;
            this.labelServiceName.Location = new System.Drawing.Point(152, 68);
            this.labelServiceName.Name = "labelServiceName";
            this.labelServiceName.Size = new System.Drawing.Size(107, 20);
            this.labelServiceName.TabIndex = 0;
            this.labelServiceName.Text = "Service Name";
            // 
            // listBoxInventory
            // 
            this.listBoxInventory.FormattingEnabled = true;
            this.listBoxInventory.ItemHeight = 20;
            this.listBoxInventory.Location = new System.Drawing.Point(85, 260);
            this.listBoxInventory.Name = "listBoxInventory";
            this.listBoxInventory.Size = new System.Drawing.Size(255, 204);
            this.listBoxInventory.TabIndex = 1;
            // 
            // textBoxServiceName
            // 
            this.textBoxServiceName.Location = new System.Drawing.Point(156, 91);
            this.textBoxServiceName.Name = "textBoxServiceName";
            this.textBoxServiceName.Size = new System.Drawing.Size(100, 26);
            this.textBoxServiceName.TabIndex = 2;
            // 
            // textBoxServicePrice
            // 
            this.textBoxServicePrice.Location = new System.Drawing.Point(156, 180);
            this.textBoxServicePrice.Name = "textBoxServicePrice";
            this.textBoxServicePrice.Size = new System.Drawing.Size(100, 26);
            this.textBoxServicePrice.TabIndex = 4;
            // 
            // labelServicePrice
            // 
            this.labelServicePrice.AutoSize = true;
            this.labelServicePrice.Location = new System.Drawing.Point(156, 157);
            this.labelServicePrice.Name = "labelServicePrice";
            this.labelServicePrice.Size = new System.Drawing.Size(100, 20);
            this.labelServicePrice.TabIndex = 3;
            this.labelServicePrice.Text = "Service Price";
            // 
            // buttonSubmit
            // 
            this.buttonSubmit.Location = new System.Drawing.Point(156, 506);
            this.buttonSubmit.Name = "buttonSubmit";
            this.buttonSubmit.Size = new System.Drawing.Size(100, 32);
            this.buttonSubmit.TabIndex = 5;
            this.buttonSubmit.Text = "Submit";
            this.buttonSubmit.UseVisualStyleBackColor = true;
            // 
            // AddServiceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 585);
            this.Controls.Add(this.buttonSubmit);
            this.Controls.Add(this.textBoxServicePrice);
            this.Controls.Add(this.labelServicePrice);
            this.Controls.Add(this.textBoxServiceName);
            this.Controls.Add(this.listBoxInventory);
            this.Controls.Add(this.labelServiceName);
            this.Name = "AddServiceForm";
            this.Text = "AddServiceForm";
            this.Load += new System.EventHandler(this.AddServiceForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelServiceName;
        private System.Windows.Forms.ListBox listBoxInventory;
        private System.Windows.Forms.TextBox textBoxServiceName;
        private System.Windows.Forms.TextBox textBoxServicePrice;
        private System.Windows.Forms.Label labelServicePrice;
        private System.Windows.Forms.Button buttonSubmit;
    }
}