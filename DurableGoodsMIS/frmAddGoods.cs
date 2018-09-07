using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DurableGoodsMIS
{
    public partial class frmAddGoods : Form
    {
        public frmAddGoods()
        {
            InitializeComponent();
        }

        string strConn;
        OleDbConnection Conn = new OleDbConnection();
        //OleDbDataAdapter da;
        DataSet ds = new DataSet();
        //DataTable dt;
        OleDbDataReader dataReader;
        OleDbCommand comm = new OleDbCommand();


        private void frmAddGoods_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'durableGoodsMISDataSet.tbAcquisition' table. You can move, or remove it, as needed.
            this.tbAcquisitionTableAdapter.Fill(this.durableGoodsMISDataSet.tbAcquisition);
            // TODO: This line of code loads data into the 'durableGoodsMISDataSet.tbBudget' table. You can move, or remove it, as needed.
            this.tbBudgetTableAdapter.Fill(this.durableGoodsMISDataSet.tbBudget);
            // TODO: This line of code loads data into the 'durableGoodsMISDataSet.tbSection' table. You can move, or remove it, as needed.
            this.tbSectionTableAdapter.Fill(this.durableGoodsMISDataSet.tbSection);
            // TODO: This line of code loads data into the 'durableGoodsMISDataSet.tbStatus' table. You can move, or remove it, as needed.
            this.tbStatusTableAdapter.Fill(this.durableGoodsMISDataSet.tbStatus);
           // TODO: This line of code loads data into the 'durableGoodsMISDataSet.tbGoodsType' table. You can move, or remove it, as needed.
            this.tbGoodsTypeTableAdapter.Fill(this.durableGoodsMISDataSet.tbGoodsType);

            strConn = "Provider=Microsoft.ACE.OLEDB.12.0;data source=DurableGoodsMIS.accdb";
           


            cbGoodsType.SelectedIndex = -1;
            cbSection.SelectedIndex = -1;
            cbStatus.SelectedIndex = 1;
            cbSection.SelectedIndex = 1;
            txtPrice.Text = "0";
            txtLastPrice.Text = "1";
            txtDepreciationSum.Text = "0";
            txtDepreciationRate.Text = "0";
            txtUseful.Text = "5";
            
        }

        private void comboBox1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'durableGoodsMISDataSet.tbGroup' table. You can move, or remove it, as needed.
            //MessageBox.Show(comboBox1.SelectedValue.ToString());
            this.tbGroupTableAdapter.FillByGoodsType(this.durableGoodsMISDataSet.tbGroup, cbGoodsType.SelectedValue.ToString());
            cbGroupClass.SelectedIndex = -1;
            cbType.SelectedIndex = -1;
            cbDesc.SelectedIndex = -1;
            txtGoodsID.Clear();
            this.durableGoodsMISDataSet.tbType.Clear();
            this.durableGoodsMISDataSet.tbDescription.Clear();

            //อ่านค่า อายุการใช้งาน กับอัตราค่าเสื่อมราคา
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


        }

        private void cbGroupClass_SelectionChangeCommitted(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'durableGoodsMISDataSet.tbType' table. You can move, or remove it, as needed.
            this.tbTypeTableAdapter.FillByGroupID(this.durableGoodsMISDataSet.tbType,cbGroupClass.SelectedValue.ToString());
            cbType.SelectedIndex = -1;
            cbDesc.SelectedIndex = -1;
            txtGoodsID.Clear();
            this.durableGoodsMISDataSet.tbDescription.Clear();
        }

        private void cbType_SelectionChangeCommitted(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'durableGoodsMISDataSet.tbDescription' table. You can move, or remove it, as needed.
            this.tbDescriptionTableAdapter.FillByTypeID(this.durableGoodsMISDataSet.tbDescription,cbType.SelectedValue.ToString());
            cbDesc.SelectedIndex = -1;
            txtGoodsID.Clear();

            //อ่านค่ารหัสกลุ่มครุภัณฑ์
           // txtGoodsID.Text = durableGoodsMISDataSet.tbType.Rows[0][2].ToString() + "-" + durableGoodsMISDataSet.tbType.Rows[0][3].ToString();

        }

        private void cbDesc_SelectionChangeCommitted(object sender, EventArgs e)
        {
            txtNoYear.Clear();
            txtSerail.Clear();
            txtSpec.Clear();
            txtGFMIS.Clear();
            txtDocument.Clear();
            txtSellName.Clear();
            txtSellAddress.Clear();
            txtSellPhone.Clear();
            txtComment.Clear();
            txtWhere.Clear();
            txtOwn.Clear();
            txtDepreciationSum.Text = "0";
            txtPrice.Text = "1";
            txtLastPrice.Text = "1";

            txtGoodsID.Clear();

            string strSql = "SELECT tbType.groupClass, tbType.type, tbDescription.description, tbDescription.descID FROM(tbDescription INNER JOIN tbType ON tbDescription.typeID = tbType.typeID)";
                    strSql += " WHERE(tbDescription.descID = " + cbDesc.SelectedValue + ")";

            if (Conn.State == ConnectionState.Open)
                Conn.Close();

            Conn.ConnectionString = strConn;
            Conn.Open();

            comm.Connection = Conn;
            comm.CommandText = strSql;

            dataReader = comm.ExecuteReader();

            if (dataReader.Read()) 
            {
                txtGoodsID.Text += dataReader[0].ToString() + "-" + dataReader[1].ToString() + "-" + dataReader[2].ToString() + "/";
            }           


        }

        private void cmdSave_Click(object sender, EventArgs e)
        {
            if ((txtGoodsID.Text != "") && (txtNoYear.Text != "") && (txtSpec.Text != "") && (txtUseful.Text != "") && (cbSection.SelectedIndex != -1))
            {
                //ตรวจสอบว่าซ้ำหรือไม่
                string strSql = "SELECT goodsID FROM tbGoods WHERE(goodsID = '" + txtGoodsID.Text + "')";

                if (Conn.State == ConnectionState.Open)
                    Conn.Close();

                Conn.ConnectionString = strConn;
                Conn.Open();

                comm.Connection = Conn;
                comm.CommandText = strSql;

                dataReader = comm.ExecuteReader();

                if (!dataReader.Read()) //ถ้าเจอข้อมูล แสดงว่าซ้ำ
                {
                    tbGoodsTableAdapter1.Insert(txtGoodsID.Text, cbGoodsType.SelectedValue.ToString(), int.Parse(cbDesc.SelectedValue.ToString()), txtNoYear.Text, txtGFMIS.Text, txtSpec.Text,
                   txtSerail.Text, txtWhere.Text, cbSection.SelectedValue.ToString(), txtSellName.Text, txtSellPhone.Text, txtSellAddress.Text, cbBudget.SelectedValue.ToString(),
                  cbAcquisition.SelectedValue.ToString(), txtDocument.Text, dtpAcquisitionDate.Value, float.Parse(txtPrice.Text),
                  float.Parse(txtDepreciationRate.Text), float.Parse(txtDepreciationSum.Text), float.Parse(txtLastPrice.Text), byte.Parse(txtUseful.Text), cbStatus.SelectedValue.ToString(),
                  txtOwn.Text, txtComment.Text, int.Parse(cbType.SelectedValue.ToString()));

                    MessageBox.Show("บันทึกข้อมูลเรียบร้อย");
                } else MessageBox.Show("ผิดพลาด: หมายเลขครุภัณฑ์ซ้ำ!!");


            }
            else MessageBox.Show("กรุณากรอกข้อมูลสำคัญให้ครบถ้วน!!");

            
        }

        private void txtPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            char chr = e.KeyChar;
            if (!char.IsNumber(chr) && chr != 8 && chr != 46)   //ตรวจสอบว่าเป็นตัวเลข  backSpace กับ .
                e.Handled = true;
        }

        private void txtUseful_KeyPress(object sender, KeyPressEventArgs e)
        {
            char chr = e.KeyChar;
            if (!char.IsNumber(chr) && chr != 8)   //ตรวจสอบว่าเป็นตัวเลข กับ backSpace
                e.Handled = true;
        }

        private void txtNoYear_KeyPress(object sender, KeyPressEventArgs e)
        {
            char chr = e.KeyChar;
            if (!char.IsNumber(chr) && chr != 8 && chr != 45)   //ตรวจสอบว่าเป็นตัวเลข กับ backSpace และ -
                e.Handled = true;
        }

        private void txtPrice_Leave(object sender, EventArgs e)
        {
            if (txtPrice.Text != "")
                txtPrice.Text = string.Format("{0:n2}", Single.Parse(txtPrice.Text));   //แปลงเป็นตัวเลข ทศนิยม 2 ตำแหน่ง

            txtLastPrice.Text = txtPrice.Text;
        }

        private void txtDepreciationSum_Leave(object sender, EventArgs e)
        {
            if (txtDepreciationSum.Text != "")
                txtDepreciationSum.Text = string.Format("{0:n2}", Single.Parse(txtDepreciationSum.Text));   //แปลงเป็นตัวเลข ทศนิยม 2 ตำแหน่ง
        }

        private void txtLastPrice_Leave(object sender, EventArgs e)
        {
            if(txtLastPrice.Text != "")
                txtLastPrice.Text = string.Format("{0:n2}", Single.Parse(txtLastPrice.Text));   //แปลงเป็นตัวเลข ทศนิยม 2 ตำแหน่ง
        }

        private void txtGoodsID_KeyPress(object sender, KeyPressEventArgs e)
        {
            char chr = e.KeyChar;
            if (!char.IsNumber(chr) && chr != 8 && chr != 45 && chr != 47)   //ตรวจสอบว่าเป็นตัวเลข กับ backSpace - และ /
                e.Handled = true;
        }

        private void cmdDescAdd_Click(object sender, EventArgs e)
        {
            frmAddDescription form = new DurableGoodsMIS.frmAddDescription();
            form.ShowDialog();

        }

        private void cmdCancle_Click(object sender, EventArgs e)
        {
            this.Close();
            Conn.Close();
        }

        private void txtGoodsID_Leave(object sender, EventArgs e)
        {
            if(txtGoodsID.Text.Length > 15)
                txtNoYear.Text = txtGoodsID.Text.Substring(15);
        }

        private void frmAddGoods_FormClosed(object sender, FormClosedEventArgs e)
        {
            Conn.Close();
        }
    }
}
