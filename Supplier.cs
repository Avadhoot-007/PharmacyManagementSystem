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
    public partial class Supplier : Form
    {
        OleDbCommand cmd;
        OleDbConnection conn;
        OleDbDataAdapter adapter;
        DataTable dt;
        public Supplier()
        {
            InitializeComponent();
        }

        void GetSupplier()
        {
            conn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=E:\\College\\Project\\Database\\PharmaDb.accdb");
            dt = new DataTable();
            adapter = new OleDbDataAdapter("SELECT *FROM SupplierTb", conn);
            conn.Open();
            adapter.Fill(dt);
            DGV_supp.DataSource = dt;
            conn.Close();

        }
        private void Save_btn_Click(object sender, EventArgs e)
        {
            string checkQuery = "SELECT COUNT(*) FROM SupplierTb WHERE Sname = @sname";
            cmd = new OleDbCommand(checkQuery, conn);
            cmd.Parameters.AddWithValue("@sname", Sname_tb.Text);
            conn.Open();

            int existingSupplierCount = (int)cmd.ExecuteScalar();
            conn.Close();

            if (existingSupplierCount > 0)
            {
                MessageBox.Show("An Supplierr with the Name and Mobile No. already exists.");
            }
            else
            {
                // Insert a new record
                string insertQuery = "INSERT INTO SupplierTb(Sname, Address, Mobno,Email,Scode) VALUES" +
                    "(@sname, @address, @mobno,@email,@scode)";
                cmd = new OleDbCommand(insertQuery, conn);
                cmd.Parameters.AddWithValue("@sname", Sname_tb.Text);
                cmd.Parameters.AddWithValue("@address", Address_tb.Text);
                cmd.Parameters.AddWithValue("@mobno", Mobno_tb.Text);
                cmd.Parameters.AddWithValue("@email", Email_tb.Text);
                cmd.Parameters.AddWithValue("@scode", Scode_tb.Text);

                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();

                MessageBox.Show("Supplier Inserted.");
                GetSupplier();
            }
        }

        private void Reset_btn_Click(object sender, EventArgs e)
        {
            Clear();
        }
        void Clear()
        {
            Supid_tb.Clear();
            Sname_tb.Clear();
            Address_tb.Clear();
            Mobno_tb.Clear();
            Email_tb.Clear();
            Scode_tb.Clear();
            Supid_tb.Focus();

        }

        private void Supplier_Load(object sender, EventArgs e)
        {
            GetSupplier();
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

            DGV_supp.DataSource = dv;
        }
        }
    }
 
