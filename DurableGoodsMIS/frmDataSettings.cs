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
    public partial class frmORGSettings : Form
    {
        public frmORGSettings()
        {
            InitializeComponent();
        }

        private void frmORGSettings_Load(object sender, EventArgs e)
        {
            tbOrganizationTableAdapter.Fill(durableGoodsMISDataSet.tbOrganization);
        }

        private void cmdCancle_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmdSave_Click(object sender, EventArgs e)
        {
            if (txtAddress.Text != "" && txtBoss.Text != "" && txtORG.Text != "" && txtPosition.Text != "" && txtSubOrg.Text != "")
            {
                tbOrganizationTableAdapter.UpdateQuery(txtORG.Text, txtSubOrg.Text, txtAddress.Text, txtBoss.Text, txtPosition.Text);
                MessageBox.Show("บันทึกเรียบร้อย.");
                this.Close();
            }else MessageBox.Show("กรุณาป้อนข้อมูลให้ครบถ้วน!!");
        }
    }
}
