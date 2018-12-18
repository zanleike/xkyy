namespace NursingManage.Win
{
    partial class BaseSelectForm<TModel>
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
            this.dgv = new Framework.WinCommon.Controls.ZCDataGridView();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lbSelectedCount = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripTop1 = new System.Windows.Forms.ToolStrip();
            this.tsBtnClose = new System.Windows.Forms.ToolStripButton();
            this.tsTxtSearchValue = new System.Windows.Forms.ToolStripTextBox();
            this.tsBtnSearch = new System.Windows.Forms.ToolStripButton();
            this.tsBtnSelected = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbtnAllSelected = new System.Windows.Forms.ToolStripButton();
            this.tsbtnUnAllSelected = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.toolStripTop1.SuspendLayout();
            this.SuspendLayout();
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
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.DisplayRowCount = true;
            this.dgv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv.Location = new System.Drawing.Point(0, 38);
            this.dgv.MultiSelect = false;
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgv.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv.RowTemplate.Height = 23;
            this.dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgv.Size = new System.Drawing.Size(788, 454);
            this.dgv.TabIndex = 30;
            this.dgv.UseControlStyle = true;
            this.dgv.SelectionChangedAndCellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_SelectionChangedAndCellClick);
            this.dgv.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellValueChanged);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.lbSelectedCount});
            this.statusStrip1.Location = new System.Drawing.Point(0, 492);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(788, 25);
            this.statusStrip1.TabIndex = 29;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.BackColor = System.Drawing.Color.Transparent;
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(69, 20);
            this.toolStripStatusLabel1.Text = "已选择：";
            // 
            // lbSelectedCount
            // 
            this.lbSelectedCount.BackColor = System.Drawing.Color.Transparent;
            this.lbSelectedCount.Name = "lbSelectedCount";
            this.lbSelectedCount.Size = new System.Drawing.Size(18, 20);
            this.lbSelectedCount.Text = "0";
            // 
            // toolStripTop1
            // 
            this.toolStripTop1.AutoSize = false;
            this.toolStripTop1.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.toolStripTop1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsBtnClose,
            this.tsTxtSearchValue,
            this.tsBtnSearch,
            this.tsBtnSelected,
            this.toolStripSeparator1,
            this.tsbtnAllSelected,
            this.tsbtnUnAllSelected});
            this.toolStripTop1.Location = new System.Drawing.Point(0, 0);
            this.toolStripTop1.Name = "toolStripTop1";
            this.toolStripTop1.Size = new System.Drawing.Size(788, 38);
            this.toolStripTop1.TabIndex = 28;
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
            // tsTxtSearchValue
            // 
            this.tsTxtSearchValue.Name = "tsTxtSearchValue";
            this.tsTxtSearchValue.Size = new System.Drawing.Size(150, 38);
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
            this.tsBtnSearch.Size = new System.Drawing.Size(82, 35);
            this.tsBtnSearch.Text = "搜索";
            this.tsBtnSearch.Click += new System.EventHandler(this.tsBtnSearch_Click);
            // 
            // tsBtnSelected
            // 
            this.tsBtnSelected.BackColor = System.Drawing.Color.Transparent;
            this.tsBtnSelected.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tsBtnSelected.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.tsBtnSelected.Image = global::NursingManage.Win.Properties.Resources.selected;
            this.tsBtnSelected.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsBtnSelected.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnSelected.Name = "tsBtnSelected";
            this.tsBtnSelected.Size = new System.Drawing.Size(118, 35);
            this.tsBtnSelected.Text = "选择退出";
            this.tsBtnSelected.Click += new System.EventHandler(this.tsBtnSelected_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 38);
            // 
            // tsbtnAllSelected
            // 
            this.tsbtnAllSelected.BackColor = System.Drawing.Color.Transparent;
            this.tsbtnAllSelected.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tsbtnAllSelected.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.tsbtnAllSelected.Image = global::NursingManage.Win.Properties.Resources.checkall;
            this.tsbtnAllSelected.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbtnAllSelected.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnAllSelected.Name = "tsbtnAllSelected";
            this.tsbtnAllSelected.Size = new System.Drawing.Size(82, 35);
            this.tsbtnAllSelected.Text = "全选";
            this.tsbtnAllSelected.Click += new System.EventHandler(this.tsbtnAllSelected_Click);
            // 
            // tsbtnUnAllSelected
            // 
            this.tsbtnUnAllSelected.BackColor = System.Drawing.Color.Transparent;
            this.tsbtnUnAllSelected.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tsbtnUnAllSelected.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.tsbtnUnAllSelected.Image = global::NursingManage.Win.Properties.Resources.cancel;
            this.tsbtnUnAllSelected.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbtnUnAllSelected.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnUnAllSelected.Name = "tsbtnUnAllSelected";
            this.tsbtnUnAllSelected.Size = new System.Drawing.Size(100, 35);
            this.tsbtnUnAllSelected.Text = "全不选";
            this.tsbtnUnAllSelected.Click += new System.EventHandler(this.tsbtnUnAllSelected_Click);
            // 
            // BaseSelectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(788, 517);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStripTop1);
            this.KeyPreview = true;
            this.MaximizeBox = true;
            this.Name = "BaseSelectForm";
            this.Text = "选择";
            this.Load += new System.EventHandler(this.BaseSelectForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.BaseSelectForm_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.BaseSelectForm_KeyUp);
            this.Controls.SetChildIndex(this.toolStripTop1, 0);
            this.Controls.SetChildIndex(this.statusStrip1, 0);
            this.Controls.SetChildIndex(this.dgv, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.toolStripTop1.ResumeLayout(false);
            this.toolStripTop1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Framework.WinCommon.Controls.ZCDataGridView dgv;
        private System.Windows.Forms.StatusStrip statusStrip1;
        public System.Windows.Forms.ToolStrip toolStripTop1;
        public System.Windows.Forms.ToolStripButton tsBtnClose;
        private System.Windows.Forms.ToolStripTextBox tsTxtSearchValue;
        public System.Windows.Forms.ToolStripButton tsBtnSearch;
        public System.Windows.Forms.ToolStripButton tsBtnSelected;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        public System.Windows.Forms.ToolStripButton tsbtnAllSelected;
        public System.Windows.Forms.ToolStripButton tsbtnUnAllSelected;
        private System.Windows.Forms.ToolStripStatusLabel lbSelectedCount;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
    }
}