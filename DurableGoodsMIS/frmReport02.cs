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
    public partial class frmReport02 : Form
    {
        public frmReport02()
        {
            InitializeComponent();
        }

        private void frmReport02_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'durableGoodsMISDataSet.dataReport01' table. You can move, or remove it, as needed.
            this.dataReport02TableAdapter.Fill(this.durableGoodsMISDataSet.dataReport02);


            CrystalReport021.SetDataSource(durableGoodsMISDataSet);
            crystalReportViewer1.RefreshReport();
        }
    }
}
