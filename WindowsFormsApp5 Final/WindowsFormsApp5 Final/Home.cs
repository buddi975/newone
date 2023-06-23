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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void manageMemberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManageMember nm = new ManageMember();
            nm.Show();
            this.Hide();

        }

        private void addUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddUser nm = new AddUser();
            nm.Show();
            this.Hide();
        }

        private void paymentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Payment nm = new Payment();
            nm.Show();
            this.Hide();
        }

        private void attendenceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Attendence nm = new Attendence();
            nm.Show();
            this.Hide();
        }

        private void profilrToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Profile nm = new Profile();
            nm.Show();
            this.Hide();
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LogOut nm = new LogOut();
            nm.Show();
            this.Hide();
        }

        private void Home_Load(object sender, EventArgs e)
        {

        }
    }
}
