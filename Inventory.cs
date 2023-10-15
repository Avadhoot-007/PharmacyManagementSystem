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
    public partial class Inventory : Form
    {

        OleDbCommand cmd;
        OleDbConnection conn;
        OleDbDataAdapter adapter;
        DataTable dt;
        public Inventory()
        {
            InitializeComponent();
        }

        void GetInventory()
        {
            conn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=E:\\College\\Project\\Database\\PharmaDb.accdb");
            dt = new DataTable();
            adapter = new OleDbDataAdapter("SELECT * FROM InventoryTb", conn);
            conn.Open();
            adapter.Fill(dt);
            DGV_inventory.DataSource = dt;
            conn.Close();

        }

        private void Inventory_Load(object sender, EventArgs e)
        {
            GetInventory();
        }

        private void Insert_btn_Click(object sender, EventArgs e)
        {
            string checkQuery = "SELECT COUNT(*) FROM InventoryTb WHERE Pname = @pname";
            cmd = new OleDbCommand(checkQuery, conn);
            cmd.Parameters.AddWithValue("@pname", Pname_tb.Text);
            conn.Open();

            int existingInventoryCount = (int)cmd.ExecuteScalar();
            conn.Close();

            if (existingInventoryCount > 0)
            {
                MessageBox.Show("An Product with the same Name already exists.");
            }
            else
            {
                // Insert a new record
                string insertQuery = "INSERT INTO InventoryTb(Pname, Bname, Category, Sname, Stock) VALUES" +
                    "(@pname, @bname, @cat, @sname, @stock)";
                cmd = new OleDbCommand(insertQuery, conn);
                cmd.Parameters.AddWithValue("@pname", Pname_tb.Text);
                cmd.Parameters.AddWithValue("@bname", Bname_tb.Text);
                cmd.Parameters.AddWithValue("@cat", Category_tb.Text);
                cmd.Parameters.AddWithValue("@sname", Sname_tb.Text);
                cmd.Parameters.AddWithValue("@stock", Stock_tb.Text);
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();

                MessageBox.Show("Item Inserted.");
                GetInventory();
            }
        }

        private void Clear_btn_Click(object sender, EventArgs e)
        {
            Clear();
        }
        void Clear()
        {
            Pid_tb.Clear();
            Pname_tb.Clear();
            Bname_tb.Clear();
            Category_tb.Clear();
            Sname_tb.Clear();
            Stock_tb.Clear();
            Pname_tb.Focus();

        }

        private void Update_btn_Click(object sender, EventArgs e)
        {
            string query = "UPDATE InventoryTb SET Pname=@pname, Bname=@bname, Category=@cat, Sname=@sname, Stock=@stock " +
            "WHERE Pid=@pid";

            cmd = new OleDbCommand(query, conn);
            cmd.Parameters.AddWithValue("@pname", Pname_tb.Text);
            cmd.Parameters.AddWithValue("@bname", Bname_tb.Text);
            cmd.Parameters.AddWithValue("@category", Category_tb.Text);
            cmd.Parameters.AddWithValue("@sname", Sname_tb.Text);
            cmd.Parameters.AddWithValue("@stock", Stock_tb.Text);
            cmd.Parameters.AddWithValue("@pid", Convert.ToInt32(Pid_tb.Text));
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Record Updated .");
            GetInventory();
        }

        private void DGV_inventory_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            Pid_tb.Text = DGV_inventory.CurrentRow.Cells[0].Value.ToString();
            Pname_tb.Text = DGV_inventory.CurrentRow.Cells[1].Value.ToString();
            Bname_tb.Text = DGV_inventory.CurrentRow.Cells[2].Value.ToString();
            Category_tb.Text = DGV_inventory.CurrentRow.Cells[3].Value.ToString();
            Sname_tb.Text = DGV_inventory.CurrentRow.Cells[4].Value.ToString();
            Stock_tb.Text = DGV_inventory.CurrentRow.Cells[5].Value.ToString();
        }
    }
}
