using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;



namespace DHANA
{
    public partial class frmMined : Form
    {
        public SqlConnection conn;
        string connectionString;
        public frmMined()
        {
            InitializeComponent();
            connectionString = ConfigurationManager.ConnectionStrings["DHANA.Properties.Settings.BLOCKCHAINConnectionString2"].ConnectionString;
        }

        private void frmMined_Load(object sender, EventArgs e)
        {
            using (conn = new SqlConnection(connectionString))
            using (SqlDataAdapter adapter = new SqlDataAdapter("Select * from BLOCK_TABLE", conn))
            {
                DataTable BlockTable = new DataTable();
                adapter.Fill(BlockTable);
                DataRow dr = BlockTable.Rows[BlockTable.Rows.Count-1];
                lbBlockHash.Text = dr["CurrentHash"].ToString();
                
                lbPreviousHash.Text = dr["PreviousHash"].ToString();
                lbDate_Time.Text = DateTime.Now.ToString();
                lbMiningTime.Text = "3 Second";

               
            }

        }
    }
}
