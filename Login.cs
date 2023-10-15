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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_btn_Click(object sender, EventArgs e)
        {
            if (Uname_tb.Text == "admin" || Pswd_tb.Text == "admin")
            {
                MessageBox.Show("You are logged in successfully..");
                this.Visible = false;
                Dashboard obj1 = new Dashboard();
                obj1.ShowDialog();
            }
            else
            {
                MessageBox.Show("Invalid Username Or Password.");
            }
        }

        private void Reset_btn_Click(object sender, EventArgs e)
        {
            Uname_tb.Text = "";
            Pswd_tb.Text = "";
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
