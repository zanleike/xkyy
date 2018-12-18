namespace NursingManage.Win.ZhiLiangKongZhi
{
    partial class FrmZhiKongJianChaQueRenEdit
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.txtJianChaRenYuan = new Framework.WinCommon.Controls.ZCTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.zcTextBox1 = new Framework.WinCommon.Controls.ZCTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.zcTextBox2 = new Framework.WinCommon.Controls.ZCTextBox();
            this.txtGaiJinShuoMing = new Framework.WinCommon.Controls.ZCTextBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.dcm1 = new Framework.WinCommon.Components.DCM(this.components);
            this.txtYUANYINFENXI = new Framework.WinCommon.Controls.ZCTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvJieGuo = new Framework.WinCommon.Controls.ZCDataGridView();
            this.col_BIAOZHUNLEIBIE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_LEIXING1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_LEIXING2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_BIAOZHUN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_JIANCHAJIEGUO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtZhengGaiQingKuang = new Framework.WinCommon.Controls.ZCTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvJieGuo)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 15);
            this.label1.TabIndex = 42;
            this.label1.Text = "检查人员：";
            // 
            // txtJianChaRenYuan
            // 
            this.txtJianChaRenYuan.EmptyTextTip = null;
            this.txtJianChaRenYuan.EmptyTextTipColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.txtJianChaRenYuan.EnterIsTab = false;
            this.dcm1.SetIsUse(this.txtJianChaRenYuan, true);
            this.txtJianChaRenYuan.Location = new System.Drawing.Point(115, 52);
            this.txtJianChaRenYuan.Name = "txtJianChaRenYuan";
            this.txtJianChaRenYuan.ReadOnly = true;
            this.txtJianChaRenYuan.Size = new System.Drawing.Size(597, 25);
            this.txtJianChaRenYuan.TabIndex = 43;
            this.dcm1.SetTagColumnName(this.txtJianChaRenYuan, null);
            this.dcm1.SetTextColumnName(this.txtJianChaRenYuan, "JianChaRenYuan");
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 15);
            this.label4.TabIndex = 46;
            this.label4.Text = "检查日期：";
            // 
            // zcTextBox1
            // 
            this.zcTextBox1.EmptyTextTip = null;
            this.zcTextBox1.EmptyTextTipColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.zcTextBox1.EnterIsTab = false;
            this.dcm1.SetIsUse(this.zcTextBox1, true);
            this.zcTextBox1.Location = new System.Drawing.Point(115, 23);
            this.zcTextBox1.Name = "zcTextBox1";
            this.zcTextBox1.ReadOnly = true;
            this.zcTextBox1.Size = new System.Drawing.Size(199, 25);
            this.zcTextBox1.TabIndex = 43;
            this.dcm1.SetTagColumnName(this.zcTextBox1, null);
            this.zcTextBox1.Text = "2017-01-01 至 2017-01-31";
            this.dcm1.SetTextColumnName(this.zcTextBox1, "JiHuaShiJian");
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 212);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 15);
            this.label2.TabIndex = 46;
            this.label2.Text = "改进措施：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(319, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 15);
            this.label3.TabIndex = 48;
            this.label3.Text = "限期整改日期：";
            // 
            // zcTextBox2
            // 
            this.zcTextBox2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.zcTextBox2.EmptyTextTip = null;
            this.zcTextBox2.EmptyTextTipColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.zcTextBox2.EnterIsTab = false;
            this.dcm1.SetIsUse(this.zcTextBox2, true);
            this.zcTextBox2.Location = new System.Drawing.Point(433, 21);
            this.zcTextBox2.Name = "zcTextBox2";
            this.zcTextBox2.ReadOnly = true;
            this.zcTextBox2.Size = new System.Drawing.Size(153, 25);
            this.zcTextBox2.TabIndex = 43;
            this.dcm1.SetTagColumnName(this.zcTextBox2, null);
            this.zcTextBox2.Text = "2017-01-01";
            this.dcm1.SetTextColumnName(this.zcTextBox2, "GaiJinShiJian_XianQi");
            // 
            // txtGaiJinShuoMing
            // 
            this.txtGaiJinShuoMing.EmptyTextTip = null;
            this.txtGaiJinShuoMing.EmptyTextTipColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.txtGaiJinShuoMing.EnterIsTab = false;
            this.dcm1.SetIsUse(this.txtGaiJinShuoMing, true);
            this.txtGaiJinShuoMing.Location = new System.Drawing.Point(115, 206);
            this.txtGaiJinShuoMing.Multiline = true;
            this.txtGaiJinShuoMing.Name = "txtGaiJinShuoMing";
            this.txtGaiJinShuoMing.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtGaiJinShuoMing.Size = new System.Drawing.Size(597, 117);
            this.txtGaiJinShuoMing.TabIndex = 1;
            this.dcm1.SetTagColumnName(this.txtGaiJinShuoMing, null);
            this.dcm1.SetTextColumnName(this.txtGaiJinShuoMing, "GaiJinShuoMing");
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(863, 123);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 42);
            this.btnOK.TabIndex = 2;
            this.btnOK.Text = "确认";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(863, 198);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 42);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // txtYUANYINFENXI
            // 
            this.txtYUANYINFENXI.EmptyTextTip = null;
            this.txtYUANYINFENXI.EmptyTextTipColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.txtYUANYINFENXI.EnterIsTab = false;
            this.dcm1.SetIsUse(this.txtYUANYINFENXI, true);
            this.txtYUANYINFENXI.Location = new System.Drawing.Point(115, 83);
            this.txtYUANYINFENXI.Multiline = true;
            this.txtYUANYINFENXI.Name = "txtYUANYINFENXI";
            this.txtYUANYINFENXI.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtYUANYINFENXI.Size = new System.Drawing.Size(597, 117);
            this.txtYUANYINFENXI.TabIndex = 0;
            this.dcm1.SetTagColumnName(this.txtYUANYINFENXI, null);
            this.dcm1.SetTextColumnName(this.txtYUANYINFENXI, "YUANYINFENXI");
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 88);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 15);
            this.label5.TabIndex = 46;
            this.label5.Text = "原因分析：";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnOK);
            this.panel1.Controls.Add(this.txtJianChaRenYuan);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtZhengGaiQingKuang);
            this.panel1.Controls.Add(this.txtGaiJinShuoMing);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtYUANYINFENXI);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.zcTextBox1);
            this.panel1.Controls.Add(this.zcTextBox2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 237);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(987, 450);
            this.panel1.TabIndex = 49;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvJieGuo);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(987, 237);
            this.groupBox1.TabIndex = 50;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "检查内容结果";
            // 
            // dgvJieGuo
            // 
            this.dgvJieGuo.AllowUserToAddRows = false;
            this.dgvJieGuo.AllowUserToDeleteRows = false;
            this.dgvJieGuo.AllowUserToResizeRows = false;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Control;
            this.dgvJieGuo.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle11;
            this.dgvJieGuo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvJieGuo.BackgroundColor = System.Drawing.Color.Snow;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvJieGuo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.dgvJieGuo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvJieGuo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_BIAOZHUNLEIBIE,
            this.col_LEIXING1,
            this.col_LEIXING2,
            this.col_BIAOZHUN,
            this.col_JIANCHAJIEGUO});
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvJieGuo.DefaultCellStyle = dataGridViewCellStyle13;
            this.dgvJieGuo.DisplayRowCount = true;
            this.dgvJieGuo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvJieGuo.IsKeepOldSeldected = true;
            this.dgvJieGuo.Location = new System.Drawing.Point(3, 21);
            this.dgvJieGuo.MultiSelect = false;
            this.dgvJieGuo.Name = "dgvJieGuo";
            this.dgvJieGuo.ReadOnly = true;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvJieGuo.RowHeadersDefaultCellStyle = dataGridViewCellStyle14;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvJieGuo.RowsDefaultCellStyle = dataGridViewCellStyle15;
            this.dgvJieGuo.RowTemplate.Height = 23;
            this.dgvJieGuo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvJieGuo.Size = new System.Drawing.Size(981, 213);
            this.dgvJieGuo.TabIndex = 41;
            this.dgvJieGuo.UseControlStyle = true;
            // 
            // col_BIAOZHUNLEIBIE
            // 
            this.col_BIAOZHUNLEIBIE.DataPropertyName = "BIAOZHUNLEIBIE";
            this.col_BIAOZHUNLEIBIE.HeaderText = "标准类型";
            this.col_BIAOZHUNLEIBIE.Name = "col_BIAOZHUNLEIBIE";
            this.col_BIAOZHUNLEIBIE.ReadOnly = true;
            this.col_BIAOZHUNLEIBIE.Width = 92;
            // 
            // col_LEIXING1
            // 
            this.col_LEIXING1.DataPropertyName = "LEIXING1";
            this.col_LEIXING1.HeaderText = "一级类型";
            this.col_LEIXING1.Name = "col_LEIXING1";
            this.col_LEIXING1.ReadOnly = true;
            this.col_LEIXING1.Width = 92;
            // 
            // col_LEIXING2
            // 
            this.col_LEIXING2.DataPropertyName = "LEIXING2";
            this.col_LEIXING2.HeaderText = "二级类型";
            this.col_LEIXING2.Name = "col_LEIXING2";
            this.col_LEIXING2.ReadOnly = true;
            this.col_LEIXING2.Width = 92;
            // 
            // col_BIAOZHUN
            // 
            this.col_BIAOZHUN.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.col_BIAOZHUN.DataPropertyName = "BIAOZHUN";
            this.col_BIAOZHUN.HeaderText = "检查问题项";
            this.col_BIAOZHUN.Name = "col_BIAOZHUN";
            this.col_BIAOZHUN.ReadOnly = true;
            this.col_BIAOZHUN.Width = 150;
            // 
            // col_JIANCHAJIEGUO
            // 
            this.col_JIANCHAJIEGUO.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.col_JIANCHAJIEGUO.DataPropertyName = "JIANCHAJIEGUO";
            this.col_JIANCHAJIEGUO.HeaderText = "问题项说明";
            this.col_JIANCHAJIEGUO.Name = "col_JIANCHAJIEGUO";
            this.col_JIANCHAJIEGUO.ReadOnly = true;
            this.col_JIANCHAJIEGUO.Width = 200;
            // 
            // txtZhengGaiQingKuang
            // 
            this.txtZhengGaiQingKuang.EmptyTextTip = null;
            this.txtZhengGaiQingKuang.EmptyTextTipColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.txtZhengGaiQingKuang.EnterIsTab = false;
            this.dcm1.SetIsUse(this.txtZhengGaiQingKuang, true);
            this.txtZhengGaiQingKuang.Location = new System.Drawing.Point(115, 332);
            this.txtZhengGaiQingKuang.Multiline = true;
            this.txtZhengGaiQingKuang.Name = "txtZhengGaiQingKuang";
            this.txtZhengGaiQingKuang.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtZhengGaiQingKuang.Size = new System.Drawing.Size(597, 117);
            this.txtZhengGaiQingKuang.TabIndex = 1;
            this.dcm1.SetTagColumnName(this.txtZhengGaiQingKuang, null);
            this.dcm1.SetTextColumnName(this.txtZhengGaiQingKuang, "ZhengGaiQingKuang");
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(27, 335);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 15);
            this.label6.TabIndex = 46;
            this.label6.Text = "整改情况：";
            // 
            // FrmZhiKongJianChaQueRenEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(987, 687);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.KeyPreview = true;
            this.Name = "FrmZhiKongJianChaQueRenEdit";
            this.Text = "质控检查确认";
            this.Load += new System.EventHandler(this.FrmZhiKongJianChaQueRenEdit_Load);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvJieGuo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Framework.WinCommon.Controls.ZCTextBox txtJianChaRenYuan;
        private System.Windows.Forms.Label label4;
        private Framework.WinCommon.Controls.ZCTextBox zcTextBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private Framework.WinCommon.Controls.ZCTextBox zcTextBox2;
        private Framework.WinCommon.Controls.ZCTextBox txtGaiJinShuoMing;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private Framework.WinCommon.Components.DCM dcm1;
        private Framework.WinCommon.Controls.ZCTextBox txtYUANYINFENXI;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private Framework.WinCommon.Controls.ZCDataGridView dgvJieGuo;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_BIAOZHUNLEIBIE;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_LEIXING1;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_LEIXING2;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_BIAOZHUN;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_JIANCHAJIEGUO;
        private Framework.WinCommon.Controls.ZCTextBox txtZhengGaiQingKuang;
        private System.Windows.Forms.Label label6;
    }
}