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
          
            //this.crystalReportViewer1.ReportSource = crystalReport011;
            this.crystalReportViewer1.Refresh();

            
        }
    }
}
