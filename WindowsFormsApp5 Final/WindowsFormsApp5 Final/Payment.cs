using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp5_Final.AppDataPaymentTableAdapters;
using WindowsFormsApp5_Final.AppDataTableAdapters;

namespace WindowsFormsApp5_Final
{
    public partial class Payment : Form
    {
        public Payment()
        {
            InitializeComponent();
        }

        private void Payment_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'appDataPayment.tblpayment1' table. You can move, or remove it, as needed.
            this.tblpayment1TableAdapter.Fill(this.appDataPayment.tblpayment1);
            Edit(false);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            Edit(true);
            txtName.Focus();
            txtMemberID.Focus();
            txtAmount.Focus();
        }

        private void Edit(bool v)
        {
            throw new NotImplementedException();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                Edit(false);
                tblpayment1BindingSource.EndEdit();
                tblpayment1TableAdapter.Update(appDataPayment.tblpayment1);
                dgvPayment.Refresh();
                txtName.Focus();
                txtMemberID.Focus();
                txtMemberID.Focus();
                dtpDateAndTimePay.Focus();
                MessageBox.Show("Your data has been succesfully saved.", "message", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                appDataPayment.tblpayment1.RejectChanges();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {


            //if (MessageBox.Show("Are you sure want to delete this record ", "message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) ;
            
            tblpayment1BindingSource.RemoveCurrent();
            Edit(true);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Home nm = new Home();
            nm.Show();
            this.Hide();
        }

        private void dgvPayment_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
