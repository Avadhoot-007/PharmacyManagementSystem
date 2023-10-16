using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PharmacyManagementSystem
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void Emp_btn_Click(object sender, EventArgs e)
        {
            Employee emp = new Employee();
            emp.Show();
        }

        private void Cust_btn_Click(object sender, EventArgs e)
        {
            Customer cust = new Customer();
            cust.Show();
        }

        private void Supplier_btn_Click(object sender, EventArgs e)
        {
            Supplier sup = new Supplier();
            sup.Show();
        }

        private void Products_btn_Click(object sender, EventArgs e)
        {
            Product prod = new Product();
            prod.Show();
        }

        private void Sales_btn_Click(object sender, EventArgs e)
        {
            Sales sal = new Sales();
            sal.Show();
        }

        private void Inventory_btn_Click(object sender, EventArgs e)
        {
            Inventory inv = new Inventory();
            inv.Show();
        }

        private void Exit_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Crystal_btn_Click(object sender, EventArgs e)
        {
            ReportGeneration reportGeneration = new ReportGeneration(); 
            reportGeneration.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Prescription prescription = new Prescription();
            prescription.Show();
        }

        private void Physician_btn_Click(object sender, EventArgs e)
        {
            Physician physician = new Physician();
            physician.Show();
        }

        private void Bill_btn_Click(object sender, EventArgs e)
        {
            BillGeneration billGeneration = new BillGeneration();  
            billGeneration.Show();
        }

        private void Payment_btn_Click(object sender, EventArgs e)
        {
            Payment payment = new Payment();    
            payment.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Company company = new Company();
            company.Show();
        }
    }
}