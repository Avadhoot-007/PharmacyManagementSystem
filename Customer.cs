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
    public partial class Customer : Form
    {
        OleDbCommand cmd;
        OleDbConnection conn;
        OleDbDataAdapter adapter;
        DataTable dt;
        public Customer()
        {
            InitializeComponent();

        }
        void GetCustomer()
        {
            conn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=E:\\College\\Project\\Database\\PharmaDb.accdb");
            dt = new DataTable();
            adapter = new OleDbDataAdapter("SELECT *FROM CustomerTb", conn);
            conn.Open();
            adapter.Fill(dt);
            DGV_cust.DataSource = dt;
            conn.Close();

        }

        private void Save_btn_Click(object sender, EventArgs e)
        {
            string checkQuery = "SELECT COUNT(*) FROM CustomerTb WHERE Cname = @Cname";
            cmd = new OleDbCommand(checkQuery, conn);
            cmd.Parameters.AddWithValue("@Cname", Cname_tb.Text);
            conn.Open();

            int existingCustomerCount = (int)cmd.ExecuteScalar();
            conn.Close();

            if (existingCustomerCount > 0)
            {
                MessageBox.Show("An Customer with the same Name and Mobile No. already exists.");
            }
            else
            {
                // Insert a new record
                string insertQuery = "INSERT INTO CustomerTb(Cname, Address, Mobno) VALUES" +
                    "(@Cname, @address, @mobno)";
                cmd = new OleDbCommand(insertQuery, conn);
                cmd.Parameters.AddWithValue("@cname", Cname_tb.Text);
                cmd.Parameters.AddWithValue("@address", Address_tb.Text);
                cmd.Parameters.AddWithValue("@mobno", Mobno_tb.Text);

                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();

                MessageBox.Show("Customer Inserted.");
                GetCustomer();
            }
        }

        private void Customer_Load(object sender, EventArgs e)
        {
            GetCustomer();
        }

        private void Reset_btn_Click(object sender, EventArgs e)
        {
            Clear();
        }
        void Clear()
        {
            Custid_tb.Clear();
            Cname_tb.Clear();
            Address_tb.Clear();
            Mobno_tb.Clear();
            Custid_tb.Focus();

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

            DGV_cust.DataSource = dv;
        }
    }
}
