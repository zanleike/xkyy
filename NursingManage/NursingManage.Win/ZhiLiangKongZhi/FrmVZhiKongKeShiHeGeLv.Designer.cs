namespace NursingManage.Win.ZhiLiangKongZhi
{
    partial class FrmVZhiKongKeShiHeGeLv
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
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsTxtSearchValue = new System.Windows.Forms.ToolStripTextBox();
            this.tsBtnSearch = new System.Windows.Forms.ToolStripButton();
            this.tsbtnClose = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbtnADSearch = new System.Windows.Forms.ToolStripButton();
            this.dgv = new Framework.WinCommon.Controls.ZCDataGridView();
            this.col_JiHua = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_KeShi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_BiaoZhunLeiBie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_BiaoZhunShu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_WenTiShu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_HeGeLv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_JianChaKaiShiShiJian = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 587);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.statusStrip1.Size = new System.Drawing.Size(948, 22);
            this.statusStrip1.TabIndex = 38;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsTxtSearchValue,
            this.tsBtnSearch,
            this.tsbtnClose,
            this.toolStripSeparator5,
            this.tsbtnADSearch});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(948, 48);
            this.toolStrip1.TabIndex = 40;
            this.toolStrip1.Text = "toolStrip2";
            // 
            // tsTxtSearchValue
            // 
            this.tsTxtSearchValue.Name = "tsTxtSearchValue";
            this.tsTxtSearchValue.Size = new System.Drawing.Size(200, 48);
            this.tsTxtSearchValue.ToolTipText = "可输入回车进行搜索";
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
            // tsbtnClose
            // 
            this.tsbtnClose.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsbtnClose.BackColor = System.Drawing.Color.Transparent;
            this.tsbtnClose.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tsbtnClose.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.tsbtnClose.Image = global::NursingManage.Win.Properties.Resources.exit;
            this.tsbtnClose.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbtnClose.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnClose.Margin = new System.Windows.Forms.Padding(0, 1, 1, 2);
            this.tsbtnClose.Name = "tsbtnClose";
            this.tsbtnClose.Size = new System.Drawing.Size(82, 45);
            this.tsbtnClose.Text = "退出";
            this.tsbtnClose.Click += new System.EventHandler(this.tsbtnClose_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 48);
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
            this.col_JiHua,
            this.col_KeShi,
            this.col_BiaoZhunLeiBie,
            this.col_BiaoZhunShu,
            this.col_WenTiShu,
            this.col_HeGeLv,
            this.col_JianChaKaiShiShiJian});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgv.DisplayRowCount = true;
            this.dgv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv.Location = new System.Drawing.Point(0, 48);
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
            this.dgv.RowTemplate.Height = 27;
            this.dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv.Size = new System.Drawing.Size(948, 539);
            this.dgv.TabIndex = 41;
            this.dgv.UseControlStyle = true;
            // 
            // col_JiHua
            // 
            this.col_JiHua.DataPropertyName = "JiHua";
            this.col_JiHua.HeaderText = "计划名称";
            this.col_JiHua.Name = "col_JiHua";
            this.col_JiHua.ReadOnly = true;
            this.col_JiHua.Width = 92;
            // 
            // col_KeShi
            // 
            this.col_KeShi.DataPropertyName = "KeShi";
            this.col_KeShi.HeaderText = "科室";
            this.col_KeShi.Name = "col_KeShi";
            this.col_KeShi.ReadOnly = true;
            this.col_KeShi.Width = 62;
            // 
            // col_BiaoZhunLeiBie
            // 
            this.col_BiaoZhunLeiBie.DataPropertyName = "BiaoZhunLeiBie";
            this.col_BiaoZhunLeiBie.HeaderText = "标准类别";
            this.col_BiaoZhunLeiBie.Name = "col_BiaoZhunLeiBie";
            this.col_BiaoZhunLeiBie.ReadOnly = true;
            this.col_BiaoZhunLeiBie.Width = 92;
            // 
            // col_BiaoZhunShu
            // 
            this.col_BiaoZhunShu.DataPropertyName = "BiaoZhunShu";
            this.col_BiaoZhunShu.HeaderText = "标准数";
            this.col_BiaoZhunShu.Name = "col_BiaoZhunShu";
            this.col_BiaoZhunShu.ReadOnly = true;
            this.col_BiaoZhunShu.Width = 77;
            // 
            // col_WenTiShu
            // 
            this.col_WenTiShu.DataPropertyName = "WenTiShu";
            this.col_WenTiShu.HeaderText = "问题数";
            this.col_WenTiShu.Name = "col_WenTiShu";
            this.col_WenTiShu.ReadOnly = true;
            this.col_WenTiShu.Width = 77;
            // 
            // col_HeGeLv
            // 
            this.col_HeGeLv.DataPropertyName = "HeGeLv";
            this.col_HeGeLv.HeaderText = "合格率";
            this.col_HeGeLv.Name = "col_HeGeLv";
            this.col_HeGeLv.ReadOnly = true;
            this.col_HeGeLv.Width = 77;
            // 
            // col_JianChaKaiShiShiJian
            // 
            this.col_JianChaKaiShiShiJian.DataPropertyName = "JianChaKaiShiShiJian";
            this.col_JianChaKaiShiShiJian.HeaderText = "检查时间";
            this.col_JianChaKaiShiShiJian.Name = "col_JianChaKaiShiShiJian";
            this.col_JianChaKaiShiShiJian.ReadOnly = true;
            this.col_JianChaKaiShiShiJian.Width = 92;
            // 
            // FrmVZhiKongKeShiHeGeLv
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(948, 609);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.statusStrip1);
            this.Name = "FrmVZhiKongKeShiHeGeLv";
            this.Text = "科室质控信息查看";
            this.Load += new System.EventHandler(this.FrmVZhiKongKeShiHeGeLv_Load);
            this.Controls.SetChildIndex(this.statusStrip1, 0);
            this.Controls.SetChildIndex(this.toolStrip1, 0);
            this.Controls.SetChildIndex(this.dgv, 0);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        public System.Windows.Forms.ToolStrip toolStrip1;
        public System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripTextBox tsTxtSearchValue;
        public System.Windows.Forms.ToolStripButton tsBtnSearch;
        public System.Windows.Forms.ToolStripButton tsbtnClose;
        public System.Windows.Forms.ToolStripButton tsbtnADSearch;
        private Framework.WinCommon.Controls.ZCDataGridView dgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_JiHua;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_KeShi;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_BiaoZhunLeiBie;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_BiaoZhunShu;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_WenTiShu;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_HeGeLv;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_JianChaKaiShiShiJian;
    }
}