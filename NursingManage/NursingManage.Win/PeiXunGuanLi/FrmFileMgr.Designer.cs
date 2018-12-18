namespace NursingManage.Win.PeiXunGuanLi
{
    partial class FrmFileMgr
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
            this.components = new System.ComponentModel.Container();
            this.lstView = new System.Windows.Forms.ListView();
            this.colHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cttMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuItemUploadFile = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemDownloadFile = new System.Windows.Forms.ToolStripMenuItem();
            this.txtBoxUrl = new System.Windows.Forms.TextBox();
            this.btnGo = new System.Windows.Forms.Button();
            this.sfd = new System.Windows.Forms.SaveFileDialog();
            this.ofd = new System.Windows.Forms.OpenFileDialog();
            this.cttMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstView
            // 
            this.lstView.AllowDrop = true;
            this.lstView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colHeader});
            this.lstView.ContextMenuStrip = this.cttMenu;
            this.lstView.FullRowSelect = true;
            this.lstView.Location = new System.Drawing.Point(2, 31);
            this.lstView.MultiSelect = false;
            this.lstView.Name = "lstView";
            this.lstView.Size = new System.Drawing.Size(906, 394);
            this.lstView.TabIndex = 1;
            this.lstView.UseCompatibleStateImageBehavior = false;
            this.lstView.View = System.Windows.Forms.View.Details;
            this.lstView.DragDrop += new System.Windows.Forms.DragEventHandler(this.lstView_DragDrop);
            this.lstView.DragEnter += new System.Windows.Forms.DragEventHandler(this.lstView_DragEnter);
            // 
            // colHeader
            // 
            this.colHeader.Text = "文件名";
            this.colHeader.Width = 250;
            // 
            // cttMenu
            // 
            this.cttMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cttMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemUploadFile,
            this.menuItemDownloadFile});
            this.cttMenu.Name = "cttMenu";
            this.cttMenu.Size = new System.Drawing.Size(139, 52);
            // 
            // menuItemUploadFile
            // 
            this.menuItemUploadFile.Name = "menuItemUploadFile";
            this.menuItemUploadFile.Size = new System.Drawing.Size(138, 24);
            this.menuItemUploadFile.Text = "上传文件";
            this.menuItemUploadFile.Click += new System.EventHandler(this.menuItemUploadFile_Click);
            // 
            // menuItemDownloadFile
            // 
            this.menuItemDownloadFile.Name = "menuItemDownloadFile";
            this.menuItemDownloadFile.Size = new System.Drawing.Size(138, 24);
            this.menuItemDownloadFile.Text = "下载文件";
            this.menuItemDownloadFile.Click += new System.EventHandler(this.menuItemDownloadFile_Click);
            // 
            // txtBoxUrl
            // 
            this.txtBoxUrl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxUrl.Location = new System.Drawing.Point(0, 0);
            this.txtBoxUrl.Name = "txtBoxUrl";
            this.txtBoxUrl.Size = new System.Drawing.Size(813, 25);
            this.txtBoxUrl.TabIndex = 2;
            // 
            // btnGo
            // 
            this.btnGo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGo.Location = new System.Drawing.Point(831, 2);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(75, 23);
            this.btnGo.TabIndex = 3;
            this.btnGo.Text = "GO";
            this.btnGo.UseVisualStyleBackColor = true;
            this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
            // 
            // FrmFileMgr
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(918, 429);
            this.Controls.Add(this.btnGo);
            this.Controls.Add(this.txtBoxUrl);
            this.Controls.Add(this.lstView);
            this.KeyPreview = true;
            this.Name = "FrmFileMgr";
            this.Text = "文件管理";
            this.Load += new System.EventHandler(this.FrmFileMgr_Load);
            this.Controls.SetChildIndex(this.lstView, 0);
            this.Controls.SetChildIndex(this.txtBoxUrl, 0);
            this.Controls.SetChildIndex(this.btnGo, 0);
            this.cttMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lstView;
        private System.Windows.Forms.TextBox txtBoxUrl;
        private System.Windows.Forms.Button btnGo;
        private System.Windows.Forms.ColumnHeader colHeader;
        private System.Windows.Forms.ContextMenuStrip cttMenu;
        private System.Windows.Forms.ToolStripMenuItem menuItemUploadFile;
        private System.Windows.Forms.ToolStripMenuItem menuItemDownloadFile;
        private System.Windows.Forms.SaveFileDialog sfd;
        private System.Windows.Forms.OpenFileDialog ofd;
    }
}