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
    public partial class FrmCar : Form
    {
        bool isloaded = false;
        string connStr = Settings.Default.connString;
        public FrmCar()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {


            txtBrand.Text = String.Empty;
            txtMake.Text = String.Empty;
            txtModel.Text = String.Empty;
            txtCarId.Text = String.Empty;
            txtDescription.Text = String.Empty;
            txtRegNo.Text = String.Empty;
            isloaded = false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtBrand.Text == "" || txtMake.Text == "" || txtDescription.Text == "" || txtModel.Text == "" || txtRegNo.Text == "")
            {
                MessageBox.Show("Fill in all blinks");

            } 
            else { 
            
           
            try
            {
                    
                    string connString = Settings.Default.connString;
                MySqlConnection conn = new MySqlConnection(connString);
                MySqlCommand cmd = new MySqlCommand();



                string cmake = txtMake.Text;
                string cmodel = txtModel.Text;
                string cbrand = txtBrand.Text;
                string creg_no = txtRegNo.Text;
                string cdes = txtDescription.Text;
                    string cdriver = comboBox1.Text;

                cmd.Connection = conn;
                cmd.CommandText = @"INSERT INTO car(make,model,brand,reg_no,description,driver_name) 
                                   VALUE(@cmake,@cmodel,@cbrand,@creg_no,@cdes,@cdriver)";

                cmd.Parameters.AddWithValue("@cmake", cmake);
                cmd.Parameters.AddWithValue("@cmodel", cmodel);
                cmd.Parameters.AddWithValue("@cbrand", cbrand);
                cmd.Parameters.AddWithValue("@creg_no", creg_no);
                cmd.Parameters.AddWithValue("@cdes", cdes);
                cmd.Parameters.AddWithValue("@cdriver", cdriver);




                conn.Open();
                int res = cmd.ExecuteNonQuery();
                conn.Close();

                if (res > 0)
                {
                    MessageBox.Show("Saved");
                        txtBrand.Text = String.Empty;
                        txtMake.Text = String.Empty;
                        txtModel.Text = String.Empty;
                        txtCarId.Text = String.Empty;
                        txtDescription.Text = String.Empty;
                        txtRegNo.Text = String.Empty;
                        GetCustomerRecord();
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

        private void btnSearch_Click(object sender, EventArgs e)
        {

            try
            {
               

                int cid = Convert.ToInt32(txtCarId.Text);

                
                MySqlConnection conn = new MySqlConnection(connStr);
                MySqlCommand cmd = new MySqlCommand();

                cmd.CommandText = $"SELECT id,make,model,brand,reg_no,description,driver_name FROM car WHERE id = {cid}";
                cmd.Connection = conn;

                conn.Open();
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    txtCarId.Text = reader.GetInt32("id").ToString();
                    txtMake.Text = reader.GetString("make");
                    txtModel.Text = reader.GetString("model");
                    txtBrand.Text = reader.GetString("brand");
                    txtRegNo.Text = reader.GetString("reg_no");
                    txtDescription.Text = reader.GetString("description");
                    comboBox1.Text = reader.GetString("driver_name");
                    isloaded = true;



                }
                conn.Close();



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dateModel_ValueChanged(object sender, EventArgs e)
        {

        }

        private void FrmCar_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'car_rental_system_dbDataSet2.driver' table. You can move, or remove it, as needed.
            this.driverTableAdapter1.Fill(this.car_rental_system_dbDataSet2.driver);

            GetCustomerRecord();


        }

        private void GetCustomerRecord()
        {
            DataTable dt = new DataTable();
            MySqlConnection conn = new MySqlConnection(connStr);
            MySqlCommand cmd = new MySqlCommand();

            cmd.CommandText = $"SELECT * from car";
            cmd.Connection = conn;
            conn.Open();
            MySqlDataReader reader = cmd.ExecuteReader();
            dt.Load(reader);
            conn.Close();
            dataGridView1.DataSource = dt;


        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtBrand.Text == "" || txtMake.Text == "" || txtDescription.Text == "" || txtModel.Text == "" || txtRegNo.Text == "")
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


                    int cid = Convert.ToInt32(txtCarId.Text);
                    string cmake = txtMake.Text;
                    string cmodel = txtModel.Text;
                    string cbrand = txtBrand.Text;
                    string creg_no = txtRegNo.Text;
                    string cdes = txtDescription.Text;
                    string cdriver = comboBox1.Text;

                    string connString = Settings.Default.connString;
                    MySqlConnection conn = new MySqlConnection(connStr);
                    MySqlCommand cmd = new MySqlCommand();
                    cmd.Connection = conn;
                    cmd.CommandText = "UPDATE car SET make = @cmake, model = @cmodel,brand = @cbrand,reg_no =@creg_no,description = @cdes,driver_name=@cdriver WHERE id = @cid";




                    cmd.Parameters.AddWithValue("@cid", cid);
                    cmd.Parameters.AddWithValue("@cmake", cmake);
                    cmd.Parameters.AddWithValue("@cmodel", cmodel);
                    cmd.Parameters.AddWithValue("@cbrand", cbrand);
                    cmd.Parameters.AddWithValue("@creg_no", creg_no);
                    cmd.Parameters.AddWithValue("@cdes", cdes);
                    cmd.Parameters.AddWithValue("@cdriver", cdriver);



                    conn.Open();
                    int res = cmd.ExecuteNonQuery();
                    conn.Close();

                    if (res > 0)
                    {
                        MessageBox.Show(" Data Updated ");
                        txtBrand.Text = String.Empty;
                        txtMake.Text = String.Empty;
                        txtModel.Text = String.Empty;
                        txtCarId.Text = String.Empty;
                        txtDescription.Text = String.Empty;
                        txtRegNo.Text = String.Empty;
                        GetCustomerRecord();
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

        private void btnDelete_Click(object sender, EventArgs e)
        {

            if (!isloaded)
            {
                MessageBox.Show("Please Search for a record first");
                return;
            }
            try
            {
                int cid = Convert.ToInt32(txtCarId.Text);


                MySqlConnection conn = new MySqlConnection(connStr);
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "DELETE FROM car WHERE id = @cid";

                cmd.Parameters.AddWithValue("@cid", cid);
                conn.Open();
                int res = cmd.ExecuteNonQuery();
                conn.Close();
                if (res > 0)
                {
                    MessageBox.Show(" Data DELETED!");
                    txtBrand.Text = String.Empty;
                    txtMake.Text = String.Empty;
                    txtModel.Text = String.Empty;
                    txtCarId.Text = String.Empty;
                    txtDescription.Text = String.Empty;
                    txtRegNo.Text = String.Empty;

                    isloaded = false;

                    GetCustomerRecord();
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

        private void txtMake_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtModel_TextChanged(object sender, EventArgs e)
        {

        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.driverTableAdapter.FillBy(this.car_rental_system_dbDataSet.driver);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillBy1ToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.driverTableAdapter.FillBy1(this.car_rental_system_dbDataSet.driver);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillByToolStripButton_Click_1(object sender, EventArgs e)
        {
            try
            {
                this.driverTableAdapter1.FillBy(this.car_rental_system_dbDataSet2.driver);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void lblDriverId_Click(object sender, EventArgs e)
        {

        }
    }
}
