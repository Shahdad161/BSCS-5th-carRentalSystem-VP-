
namespace car_rental_system
{
    partial class FrmCar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCar));
            this.btnSave = new System.Windows.Forms.Button();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblDriverId = new System.Windows.Forms.Label();
            this.txtBrand = new System.Windows.Forms.TextBox();
            this.lblBrand = new System.Windows.Forms.Label();
            this.lblModel = new System.Windows.Forms.Label();
            this.txtMake = new System.Windows.Forms.TextBox();
            this.lblMake = new System.Windows.Forms.Label();
            this.txtCarId = new System.Windows.Forms.TextBox();
            this.lblCarId = new System.Windows.Forms.Label();
            this.lblAddData = new System.Windows.Forms.Label();
            this.lblCarManagment = new System.Windows.Forms.Label();
            this.lblCarList = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.txtRegNo = new System.Windows.Forms.TextBox();
            this.lblRegNo = new System.Windows.Forms.Label();
            this.txtModel = new System.Windows.Forms.TextBox();
            this.driverBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.car_rental_system_dbDataSet = new CarRentalFinal.car_rental_system_dbDataSet();
            this.driverTableAdapter = new CarRentalFinal.car_rental_system_dbDataSetTableAdapters.driverTableAdapter();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.driverBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.car_rental_system_dbDataSet2 = new CarRentalFinal.car_rental_system_dbDataSet2();
            this.driverTableAdapter1 = new CarRentalFinal.car_rental_system_dbDataSet2TableAdapters.driverTableAdapter();
            this.fillByToolStrip = new System.Windows.Forms.ToolStrip();
            this.fillByToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.driverBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.car_rental_system_dbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.driverBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.car_rental_system_dbDataSet2)).BeginInit();
            this.fillByToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Red;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnSave.Location = new System.Drawing.Point(170, 281);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(78, 30);
            this.btnSave.TabIndex = 27;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(682, 141);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(86, 20);
            this.txtDescription.TabIndex = 26;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.BackColor = System.Drawing.Color.Red;
            this.lblDescription.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblDescription.Location = new System.Drawing.Point(570, 143);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(89, 21);
            this.lblDescription.TabIndex = 25;
            this.lblDescription.Text = "Description";
            // 
            // lblDriverId
            // 
            this.lblDriverId.AutoSize = true;
            this.lblDriverId.BackColor = System.Drawing.Color.Red;
            this.lblDriverId.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblDriverId.Location = new System.Drawing.Point(570, 110);
            this.lblDriverId.Name = "lblDriverId";
            this.lblDriverId.Size = new System.Drawing.Size(53, 21);
            this.lblDriverId.TabIndex = 23;
            this.lblDriverId.Text = "Driver";
            this.lblDriverId.Click += new System.EventHandler(this.lblDriverId_Click);
            // 
            // txtBrand
            // 
            this.txtBrand.Location = new System.Drawing.Point(438, 148);
            this.txtBrand.Name = "txtBrand";
            this.txtBrand.Size = new System.Drawing.Size(86, 20);
            this.txtBrand.TabIndex = 22;
            // 
            // lblBrand
            // 
            this.lblBrand.AutoSize = true;
            this.lblBrand.BackColor = System.Drawing.Color.Red;
            this.lblBrand.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblBrand.Location = new System.Drawing.Point(326, 148);
            this.lblBrand.Name = "lblBrand";
            this.lblBrand.Size = new System.Drawing.Size(51, 21);
            this.lblBrand.TabIndex = 21;
            this.lblBrand.Text = "Brand";
            // 
            // lblModel
            // 
            this.lblModel.AutoSize = true;
            this.lblModel.BackColor = System.Drawing.Color.Red;
            this.lblModel.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblModel.Location = new System.Drawing.Point(326, 109);
            this.lblModel.Name = "lblModel";
            this.lblModel.Size = new System.Drawing.Size(54, 21);
            this.lblModel.TabIndex = 19;
            this.lblModel.Text = "Model";
            // 
            // txtMake
            // 
            this.txtMake.Location = new System.Drawing.Point(149, 148);
            this.txtMake.Name = "txtMake";
            this.txtMake.Size = new System.Drawing.Size(125, 20);
            this.txtMake.TabIndex = 18;
            this.txtMake.TextChanged += new System.EventHandler(this.txtMake_TextChanged);
            // 
            // lblMake
            // 
            this.lblMake.AutoSize = true;
            this.lblMake.BackColor = System.Drawing.Color.Red;
            this.lblMake.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblMake.Location = new System.Drawing.Point(76, 150);
            this.lblMake.Name = "lblMake";
            this.lblMake.Size = new System.Drawing.Size(48, 21);
            this.lblMake.TabIndex = 17;
            this.lblMake.Text = "Make";
            // 
            // txtCarId
            // 
            this.txtCarId.Location = new System.Drawing.Point(149, 110);
            this.txtCarId.Name = "txtCarId";
            this.txtCarId.Size = new System.Drawing.Size(125, 20);
            this.txtCarId.TabIndex = 16;
            // 
            // lblCarId
            // 
            this.lblCarId.AutoSize = true;
            this.lblCarId.BackColor = System.Drawing.Color.Red;
            this.lblCarId.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblCarId.ForeColor = System.Drawing.Color.Black;
            this.lblCarId.Location = new System.Drawing.Point(76, 110);
            this.lblCarId.Name = "lblCarId";
            this.lblCarId.Size = new System.Drawing.Size(53, 21);
            this.lblCarId.TabIndex = 15;
            this.lblCarId.Text = "Car ID";
            // 
            // lblAddData
            // 
            this.lblAddData.AutoSize = true;
            this.lblAddData.BackColor = System.Drawing.Color.Red;
            this.lblAddData.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.lblAddData.Location = new System.Drawing.Point(415, 64);
            this.lblAddData.Name = "lblAddData";
            this.lblAddData.Size = new System.Drawing.Size(78, 21);
            this.lblAddData.TabIndex = 14;
            this.lblAddData.Text = "Add Data";
            // 
            // lblCarManagment
            // 
            this.lblCarManagment.AutoSize = true;
            this.lblCarManagment.BackColor = System.Drawing.Color.Red;
            this.lblCarManagment.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblCarManagment.Location = new System.Drawing.Point(381, 30);
            this.lblCarManagment.Name = "lblCarManagment";
            this.lblCarManagment.Size = new System.Drawing.Size(155, 25);
            this.lblCarManagment.TabIndex = 28;
            this.lblCarManagment.Text = "Car Managment";
            // 
            // lblCarList
            // 
            this.lblCarList.AutoSize = true;
            this.lblCarList.BackColor = System.Drawing.Color.Red;
            this.lblCarList.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.lblCarList.Location = new System.Drawing.Point(385, 328);
            this.lblCarList.Name = "lblCarList";
            this.lblCarList.Size = new System.Drawing.Size(70, 21);
            this.lblCarList.TabIndex = 29;
            this.lblCarList.Text = "Cars List";
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.Red;
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnSearch.Location = new System.Drawing.Point(266, 281);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(78, 30);
            this.btnSearch.TabIndex = 31;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.Red;
            this.btnUpdate.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnUpdate.Location = new System.Drawing.Point(349, 281);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(78, 30);
            this.btnUpdate.TabIndex = 32;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Red;
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnDelete.Location = new System.Drawing.Point(446, 281);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(78, 30);
            this.btnDelete.TabIndex = 33;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Red;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnCancel.Location = new System.Drawing.Point(544, 281);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(78, 30);
            this.btnCancel.TabIndex = 34;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.Red;
            this.btnReset.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnReset.Location = new System.Drawing.Point(627, 281);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(78, 30);
            this.btnReset.TabIndex = 35;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtRegNo
            // 
            this.txtRegNo.Location = new System.Drawing.Point(205, 186);
            this.txtRegNo.Name = "txtRegNo";
            this.txtRegNo.Size = new System.Drawing.Size(86, 20);
            this.txtRegNo.TabIndex = 37;
            // 
            // lblRegNo
            // 
            this.lblRegNo.AutoSize = true;
            this.lblRegNo.BackColor = System.Drawing.Color.Red;
            this.lblRegNo.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblRegNo.Location = new System.Drawing.Point(67, 186);
            this.lblRegNo.Name = "lblRegNo";
            this.lblRegNo.Size = new System.Drawing.Size(119, 21);
            this.lblRegNo.TabIndex = 36;
            this.lblRegNo.Text = "Registration No";
            // 
            // txtModel
            // 
            this.txtModel.Location = new System.Drawing.Point(404, 111);
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(120, 20);
            this.txtModel.TabIndex = 38;
            this.txtModel.TextChanged += new System.EventHandler(this.txtModel_TextChanged);
            // 
            // driverBindingSource
            // 
            this.driverBindingSource.DataMember = "driver";
            this.driverBindingSource.DataSource = this.car_rental_system_dbDataSet;
            // 
            // car_rental_system_dbDataSet
            // 
            this.car_rental_system_dbDataSet.DataSetName = "car_rental_system_dbDataSet";
            this.car_rental_system_dbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // driverTableAdapter
            // 
            this.driverTableAdapter.ClearBeforeFill = true;
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.driverBindingSource1;
            this.comboBox1.DisplayMember = "first_name";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(682, 113);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(86, 21);
            this.comboBox1.TabIndex = 42;
            this.comboBox1.ValueMember = "first_name";
            // 
            // driverBindingSource1
            // 
            this.driverBindingSource1.DataMember = "driver";
            this.driverBindingSource1.DataSource = this.car_rental_system_dbDataSet2;
            // 
            // car_rental_system_dbDataSet2
            // 
            this.car_rental_system_dbDataSet2.DataSetName = "car_rental_system_dbDataSet2";
            this.car_rental_system_dbDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // driverTableAdapter1
            // 
            this.driverTableAdapter1.ClearBeforeFill = true;
            // 
            // fillByToolStrip
            // 
            this.fillByToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fillByToolStripButton});
            this.fillByToolStrip.Location = new System.Drawing.Point(0, 0);
            this.fillByToolStrip.Name = "fillByToolStrip";
            this.fillByToolStrip.Size = new System.Drawing.Size(819, 25);
            this.fillByToolStrip.TabIndex = 43;
            this.fillByToolStrip.Text = "fillByToolStrip";
            // 
            // fillByToolStripButton
            // 
            this.fillByToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fillByToolStripButton.Name = "fillByToolStripButton";
            this.fillByToolStripButton.Size = new System.Drawing.Size(39, 22);
            this.fillByToolStripButton.Text = "FillBy";
            this.fillByToolStripButton.Click += new System.EventHandler(this.fillByToolStripButton_Click_1);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.InactiveCaption;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(39, 362);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(748, 107);
            this.dataGridView1.TabIndex = 44;
            // 
            // FrmCar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(819, 481);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.fillByToolStrip);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.txtModel);
            this.Controls.Add(this.txtRegNo);
            this.Controls.Add(this.lblRegNo);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.lblCarList);
            this.Controls.Add(this.lblCarManagment);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.lblDriverId);
            this.Controls.Add(this.txtBrand);
            this.Controls.Add(this.lblBrand);
            this.Controls.Add(this.lblModel);
            this.Controls.Add(this.txtMake);
            this.Controls.Add(this.lblMake);
            this.Controls.Add(this.txtCarId);
            this.Controls.Add(this.lblCarId);
            this.Controls.Add(this.lblAddData);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmCar";
            this.Text = "Car Manager";
            this.Load += new System.EventHandler(this.FrmCar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.driverBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.car_rental_system_dbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.driverBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.car_rental_system_dbDataSet2)).EndInit();
            this.fillByToolStrip.ResumeLayout(false);
            this.fillByToolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblDriverId;
        private System.Windows.Forms.TextBox txtBrand;
        private System.Windows.Forms.Label lblBrand;
        private System.Windows.Forms.Label lblModel;
        private System.Windows.Forms.TextBox txtMake;
        private System.Windows.Forms.Label lblMake;
        private System.Windows.Forms.TextBox txtCarId;
        private System.Windows.Forms.Label lblCarId;
        private System.Windows.Forms.Label lblAddData;
        private System.Windows.Forms.Label lblCarManagment;
        private System.Windows.Forms.Label lblCarList;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.TextBox txtRegNo;
        private System.Windows.Forms.Label lblRegNo;
        private System.Windows.Forms.TextBox txtModel;
        private CarRentalFinal.car_rental_system_dbDataSet car_rental_system_dbDataSet;
        private System.Windows.Forms.BindingSource driverBindingSource;
        private CarRentalFinal.car_rental_system_dbDataSetTableAdapters.driverTableAdapter driverTableAdapter;
        private System.Windows.Forms.ComboBox comboBox1;
        private CarRentalFinal.car_rental_system_dbDataSet2 car_rental_system_dbDataSet2;
        private System.Windows.Forms.BindingSource driverBindingSource1;
        private CarRentalFinal.car_rental_system_dbDataSet2TableAdapters.driverTableAdapter driverTableAdapter1;
        private System.Windows.Forms.ToolStrip fillByToolStrip;
        private System.Windows.Forms.ToolStripButton fillByToolStripButton;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}