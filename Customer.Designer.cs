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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Save_btn = new System.Windows.Forms.Button();
            this.Reset_btn = new System.Windows.Forms.Button();
            this.Custid_tb = new System.Windows.Forms.TextBox();
            this.Cname_tb = new System.Windows.Forms.TextBox();
            this.Mobno_tb = new System.Windows.Forms.TextBox();
            this.Address_tb = new System.Windows.Forms.TextBox();
            this.Male_rbtn = new System.Windows.Forms.RadioButton();
            this.Female_rbtn = new System.Windows.Forms.RadioButton();
            this.DGV_cust = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.Search_tb = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_cust)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkRed;
            this.label1.Location = new System.Drawing.Point(355, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(456, 51);
            this.label1.TabIndex = 1;
            this.label1.Text = "Customer Information";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(36, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 29);
            this.label2.TabIndex = 2;
            this.label2.Text = "Customer Id:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(36, 186);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 29);
            this.label3.TabIndex = 3;
            this.label3.Text = "Name:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(36, 248);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(141, 29);
            this.label4.TabIndex = 4;
            this.label4.Text = "Mobile No:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(36, 302);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 29);
            this.label5.TabIndex = 5;
            this.label5.Text = "Gender:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(36, 361);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(116, 29);
            this.label6.TabIndex = 6;
            this.label6.Text = "Address:";
            // 
            // Save_btn
            // 
            this.Save_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Save_btn.Location = new System.Drawing.Point(336, 471);
            this.Save_btn.Name = "Save_btn";
            this.Save_btn.Size = new System.Drawing.Size(131, 50);
            this.Save_btn.TabIndex = 7;
            this.Save_btn.Text = "Save";
            this.Save_btn.UseVisualStyleBackColor = true;
            this.Save_btn.Click += new System.EventHandler(this.Save_btn_Click);
            // 
            // Reset_btn
            // 
            this.Reset_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Reset_btn.Location = new System.Drawing.Point(546, 471);
            this.Reset_btn.Name = "Reset_btn";
            this.Reset_btn.Size = new System.Drawing.Size(131, 50);
            this.Reset_btn.TabIndex = 9;
            this.Reset_btn.Text = "Reset";
            this.Reset_btn.UseVisualStyleBackColor = true;
            this.Reset_btn.Click += new System.EventHandler(this.Reset_btn_Click);
            // 
            // Custid_tb
            // 
            this.Custid_tb.Location = new System.Drawing.Point(243, 134);
            this.Custid_tb.Name = "Custid_tb";
            this.Custid_tb.Size = new System.Drawing.Size(133, 22);
            this.Custid_tb.TabIndex = 10;
            // 
            // Cname_tb
            // 
            this.Cname_tb.Location = new System.Drawing.Point(243, 193);
            this.Cname_tb.Name = "Cname_tb";
            this.Cname_tb.Size = new System.Drawing.Size(133, 22);
            this.Cname_tb.TabIndex = 11;
            // 
            // Mobno_tb
            // 
            this.Mobno_tb.Location = new System.Drawing.Point(243, 255);
            this.Mobno_tb.Name = "Mobno_tb";
            this.Mobno_tb.Size = new System.Drawing.Size(133, 22);
            this.Mobno_tb.TabIndex = 12;
            // 
            // Address_tb
            // 
            this.Address_tb.Location = new System.Drawing.Point(243, 368);
            this.Address_tb.Name = "Address_tb";
            this.Address_tb.Size = new System.Drawing.Size(133, 22);
            this.Address_tb.TabIndex = 14;
            // 
            // Male_rbtn
            // 
            this.Male_rbtn.AutoSize = true;
            this.Male_rbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Male_rbtn.Location = new System.Drawing.Point(245, 307);
            this.Male_rbtn.Name = "Male_rbtn";
            this.Male_rbtn.Size = new System.Drawing.Size(70, 24);
            this.Male_rbtn.TabIndex = 15;
            this.Male_rbtn.TabStop = true;
            this.Male_rbtn.Text = "Male";
            this.Male_rbtn.UseVisualStyleBackColor = true;
            // 
            // Female_rbtn
            // 
            this.Female_rbtn.AutoSize = true;
            this.Female_rbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Female_rbtn.Location = new System.Drawing.Point(364, 307);
            this.Female_rbtn.Name = "Female_rbtn";
            this.Female_rbtn.Size = new System.Drawing.Size(91, 24);
            this.Female_rbtn.TabIndex = 16;
            this.Female_rbtn.TabStop = true;
            this.Female_rbtn.Text = "Female";
            this.Female_rbtn.UseVisualStyleBackColor = true;
            // 
            // DGV_cust
            // 
            this.DGV_cust.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_cust.Location = new System.Drawing.Point(718, 107);
            this.DGV_cust.Name = "DGV_cust";
            this.DGV_cust.RowHeadersWidth = 51;
            this.DGV_cust.RowTemplate.Height = 24;
            this.DGV_cust.Size = new System.Drawing.Size(427, 292);
            this.DGV_cust.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(36, 409);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(102, 29);
            this.label7.TabIndex = 18;
            this.label7.Text = "Search:";
            // 
            // Search_tb
            // 
            this.Search_tb.Location = new System.Drawing.Point(243, 425);
            this.Search_tb.Name = "Search_tb";
            this.Search_tb.Size = new System.Drawing.Size(657, 22);
            this.Search_tb.TabIndex = 21;
            this.Search_tb.TextChanged += new System.EventHandler(this.Search_tb_TextChanged);
            // 
            // Customer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1176, 549);
            this.Controls.Add(this.Search_tb);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.DGV_cust);
            this.Controls.Add(this.Female_rbtn);
            this.Controls.Add(this.Male_rbtn);
            this.Controls.Add(this.Address_tb);
            this.Controls.Add(this.Mobno_tb);
            this.Controls.Add(this.Cname_tb);
            this.Controls.Add(this.Custid_tb);
            this.Controls.Add(this.Reset_btn);
            this.Controls.Add(this.Save_btn);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Customer";
            this.Text = "Customer";
            this.Load += new System.EventHandler(this.Customer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_cust)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button Save_btn;
        private System.Windows.Forms.Button Reset_btn;
        private System.Windows.Forms.TextBox Custid_tb;
        private System.Windows.Forms.TextBox Cname_tb;
        private System.Windows.Forms.TextBox Mobno_tb;
        private System.Windows.Forms.TextBox Address_tb;
        private System.Windows.Forms.RadioButton Male_rbtn;
        private System.Windows.Forms.RadioButton Female_rbtn;
        private System.Windows.Forms.DataGridView DGV_cust;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox Search_tb;
    }
}