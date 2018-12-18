namespace NursingManage.Win.PeiXunGuanLi
{
    partial class FrmTiKuGuanLi_ShiTiZhengLi
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.toolStripTop1 = new System.Windows.Forms.ToolStrip();
            this.tsBtnClose = new System.Windows.Forms.ToolStripButton();
            this.tsbnSelectFile = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbtnOutExcel = new System.Windows.Forms.ToolStripButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.dgv = new Framework.WinCommon.Controls.ZCDataGridView();
            this.col_ShiTiXuhao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_LEIXING = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_NanYiChengDu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.tsBtnClose,
            this.tsbnSelectFile,
            this.toolStripSeparator1,
            this.tsbtnOutExcel});
            this.toolStripTop1.Location = new System.Drawing.Point(0, 0);
            this.toolStripTop1.Name = "toolStripTop1";
            this.toolStripTop1.Size = new System.Drawing.Size(1052, 48);
            this.toolStripTop1.TabIndex = 27;
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
            this.tsBtnClose.Size = new System.Drawing.Size(82, 45);
            this.tsBtnClose.Text = "退出";
            this.tsBtnClose.Click += new System.EventHandler(this.tsBtnClose_Click);
            // 
            // tsbnSelectFile
            // 
            this.tsbnSelectFile.BackColor = System.Drawing.Color.Transparent;
            this.tsbnSelectFile.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tsbnSelectFile.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.tsbnSelectFile.Image = global::NursingManage.Win.Properties.Resources.shouru;
            this.tsbnSelectFile.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbnSelectFile.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbnSelectFile.Name = "tsbnSelectFile";
            this.tsbnSelectFile.Size = new System.Drawing.Size(118, 45);
            this.tsbnSelectFile.Text = "选择文件";
            this.tsbnSelectFile.Click += new System.EventHandler(this.tsbnSelectFile_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 48);
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
            this.tsbtnOutExcel.Size = new System.Drawing.Size(125, 45);
            this.tsbtnOutExcel.Text = "导出excel";
            this.tsbtnOutExcel.Click += new System.EventHandler(this.tsbtnOutExcel_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 692);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.statusStrip1.Size = new System.Drawing.Size(1052, 22);
            this.statusStrip1.TabIndex = 29;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AllowUserToDeleteRows = false;
            this.dgv.AllowUserToResizeRows = false;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            this.dgv.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgv.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.dgv.BackgroundColor = System.Drawing.Color.Snow;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_ShiTiXuhao,
            this.col_LEIXING,
            this.col_NanYiChengDu,
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.col_XiangMuA,
            this.col_XiangMuB,
            this.col_XiangMuC,
            this.col_XiangMuD,
            this.col_XiangMuE,
            this.col_XiangMuF});
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv.DefaultCellStyle = dataGridViewCellStyle10;
            this.dgv.DisplayRowCount = true;
            this.dgv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv.Location = new System.Drawing.Point(0, 48);
            this.dgv.MultiSelect = false;
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv.RowHeadersDefaultCellStyle = dataGridViewCellStyle11;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgv.RowsDefaultCellStyle = dataGridViewCellStyle12;
            this.dgv.RowTemplate.Height = 23;
            this.dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgv.Size = new System.Drawing.Size(1052, 644);
            this.dgv.TabIndex = 39;
            this.dgv.UseControlStyle = true;
            // 
            // col_ShiTiXuhao
            // 
            this.col_ShiTiXuhao.DataPropertyName = "XuHao";
            this.col_ShiTiXuhao.HeaderText = "试题编号";
            this.col_ShiTiXuhao.Name = "col_ShiTiXuhao";
            this.col_ShiTiXuhao.ReadOnly = true;
            this.col_ShiTiXuhao.Width = 92;
            // 
            // col_LEIXING
            // 
            this.col_LEIXING.DataPropertyName = "LEIXING";
            this.col_LEIXING.HeaderText = "试题类型";
            this.col_LEIXING.Name = "col_LEIXING";
            this.col_LEIXING.ReadOnly = true;
            this.col_LEIXING.Width = 92;
            // 
            // col_NanYiChengDu
            // 
            this.col_NanYiChengDu.DataPropertyName = "NanYiChengDu";
            dataGridViewCellStyle9.NullValue = "普通";
            this.col_NanYiChengDu.DefaultCellStyle = dataGridViewCellStyle9;
            this.col_NanYiChengDu.HeaderText = "难易程度";
            this.col_NanYiChengDu.Name = "col_NanYiChengDu";
            this.col_NanYiChengDu.ReadOnly = true;
            this.col_NanYiChengDu.Width = 92;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewTextBoxColumn1.DataPropertyName = "NEIRONG";
            this.dataGridViewTextBoxColumn1.HeaderText = "试题内容";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 300;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "DaAn";
            this.dataGridViewTextBoxColumn2.HeaderText = "答案";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 62;
            // 
            // col_XiangMuA
            // 
            this.col_XiangMuA.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.col_XiangMuA.DataPropertyName = "XuanXiangA";
            this.col_XiangMuA.HeaderText = "选项A";
            this.col_XiangMuA.Name = "col_XiangMuA";
            this.col_XiangMuA.ReadOnly = true;
            this.col_XiangMuA.Width = 120;
            // 
            // col_XiangMuB
            // 
            this.col_XiangMuB.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.col_XiangMuB.DataPropertyName = "XuanXiangB";
            this.col_XiangMuB.HeaderText = "选项B";
            this.col_XiangMuB.Name = "col_XiangMuB";
            this.col_XiangMuB.ReadOnly = true;
            this.col_XiangMuB.Width = 120;
            // 
            // col_XiangMuC
            // 
            this.col_XiangMuC.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.col_XiangMuC.DataPropertyName = "XuanXiangC";
            this.col_XiangMuC.HeaderText = "选项C";
            this.col_XiangMuC.Name = "col_XiangMuC";
            this.col_XiangMuC.ReadOnly = true;
            this.col_XiangMuC.Width = 120;
            // 
            // col_XiangMuD
            // 
            this.col_XiangMuD.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.col_XiangMuD.DataPropertyName = "XuanXiangD";
            this.col_XiangMuD.HeaderText = "选项D";
            this.col_XiangMuD.Name = "col_XiangMuD";
            this.col_XiangMuD.ReadOnly = true;
            this.col_XiangMuD.Width = 120;
            // 
            // col_XiangMuE
            // 
            this.col_XiangMuE.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.col_XiangMuE.DataPropertyName = "XuanXiangE";
            this.col_XiangMuE.HeaderText = "选项E";
            this.col_XiangMuE.Name = "col_XiangMuE";
            this.col_XiangMuE.ReadOnly = true;
            this.col_XiangMuE.Width = 120;
            // 
            // col_XiangMuF
            // 
            this.col_XiangMuF.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.col_XiangMuF.DataPropertyName = "XuanXiangF";
            this.col_XiangMuF.HeaderText = "选项F";
            this.col_XiangMuF.Name = "col_XiangMuF";
            this.col_XiangMuF.ReadOnly = true;
            this.col_XiangMuF.Width = 120;
            // 
            // FrmTiKuGuanLi_ShiTiZhengLi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1052, 714);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStripTop1);
            this.KeyPreview = true;
            this.Name = "FrmTiKuGuanLi_ShiTiZhengLi";
            this.Text = "题库整理";
            this.Load += new System.EventHandler(this.FrmTiKuGuanLi_ShiTiZhengLi_Load);
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
        public System.Windows.Forms.ToolStripButton tsbtnOutExcel;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        public System.Windows.Forms.ToolStripButton tsbnSelectFile;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private Framework.WinCommon.Controls.ZCDataGridView dgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_ShiTiXuhao;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_LEIXING;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_NanYiChengDu;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_XiangMuA;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_XiangMuB;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_XiangMuC;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_XiangMuD;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_XiangMuE;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_XiangMuF;
    }
}