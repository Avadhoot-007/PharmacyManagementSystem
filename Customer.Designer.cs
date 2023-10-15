namespace PharmacyManagementSystem
{
    partial class Customer
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
            this.Save_btn = new System.Windows.Forms.Button();
            this.Reset_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Cname_tb = new System.Windows.Forms.TextBox();
            this.Custid_tb = new System.Windows.Forms.TextBox();
            this.Mobno_tb = new System.Windows.Forms.TextBox();
            this.Address_tb = new System.Windows.Forms.TextBox();
            this.Search_tb = new System.Windows.Forms.TextBox();
            this.DGV_cust = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_cust)).BeginInit();
            this.SuspendLayout();
            // 
            // Save_btn
            // 
            this.Save_btn.Location = new System.Drawing.Point(287, 423);
            this.Save_btn.Name = "Save_btn";
            this.Save_btn.Size = new System.Drawing.Size(75, 23);
            this.Save_btn.TabIndex = 0;
            this.Save_btn.Text = "save";
            this.Save_btn.UseVisualStyleBackColor = true;
            // 
            // Reset_btn
            // 
            this.Reset_btn.Location = new System.Drawing.Point(524, 422);
            this.Reset_btn.Name = "Reset_btn";
            this.Reset_btn.Size = new System.Drawing.Size(75, 23);
            this.Reset_btn.TabIndex = 1;
            this.Reset_btn.Text = "reset";
            this.Reset_btn.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(156, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "label1";
            // 
            // Cname_tb
            // 
            this.Cname_tb.Location = new System.Drawing.Point(644, 188);
            this.Cname_tb.Name = "Cname_tb";
            this.Cname_tb.Size = new System.Drawing.Size(100, 22);
            this.Cname_tb.TabIndex = 3;
            // 
            // Custid_tb
            // 
            this.Custid_tb.Location = new System.Drawing.Point(644, 108);
            this.Custid_tb.Name = "Custid_tb";
            this.Custid_tb.Size = new System.Drawing.Size(100, 22);
            this.Custid_tb.TabIndex = 4;
            // 
            // Mobno_tb
            // 
            this.Mobno_tb.Location = new System.Drawing.Point(657, 257);
            this.Mobno_tb.Name = "Mobno_tb";
            this.Mobno_tb.Size = new System.Drawing.Size(100, 22);
            this.Mobno_tb.TabIndex = 5;
            // 
            // Address_tb
            // 
            this.Address_tb.Location = new System.Drawing.Point(524, 282);
            this.Address_tb.Name = "Address_tb";
            this.Address_tb.Size = new System.Drawing.Size(100, 22);
            this.Address_tb.TabIndex = 6;
            // 
            // Search_tb
            // 
            this.Search_tb.Location = new System.Drawing.Point(644, 360);
            this.Search_tb.Name = "Search_tb";
            this.Search_tb.Size = new System.Drawing.Size(100, 22);
            this.Search_tb.TabIndex = 7;
            // 
            // DGV_cust
            // 
            this.DGV_cust.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_cust.Location = new System.Drawing.Point(12, 188);
            this.DGV_cust.Name = "DGV_cust";
            this.DGV_cust.RowHeadersWidth = 51;
            this.DGV_cust.RowTemplate.Height = 24;
            this.DGV_cust.Size = new System.Drawing.Size(506, 204);
            this.DGV_cust.TabIndex = 8;
            // 
            // Customer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1148, 586);
            this.Controls.Add(this.DGV_cust);
            this.Controls.Add(this.Search_tb);
            this.Controls.Add(this.Address_tb);
            this.Controls.Add(this.Mobno_tb);
            this.Controls.Add(this.Custid_tb);
            this.Controls.Add(this.Cname_tb);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Reset_btn);
            this.Controls.Add(this.Save_btn);
            this.Name = "Customer";
            this.Text = "Customer";
            this.Load += new System.EventHandler(this.Customer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_cust)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Save_btn;
        private System.Windows.Forms.Button Reset_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Cname_tb;
        private System.Windows.Forms.TextBox Custid_tb;
        private System.Windows.Forms.TextBox Mobno_tb;
        private System.Windows.Forms.TextBox Address_tb;
        private System.Windows.Forms.TextBox Search_tb;
        private System.Windows.Forms.DataGridView DGV_cust;
    }
}