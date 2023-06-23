using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp5_Final.AppDataTableAdapters;
using WindowsFormsApp5_Final.uaDBDataSet1TableAdapters;


namespace WindowsFormsApp5_Final
{
    public partial class Attendence : Form
    {
        public Attendence()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Attendence_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'uaDBDataSet1.tblAttendance' table. You can move, or remove it, as needed.
            this.tblAttendanceTableAdapter.Fill(this.uaDBDataSet1.tblAttendance);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Home nm = new Home();
            nm.Show();
            this.Hide();
        }

        private void btnMarkattendence_Click(object sender, EventArgs e)
        {

            try
            {
                tblAttendanceBindingSource.EndEdit();
                tblAttendanceTableAdapter.Update(uaDBDataSet1.tblAttendance);
                dataGridView1.Refresh();
                txtMemberID.Focus();
                MessageBox.Show("Your data has been succesfully saved.", "message", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                uaDBDataSet1.tblAttendance.RejectChanges();
            }
        }
    }
}
