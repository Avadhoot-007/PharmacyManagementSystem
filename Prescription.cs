using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PharmacyManagementSystem
{
    public partial class Prescription : Form
    {
        OleDbCommand cmd;
        OleDbConnection conn;
        OleDbDataAdapter adapter;
        DataTable dt;
        public Prescription()
        {
            InitializeComponent();
        }

        void GetPrescription()
        {
            conn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=E:\\College\\Project\\Database\\PharmaDb.accdb");
            dt = new DataTable();
            adapter = new OleDbDataAdapter("SELECT *FROM PrescriptionTb", conn);
            conn.Open();
            adapter.Fill(dt);
            DGV_pres.DataSource = dt;
            conn.Close();

        }

        private void Insert_btn_Click(object sender, EventArgs e)
        {
            string checkQuery = "SELECT COUNT(*) FROM PrescriptionTb WHERE Pname = @pname";
            cmd = new OleDbCommand(checkQuery, conn);
            cmd.Parameters.AddWithValue("@pname", Pname_tb.Text);
            conn.Open();

            int existingPrescriptionCount = (int)cmd.ExecuteScalar();
            conn.Close();

            if (existingPrescriptionCount > 0)
            {
                MessageBox.Show("An Patient with the same name already exists.");
            }
            else
            {
                // Insert a new record
                string insertQuery = "INSERT INTO PrescriptionTb(Pmed, Dname, Pname) VALUES" +
                    "(@pmed, @dname, @pname)";
                cmd = new OleDbCommand(insertQuery, conn);
                cmd.Parameters.AddWithValue("@pmed", Presmed_tb.Text);
                cmd.Parameters.AddWithValue("@dname", Dname_tb.Text);
                cmd.Parameters.AddWithValue("@pname", Pname_tb.Text);

                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();

                MessageBox.Show("Prescription Inserted.");
                GetPrescription();
            }
        }

        private void Prescription_Load(object sender, EventArgs e)
        {
            GetPrescription();
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

            DGV_pres.DataSource = dv;
        }

        private void Update_btn_Click(object sender, EventArgs e)
        {
            string query = "UPDATE PrescriptionTb SET Pmed=@pmed, Dname=@dname, Pname=@pname " +
                           "WHERE Presid = @pid";

            cmd = new OleDbCommand(query, conn);
            cmd.Parameters.AddWithValue("@pmed", Presmed_tb.Text);
            cmd.Parameters.AddWithValue("@dname", Dname_tb.Text);
            cmd.Parameters.AddWithValue("@pname", Pname_tb.Text);
            cmd.Parameters.AddWithValue("@pid", Convert.ToInt32(Presid_tb.Text));
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Record Updated.");
            GetPrescription();
        }


        private void Clear_btn_Click(object sender, EventArgs e)
        {
            Clear();
        }
        void Clear()
        {
            Presid_tb.Clear();
            Presmed_tb.Clear();
            Dname_tb.Clear();
            Pname_tb.Clear();
            Presid_tb.Focus();

        }

        private void DGV_pres_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            Presid_tb.Text = DGV_pres.CurrentRow.Cells[0].Value.ToString();
            Presmed_tb.Text = DGV_pres.CurrentRow.Cells[1].Value.ToString();
            Dname_tb.Text = DGV_pres.CurrentRow.Cells[2].Value.ToString();
            Pname_tb.Text = DGV_pres.CurrentRow.Cells[3].Value.ToString();
        }

        private void Presid_tb_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
