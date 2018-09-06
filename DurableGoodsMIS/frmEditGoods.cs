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
    public partial class frmEditGoods : Form
    {
        string goodsID;
               

        public frmEditGoods(string GoodsID)
        {
            goodsID = GoodsID;
            InitializeComponent();

        }

        private void frmEditGoods_Load(object sender, EventArgs e)
        {
            //MessageBox.Show(goodsID);
           

            this.tbAcquisitionTableAdapter.Fill(this.durableGoodsMISDataSet.tbAcquisition);
            this.tbBudgetTableAdapter.Fill(this.durableGoodsMISDataSet.tbBudget);
            this.tbSectionTableAdapter.Fill(this.durableGoodsMISDataSet.tbSection);
            this.tbStatusTableAdapter.Fill(this.durableGoodsMISDataSet.tbStatus);
            this.tbGoodsTypeTableAdapter.Fill(this.durableGoodsMISDataSet.tbGoodsType);


            tbGoodsTypeTableAdapter.Fill(durableGoodsMISDataSet.tbGoodsType);
            
            tbTypeTableAdapter.Fill(durableGoodsMISDataSet.tbType);
            tbDescriptionTableAdapter.Fill(durableGoodsMISDataSet.tbDescription);

            tbGoodsTableAdapter1.FillByGoodsID(this.durableGoodsMISDataSet.tbGoods, goodsID);

        }

        private void cmdCancle_Click(object sender, EventArgs e)
        {
            
            this.Close();
        }

        private void cmdSave_Click(object sender, EventArgs e)
        {
            if ((txtGoodsID.Text != "") && (txtNoYear.Text != "") && (txtSpec.Text != "") && (txtUseful.Text != "") && (cbSection.SelectedIndex != -1))
            {
                  tbGoodsTableAdapter1.UpdateQuery(txtNoYear.Text, txtGFMIS.Text, txtSpec.Text,
                  txtSerail.Text, txtWhere.Text, cbSection.SelectedValue.ToString(), txtSellName.Text, txtSellPhone.Text, txtSellAddress.Text, cbBudget.SelectedValue.ToString(),
                  cbAcquisition.SelectedValue.ToString(), txtDocument.Text, dtpAcquisitionDate.Value, decimal.Parse(txtPrice.Text),
                  decimal.Parse(txtDepreciationRate.Text), decimal.Parse(txtDepreciationSum.Text), decimal.Parse(txtLastPrice.Text), byte.Parse(txtUseful.Text), cbStatus.SelectedValue.ToString(),
                  txtOwn.Text, txtComment.Text,txtGoodsID.Text);

                MessageBox.Show("บันทึกข้อมูลเรียบร้อย");
                this.Close();
             }
            
            else MessageBox.Show("กรุณากรอกข้อมูลสำคัญให้ครบถ้วน!!");
        }
    }
}
