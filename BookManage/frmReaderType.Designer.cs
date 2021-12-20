﻿namespace BookManage
{
    partial class frmReaderType
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReaderType));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbFirstRecord = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbNextRecord = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbLastRecord = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel3 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbFinaRecord = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel4 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbAdd = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel5 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbUpdate = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel6 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbDelate = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel7 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbBack = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel8 = new System.Windows.Forms.ToolStripLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtrdType = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTypeName = new System.Windows.Forms.TextBox();
            this.txtCanContinueTimes = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCanLendDay = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPunishRate = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCanLendQty = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtDateValid = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dgvReaderType = new System.Windows.Forms.DataGridView();
            this.labImformation = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReaderType)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbFirstRecord,
            this.toolStripLabel1,
            this.toolStripSeparator1,
            this.tsbNextRecord,
            this.toolStripLabel2,
            this.toolStripSeparator2,
            this.tsbLastRecord,
            this.toolStripLabel3,
            this.toolStripSeparator3,
            this.tsbFinaRecord,
            this.toolStripLabel4,
            this.toolStripSeparator4,
            this.tsbAdd,
            this.toolStripLabel5,
            this.toolStripSeparator5,
            this.tsbUpdate,
            this.toolStripLabel6,
            this.toolStripSeparator6,
            this.tsbDelate,
            this.toolStripLabel7,
            this.toolStripSeparator7,
            this.tsbBack,
            this.toolStripLabel8});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbFirstRecord
            // 
            this.tsbFirstRecord.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbFirstRecord.Image = ((System.Drawing.Image)(resources.GetObject("tsbFirstRecord.Image")));
            this.tsbFirstRecord.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbFirstRecord.Name = "tsbFirstRecord";
            this.tsbFirstRecord.Size = new System.Drawing.Size(23, 22);
            this.tsbFirstRecord.Text = "toolStripButton1";
            this.tsbFirstRecord.Click += new System.EventHandler(this.tsbFirstRecord_Click);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(44, 22);
            this.toolStripLabel1.Text = "首记录";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // tsbNextRecord
            // 
            this.tsbNextRecord.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbNextRecord.Image = ((System.Drawing.Image)(resources.GetObject("tsbNextRecord.Image")));
            this.tsbNextRecord.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbNextRecord.Name = "tsbNextRecord";
            this.tsbNextRecord.Size = new System.Drawing.Size(23, 22);
            this.tsbNextRecord.Text = "toolStripButton2";
            this.tsbNextRecord.Click += new System.EventHandler(this.tsbNextRecord_Click);
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(44, 22);
            this.toolStripLabel2.Text = "下记录";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // tsbLastRecord
            // 
            this.tsbLastRecord.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbLastRecord.Image = ((System.Drawing.Image)(resources.GetObject("tsbLastRecord.Image")));
            this.tsbLastRecord.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbLastRecord.Name = "tsbLastRecord";
            this.tsbLastRecord.Size = new System.Drawing.Size(23, 22);
            this.tsbLastRecord.Text = "toolStripButton3";
            this.tsbLastRecord.Click += new System.EventHandler(this.tsbLastRecord_Click);
            // 
            // toolStripLabel3
            // 
            this.toolStripLabel3.Name = "toolStripLabel3";
            this.toolStripLabel3.Size = new System.Drawing.Size(44, 22);
            this.toolStripLabel3.Text = "上记录";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // tsbFinaRecord
            // 
            this.tsbFinaRecord.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbFinaRecord.Image = ((System.Drawing.Image)(resources.GetObject("tsbFinaRecord.Image")));
            this.tsbFinaRecord.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbFinaRecord.Name = "tsbFinaRecord";
            this.tsbFinaRecord.Size = new System.Drawing.Size(23, 22);
            this.tsbFinaRecord.Text = "toolStripButton4";
            this.tsbFinaRecord.Click += new System.EventHandler(this.tsbFinaRecord_Click);
            // 
            // toolStripLabel4
            // 
            this.toolStripLabel4.Name = "toolStripLabel4";
            this.toolStripLabel4.Size = new System.Drawing.Size(44, 22);
            this.toolStripLabel4.Text = "尾记录";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // tsbAdd
            // 
            this.tsbAdd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbAdd.Image = ((System.Drawing.Image)(resources.GetObject("tsbAdd.Image")));
            this.tsbAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbAdd.Name = "tsbAdd";
            this.tsbAdd.Size = new System.Drawing.Size(23, 22);
            this.tsbAdd.Text = "toolStripButton5";
            this.tsbAdd.Click += new System.EventHandler(this.tsbAdd_Click);
            // 
            // toolStripLabel5
            // 
            this.toolStripLabel5.Name = "toolStripLabel5";
            this.toolStripLabel5.Size = new System.Drawing.Size(32, 22);
            this.toolStripLabel5.Text = "添加";
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 25);
            // 
            // tsbUpdate
            // 
            this.tsbUpdate.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbUpdate.Image = ((System.Drawing.Image)(resources.GetObject("tsbUpdate.Image")));
            this.tsbUpdate.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbUpdate.Name = "tsbUpdate";
            this.tsbUpdate.Size = new System.Drawing.Size(23, 22);
            this.tsbUpdate.Text = "toolStripButton6";
            this.tsbUpdate.Click += new System.EventHandler(this.tsbUpdate_Click);
            // 
            // toolStripLabel6
            // 
            this.toolStripLabel6.Name = "toolStripLabel6";
            this.toolStripLabel6.Size = new System.Drawing.Size(32, 22);
            this.toolStripLabel6.Text = "修改";
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 25);
            // 
            // tsbDelate
            // 
            this.tsbDelate.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbDelate.Image = ((System.Drawing.Image)(resources.GetObject("tsbDelate.Image")));
            this.tsbDelate.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbDelate.Name = "tsbDelate";
            this.tsbDelate.Size = new System.Drawing.Size(23, 22);
            this.tsbDelate.Text = "toolStripButton7";
            this.tsbDelate.Click += new System.EventHandler(this.tsbDelate_Click);
            // 
            // toolStripLabel7
            // 
            this.toolStripLabel7.Name = "toolStripLabel7";
            this.toolStripLabel7.Size = new System.Drawing.Size(32, 22);
            this.toolStripLabel7.Text = "删除";
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(6, 25);
            // 
            // tsbBack
            // 
            this.tsbBack.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbBack.Image = ((System.Drawing.Image)(resources.GetObject("tsbBack.Image")));
            this.tsbBack.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbBack.Name = "tsbBack";
            this.tsbBack.Size = new System.Drawing.Size(23, 22);
            this.tsbBack.Text = "toolStripButton8";
            this.tsbBack.Click += new System.EventHandler(this.tsbBack_Click);
            // 
            // toolStripLabel8
            // 
            this.toolStripLabel8.Name = "toolStripLabel8";
            this.toolStripLabel8.Size = new System.Drawing.Size(32, 22);
            this.toolStripLabel8.Text = "返回";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(68, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "读者类别";
            // 
            // txtrdType
            // 
            this.txtrdType.Location = new System.Drawing.Point(127, 44);
            this.txtrdType.Name = "txtrdType";
            this.txtrdType.Size = new System.Drawing.Size(100, 21);
            this.txtrdType.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(68, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "类型名称";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(56, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 1;
            this.label3.Text = "可续借次数";
            // 
            // txtTypeName
            // 
            this.txtTypeName.Location = new System.Drawing.Point(127, 78);
            this.txtTypeName.Name = "txtTypeName";
            this.txtTypeName.Size = new System.Drawing.Size(100, 21);
            this.txtTypeName.TabIndex = 2;
            // 
            // txtCanContinueTimes
            // 
            this.txtCanContinueTimes.Location = new System.Drawing.Point(127, 115);
            this.txtCanContinueTimes.Name = "txtCanContinueTimes";
            this.txtCanContinueTimes.Size = new System.Drawing.Size(100, 21);
            this.txtCanContinueTimes.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(249, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 1;
            this.label4.Text = "可借书天数";
            // 
            // txtCanLendDay
            // 
            this.txtCanLendDay.Location = new System.Drawing.Point(320, 50);
            this.txtCanLendDay.Name = "txtCanLendDay";
            this.txtCanLendDay.Size = new System.Drawing.Size(100, 21);
            this.txtCanLendDay.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(273, 105);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 12);
            this.label5.TabIndex = 1;
            this.label5.Text = "罚款率";
            // 
            // txtPunishRate
            // 
            this.txtPunishRate.Location = new System.Drawing.Point(320, 102);
            this.txtPunishRate.Name = "txtPunishRate";
            this.txtPunishRate.Size = new System.Drawing.Size(100, 21);
            this.txtPunishRate.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(454, 53);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 12);
            this.label6.TabIndex = 1;
            this.label6.Text = "可借书数量";
            // 
            // txtCanLendQty
            // 
            this.txtCanLendQty.Location = new System.Drawing.Point(525, 50);
            this.txtCanLendQty.Name = "txtCanLendQty";
            this.txtCanLendQty.Size = new System.Drawing.Size(100, 21);
            this.txtCanLendQty.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(454, 105);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 12);
            this.label7.TabIndex = 1;
            this.label7.Text = "证件有效期";
            // 
            // txtDateValid
            // 
            this.txtDateValid.Location = new System.Drawing.Point(525, 102);
            this.txtDateValid.Name = "txtDateValid";
            this.txtDateValid.Size = new System.Drawing.Size(100, 21);
            this.txtDateValid.TabIndex = 2;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(631, 105);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(17, 12);
            this.label8.TabIndex = 1;
            this.label8.Text = "年";
            // 
            // dgvReaderType
            // 
            this.dgvReaderType.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReaderType.Location = new System.Drawing.Point(23, 142);
            this.dgvReaderType.Name = "dgvReaderType";
            this.dgvReaderType.RowTemplate.Height = 23;
            this.dgvReaderType.Size = new System.Drawing.Size(749, 260);
            this.dgvReaderType.TabIndex = 3;
            this.dgvReaderType.SelectionChanged += new System.EventHandler(this.dgvReaderType_SelectionChanged);
            // 
            // labImformation
            // 
            this.labImformation.AutoSize = true;
            this.labImformation.ForeColor = System.Drawing.Color.Red;
            this.labImformation.Location = new System.Drawing.Point(21, 419);
            this.labImformation.Name = "labImformation";
            this.labImformation.Size = new System.Drawing.Size(41, 12);
            this.labImformation.TabIndex = 4;
            this.labImformation.Text = "状态：";
            // 
            // frmReaderType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labImformation);
            this.Controls.Add(this.dgvReaderType);
            this.Controls.Add(this.txtCanContinueTimes);
            this.Controls.Add(this.txtTypeName);
            this.Controls.Add(this.txtDateValid);
            this.Controls.Add(this.txtPunishRate);
            this.Controls.Add(this.txtCanLendQty);
            this.Controls.Add(this.txtCanLendDay);
            this.Controls.Add(this.txtrdType);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "frmReaderType";
            this.Text = "frmReaderType";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReaderType)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbFirstRecord;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tsbNextRecord;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton tsbLastRecord;
        private System.Windows.Forms.ToolStripLabel toolStripLabel3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton tsbFinaRecord;
        private System.Windows.Forms.ToolStripLabel toolStripLabel4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton tsbAdd;
        private System.Windows.Forms.ToolStripLabel toolStripLabel5;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripButton tsbUpdate;
        private System.Windows.Forms.ToolStripLabel toolStripLabel6;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripButton tsbDelate;
        private System.Windows.Forms.ToolStripLabel toolStripLabel7;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripButton tsbBack;
        private System.Windows.Forms.ToolStripLabel toolStripLabel8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtrdType;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTypeName;
        private System.Windows.Forms.TextBox txtCanContinueTimes;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCanLendDay;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPunishRate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtCanLendQty;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtDateValid;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dgvReaderType;
        private System.Windows.Forms.Label labImformation;
    }
}
