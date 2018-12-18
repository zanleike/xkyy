namespace NursingManage.Win.PeiXunGuanLi
{
    partial class FrmDaTiLieBiao
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            this.toolStripTop1 = new System.Windows.Forms.ToolStrip();
            this.tsBtnAdd = new System.Windows.Forms.ToolStripButton();
            this.tsBtnEditor = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.tsBtnClose = new System.Windows.Forms.ToolStripButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.dgv = new Framework.WinCommon.Controls.ZCDataGridView();
            this.col_DaTi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_ShiTiXuhao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_FENLEI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_BIANHAO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_FenShu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_LEIXING = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_NEIRONG = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.tsBtnAdd,
            this.tsBtnEditor,
            this.toolStripSeparator5,
            this.tsBtnClose});
            this.toolStripTop1.Location = new System.Drawing.Point(0, 0);
            this.toolStripTop1.Name = "toolStripTop1";
            this.toolStripTop1.Size = new System.Drawing.Size(975, 48);
            this.toolStripTop1.TabIndex = 26;
            this.toolStripTop1.Text = "toolStrip2";
            // 
            // tsBtnAdd
            // 
            this.tsBtnAdd.BackColor = System.Drawing.Color.Transparent;
            this.tsBtnAdd.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tsBtnAdd.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.tsBtnAdd.Image = global::NursingManage.Win.Properties.Resources.add;
            this.tsBtnAdd.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsBtnAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnAdd.Name = "tsBtnAdd";
            this.tsBtnAdd.Size = new System.Drawing.Size(118, 45);
            this.tsBtnAdd.Text = "逐步答题";
            this.tsBtnAdd.Click += new System.EventHandler(this.tsBtnAdd_Click);
            // 
            // tsBtnEditor
            // 
            this.tsBtnEditor.BackColor = System.Drawing.Color.Transparent;
            this.tsBtnEditor.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tsBtnEditor.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.tsBtnEditor.Image = global::NursingManage.Win.Properties.Resources.edit;
            this.tsBtnEditor.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsBtnEditor.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnEditor.Name = "tsBtnEditor";
            this.tsBtnEditor.Size = new System.Drawing.Size(118, 45);
            this.tsBtnEditor.Text = "提交答卷";
            this.tsBtnEditor.Click += new System.EventHandler(this.tsBtnEditor_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 48);
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
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 464);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.statusStrip1.Size = new System.Drawing.Size(975, 22);
            this.statusStrip1.TabIndex = 28;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AllowUserToDeleteRows = false;
            this.dgv.AllowUserToResizeRows = false;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Control;
            this.dgv.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle11;
            this.dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgv.BackgroundColor = System.Drawing.Color.Snow;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_DaTi,
            this.col_ShiTiXuhao,
            this.col_FENLEI,
            this.col_BIANHAO,
            this.col_FenShu,
            this.col_LEIXING,
            this.col_NEIRONG,
            this.col_XiangMuA,
            this.col_XiangMuB,
            this.col_XiangMuC,
            this.col_XiangMuD,
            this.col_XiangMuE,
            this.col_XiangMuF});
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv.DefaultCellStyle = dataGridViewCellStyle13;
            this.dgv.DisplayRowCount = true;
            this.dgv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv.Location = new System.Drawing.Point(0, 48);
            this.dgv.MultiSelect = false;
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv.RowHeadersDefaultCellStyle = dataGridViewCellStyle14;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgv.RowsDefaultCellStyle = dataGridViewCellStyle15;
            this.dgv.RowTemplate.Height = 23;
            this.dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgv.Size = new System.Drawing.Size(975, 416);
            this.dgv.TabIndex = 38;
            this.dgv.UseControlStyle = true;
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
            this.col_FENLEI.Width = 92;
            // 
            // col_BIANHAO
            // 
            this.col_BIANHAO.DataPropertyName = "BIANHAO";
            this.col_BIANHAO.HeaderText = "编号";
            this.col_BIANHAO.Name = "col_BIANHAO";
            this.col_BIANHAO.ReadOnly = true;
            this.col_BIANHAO.Visible = false;
            this.col_BIANHAO.Width = 62;
            // 
            // col_FenShu
            // 
            this.col_FenShu.DataPropertyName = "FenShu";
            this.col_FenShu.HeaderText = "分数";
            this.col_FenShu.Name = "col_FenShu";
            this.col_FenShu.ReadOnly = true;
            this.col_FenShu.Width = 62;
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
            // FrmDaTiLieBiao
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(975, 486);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStripTop1);
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = true;
            this.Name = "FrmDaTiLieBiao";
            this.Text = "考试";
            this.Load += new System.EventHandler(this.FrmDaTiLieBiao_Load);
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
        public System.Windows.Forms.ToolStripButton tsBtnAdd;
        public System.Windows.Forms.ToolStripButton tsBtnEditor;
        public System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        public System.Windows.Forms.ToolStripButton tsBtnClose;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private Framework.WinCommon.Controls.ZCDataGridView dgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_DaTi;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_ShiTiXuhao;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_FENLEI;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_BIANHAO;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_FenShu;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_LEIXING;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_NEIRONG;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_XiangMuA;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_XiangMuB;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_XiangMuC;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_XiangMuD;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_XiangMuE;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_XiangMuF;
    }
}