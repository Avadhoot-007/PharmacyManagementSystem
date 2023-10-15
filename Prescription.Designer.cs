namespace PharmacyManagementSystem
{
    partial class Prescription
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
            this.Presid_tb = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Presmed_tb = new System.Windows.Forms.TextBox();
            this.Dname_tb = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.Search_tb = new System.Windows.Forms.TextBox();
            this.Insert_btn = new System.Windows.Forms.Button();
            this.Update_btn = new System.Windows.Forms.Button();
            this.Clear_btn = new System.Windows.Forms.Button();
            this.DGV_pres = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.Pname_tb = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_pres)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkRed;
            this.label1.Location = new System.Drawing.Point(306, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(537, 51);
            this.label1.TabIndex = 23;
            this.label1.Text = "Prescription Management";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(29, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(222, 36);
            this.label2.TabIndex = 24;
            this.label2.Text = "Prescription Id";
            // 
            // Presid_tb
            // 
            this.Presid_tb.Enabled = false;
            this.Presid_tb.Location = new System.Drawing.Point(360, 124);
            this.Presid_tb.Name = "Presid_tb";
            this.Presid_tb.Size = new System.Drawing.Size(216, 22);
            this.Presid_tb.TabIndex = 25;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(29, 174);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(305, 36);
            this.label3.TabIndex = 26;
            this.label3.Text = "Prescribed Medicine";
            // 
            // Presmed_tb
            // 
            this.Presmed_tb.Enabled = false;
            this.Presmed_tb.Location = new System.Drawing.Point(360, 188);
            this.Presmed_tb.Name = "Presmed_tb";
            this.Presmed_tb.Size = new System.Drawing.Size(216, 22);
            this.Presmed_tb.TabIndex = 27;
            // 
            // Dname_tb
            // 
            this.Dname_tb.Enabled = false;
            this.Dname_tb.Location = new System.Drawing.Point(360, 268);
            this.Dname_tb.Name = "Dname_tb";
            this.Dname_tb.Size = new System.Drawing.Size(216, 22);
            this.Dname_tb.TabIndex = 28;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(29, 254);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(222, 36);
            this.label4.TabIndex = 29;
            this.label4.Text = "Doctor\'s Name\r\n";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(29, 396);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(115, 36);
            this.label9.TabIndex = 30;
            this.label9.Text = "Search";
            // 
            // Search_tb
            // 
            this.Search_tb.Location = new System.Drawing.Point(360, 409);
            this.Search_tb.Name = "Search_tb";
            this.Search_tb.Size = new System.Drawing.Size(358, 22);
            this.Search_tb.TabIndex = 31;
            this.Search_tb.TextChanged += new System.EventHandler(this.Search_tb_TextChanged);
            // 
            // Insert_btn
            // 
            this.Insert_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Insert_btn.Location = new System.Drawing.Point(192, 490);
            this.Insert_btn.Name = "Insert_btn";
            this.Insert_btn.Size = new System.Drawing.Size(167, 50);
            this.Insert_btn.TabIndex = 32;
            this.Insert_btn.Text = "Insert";
            this.Insert_btn.UseVisualStyleBackColor = true;
            this.Insert_btn.Click += new System.EventHandler(this.Insert_btn_Click);
            // 
            // Update_btn
            // 
            this.Update_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Update_btn.Location = new System.Drawing.Point(461, 490);
            this.Update_btn.Name = "Update_btn";
            this.Update_btn.Size = new System.Drawing.Size(185, 50);
            this.Update_btn.TabIndex = 33;
            this.Update_btn.Text = "Update";
            this.Update_btn.UseVisualStyleBackColor = true;
            this.Update_btn.Click += new System.EventHandler(this.Update_btn_Click);
            // 
            // Clear_btn
            // 
            this.Clear_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Clear_btn.Location = new System.Drawing.Point(718, 490);
            this.Clear_btn.Name = "Clear_btn";
            this.Clear_btn.Size = new System.Drawing.Size(167, 50);
            this.Clear_btn.TabIndex = 34;
            this.Clear_btn.Text = "Clear";
            this.Clear_btn.UseVisualStyleBackColor = true;
            this.Clear_btn.Click += new System.EventHandler(this.Clear_btn_Click);
            // 
            // DGV_pres
            // 
            this.DGV_pres.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_pres.Location = new System.Drawing.Point(742, 100);
            this.DGV_pres.Name = "DGV_pres";
            this.DGV_pres.RowHeadersWidth = 51;
            this.DGV_pres.RowTemplate.Height = 24;
            this.DGV_pres.Size = new System.Drawing.Size(377, 288);
            this.DGV_pres.TabIndex = 35;
            this.DGV_pres.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_pres_CellEnter);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(29, 319);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(227, 36);
            this.label5.TabIndex = 36;
            this.label5.Text = "Patient\'s Name\r\n";
            // 
            // Pname_tb
            // 
            this.Pname_tb.Enabled = false;
            this.Pname_tb.Location = new System.Drawing.Point(360, 332);
            this.Pname_tb.Name = "Pname_tb";
            this.Pname_tb.Size = new System.Drawing.Size(216, 22);
            this.Pname_tb.TabIndex = 37;
            // 
            // Prescription
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1131, 613);
            this.Controls.Add(this.Pname_tb);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.DGV_pres);
            this.Controls.Add(this.Clear_btn);
            this.Controls.Add(this.Update_btn);
            this.Controls.Add(this.Insert_btn);
            this.Controls.Add(this.Search_tb);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Dname_tb);
            this.Controls.Add(this.Presmed_tb);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Presid_tb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Prescription";
            this.Text = "Prescription";
            this.Load += new System.EventHandler(this.Prescription_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_pres)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Presid_tb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Presmed_tb;
        private System.Windows.Forms.TextBox Dname_tb;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox Search_tb;
        private System.Windows.Forms.Button Insert_btn;
        private System.Windows.Forms.Button Update_btn;
        private System.Windows.Forms.Button Clear_btn;
        private System.Windows.Forms.DataGridView DGV_pres;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Pname_tb;
    }
}