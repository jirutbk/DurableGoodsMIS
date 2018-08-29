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
            this.tbGoodsTypeTableAdapter.Fill(this.durableGoodsMISDataSet.tbGoodsType);

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

            cbGroupClass.SelectedIndex = -1;
            cbGoodsType.SelectedIndex = -1;
            cbType.SelectedIndex = -1;

        }

        private void txtDescNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            char chr = e.KeyChar;
            if (!char.IsNumber(chr) && chr != 8)   //ตรวจสอบว่าเป็นตัวเลข กับ backSpace
                e.Handled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtDescNo.Text == "" || txtDescTitle.Text == "" || txtDescNo.Text.Length != 4 || cbType.SelectedIndex == -1)
            {
                MessageBox.Show("กรุณาป้อนข้อมูลให้ครบถ้วน!!");
                return;
            }

            MessageBox.Show("บันทึกข้อมูลเรียบร้อย.");
        }

        private void cbGoodsType_SelectionChangeCommitted(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'durableGoodsMISDataSet.tbGroup' table. You can move, or remove it, as needed.
            this.tbGroupTableAdapter.FillByGoodsType(this.durableGoodsMISDataSet.tbGroup,cbGoodsType.SelectedValue.ToString());
            this.durableGoodsMISDataSet.tbType.Clear();
            cbGroupClass.SelectedIndex = -1;
        }

        private void cbGroupClass_SelectionChangeCommitted(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'durableGoodsMISDataSet.tbType' table. You can move, or remove it, as needed.
            this.tbTypeTableAdapter.FillByGroupID(this.durableGoodsMISDataSet.tbType,cbGroupClass.SelectedValue.ToString());
            cbType.SelectedIndex = -1;

        }
    }
}
