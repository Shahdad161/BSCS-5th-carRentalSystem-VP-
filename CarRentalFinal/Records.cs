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
    public partial class frmRecords : Form
    {
        public frmRecords()
        {
            InitializeComponent();
        }

        private void btnRentalSave_Click(object sender, EventArgs e)
        {
            try
            {
                string connString = Settings.Default.connString; ;
                MySqlConnection conn = new MySqlConnection(connString);
                MySqlCommand cmd = new MySqlCommand();



                int customerid = Convert.ToInt32(txtRentalRecordCustomerID.Text);
                int carid = Convert.ToInt32(txtRentalRecordCarId.Text);
                DateTime booking_from = dateRentalRecordBookingFrom.Value.Date;
                DateTime booking_to = dateRentalRecordBookingTo.Value.Date;
                decimal total_rent = Convert.ToDecimal(txtRentalRecordTotalRent.Text);
                decimal paid = Convert.ToDecimal(txtRentalRecordPaid.Text);
                decimal balance = Convert.ToDecimal(txtRentalRecordBalance.Text);


                cmd.Connection = conn;
                cmd.CommandText = @"INSERT INTO rental_record(car_id,customer_id,booking_from,booking_to,total_rent,paid,balance) 
                                   VALUE(@carid,@customerid,@booking_from,@booking_to,@total_rent,@paid,@balance)";

                cmd.Parameters.AddWithValue("@carid", carid);
                cmd.Parameters.AddWithValue("@customerid", customerid);
                cmd.Parameters.AddWithValue("@booking_from", booking_from);
                cmd.Parameters.AddWithValue("@booking_to", booking_to);
                cmd.Parameters.AddWithValue("@total_rent", total_rent);
                cmd.Parameters.AddWithValue("@paid", paid);
                cmd.Parameters.AddWithValue("@balance", balance);



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

        private void btnRentalSearch_Click(object sender, EventArgs e)
        {
            try
            {

                int cid = Convert.ToInt32(txtRentalRecordCarId.Text);

                string connStr = Settings.Default.connString;
                MySqlConnection conn = new MySqlConnection(connStr);
                MySqlCommand cmd = new MySqlCommand();

                cmd.CommandText = $"SELECT * FROM rental_record WHERE car_id = {cid}";
                cmd.Connection = conn;

                conn.Open();
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    txtRentalRecordBalance.Text = reader.GetInt32("balance").ToString();
                    txtRentalRecordCarId.Text = reader.GetString("customer_id");
                    txtRentalRecordCustomerID.Text = reader.GetString("customer_id");
                    txtRentalRecordPaid.Text = reader.GetString("paid");
                    txtRentalRecordTotalRent.Text = reader.GetString("total_rent");

                }
                conn.Close();



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnRentalReset_Click(object sender, EventArgs e)
        {
            txtRentalRecordBalance.Text =     String.Empty;
            txtRentalRecordCarId.Text =       String.Empty;
            txtRentalRecordCustomerID.Text =  String.Empty;
            txtRentalRecordPaid.Text =        String.Empty;
            txtRentalRecordTotalRent.Text = String.Empty;
        }

        private void btnDriverCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmRecords_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'car_rental_system_dbDataSet5.rental_record' table. You can move, or remove it, as needed.
            this.rental_recordTableAdapter.Fill(this.car_rental_system_dbDataSet5.rental_record);

        }
    }
}
