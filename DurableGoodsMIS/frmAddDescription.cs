using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace DurableGoodsMIS
{
    public partial class frmAddDescription : Form
    {
        public frmAddDescription()
        {
            InitializeComponent();
        }

        string strConn;
        OleDbConnection Conn = new OleDbConnection();
        //OleDbDataAdapter da;
        DataSet ds = new DataSet();
        //DataTable dt;
        DataRow dr;
        OleDbDataReader dataReader;
        OleDbCommand comm = new OleDbCommand();

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmAddDescription_Load(object sender, EventArgs e)
        {
            strConn = "Provider=Microsoft.ACE.OLEDB.12.0;data source=DurableGoodsMIS.accdb";

            string strSql = "select * from tbGoodsType";

            if (Conn.State == ConnectionState.Open)
                Conn.Close();

            Conn.ConnectionString = strConn;
            Conn.Open();

            comm.Connection = Conn;
            comm.CommandText = strSql;

            dataReader = comm.ExecuteReader();

            dataReader.Read();

            MessageBox.Show(dataReader.GetString(1));  //แสดงข้อมูล collum ที่ 2



        }
    }
}
