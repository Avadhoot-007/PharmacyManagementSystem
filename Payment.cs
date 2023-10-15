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
    public partial class Payment : Form
    {
        OleDbCommand cmd;
        OleDbConnection conn;
        OleDbDataAdapter adapter;
        DataTable dt;
        public Payment()
        {
            InitializeComponent();
        }

        void GetPayment()
        {
            conn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=E:\\College\\Project\\Database\\PharmaDb.accdb");
            dt = new DataTable();
            adapter = new OleDbDataAdapter("SELECT *FROM PaymentTb", conn);
            conn.Open();
            adapter.Fill(dt);
            DGV_payment.DataSource = dt;
            conn.Close();

        }

        private void Save_btn_Click(object sender, EventArgs e)
        {
            string paymentmode;
            if (Cash_rbtn.Checked==true) 
            {
                paymentmode="Cash";
            }
            else
            {
                paymentmode="Online";
            }
            string checkQuery = "SELECT COUNT(*) FROM PaymentTb WHERE Salesid  = @sid";
            cmd = new OleDbCommand(checkQuery, conn);
            cmd.Parameters.AddWithValue("@sid", Sid_tb.Text);
            conn.Open();

            int existingPaymentCount = (int)cmd.ExecuteScalar();
            conn.Close();

            if (existingPaymentCount > 0)
            {
                MessageBox.Show("An Payment with the same Sales id already exists.");
            }
            else
            {
                // Insert a new record
                string insertQuery = "INSERT INTO PaymentTb(Salesid, Cname, Mobno, Mname, Price, Pmode) VALUES" +
                    "(@sid, @cname, @mobno, @mname, @price, @pmode)";
                cmd = new OleDbCommand(insertQuery, conn);
                cmd.Parameters.AddWithValue("@sid", Sid_tb.Text);
                cmd.Parameters.AddWithValue("@cname", Cname_tb.Text);
                cmd.Parameters.AddWithValue("@mobno", Mobno_tb.Text);
                cmd.Parameters.AddWithValue("@mname", Mname_tb.Text);
                cmd.Parameters.AddWithValue("@price", Price_tb.Text);
                cmd.Parameters.AddWithValue("@pmode", paymentmode.ToString());

                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();

                MessageBox.Show("Payment Details Inserted.");
                GetPayment();
            }
        }

        private void Payment_Load(object sender, EventArgs e)
        {
            GetPayment();
        }

        private void Reset_btn_Click(object sender, EventArgs e)
        {
            Clear();
        }
        void Clear()
        {
            Pid_tb.Clear();
            Sid_tb.Clear();
            Cname_tb.Clear();
            Mobno_tb.Clear();
            Mname_tb.Clear();
            Price_tb.Clear();
            Cash_rbtn.Checked = false;
            Online_rbtn.Checked = false;
            Sid_tb.Focus();

        }

        private void Search_tb_TextChanged(object sender, EventArgs e)
        {
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

                DGV_payment.DataSource = dv;
            }
        }
    }
}
