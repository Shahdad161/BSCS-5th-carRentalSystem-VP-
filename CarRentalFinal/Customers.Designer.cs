
namespace car_rental_system
{
    partial class FrmCustomer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCustomer));
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.lblCustomerAddress = new System.Windows.Forms.Label();
            this.lblCustomerList = new System.Windows.Forms.Label();
            this.lblCustomerManagment = new System.Windows.Forms.Label();
            this.btnCustomerSave = new System.Windows.Forms.Button();
            this.lblCustomerGender = new System.Windows.Forms.Label();
            this.txtCustomerContactNo = new System.Windows.Forms.TextBox();
            this.lblCustomerContactNo = new System.Windows.Forms.Label();
            this.txtCustomerCnic = new System.Windows.Forms.TextBox();
            this.lblCustomerCnic = new System.Windows.Forms.Label();
            this.txtCustomerLastName = new System.Windows.Forms.TextBox();
            this.lblCustomerLastName = new System.Windows.Forms.Label();
            this.txtCustomerFirstName = new System.Windows.Forms.TextBox();
            this.lblCustomerFirstName = new System.Windows.Forms.Label();
            this.txtCustomerId = new System.Windows.Forms.TextBox();
            this.lblCustomerId = new System.Windows.Forms.Label();
            this.lblCustomerAddData = new System.Windows.Forms.Label();
            this.txtGuarantorCnic = new System.Windows.Forms.TextBox();
            this.lblGuarantorCnic = new System.Windows.Forms.Label();
            this.txtGuarantorName = new System.Windows.Forms.TextBox();
            this.lblGuarantorName = new System.Windows.Forms.Label();
            this.btnCustomerReset = new System.Windows.Forms.Button();
            this.btnCustomerCancel = new System.Windows.Forms.Button();
            this.btnCustomerDelete = new System.Windows.Forms.Button();
            this.btnCustomerUpdate = new System.Windows.Forms.Button();
            this.btnCustomerSearch = new System.Windows.Forms.Button();
            this.customerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.car_rental_system_dbDataSet1 = new CarRentalFinal.car_rental_system_dbDataSet1();
            this.customerTableAdapter = new CarRentalFinal.car_rental_system_dbDataSet1TableAdapters.customerTableAdapter();
            this.customerBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.car_rental_system_dbDataSet3 = new CarRentalFinal.car_rental_system_dbDataSet3();
            this.customerTableAdapter1 = new CarRentalFinal.car_rental_system_dbDataSet3TableAdapters.customerTableAdapter();
            this.txtCustomerGender = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.car_rental_system_dbDataSet6 = new CarRentalFinal.car_rental_system_dbDataSet6();
            this.customerBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.customerTableAdapter2 = new CarRentalFinal.car_rental_system_dbDataSet6TableAdapters.customerTableAdapter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cnicDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contactnoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.guarantorcnicDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.guarantornameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.car_rental_system_dbDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.car_rental_system_dbDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.car_rental_system_dbDataSet6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(59, 189);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(108, 20);
            this.txtAddress.TabIndex = 65;
            // 
            // lblCustomerAddress
            // 
            this.lblCustomerAddress.AutoSize = true;
            this.lblCustomerAddress.BackColor = System.Drawing.Color.Transparent;
            this.lblCustomerAddress.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblCustomerAddress.Location = new System.Drawing.Point(60, 163);
            this.lblCustomerAddress.Name = "lblCustomerAddress";
            this.lblCustomerAddress.Size = new System.Drawing.Size(66, 21);
            this.lblCustomerAddress.TabIndex = 64;
            this.lblCustomerAddress.Text = "Address";
            // 
            // lblCustomerList
            // 
            this.lblCustomerList.AutoSize = true;
            this.lblCustomerList.BackColor = System.Drawing.Color.Red;
            this.lblCustomerList.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.lblCustomerList.Location = new System.Drawing.Point(346, 283);
            this.lblCustomerList.Name = "lblCustomerList";
            this.lblCustomerList.Size = new System.Drawing.Size(120, 21);
            this.lblCustomerList.TabIndex = 63;
            this.lblCustomerList.Text = "Customer\'s List";
            // 
            // lblCustomerManagment
            // 
            this.lblCustomerManagment.AutoSize = true;
            this.lblCustomerManagment.BackColor = System.Drawing.Color.Red;
            this.lblCustomerManagment.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblCustomerManagment.Location = new System.Drawing.Point(345, 20);
            this.lblCustomerManagment.Name = "lblCustomerManagment";
            this.lblCustomerManagment.Size = new System.Drawing.Size(106, 25);
            this.lblCustomerManagment.TabIndex = 62;
            this.lblCustomerManagment.Text = "Customers";
            // 
            // btnCustomerSave
            // 
            this.btnCustomerSave.BackColor = System.Drawing.Color.Red;
            this.btnCustomerSave.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnCustomerSave.Location = new System.Drawing.Point(144, 235);
            this.btnCustomerSave.Name = "btnCustomerSave";
            this.btnCustomerSave.Size = new System.Drawing.Size(78, 30);
            this.btnCustomerSave.TabIndex = 61;
            this.btnCustomerSave.Text = "Save";
            this.btnCustomerSave.UseVisualStyleBackColor = false;
            this.btnCustomerSave.Click += new System.EventHandler(this.btnCustomerSave_Click);
            // 
            // lblCustomerGender
            // 
            this.lblCustomerGender.AutoSize = true;
            this.lblCustomerGender.BackColor = System.Drawing.Color.Transparent;
            this.lblCustomerGender.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblCustomerGender.Location = new System.Drawing.Point(698, 103);
            this.lblCustomerGender.Name = "lblCustomerGender";
            this.lblCustomerGender.Size = new System.Drawing.Size(61, 21);
            this.lblCustomerGender.TabIndex = 59;
            this.lblCustomerGender.Text = "Gender";
            // 
            // txtCustomerContactNo
            // 
            this.txtCustomerContactNo.Location = new System.Drawing.Point(567, 124);
            this.txtCustomerContactNo.Name = "txtCustomerContactNo";
            this.txtCustomerContactNo.Size = new System.Drawing.Size(107, 20);
            this.txtCustomerContactNo.TabIndex = 58;
            // 
            // lblCustomerContactNo
            // 
            this.lblCustomerContactNo.AutoSize = true;
            this.lblCustomerContactNo.BackColor = System.Drawing.Color.Transparent;
            this.lblCustomerContactNo.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblCustomerContactNo.Location = new System.Drawing.Point(565, 103);
            this.lblCustomerContactNo.Name = "lblCustomerContactNo";
            this.lblCustomerContactNo.Size = new System.Drawing.Size(88, 21);
            this.lblCustomerContactNo.TabIndex = 57;
            this.lblCustomerContactNo.Text = "Contact No";
            // 
            // txtCustomerCnic
            // 
            this.txtCustomerCnic.Location = new System.Drawing.Point(433, 124);
            this.txtCustomerCnic.Name = "txtCustomerCnic";
            this.txtCustomerCnic.Size = new System.Drawing.Size(102, 20);
            this.txtCustomerCnic.TabIndex = 56;
            // 
            // lblCustomerCnic
            // 
            this.lblCustomerCnic.AutoSize = true;
            this.lblCustomerCnic.BackColor = System.Drawing.Color.Transparent;
            this.lblCustomerCnic.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblCustomerCnic.Location = new System.Drawing.Point(432, 104);
            this.lblCustomerCnic.Name = "lblCustomerCnic";
            this.lblCustomerCnic.Size = new System.Drawing.Size(46, 21);
            this.lblCustomerCnic.TabIndex = 55;
            this.lblCustomerCnic.Text = "CNIC";
            // 
            // txtCustomerLastName
            // 
            this.txtCustomerLastName.Location = new System.Drawing.Point(313, 124);
            this.txtCustomerLastName.Name = "txtCustomerLastName";
            this.txtCustomerLastName.Size = new System.Drawing.Size(108, 20);
            this.txtCustomerLastName.TabIndex = 54;
            // 
            // lblCustomerLastName
            // 
            this.lblCustomerLastName.AutoSize = true;
            this.lblCustomerLastName.BackColor = System.Drawing.Color.Transparent;
            this.lblCustomerLastName.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblCustomerLastName.Location = new System.Drawing.Point(312, 103);
            this.lblCustomerLastName.Name = "lblCustomerLastName";
            this.lblCustomerLastName.Size = new System.Drawing.Size(84, 21);
            this.lblCustomerLastName.TabIndex = 53;
            this.lblCustomerLastName.Text = "Last Name";
            // 
            // txtCustomerFirstName
            // 
            this.txtCustomerFirstName.Location = new System.Drawing.Point(180, 124);
            this.txtCustomerFirstName.Name = "txtCustomerFirstName";
            this.txtCustomerFirstName.Size = new System.Drawing.Size(101, 20);
            this.txtCustomerFirstName.TabIndex = 52;
            // 
            // lblCustomerFirstName
            // 
            this.lblCustomerFirstName.AutoSize = true;
            this.lblCustomerFirstName.BackColor = System.Drawing.Color.Transparent;
            this.lblCustomerFirstName.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblCustomerFirstName.Location = new System.Drawing.Point(180, 103);
            this.lblCustomerFirstName.Name = "lblCustomerFirstName";
            this.lblCustomerFirstName.Size = new System.Drawing.Size(86, 21);
            this.lblCustomerFirstName.TabIndex = 51;
            this.lblCustomerFirstName.Text = "First Name";
            // 
            // txtCustomerId
            // 
            this.txtCustomerId.Location = new System.Drawing.Point(60, 124);
            this.txtCustomerId.Name = "txtCustomerId";
            this.txtCustomerId.Size = new System.Drawing.Size(107, 20);
            this.txtCustomerId.TabIndex = 50;
            // 
            // lblCustomerId
            // 
            this.lblCustomerId.AutoSize = true;
            this.lblCustomerId.BackColor = System.Drawing.Color.Transparent;
            this.lblCustomerId.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblCustomerId.ForeColor = System.Drawing.Color.Black;
            this.lblCustomerId.Location = new System.Drawing.Point(57, 103);
            this.lblCustomerId.Name = "lblCustomerId";
            this.lblCustomerId.Size = new System.Drawing.Size(97, 21);
            this.lblCustomerId.TabIndex = 49;
            this.lblCustomerId.Text = "Customer ID";
            // 
            // lblCustomerAddData
            // 
            this.lblCustomerAddData.AutoSize = true;
            this.lblCustomerAddData.BackColor = System.Drawing.Color.Red;
            this.lblCustomerAddData.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.lblCustomerAddData.Location = new System.Drawing.Point(363, 72);
            this.lblCustomerAddData.Name = "lblCustomerAddData";
            this.lblCustomerAddData.Size = new System.Drawing.Size(78, 21);
            this.lblCustomerAddData.TabIndex = 48;
            this.lblCustomerAddData.Text = "Add Data";
            // 
            // txtGuarantorCnic
            // 
            this.txtGuarantorCnic.Location = new System.Drawing.Point(180, 189);
            this.txtGuarantorCnic.Name = "txtGuarantorCnic";
            this.txtGuarantorCnic.Size = new System.Drawing.Size(121, 20);
            this.txtGuarantorCnic.TabIndex = 67;
            // 
            // lblGuarantorCnic
            // 
            this.lblGuarantorCnic.AutoSize = true;
            this.lblGuarantorCnic.BackColor = System.Drawing.Color.Transparent;
            this.lblGuarantorCnic.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblGuarantorCnic.Location = new System.Drawing.Point(180, 165);
            this.lblGuarantorCnic.Name = "lblGuarantorCnic";
            this.lblGuarantorCnic.Size = new System.Drawing.Size(121, 21);
            this.lblGuarantorCnic.TabIndex = 66;
            this.lblGuarantorCnic.Text = "Guarantor CNIC";
            // 
            // txtGuarantorName
            // 
            this.txtGuarantorName.Location = new System.Drawing.Point(318, 189);
            this.txtGuarantorName.Name = "txtGuarantorName";
            this.txtGuarantorName.Size = new System.Drawing.Size(125, 20);
            this.txtGuarantorName.TabIndex = 69;
            // 
            // lblGuarantorName
            // 
            this.lblGuarantorName.AutoSize = true;
            this.lblGuarantorName.BackColor = System.Drawing.Color.Transparent;
            this.lblGuarantorName.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblGuarantorName.Location = new System.Drawing.Point(316, 163);
            this.lblGuarantorName.Name = "lblGuarantorName";
            this.lblGuarantorName.Size = new System.Drawing.Size(127, 21);
            this.lblGuarantorName.TabIndex = 68;
            this.lblGuarantorName.Text = "Guarantor Name";
            // 
            // btnCustomerReset
            // 
            this.btnCustomerReset.BackColor = System.Drawing.Color.Red;
            this.btnCustomerReset.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnCustomerReset.Location = new System.Drawing.Point(569, 235);
            this.btnCustomerReset.Name = "btnCustomerReset";
            this.btnCustomerReset.Size = new System.Drawing.Size(78, 30);
            this.btnCustomerReset.TabIndex = 76;
            this.btnCustomerReset.Text = "Reset";
            this.btnCustomerReset.UseVisualStyleBackColor = false;
            this.btnCustomerReset.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnCustomerCancel
            // 
            this.btnCustomerCancel.BackColor = System.Drawing.Color.Red;
            this.btnCustomerCancel.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnCustomerCancel.Location = new System.Drawing.Point(486, 235);
            this.btnCustomerCancel.Name = "btnCustomerCancel";
            this.btnCustomerCancel.Size = new System.Drawing.Size(78, 30);
            this.btnCustomerCancel.TabIndex = 75;
            this.btnCustomerCancel.Text = "Cancel";
            this.btnCustomerCancel.UseVisualStyleBackColor = false;
            this.btnCustomerCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnCustomerDelete
            // 
            this.btnCustomerDelete.BackColor = System.Drawing.Color.Red;
            this.btnCustomerDelete.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnCustomerDelete.Location = new System.Drawing.Point(403, 235);
            this.btnCustomerDelete.Name = "btnCustomerDelete";
            this.btnCustomerDelete.Size = new System.Drawing.Size(78, 30);
            this.btnCustomerDelete.TabIndex = 74;
            this.btnCustomerDelete.Text = "Delete";
            this.btnCustomerDelete.UseVisualStyleBackColor = false;
            this.btnCustomerDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnCustomerUpdate
            // 
            this.btnCustomerUpdate.BackColor = System.Drawing.Color.Red;
            this.btnCustomerUpdate.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnCustomerUpdate.Location = new System.Drawing.Point(310, 235);
            this.btnCustomerUpdate.Name = "btnCustomerUpdate";
            this.btnCustomerUpdate.Size = new System.Drawing.Size(78, 30);
            this.btnCustomerUpdate.TabIndex = 73;
            this.btnCustomerUpdate.Text = "Update";
            this.btnCustomerUpdate.UseVisualStyleBackColor = false;
            this.btnCustomerUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnCustomerSearch
            // 
            this.btnCustomerSearch.BackColor = System.Drawing.Color.Red;
            this.btnCustomerSearch.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnCustomerSearch.Location = new System.Drawing.Point(227, 235);
            this.btnCustomerSearch.Name = "btnCustomerSearch";
            this.btnCustomerSearch.Size = new System.Drawing.Size(78, 30);
            this.btnCustomerSearch.TabIndex = 72;
            this.btnCustomerSearch.Text = "Search";
            this.btnCustomerSearch.UseVisualStyleBackColor = false;
            this.btnCustomerSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // customerBindingSource
            // 
            this.customerBindingSource.DataMember = "customer";
            this.customerBindingSource.DataSource = this.car_rental_system_dbDataSet1;
            // 
            // car_rental_system_dbDataSet1
            // 
            this.car_rental_system_dbDataSet1.DataSetName = "car_rental_system_dbDataSet1";
            this.car_rental_system_dbDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // customerTableAdapter
            // 
            this.customerTableAdapter.ClearBeforeFill = true;
            // 
            // customerBindingSource1
            // 
            this.customerBindingSource1.DataMember = "customer";
            this.customerBindingSource1.DataSource = this.car_rental_system_dbDataSet3;
            // 
            // car_rental_system_dbDataSet3
            // 
            this.car_rental_system_dbDataSet3.DataSetName = "car_rental_system_dbDataSet3";
            this.car_rental_system_dbDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // customerTableAdapter1
            // 
            this.customerTableAdapter1.ClearBeforeFill = true;
            // 
            // txtCustomerGender
            // 
            this.txtCustomerGender.FormattingEnabled = true;
            this.txtCustomerGender.Items.AddRange(new object[] {
            "Male",
            "Female",
            "Not Say"});
            this.txtCustomerGender.Location = new System.Drawing.Point(702, 127);
            this.txtCustomerGender.Name = "txtCustomerGender";
            this.txtCustomerGender.Size = new System.Drawing.Size(94, 21);
            this.txtCustomerGender.TabIndex = 79;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.firstnameDataGridViewTextBoxColumn,
            this.lastnameDataGridViewTextBoxColumn,
            this.genderDataGridViewTextBoxColumn,
            this.cnicDataGridViewTextBoxColumn,
            this.contactnoDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn,
            this.guarantorcnicDataGridViewTextBoxColumn,
            this.guarantornameDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.customerBindingSource2;
            this.dataGridView1.Location = new System.Drawing.Point(49, 307);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(747, 109);
            this.dataGridView1.TabIndex = 80;
            // 
            // car_rental_system_dbDataSet6
            // 
            this.car_rental_system_dbDataSet6.DataSetName = "car_rental_system_dbDataSet6";
            this.car_rental_system_dbDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // customerBindingSource2
            // 
            this.customerBindingSource2.DataMember = "customer";
            this.customerBindingSource2.DataSource = this.car_rental_system_dbDataSet6;
            // 
            // customerTableAdapter2
            // 
            this.customerTableAdapter2.ClearBeforeFill = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // firstnameDataGridViewTextBoxColumn
            // 
            this.firstnameDataGridViewTextBoxColumn.DataPropertyName = "first_name";
            this.firstnameDataGridViewTextBoxColumn.HeaderText = "first_name";
            this.firstnameDataGridViewTextBoxColumn.Name = "firstnameDataGridViewTextBoxColumn";
            // 
            // lastnameDataGridViewTextBoxColumn
            // 
            this.lastnameDataGridViewTextBoxColumn.DataPropertyName = "last_name";
            this.lastnameDataGridViewTextBoxColumn.HeaderText = "last_name";
            this.lastnameDataGridViewTextBoxColumn.Name = "lastnameDataGridViewTextBoxColumn";
            // 
            // genderDataGridViewTextBoxColumn
            // 
            this.genderDataGridViewTextBoxColumn.DataPropertyName = "gender";
            this.genderDataGridViewTextBoxColumn.HeaderText = "gender";
            this.genderDataGridViewTextBoxColumn.Name = "genderDataGridViewTextBoxColumn";
            // 
            // cnicDataGridViewTextBoxColumn
            // 
            this.cnicDataGridViewTextBoxColumn.DataPropertyName = "cnic";
            this.cnicDataGridViewTextBoxColumn.HeaderText = "cnic";
            this.cnicDataGridViewTextBoxColumn.Name = "cnicDataGridViewTextBoxColumn";
            // 
            // contactnoDataGridViewTextBoxColumn
            // 
            this.contactnoDataGridViewTextBoxColumn.DataPropertyName = "contact_no";
            this.contactnoDataGridViewTextBoxColumn.HeaderText = "contact_no";
            this.contactnoDataGridViewTextBoxColumn.Name = "contactnoDataGridViewTextBoxColumn";
            // 
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.DataPropertyName = "address";
            this.addressDataGridViewTextBoxColumn.HeaderText = "address";
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            // 
            // guarantorcnicDataGridViewTextBoxColumn
            // 
            this.guarantorcnicDataGridViewTextBoxColumn.DataPropertyName = "guarantor_cnic";
            this.guarantorcnicDataGridViewTextBoxColumn.HeaderText = "guarantor_cnic";
            this.guarantorcnicDataGridViewTextBoxColumn.Name = "guarantorcnicDataGridViewTextBoxColumn";
            // 
            // guarantornameDataGridViewTextBoxColumn
            // 
            this.guarantornameDataGridViewTextBoxColumn.DataPropertyName = "guarantor_name";
            this.guarantornameDataGridViewTextBoxColumn.HeaderText = "guarantor_name";
            this.guarantornameDataGridViewTextBoxColumn.Name = "guarantornameDataGridViewTextBoxColumn";
            // 
            // FrmCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(819, 481);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtCustomerGender);
            this.Controls.Add(this.btnCustomerReset);
            this.Controls.Add(this.btnCustomerCancel);
            this.Controls.Add(this.btnCustomerDelete);
            this.Controls.Add(this.btnCustomerUpdate);
            this.Controls.Add(this.btnCustomerSearch);
            this.Controls.Add(this.txtGuarantorName);
            this.Controls.Add(this.lblGuarantorName);
            this.Controls.Add(this.txtGuarantorCnic);
            this.Controls.Add(this.lblGuarantorCnic);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.lblCustomerAddress);
            this.Controls.Add(this.lblCustomerList);
            this.Controls.Add(this.lblCustomerManagment);
            this.Controls.Add(this.btnCustomerSave);
            this.Controls.Add(this.lblCustomerGender);
            this.Controls.Add(this.txtCustomerContactNo);
            this.Controls.Add(this.lblCustomerContactNo);
            this.Controls.Add(this.txtCustomerCnic);
            this.Controls.Add(this.lblCustomerCnic);
            this.Controls.Add(this.txtCustomerLastName);
            this.Controls.Add(this.lblCustomerLastName);
            this.Controls.Add(this.txtCustomerFirstName);
            this.Controls.Add(this.lblCustomerFirstName);
            this.Controls.Add(this.txtCustomerId);
            this.Controls.Add(this.lblCustomerId);
            this.Controls.Add(this.lblCustomerAddData);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmCustomer";
            this.Text = "Customers";
            this.Load += new System.EventHandler(this.FrmCustomer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.car_rental_system_dbDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.car_rental_system_dbDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.car_rental_system_dbDataSet6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label lblCustomerAddress;
        private System.Windows.Forms.Label lblCustomerList;
        private System.Windows.Forms.Label lblCustomerManagment;
        private System.Windows.Forms.Button btnCustomerSave;
        private System.Windows.Forms.Label lblCustomerGender;
        private System.Windows.Forms.TextBox txtCustomerContactNo;
        private System.Windows.Forms.Label lblCustomerContactNo;
        private System.Windows.Forms.TextBox txtCustomerCnic;
        private System.Windows.Forms.Label lblCustomerCnic;
        private System.Windows.Forms.TextBox txtCustomerLastName;
        private System.Windows.Forms.Label lblCustomerLastName;
        private System.Windows.Forms.TextBox txtCustomerFirstName;
        private System.Windows.Forms.Label lblCustomerFirstName;
        private System.Windows.Forms.TextBox txtCustomerId;
        private System.Windows.Forms.Label lblCustomerId;
        private System.Windows.Forms.Label lblCustomerAddData;
        private System.Windows.Forms.TextBox txtGuarantorCnic;
        private System.Windows.Forms.Label lblGuarantorCnic;
        private System.Windows.Forms.TextBox txtGuarantorName;
        private System.Windows.Forms.Label lblGuarantorName;
        private System.Windows.Forms.Button btnCustomerReset;
        private System.Windows.Forms.Button btnCustomerCancel;
        private System.Windows.Forms.Button btnCustomerDelete;
        private System.Windows.Forms.Button btnCustomerUpdate;
        private System.Windows.Forms.Button btnCustomerSearch;
        private CarRentalFinal.car_rental_system_dbDataSet1 car_rental_system_dbDataSet1;
        private System.Windows.Forms.BindingSource customerBindingSource;
        private CarRentalFinal.car_rental_system_dbDataSet1TableAdapters.customerTableAdapter customerTableAdapter;
        private CarRentalFinal.car_rental_system_dbDataSet3 car_rental_system_dbDataSet3;
        private System.Windows.Forms.BindingSource customerBindingSource1;
        private CarRentalFinal.car_rental_system_dbDataSet3TableAdapters.customerTableAdapter customerTableAdapter1;
        private System.Windows.Forms.ComboBox txtCustomerGender;
        private System.Windows.Forms.DataGridView dataGridView1;
        private CarRentalFinal.car_rental_system_dbDataSet6 car_rental_system_dbDataSet6;
        private System.Windows.Forms.BindingSource customerBindingSource2;
        private CarRentalFinal.car_rental_system_dbDataSet6TableAdapters.customerTableAdapter customerTableAdapter2;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn genderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cnicDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contactnoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn guarantorcnicDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn guarantornameDataGridViewTextBoxColumn;
    }
}