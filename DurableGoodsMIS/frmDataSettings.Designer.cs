namespace DurableGoodsMIS
{
    partial class frmORGSettings
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
            this.cmdSave = new System.Windows.Forms.Button();
            this.cmdCancle = new System.Windows.Forms.Button();
            this.txtPosition = new System.Windows.Forms.TextBox();
            this.txtBoss = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtSubOrg = new System.Windows.Forms.TextBox();
            this.txtORG = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbOrganizationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.durableGoodsMISDataSet = new DurableGoodsMIS.DurableGoodsMISDataSet();
            this.tbOrganizationTableAdapter = new DurableGoodsMIS.DurableGoodsMISDataSetTableAdapters.tbOrganizationTableAdapter();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbOrganizationBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.durableGoodsMISDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cmdSave);
            this.groupBox1.Controls.Add(this.cmdCancle);
            this.groupBox1.Controls.Add(this.txtPosition);
            this.groupBox1.Controls.Add(this.txtBoss);
            this.groupBox1.Controls.Add(this.txtAddress);
            this.groupBox1.Controls.Add(this.txtSubOrg);
            this.groupBox1.Controls.Add(this.txtORG);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(425, 272);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            // 
            // cmdSave
            // 
            this.cmdSave.Location = new System.Drawing.Point(248, 225);
            this.cmdSave.Name = "cmdSave";
            this.cmdSave.Size = new System.Drawing.Size(66, 27);
            this.cmdSave.TabIndex = 10;
            this.cmdSave.Text = "บันทึก";
            this.cmdSave.UseVisualStyleBackColor = true;
            this.cmdSave.Click += new System.EventHandler(this.cmdSave_Click);
            // 
            // cmdCancle
            // 
            this.cmdCancle.Location = new System.Drawing.Point(332, 225);
            this.cmdCancle.Name = "cmdCancle";
            this.cmdCancle.Size = new System.Drawing.Size(66, 27);
            this.cmdCancle.TabIndex = 11;
            this.cmdCancle.Text = "ยกเลิก";
            this.cmdCancle.UseVisualStyleBackColor = true;
            this.cmdCancle.Click += new System.EventHandler(this.cmdCancle_Click);
            // 
            // txtPosition
            // 
            this.txtPosition.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbOrganizationBindingSource, "position", true));
            this.txtPosition.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.txtPosition.Location = new System.Drawing.Point(123, 182);
            this.txtPosition.Name = "txtPosition";
            this.txtPosition.Size = new System.Drawing.Size(275, 22);
            this.txtPosition.TabIndex = 9;
            // 
            // txtBoss
            // 
            this.txtBoss.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbOrganizationBindingSource, "boss", true));
            this.txtBoss.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.txtBoss.Location = new System.Drawing.Point(123, 144);
            this.txtBoss.Name = "txtBoss";
            this.txtBoss.Size = new System.Drawing.Size(275, 22);
            this.txtBoss.TabIndex = 8;
            // 
            // txtAddress
            // 
            this.txtAddress.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbOrganizationBindingSource, "address", true));
            this.txtAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.txtAddress.Location = new System.Drawing.Point(123, 107);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(275, 22);
            this.txtAddress.TabIndex = 7;
            // 
            // txtSubOrg
            // 
            this.txtSubOrg.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbOrganizationBindingSource, "orgSector", true));
            this.txtSubOrg.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.txtSubOrg.Location = new System.Drawing.Point(123, 68);
            this.txtSubOrg.Name = "txtSubOrg";
            this.txtSubOrg.Size = new System.Drawing.Size(275, 22);
            this.txtSubOrg.TabIndex = 6;
            // 
            // txtORG
            // 
            this.txtORG.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbOrganizationBindingSource, "organization", true));
            this.txtORG.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.txtORG.Location = new System.Drawing.Point(123, 29);
            this.txtORG.Name = "txtORG";
            this.txtORG.Size = new System.Drawing.Size(275, 22);
            this.txtORG.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label1.Location = new System.Drawing.Point(17, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 16);
            this.label1.TabIndex = 12;
            this.label1.Text = "ชื่อส่วนราชการ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label2.Location = new System.Drawing.Point(17, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 16);
            this.label2.TabIndex = 13;
            this.label2.Text = "ชื่อหน่วยงาน";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label3.Location = new System.Drawing.Point(17, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 16);
            this.label3.TabIndex = 14;
            this.label3.Text = "ที่ตั้งหน่วยงาน";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label4.Location = new System.Drawing.Point(17, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 16);
            this.label4.TabIndex = 15;
            this.label4.Text = "ชื่อหัวหน้าหน่วยงาน";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label5.Location = new System.Drawing.Point(19, 185);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 16);
            this.label5.TabIndex = 16;
            this.label5.Text = "ตำแหน่ง";
            // 
            // tbOrganizationBindingSource
            // 
            this.tbOrganizationBindingSource.DataMember = "tbOrganization";
            this.tbOrganizationBindingSource.DataSource = this.durableGoodsMISDataSet;
            // 
            // durableGoodsMISDataSet
            // 
            this.durableGoodsMISDataSet.DataSetName = "DurableGoodsMISDataSet";
            this.durableGoodsMISDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbOrganizationTableAdapter
            // 
            this.tbOrganizationTableAdapter.ClearBeforeFill = true;
            // 
            // frmORGSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(449, 295);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmORGSettings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ตั้งค่าหน่วยงาน";
            this.Load += new System.EventHandler(this.frmORGSettings_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbOrganizationBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.durableGoodsMISDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DurableGoodsMISDataSetTableAdapters.tbOrganizationTableAdapter tbOrganizationTableAdapter;
        private System.Windows.Forms.BindingSource tbOrganizationBindingSource;
        private DurableGoodsMISDataSet durableGoodsMISDataSet;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button cmdSave;
        private System.Windows.Forms.Button cmdCancle;
        private System.Windows.Forms.TextBox txtPosition;
        private System.Windows.Forms.TextBox txtBoss;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtSubOrg;
        private System.Windows.Forms.TextBox txtORG;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
    }
}