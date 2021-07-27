using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace DHANA
{
    public partial class frmBlockInfo : Form
    {
        string connectionString;
        BindingSource blockBindingSource = new BindingSource();
        SqlDataAdapter adapter,adapter1;
        
        public frmBlockInfo()
        {
            InitializeComponent();
            connectionString = ConfigurationManager.ConnectionStrings["DHANA.Properties.Settings.BLOCKCHAINConnectionString2"].ConnectionString;
        }

        private void frmBlockInfo_Load(object sender, EventArgs e)
        {
            dgvBlockTable.DataSource = blockBindingSource;
            adapter = new SqlDataAdapter("Select * from BLOCK_TABLE", connectionString);
            SqlCommandBuilder commandBuilder = new SqlCommandBuilder(adapter);
            DataTable blockTable = new DataTable(); 
            adapter.Fill(blockTable);
            blockBindingSource.DataSource = blockTable;

            dgvTransaction.DataSource = blockBindingSource;
            adapter1 = new SqlDataAdapter("Select * from Transaction_Table", connectionString);
            SqlCommandBuilder commandBuilder1 = new SqlCommandBuilder(adapter1);
            DataTable trantable = new DataTable();
            adapter.Fill(trantable);
            blockBindingSource.DataSource = trantable;

        }

       
    }
}
