namespace DurableGoodsMIS
{
    partial class frmAddDescription
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDescNo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.txtDescTitle = new System.Windows.Forms.TextBox();
            this.label44 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cbGroupClass = new System.Windows.Forms.ComboBox();
            this.tbGroupBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.durableGoodsMISDataSet = new DurableGoodsMIS.DurableGoodsMISDataSet();
            this.label43 = new System.Windows.Forms.Label();
            this.cbType = new System.Windows.Forms.ComboBox();
            this.tbTypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.cbGoodsType = new System.Windows.Forms.ComboBox();
            this.tbGoodsTypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbGoodsTypeTableAdapter = new DurableGoodsMIS.DurableGoodsMISDataSetTableAdapters.tbGoodsTypeTableAdapter();
            this.tbGroupTableAdapter = new DurableGoodsMIS.DurableGoodsMISDataSetTableAdapters.tbGroupTableAdapter();
            this.tbTypeTableAdapter = new DurableGoodsMIS.DurableGoodsMISDataSetTableAdapters.tbTypeTableAdapter();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbGroupBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.durableGoodsMISDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbTypeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbGoodsTypeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtDescNo);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.txtDescTitle);
            this.groupBox1.Controls.Add(this.label44);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.cbGroupClass);
            this.groupBox1.Controls.Add(this.label43);
            this.groupBox1.Controls.Add(this.cbType);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cbGoodsType);
            this.groupBox1.Location = new System.Drawing.Point(10, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(513, 279);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label3.Location = new System.Drawing.Point(196, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 18);
            this.label3.TabIndex = 133;
            this.label3.Text = "ตัวเลข 4 หลัก";
            // 
            // txtDescNo
            // 
            this.txtDescNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.txtDescNo.Location = new System.Drawing.Point(125, 134);
            this.txtDescNo.MaxLength = 4;
            this.txtDescNo.Name = "txtDescNo";
            this.txtDescNo.Size = new System.Drawing.Size(65, 22);
            this.txtDescNo.TabIndex = 132;
            this.txtDescNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDescNo_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label2.Location = new System.Drawing.Point(27, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 18);
            this.label2.TabIndex = 131;
            this.label2.Text = "กลุ่มรหัส";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(415, 228);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(71, 28);
            this.button2.TabIndex = 130;
            this.button2.Text = "ยกเลิก";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(329, 228);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(71, 28);
            this.button1.TabIndex = 129;
            this.button1.Text = "บันทึก";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtDescTitle
            // 
            this.txtDescTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.txtDescTitle.Location = new System.Drawing.Point(125, 167);
            this.txtDescTitle.MaxLength = 80;
            this.txtDescTitle.Name = "txtDescTitle";
            this.txtDescTitle.Size = new System.Drawing.Size(361, 22);
            this.txtDescTitle.TabIndex = 128;
            // 
            // label44
            // 
            this.label44.AutoSize = true;
            this.label44.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label44.Location = new System.Drawing.Point(27, 167);
            this.label44.Name = "label44";
            this.label44.Size = new System.Drawing.Size(71, 18);
            this.label44.TabIndex = 127;
            this.label44.Text = "คุณลักษณะ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label8.Location = new System.Drawing.Point(27, 63);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(81, 18);
            this.label8.TabIndex = 126;
            this.label8.Text = "กลุ่ม ประเภท";
            // 
            // cbGroupClass
            // 
            this.cbGroupClass.DataSource = this.tbGroupBindingSource;
            this.cbGroupClass.DisplayMember = "groupTitle";
            this.cbGroupClass.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbGroupClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.cbGroupClass.FormattingEnabled = true;
            this.cbGroupClass.Location = new System.Drawing.Point(125, 62);
            this.cbGroupClass.Name = "cbGroupClass";
            this.cbGroupClass.Size = new System.Drawing.Size(361, 24);
            this.cbGroupClass.TabIndex = 118;
            this.cbGroupClass.ValueMember = "groupID";
            this.cbGroupClass.SelectionChangeCommitted += new System.EventHandler(this.cbGroupClass_SelectionChangeCommitted);
            // 
            // tbGroupBindingSource
            // 
            this.tbGroupBindingSource.DataMember = "tbGroup";
            this.tbGroupBindingSource.DataSource = this.durableGoodsMISDataSet;
            // 
            // durableGoodsMISDataSet
            // 
            this.durableGoodsMISDataSet.DataSetName = "DurableGoodsMISDataSet";
            this.durableGoodsMISDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label43
            // 
            this.label43.AutoSize = true;
            this.label43.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label43.Location = new System.Drawing.Point(27, 98);
            this.label43.Name = "label43";
            this.label43.Size = new System.Drawing.Size(33, 18);
            this.label43.TabIndex = 125;
            this.label43.Text = "ชนิด";
            // 
            // cbType
            // 
            this.cbType.DataSource = this.tbTypeBindingSource;
            this.cbType.DisplayMember = "typeTitle";
            this.cbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.cbType.FormattingEnabled = true;
            this.cbType.Location = new System.Drawing.Point(125, 97);
            this.cbType.Name = "cbType";
            this.cbType.Size = new System.Drawing.Size(361, 24);
            this.cbType.TabIndex = 120;
            this.cbType.ValueMember = "typeID";
            // 
            // tbTypeBindingSource
            // 
            this.tbTypeBindingSource.DataMember = "tbType";
            this.tbTypeBindingSource.DataSource = this.durableGoodsMISDataSet;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label1.Location = new System.Drawing.Point(27, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 18);
            this.label1.TabIndex = 124;
            this.label1.Text = "หมวดครุภัณฑ์";
            // 
            // cbGoodsType
            // 
            this.cbGoodsType.DataSource = this.tbGoodsTypeBindingSource;
            this.cbGoodsType.DisplayMember = "goodsType";
            this.cbGoodsType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbGoodsType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.cbGoodsType.FormattingEnabled = true;
            this.cbGoodsType.Location = new System.Drawing.Point(125, 26);
            this.cbGoodsType.Name = "cbGoodsType";
            this.cbGoodsType.Size = new System.Drawing.Size(234, 24);
            this.cbGoodsType.TabIndex = 117;
            this.cbGoodsType.ValueMember = "goodsTypeID";
            this.cbGoodsType.SelectionChangeCommitted += new System.EventHandler(this.cbGoodsType_SelectionChangeCommitted);
            // 
            // tbGoodsTypeBindingSource
            // 
            this.tbGoodsTypeBindingSource.DataMember = "tbGoodsType";
            this.tbGoodsTypeBindingSource.DataSource = this.durableGoodsMISDataSet;
            // 
            // tbGoodsTypeTableAdapter
            // 
            this.tbGoodsTypeTableAdapter.ClearBeforeFill = true;
            // 
            // tbGroupTableAdapter
            // 
            this.tbGroupTableAdapter.ClearBeforeFill = true;
            // 
            // tbTypeTableAdapter
            // 
            this.tbTypeTableAdapter.ClearBeforeFill = true;
            // 
            // frmAddDescription
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(536, 303);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmAddDescription";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "เพิ่มคุณลักษณะครุภัณฑ์";
            this.Load += new System.EventHandler(this.frmAddDescription_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbGroupBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.durableGoodsMISDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbTypeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbGoodsTypeBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtDescTitle;
        private System.Windows.Forms.Label label44;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbGroupClass;
        private System.Windows.Forms.Label label43;
        private System.Windows.Forms.ComboBox cbType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbGoodsType;
        private DurableGoodsMISDataSet durableGoodsMISDataSet;
        private System.Windows.Forms.BindingSource tbGoodsTypeBindingSource;
        private DurableGoodsMISDataSetTableAdapters.tbGoodsTypeTableAdapter tbGoodsTypeTableAdapter;
        private System.Windows.Forms.BindingSource tbGroupBindingSource;
        private DurableGoodsMISDataSetTableAdapters.tbGroupTableAdapter tbGroupTableAdapter;
        private System.Windows.Forms.BindingSource tbTypeBindingSource;
        private DurableGoodsMISDataSetTableAdapters.tbTypeTableAdapter tbTypeTableAdapter;
        private System.Windows.Forms.TextBox txtDescNo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}