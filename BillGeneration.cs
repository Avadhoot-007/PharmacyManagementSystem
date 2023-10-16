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
    public partial class BillGeneration : Form
    {
        public BillGeneration()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            string customerName = txtcname.Text;
            string mobileNumber = textmobile.Text;
            string selectedMedicine = comboBox1.SelectedItem.ToString();
            int quantity = Convert.ToInt32(txtQuantity.Text);
            int totalAmount = CalculateAmount(selectedMedicine, quantity);

            // Set the connection string for the Access database
            string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=E:\\College\\Project\\Database\\PharmaDb.accdb";

            try
            {
                // Insert the data into the database
                using (OleDbConnection connection = new OleDbConnection(connectionString))
                {
                    connection.Open();
                    string query = "INSERT INTO BillingTable (CustomerName, MobileNumber, Medicine, Quantity, TotalAmount) VALUES (@customerName, @mobileNumber, @selectedMedicine, @quantity, @totalAmount)";
                    using (OleDbCommand command = new OleDbCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@customerName", customerName);
                        command.Parameters.AddWithValue("@mobileNumber", mobileNumber);
                        command.Parameters.AddWithValue("@selectedMedicine", selectedMedicine);
                        command.Parameters.AddWithValue("@quantity", quantity);
                        command.Parameters.AddWithValue("@totalAmount", totalAmount);

                        command.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Data saved successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while saving data: " + ex.Message);
            }

        }
        private void generate_btn_Click(object sender, EventArgs e)
        {
            txtTotalAmount.Visible = true;
            string customerName = txtcname.Text;
            string mobileNumber = textmobile.Text;
            string selectedMedicine = comboBox1.SelectedItem.ToString();
            int quantity = Convert.ToInt32(txtQuantity.Text);
            int totalAmount = CalculateAmount(selectedMedicine, quantity);

            // Set the Text property of the txtTotalAmount control
            txtTotalAmount.Text = totalAmount.ToString();

            // Print the output on the RichTextBox
            textresult.Text += "*************************************\n";
            textresult.Text += "        Medicine Payment                \n";
            textresult.Text += "*************************************\n";
            textresult.Text += "Date: " + DateTime.Now + "\n\n";

            textresult.Text += "Customer Name:- " + txtcname.Text + "\n\n";
            textresult.Text += "Mobile No.:  " + textmobile.Text + "\n\n";
            textresult.Text += "Medicine  :- " + comboBox1.Text + "\n\n";
            textresult.Text += "Quantity :- " + txtQuantity.Text + "\n\n";
            textresult.Text += "Total Amount:- " + totalAmount.ToString() + "\n\n";

            textresult.Text += "\n                Signature\n";
        }
        private int CalculateAmount(string selectedMedicine, int quantity)
        {
            int price = 0;
            switch (selectedMedicine)
            {
                case "Paracetamol (25)":
                    price = 25;
                    break;
                case "Crocin (10)":
                    price = 10;
                    break;
                case "Vitamin c (5)":
                    price = 5;
                    break;
                case "Dolo (10)":
                    price = 10;
                    break;
                case "Multivitamin (30)":
                    price = 30;
                    break;
                case "Cetirizine (30)":
                    price = 30;
                    break;
                default:
                    price = 0;
                    break;
            }
            return price * quantity;
        }

       /* private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString(textresult.Text, new Font("MicroSoft Sans Serif ", 18, FontStyle.Bold), Brushes.Black, new Point(10, 10));
        }*/

        private void print_btn_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }

        private void printDocument1_PrintPage_1(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString(textresult.Text, new Font("MicroSoft Sans Serif ", 18, FontStyle.Bold), Brushes.Black, new Point(10, 10));
        }
    }
    }
    
