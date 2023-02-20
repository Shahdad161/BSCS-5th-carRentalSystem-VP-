using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using CarRentalFinal.Properties;

namespace car_rental_system
{
    public partial class FrmCustomer : Form

    {
        bool isloaded = false;
        string connStr = Settings.Default.connString;
        public FrmCustomer()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
           
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtAddress.Text == "" || txtCustomerCnic.Text == "" || txtCustomerContactNo.Text == "" || txtCustomerFirstName.Text == "" || txtCustomerGender.Text == "" || txtCustomerId.Text == "" || txtCustomerLastName.Text == "" || txtGuarantorCnic.Text == "" || txtGuarantorName.Text == "")
            {
                MessageBox.Show("Fill in all blinks");

            }
            else
            {

                if (!isloaded)
                {
                    MessageBox.Show("Please Search for a record first");
                    return;
                }
                try
                {

                    int cid = Convert.ToInt32(txtCustomerId.Text);
                    string cfirstname = txtCustomerFirstName.Text;
                    string clastname = txtCustomerLastName.Text;
                    string cgender = txtCustomerGender.Text;
                    string ccnic = txtCustomerCnic.Text;
                    string ccontact = txtCustomerContactNo.Text;
                    string caddress = txtAddress.Text;
                    string gcnic = txtGuarantorCnic.Text;
                    string gname = txtGuarantorName.Text;

                    string connString = Settings.Default.connString;
                    MySqlConnection conn = new MySqlConnection(connString);
                    MySqlCommand cmd = new MySqlCommand();
                    cmd.Connection = conn;
                    cmd.CommandText = @"DELETE FROM customer WHERE id = @cid";

                    cmd.Parameters.AddWithValue("@cfirstname", cfirstname);
                    cmd.Parameters.AddWithValue("@clastname", clastname);
                    cmd.Parameters.AddWithValue("@cgender", cgender);
                    cmd.Parameters.AddWithValue("@ccnic", ccnic);
                    cmd.Parameters.AddWithValue("@ccontact", ccontact);
                    cmd.Parameters.AddWithValue("@caddress", caddress);
                    cmd.Parameters.AddWithValue("@gcnic", gcnic);
                    cmd.Parameters.AddWithValue("@gname", gname);


                    conn.Open();
                    int res = cmd.ExecuteNonQuery();
                    conn.Close();

                    if (res > 0)
                    {
                        MessageBox.Show(" Data Deleted ");
                        txtAddress.Text = String.Empty;
                        txtCustomerCnic.Text = String.Empty;
                        txtCustomerContactNo.Text = String.Empty;
                        txtCustomerFirstName.Text = String.Empty;
                        txtCustomerGender.Text = String.Empty;
                        txtCustomerId.Text = String.Empty;
                        txtCustomerLastName.Text = String.Empty;
                        txtGuarantorCnic.Text = String.Empty;
                        txtGuarantorName.Text = String.Empty;
                    }
                }

                catch (MySqlException ex)
                {
                    MessageBox.Show(ex.Message + ex.Number);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtAddress.Text == "" || txtCustomerCnic.Text == "" || txtCustomerContactNo.Text == "" || txtCustomerFirstName.Text == "" || txtCustomerGender.Text == "" || txtCustomerId.Text == "" || txtCustomerLastName.Text == "" || txtGuarantorCnic.Text == "" || txtGuarantorName.Text == "")
            {
                MessageBox.Show("Fill in all blinks");

            }
            else
            {

                if (!isloaded)
                {
                    MessageBox.Show("Please Search for a record first");
                    return;
                }
                try
                {

                    int cid = Convert.ToInt32(txtCustomerId.Text);
                    string cfirstname = txtCustomerFirstName.Text;
                    string clastname = txtCustomerLastName.Text;
                    string cgender = txtCustomerGender.Text;
                    string ccnic = txtCustomerCnic.Text;
                    string ccontact = txtCustomerContactNo.Text;
                    string caddress = txtAddress.Text;
                    string gcnic = txtGuarantorCnic.Text;
                    string gname = txtGuarantorName.Text;

                    string connString = Settings.Default.connString;
                    MySqlConnection conn = new MySqlConnection(connString);
                    MySqlCommand cmd = new MySqlCommand();
                    cmd.Connection = conn;
                    cmd.CommandText = @"UPDATE customer SET first_name = @cfirstname,
                                        last_name = @clastname,gender = @cgender,cnic =@ccnic,
                                        contact_no =@ccontact, 	address = @caddress, guarantor_cnic = @gcnic,
                                        guarantor_name = @gname WHERE id = @cid";

                    cmd.Parameters.AddWithValue("@cfirstname", cfirstname);
                    cmd.Parameters.AddWithValue("@clastname", clastname);
                    cmd.Parameters.AddWithValue("@cgender", cgender);
                    cmd.Parameters.AddWithValue("@ccnic", ccnic);
                    cmd.Parameters.AddWithValue("@ccontact", ccontact);
                    cmd.Parameters.AddWithValue("@caddress", caddress);
                    cmd.Parameters.AddWithValue("@gcnic", gcnic);
                    cmd.Parameters.AddWithValue("@gname", gname);


                    conn.Open();
                    int res = cmd.ExecuteNonQuery();
                    conn.Close();

                    if (res > 0)
                    {
                        MessageBox.Show(" Data Updated ");
                        txtAddress.Text = String.Empty;
                        txtCustomerCnic.Text = String.Empty;
                        txtCustomerContactNo.Text = String.Empty;
                        txtCustomerFirstName.Text = String.Empty;
                        txtCustomerGender.Text = String.Empty;
                        txtCustomerId.Text = String.Empty;
                        txtCustomerLastName.Text = String.Empty;
                        txtGuarantorCnic.Text = String.Empty;
                        txtGuarantorName.Text = String.Empty;
                    }
                }

                catch (MySqlException ex)
                {
                    MessageBox.Show(ex.Message + ex.Number);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        
        private void btnSearch_Click(object sender, EventArgs e)
        {

            try
            {

                int cid = Convert.ToInt32(txtCustomerId.Text);

                string connStr = Settings.Default.connString;
                MySqlConnection conn = new MySqlConnection(connStr);
                MySqlCommand cmd = new MySqlCommand();

                cmd.CommandText = $"SELECT id,first_name,last_name,gender,cnic,contact_no,Address,guarantor_cnic,guarantor_name FROM customer WHERE id = {cid}";
                cmd.Connection = conn;

                conn.Open();
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    txtCustomerId.Text = reader.GetInt32("id").ToString();
                    txtCustomerFirstName.Text = reader.GetString("first_name");
                    txtCustomerLastName.Text = reader.GetString("last_name");
                    txtCustomerGender.Text = reader.GetString("gender");
                    txtCustomerCnic.Text = reader.GetString("cnic");
                    txtCustomerContactNo.Text = reader.GetString("contact_no");
                    txtAddress.Text = reader.GetString("Address");
                    txtGuarantorCnic.Text = reader.GetString("guarantor_cnic");
                    txtGuarantorName.Text = reader.GetString("guarantor_name");
                    isloaded = true;

                }
                conn.Close();



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtAddress.Text =           String.Empty;
            txtCustomerCnic.Text =      String.Empty;
            txtCustomerContactNo.Text = String.Empty;
            txtCustomerFirstName.Text = String.Empty;
            txtCustomerGender.Text =    String.Empty;
            txtCustomerId.Text =        String.Empty;
            txtCustomerLastName.Text =  String.Empty;
            txtGuarantorCnic.Text =     String.Empty;
            txtGuarantorName.Text =     String.Empty;

        }

        private void btnCustomerSave_Click(object sender, EventArgs e)
        {
            if(txtAddress.Text == "" || txtCustomerCnic.Text == "" || txtCustomerContactNo.Text == "" || txtCustomerFirstName.Text == "" 
                || txtCustomerGender.Text == ""  || txtCustomerLastName.Text == "" || txtGuarantorCnic.Text == "" || txtGuarantorName.Text == "")
            {
                MessageBox.Show("Please, Fill in all the Blinks");
            }
            else
            {

            

            try
            {
                string connString = Settings.Default.connString; ;
                MySqlConnection conn = new MySqlConnection(connString);
                MySqlCommand cmd = new MySqlCommand();



                string cfirstname = txtCustomerFirstName.Text;
                string clastname = txtCustomerLastName.Text;
                string cgender = txtCustomerGender.Text;
                string ccnic = txtCustomerCnic.Text;
                string ccontact = txtCustomerContactNo.Text;
                string caddress = txtAddress.Text;
                string gcnic = txtGuarantorCnic.Text;
                string gname = txtGuarantorName.Text;

                
                cmd.CommandText = @"INSERT INTO customer (first_name ,last_name , 	gender ,cnic ,contact_no,Address ,guarantor_cnic,guarantor_name ) 
                                   VALUE(@cfirstname,@clastname,@cgender,@ccnic,@ccontact,@caddress,@gcnic,@gname)";
                cmd.Connection = conn;
                cmd.Parameters.AddWithValue("@cfirstname", cfirstname);
                cmd.Parameters.AddWithValue("@clastname", clastname);
                cmd.Parameters.AddWithValue("@cgender", cgender);
                cmd.Parameters.AddWithValue("@ccnic", ccnic);
                cmd.Parameters.AddWithValue("@ccontact", ccontact);
                cmd.Parameters.AddWithValue("@caddress", caddress);
                cmd.Parameters.AddWithValue("@gcnic", gcnic);
                cmd.Parameters.AddWithValue("@gname", gname);



                conn.Open();
                int res = cmd.ExecuteNonQuery();
                conn.Close();

                if (res > 0)
                {
                    MessageBox.Show("Saved");
                }
                else
                {
                    MessageBox.Show("NOT Saved");
                }



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            } 



        }

        private void FrmCustomer_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'car_rental_system_dbDataSet6.customer' table. You can move, or remove it, as needed.
            this.customerTableAdapter2.Fill(this.car_rental_system_dbDataSet6.customer);
            // TODO: This line of code loads data into the 'car_rental_system_dbDataSet3.customer' table. You can move, or remove it, as needed.
            
            this.customerTableAdapter1.Fill(car_rental_system_dbDataSet3.customer);
            // TODO: This line of code loads data into the 'car_rental_system_dbDataSet1.customer' table. You can move, or remove it, as needed.
            this.customerTableAdapter.Fill(this.car_rental_system_dbDataSet1.customer);

        }
    }
}
