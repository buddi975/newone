namespace WindowsFormsApp5_Final
{
    partial class ManageMember
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageMember));
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.rbtnMale = new System.Windows.Forms.RadioButton();
            this.rbnFemale = new System.Windows.Forms.RadioButton();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblMemberID = new System.Windows.Forms.Label();
            this.lblBirthDay = new System.Windows.Forms.Label();
            this.lblContact = new System.Windows.Forms.Label();
            this.lblGender = new System.Windows.Forms.Label();
            this.lblNICNumber = new System.Windows.Forms.Label();
            this.lblAdress = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtMemberID = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.txtContact = new System.Windows.Forms.TextBox();
            this.txtNICNumber = new System.Windows.Forms.TextBox();
            this.dtbBirthDay = new System.Windows.Forms.DateTimePicker();
            this.rtbAdress = new System.Windows.Forms.RichTextBox();
            this.dgvmanage = new System.Windows.Forms.DataGridView();
            this.tblmemberBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.uaDBDataSet = new WindowsFormsApp5_Final.uaDBDataSet();
            this.tblmemberTableAdapter = new WindowsFormsApp5_Final.uaDBDataSetTableAdapters.tblmemberTableAdapter();
            this.tblmemberBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.firstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.memberIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.birthDayDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contactDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nICNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSave = new System.Windows.Forms.Button();
            this.tblmemberBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvmanage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblmemberBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uaDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblmemberBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblmemberBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button1);
            this.panel1.Location = new System.Drawing.Point(8, 7);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1077, 33);
            this.panel1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(4, 7);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(308, 240);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(556, 240);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 3;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // rbtnMale
            // 
            this.rbtnMale.AutoSize = true;
            this.rbtnMale.Location = new System.Drawing.Point(119, 186);
            this.rbtnMale.Name = "rbtnMale";
            this.rbtnMale.Size = new System.Drawing.Size(58, 20);
            this.rbtnMale.TabIndex = 4;
            this.rbtnMale.TabStop = true;
            this.rbtnMale.Text = "Male";
            this.rbtnMale.UseVisualStyleBackColor = true;
            // 
            // rbnFemale
            // 
            this.rbnFemale.AutoSize = true;
            this.rbnFemale.Location = new System.Drawing.Point(183, 186);
            this.rbnFemale.Name = "rbnFemale";
            this.rbnFemale.Size = new System.Drawing.Size(74, 20);
            this.rbnFemale.TabIndex = 5;
            this.rbnFemale.TabStop = true;
            this.rbnFemale.Text = "Female";
            this.rbnFemale.UseVisualStyleBackColor = true;
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(43, 72);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(72, 16);
            this.lblFirstName.TabIndex = 6;
            this.lblFirstName.Text = "First Name";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(305, 72);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(72, 16);
            this.lblLastName.TabIndex = 7;
            this.lblLastName.Text = "Last Name";
            // 
            // lblMemberID
            // 
            this.lblMemberID.AutoSize = true;
            this.lblMemberID.Location = new System.Drawing.Point(43, 112);
            this.lblMemberID.Name = "lblMemberID";
            this.lblMemberID.Size = new System.Drawing.Size(73, 16);
            this.lblMemberID.TabIndex = 8;
            this.lblMemberID.Text = "Member ID";
            // 
            // lblBirthDay
            // 
            this.lblBirthDay.AutoSize = true;
            this.lblBirthDay.Location = new System.Drawing.Point(305, 112);
            this.lblBirthDay.Name = "lblBirthDay";
            this.lblBirthDay.Size = new System.Drawing.Size(61, 16);
            this.lblBirthDay.TabIndex = 9;
            this.lblBirthDay.Text = "Birth Day";
            // 
            // lblContact
            // 
            this.lblContact.AutoSize = true;
            this.lblContact.Location = new System.Drawing.Point(43, 144);
            this.lblContact.Name = "lblContact";
            this.lblContact.Size = new System.Drawing.Size(52, 16);
            this.lblContact.TabIndex = 10;
            this.lblContact.Text = "Contact";
            this.lblContact.Click += new System.EventHandler(this.label5_Click);
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Location = new System.Drawing.Point(43, 190);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(52, 16);
            this.lblGender.TabIndex = 11;
            this.lblGender.Text = "Gender";
            // 
            // lblNICNumber
            // 
            this.lblNICNumber.AutoSize = true;
            this.lblNICNumber.Location = new System.Drawing.Point(43, 222);
            this.lblNICNumber.Name = "lblNICNumber";
            this.lblNICNumber.Size = new System.Drawing.Size(80, 16);
            this.lblNICNumber.TabIndex = 12;
            this.lblNICNumber.Text = "NIC Number";
            // 
            // lblAdress
            // 
            this.lblAdress.AutoSize = true;
            this.lblAdress.Location = new System.Drawing.Point(305, 150);
            this.lblAdress.Name = "lblAdress";
            this.lblAdress.Size = new System.Drawing.Size(50, 16);
            this.lblAdress.TabIndex = 13;
            this.lblAdress.Text = "Adress";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(141, 69);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(100, 22);
            this.txtFirstName.TabIndex = 15;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(425, 66);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(100, 22);
            this.txtLastName.TabIndex = 16;
            // 
            // txtMemberID
            // 
            this.txtMemberID.Location = new System.Drawing.Point(141, 106);
            this.txtMemberID.Name = "txtMemberID";
            this.txtMemberID.Size = new System.Drawing.Size(100, 22);
            this.txtMemberID.TabIndex = 17;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(630, 348);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(8, 22);
            this.textBox4.TabIndex = 18;
            // 
            // txtContact
            // 
            this.txtContact.Location = new System.Drawing.Point(141, 144);
            this.txtContact.Name = "txtContact";
            this.txtContact.Size = new System.Drawing.Size(100, 22);
            this.txtContact.TabIndex = 19;
            // 
            // txtNICNumber
            // 
            this.txtNICNumber.Location = new System.Drawing.Point(141, 216);
            this.txtNICNumber.Name = "txtNICNumber";
            this.txtNICNumber.Size = new System.Drawing.Size(100, 22);
            this.txtNICNumber.TabIndex = 20;
            // 
            // dtbBirthDay
            // 
            this.dtbBirthDay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtbBirthDay.Location = new System.Drawing.Point(429, 112);
            this.dtbBirthDay.Name = "dtbBirthDay";
            this.dtbBirthDay.Size = new System.Drawing.Size(110, 22);
            this.dtbBirthDay.TabIndex = 21;
            // 
            // rtbAdress
            // 
            this.rtbAdress.Location = new System.Drawing.Point(425, 141);
            this.rtbAdress.Name = "rtbAdress";
            this.rtbAdress.Size = new System.Drawing.Size(126, 83);
            this.rtbAdress.TabIndex = 24;
            this.rtbAdress.Text = "";
            // 
            // dgvmanage
            // 
            this.dgvmanage.AutoGenerateColumns = false;
            this.dgvmanage.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvmanage.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.firstNameDataGridViewTextBoxColumn,
            this.lastNameDataGridViewTextBoxColumn,
            this.memberIDDataGridViewTextBoxColumn,
            this.birthDayDataGridViewTextBoxColumn,
            this.contactDataGridViewTextBoxColumn,
            this.genderDataGridViewTextBoxColumn,
            this.nICNumberDataGridViewTextBoxColumn,
            this.adressDataGridViewTextBoxColumn});
            this.dgvmanage.DataSource = this.tblmemberBindingSource2;
            this.dgvmanage.Location = new System.Drawing.Point(-5, 269);
            this.dgvmanage.Name = "dgvmanage";
            this.dgvmanage.RowHeadersWidth = 51;
            this.dgvmanage.RowTemplate.Height = 24;
            this.dgvmanage.Size = new System.Drawing.Size(1039, 142);
            this.dgvmanage.TabIndex = 25;
            this.dgvmanage.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // tblmemberBindingSource
            // 
            this.tblmemberBindingSource.DataMember = "tblmember";
            this.tblmemberBindingSource.DataSource = this.uaDBDataSet;
            // 
            // uaDBDataSet
            // 
            this.uaDBDataSet.DataSetName = "uaDBDataSet";
            this.uaDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblmemberTableAdapter
            // 
            this.tblmemberTableAdapter.ClearBeforeFill = true;
            // 
            // tblmemberBindingSource1
            // 
            this.tblmemberBindingSource1.DataMember = "tblmember";
            this.tblmemberBindingSource1.DataSource = this.uaDBDataSet;
            // 
            // firstNameDataGridViewTextBoxColumn
            // 
            this.firstNameDataGridViewTextBoxColumn.DataPropertyName = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.HeaderText = "First Name";
            this.firstNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.firstNameDataGridViewTextBoxColumn.Name = "firstNameDataGridViewTextBoxColumn";
            this.firstNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // lastNameDataGridViewTextBoxColumn
            // 
            this.lastNameDataGridViewTextBoxColumn.DataPropertyName = "LastName";
            this.lastNameDataGridViewTextBoxColumn.HeaderText = "Last Name";
            this.lastNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.lastNameDataGridViewTextBoxColumn.Name = "lastNameDataGridViewTextBoxColumn";
            this.lastNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // memberIDDataGridViewTextBoxColumn
            // 
            this.memberIDDataGridViewTextBoxColumn.DataPropertyName = "MemberID";
            this.memberIDDataGridViewTextBoxColumn.HeaderText = "Member ID";
            this.memberIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.memberIDDataGridViewTextBoxColumn.Name = "memberIDDataGridViewTextBoxColumn";
            this.memberIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // birthDayDataGridViewTextBoxColumn
            // 
            this.birthDayDataGridViewTextBoxColumn.DataPropertyName = "BirthDay";
            this.birthDayDataGridViewTextBoxColumn.HeaderText = "Birth Day";
            this.birthDayDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.birthDayDataGridViewTextBoxColumn.Name = "birthDayDataGridViewTextBoxColumn";
            this.birthDayDataGridViewTextBoxColumn.Width = 125;
            // 
            // contactDataGridViewTextBoxColumn
            // 
            this.contactDataGridViewTextBoxColumn.DataPropertyName = "Contact";
            this.contactDataGridViewTextBoxColumn.HeaderText = "Contact";
            this.contactDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.contactDataGridViewTextBoxColumn.Name = "contactDataGridViewTextBoxColumn";
            this.contactDataGridViewTextBoxColumn.Width = 125;
            // 
            // genderDataGridViewTextBoxColumn
            // 
            this.genderDataGridViewTextBoxColumn.DataPropertyName = "Gender";
            this.genderDataGridViewTextBoxColumn.HeaderText = "Gender";
            this.genderDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.genderDataGridViewTextBoxColumn.Name = "genderDataGridViewTextBoxColumn";
            this.genderDataGridViewTextBoxColumn.Width = 125;
            // 
            // nICNumberDataGridViewTextBoxColumn
            // 
            this.nICNumberDataGridViewTextBoxColumn.DataPropertyName = "NICNumber";
            this.nICNumberDataGridViewTextBoxColumn.HeaderText = "NIC Number";
            this.nICNumberDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nICNumberDataGridViewTextBoxColumn.Name = "nICNumberDataGridViewTextBoxColumn";
            this.nICNumberDataGridViewTextBoxColumn.Width = 125;
            // 
            // adressDataGridViewTextBoxColumn
            // 
            this.adressDataGridViewTextBoxColumn.DataPropertyName = "Adress";
            this.adressDataGridViewTextBoxColumn.HeaderText = "Adress";
            this.adressDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.adressDataGridViewTextBoxColumn.Name = "adressDataGridViewTextBoxColumn";
            this.adressDataGridViewTextBoxColumn.Width = 125;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(400, 234);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(76, 28);
            this.btnSave.TabIndex = 26;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // tblmemberBindingSource2
            // 
            this.tblmemberBindingSource2.DataMember = "tblmember";
            this.tblmemberBindingSource2.DataSource = this.uaDBDataSet;
            // 
            // ManageMember
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1090, 425);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.dgvmanage);
            this.Controls.Add(this.rtbAdress);
            this.Controls.Add(this.dtbBirthDay);
            this.Controls.Add(this.txtNICNumber);
            this.Controls.Add(this.txtContact);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.txtMemberID);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.lblAdress);
            this.Controls.Add(this.lblNICNumber);
            this.Controls.Add(this.lblGender);
            this.Controls.Add(this.lblContact);
            this.Controls.Add(this.lblBirthDay);
            this.Controls.Add(this.lblMemberID);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.rbnFemale);
            this.Controls.Add(this.rbtnMale);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.panel1);
            this.Name = "ManageMember";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ManageMember";
            this.Load += new System.EventHandler(this.ManageMember_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvmanage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblmemberBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uaDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblmemberBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblmemberBindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.RadioButton rbtnMale;
        private System.Windows.Forms.RadioButton rbnFemale;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblMemberID;
        private System.Windows.Forms.Label lblBirthDay;
        private System.Windows.Forms.Label lblContact;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.Label lblNICNumber;
        private System.Windows.Forms.Label lblAdress;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtMemberID;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox txtContact;
        private System.Windows.Forms.TextBox txtNICNumber;
        private System.Windows.Forms.DateTimePicker dtbBirthDay;
        private System.Windows.Forms.RichTextBox rtbAdress;
        private System.Windows.Forms.DataGridView dgvmanage;
        private uaDBDataSet uaDBDataSet;
        private System.Windows.Forms.BindingSource tblmemberBindingSource;
        private uaDBDataSetTableAdapters.tblmemberTableAdapter tblmemberTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn memberIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn birthDayDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contactDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn genderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nICNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adressDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource tblmemberBindingSource1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.BindingSource tblmemberBindingSource2;
    }
}