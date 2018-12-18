namespace NursingManage.Win.ZhiLiangKongZhi
{
    partial class FrmVZhiKongWenTiHuiZong
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.toolStripTop1 = new System.Windows.Forms.ToolStrip();
            this.tsBtnClose = new System.Windows.Forms.ToolStripButton();
            this.txtSearchByJiHua = new System.Windows.Forms.ToolStripTextBox();
            this.btnSearchByJiHua = new System.Windows.Forms.ToolStripButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.dgv = new Framework.WinCommon.Controls.ZCDataGridView();
            this.col_BiaoZhunLeiBie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_LeiXing1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_LeiXing2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_BiaoZhun = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_WenTiShu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_PaiMing = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tslbJiHua = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripTop1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStripTop1
            // 
            this.toolStripTop1.AutoSize = false;
            this.toolStripTop1.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.toolStripTop1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsBtnClose,
            this.txtSearchByJiHua,
            this.btnSearchByJiHua});
            this.toolStripTop1.Location = new System.Drawing.Point(0, 0);
            this.toolStripTop1.Name = "toolStripTop1";
            this.toolStripTop1.Size = new System.Drawing.Size(731, 38);
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
            this.tsBtnClose.Size = new System.Drawing.Size(73, 35);
            this.tsBtnClose.Text = "退出";
            this.tsBtnClose.Click += new System.EventHandler(this.tsBtnClose_Click);
            // 
            // txtSearchByJiHua
            // 
            this.txtSearchByJiHua.Name = "txtSearchByJiHua";
            this.txtSearchByJiHua.Size = new System.Drawing.Size(350, 38);
            this.txtSearchByJiHua.ToolTipText = "可输入回车进行搜索";
            // 
            // btnSearchByJiHua
            // 
            this.btnSearchByJiHua.BackColor = System.Drawing.Color.Transparent;
            this.btnSearchByJiHua.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnSearchByJiHua.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnSearchByJiHua.Image = global::NursingManage.Win.Properties.Resources.shouru;
            this.btnSearchByJiHua.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnSearchByJiHua.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSearchByJiHua.Name = "btnSearchByJiHua";
            this.btnSearchByJiHua.Size = new System.Drawing.Size(101, 35);
            this.btnSearchByJiHua.Text = "选择计划";
            this.btnSearchByJiHua.Click += new System.EventHandler(this.btnSearchByJiHua_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.tslbJiHua});
            this.statusStrip1.Location = new System.Drawing.Point(0, 367);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(731, 22);
            this.statusStrip1.TabIndex = 37;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AllowUserToDeleteRows = false;
            this.dgv.AllowUserToResizeRows = false;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            this.dgv.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgv.BackgroundColor = System.Drawing.Color.Snow;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_BiaoZhunLeiBie,
            this.col_LeiXing1,
            this.col_LeiXing2,
            this.col_BiaoZhun,
            this.col_WenTiShu,
            this.col_PaiMing});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv.DefaultCellStyle = dataGridViewCellStyle8;
            this.dgv.DisplayRowCount = false;
            this.dgv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv.Location = new System.Drawing.Point(0, 38);
            this.dgv.MultiSelect = false;
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dgv.RowHeadersVisible = false;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgv.RowsDefaultCellStyle = dataGridViewCellStyle10;
            this.dgv.RowTemplate.Height = 23;
            this.dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv.Size = new System.Drawing.Size(731, 329);
            this.dgv.TabIndex = 38;
            this.dgv.UseControlStyle = true;
            // 
            // col_BiaoZhunLeiBie
            // 
            this.col_BiaoZhunLeiBie.DataPropertyName = "BiaoZhunLeiBie";
            this.col_BiaoZhunLeiBie.HeaderText = "标准类别";
            this.col_BiaoZhunLeiBie.Name = "col_BiaoZhunLeiBie";
            this.col_BiaoZhunLeiBie.ReadOnly = true;
            this.col_BiaoZhunLeiBie.Width = 78;
            // 
            // col_LeiXing1
            // 
            this.col_LeiXing1.DataPropertyName = "LeiXing1";
            this.col_LeiXing1.HeaderText = "一级类型";
            this.col_LeiXing1.Name = "col_LeiXing1";
            this.col_LeiXing1.ReadOnly = true;
            this.col_LeiXing1.Width = 78;
            // 
            // col_LeiXing2
            // 
            this.col_LeiXing2.DataPropertyName = "LeiXing2";
            this.col_LeiXing2.HeaderText = "二级类型";
            this.col_LeiXing2.Name = "col_LeiXing2";
            this.col_LeiXing2.ReadOnly = true;
            this.col_LeiXing2.Width = 78;
            // 
            // col_BiaoZhun
            // 
            this.col_BiaoZhun.DataPropertyName = "BiaoZhun";
            this.col_BiaoZhun.HeaderText = "标准内容";
            this.col_BiaoZhun.Name = "col_BiaoZhun";
            this.col_BiaoZhun.ReadOnly = true;
            this.col_BiaoZhun.Width = 78;
            // 
            // col_WenTiShu
            // 
            this.col_WenTiShu.DataPropertyName = "WenTiShu";
            this.col_WenTiShu.HeaderText = "问题数";
            this.col_WenTiShu.Name = "col_WenTiShu";
            this.col_WenTiShu.ReadOnly = true;
            this.col_WenTiShu.Width = 66;
            // 
            // col_PaiMing
            // 
            this.col_PaiMing.DataPropertyName = "PaiMing";
            this.col_PaiMing.HeaderText = "排名";
            this.col_PaiMing.Name = "col_PaiMing";
            this.col_PaiMing.ReadOnly = true;
            this.col_PaiMing.Width = 54;
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.BackColor = System.Drawing.Color.Transparent;
            this.toolStripStatusLabel1.ForeColor = System.Drawing.Color.Blue;
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(104, 17);
            this.toolStripStatusLabel1.Text = "当前选择的计划：";
            // 
            // tslbJiHua
            // 
            this.tslbJiHua.BackColor = System.Drawing.Color.Transparent;
            this.tslbJiHua.ForeColor = System.Drawing.Color.Blue;
            this.tslbJiHua.Name = "tslbJiHua";
            this.tslbJiHua.Size = new System.Drawing.Size(15, 17);
            this.tslbJiHua.Text = "0";
            // 
            // FrmVZhiKongWenTiHuiZong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(731, 389);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStripTop1);
            this.Name = "FrmVZhiKongWenTiHuiZong";
            this.Text = "质控问题项汇总";
            this.Load += new System.EventHandler(this.FrmVZhiKongWenTiHuiZong_Load);
            this.Controls.SetChildIndex(this.toolStripTop1, 0);
            this.Controls.SetChildIndex(this.statusStrip1, 0);
            this.Controls.SetChildIndex(this.dgv, 0);
            this.toolStripTop1.ResumeLayout(false);
            this.toolStripTop1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.ToolStrip toolStripTop1;
        public System.Windows.Forms.ToolStripButton tsBtnClose;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private Framework.WinCommon.Controls.ZCDataGridView dgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_BiaoZhunLeiBie;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_LeiXing1;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_LeiXing2;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_BiaoZhun;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_WenTiShu;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_PaiMing;
        public System.Windows.Forms.ToolStripButton btnSearchByJiHua;
        private System.Windows.Forms.ToolStripTextBox txtSearchByJiHua;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel tslbJiHua;
    }
}