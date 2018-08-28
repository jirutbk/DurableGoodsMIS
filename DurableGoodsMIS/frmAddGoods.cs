using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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


            cbGoodsType.SelectedIndex = -1;
            cbSection.SelectedIndex = -1;
            cbStatus.SelectedIndex = 1;
        }

        private void comboBox1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'durableGoodsMISDataSet.tbGroup' table. You can move, or remove it, as needed.
            //MessageBox.Show(comboBox1.SelectedValue.ToString());
            this.tbGroupTableAdapter.FillByGoodsType(this.durableGoodsMISDataSet.tbGroup, cbGoodsType.SelectedValue.ToString());
            cbGroupClass.SelectedIndex = -1;
            cbType.SelectedIndex = -1;
            cbDesc.SelectedIndex = -1;            
            this.durableGoodsMISDataSet.tbType.Clear();
            this.durableGoodsMISDataSet.tbDescription.Clear();
        }

        private void cbGroupClass_SelectionChangeCommitted(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'durableGoodsMISDataSet.tbType' table. You can move, or remove it, as needed.
            this.tbTypeTableAdapter.FillByGroupID(this.durableGoodsMISDataSet.tbType,cbGroupClass.SelectedValue.ToString());
            cbType.SelectedIndex = -1;
            cbDesc.SelectedIndex = -1;
            this.durableGoodsMISDataSet.tbDescription.Clear();
        }

        private void cbType_SelectionChangeCommitted(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'durableGoodsMISDataSet.tbDescription' table. You can move, or remove it, as needed.
            this.tbDescriptionTableAdapter.FillByTypeID(this.durableGoodsMISDataSet.tbDescription,cbType.SelectedValue.ToString());
            cbDesc.SelectedIndex = -1;

            //อ่านค่ารหัสกลุ่มครุภัณฑ์
            //this.tbDescriptionTableAdapter.readTemp(this.durableGoodsMISDataSet.tbTemp, cbType.SelectedValue.ToString());
            //this.durableGoodsMISDataSet.tbTemp.Rows[0][1].

            txtGoodsID.Text = cbType.SelectedValue.ToString();

        }

        private void cbDesc_SelectionChangeCommitted(object sender, EventArgs e)
        {
            txtGoodsID.Text += cbType.SelectedValue.ToString();
        }

        private void cmdSave_Click(object sender, EventArgs e)
        {
            //tbGoodsTableAdapter1.Insert();
        }
    }
}
