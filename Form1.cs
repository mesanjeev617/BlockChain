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
using System.Configuration;

namespace DHANA
{
    public partial class frmWelcome : Form
    {
       
        public frmWelcome()
        {
            InitializeComponent();
            //connectionString = ConfigurationManager.ConnectionStrings.
        }

        private void frmWelcome_Load(object sender, EventArgs e)
        {

        }

        private void btnSignIN_Click(object sender, EventArgs e)
        {
            if (tbUserName.Text == String.Empty || tbPassword.Text == String.Empty)
            {
                MessageBox.Show("Please, Enter UserName and Password");
            }
            else
            {
                if (tbUserName.Text == "Me_Sansil" && tbPassword.Text == "Password")
                {
                    frmCurrentStatus frm = new frmCurrentStatus();
                    frm.ShowDialog();

                }
                else
                {
                    MessageBox.Show("Incorrect Username or Password");
                }
            }
        }
    }
}
