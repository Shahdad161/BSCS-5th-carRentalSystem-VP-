using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using CarRentalFinal.Properties;
//using car_rental_system.Properties;

namespace car_rental_system
{
    public partial class FrmDriver : Form
    {
        bool isloaded = false;
        string connStr = Settings.Default.connString;
        public FrmDriver()
        {
            InitializeComponent();
        }

        private void btnDriverSave_Click(object sender, EventArgs e)
        {
            try
            {
                string connString = Settings.Default.connString;
                MySqlConnection conn = new MySqlConnection(connString);
                MySqlCommand cmd = new MySqlCommand();



                string dfname = txtFirstName.Text;
                string dlname = txtLastName.Text;
                string dcnic = txtCnic.Text;
                string dlicenseno = txtLicenseNo.Text;
                string dcontactno = txtContacNo.Text;
                //int dgender = comboDriverGender.;
                string daddress = txtAddress.Text;
                string dgender = txtgender.Text;

                cmd.Connection = conn;
                cmd.CommandText = @"INSERT INTO driver(first_name,last_name,cnic,license_no,contact_no,address,gender) 
                                   VALUE(@dfname,@dlname,@dcnic,@dlicenseno,@dcontactno,@daddress,@dgender)";

                cmd.Parameters.AddWithValue("@dfname", dfname);
                cmd.Parameters.AddWithValue("@dlname", dlname);
                cmd.Parameters.AddWithValue("@dcnic", dcnic);
                cmd.Parameters.AddWithValue("@dlicenseno", dlicenseno);
                cmd.Parameters.AddWithValue("@dcontactno", dcontactno);
                cmd.Parameters.AddWithValue("@daddress", daddress);
                cmd.Parameters.AddWithValue("@dgender", dgender);



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

        private void btnDriverSearch_Click(object sender, EventArgs e)
        {
            try
            {

                int cid = Convert.ToInt32(txtDriverIdDriver.Text);

                string connStr = Settings.Default.connString; ;
                MySqlConnection conn = new MySqlConnection(connStr);
                MySqlCommand cmd = new MySqlCommand();

                cmd.CommandText = $"SELECT * FROM driver WHERE id = {cid}";
                cmd.Connection = conn;

                conn.Open();
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    txtDriverIdDriver.Text = reader.GetInt32("id").ToString();
                    txtFirstName.Text = reader.GetString("first_name");
                    txtLastName.Text = reader.GetString("last_name");
                    txtCnic.Text = reader.GetString("cnic");
                    txtContacNo.Text = reader.GetString("contact_no");
                    txtLicenseNo.Text = reader.GetString("license_no");
                    txtAddress.Text = reader.GetInt32("address").ToString();
                    isloaded = true;

                }
                conn.Close();



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDriverReset_Click(object sender, EventArgs e)
        {
            txtFirstName.Text = String.Empty;
            txtLastName.Text = String.Empty;
            txtLicenseNo.Text = String.Empty;
            txtDriverIdDriver.Text = String.Empty;
            txtCnic.Text = String.Empty;
            txtAddress.Text = String.Empty;
            txtContacNo.Text = String.Empty;
            isloaded = false;
        }

        private void btnDriverCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtCnic_TextChanged(object sender, EventArgs e)
        {
         
        }

        private void FrmDriver_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'car_rental_system_dbDataSet4.driver' table. You can move, or remove it, as needed.
            
            
            this.driverTableAdapter.Fill(this.car_rental_system_dbDataSet4.driver);
        

        }

        private void btnDriverUpdate_Click(object sender, EventArgs e)
        {

            if (txtAddress.Text == "" || txtCnic.Text == "" || txtContacNo.Text == "" || txtDriverIdDriver.Text == "" || txtFirstName.Text == "" || txtgender.Text == "" || txtLastName.Text == "" || txtLicenseNo.Text == "")
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


                    string dfname = txtFirstName.Text;
                    string dlname = txtLastName.Text;
                    string dcnic = txtCnic.Text;
                    string dlicenseno = txtLicenseNo.Text;
                    string dcontactno = txtContacNo.Text;
                    string dgender = txtgender.Text;
                    string daddress = txtAddress.Text;
                    string dgender2 = txtgender.Text;

                    string connString = Settings.Default.connString;
                    MySqlConnection conn = new MySqlConnection(connString);
                    MySqlCommand cmd = new MySqlCommand();
                    cmd.Connection = conn;
                    cmd.CommandText ="UPDATE driver SET first_name = @dfname, last_name = @dlname,cnic = @dcnic,license_no=@dlicenseno,contact_no=@dcontactno,gender =@dgender, address =@daddress, gender=@dgender2; WHERE id = @cid";



                    cmd.Parameters.AddWithValue("@dfname", dfname);
                    cmd.Parameters.AddWithValue("@dlname", dlname);
                    cmd.Parameters.AddWithValue("@dcnic", dcnic);
                    cmd.Parameters.AddWithValue("@dlicenseno", dlicenseno);
                    cmd.Parameters.AddWithValue("@dcontactno", dcontactno);
                    cmd.Parameters.AddWithValue("@dgender", dgender);
                    cmd.Parameters.AddWithValue("@daddress", daddress);
                    cmd.Parameters.AddWithValue("@dgender2", dgender2);


                    conn.Open();
                    int res = cmd.ExecuteNonQuery();
                    conn.Close();

                    if (res > 0)
                    {
                        MessageBox.Show(" Data Updated ");
                        txtFirstName.Text = String.Empty;
                        txtLastName.Text = String.Empty;
                        txtLicenseNo.Text = String.Empty;
                        txtDriverIdDriver.Text = String.Empty;
                        txtCnic.Text = String.Empty;
                        txtAddress.Text = String.Empty;
                        txtContacNo.Text = String.Empty;
                    }
                }

                catch (MySqlException ex)
                {
                    MessageBox.Show("MySqlException error " + ex.Number);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
