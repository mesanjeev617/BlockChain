using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Windows.Forms;

namespace DHANA
{
    public partial class frmTransaction : Form
    {
        public int LastRow { get; set; }
        string connectionString;
        SqlConnection conn, conn2,conn3;
        DataRow dr1;
        public frmTransaction()
        {
            InitializeComponent();
            connectionString = ConfigurationManager.ConnectionStrings["DHANA.Properties.Settings.BLOCKCHAINConnectionString2"].ConnectionString;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (conn3 = new SqlConnection(connectionString))
            using (SqlDataAdapter adapter = new SqlDataAdapter("Select * from BLOCK_TABLE", conn3))
            {
                DataTable BlockTable = new DataTable();
                adapter.Fill(BlockTable);
                LastRow = BlockTable.Rows.Count;
                 dr1 = BlockTable.Rows[LastRow - 1];
            }



                using (conn = new SqlConnection(connectionString))
                using (SqlCommand comd = new SqlCommand("Insert into Transaction_table (TransactionId,SenderKey, ReceiverKey, TimeStamp, FinalHash, SentQuantity ) " +
                    "VALUES (@TranId, @SKey, @RKey, @TStamp, @FHash, @sent)", conn))
                {

                    conn.Open();
                    comd.Parameters.AddWithValue("@TranId", (LastRow + 1).ToString());
                    comd.Parameters.AddWithValue("@Skey", tbSender.Text);
                    comd.Parameters.AddWithValue("@RKey", tbReceiver.Text);
                    comd.Parameters.AddWithValue("@TStamp", DateTime.Now.ToString());
                    comd.Parameters.AddWithValue("@FHash", TransacData.HashData(int.Parse(tbSent.Text), tbSender.Text, tbReceiver.Text, DateTime.Now));
                    comd.Parameters.AddWithValue("@sent", int.Parse(tbSent.Text));
                    comd.ExecuteScalar();

                    using (conn2 = new SqlConnection(connectionString))
                    using (SqlCommand cmd = new SqlCommand("Insert into Block_table (BlockIndex,TransactionId,CurrentHash,PreviousHash) " +
                        "Values (@bIn, @TranId,@CHash,@PHash)", conn2))
                    {
                        conn2.Open();
                        cmd.Parameters.AddWithValue("@bIn", (LastRow + 1).ToString());
                        cmd.Parameters.AddWithValue("@TranId", (LastRow + 1).ToString());
                       
                        cmd.Parameters.AddWithValue("CHash", TransacData.HashData(int.Parse(tbSent.Text), tbSender.Text, tbReceiver.Text, DateTime.Now));

                        cmd.Parameters.AddWithValue("@PHash", dr1["CurrentHash"].ToString());
                        cmd.ExecuteScalar();


                    }


                    MessageBox.Show("Transatcion Data Hashing Successful\n" +
                        "Block Successfully Created");
                }

            
            frmMined frm = new frmMined();
            frm.ShowDialog();


        }

        private void frmTransaction_Load(object sender, EventArgs e)
        {


        }
    }
}
