namespace NursingManage.Win.PeiXunGuanLi
{
    partial class FrmVPingFenJieGuo
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.toolStripTop1 = new System.Windows.Forms.ToolStrip();
            this.tsBtnClose = new System.Windows.Forms.ToolStripButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.dgv = new Framework.WinCommon.Controls.ZCDataGridView();
            this.col_ShiFouZhengQue = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.col_DaTi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_ShiTiXuhao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_FENLEI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_BIANHAO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_FenShu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_NANYICHENGDU = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_LEIXING = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_NEIRONG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_DaAn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_XiangMuA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_XiangMuB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_XiangMuC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_XiangMuD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_XiangMuE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_XiangMuF = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStripTop1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStripTop1
            // 
            this.toolStripTop1.AutoSize = false;
            this.toolStripTop1.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.toolStripTop1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsBtnClose});
            this.toolStripTop1.Location = new System.Drawing.Point(0, 0);
            this.toolStripTop1.Name = "toolStripTop1";
            this.toolStripTop1.Size = new System.Drawing.Size(732, 38);
            this.toolStripTop1.TabIndex = 36;
            this.toolStripTop1.Text = "toolStrip2";
            // 
            // tsBtnClose
            // 
            this.tsBtnClose.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsBtnClose.BackColor = System.Drawing.Color.Transparent;
            this.tsBtnClose.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tsBtnClose.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.tsBtnClose.Image = global::NursingManage.Win.Properties.Resources.exit;
            this.tsBtnClose.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsBtnClose.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnClose.Margin = new System.Windows.Forms.Padding(0, 1, 1, 2);
            this.tsBtnClose.Name = "tsBtnClose";
            this.tsBtnClose.Size = new System.Drawing.Size(82, 35);
            this.tsBtnClose.Text = "退出";
            this.tsBtnClose.Click += new System.EventHandler(this.tsBtnClose_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 372);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(732, 22);
            this.statusStrip1.TabIndex = 37;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AllowUserToDeleteRows = false;
            this.dgv.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            this.dgv.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgv.BackgroundColor = System.Drawing.Color.Snow;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_ShiFouZhengQue,
            this.col_DaTi,
            this.col_ShiTiXuhao,
            this.col_FENLEI,
            this.col_BIANHAO,
            this.col_FenShu,
            this.col_NANYICHENGDU,
            this.col_LEIXING,
            this.col_NEIRONG,
            this.col_DaAn,
            this.col_XiangMuA,
            this.col_XiangMuB,
            this.col_XiangMuC,
            this.col_XiangMuD,
            this.col_XiangMuE,
            this.col_XiangMuF});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgv.DisplayRowCount = true;
            this.dgv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv.Location = new System.Drawing.Point(0, 38);
            this.dgv.MultiSelect = false;
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgv.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgv.RowTemplate.Height = 23;
            this.dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgv.Size = new System.Drawing.Size(732, 334);
            this.dgv.TabIndex = 38;
            this.dgv.UseControlStyle = true;
            // 
            // col_ShiFouZhengQue
            // 
            this.col_ShiFouZhengQue.DataPropertyName = "ShiFouZhengQue";
            this.col_ShiFouZhengQue.HeaderText = "是否正确";
            this.col_ShiFouZhengQue.Name = "col_ShiFouZhengQue";
            this.col_ShiFouZhengQue.ReadOnly = true;
            this.col_ShiFouZhengQue.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.col_ShiFouZhengQue.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.col_ShiFouZhengQue.Width = 92;
            // 
            // col_DaTi
            // 
            this.col_DaTi.DataPropertyName = "DaTi";
            this.col_DaTi.HeaderText = "答题";
            this.col_DaTi.Name = "col_DaTi";
            this.col_DaTi.ReadOnly = true;
            this.col_DaTi.Width = 62;
            // 
            // col_ShiTiXuhao
            // 
            this.col_ShiTiXuhao.DataPropertyName = "ShiTiXuhao";
            this.col_ShiTiXuhao.HeaderText = "试题序号";
            this.col_ShiTiXuhao.Name = "col_ShiTiXuhao";
            this.col_ShiTiXuhao.ReadOnly = true;
            this.col_ShiTiXuhao.Width = 92;
            // 
            // col_FENLEI
            // 
            this.col_FENLEI.DataPropertyName = "FENLEI";
            this.col_FENLEI.HeaderText = "试题分类";
            this.col_FENLEI.Name = "col_FENLEI";
            this.col_FENLEI.ReadOnly = true;
            this.col_FENLEI.Visible = false;
            this.col_FENLEI.Width = 78;
            // 
            // col_BIANHAO
            // 
            this.col_BIANHAO.DataPropertyName = "BIANHAO";
            this.col_BIANHAO.HeaderText = "编号";
            this.col_BIANHAO.Name = "col_BIANHAO";
            this.col_BIANHAO.ReadOnly = true;
            this.col_BIANHAO.Visible = false;
            this.col_BIANHAO.Width = 54;
            // 
            // col_FenShu
            // 
            this.col_FenShu.DataPropertyName = "FenShu";
            this.col_FenShu.HeaderText = "分数";
            this.col_FenShu.Name = "col_FenShu";
            this.col_FenShu.ReadOnly = true;
            this.col_FenShu.Width = 62;
            // 
            // col_NANYICHENGDU
            // 
            this.col_NANYICHENGDU.DataPropertyName = "NANYICHENGDU";
            this.col_NANYICHENGDU.HeaderText = "难易程度";
            this.col_NANYICHENGDU.Name = "col_NANYICHENGDU";
            this.col_NANYICHENGDU.ReadOnly = true;
            this.col_NANYICHENGDU.Visible = false;
            this.col_NANYICHENGDU.Width = 78;
            // 
            // col_LEIXING
            // 
            this.col_LEIXING.DataPropertyName = "LEIXING";
            this.col_LEIXING.HeaderText = "试题类型";
            this.col_LEIXING.Name = "col_LEIXING";
            this.col_LEIXING.ReadOnly = true;
            this.col_LEIXING.Width = 92;
            // 
            // col_NEIRONG
            // 
            this.col_NEIRONG.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.col_NEIRONG.DataPropertyName = "NEIRONG";
            this.col_NEIRONG.HeaderText = "试题内容";
            this.col_NEIRONG.Name = "col_NEIRONG";
            this.col_NEIRONG.ReadOnly = true;
            this.col_NEIRONG.Width = 300;
            // 
            // col_DaAn
            // 
            this.col_DaAn.DataPropertyName = "DaAn";
            this.col_DaAn.HeaderText = "正确答案";
            this.col_DaAn.Name = "col_DaAn";
            this.col_DaAn.ReadOnly = true;
            this.col_DaAn.Width = 92;
            // 
            // col_XiangMuA
            // 
            this.col_XiangMuA.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.col_XiangMuA.DataPropertyName = "XiangMuA";
            this.col_XiangMuA.HeaderText = "选项A";
            this.col_XiangMuA.Name = "col_XiangMuA";
            this.col_XiangMuA.ReadOnly = true;
            this.col_XiangMuA.Width = 120;
            // 
            // col_XiangMuB
            // 
            this.col_XiangMuB.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.col_XiangMuB.DataPropertyName = "XiangMuB";
            this.col_XiangMuB.HeaderText = "选项B";
            this.col_XiangMuB.Name = "col_XiangMuB";
            this.col_XiangMuB.ReadOnly = true;
            this.col_XiangMuB.Width = 120;
            // 
            // col_XiangMuC
            // 
            this.col_XiangMuC.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.col_XiangMuC.DataPropertyName = "XiangMuC";
            this.col_XiangMuC.HeaderText = "选项C";
            this.col_XiangMuC.Name = "col_XiangMuC";
            this.col_XiangMuC.ReadOnly = true;
            this.col_XiangMuC.Width = 120;
            // 
            // col_XiangMuD
            // 
            this.col_XiangMuD.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.col_XiangMuD.DataPropertyName = "XiangMuD";
            this.col_XiangMuD.HeaderText = "选项D";
            this.col_XiangMuD.Name = "col_XiangMuD";
            this.col_XiangMuD.ReadOnly = true;
            this.col_XiangMuD.Width = 120;
            // 
            // col_XiangMuE
            // 
            this.col_XiangMuE.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.col_XiangMuE.DataPropertyName = "XiangMuE";
            this.col_XiangMuE.HeaderText = "选项E";
            this.col_XiangMuE.Name = "col_XiangMuE";
            this.col_XiangMuE.ReadOnly = true;
            this.col_XiangMuE.Width = 120;
            // 
            // col_XiangMuF
            // 
            this.col_XiangMuF.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.col_XiangMuF.DataPropertyName = "XiangMuF";
            this.col_XiangMuF.HeaderText = "选项F";
            this.col_XiangMuF.Name = "col_XiangMuF";
            this.col_XiangMuF.ReadOnly = true;
            this.col_XiangMuF.Width = 120;
            // 
            // FrmVPingFenJieGuo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(732, 394);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStripTop1);
            this.KeyPreview = true;
            this.MaximizeBox = true;
            this.Name = "FrmVPingFenJieGuo";
            this.Text = "评分结果";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmVPingFenJieGuo_Load);
            this.Controls.SetChildIndex(this.toolStripTop1, 0);
            this.Controls.SetChildIndex(this.statusStrip1, 0);
            this.Controls.SetChildIndex(this.dgv, 0);
            this.toolStripTop1.ResumeLayout(false);
            this.toolStripTop1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.ToolStrip toolStripTop1;
        public System.Windows.Forms.ToolStripButton tsBtnClose;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private Framework.WinCommon.Controls.ZCDataGridView dgv;
        private System.Windows.Forms.DataGridViewCheckBoxColumn col_ShiFouZhengQue;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_DaTi;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_ShiTiXuhao;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_FENLEI;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_BIANHAO;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_FenShu;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_NANYICHENGDU;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_LEIXING;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_NEIRONG;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_DaAn;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_XiangMuA;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_XiangMuB;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_XiangMuC;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_XiangMuD;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_XiangMuE;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_XiangMuF;
    }
}