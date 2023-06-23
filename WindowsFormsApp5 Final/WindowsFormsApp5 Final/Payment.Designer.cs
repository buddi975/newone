namespace WindowsFormsApp5_Final
{
    partial class Payment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Payment));
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.lblName = new System.Windows.Forms.Label();
            this.lblMemberI = new System.Windows.Forms.Label();
            this.lblAmount = new System.Windows.Forms.Label();
            this.lblDateAndTime = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.txtMemberID = new System.Windows.Forms.TextBox();
            this.dtpDateAndTimePay = new System.Windows.Forms.DateTimePicker();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.appDataPayment = new WindowsFormsApp5_Final.AppDataPayment();
            this.appDataPaymentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblpayment1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblpayment1TableAdapter = new WindowsFormsApp5_Final.AppDataPaymentTableAdapters.tblpayment1TableAdapter();
            this.dgvPayment = new System.Windows.Forms.DataGridView();
            this.tblpayment1BindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.memberIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateAndTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.appDataPayment)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.appDataPaymentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblpayment1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPayment)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblpayment1BindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button1);
            this.panel1.Location = new System.Drawing.Point(9, 8);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(786, 41);
            this.panel1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(17, 10);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(45, 73);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(44, 16);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Name";
            // 
            // lblMemberI
            // 
            this.lblMemberI.AutoSize = true;
            this.lblMemberI.Location = new System.Drawing.Point(377, 73);
            this.lblMemberI.Name = "lblMemberI";
            this.lblMemberI.Size = new System.Drawing.Size(73, 16);
            this.lblMemberI.TabIndex = 2;
            this.lblMemberI.Text = "Member ID";
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Location = new System.Drawing.Point(45, 111);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(52, 16);
            this.lblAmount.TabIndex = 3;
            this.lblAmount.Text = "Amount";
            // 
            // lblDateAndTime
            // 
            this.lblDateAndTime.AutoSize = true;
            this.lblDateAndTime.Location = new System.Drawing.Point(377, 111);
            this.lblDateAndTime.Name = "lblDateAndTime";
            this.lblDateAndTime.Size = new System.Drawing.Size(97, 16);
            this.lblDateAndTime.TabIndex = 4;
            this.lblDateAndTime.Text = "Date And Time";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(132, 67);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(162, 22);
            this.txtName.TabIndex = 5;
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(129, 105);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(165, 22);
            this.txtAmount.TabIndex = 6;
            // 
            // txtMemberID
            // 
            this.txtMemberID.Location = new System.Drawing.Point(456, 67);
            this.txtMemberID.Name = "txtMemberID";
            this.txtMemberID.Size = new System.Drawing.Size(233, 22);
            this.txtMemberID.TabIndex = 7;
            // 
            // dtpDateAndTimePay
            // 
            this.dtpDateAndTimePay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDateAndTimePay.Location = new System.Drawing.Point(504, 105);
            this.dtpDateAndTimePay.Name = "dtpDateAndTimePay";
            this.dtpDateAndTimePay.Size = new System.Drawing.Size(117, 22);
            this.dtpDateAndTimePay.TabIndex = 8;
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(107, 168);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 9;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSave.BackgroundImage")));
            this.btnSave.Location = new System.Drawing.Point(298, 168);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 10;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(504, 165);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(69, 28);
            this.btnDelete.TabIndex = 11;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // appDataPayment
            // 
            this.appDataPayment.DataSetName = "AppDataPayment";
            this.appDataPayment.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // appDataPaymentBindingSource
            // 
            this.appDataPaymentBindingSource.DataSource = this.appDataPayment;
            this.appDataPaymentBindingSource.Position = 0;
            // 
            // tblpayment1BindingSource
            // 
            this.tblpayment1BindingSource.DataMember = "tblpayment1";
            this.tblpayment1BindingSource.DataSource = this.appDataPayment;
            // 
            // tblpayment1TableAdapter
            // 
            this.tblpayment1TableAdapter.ClearBeforeFill = true;
            // 
            // dgvPayment
            // 
            this.dgvPayment.AutoGenerateColumns = false;
            this.dgvPayment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPayment.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.memberIDDataGridViewTextBoxColumn,
            this.amountDataGridViewTextBoxColumn,
            this.dateAndTimeDataGridViewTextBoxColumn});
            this.dgvPayment.DataSource = this.tblpayment1BindingSource1;
            this.dgvPayment.Location = new System.Drawing.Point(31, 229);
            this.dgvPayment.Name = "dgvPayment";
            this.dgvPayment.RowHeadersWidth = 51;
            this.dgvPayment.RowTemplate.Height = 24;
            this.dgvPayment.Size = new System.Drawing.Size(738, 190);
            this.dgvPayment.TabIndex = 12;
            this.dgvPayment.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPayment_CellContentClick);
            // 
            // tblpayment1BindingSource1
            // 
            this.tblpayment1BindingSource1.DataMember = "tblpayment1";
            this.tblpayment1BindingSource1.DataSource = this.appDataPaymentBindingSource;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Width = 125;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.Width = 125;
            // 
            // memberIDDataGridViewTextBoxColumn
            // 
            this.memberIDDataGridViewTextBoxColumn.DataPropertyName = "MemberID";
            this.memberIDDataGridViewTextBoxColumn.HeaderText = "MemberID";
            this.memberIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.memberIDDataGridViewTextBoxColumn.Name = "memberIDDataGridViewTextBoxColumn";
            this.memberIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // amountDataGridViewTextBoxColumn
            // 
            this.amountDataGridViewTextBoxColumn.DataPropertyName = "Amount";
            this.amountDataGridViewTextBoxColumn.HeaderText = "Amount";
            this.amountDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.amountDataGridViewTextBoxColumn.Name = "amountDataGridViewTextBoxColumn";
            this.amountDataGridViewTextBoxColumn.Width = 125;
            // 
            // dateAndTimeDataGridViewTextBoxColumn
            // 
            this.dateAndTimeDataGridViewTextBoxColumn.DataPropertyName = "DateAndTime";
            this.dateAndTimeDataGridViewTextBoxColumn.HeaderText = "DateAndTime";
            this.dateAndTimeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dateAndTimeDataGridViewTextBoxColumn.Name = "dateAndTimeDataGridViewTextBoxColumn";
            this.dateAndTimeDataGridViewTextBoxColumn.Width = 125;
            // 
            // Payment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvPayment);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.dtpDateAndTimePay);
            this.Controls.Add(this.txtMemberID);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblDateAndTime);
            this.Controls.Add(this.lblAmount);
            this.Controls.Add(this.lblMemberI);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.Name = "Payment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Payment";
            this.Load += new System.EventHandler(this.Payment_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.appDataPayment)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.appDataPaymentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblpayment1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPayment)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblpayment1BindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblMemberI;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.Label lblDateAndTime;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.TextBox txtMemberID;
        private System.Windows.Forms.DateTimePicker dtpDateAndTimePay;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.BindingSource appDataPaymentBindingSource;
        private AppDataPayment appDataPayment;
        private System.Windows.Forms.BindingSource tblpayment1BindingSource;
        private AppDataPaymentTableAdapters.tblpayment1TableAdapter tblpayment1TableAdapter;
        private System.Windows.Forms.DataGridView dgvPayment;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn memberIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateAndTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource tblpayment1BindingSource1;
    }
}