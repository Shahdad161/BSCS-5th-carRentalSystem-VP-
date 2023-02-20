
namespace car_rental_system
{
    partial class FrmDriver
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDriver));
            this.lblDriverManagment = new System.Windows.Forms.Label();
            this.lblGender = new System.Windows.Forms.Label();
            this.txtContacNo = new System.Windows.Forms.TextBox();
            this.lblDriverId = new System.Windows.Forms.Label();
            this.txtCnic = new System.Windows.Forms.TextBox();
            this.lblCnic = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.lblLastName = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.txtDriverIdDriver = new System.Windows.Forms.TextBox();
            this.lblDriverId2 = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.btnDriverReset = new System.Windows.Forms.Button();
            this.btnDriverCancel = new System.Windows.Forms.Button();
            this.btnDriverDelete = new System.Windows.Forms.Button();
            this.btnDriverUpdate = new System.Windows.Forms.Button();
            this.btnDriverSearch = new System.Windows.Forms.Button();
            this.btnDriverSave = new System.Windows.Forms.Button();
            this.txtLicenseNo = new System.Windows.Forms.TextBox();
            this.lbllicenseNo = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cnicDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.licensenoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contactnoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.driverBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.car_rental_system_dbDataSet4 = new CarRentalFinal.car_rental_system_dbDataSet4();
            this.driverTableAdapter = new CarRentalFinal.car_rental_system_dbDataSet4TableAdapters.driverTableAdapter();
            this.txtgender = new System.Windows.Forms.ComboBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.driverBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.car_rental_system_dbDataSet4)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDriverManagment
            // 
            this.lblDriverManagment.AutoSize = true;
            this.lblDriverManagment.BackColor = System.Drawing.Color.Red;
            this.lblDriverManagment.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblDriverManagment.Location = new System.Drawing.Point(358, 9);
            this.lblDriverManagment.Name = "lblDriverManagment";
            this.lblDriverManagment.Size = new System.Drawing.Size(75, 25);
            this.lblDriverManagment.TabIndex = 44;
            this.lblDriverManagment.Text = "Drivers";
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.BackColor = System.Drawing.Color.Red;
            this.lblGender.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblGender.Location = new System.Drawing.Point(631, 55);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(61, 21);
            this.lblGender.TabIndex = 41;
            this.lblGender.Text = "Gender";
            // 
            // txtContacNo
            // 
            this.txtContacNo.Location = new System.Drawing.Point(528, 103);
            this.txtContacNo.Name = "txtContacNo";
            this.txtContacNo.Size = new System.Drawing.Size(86, 20);
            this.txtContacNo.TabIndex = 40;
            // 
            // lblDriverId
            // 
            this.lblDriverId.AutoSize = true;
            this.lblDriverId.BackColor = System.Drawing.Color.Red;
            this.lblDriverId.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblDriverId.Location = new System.Drawing.Point(434, 102);
            this.lblDriverId.Name = "lblDriverId";
            this.lblDriverId.Size = new System.Drawing.Size(88, 21);
            this.lblDriverId.TabIndex = 39;
            this.lblDriverId.Text = "Contact No";
            // 
            // txtCnic
            // 
            this.txtCnic.Location = new System.Drawing.Point(319, 100);
            this.txtCnic.Name = "txtCnic";
            this.txtCnic.Size = new System.Drawing.Size(86, 20);
            this.txtCnic.TabIndex = 38;
            this.txtCnic.TextChanged += new System.EventHandler(this.txtCnic_TextChanged);
            // 
            // lblCnic
            // 
            this.lblCnic.AutoSize = true;
            this.lblCnic.BackColor = System.Drawing.Color.Red;
            this.lblCnic.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblCnic.Location = new System.Drawing.Point(227, 102);
            this.lblCnic.Name = "lblCnic";
            this.lblCnic.Size = new System.Drawing.Size(46, 21);
            this.lblCnic.TabIndex = 37;
            this.lblCnic.Text = "CNIC";
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(101, 100);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(86, 20);
            this.txtLastName.TabIndex = 36;
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.BackColor = System.Drawing.Color.Red;
            this.lblLastName.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblLastName.Location = new System.Drawing.Point(11, 102);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(84, 21);
            this.lblLastName.TabIndex = 35;
            this.lblLastName.Text = "Last Name";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(528, 54);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(86, 20);
            this.txtFirstName.TabIndex = 34;
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.BackColor = System.Drawing.Color.Red;
            this.lblFirstName.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblFirstName.Location = new System.Drawing.Point(436, 54);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(86, 21);
            this.lblFirstName.TabIndex = 33;
            this.lblFirstName.Text = "First Name";
            // 
            // txtDriverIdDriver
            // 
            this.txtDriverIdDriver.Location = new System.Drawing.Point(101, 60);
            this.txtDriverIdDriver.Name = "txtDriverIdDriver";
            this.txtDriverIdDriver.Size = new System.Drawing.Size(86, 20);
            this.txtDriverIdDriver.TabIndex = 32;
            // 
            // lblDriverId2
            // 
            this.lblDriverId2.AutoSize = true;
            this.lblDriverId2.BackColor = System.Drawing.Color.Red;
            this.lblDriverId2.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblDriverId2.ForeColor = System.Drawing.Color.Black;
            this.lblDriverId2.Location = new System.Drawing.Point(11, 62);
            this.lblDriverId2.Name = "lblDriverId2";
            this.lblDriverId2.Size = new System.Drawing.Size(72, 21);
            this.lblDriverId2.TabIndex = 31;
            this.lblDriverId2.Text = "Driver ID";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.BackColor = System.Drawing.Color.Red;
            this.lblAddress.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblAddress.Location = new System.Drawing.Point(631, 102);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(66, 21);
            this.lblAddress.TabIndex = 46;
            this.lblAddress.Text = "Address";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(721, 100);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(86, 20);
            this.txtAddress.TabIndex = 47;
            // 
            // btnDriverReset
            // 
            this.btnDriverReset.BackColor = System.Drawing.Color.Red;
            this.btnDriverReset.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnDriverReset.Location = new System.Drawing.Point(584, 138);
            this.btnDriverReset.Name = "btnDriverReset";
            this.btnDriverReset.Size = new System.Drawing.Size(78, 30);
            this.btnDriverReset.TabIndex = 82;
            this.btnDriverReset.Text = "Reset";
            this.btnDriverReset.UseVisualStyleBackColor = false;
            this.btnDriverReset.Click += new System.EventHandler(this.btnDriverReset_Click);
            // 
            // btnDriverCancel
            // 
            this.btnDriverCancel.BackColor = System.Drawing.Color.Red;
            this.btnDriverCancel.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnDriverCancel.Location = new System.Drawing.Point(501, 138);
            this.btnDriverCancel.Name = "btnDriverCancel";
            this.btnDriverCancel.Size = new System.Drawing.Size(78, 30);
            this.btnDriverCancel.TabIndex = 81;
            this.btnDriverCancel.Text = "Cancel";
            this.btnDriverCancel.UseVisualStyleBackColor = false;
            this.btnDriverCancel.Click += new System.EventHandler(this.btnDriverCancel_Click);
            // 
            // btnDriverDelete
            // 
            this.btnDriverDelete.BackColor = System.Drawing.Color.Red;
            this.btnDriverDelete.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnDriverDelete.Location = new System.Drawing.Point(417, 138);
            this.btnDriverDelete.Name = "btnDriverDelete";
            this.btnDriverDelete.Size = new System.Drawing.Size(78, 30);
            this.btnDriverDelete.TabIndex = 80;
            this.btnDriverDelete.Text = "Delete";
            this.btnDriverDelete.UseVisualStyleBackColor = false;
            // 
            // btnDriverUpdate
            // 
            this.btnDriverUpdate.BackColor = System.Drawing.Color.Red;
            this.btnDriverUpdate.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnDriverUpdate.Location = new System.Drawing.Point(333, 138);
            this.btnDriverUpdate.Name = "btnDriverUpdate";
            this.btnDriverUpdate.Size = new System.Drawing.Size(78, 30);
            this.btnDriverUpdate.TabIndex = 79;
            this.btnDriverUpdate.Text = "Update";
            this.btnDriverUpdate.UseVisualStyleBackColor = false;
            this.btnDriverUpdate.Click += new System.EventHandler(this.btnDriverUpdate_Click);
            // 
            // btnDriverSearch
            // 
            this.btnDriverSearch.BackColor = System.Drawing.Color.Red;
            this.btnDriverSearch.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnDriverSearch.Location = new System.Drawing.Point(250, 138);
            this.btnDriverSearch.Name = "btnDriverSearch";
            this.btnDriverSearch.Size = new System.Drawing.Size(78, 30);
            this.btnDriverSearch.TabIndex = 78;
            this.btnDriverSearch.Text = "Search";
            this.btnDriverSearch.UseVisualStyleBackColor = false;
            this.btnDriverSearch.Click += new System.EventHandler(this.btnDriverSearch_Click);
            // 
            // btnDriverSave
            // 
            this.btnDriverSave.BackColor = System.Drawing.Color.Red;
            this.btnDriverSave.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnDriverSave.Location = new System.Drawing.Point(166, 138);
            this.btnDriverSave.Name = "btnDriverSave";
            this.btnDriverSave.Size = new System.Drawing.Size(78, 30);
            this.btnDriverSave.TabIndex = 77;
            this.btnDriverSave.Text = "Save";
            this.btnDriverSave.UseVisualStyleBackColor = false;
            this.btnDriverSave.Click += new System.EventHandler(this.btnDriverSave_Click);
            // 
            // txtLicenseNo
            // 
            this.txtLicenseNo.Location = new System.Drawing.Point(319, 57);
            this.txtLicenseNo.Name = "txtLicenseNo";
            this.txtLicenseNo.Size = new System.Drawing.Size(86, 20);
            this.txtLicenseNo.TabIndex = 84;
            // 
            // lbllicenseNo
            // 
            this.lbllicenseNo.AutoSize = true;
            this.lbllicenseNo.BackColor = System.Drawing.Color.Red;
            this.lbllicenseNo.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lbllicenseNo.Location = new System.Drawing.Point(227, 57);
            this.lbllicenseNo.Name = "lbllicenseNo";
            this.lbllicenseNo.Size = new System.Drawing.Size(86, 21);
            this.lbllicenseNo.TabIndex = 83;
            this.lbllicenseNo.Text = "License No";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.firstnameDataGridViewTextBoxColumn,
            this.lastnameDataGridViewTextBoxColumn,
            this.cnicDataGridViewTextBoxColumn,
            this.licensenoDataGridViewTextBoxColumn,
            this.contactnoDataGridViewTextBoxColumn,
            this.genderDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.driverBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(0, 315);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(820, 114);
            this.dataGridView1.TabIndex = 85;
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
            // cnicDataGridViewTextBoxColumn
            // 
            this.cnicDataGridViewTextBoxColumn.DataPropertyName = "cnic";
            this.cnicDataGridViewTextBoxColumn.HeaderText = "cnic";
            this.cnicDataGridViewTextBoxColumn.Name = "cnicDataGridViewTextBoxColumn";
            // 
            // licensenoDataGridViewTextBoxColumn
            // 
            this.licensenoDataGridViewTextBoxColumn.DataPropertyName = "license_no";
            this.licensenoDataGridViewTextBoxColumn.HeaderText = "license_no";
            this.licensenoDataGridViewTextBoxColumn.Name = "licensenoDataGridViewTextBoxColumn";
            // 
            // contactnoDataGridViewTextBoxColumn
            // 
            this.contactnoDataGridViewTextBoxColumn.DataPropertyName = "contact_no";
            this.contactnoDataGridViewTextBoxColumn.HeaderText = "contact_no";
            this.contactnoDataGridViewTextBoxColumn.Name = "contactnoDataGridViewTextBoxColumn";
            // 
            // genderDataGridViewTextBoxColumn
            // 
            this.genderDataGridViewTextBoxColumn.DataPropertyName = "gender";
            this.genderDataGridViewTextBoxColumn.HeaderText = "gender";
            this.genderDataGridViewTextBoxColumn.Name = "genderDataGridViewTextBoxColumn";
            // 
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.DataPropertyName = "address";
            this.addressDataGridViewTextBoxColumn.HeaderText = "address";
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            // 
            // driverBindingSource
            // 
            this.driverBindingSource.DataMember = "driver";
            this.driverBindingSource.DataSource = this.car_rental_system_dbDataSet4;
            // 
            // car_rental_system_dbDataSet4
            // 
            this.car_rental_system_dbDataSet4.DataSetName = "car_rental_system_dbDataSet4";
            this.car_rental_system_dbDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // driverTableAdapter
            // 
            this.driverTableAdapter.ClearBeforeFill = true;
            // 
            // txtgender
            // 
            this.txtgender.FormattingEnabled = true;
            this.txtgender.Items.AddRange(new object[] {
            "Male ",
            "Femal",
            "Rather not say"});
            this.txtgender.Location = new System.Drawing.Point(721, 57);
            this.txtgender.Name = "txtgender";
            this.txtgender.Size = new System.Drawing.Size(86, 21);
            this.txtgender.TabIndex = 87;
            // 
            // FrmDriver
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(819, 481);
            this.Controls.Add(this.txtgender);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtLicenseNo);
            this.Controls.Add(this.lbllicenseNo);
            this.Controls.Add(this.btnDriverReset);
            this.Controls.Add(this.btnDriverCancel);
            this.Controls.Add(this.btnDriverDelete);
            this.Controls.Add(this.btnDriverUpdate);
            this.Controls.Add(this.btnDriverSearch);
            this.Controls.Add(this.btnDriverSave);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.lblDriverManagment);
            this.Controls.Add(this.lblGender);
            this.Controls.Add(this.txtContacNo);
            this.Controls.Add(this.lblDriverId);
            this.Controls.Add(this.txtCnic);
            this.Controls.Add(this.lblCnic);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.txtDriverIdDriver);
            this.Controls.Add(this.lblDriverId2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmDriver";
            this.Text = "Drivers";
            this.Load += new System.EventHandler(this.FrmDriver_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.driverBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.car_rental_system_dbDataSet4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblDriverManagment;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.TextBox txtContacNo;
        private System.Windows.Forms.Label lblDriverId;
        private System.Windows.Forms.TextBox txtCnic;
        private System.Windows.Forms.Label lblCnic;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.TextBox txtDriverIdDriver;
        private System.Windows.Forms.Label lblDriverId2;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Button btnDriverReset;
        private System.Windows.Forms.Button btnDriverCancel;
        private System.Windows.Forms.Button btnDriverDelete;
        private System.Windows.Forms.Button btnDriverUpdate;
        private System.Windows.Forms.Button btnDriverSearch;
        private System.Windows.Forms.Button btnDriverSave;
        private System.Windows.Forms.TextBox txtLicenseNo;
        private System.Windows.Forms.Label lbllicenseNo;
        private System.Windows.Forms.DataGridView dataGridView1;
        private CarRentalFinal.car_rental_system_dbDataSet4 car_rental_system_dbDataSet4;
        private System.Windows.Forms.BindingSource driverBindingSource;
        private CarRentalFinal.car_rental_system_dbDataSet4TableAdapters.driverTableAdapter driverTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cnicDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn licensenoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contactnoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn genderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private System.Windows.Forms.ComboBox txtgender;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}