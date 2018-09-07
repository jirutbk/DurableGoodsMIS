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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {          
          
            this.tbSubGoodsTableAdapter.Fill(this.durableGoodsMISDataSet.tbSubGoods);
            // TODO: This line of code loads data into the 'durableGoodsMISDataSet.tbFix' table. You can move, or remove it, as needed.
            this.tbFixTableAdapter.Fill(this.durableGoodsMISDataSet.tbFix);
            // TODO: This line of code loads data into the 'durableGoodsMISDataSet.tbDescription' table. You can move, or remove it, as needed.
            this.tbDescriptionTableAdapter.Fill(this.durableGoodsMISDataSet.tbDescription);
            // TODO: This line of code loads data into the 'durableGoodsMISDataSet.tbAcquisition' table. You can move, or remove it, as needed.
            this.tbAcquisitionTableAdapter.Fill(this.durableGoodsMISDataSet.tbAcquisition);
            // TODO: This line of code loads data into the 'durableGoodsMISDataSet.tbBudget' table. You can move, or remove it, as needed.
            this.tbBudgetTableAdapter.Fill(this.durableGoodsMISDataSet.tbBudget);
            // TODO: This line of code loads data into the 'durableGoodsMISDataSet.tbStatus' table. You can move, or remove it, as needed.
            this.tbStatusTableAdapter.Fill(this.durableGoodsMISDataSet.tbStatus);
            // TODO: This line of code loads data into the 'durableGoodsMISDataSet.tbSection' table. You can move, or remove it, as needed.
            this.tbSectionTableAdapter.Fill(this.durableGoodsMISDataSet.tbSection);

            // TODO: This line of code loads data into the 'durableGoodsMISDataSet.tbType' table. You can move, or remove it, as needed.
            this.tbTypeTableAdapter.Fill(this.durableGoodsMISDataSet.tbType);
            // TODO: This line of code loads data into the 'durableGoodsMISDataSet.tbGoodsType' table. You can move, or remove it, as needed.
            this.tbGoodsTypeTableAdapter.Fill(this.durableGoodsMISDataSet.tbGoodsType);


            comboBox1.SelectedIndex = -1;
            comboBox2.SelectedIndex = -1;
            comboBox3.SelectedIndex = -1;
            comboBox6.SelectedIndex = -1;
            comboBox7.SelectedIndex = -1;
            cmdEdit.Enabled = false;
            btnEdit.Enabled = false;

            dataGridView2.Columns[3].DefaultCellStyle.Format = "c";  //เซต cell format เป็นแบบ currency
            dataGridView2.Columns[4].DefaultCellStyle.Format = "c";  //เซต cell format เป็นแบบ currency
           // dataGridView2.Columns[5].DefaultCellStyle.Format = "c";  //เซต cell format เป็นแบบ currency

            dataGridView3.Columns[3].DefaultCellStyle.Format = "c";  //เซต cell format เป็นแบบ currency
            dataGridView4.Columns[2].DefaultCellStyle.Format = "c";  //เซต cell format เป็นแบบ currency


        }
              
        private void comboBox1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            this.tbGoodsTableAdapter.FillByGoodtype(this.durableGoodsMISDataSet.tbGoods, comboBox1.SelectedValue.ToString());
            comboBox6.SelectedIndex = -1;
            textBox1.Clear();
        }

        private void comboBox6_SelectionChangeCommitted(object sender, EventArgs e)
        {
            this.tbGoodsTableAdapter.FillByType(this.durableGoodsMISDataSet.tbGoods, comboBox6.SelectedValue.ToString());
            comboBox1.SelectedIndex = -1;
            textBox1.Clear();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            this.tbGoodsTableAdapter.FillByGoodsID(this.durableGoodsMISDataSet.tbGoods, textBox1.Text + "%");
            comboBox1.SelectedIndex = -1;
            comboBox6.SelectedIndex = -1;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void report01ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmReport01 form2 = new frmReport01();
            form2.ShowDialog();
        }

        private void report02ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmReport02 form = new frmReport02();
            form.ShowDialog();
        }

        private void addGoodsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddGoods form2 = new frmAddGoods();
            form2.ShowDialog();
        }

        private void cmdAdd_Click(object sender, EventArgs e)
        {
            frmAddGoods form2 = new frmAddGoods();
            form2.ShowDialog();
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            frmAddGoods form2 = new frmAddGoods();
            form2.ShowDialog();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char chr = e.KeyChar;
            if (!char.IsNumber(chr) && chr != 8 && chr != 45 && chr != 47)   //ตรวจสอบว่าเป็นตัวเลข กับ backSpace - และ /
                e.Handled = true;
        }

        private void addDescToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddDescription form = new frmAddDescription();
            form.ShowDialog();
        }

        private void tbGoodsBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            if (label40.Text != "-" && label40.Text != "")
            {
                var date = DateTime.Parse(label40.Text);
                label40.Text = date.ToString("dd/MM/yyyy");
            }
                                              
           
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            frmEditGoods form = new frmEditGoods(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            form.ShowDialog();
        }

        private void cmdEdit_Click(object sender, EventArgs e)
        {
            frmEditGoods form = new frmEditGoods(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value.ToString());
            form.ShowDialog();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
          
                frmEditGoods form = new frmEditGoods(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value.ToString());
                form.ShowDialog();
          
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            cmdEdit.Enabled = true;
            btnEdit.Enabled = true;
        }

        private void frmMain_Activated(object sender, EventArgs e)
        {
            //dataGridView1.Update();
            //dataGridView1.Refresh();
        }

        private void frmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }

        private void report03ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmReport0 form = new frmReport0();
            form.ShowDialog();
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            frmDepreciation form = new frmDepreciation();
            form.ShowDialog();
        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            // TODO: This line of code loads data into the 'durableGoodsMISDataSet.tbDepreciation' table. You can move, or remove it, as needed.
            this.tbDepreciationTableAdapter.FillByGoodsID(this.durableGoodsMISDataSet.tbDepreciation, dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value.ToString());
                       
        }

       
    }
}
