namespace NursingManage.Win.PeiXunGuanLi
{
    partial class FrmShiTiPingFenLuRu
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
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.tsTxtSearchValue = new System.Windows.Forms.ToolStripTextBox();
            this.tsBtnSearch = new System.Windows.Forms.ToolStripButton();
            this.tsBtnClose = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.btnPiLiangPingFen = new System.Windows.Forms.ToolStripButton();
            this.btnSavePingFen = new System.Windows.Forms.ToolStripButton();
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
            this.toolStripLabel1,
            this.tsTxtSearchValue,
            this.tsBtnSearch,
            this.tsBtnClose,
            this.toolStripSeparator5,
            this.btnPiLiangPingFen,
            this.btnSavePingFen});
            this.toolStripTop1.Location = new System.Drawing.Point(0, 0);
            this.toolStripTop1.Name = "toolStripTop1";
            this.toolStripTop1.Size = new System.Drawing.Size(812, 38);
            this.toolStripTop1.TabIndex = 35;
            this.toolStripTop1.Text = "toolStrip2";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(79, 35);
            this.toolStripLabel1.Text = "试题序号：";
            // 
            // tsTxtSearchValue
            // 
            this.tsTxtSearchValue.Name = "tsTxtSearchValue";
            this.tsTxtSearchValue.Size = new System.Drawing.Size(100, 38);
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
            this.tsBtnSearch.Size = new System.Drawing.Size(73, 35);
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
            this.tsBtnClose.Size = new System.Drawing.Size(73, 35);
            this.tsBtnClose.Text = "退出";
            this.tsBtnClose.Click += new System.EventHandler(this.tsBtnClose_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 38);
            // 
            // btnPiLiangPingFen
            // 
            this.btnPiLiangPingFen.BackColor = System.Drawing.Color.Transparent;
            this.btnPiLiangPingFen.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnPiLiangPingFen.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnPiLiangPingFen.Image = global::NursingManage.Win.Properties.Resources.checkall;
            this.btnPiLiangPingFen.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnPiLiangPingFen.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnPiLiangPingFen.Name = "btnPiLiangPingFen";
            this.btnPiLiangPingFen.Size = new System.Drawing.Size(101, 35);
            this.btnPiLiangPingFen.Text = "批量评分";
            this.btnPiLiangPingFen.Click += new System.EventHandler(this.btnPiLiangPingFen_Click);
            // 
            // btnSavePingFen
            // 
            this.btnSavePingFen.BackColor = System.Drawing.Color.Transparent;
            this.btnSavePingFen.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnSavePingFen.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnSavePingFen.Image = global::NursingManage.Win.Properties.Resources.save;
            this.btnSavePingFen.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnSavePingFen.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSavePingFen.Name = "btnSavePingFen";
            this.btnSavePingFen.Size = new System.Drawing.Size(101, 35);
            this.btnSavePingFen.Text = "保存评分";
            this.btnSavePingFen.Click += new System.EventHandler(this.btnSavePingFen_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 401);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(812, 22);
            this.statusStrip1.TabIndex = 36;
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
            this.dgv.Size = new System.Drawing.Size(812, 363);
            this.dgv.TabIndex = 37;
            this.dgv.UseControlStyle = true;
            this.dgv.CellLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellLeave);
            this.dgv.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellValueChanged);
            // 
            // col_ShiFouZhengQue
            // 
            this.col_ShiFouZhengQue.DataPropertyName = "ShiFouZhengQue";
            this.col_ShiFouZhengQue.HeaderText = "是否正确";
            this.col_ShiFouZhengQue.Name = "col_ShiFouZhengQue";
            this.col_ShiFouZhengQue.ReadOnly = true;
            this.col_ShiFouZhengQue.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.col_ShiFouZhengQue.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.col_ShiFouZhengQue.Width = 78;
            // 
            // col_DaTi
            // 
            this.col_DaTi.DataPropertyName = "DaTi";
            this.col_DaTi.HeaderText = "答题";
            this.col_DaTi.Name = "col_DaTi";
            this.col_DaTi.ReadOnly = true;
            this.col_DaTi.Width = 54;
            // 
            // col_ShiTiXuhao
            // 
            this.col_ShiTiXuhao.DataPropertyName = "ShiTiXuhao";
            this.col_ShiTiXuhao.HeaderText = "试题序号";
            this.col_ShiTiXuhao.Name = "col_ShiTiXuhao";
            this.col_ShiTiXuhao.ReadOnly = true;
            this.col_ShiTiXuhao.Width = 78;
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
            this.col_FenShu.Width = 54;
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
            this.col_LEIXING.Width = 78;
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
            this.col_DaAn.Width = 78;
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
            // FrmShiTiPingFenLuRu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(812, 423);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStripTop1);
            this.KeyPreview = true;
            this.MaximizeBox = true;
            this.Name = "FrmShiTiPingFenLuRu";
            this.Text = "评分录入";
            this.Load += new System.EventHandler(this.FrmShiTiPingFenLuRu_Load);
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
        private System.Windows.Forms.ToolStripTextBox tsTxtSearchValue;
        public System.Windows.Forms.ToolStripButton tsBtnSearch;
        public System.Windows.Forms.ToolStripButton tsBtnClose;
        public System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        public System.Windows.Forms.ToolStripButton btnPiLiangPingFen;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private Framework.WinCommon.Controls.ZCDataGridView dgv;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        public System.Windows.Forms.ToolStripButton btnSavePingFen;
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