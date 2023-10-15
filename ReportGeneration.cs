using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;

namespace PharmacyManagementSystem
{
    public partial class ReportGeneration : Form
    {
        public ReportGeneration()
        {
            InitializeComponent();
        }

        private void Emp_report_Click(object sender, EventArgs e)
        {
            ReportDocument reportDocument = new ReportDocument();
            reportDocument.Load("E:\\College\\Project\\PharmacyManagementSystem\\Emp.rpt");
            crystalReportViewer1.Refresh();
            crystalReportViewer1.ReportSource = reportDocument;
        }

        private void Cust_report_Click(object sender, EventArgs e)
        {
            ReportDocument reportDocument = new ReportDocument();
            reportDocument.Load("E:\\College\\Project\\PharmacyManagementSystem\\Cust.rpt");
            crystalReportViewer1.Refresh();
            crystalReportViewer1.ReportSource = reportDocument;
        }

        private void Sup_rpt_Click(object sender, EventArgs e)
        {
            ReportDocument reportDocument = new ReportDocument();
            reportDocument.Load("E:\\College\\Project\\PharmacyManagementSystem\\Sup.rpt");
            crystalReportViewer1.Refresh();
            crystalReportViewer1.ReportSource = reportDocument;
        }

        private void Prod_rpt_Click(object sender, EventArgs e)
        {
            ReportDocument reportDocument = new ReportDocument();
            reportDocument.Load("E:\\College\\Project\\PharmacyManagementSystem\\Prod.rpt");
            crystalReportViewer1.Refresh();
            crystalReportViewer1.ReportSource = reportDocument;
        }

        private void Sales_rpt_Click(object sender, EventArgs e)
        {
            ReportDocument reportDocument = new ReportDocument();
            reportDocument.Load("E:\\College\\Project\\PharmacyManagementSystem\\Sal.rpt");
            crystalReportViewer1.Refresh();
            crystalReportViewer1.ReportSource = reportDocument;
        }

        private void Inv_rpt_Click(object sender, EventArgs e)
        {
            ReportDocument reportDocument = new ReportDocument();
            reportDocument.Load("E:\\College\\Project\\PharmacyManagementSystem\\Inv.rpt");
            crystalReportViewer1.Refresh();
            crystalReportViewer1.ReportSource = reportDocument;
        }
    }
}
