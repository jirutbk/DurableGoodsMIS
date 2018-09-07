namespace DurableGoodsMIS
{
    partial class frmReport01
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.CrystalReport011 = new DurableGoodsMIS.CrystalReport01();
            this.durableGoodsMISDataSet = new DurableGoodsMIS.DurableGoodsMISDataSet();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dataReport01TableAdapter = new DurableGoodsMIS.DurableGoodsMISDataSetTableAdapters.dataReport01TableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.durableGoodsMISDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = 0;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalReportViewer1.Location = new System.Drawing.Point(0, 0);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.ReportSource = this.CrystalReport011;
            this.crystalReportViewer1.Size = new System.Drawing.Size(854, 411);
            this.crystalReportViewer1.TabIndex = 0;
            // 
            // durableGoodsMISDataSet
            // 
            this.durableGoodsMISDataSet.DataSetName = "DurableGoodsMISDataSet";
            this.durableGoodsMISDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataMember = "dataReport01";
            this.bindingSource1.DataSource = this.durableGoodsMISDataSet;
            // 
            // dataReport01TableAdapter
            // 
            this.dataReport01TableAdapter.ClearBeforeFill = true;
            // 
            // frmReport01
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(854, 411);
            this.Controls.Add(this.crystalReportViewer1);
            this.Name = "frmReport01";
            this.Text = "พิมพ์ทะเบียนคุมครุภัณฑ์";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmReport02_Load);
            ((System.ComponentModel.ISupportInitialize)(this.durableGoodsMISDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        private CrystalReport01 CrystalReport011;
        private DurableGoodsMISDataSet durableGoodsMISDataSet;
        private System.Windows.Forms.BindingSource bindingSource1;
        private DurableGoodsMISDataSetTableAdapters.dataReport01TableAdapter dataReport01TableAdapter;
    }
}