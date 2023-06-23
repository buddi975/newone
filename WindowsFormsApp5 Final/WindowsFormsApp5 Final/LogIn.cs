using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApp5_Final
{
    public partial class LogIn : Form
    {
        SqlConnection con = new SqlConnection(Properties.Settings.Default.uaDBConnectionString);
        SqlDataAdapter da;
        SqlCommand cmd;
        public LogIn()
        {
            InitializeComponent();
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            con.Open();
            cmd = new SqlCommand("SELECT * FROM tbllog WHERE Username='" + txtUserName.Text + "' and Password='" + txtPassword.Text + "'", con);
            da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            int i = ds.Tables[0].Rows.Count;
            if (i == 1)
            {
                Home nm = new Home();
                nm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Please check your user name or password", "message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            con.Close();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtUserName_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblUserName_Click(object sender, EventArgs e)
        {

        }

        private void LogIn_Load(object sender, EventArgs e)
        {

        }
    }
}
