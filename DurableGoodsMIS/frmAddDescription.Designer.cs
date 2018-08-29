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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmdTypeAdd = new System.Windows.Forms.Button();
            this.cmdGroupClassAdd = new System.Windows.Forms.Button();
            this.label44 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cbGroupClass = new System.Windows.Forms.ComboBox();
            this.label43 = new System.Windows.Forms.Label();
            this.cbType = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbGoodsType = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.cmdTypeAdd);
            this.groupBox1.Controls.Add(this.cmdGroupClassAdd);
            this.groupBox1.Controls.Add(this.label44);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.cbGroupClass);
            this.groupBox1.Controls.Add(this.label43);
            this.groupBox1.Controls.Add(this.cbType);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cbGoodsType);
            this.groupBox1.Location = new System.Drawing.Point(10, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(513, 230);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // cmdTypeAdd
            // 
            this.cmdTypeAdd.Location = new System.Drawing.Point(452, 93);
            this.cmdTypeAdd.Name = "cmdTypeAdd";
            this.cmdTypeAdd.Size = new System.Drawing.Size(34, 26);
            this.cmdTypeAdd.TabIndex = 121;
            this.cmdTypeAdd.Text = "...";
            this.cmdTypeAdd.UseVisualStyleBackColor = true;
            // 
            // cmdGroupClassAdd
            // 
            this.cmdGroupClassAdd.Location = new System.Drawing.Point(452, 58);
            this.cmdGroupClassAdd.Name = "cmdGroupClassAdd";
            this.cmdGroupClassAdd.Size = new System.Drawing.Size(34, 26);
            this.cmdGroupClassAdd.TabIndex = 119;
            this.cmdGroupClassAdd.Text = "...";
            this.cmdGroupClassAdd.UseVisualStyleBackColor = true;
            // 
            // label44
            // 
            this.label44.AutoSize = true;
            this.label44.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label44.Location = new System.Drawing.Point(27, 132);
            this.label44.Name = "label44";
            this.label44.Size = new System.Drawing.Size(71, 18);
            this.label44.TabIndex = 127;
            this.label44.Text = "คุณลักษณะ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label8.Location = new System.Drawing.Point(27, 61);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(81, 18);
            this.label8.TabIndex = 126;
            this.label8.Text = "กลุ่ม ประเภท";
            // 
            // cbGroupClass
            // 
            this.cbGroupClass.DisplayMember = "groupTitle";
            this.cbGroupClass.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbGroupClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.cbGroupClass.FormattingEnabled = true;
            this.cbGroupClass.Location = new System.Drawing.Point(125, 60);
            this.cbGroupClass.Name = "cbGroupClass";
            this.cbGroupClass.Size = new System.Drawing.Size(321, 24);
            this.cbGroupClass.TabIndex = 118;
            this.cbGroupClass.ValueMember = "groupID";
            // 
            // label43
            // 
            this.label43.AutoSize = true;
            this.label43.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label43.Location = new System.Drawing.Point(27, 96);
            this.label43.Name = "label43";
            this.label43.Size = new System.Drawing.Size(33, 18);
            this.label43.TabIndex = 125;
            this.label43.Text = "ชนิด";
            // 
            // cbType
            // 
            this.cbType.DisplayMember = "typeTitle";
            this.cbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.cbType.FormattingEnabled = true;
            this.cbType.Location = new System.Drawing.Point(125, 95);
            this.cbType.Name = "cbType";
            this.cbType.Size = new System.Drawing.Size(321, 24);
            this.cbType.TabIndex = 120;
            this.cbType.ValueMember = "typeID";
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
            this.cbGoodsType.DisplayMember = "goodsType";
            this.cbGoodsType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbGoodsType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.cbGoodsType.FormattingEnabled = true;
            this.cbGoodsType.Location = new System.Drawing.Point(125, 26);
            this.cbGoodsType.Name = "cbGoodsType";
            this.cbGoodsType.Size = new System.Drawing.Size(234, 24);
            this.cbGoodsType.TabIndex = 117;
            this.cbGoodsType.ValueMember = "goodsTypeID";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.textBox1.Location = new System.Drawing.Point(125, 132);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(361, 22);
            this.textBox1.TabIndex = 128;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(329, 180);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(71, 28);
            this.button1.TabIndex = 129;
            this.button1.Text = "บันทึก";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(415, 180);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(71, 28);
            this.button2.TabIndex = 130;
            this.button2.Text = "ยกเลิก";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // frmAddDescription
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(536, 257);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmAddDescription";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "เพิ่มคุณลักษณะครุภัณฑ์";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button cmdTypeAdd;
        private System.Windows.Forms.Button cmdGroupClassAdd;
        private System.Windows.Forms.Label label44;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbGroupClass;
        private System.Windows.Forms.Label label43;
        private System.Windows.Forms.ComboBox cbType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbGoodsType;
    }
}