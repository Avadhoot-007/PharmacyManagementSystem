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
    public partial class Sales : Form
    {
        OleDbCommand cmd;
        OleDbConnection conn;
        OleDbDataAdapter adapter;
        DataTable dt;
        public Sales()
        {
            InitializeComponent();
        }
            void GetSales()
        {
            conn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=E:\\College\\Project\\Database\\PharmaDb.accdb");
            dt = new DataTable();
            adapter = new OleDbDataAdapter("SELECT * FROM SalesTb", conn);
            conn.Open();
            adapter.Fill(dt);
            DGV_sales.DataSource = dt;
            conn.Close();

        }
        private void Sales_Load(object sender, EventArgs e)
        {
            GetSales();
        }

        private void Save_btn_Click(object sender, EventArgs e)
        {
            string checkQuery = "SELECT COUNT(*) FROM SalesTb WHERE Cname = @cname";
            cmd = new OleDbCommand(checkQuery, conn);
            cmd.Parameters.AddWithValue("@cname", Cname_tb.Text);
            conn.Open();

            int existingSalesCount = (int)cmd.ExecuteScalar();
            conn.Close();

            if (existingSalesCount > 0)
            {
                MessageBox.Show("An Sale with the same Customer Name already exists.");
            }
            else
            {
                // Insert a new record
                string insertQuery = "INSERT INTO SalesTb(Cid, Cname, Mobno, Address, Mid, Mname, Price) VALUES" +
                    "(@cid, @cname, @mobno, @addr, @mid, @mname,@price)";
                cmd = new OleDbCommand(insertQuery, conn);
                cmd.Parameters.AddWithValue("@cid", Cid_tb.Text);
                cmd.Parameters.AddWithValue("@cname", Address_tb.Text);
                cmd.Parameters.AddWithValue("@mobno", Mobno_tb.Text);
                cmd.Parameters.AddWithValue("@addr", Address_tb.Text);
                cmd.Parameters.AddWithValue("@mid", Mid_tb.Text);
                cmd.Parameters.AddWithValue("@mname", Mname_tb.Text);
                cmd.Parameters.AddWithValue("@price", Price_tb.Text);

                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();

                MessageBox.Show("Employee Inserted.");
                GetSales();
            }
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

            DGV_sales.DataSource = dv;
        }
        private void Delete_btn_Click(object sender, EventArgs e)
        {
            Clear();
        }
        void Clear()
        {
            Salesid_tb.Clear();
            Cid_tb.Clear();
            Address_tb.Clear();
            Mobno_tb.Clear();
            Cname_tb.Clear();
            Mname_tb.Clear();
            Mid_tb.Clear();
            Price_tb.Clear();
            Cid_tb.Focus();

        }

        private void Update_btn_Click(object sender, EventArgs e)
        {
            string query = "UPDATE SalesTb SET Cid=@cid, Cname=@cname, Address=@address, Mobno=@mobile, Mid=@mid, Mname=@mname, Price=@price " +
       "WHERE Salesid=@id";

            cmd = new OleDbCommand(query, conn);
            cmd.Parameters.AddWithValue("@cid", Cid_tb.Text);
            cmd.Parameters.AddWithValue("@cname", Cname_tb.Text);
            cmd.Parameters.AddWithValue("@address", Address_tb.Text);
            cmd.Parameters.AddWithValue("@mobile", Mobno_tb.Text);
            cmd.Parameters.AddWithValue("@mid", Mid_tb.Text);
            cmd.Parameters.AddWithValue("@mname", Mname_tb.Text);
            cmd.Parameters.AddWithValue("@price", Price_tb.Text);
            cmd.Parameters.AddWithValue("@id", Convert.ToInt32(Salesid_tb.Text));
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Record Updated .");
            GetSales();
        }

        private void DGV_sales_CellEnter(object sender, DataGridViewCellEventArgs e)
        {

            Salesid_tb.Text = DGV_sales.CurrentRow.Cells[0].Value.ToString();
            Cid_tb.Text = DGV_sales.CurrentRow.Cells[1].Value.ToString();
            Cname_tb.Text = DGV_sales.CurrentRow.Cells[2].Value.ToString();
            Address_tb.Text = DGV_sales.CurrentRow.Cells[3].Value.ToString();
            Mobno_tb.Text = DGV_sales.CurrentRow.Cells[4].Value.ToString();
            Mid_tb.Text = DGV_sales.CurrentRow.Cells[5].Value.ToString();
            Mname_tb.Text = DGV_sales.CurrentRow.Cells[6].Value.ToString();
            Price_tb.Text = DGV_sales.CurrentRow.Cells[7].Value.ToString();
        }
    }
    }

