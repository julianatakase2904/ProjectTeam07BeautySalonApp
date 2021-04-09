namespace BeautySalonApp
{
    partial class AddOrUpdatePaymentForm
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
            this.components = new System.ComponentModel.Container();
            this.btnOkay = new System.Windows.Forms.Button();
            this.labelAppointmentsOfTheDay = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxTax = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.dataGridViewAppointmentsOfTheDay = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAppointmentsOfTheDay)).BeginInit();
            this.SuspendLayout();
            // 
            // btnOkay
            // 
            this.btnOkay.Location = new System.Drawing.Point(598, 244);
            this.btnOkay.Margin = new System.Windows.Forms.Padding(2);
            this.btnOkay.Name = "btnOkay";
            this.btnOkay.Size = new System.Drawing.Size(87, 28);
            this.btnOkay.TabIndex = 5;
            this.btnOkay.Text = "Okay";
            this.btnOkay.UseVisualStyleBackColor = true;
            this.btnOkay.Click += new System.EventHandler(this.btnOkay_Click);
            // 
            // labelAppointmentsOfTheDay
            // 
            this.labelAppointmentsOfTheDay.AutoSize = true;
            this.labelAppointmentsOfTheDay.Location = new System.Drawing.Point(9, 19);
            this.labelAppointmentsOfTheDay.Name = "labelAppointmentsOfTheDay";
            this.labelAppointmentsOfTheDay.Size = new System.Drawing.Size(159, 13);
            this.labelAppointmentsOfTheDay.TabIndex = 10;
            this.labelAppointmentsOfTheDay.Text = "APPOINTMENTS OF THE DAY";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(689, 244);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(87, 28);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 244);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Tax";
            // 
            // textBoxTax
            // 
            this.textBoxTax.Location = new System.Drawing.Point(63, 241);
            this.textBoxTax.Name = "textBoxTax";
            this.textBoxTax.Size = new System.Drawing.Size(81, 20);
            this.textBoxTax.TabIndex = 12;
            this.textBoxTax.Text = "0";
            this.textBoxTax.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // dataGridViewAppointmentsOfTheDay
            // 
            this.dataGridViewAppointmentsOfTheDay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAppointmentsOfTheDay.Location = new System.Drawing.Point(12, 38);
            this.dataGridViewAppointmentsOfTheDay.Name = "dataGridViewAppointmentsOfTheDay";
            this.dataGridViewAppointmentsOfTheDay.RowHeadersWidth = 24;
            this.dataGridViewAppointmentsOfTheDay.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewAppointmentsOfTheDay.Size = new System.Drawing.Size(764, 197);
            this.dataGridViewAppointmentsOfTheDay.TabIndex = 13;
            // 
            // AddOrUpdatePaymentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(790, 280);
            this.Controls.Add(this.dataGridViewAppointmentsOfTheDay);
            this.Controls.Add(this.textBoxTax);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelAppointmentsOfTheDay);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOkay);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "AddOrUpdatePaymentForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add/Update Payment Form";
            this.Load += new System.EventHandler(this.AddOrUpdatePaymentForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAppointmentsOfTheDay)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnOkay;
        private System.Windows.Forms.Label labelAppointmentsOfTheDay;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxTax;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.DataGridView dataGridViewAppointmentsOfTheDay;
    }
}