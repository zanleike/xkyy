namespace Framework.WinCommon.Controls
{
    partial class UCPagingNavigation
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.toolStripPage = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel8 = new System.Windows.Forms.ToolStripLabel();
            this.tsCoBoxOnePage = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.tsBtnFirstPage = new System.Windows.Forms.ToolStripButton();
            this.tsBtnBackPage = new System.Windows.Forms.ToolStripButton();
            this.tsBtnNextPage = new System.Windows.Forms.ToolStripButton();
            this.tsBtnLastPage = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel4 = new System.Windows.Forms.ToolStripLabel();
            this.tsCoBoxSkipPage = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel3 = new System.Windows.Forms.ToolStripLabel();
            this.tsLblPageCount = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel5 = new System.Windows.Forms.ToolStripLabel();
            this.tsLblRecordCount = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel7 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStripPage
            // 
            this.toolStripPage.AutoSize = false;
            this.toolStripPage.BackColor = System.Drawing.Color.Transparent;
            this.toolStripPage.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStripPage.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.toolStripPage.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel8,
            this.tsCoBoxOnePage,
            this.toolStripSeparator4,
            this.tsBtnFirstPage,
            this.tsBtnBackPage,
            this.tsBtnNextPage,
            this.tsBtnLastPage,
            this.toolStripSeparator3,
            this.toolStripLabel4,
            this.tsCoBoxSkipPage,
            this.toolStripSeparator2,
            this.toolStripLabel3,
            this.tsLblPageCount,
            this.toolStripLabel2,
            this.toolStripSeparator1,
            this.toolStripLabel5,
            this.tsLblRecordCount,
            this.toolStripLabel7});
            this.toolStripPage.Location = new System.Drawing.Point(0, 1);
            this.toolStripPage.Name = "toolStripPage";
            this.toolStripPage.Size = new System.Drawing.Size(738, 35);
            this.toolStripPage.TabIndex = 10;
            this.toolStripPage.Text = "toolStrip1";
            // 
            // toolStripLabel8
            // 
            this.toolStripLabel8.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.toolStripLabel8.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.toolStripLabel8.Name = "toolStripLabel8";
            this.toolStripLabel8.Size = new System.Drawing.Size(59, 32);
            this.toolStripLabel8.Text = "每页条数:";
            // 
            // tsCoBoxOnePage
            // 
            this.tsCoBoxOnePage.AutoSize = false;
            this.tsCoBoxOnePage.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tsCoBoxOnePage.Items.AddRange(new object[] {
            "20",
            "50",
            "100",
            "不分页"});
            this.tsCoBoxOnePage.Name = "tsCoBoxOnePage";
            this.tsCoBoxOnePage.Size = new System.Drawing.Size(70, 20);
            this.tsCoBoxOnePage.SelectedIndexChanged += new System.EventHandler(this.tsCoBoxOnePage_SelectedIndexChanged);
            this.tsCoBoxOnePage.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tsCoBoxOnePage_KeyDown);
            this.tsCoBoxOnePage.Click += new System.EventHandler(this.tsCoBoxOnePage_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 35);
            // 
            // tsBtnFirstPage
            // 
            this.tsBtnFirstPage.BackColor = System.Drawing.Color.Transparent;
            this.tsBtnFirstPage.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsBtnFirstPage.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tsBtnFirstPage.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.tsBtnFirstPage.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnFirstPage.Name = "tsBtnFirstPage";
            this.tsBtnFirstPage.Size = new System.Drawing.Size(33, 32);
            this.tsBtnFirstPage.Text = "首页";
            this.tsBtnFirstPage.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            this.tsBtnFirstPage.Click += new System.EventHandler(this.tsBtnFirstPage_Click);
            // 
            // tsBtnBackPage
            // 
            this.tsBtnBackPage.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsBtnBackPage.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tsBtnBackPage.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.tsBtnBackPage.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnBackPage.Name = "tsBtnBackPage";
            this.tsBtnBackPage.Size = new System.Drawing.Size(45, 32);
            this.tsBtnBackPage.Text = "上一页";
            this.tsBtnBackPage.Click += new System.EventHandler(this.tsBtnBackPage_Click);
            // 
            // tsBtnNextPage
            // 
            this.tsBtnNextPage.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsBtnNextPage.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tsBtnNextPage.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.tsBtnNextPage.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnNextPage.Name = "tsBtnNextPage";
            this.tsBtnNextPage.Size = new System.Drawing.Size(45, 32);
            this.tsBtnNextPage.Text = "下一页";
            this.tsBtnNextPage.Click += new System.EventHandler(this.tsBtnNextPage_Click);
            // 
            // tsBtnLastPage
            // 
            this.tsBtnLastPage.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsBtnLastPage.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tsBtnLastPage.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.tsBtnLastPage.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnLastPage.Name = "tsBtnLastPage";
            this.tsBtnLastPage.Size = new System.Drawing.Size(33, 32);
            this.tsBtnLastPage.Text = "末页";
            this.tsBtnLastPage.Click += new System.EventHandler(this.tsBtnLastPage_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 35);
            // 
            // toolStripLabel4
            // 
            this.toolStripLabel4.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.toolStripLabel4.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.toolStripLabel4.Name = "toolStripLabel4";
            this.toolStripLabel4.Size = new System.Drawing.Size(47, 32);
            this.toolStripLabel4.Text = "当前页:";
            // 
            // tsCoBoxSkipPage
            // 
            this.tsCoBoxSkipPage.AutoSize = false;
            this.tsCoBoxSkipPage.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tsCoBoxSkipPage.Name = "tsCoBoxSkipPage";
            this.tsCoBoxSkipPage.Size = new System.Drawing.Size(50, 20);
            this.tsCoBoxSkipPage.SelectedIndexChanged += new System.EventHandler(this.tsCoBoxSkipPage_SelectedIndexChanged);
            this.tsCoBoxSkipPage.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tsCoBoxSkipPage_KeyDown);
            this.tsCoBoxSkipPage.Click += new System.EventHandler(this.tsCoBoxSkipPage_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 35);
            // 
            // toolStripLabel3
            // 
            this.toolStripLabel3.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.toolStripLabel3.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.toolStripLabel3.Name = "toolStripLabel3";
            this.toolStripLabel3.Size = new System.Drawing.Size(35, 32);
            this.toolStripLabel3.Text = "共计:";
            // 
            // tsLblPageCount
            // 
            this.tsLblPageCount.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tsLblPageCount.ForeColor = System.Drawing.Color.Red;
            this.tsLblPageCount.Name = "tsLblPageCount";
            this.tsLblPageCount.Size = new System.Drawing.Size(17, 32);
            this.tsLblPageCount.Text = "55";
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.toolStripLabel2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(17, 32);
            this.toolStripLabel2.Text = "页";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 35);
            // 
            // toolStripLabel5
            // 
            this.toolStripLabel5.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.toolStripLabel5.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.toolStripLabel5.Name = "toolStripLabel5";
            this.toolStripLabel5.Size = new System.Drawing.Size(35, 32);
            this.toolStripLabel5.Text = "共计:";
            // 
            // tsLblRecordCount
            // 
            this.tsLblRecordCount.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tsLblRecordCount.ForeColor = System.Drawing.Color.Red;
            this.tsLblRecordCount.Name = "tsLblRecordCount";
            this.tsLblRecordCount.Size = new System.Drawing.Size(35, 32);
            this.tsLblRecordCount.Text = "99999";
            // 
            // toolStripLabel7
            // 
            this.toolStripLabel7.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.toolStripLabel7.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.toolStripLabel7.Name = "toolStripLabel7";
            this.toolStripLabel7.Size = new System.Drawing.Size(41, 32);
            this.toolStripLabel7.Text = "条记录";
            // 
            // UCPagingNavigation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.toolStripPage);
            this.Name = "UCPagingNavigation";
            this.Size = new System.Drawing.Size(738, 36);
            this.toolStripPage.ResumeLayout(false);
            this.toolStripPage.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStripPage;
        private System.Windows.Forms.ToolStripLabel toolStripLabel8;
        private System.Windows.Forms.ToolStripComboBox tsCoBoxOnePage;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton tsBtnFirstPage;
        private System.Windows.Forms.ToolStripButton tsBtnBackPage;
        private System.Windows.Forms.ToolStripButton tsBtnNextPage;
        private System.Windows.Forms.ToolStripButton tsBtnLastPage;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripLabel toolStripLabel4;
        private System.Windows.Forms.ToolStripComboBox tsCoBoxSkipPage;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripLabel toolStripLabel3;
        private System.Windows.Forms.ToolStripLabel tsLblPageCount;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel5;
        private System.Windows.Forms.ToolStripLabel tsLblRecordCount;
        private System.Windows.Forms.ToolStripLabel toolStripLabel7;
    }
}
