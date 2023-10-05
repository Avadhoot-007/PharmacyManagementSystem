using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace PharmacyManagementSystem
{
    public partial class Employee : Form
    {
        OleDbCommand cmd;
        OleDbConnection conn;
        OleDbDataAdapter adapter;
        DataTable dt;
        public Employee()
        {
            InitializeComponent();
        }
        void GetEmployee()
        {
            conn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=E:\\College\\Project\\Database\\PharmaDb.accdb");
            dt = new DataTable();
            adapter = new OleDbDataAdapter("SELECT *FROM EmployeeTb", conn);
            conn.Open();
            adapter.Fill(dt);
            DGV_emp.DataSource = dt;
            conn.Close();

        }

        private void Insert_btn_Click(object sender, EventArgs e)
        {
            string checkQuery = "SELECT COUNT(*) FROM EmployeeTb WHERE Email = @email_Id";
            cmd = new OleDbCommand(checkQuery, conn);
            cmd.Parameters.AddWithValue("@email_Id", Email_tb.Text);
            conn.Open();

            int existingEmployeeCount = (int)cmd.ExecuteScalar();
            conn.Close();

            if (existingEmployeeCount > 0)
            {
                MessageBox.Show("An employee with the same email address and Mobile No. already exists.");
            }
            else
            {
                // Insert a new record
                string insertQuery = "INSERT INTO EmployeeTb(Ename, Address, Mobno, Email, Jobrole, Salary) VALUES" +
                    "(@ename, @address, @mobile, @email_Id, @job_Role, @salary)";
                cmd = new OleDbCommand(insertQuery, conn);
                cmd.Parameters.AddWithValue("@ename", Empname_tb.Text);
                cmd.Parameters.AddWithValue("@address", Address_tb.Text);
                cmd.Parameters.AddWithValue("@mobile", Mobno_tb.Text);
                cmd.Parameters.AddWithValue("@email_Id", Email_tb.Text);
                cmd.Parameters.AddWithValue("@job_Role", Jobrole_tb.Text);
                cmd.Parameters.AddWithValue("@salary", Salary_tb.Text);

                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();

                MessageBox.Show("Employee Inserted.");
                GetEmployee();
            }
        }

        private void Employee_Load(object sender, EventArgs e)
        {
            GetEmployee();

        }

        private void Search_tb_TextChanged(object sender, EventArgs e)
        {
            DataView dv = dt.DefaultView;

            // Initialize a filter string
            string filter = "";

            // Check and add filters for specific columns
            if (!string.IsNullOrWhiteSpace(Search_tb.Text))
            {
                foreach (DataColumn column in dt.Columns)
                {
                    if (column.DataType == typeof(string))
                    {
                        filter += column.ColumnName + " LIKE '%" + Search_tb.Text + "%' OR ";
                    }
                    else if (column.DataType == typeof(int))
                    {
                        // Check if the search text can be parsed as an integer
                        if (int.TryParse(Search_tb.Text, out int intValue))
                        {
                            filter += column.ColumnName + " = " + intValue + " OR ";
                        }
                    }
                }
            }

            // Remove the trailing " OR "
            if (!string.IsNullOrEmpty(filter))
            {
                filter = filter.Substring(0, filter.Length - 4); // Remove the last " OR "
            }

            // Apply the combined filter
            dv.RowFilter = filter;

            DGV_emp.DataSource = dv;
        }

        private void DGV_emp_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            Empid_tb.Text = DGV_emp.CurrentRow.Cells[0].Value.ToString();
            Empname_tb.Text = DGV_emp.CurrentRow.Cells[1].Value.ToString();
            Address_tb.Text = DGV_emp.CurrentRow.Cells[2].Value.ToString();
            Mobno_tb.Text = DGV_emp.CurrentRow.Cells[3].Value.ToString();
            Email_tb.Text = DGV_emp.CurrentRow.Cells[4].Value.ToString();
            Jobrole_tb.Text = DGV_emp.CurrentRow.Cells[5].Value.ToString();
            Salary_tb.Text = DGV_emp.CurrentRow.Cells[6].Value.ToString();
        }

        private void Update_btn_Click(object sender, EventArgs e)
        {
            string query = "UPDATE EmployeeTb SET Ename=@ename, Address=@address, Mobno=@mobile, Email=@email_Id, Jobrole=@job_Role, Salary=@salary " +
       "WHERE EmpiD=@id";

            cmd = new OleDbCommand(query, conn);
            cmd.Parameters.AddWithValue("@ename", Empname_tb.Text);
            cmd.Parameters.AddWithValue("@address", Address_tb.Text);
            cmd.Parameters.AddWithValue("@mobile", Mobno_tb.Text);
            cmd.Parameters.AddWithValue("@email_Id", Email_tb.Text);
            cmd.Parameters.AddWithValue("@job_Role", Jobrole_tb.Text);
            cmd.Parameters.AddWithValue("@salary", Salary_tb.Text);
            cmd.Parameters.AddWithValue("@id", Convert.ToInt32(Empid_tb.Text));
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Record Updated .");
            GetEmployee();
        }

        private void Clear_btn_Click(object sender, EventArgs e)
        {
            Clear();
        }
        void Clear()
        {
            Empid_tb.Clear();
            Empname_tb.Clear();
            Address_tb.Clear();
            Mobno_tb.Clear();
            Email_tb.Clear();
            Jobrole_tb.Clear();
            Salary_tb.Clear();
            Empid_tb.Focus();

        }
    }
}
