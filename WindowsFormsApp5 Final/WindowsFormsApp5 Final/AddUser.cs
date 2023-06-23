using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp5_Final
{
    public partial class AddUser : Form
    {
        public AddUser()
        {
            InitializeComponent();
        }

        private void AddUser_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'appData.tbllog' table. You can move, or remove it, as needed.
            this.tbllogTableAdapter.Fill(this.appData.tbllog);
            Edit(false);

        }
        private void Edit(bool value)
        {
            txtUserName.Enabled = value;
            txtPassword.Enabled = value;
            cbRole.Enabled = value;
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            try
            {
                Edit(true);
                appData.tbllog.AddtbllogRow(appData.tbllog.NewtbllogRow());
                tbllogBindingSource.MoveLast();
                txtUserName.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                appData.tbllog.RejectChanges();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            Edit(true);
            txtUserName.Focus();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                Edit(false);
                tbllogBindingSource.EndEdit();
                tbllogTableAdapter.Update(appData.tbllog);
                dgv_adminuser.Refresh();
                txtUserName.Focus();
                MessageBox.Show("Your data has been succesfully saved.", "message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                appData.tbllog.RejectChanges();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            //if (MessageBox.Show("Are you sure want to delete this record ", "message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes);
            
            tbllogBindingSource.RemoveCurrent();
            
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Edit(false);
            tbllogBindingSource.ResetBindings(false);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Home nm = new Home();
            nm.Show();
            this.Hide();
        }

        private void dgv_adminuser_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
