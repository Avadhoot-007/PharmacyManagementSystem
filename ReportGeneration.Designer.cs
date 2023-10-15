namespace PharmacyManagementSystem
{
    partial class ReportGeneration
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
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.Emp_rpt = new System.Windows.Forms.Button();
            this.Cust_rpt = new System.Windows.Forms.Button();
            this.Sup_rpt = new System.Windows.Forms.Button();
            this.Sales_rpt = new System.Windows.Forms.Button();
            this.Prod_rpt = new System.Windows.Forms.Button();
            this.Inv_rpt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = -1;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalReportViewer1.Location = new System.Drawing.Point(0, 0);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.Size = new System.Drawing.Size(1148, 573);
            this.crystalReportViewer1.TabIndex = 0;
            // 
            // Emp_rpt
            // 
            this.Emp_rpt.Location = new System.Drawing.Point(26, 47);
            this.Emp_rpt.Name = "Emp_rpt";
            this.Emp_rpt.Size = new System.Drawing.Size(139, 60);
            this.Emp_rpt.TabIndex = 1;
            this.Emp_rpt.Text = "Employee Reports";
            this.Emp_rpt.UseVisualStyleBackColor = true;
            this.Emp_rpt.Click += new System.EventHandler(this.Emp_report_Click);
            // 
            // Cust_rpt
            // 
            this.Cust_rpt.Location = new System.Drawing.Point(26, 126);
            this.Cust_rpt.Name = "Cust_rpt";
            this.Cust_rpt.Size = new System.Drawing.Size(139, 76);
            this.Cust_rpt.TabIndex = 2;
            this.Cust_rpt.Text = "Customer Reports";
            this.Cust_rpt.UseVisualStyleBackColor = true;
            this.Cust_rpt.Click += new System.EventHandler(this.Cust_report_Click);
            // 
            // Sup_rpt
            // 
            this.Sup_rpt.Location = new System.Drawing.Point(26, 220);
            this.Sup_rpt.Name = "Sup_rpt";
            this.Sup_rpt.Size = new System.Drawing.Size(139, 60);
            this.Sup_rpt.TabIndex = 3;
            this.Sup_rpt.Text = "Supplier Reports";
            this.Sup_rpt.UseVisualStyleBackColor = true;
            this.Sup_rpt.Click += new System.EventHandler(this.Sup_rpt_Click);
            // 
            // Sales_rpt
            // 
            this.Sales_rpt.Location = new System.Drawing.Point(26, 378);
            this.Sales_rpt.Name = "Sales_rpt";
            this.Sales_rpt.Size = new System.Drawing.Size(139, 60);
            this.Sales_rpt.TabIndex = 4;
            this.Sales_rpt.Text = "Sales Reports";
            this.Sales_rpt.UseVisualStyleBackColor = true;
            this.Sales_rpt.Click += new System.EventHandler(this.Sales_rpt_Click);
            // 
            // Prod_rpt
            // 
            this.Prod_rpt.Location = new System.Drawing.Point(26, 295);
            this.Prod_rpt.Name = "Prod_rpt";
            this.Prod_rpt.Size = new System.Drawing.Size(139, 60);
            this.Prod_rpt.TabIndex = 5;
            this.Prod_rpt.Text = "Product Reports";
            this.Prod_rpt.UseVisualStyleBackColor = true;
            this.Prod_rpt.Click += new System.EventHandler(this.Prod_rpt_Click);
            // 
            // Inv_rpt
            // 
            this.Inv_rpt.Location = new System.Drawing.Point(26, 460);
            this.Inv_rpt.Name = "Inv_rpt";
            this.Inv_rpt.Size = new System.Drawing.Size(139, 60);
            this.Inv_rpt.TabIndex = 6;
            this.Inv_rpt.Text = "Inventory Reports";
            this.Inv_rpt.UseVisualStyleBackColor = true;
            this.Inv_rpt.Click += new System.EventHandler(this.Inv_rpt_Click);
            // 
            // ReportGeneration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1148, 573);
            this.Controls.Add(this.Inv_rpt);
            this.Controls.Add(this.Prod_rpt);
            this.Controls.Add(this.Sales_rpt);
            this.Controls.Add(this.Sup_rpt);
            this.Controls.Add(this.Cust_rpt);
            this.Controls.Add(this.Emp_rpt);
            this.Controls.Add(this.crystalReportViewer1);
            this.Name = "ReportGeneration";
            this.Text = "ReportGeneration";
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        private System.Windows.Forms.Button Emp_rpt;
        private System.Windows.Forms.Button Cust_rpt;
        private System.Windows.Forms.Button Sup_rpt;
        private System.Windows.Forms.Button Sales_rpt;
        private System.Windows.Forms.Button Prod_rpt;
        private System.Windows.Forms.Button Inv_rpt;
    }
}