namespace NursingManage.Win.PeiXunGuanLi
{
    partial class FrmVPingFenMingXiChaKan
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.toolStripTop1 = new System.Windows.Forms.ToolStrip();
            this.tsbtnChaKanMingXi = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.tsTxtSearchValue = new System.Windows.Forms.ToolStripTextBox();
            this.tsBtnSearch = new System.Windows.Forms.ToolStripButton();
            this.tsBtnClose = new System.Windows.Forms.ToolStripButton();
            this.tsbtnADSearch = new System.Windows.Forms.ToolStripButton();
            this.tsbtnOutExcel = new System.Windows.Forms.ToolStripButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.ucPage = new Framework.WinCommon.Controls.UCPagingNavigation();
            this.dgv = new Framework.WinCommon.Controls.ZCDataGridView();
            this.col_KeShi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_JiHuaMingCheng = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_MuBan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_BianHao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_XingMing = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_FenShu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_PingFenRen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_PingFenShiJian = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_DaTi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStripTop1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStripTop1
            // 
            this.toolStripTop1.AutoSize = false;
            this.toolStripTop1.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.toolStripTop1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbtnChaKanMingXi,
            this.toolStripSeparator5,
            this.tsTxtSearchValue,
            this.tsBtnSearch,
            this.tsBtnClose,
            this.tsbtnADSearch,
            this.tsbtnOutExcel});
            this.toolStripTop1.Location = new System.Drawing.Point(0, 0);
            this.toolStripTop1.Name = "toolStripTop1";
            this.toolStripTop1.Size = new System.Drawing.Size(975, 48);
            this.toolStripTop1.TabIndex = 33;
            this.toolStripTop1.Text = "toolStrip2";
            // 
            // tsbtnChaKanMingXi
            // 
            this.tsbtnChaKanMingXi.BackColor = System.Drawing.Color.Transparent;
            this.tsbtnChaKanMingXi.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tsbtnChaKanMingXi.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.tsbtnChaKanMingXi.Image = global::NursingManage.Win.Properties.Resources.viewdetail;
            this.tsbtnChaKanMingXi.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbtnChaKanMingXi.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnChaKanMingXi.Name = "tsbtnChaKanMingXi";
            this.tsbtnChaKanMingXi.Size = new System.Drawing.Size(118, 45);
            this.tsbtnChaKanMingXi.Text = "查看试题";
            this.tsbtnChaKanMingXi.Click += new System.EventHandler(this.tsbtnChaKanMingXi_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 48);
            // 
            // tsTxtSearchValue
            // 
            this.tsTxtSearchValue.Name = "tsTxtSearchValue";
            this.tsTxtSearchValue.Size = new System.Drawing.Size(132, 48);
            this.tsTxtSearchValue.ToolTipText = "可输入回车进行搜索";
            this.tsTxtSearchValue.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tsTxtSearchValue_KeyDown);
            // 
            // tsBtnSearch
            // 
            this.tsBtnSearch.BackColor = System.Drawing.Color.Transparent;
            this.tsBtnSearch.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tsBtnSearch.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.tsBtnSearch.Image = global::NursingManage.Win.Properties.Resources.search;
            this.tsBtnSearch.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsBtnSearch.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnSearch.Name = "tsBtnSearch";
            this.tsBtnSearch.Size = new System.Drawing.Size(82, 45);
            this.tsBtnSearch.Text = "搜索";
            this.tsBtnSearch.Click += new System.EventHandler(this.tsBtnSearch_Click);
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
            this.tsBtnClose.Size = new System.Drawing.Size(82, 45);
            this.tsBtnClose.Text = "退出";
            this.tsBtnClose.Click += new System.EventHandler(this.tsBtnClose_Click);
            // 
            // tsbtnADSearch
            // 
            this.tsbtnADSearch.BackColor = System.Drawing.Color.Transparent;
            this.tsbtnADSearch.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tsbtnADSearch.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.tsbtnADSearch.Image = global::NursingManage.Win.Properties.Resources.search2;
            this.tsbtnADSearch.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbtnADSearch.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnADSearch.Name = "tsbtnADSearch";
            this.tsbtnADSearch.Size = new System.Drawing.Size(118, 45);
            this.tsbtnADSearch.Text = "高级查询";
            this.tsbtnADSearch.Click += new System.EventHandler(this.tsbtnADSearch_Click);
            // 
            // tsbtnOutExcel
            // 
            this.tsbtnOutExcel.BackColor = System.Drawing.Color.Transparent;
            this.tsbtnOutExcel.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tsbtnOutExcel.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.tsbtnOutExcel.Image = global::NursingManage.Win.Properties.Resources.excel;
            this.tsbtnOutExcel.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbtnOutExcel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnOutExcel.Name = "tsbtnOutExcel";
            this.tsbtnOutExcel.Size = new System.Drawing.Size(82, 45);
            this.tsbtnOutExcel.Text = "导出";
            this.tsbtnOutExcel.Click += new System.EventHandler(this.tsbtnOutExcel_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 464);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.statusStrip1.Size = new System.Drawing.Size(975, 22);
            this.statusStrip1.TabIndex = 34;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // ucPage
            // 
            this.ucPage.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ucPage.Location = new System.Drawing.Point(0, 419);
            this.ucPage.Margin = new System.Windows.Forms.Padding(5);
            this.ucPage.Name = "ucPage";
            this.ucPage.Size = new System.Drawing.Size(975, 45);
            this.ucPage.TabIndex = 36;
            this.ucPage.PageChangedEvent += new Framework.WinCommon.Controls.PadeChangedHandle(this.ucPage_PageChangedEvent);
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
            this.col_KeShi,
            this.col_JiHuaMingCheng,
            this.col_MuBan,
            this.col_BianHao,
            this.col_XingMing,
            this.col_FenShu,
            this.col_PingFenRen,
            this.col_PingFenShiJian,
            this.col_DaTi});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgv.DisplayRowCount = true;
            this.dgv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv.IsKeepOldSeldected = true;
            this.dgv.Location = new System.Drawing.Point(0, 48);
            this.dgv.Margin = new System.Windows.Forms.Padding(4);
            this.dgv.MultiSelect = false;
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgv.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgv.RowTemplate.Height = 23;
            this.dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv.Size = new System.Drawing.Size(975, 371);
            this.dgv.TabIndex = 37;
            this.dgv.UseControlStyle = true;
            // 
            // col_KeShi
            // 
            this.col_KeShi.DataPropertyName = "KeShi";
            this.col_KeShi.HeaderText = "科室";
            this.col_KeShi.Name = "col_KeShi";
            this.col_KeShi.ReadOnly = true;
            this.col_KeShi.Width = 62;
            // 
            // col_JiHuaMingCheng
            // 
            this.col_JiHuaMingCheng.DataPropertyName = "JiHuaMingCheng";
            this.col_JiHuaMingCheng.HeaderText = "计划名称";
            this.col_JiHuaMingCheng.Name = "col_JiHuaMingCheng";
            this.col_JiHuaMingCheng.ReadOnly = true;
            this.col_JiHuaMingCheng.Width = 92;
            // 
            // col_MuBan
            // 
            this.col_MuBan.DataPropertyName = "MuBan";
            this.col_MuBan.HeaderText = "考试模板";
            this.col_MuBan.Name = "col_MuBan";
            this.col_MuBan.ReadOnly = true;
            this.col_MuBan.Width = 92;
            // 
            // col_BianHao
            // 
            this.col_BianHao.DataPropertyName = "BianHao";
            this.col_BianHao.HeaderText = "员工编号";
            this.col_BianHao.Name = "col_BianHao";
            this.col_BianHao.ReadOnly = true;
            this.col_BianHao.Width = 92;
            // 
            // col_XingMing
            // 
            this.col_XingMing.DataPropertyName = "XingMing";
            this.col_XingMing.HeaderText = "姓名";
            this.col_XingMing.Name = "col_XingMing";
            this.col_XingMing.ReadOnly = true;
            this.col_XingMing.Width = 62;
            // 
            // col_FenShu
            // 
            this.col_FenShu.DataPropertyName = "FenShu";
            dataGridViewCellStyle3.Format = "N2";
            dataGridViewCellStyle3.NullValue = "0.00";
            this.col_FenShu.DefaultCellStyle = dataGridViewCellStyle3;
            this.col_FenShu.HeaderText = "分数";
            this.col_FenShu.Name = "col_FenShu";
            this.col_FenShu.ReadOnly = true;
            this.col_FenShu.Width = 62;
            // 
            // col_PingFenRen
            // 
            this.col_PingFenRen.DataPropertyName = "PingFenRen";
            this.col_PingFenRen.HeaderText = "评分人";
            this.col_PingFenRen.Name = "col_PingFenRen";
            this.col_PingFenRen.ReadOnly = true;
            this.col_PingFenRen.Width = 77;
            // 
            // col_PingFenShiJian
            // 
            this.col_PingFenShiJian.DataPropertyName = "PingFenShiJian";
            this.col_PingFenShiJian.HeaderText = "评分时间";
            this.col_PingFenShiJian.Name = "col_PingFenShiJian";
            this.col_PingFenShiJian.ReadOnly = true;
            this.col_PingFenShiJian.Width = 92;
            // 
            // col_DaTi
            // 
            this.col_DaTi.DataPropertyName = "DaTi";
            this.col_DaTi.HeaderText = "答题";
            this.col_DaTi.Name = "col_DaTi";
            this.col_DaTi.ReadOnly = true;
            this.col_DaTi.Visible = false;
            this.col_DaTi.Width = 62;
            // 
            // FrmVPingFenMingXiChaKan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(975, 486);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.ucPage);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStripTop1);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "FrmVPingFenMingXiChaKan";
            this.Text = "评分明细查看";
            this.Load += new System.EventHandler(this.FrmVPingFenMingXiChaKan_Load);
            this.Controls.SetChildIndex(this.toolStripTop1, 0);
            this.Controls.SetChildIndex(this.statusStrip1, 0);
            this.Controls.SetChildIndex(this.ucPage, 0);
            this.Controls.SetChildIndex(this.dgv, 0);
            this.toolStripTop1.ResumeLayout(false);
            this.toolStripTop1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.ToolStrip toolStripTop1;
        public System.Windows.Forms.ToolStripButton tsbtnChaKanMingXi;
        public System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripTextBox tsTxtSearchValue;
        public System.Windows.Forms.ToolStripButton tsBtnSearch;
        public System.Windows.Forms.ToolStripButton tsBtnClose;
        public System.Windows.Forms.ToolStripButton tsbtnADSearch;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private Framework.WinCommon.Controls.UCPagingNavigation ucPage;
        private Framework.WinCommon.Controls.ZCDataGridView dgv;
        public System.Windows.Forms.ToolStripButton tsbtnOutExcel;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_KeShi;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_JiHuaMingCheng;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_MuBan;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_BianHao;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_XingMing;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_FenShu;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_PingFenRen;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_PingFenShiJian;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_DaTi;
    }
}