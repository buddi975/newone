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
    public partial class LogOut : Form
    {
        public LogOut()
        {
            InitializeComponent();
        }

        private void btnYes_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnNo_Click(object sender, EventArgs e)
        {
            LogIn nm = new LogIn();
            nm.Show();
            this.Hide();
        }

        private void lblAreyou_Click(object sender, EventArgs e)
        {

        }
    }
}
