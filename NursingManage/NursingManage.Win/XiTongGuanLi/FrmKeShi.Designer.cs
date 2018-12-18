namespace NursingManage.Win.XiTongGuanLi
{
    partial class FrmKeShi
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
            this.toolStripTop1 = new System.Windows.Forms.ToolStrip();
            this.tsBtnAdd = new System.Windows.Forms.ToolStripButton();
            this.tsBtnEdit = new System.Windows.Forms.ToolStripButton();
            this.tsBtnDelete = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.tsTxtSearchValue = new System.Windows.Forms.ToolStripTextBox();
            this.tsBtnSearch = new System.Windows.Forms.ToolStripButton();
            this.tsBtnClose = new System.Windows.Forms.ToolStripButton();
            this.dgvKeShi = new Framework.WinCommon.Controls.ZCDataGridView();
            this.col_BianMa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_MingCheng = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_KESHILEIBIE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_LeiXing1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_LeiXing2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_MingCheng_PY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_KeShiID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStripTop1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKeShi)).BeginInit();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 381);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(597, 22);
            this.statusStrip1.TabIndex = 26;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripTop1
            // 
            this.toolStripTop1.AutoSize = false;
            this.toolStripTop1.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.toolStripTop1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsBtnAdd,
            this.tsBtnEdit,
            this.tsBtnDelete,
            this.toolStripSeparator5,
            this.tsTxtSearchValue,
            this.tsBtnSearch,
            this.tsBtnClose});
            this.toolStripTop1.Location = new System.Drawing.Point(0, 0);
            this.toolStripTop1.Name = "toolStripTop1";
            this.toolStripTop1.Size = new System.Drawing.Size(597, 38);
            this.toolStripTop1.TabIndex = 31;
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
            this.tsBtnAdd.Size = new System.Drawing.Size(73, 35);
            this.tsBtnAdd.Text = "增加";
            this.tsBtnAdd.Click += new System.EventHandler(this.tsBtnAdd_Click);
            // 
            // tsBtnEdit
            // 
            this.tsBtnEdit.BackColor = System.Drawing.Color.Transparent;
            this.tsBtnEdit.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tsBtnEdit.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.tsBtnEdit.Image = global::NursingManage.Win.Properties.Resources.edit;
            this.tsBtnEdit.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsBtnEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnEdit.Name = "tsBtnEdit";
            this.tsBtnEdit.Size = new System.Drawing.Size(73, 35);
            this.tsBtnEdit.Text = "编辑";
            this.tsBtnEdit.Click += new System.EventHandler(this.tsBtnEdit_Click);
            // 
            // tsBtnDelete
            // 
            this.tsBtnDelete.BackColor = System.Drawing.Color.Transparent;
            this.tsBtnDelete.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tsBtnDelete.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.tsBtnDelete.Image = global::NursingManage.Win.Properties.Resources.delete;
            this.tsBtnDelete.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsBtnDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnDelete.Name = "tsBtnDelete";
            this.tsBtnDelete.Size = new System.Drawing.Size(73, 35);
            this.tsBtnDelete.Text = "删除";
            this.tsBtnDelete.Click += new System.EventHandler(this.tsBtnDelete_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 38);
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
            // dgvKeShi
            // 
            this.dgvKeShi.AllowUserToAddRows = false;
            this.dgvKeShi.AllowUserToDeleteRows = false;
            this.dgvKeShi.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            this.dgvKeShi.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvKeShi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvKeShi.BackgroundColor = System.Drawing.Color.Snow;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvKeShi.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvKeShi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKeShi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_BianMa,
            this.col_MingCheng,
            this.col_KESHILEIBIE,
            this.col_LeiXing1,
            this.col_LeiXing2,
            this.col_MingCheng_PY,
            this.col_KeShiID});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvKeShi.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvKeShi.DisplayRowCount = true;
            this.dgvKeShi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvKeShi.Location = new System.Drawing.Point(0, 38);
            this.dgvKeShi.MultiSelect = false;
            this.dgvKeShi.Name = "dgvKeShi";
            this.dgvKeShi.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvKeShi.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvKeShi.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvKeShi.RowTemplate.Height = 23;
            this.dgvKeShi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvKeShi.Size = new System.Drawing.Size(597, 343);
            this.dgvKeShi.TabIndex = 33;
            this.dgvKeShi.UseControlStyle = true;
            // 
            // col_BianMa
            // 
            this.col_BianMa.DataPropertyName = "BianMa";
            this.col_BianMa.HeaderText = "科室编码";
            this.col_BianMa.Name = "col_BianMa";
            this.col_BianMa.ReadOnly = true;
            this.col_BianMa.Width = 78;
            // 
            // col_MingCheng
            // 
            this.col_MingCheng.DataPropertyName = "MingCheng";
            this.col_MingCheng.HeaderText = "科室名称";
            this.col_MingCheng.Name = "col_MingCheng";
            this.col_MingCheng.ReadOnly = true;
            this.col_MingCheng.Width = 78;
            // 
            // col_KESHILEIBIE
            // 
            this.col_KESHILEIBIE.DataPropertyName = "KESHILEIBIE";
            this.col_KESHILEIBIE.HeaderText = "科室类别";
            this.col_KESHILEIBIE.Name = "col_KESHILEIBIE";
            this.col_KESHILEIBIE.ReadOnly = true;
            this.col_KESHILEIBIE.Width = 78;
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
            // col_MingCheng_PY
            // 
            this.col_MingCheng_PY.DataPropertyName = "MingCheng_PY";
            this.col_MingCheng_PY.HeaderText = "助记码";
            this.col_MingCheng_PY.Name = "col_MingCheng_PY";
            this.col_MingCheng_PY.ReadOnly = true;
            this.col_MingCheng_PY.Visible = false;
            this.col_MingCheng_PY.Width = 66;
            // 
            // col_KeShiID
            // 
            this.col_KeShiID.DataPropertyName = "ID";
            this.col_KeShiID.HeaderText = "科室ID";
            this.col_KeShiID.Name = "col_KeShiID";
            this.col_KeShiID.ReadOnly = true;
            this.col_KeShiID.Visible = false;
            this.col_KeShiID.Width = 66;
            // 
            // FrmKeShi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(597, 403);
            this.Controls.Add(this.dgvKeShi);
            this.Controls.Add(this.toolStripTop1);
            this.Controls.Add(this.statusStrip1);
            this.Name = "FrmKeShi";
            this.Text = "科室管理";
            this.Load += new System.EventHandler(this.FrmKeShi_Load);
            this.Controls.SetChildIndex(this.statusStrip1, 0);
            this.Controls.SetChildIndex(this.toolStripTop1, 0);
            this.Controls.SetChildIndex(this.dgvKeShi, 0);
            this.toolStripTop1.ResumeLayout(false);
            this.toolStripTop1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKeShi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        public System.Windows.Forms.ToolStrip toolStripTop1;
        public System.Windows.Forms.ToolStripButton tsBtnAdd;
        public System.Windows.Forms.ToolStripButton tsBtnEdit;
        public System.Windows.Forms.ToolStripButton tsBtnDelete;
        public System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripTextBox tsTxtSearchValue;
        public System.Windows.Forms.ToolStripButton tsBtnSearch;
        public System.Windows.Forms.ToolStripButton tsBtnClose;
        private Framework.WinCommon.Controls.ZCDataGridView dgvKeShi;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_BianMa;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_MingCheng;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_KESHILEIBIE;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_LeiXing1;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_LeiXing2;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_MingCheng_PY;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_KeShiID;
    }
}