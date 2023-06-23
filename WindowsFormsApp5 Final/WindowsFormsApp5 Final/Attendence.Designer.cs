namespace WindowsFormsApp5_Final
{
    partial class Attendence
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Attendence));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnBack = new System.Windows.Forms.Button();
            this.lblMemberID = new System.Windows.Forms.Label();
            this.lblDateAndTime = new System.Windows.Forms.Label();
            this.lblInstrucor = new System.Windows.Forms.Label();
            this.txtMemberID = new System.Windows.Forms.TextBox();
            this.txtInstructor = new System.Windows.Forms.TextBox();
            this.dtpDateAndTime = new System.Windows.Forms.DateTimePicker();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.memberIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateAndTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblAttendanceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.uaDBDataSet1 = new WindowsFormsApp5_Final.uaDBDataSet1();
            this.btnMarkattendence = new System.Windows.Forms.Button();
            this.uaDBDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblAttendanceTableAdapter = new WindowsFormsApp5_Final.uaDBDataSet1TableAdapters.tblAttendanceTableAdapter();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblAttendanceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uaDBDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uaDBDataSet1BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnBack);
            this.panel1.Location = new System.Drawing.Point(8, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(788, 36);
            this.panel1.TabIndex = 0;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(13, 8);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 0;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblMemberID
            // 
            this.lblMemberID.AutoSize = true;
            this.lblMemberID.Location = new System.Drawing.Point(37, 66);
            this.lblMemberID.Name = "lblMemberID";
            this.lblMemberID.Size = new System.Drawing.Size(73, 16);
            this.lblMemberID.TabIndex = 1;
            this.lblMemberID.Text = "Member ID";
            this.lblMemberID.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblDateAndTime
            // 
            this.lblDateAndTime.AutoSize = true;
            this.lblDateAndTime.Location = new System.Drawing.Point(37, 119);
            this.lblDateAndTime.Name = "lblDateAndTime";
            this.lblDateAndTime.Size = new System.Drawing.Size(97, 16);
            this.lblDateAndTime.TabIndex = 2;
            this.lblDateAndTime.Text = "Date And Time";
            // 
            // lblInstrucor
            // 
            this.lblInstrucor.AutoSize = true;
            this.lblInstrucor.Location = new System.Drawing.Point(36, 179);
            this.lblInstrucor.Name = "lblInstrucor";
            this.lblInstrucor.Size = new System.Drawing.Size(60, 16);
            this.lblInstrucor.TabIndex = 3;
            this.lblInstrucor.Text = "Instructor";
            // 
            // txtMemberID
            // 
            this.txtMemberID.Location = new System.Drawing.Point(40, 85);
            this.txtMemberID.Name = "txtMemberID";
            this.txtMemberID.Size = new System.Drawing.Size(167, 22);
            this.txtMemberID.TabIndex = 4;
            // 
            // txtInstructor
            // 
            this.txtInstructor.Location = new System.Drawing.Point(40, 199);
            this.txtInstructor.Name = "txtInstructor";
            this.txtInstructor.Size = new System.Drawing.Size(109, 22);
            this.txtInstructor.TabIndex = 5;
            // 
            // dtpDateAndTime
            // 
            this.dtpDateAndTime.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDateAndTime.Location = new System.Drawing.Point(40, 138);
            this.dtpDateAndTime.Name = "dtpDateAndTime";
            this.dtpDateAndTime.Size = new System.Drawing.Size(123, 22);
            this.dtpDateAndTime.TabIndex = 6;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.memberIDDataGridViewTextBoxColumn,
            this.dateAndTimeDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tblAttendanceBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(40, 289);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(432, 233);
            this.dataGridView1.TabIndex = 7;
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
            // memberIDDataGridViewTextBoxColumn
            // 
            this.memberIDDataGridViewTextBoxColumn.DataPropertyName = "MemberID";
            this.memberIDDataGridViewTextBoxColumn.HeaderText = "MemberID";
            this.memberIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.memberIDDataGridViewTextBoxColumn.Name = "memberIDDataGridViewTextBoxColumn";
            this.memberIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // dateAndTimeDataGridViewTextBoxColumn
            // 
            this.dateAndTimeDataGridViewTextBoxColumn.DataPropertyName = "Date And Time";
            this.dateAndTimeDataGridViewTextBoxColumn.HeaderText = "Date And Time";
            this.dateAndTimeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dateAndTimeDataGridViewTextBoxColumn.Name = "dateAndTimeDataGridViewTextBoxColumn";
            this.dateAndTimeDataGridViewTextBoxColumn.Width = 125;
            // 
            // tblAttendanceBindingSource
            // 
            this.tblAttendanceBindingSource.DataMember = "tblAttendance";
            this.tblAttendanceBindingSource.DataSource = this.uaDBDataSet1;
            // 
            // uaDBDataSet1
            // 
            this.uaDBDataSet1.DataSetName = "uaDBDataSet1";
            this.uaDBDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnMarkattendence
            // 
            this.btnMarkattendence.Location = new System.Drawing.Point(39, 238);
            this.btnMarkattendence.Name = "btnMarkattendence";
            this.btnMarkattendence.Size = new System.Drawing.Size(167, 23);
            this.btnMarkattendence.TabIndex = 8;
            this.btnMarkattendence.Text = "Mark Attendence";
            this.btnMarkattendence.UseVisualStyleBackColor = true;
            this.btnMarkattendence.Click += new System.EventHandler(this.btnMarkattendence_Click);
            // 
            // uaDBDataSet1BindingSource
            // 
            this.uaDBDataSet1BindingSource.DataSource = this.uaDBDataSet1;
            this.uaDBDataSet1BindingSource.Position = 0;
            // 
            // tblAttendanceTableAdapter
            // 
            this.tblAttendanceTableAdapter.ClearBeforeFill = true;
            // 
            // Attendence
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(655, 534);
            this.Controls.Add(this.btnMarkattendence);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.dtpDateAndTime);
            this.Controls.Add(this.txtInstructor);
            this.Controls.Add(this.txtMemberID);
            this.Controls.Add(this.lblInstrucor);
            this.Controls.Add(this.lblDateAndTime);
            this.Controls.Add(this.lblMemberID);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.Name = "Attendence";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Attendence";
            this.Load += new System.EventHandler(this.Attendence_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblAttendanceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uaDBDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uaDBDataSet1BindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lblMemberID;
        private System.Windows.Forms.Label lblDateAndTime;
        private System.Windows.Forms.Label lblInstrucor;
        private System.Windows.Forms.TextBox txtMemberID;
        private System.Windows.Forms.TextBox txtInstructor;
        private System.Windows.Forms.DateTimePicker dtpDateAndTime;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnMarkattendence;
        private System.Windows.Forms.BindingSource uaDBDataSet1BindingSource;
        private uaDBDataSet1 uaDBDataSet1;
        private System.Windows.Forms.BindingSource tblAttendanceBindingSource;
        private uaDBDataSet1TableAdapters.tblAttendanceTableAdapter tblAttendanceTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn memberIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateAndTimeDataGridViewTextBoxColumn;
    }
}