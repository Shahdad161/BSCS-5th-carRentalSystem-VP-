
namespace car_rental_system
{
    partial class frmRecords
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRecords));
            this.txtRentalRecordBalance = new System.Windows.Forms.TextBox();
            this.lblRentalRecordBalance = new System.Windows.Forms.Label();
            this.lblRentalRecordsList = new System.Windows.Forms.Label();
            this.lblRecords = new System.Windows.Forms.Label();
            this.txtRentalRecordPaid = new System.Windows.Forms.TextBox();
            this.lblRentalRecordPaid = new System.Windows.Forms.Label();
            this.txtRentalRecordTotalRent = new System.Windows.Forms.TextBox();
            this.lblRentalRecordTotalRent = new System.Windows.Forms.Label();
            this.lblRentalRecordBookingTo = new System.Windows.Forms.Label();
            this.lblRentalRecordBookingFrom = new System.Windows.Forms.Label();
            this.txtRentalRecordCustomerID = new System.Windows.Forms.TextBox();
            this.lblRentalRecordCustomerID = new System.Windows.Forms.Label();
            this.txtRentalRecordCarId = new System.Windows.Forms.TextBox();
            this.lblRentalRecordCarId = new System.Windows.Forms.Label();
            this.lblRentalRecordsAddData = new System.Windows.Forms.Label();
            this.dateRentalRecordBookingFrom = new System.Windows.Forms.DateTimePicker();
            this.dateRentalRecordBookingTo = new System.Windows.Forms.DateTimePicker();
            this.btnRentalReset = new System.Windows.Forms.Button();
            this.btnDriverCancel = new System.Windows.Forms.Button();
            this.btnRentalDelete = new System.Windows.Forms.Button();
            this.btnRentalUpdate = new System.Windows.Forms.Button();
            this.btnRentalSearch = new System.Windows.Forms.Button();
            this.btnRentalSave = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.car_rental_system_dbDataSet5 = new CarRentalFinal.car_rental_system_dbDataSet5();
            this.rentalrecordBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rental_recordTableAdapter = new CarRentalFinal.car_rental_system_dbDataSet5TableAdapters.rental_recordTableAdapter();
            this.caridDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customeridDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookingfromDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookingtoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalrentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.balanceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.car_rental_system_dbDataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rentalrecordBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // txtRentalRecordBalance
            // 
            this.txtRentalRecordBalance.Location = new System.Drawing.Point(170, 260);
            this.txtRentalRecordBalance.Name = "txtRentalRecordBalance";
            this.txtRentalRecordBalance.Size = new System.Drawing.Size(108, 20);
            this.txtRentalRecordBalance.TabIndex = 87;
            // 
            // lblRentalRecordBalance
            // 
            this.lblRentalRecordBalance.AutoSize = true;
            this.lblRentalRecordBalance.BackColor = System.Drawing.Color.Transparent;
            this.lblRentalRecordBalance.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblRentalRecordBalance.Location = new System.Drawing.Point(64, 262);
            this.lblRentalRecordBalance.Name = "lblRentalRecordBalance";
            this.lblRentalRecordBalance.Size = new System.Drawing.Size(63, 21);
            this.lblRentalRecordBalance.TabIndex = 86;
            this.lblRentalRecordBalance.Text = "Balance";
            // 
            // lblRentalRecordsList
            // 
            this.lblRentalRecordsList.AutoSize = true;
            this.lblRentalRecordsList.BackColor = System.Drawing.Color.Red;
            this.lblRentalRecordsList.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.lblRentalRecordsList.Location = new System.Drawing.Point(485, 38);
            this.lblRentalRecordsList.Name = "lblRentalRecordsList";
            this.lblRentalRecordsList.Size = new System.Drawing.Size(142, 21);
            this.lblRentalRecordsList.TabIndex = 85;
            this.lblRentalRecordsList.Text = "Rental Record List";
            // 
            // lblRecords
            // 
            this.lblRecords.AutoSize = true;
            this.lblRecords.BackColor = System.Drawing.Color.Red;
            this.lblRecords.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblRecords.Location = new System.Drawing.Point(306, 8);
            this.lblRecords.Name = "lblRecords";
            this.lblRecords.Size = new System.Drawing.Size(144, 25);
            this.lblRecords.TabIndex = 84;
            this.lblRecords.Text = "Rental Records";
            // 
            // txtRentalRecordPaid
            // 
            this.txtRentalRecordPaid.Location = new System.Drawing.Point(171, 297);
            this.txtRentalRecordPaid.Name = "txtRentalRecordPaid";
            this.txtRentalRecordPaid.Size = new System.Drawing.Size(108, 20);
            this.txtRentalRecordPaid.TabIndex = 82;
            // 
            // lblRentalRecordPaid
            // 
            this.lblRentalRecordPaid.AutoSize = true;
            this.lblRentalRecordPaid.BackColor = System.Drawing.Color.Transparent;
            this.lblRentalRecordPaid.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblRentalRecordPaid.Location = new System.Drawing.Point(66, 299);
            this.lblRentalRecordPaid.Name = "lblRentalRecordPaid";
            this.lblRentalRecordPaid.Size = new System.Drawing.Size(39, 21);
            this.lblRentalRecordPaid.TabIndex = 81;
            this.lblRentalRecordPaid.Text = "Paid";
            // 
            // txtRentalRecordTotalRent
            // 
            this.txtRentalRecordTotalRent.Location = new System.Drawing.Point(170, 220);
            this.txtRentalRecordTotalRent.Name = "txtRentalRecordTotalRent";
            this.txtRentalRecordTotalRent.Size = new System.Drawing.Size(108, 20);
            this.txtRentalRecordTotalRent.TabIndex = 80;
            // 
            // lblRentalRecordTotalRent
            // 
            this.lblRentalRecordTotalRent.AutoSize = true;
            this.lblRentalRecordTotalRent.BackColor = System.Drawing.Color.Transparent;
            this.lblRentalRecordTotalRent.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblRentalRecordTotalRent.Location = new System.Drawing.Point(63, 222);
            this.lblRentalRecordTotalRent.Name = "lblRentalRecordTotalRent";
            this.lblRentalRecordTotalRent.Size = new System.Drawing.Size(78, 21);
            this.lblRentalRecordTotalRent.TabIndex = 79;
            this.lblRentalRecordTotalRent.Text = "Total Rent";
            // 
            // lblRentalRecordBookingTo
            // 
            this.lblRentalRecordBookingTo.AutoSize = true;
            this.lblRentalRecordBookingTo.BackColor = System.Drawing.Color.Transparent;
            this.lblRentalRecordBookingTo.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblRentalRecordBookingTo.Location = new System.Drawing.Point(61, 179);
            this.lblRentalRecordBookingTo.Name = "lblRentalRecordBookingTo";
            this.lblRentalRecordBookingTo.Size = new System.Drawing.Size(86, 21);
            this.lblRentalRecordBookingTo.TabIndex = 77;
            this.lblRentalRecordBookingTo.Text = "Booking To";
            // 
            // lblRentalRecordBookingFrom
            // 
            this.lblRentalRecordBookingFrom.AutoSize = true;
            this.lblRentalRecordBookingFrom.BackColor = System.Drawing.Color.Transparent;
            this.lblRentalRecordBookingFrom.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblRentalRecordBookingFrom.Location = new System.Drawing.Point(61, 145);
            this.lblRentalRecordBookingFrom.Name = "lblRentalRecordBookingFrom";
            this.lblRentalRecordBookingFrom.Size = new System.Drawing.Size(108, 21);
            this.lblRentalRecordBookingFrom.TabIndex = 75;
            this.lblRentalRecordBookingFrom.Text = "Booking From";
            // 
            // txtRentalRecordCustomerID
            // 
            this.txtRentalRecordCustomerID.Location = new System.Drawing.Point(171, 109);
            this.txtRentalRecordCustomerID.Name = "txtRentalRecordCustomerID";
            this.txtRentalRecordCustomerID.Size = new System.Drawing.Size(108, 20);
            this.txtRentalRecordCustomerID.TabIndex = 74;
            // 
            // lblRentalRecordCustomerID
            // 
            this.lblRentalRecordCustomerID.AutoSize = true;
            this.lblRentalRecordCustomerID.BackColor = System.Drawing.Color.Transparent;
            this.lblRentalRecordCustomerID.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblRentalRecordCustomerID.Location = new System.Drawing.Point(62, 111);
            this.lblRentalRecordCustomerID.Name = "lblRentalRecordCustomerID";
            this.lblRentalRecordCustomerID.Size = new System.Drawing.Size(97, 21);
            this.lblRentalRecordCustomerID.TabIndex = 73;
            this.lblRentalRecordCustomerID.Text = "Customer ID";
            // 
            // txtRentalRecordCarId
            // 
            this.txtRentalRecordCarId.Location = new System.Drawing.Point(170, 72);
            this.txtRentalRecordCarId.Name = "txtRentalRecordCarId";
            this.txtRentalRecordCarId.Size = new System.Drawing.Size(108, 20);
            this.txtRentalRecordCarId.TabIndex = 72;
            // 
            // lblRentalRecordCarId
            // 
            this.lblRentalRecordCarId.AutoSize = true;
            this.lblRentalRecordCarId.BackColor = System.Drawing.Color.Transparent;
            this.lblRentalRecordCarId.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblRentalRecordCarId.ForeColor = System.Drawing.Color.Black;
            this.lblRentalRecordCarId.Location = new System.Drawing.Point(62, 74);
            this.lblRentalRecordCarId.Name = "lblRentalRecordCarId";
            this.lblRentalRecordCarId.Size = new System.Drawing.Size(53, 21);
            this.lblRentalRecordCarId.TabIndex = 71;
            this.lblRentalRecordCarId.Text = "Car ID";
            // 
            // lblRentalRecordsAddData
            // 
            this.lblRentalRecordsAddData.AutoSize = true;
            this.lblRentalRecordsAddData.BackColor = System.Drawing.Color.Red;
            this.lblRentalRecordsAddData.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.lblRentalRecordsAddData.Location = new System.Drawing.Point(121, 38);
            this.lblRentalRecordsAddData.Name = "lblRentalRecordsAddData";
            this.lblRentalRecordsAddData.Size = new System.Drawing.Size(78, 21);
            this.lblRentalRecordsAddData.TabIndex = 70;
            this.lblRentalRecordsAddData.Text = "Add Data";
            // 
            // dateRentalRecordBookingFrom
            // 
            this.dateRentalRecordBookingFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateRentalRecordBookingFrom.Location = new System.Drawing.Point(171, 143);
            this.dateRentalRecordBookingFrom.Name = "dateRentalRecordBookingFrom";
            this.dateRentalRecordBookingFrom.Size = new System.Drawing.Size(108, 20);
            this.dateRentalRecordBookingFrom.TabIndex = 88;
            // 
            // dateRentalRecordBookingTo
            // 
            this.dateRentalRecordBookingTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateRentalRecordBookingTo.Location = new System.Drawing.Point(170, 179);
            this.dateRentalRecordBookingTo.Name = "dateRentalRecordBookingTo";
            this.dateRentalRecordBookingTo.Size = new System.Drawing.Size(108, 20);
            this.dateRentalRecordBookingTo.TabIndex = 89;
            // 
            // btnRentalReset
            // 
            this.btnRentalReset.BackColor = System.Drawing.Color.Red;
            this.btnRentalReset.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnRentalReset.Location = new System.Drawing.Point(411, 357);
            this.btnRentalReset.Name = "btnRentalReset";
            this.btnRentalReset.Size = new System.Drawing.Size(78, 30);
            this.btnRentalReset.TabIndex = 95;
            this.btnRentalReset.Text = "Reset";
            this.btnRentalReset.UseVisualStyleBackColor = false;
            this.btnRentalReset.Click += new System.EventHandler(this.btnRentalReset_Click);
            // 
            // btnDriverCancel
            // 
            this.btnDriverCancel.BackColor = System.Drawing.Color.Red;
            this.btnDriverCancel.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnDriverCancel.Location = new System.Drawing.Point(327, 357);
            this.btnDriverCancel.Name = "btnDriverCancel";
            this.btnDriverCancel.Size = new System.Drawing.Size(78, 30);
            this.btnDriverCancel.TabIndex = 94;
            this.btnDriverCancel.Text = "Cancel";
            this.btnDriverCancel.UseVisualStyleBackColor = false;
            this.btnDriverCancel.Click += new System.EventHandler(this.btnDriverCancel_Click);
            // 
            // btnRentalDelete
            // 
            this.btnRentalDelete.BackColor = System.Drawing.Color.Red;
            this.btnRentalDelete.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnRentalDelete.Location = new System.Drawing.Point(244, 357);
            this.btnRentalDelete.Name = "btnRentalDelete";
            this.btnRentalDelete.Size = new System.Drawing.Size(78, 30);
            this.btnRentalDelete.TabIndex = 93;
            this.btnRentalDelete.Text = "Delete";
            this.btnRentalDelete.UseVisualStyleBackColor = false;
            // 
            // btnRentalUpdate
            // 
            this.btnRentalUpdate.BackColor = System.Drawing.Color.Red;
            this.btnRentalUpdate.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnRentalUpdate.Location = new System.Drawing.Point(411, 326);
            this.btnRentalUpdate.Name = "btnRentalUpdate";
            this.btnRentalUpdate.Size = new System.Drawing.Size(78, 30);
            this.btnRentalUpdate.TabIndex = 92;
            this.btnRentalUpdate.Text = "Update";
            this.btnRentalUpdate.UseVisualStyleBackColor = false;
            // 
            // btnRentalSearch
            // 
            this.btnRentalSearch.BackColor = System.Drawing.Color.Red;
            this.btnRentalSearch.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnRentalSearch.Location = new System.Drawing.Point(327, 326);
            this.btnRentalSearch.Name = "btnRentalSearch";
            this.btnRentalSearch.Size = new System.Drawing.Size(78, 30);
            this.btnRentalSearch.TabIndex = 91;
            this.btnRentalSearch.Text = "Search";
            this.btnRentalSearch.UseVisualStyleBackColor = false;
            this.btnRentalSearch.Click += new System.EventHandler(this.btnRentalSearch_Click);
            // 
            // btnRentalSave
            // 
            this.btnRentalSave.BackColor = System.Drawing.Color.Red;
            this.btnRentalSave.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnRentalSave.Location = new System.Drawing.Point(244, 326);
            this.btnRentalSave.Name = "btnRentalSave";
            this.btnRentalSave.Size = new System.Drawing.Size(78, 30);
            this.btnRentalSave.TabIndex = 90;
            this.btnRentalSave.Text = "Save";
            this.btnRentalSave.UseVisualStyleBackColor = false;
            this.btnRentalSave.Click += new System.EventHandler(this.btnRentalSave_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.caridDataGridViewTextBoxColumn,
            this.customeridDataGridViewTextBoxColumn,
            this.bookingfromDataGridViewTextBoxColumn,
            this.bookingtoDataGridViewTextBoxColumn,
            this.totalrentDataGridViewTextBoxColumn,
            this.paidDataGridViewTextBoxColumn,
            this.balanceDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.rentalrecordBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(361, 72);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(313, 245);
            this.dataGridView1.TabIndex = 96;
            // 
            // car_rental_system_dbDataSet5
            // 
            this.car_rental_system_dbDataSet5.DataSetName = "car_rental_system_dbDataSet5";
            this.car_rental_system_dbDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rentalrecordBindingSource
            // 
            this.rentalrecordBindingSource.DataMember = "rental_record";
            this.rentalrecordBindingSource.DataSource = this.car_rental_system_dbDataSet5;
            // 
            // rental_recordTableAdapter
            // 
            this.rental_recordTableAdapter.ClearBeforeFill = true;
            // 
            // caridDataGridViewTextBoxColumn
            // 
            this.caridDataGridViewTextBoxColumn.DataPropertyName = "car_id";
            this.caridDataGridViewTextBoxColumn.HeaderText = "car_id";
            this.caridDataGridViewTextBoxColumn.Name = "caridDataGridViewTextBoxColumn";
            // 
            // customeridDataGridViewTextBoxColumn
            // 
            this.customeridDataGridViewTextBoxColumn.DataPropertyName = "customer_id";
            this.customeridDataGridViewTextBoxColumn.HeaderText = "customer_id";
            this.customeridDataGridViewTextBoxColumn.Name = "customeridDataGridViewTextBoxColumn";
            // 
            // bookingfromDataGridViewTextBoxColumn
            // 
            this.bookingfromDataGridViewTextBoxColumn.DataPropertyName = "booking_from";
            this.bookingfromDataGridViewTextBoxColumn.HeaderText = "booking_from";
            this.bookingfromDataGridViewTextBoxColumn.Name = "bookingfromDataGridViewTextBoxColumn";
            // 
            // bookingtoDataGridViewTextBoxColumn
            // 
            this.bookingtoDataGridViewTextBoxColumn.DataPropertyName = "booking_to";
            this.bookingtoDataGridViewTextBoxColumn.HeaderText = "booking_to";
            this.bookingtoDataGridViewTextBoxColumn.Name = "bookingtoDataGridViewTextBoxColumn";
            // 
            // totalrentDataGridViewTextBoxColumn
            // 
            this.totalrentDataGridViewTextBoxColumn.DataPropertyName = "total_rent";
            this.totalrentDataGridViewTextBoxColumn.HeaderText = "total_rent";
            this.totalrentDataGridViewTextBoxColumn.Name = "totalrentDataGridViewTextBoxColumn";
            // 
            // paidDataGridViewTextBoxColumn
            // 
            this.paidDataGridViewTextBoxColumn.DataPropertyName = "paid";
            this.paidDataGridViewTextBoxColumn.HeaderText = "paid";
            this.paidDataGridViewTextBoxColumn.Name = "paidDataGridViewTextBoxColumn";
            // 
            // balanceDataGridViewTextBoxColumn
            // 
            this.balanceDataGridViewTextBoxColumn.DataPropertyName = "balance";
            this.balanceDataGridViewTextBoxColumn.HeaderText = "balance";
            this.balanceDataGridViewTextBoxColumn.Name = "balanceDataGridViewTextBoxColumn";
            // 
            // frmRecords
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(686, 390);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnRentalReset);
            this.Controls.Add(this.btnDriverCancel);
            this.Controls.Add(this.btnRentalDelete);
            this.Controls.Add(this.btnRentalUpdate);
            this.Controls.Add(this.btnRentalSearch);
            this.Controls.Add(this.btnRentalSave);
            this.Controls.Add(this.dateRentalRecordBookingTo);
            this.Controls.Add(this.dateRentalRecordBookingFrom);
            this.Controls.Add(this.txtRentalRecordBalance);
            this.Controls.Add(this.lblRentalRecordBalance);
            this.Controls.Add(this.lblRentalRecordsList);
            this.Controls.Add(this.lblRecords);
            this.Controls.Add(this.txtRentalRecordPaid);
            this.Controls.Add(this.lblRentalRecordPaid);
            this.Controls.Add(this.txtRentalRecordTotalRent);
            this.Controls.Add(this.lblRentalRecordTotalRent);
            this.Controls.Add(this.lblRentalRecordBookingTo);
            this.Controls.Add(this.lblRentalRecordBookingFrom);
            this.Controls.Add(this.txtRentalRecordCustomerID);
            this.Controls.Add(this.lblRentalRecordCustomerID);
            this.Controls.Add(this.txtRentalRecordCarId);
            this.Controls.Add(this.lblRentalRecordCarId);
            this.Controls.Add(this.lblRentalRecordsAddData);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmRecords";
            this.Text = "Records";
            this.Load += new System.EventHandler(this.frmRecords_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.car_rental_system_dbDataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rentalrecordBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtRentalRecordBalance;
        private System.Windows.Forms.Label lblRentalRecordBalance;
        private System.Windows.Forms.Label lblRentalRecordsList;
        private System.Windows.Forms.Label lblRecords;
        private System.Windows.Forms.TextBox txtRentalRecordPaid;
        private System.Windows.Forms.Label lblRentalRecordPaid;
        private System.Windows.Forms.TextBox txtRentalRecordTotalRent;
        private System.Windows.Forms.Label lblRentalRecordTotalRent;
        private System.Windows.Forms.Label lblRentalRecordBookingTo;
        private System.Windows.Forms.Label lblRentalRecordBookingFrom;
        private System.Windows.Forms.TextBox txtRentalRecordCustomerID;
        private System.Windows.Forms.Label lblRentalRecordCustomerID;
        private System.Windows.Forms.TextBox txtRentalRecordCarId;
        private System.Windows.Forms.Label lblRentalRecordCarId;
        private System.Windows.Forms.Label lblRentalRecordsAddData;
        private System.Windows.Forms.DateTimePicker dateRentalRecordBookingFrom;
        private System.Windows.Forms.DateTimePicker dateRentalRecordBookingTo;
        private System.Windows.Forms.Button btnRentalReset;
        private System.Windows.Forms.Button btnDriverCancel;
        private System.Windows.Forms.Button btnRentalDelete;
        private System.Windows.Forms.Button btnRentalUpdate;
        private System.Windows.Forms.Button btnRentalSearch;
        private System.Windows.Forms.Button btnRentalSave;
        private System.Windows.Forms.DataGridView dataGridView1;
        private CarRentalFinal.car_rental_system_dbDataSet5 car_rental_system_dbDataSet5;
        private System.Windows.Forms.BindingSource rentalrecordBindingSource;
        private CarRentalFinal.car_rental_system_dbDataSet5TableAdapters.rental_recordTableAdapter rental_recordTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn caridDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customeridDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookingfromDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookingtoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalrentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn paidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn balanceDataGridViewTextBoxColumn;
    }
}