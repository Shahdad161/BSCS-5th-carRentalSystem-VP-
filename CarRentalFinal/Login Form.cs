using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace car_rental_system
{
    public partial class Login_Form : Form
    {
        public Login_Form()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = txtusername.Text;
            string password = txtpassword.Text;

            if (txtusername.Text == "" || txtpassword.Text == "")
            {
                MessageBox.Show("Enter Missing Values");

            }
            else { 
                if (username.Equals("admin") && password.Equals("123"))
                {
                     MDICarRentalSystem f = new MDICarRentalSystem();
                     f.Show();
                 }
                else
                 {
                     MessageBox.Show("login Fail");
                 }
            }
        }

        private void txtusername_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtusername_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}
