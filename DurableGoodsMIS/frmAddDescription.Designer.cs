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
            this.txtDesc2 = new System.Windows.Forms.TextBox();
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
            this.label4 = new System.Windows.Forms.Label();
            this.cbDesc = new System.Windows.Forms.ComboBox();
            this.tbDescriptionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbDescriptionTableAdapter = new DurableGoodsMIS.DurableGoodsMISDataSetTableAdapters.tbDescriptionTableAdapter();
            this.txtDesc1 = new System.Windows.Forms.TextBox();
            this.txtType = new System.Windows.Forms.TextBox();
            this.txtGroup = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbGroupBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.durableGoodsMISDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbTypeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbGoodsTypeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbDescriptionBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtGroup);
            this.groupBox1.Controls.Add(this.txtType);
            this.groupBox1.Controls.Add(this.txtDesc1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.cbDesc);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtDesc2);
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
            this.groupBox1.Size = new System.Drawing.Size(555, 292);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label3.Location = new System.Drawing.Point(169, 170);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 18);
            this.label3.TabIndex = 133;
            this.label3.Text = "ตัวเลข 4 หลัก";
            // 
            // txtDesc2
            // 
            this.txtDesc2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.txtDesc2.Location = new System.Drawing.Point(125, 169);
            this.txtDesc2.MaxLength = 4;
            this.txtDesc2.Name = "txtDesc2";
            this.txtDesc2.Size = new System.Drawing.Size(38, 22);
            this.txtDesc2.TabIndex = 5;
            this.txtDesc2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDescNo_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(27, 169);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 18);
            this.label2.TabIndex = 131;
            this.label2.Text = "เพิ่มกลุ่มรหัส";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(434, 245);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(71, 28);
            this.button2.TabIndex = 8;
            this.button2.Text = "ยกเลิก";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(346, 245);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(71, 28);
            this.button1.TabIndex = 7;
            this.button1.Text = "บันทึก";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtDescTitle
            // 
            this.txtDescTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.txtDescTitle.Location = new System.Drawing.Point(125, 202);
            this.txtDescTitle.MaxLength = 80;
            this.txtDescTitle.Name = "txtDescTitle";
            this.txtDescTitle.Size = new System.Drawing.Size(409, 22);
            this.txtDescTitle.TabIndex = 6;
            // 
            // label44
            // 
            this.label44.AutoSize = true;
            this.label44.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label44.ForeColor = System.Drawing.Color.Red;
            this.label44.Location = new System.Drawing.Point(27, 202);
            this.label44.Name = "label44";
            this.label44.Size = new System.Drawing.Size(94, 18);
            this.label44.TabIndex = 127;
            this.label44.Text = "เพิ่มคุณลักษณะ";
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
            this.cbGroupClass.Location = new System.Drawing.Point(169, 62);
            this.cbGroupClass.Name = "cbGroupClass";
            this.cbGroupClass.Size = new System.Drawing.Size(365, 24);
            this.cbGroupClass.TabIndex = 2;
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
            this.cbType.Location = new System.Drawing.Point(172, 97);
            this.cbType.Name = "cbType";
            this.cbType.Size = new System.Drawing.Size(362, 24);
            this.cbType.TabIndex = 3;
            this.cbType.ValueMember = "typeID";
            this.cbType.SelectionChangeCommitted += new System.EventHandler(this.cbType_SelectionChangeCommitted);
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
            this.cbGoodsType.TabIndex = 1;
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
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label4.Location = new System.Drawing.Point(27, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 18);
            this.label4.TabIndex = 135;
            this.label4.Text = "คุณลักษณะ";
            // 
            // cbDesc
            // 
            this.cbDesc.DataSource = this.tbDescriptionBindingSource;
            this.cbDesc.DisplayMember = "descriptionTitle";
            this.cbDesc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.cbDesc.FormattingEnabled = true;
            this.cbDesc.Location = new System.Drawing.Point(172, 132);
            this.cbDesc.Name = "cbDesc";
            this.cbDesc.Size = new System.Drawing.Size(362, 24);
            this.cbDesc.TabIndex = 4;
            this.cbDesc.ValueMember = "descID";
            // 
            // tbDescriptionBindingSource
            // 
            this.tbDescriptionBindingSource.DataMember = "tbDescription";
            this.tbDescriptionBindingSource.DataSource = this.durableGoodsMISDataSet;
            // 
            // tbDescriptionTableAdapter
            // 
            this.tbDescriptionTableAdapter.ClearBeforeFill = true;
            // 
            // txtDesc1
            // 
            this.txtDesc1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbDescriptionBindingSource, "description", true));
            this.txtDesc1.Enabled = false;
            this.txtDesc1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.txtDesc1.Location = new System.Drawing.Point(125, 134);
            this.txtDesc1.MaxLength = 4;
            this.txtDesc1.Name = "txtDesc1";
            this.txtDesc1.Size = new System.Drawing.Size(38, 22);
            this.txtDesc1.TabIndex = 136;
            // 
            // txtType
            // 
            this.txtType.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbTypeBindingSource, "type", true));
            this.txtType.Enabled = false;
            this.txtType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.txtType.Location = new System.Drawing.Point(125, 99);
            this.txtType.MaxLength = 4;
            this.txtType.Name = "txtType";
            this.txtType.Size = new System.Drawing.Size(38, 22);
            this.txtType.TabIndex = 137;
            // 
            // txtGroup
            // 
            this.txtGroup.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbGroupBindingSource, "groupID", true));
            this.txtGroup.Enabled = false;
            this.txtGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.txtGroup.Location = new System.Drawing.Point(125, 64);
            this.txtGroup.MaxLength = 4;
            this.txtGroup.Name = "txtGroup";
            this.txtGroup.Size = new System.Drawing.Size(25, 22);
            this.txtGroup.TabIndex = 138;
            // 
            // frmAddDescription
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(577, 315);
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
            ((System.ComponentModel.ISupportInitialize)(this.tbDescriptionBindingSource)).EndInit();
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
        private System.Windows.Forms.TextBox txtDesc2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbDesc;
        private System.Windows.Forms.BindingSource tbDescriptionBindingSource;
        private DurableGoodsMISDataSetTableAdapters.tbDescriptionTableAdapter tbDescriptionTableAdapter;
        private System.Windows.Forms.TextBox txtGroup;
        private System.Windows.Forms.TextBox txtType;
        private System.Windows.Forms.TextBox txtDesc1;
    }
}