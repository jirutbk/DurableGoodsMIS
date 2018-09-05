using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DurableGoodsMIS
{
    public partial class frmReport0 : Form
    {
        public frmReport0()
        {
            InitializeComponent();
        }

        private void frmReport01_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DurableGoodsMISDataSet.tbGoods' table. You can move, or remove it, as needed.
            this.tbGoodsTableAdapter.Fill(this.DurableGoodsMISDataSet.tbGoods);
            
           /*

            System.Drawing.Printing.PageSettings pg = new System.Drawing.Printing.PageSettings();
            pg.Margins.Top = 15;
            pg.Margins.Bottom = 15;
            pg.Margins.Left = 15;
            pg.Margins.Right = 15;
            System.Drawing.Printing.PaperSize size = new PaperSize();
            size.RawKind = (int)PaperKind.A4;
            pg.PaperSize = size;
            pg.Landscape = true;
            reportViewer1.SetPageSettings(pg);
            */
            this.reportViewer1.RefreshReport();
        }
    }
}
