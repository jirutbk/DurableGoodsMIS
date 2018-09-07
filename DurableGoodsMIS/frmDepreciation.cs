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
    public partial class frmDepreciation : Form
    {
        string strConn;
        OleDbConnection Conn = new OleDbConnection();
        //OleDbDataAdapter da;
        DataSet ds = new DataSet();
        //DataTable dt;
        OleDbDataReader dataReader;
        OleDbCommand comm = new OleDbCommand();

        public frmDepreciation()
        {
            InitializeComponent();
        }

        private void frmDepreciation_Load(object sender, EventArgs e)
        {
            strConn = "Provider=Microsoft.ACE.OLEDB.12.0;data source=DurableGoodsMIS.accdb";

/*
            string strSql = "SELECT * FROM tbGoodsType";
            strSql += " WHERE(goodsTypeID = '" + cbGoodsType.SelectedValue.ToString() + "')";

            //MessageBox.Show(strSql);

            if (Conn.State == ConnectionState.Open)
                Conn.Close();

            Conn.ConnectionString = strConn;
            Conn.Open();

            comm.Connection = Conn;
            comm.CommandText = strSql;

            dataReader = comm.ExecuteReader();

            if (dataReader.Read())
            {
                txtUseful.Text = dataReader[3].ToString();  //อายุการใช้งานสูงสุด
                txtDepreciationRate.Text = dataReader[4].ToString();  //อัตราค่าเสื่อมราคาต่ำสุด

            }
            */
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            Conn.Close();
        }
    }
}
