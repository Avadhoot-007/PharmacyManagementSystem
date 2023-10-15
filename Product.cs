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
using System.Diagnostics;

namespace PharmacyManagementSystem
{
    public partial class Product : Form
    {
        OleDbCommand cmd;
        OleDbConnection conn;
        OleDbDataAdapter adapter;
        DataTable dt;
        public Product()
        {
            InitializeComponent();
        }
                   
        void GetProduct()
        {
            conn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=E:\\College\\Project\\Database\\PharmaDb.accdb");
            dt = new DataTable();
            adapter = new OleDbDataAdapter("SELECT *FROM ProductTb", conn);
            conn.Open();
            adapter.Fill(dt);
            DGV_prod.DataSource = dt;
            conn.Close();

        }
        private void Product_Load(object sender, EventArgs e)
        {
            GetProduct();
        }

        private void Save_btn_Click(object sender, EventArgs e)
        {
            string checkQuery = "SELECT COUNT(*) FROM ProductTb WHERE Mname = @mname";
            cmd = new OleDbCommand(checkQuery, conn);
            cmd.Parameters.AddWithValue("@mname", Medname_tb.Text);
            conn.Open();

            int existingProductCount = (int)cmd.ExecuteScalar();
            conn.Close();

            if (existingProductCount > 0)
            {
                MessageBox.Show("An Product with the same Name already exists.");
            }
            else
            {
                // Insert a new record
                string insertQuery = "INSERT INTO ProductTb(Mname, Mfgdate, Expdate, Qty, Price) VALUES" +
                    "(@medname, @mfgdate, @expdate, @qty, @price)";
                cmd = new OleDbCommand(insertQuery, conn);
                cmd.Parameters.AddWithValue("@mname", Medname_tb.Text);
                cmd.Parameters.AddWithValue("@mfgdate", Mfg_tb.Text);
                cmd.Parameters.AddWithValue("@expdate", Exp_tb.Text);
                cmd.Parameters.AddWithValue("@qty", Qty_tb.Text);
                cmd.Parameters.AddWithValue("@price", Price_tb.Text);

                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();

                MessageBox.Show("Product Inserted.");
                GetProduct();
            }
        }

        private void Reset_btn_Click(object sender, EventArgs e)
        {
            Clear();
        }
        void Clear()
        {
            Medid_tb.Clear();
            Medname_tb.Clear();
            Mfg_tb.Clear();
            Exp_tb.Clear();
            Qty_tb.Clear();
            Price_tb.Clear();
            Medid_tb.Focus();

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

            DGV_prod.DataSource = dv;
        }

        private void Update_btn_Click(object sender, EventArgs e)
        {
            int mid = Convert.ToInt32(Medid_tb.Text);

            string query = "UPDATE ProductTb SET Mname=@mname, Mfgdate=@mfgdate, Expdate=@expdate, Qty=@qty, Price=@price WHERE Medid=@medid";

            cmd = new OleDbCommand(query, conn);
            cmd.Parameters.AddWithValue("@mname", Medname_tb.Text);
            cmd.Parameters.AddWithValue("@mfgdate", Mfg_tb.Text);
            cmd.Parameters.AddWithValue("@expdate", Exp_tb.Text);
            cmd.Parameters.AddWithValue("@qty", Qty_tb.Text);
            cmd.Parameters.AddWithValue("@price", Price_tb.Text);
            cmd.Parameters.AddWithValue("@medid", mid);

            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Record Updated.");
            GetProduct();
        }

        private void DGV_prod_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            Medid_tb.Text = DGV_prod.CurrentRow.Cells[0].Value.ToString();
            Medname_tb.Text = DGV_prod.CurrentRow.Cells[1].Value.ToString();
            Mfg_tb.Text = DGV_prod.CurrentRow.Cells[2].Value.ToString();
            Exp_tb.Text = DGV_prod.CurrentRow.Cells[3].Value.ToString();
            Qty_tb.Text = DGV_prod.CurrentRow.Cells[4].Value.ToString();
            Price_tb.Text = DGV_prod.CurrentRow.Cells[5].Value.ToString();
        }

    }
}
