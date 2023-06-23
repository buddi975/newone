using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WindowsFormsApp5_Final
{
    public partial class ManageMember : Form
    {

        public ManageMember()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Edit(true);
            txtFirstName.Focus();
            txtLastName.Focus();
            txtMemberID.Focus();
            dtbBirthDay.Focus();
            txtContact.Focus();
            rbtnMale.Focus();
            rbnFemale.Focus();
            txtNICNumber.Focus();
            rtbAdress.Focus();

        }

        private void ManageMember_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'uaDBDataSet.tblmember' table. You can move, or remove it, as needed.
            this.tblmemberTableAdapter.Fill(this.uaDBDataSet.tblmember);
            Edit(false);
        }
        private void Edit(bool value)
        {
            txtFirstName.Enabled = value;
            txtLastName.Enabled = value;
            txtMemberID.Enabled = value;
            dtbBirthDay.Enabled = value;
            txtContact.Enabled = value;
            rbtnMale.Enabled = value;
            rbnFemale.Enabled = value;
            txtNICNumber.Enabled = value;
            rtbAdress.Enabled = value;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Home nm = new Home();
            nm.Show();
            this.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                Edit(true);
                uaDBDataSet.tblmember.AddtblmemberRow(uaDBDataSet.tblmember.NewtblmemberRow());
                tblmemberBindingSource.MoveLast();
                dgvmanage.Refresh();
                txtFirstName.Focus();
                txtLastName.Focus();
                txtMemberID.Focus();
                dtbBirthDay.Focus();
                txtContact.Focus();
                rbtnMale.Focus();
                rbnFemale.Focus();
                txtNICNumber.Focus();
                rtbAdress.Focus();
                MessageBox.Show("Your data has been succesfully saved.", "message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                uaDBDataSet.tblmember.RejectChanges();
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            tblmemberBindingSource.RemoveCurrent();
        }
    }
}
