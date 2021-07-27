using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace DHANA
{
    public partial class frmCurrentStatus : Form
    {
        string connectionString;
        public SqlConnection conn;
        public frmCurrentStatus()
        {
            InitializeComponent();
            connectionString = ConfigurationManager.ConnectionStrings["DHANA.Properties.Settings.BLOCKCHAINConnectionString2"].ConnectionString;
        }

        private void llDetails_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmBlockInfo frm = new frmBlockInfo();
            frm.ShowDialog();
        }

        private void btnMine_Click(object sender, EventArgs e)
        {
            frmTransaction frm = new frmTransaction();
            frm.ShowDialog();
        }

        private void frmCurrentStatus_Load(object sender, EventArgs e)
        {

            using (conn = new SqlConnection(connectionString))
            using (SqlDataAdapter adapter = new SqlDataAdapter("Select * from BLOCK_TABLE", conn))
            {
                DataTable BlockTable = new DataTable();
                adapter.Fill(BlockTable);
                DataRow dr = BlockTable.Rows[(BlockTable.Rows.Count) - 1];
                lbCurrentHash.Text = dr["CurrentHash"].ToString();
                lbTotalCirculating.Text = BlockTable.Rows.Count.ToString();
                int usedBlock = BlockTable.Rows.Count;
                lbRemaining.Text = (10 - usedBlock).ToString();
            }

            using (conn = new SqlConnection(connectionString))
            using (SqlDataAdapter adapter1 = new SqlDataAdapter("Select * from Transaction_Table", conn))
            {
                DataTable transTable = new DataTable();
                adapter1.Fill(transTable);
                DataRow de = transTable.Rows[(transTable.Rows.Count) - 1];
                lbDateTime.Text = de["TimeStamp"].ToString();
            }
        }

    }
}
