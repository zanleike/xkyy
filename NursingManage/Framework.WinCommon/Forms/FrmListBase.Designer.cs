namespace Framework.WinCommon.Forms
{
    partial class FrmListBase
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmListBase));
            this.toolStripTop2 = new System.Windows.Forms.ToolStrip();
            this.tsTxtQuickSearch = new System.Windows.Forms.ToolStripTextBox();
            this.tsBtnQuickSearch = new System.Windows.Forms.ToolStripButton();
            this.tsBtnQuickSearchClear = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.tsBtnAdvancedSearch = new System.Windows.Forms.ToolStripButton();
            this.toolStripTop1 = new System.Windows.Forms.ToolStrip();
            this.tsBtnAdd = new System.Windows.Forms.ToolStripButton();
            this.tsBtnEditor = new System.Windows.Forms.ToolStripButton();
            this.tsBtnView = new System.Windows.Forms.ToolStripButton();
            this.tsBtnDelete = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.tsBtnClose = new System.Windows.Forms.ToolStripButton();
            this.toolStripTop2.SuspendLayout();
            this.toolStripTop1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStripTop2
            // 
            this.toolStripTop2.AutoSize = false;
            this.toolStripTop2.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.toolStripTop2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsTxtQuickSearch,
            this.tsBtnQuickSearch,
            this.tsBtnQuickSearchClear,
            this.toolStripSeparator7,
            this.tsBtnAdvancedSearch});
            this.toolStripTop2.Location = new System.Drawing.Point(0, 34);
            this.toolStripTop2.Name = "toolStripTop2";
            this.toolStripTop2.Size = new System.Drawing.Size(829, 34);
            this.toolStripTop2.TabIndex = 11;
            this.toolStripTop2.Text = "toolStrip3";
            // 
            // tsTxtQuickSearch
            // 
            this.tsTxtQuickSearch.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tsTxtQuickSearch.Margin = new System.Windows.Forms.Padding(5);
            this.tsTxtQuickSearch.Name = "tsTxtQuickSearch";
            this.tsTxtQuickSearch.Size = new System.Drawing.Size(172, 24);
            this.tsTxtQuickSearch.ToolTipText = "输入回车进行快速检索";
            this.tsTxtQuickSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tsTxtQuickSearch_KeyDown);
            // 
            // tsBtnQuickSearch
            // 
            this.tsBtnQuickSearch.Checked = true;
            this.tsBtnQuickSearch.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tsBtnQuickSearch.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsBtnQuickSearch.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tsBtnQuickSearch.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.tsBtnQuickSearch.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnQuickSearch.Margin = new System.Windows.Forms.Padding(0, 1, 5, 2);
            this.tsBtnQuickSearch.Name = "tsBtnQuickSearch";
            this.tsBtnQuickSearch.Padding = new System.Windows.Forms.Padding(0, 0, 20, 0);
            this.tsBtnQuickSearch.Size = new System.Drawing.Size(77, 31);
            this.tsBtnQuickSearch.Text = "快速检索";
            this.tsBtnQuickSearch.Click += new System.EventHandler(this.tsBtnQuickSearch_Click);
            // 
            // tsBtnQuickSearchClear
            // 
            this.tsBtnQuickSearchClear.Checked = true;
            this.tsBtnQuickSearchClear.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tsBtnQuickSearchClear.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsBtnQuickSearchClear.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tsBtnQuickSearchClear.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.tsBtnQuickSearchClear.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnQuickSearchClear.Margin = new System.Windows.Forms.Padding(0, 1, 5, 2);
            this.tsBtnQuickSearchClear.Name = "tsBtnQuickSearchClear";
            this.tsBtnQuickSearchClear.Padding = new System.Windows.Forms.Padding(0, 0, 20, 0);
            this.tsBtnQuickSearchClear.Size = new System.Drawing.Size(53, 31);
            this.tsBtnQuickSearchClear.Text = "清空";
            this.tsBtnQuickSearchClear.Click += new System.EventHandler(this.tsBtnQuickSearchClear_Click);
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(6, 34);
            // 
            // tsBtnAdvancedSearch
            // 
            this.tsBtnAdvancedSearch.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsBtnAdvancedSearch.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tsBtnAdvancedSearch.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.tsBtnAdvancedSearch.Image = ((System.Drawing.Image)(resources.GetObject("tsBtnAdvancedSearch.Image")));
            this.tsBtnAdvancedSearch.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnAdvancedSearch.Name = "tsBtnAdvancedSearch";
            this.tsBtnAdvancedSearch.Size = new System.Drawing.Size(57, 31);
            this.tsBtnAdvancedSearch.Text = "高级查询";
            this.tsBtnAdvancedSearch.Click += new System.EventHandler(this.tsBtnAdvancedSearch_Click);
            // 
            // toolStripTop1
            // 
            this.toolStripTop1.AutoSize = false;
            this.toolStripTop1.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.toolStripTop1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsBtnAdd,
            this.tsBtnEditor,
            this.tsBtnView,
            this.tsBtnDelete,
            this.toolStripSeparator5,
            this.tsBtnClose});
            this.toolStripTop1.Location = new System.Drawing.Point(0, 0);
            this.toolStripTop1.Name = "toolStripTop1";
            this.toolStripTop1.Size = new System.Drawing.Size(829, 34);
            this.toolStripTop1.TabIndex = 10;
            this.toolStripTop1.Text = "toolStrip2";
            // 
            // tsBtnAdd
            // 
            this.tsBtnAdd.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.tsBtnAdd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsBtnAdd.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tsBtnAdd.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.tsBtnAdd.Image = ((System.Drawing.Image)(resources.GetObject("tsBtnAdd.Image")));
            this.tsBtnAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnAdd.Name = "tsBtnAdd";
            this.tsBtnAdd.Size = new System.Drawing.Size(36, 31);
            this.tsBtnAdd.Text = "增加";
            this.tsBtnAdd.Click += new System.EventHandler(this.tsBtnAdd_Click);
            // 
            // tsBtnEditor
            // 
            this.tsBtnEditor.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.tsBtnEditor.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsBtnEditor.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tsBtnEditor.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.tsBtnEditor.Image = ((System.Drawing.Image)(resources.GetObject("tsBtnEditor.Image")));
            this.tsBtnEditor.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnEditor.Name = "tsBtnEditor";
            this.tsBtnEditor.Size = new System.Drawing.Size(36, 31);
            this.tsBtnEditor.Text = "编辑";
            this.tsBtnEditor.Click += new System.EventHandler(this.tsBtnEditor_Click);
            // 
            // tsBtnView
            // 
            this.tsBtnView.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.tsBtnView.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsBtnView.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tsBtnView.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.tsBtnView.Image = ((System.Drawing.Image)(resources.GetObject("tsBtnView.Image")));
            this.tsBtnView.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnView.Name = "tsBtnView";
            this.tsBtnView.Size = new System.Drawing.Size(36, 31);
            this.tsBtnView.Text = "查看";
            this.tsBtnView.Click += new System.EventHandler(this.tsBtnView_Click);
            // 
            // tsBtnDelete
            // 
            this.tsBtnDelete.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.tsBtnDelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsBtnDelete.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tsBtnDelete.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.tsBtnDelete.Image = ((System.Drawing.Image)(resources.GetObject("tsBtnDelete.Image")));
            this.tsBtnDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnDelete.Name = "tsBtnDelete";
            this.tsBtnDelete.Size = new System.Drawing.Size(36, 31);
            this.tsBtnDelete.Text = "删除";
            this.tsBtnDelete.Click += new System.EventHandler(this.tsBtnDelete_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 34);
            // 
            // tsBtnClose
            // 
            this.tsBtnClose.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsBtnClose.BackColor = System.Drawing.Color.Transparent;
            this.tsBtnClose.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsBtnClose.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.tsBtnClose.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnClose.Margin = new System.Windows.Forms.Padding(0, 1, 15, 2);
            this.tsBtnClose.Name = "tsBtnClose";
            this.tsBtnClose.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.tsBtnClose.Size = new System.Drawing.Size(51, 31);
            this.tsBtnClose.Text = "退出";
            this.tsBtnClose.Click += new System.EventHandler(this.tsBtnClose_Click);
            // 
            // FrmListBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(829, 410);
            this.Controls.Add(this.toolStripTop2);
            this.Controls.Add(this.toolStripTop1);
            this.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.HideOnClose = true;
            this.Name = "FrmListBase";
            this.Text = "ListBaseForm";
            this.Load += new System.EventHandler(this.ListForm_Load);
            this.toolStripTop2.ResumeLayout(false);
            this.toolStripTop2.PerformLayout();
            this.toolStripTop1.ResumeLayout(false);
            this.toolStripTop1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.ToolStrip toolStripTop1;
        public System.Windows.Forms.ToolStripButton tsBtnAdd;
        public System.Windows.Forms.ToolStripButton tsBtnEditor;
        public System.Windows.Forms.ToolStripButton tsBtnView;
        public System.Windows.Forms.ToolStripButton tsBtnDelete;
        public System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        public System.Windows.Forms.ToolStripButton tsBtnClose;
        public System.Windows.Forms.ToolStripButton tsBtnAdvancedSearch;
        public System.Windows.Forms.ToolStripButton tsBtnQuickSearchClear;

        public System.Windows.Forms.ToolStrip toolStripTop2;
        public System.Windows.Forms.ToolStripButton tsBtnQuickSearch;
        public System.Windows.Forms.ToolStripTextBox tsTxtQuickSearch;
        public System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
    }
}