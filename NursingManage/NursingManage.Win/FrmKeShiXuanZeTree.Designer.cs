namespace NursingManage.Win
{
    partial class FrmKeShiXuanZeTree
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
            this.tv = new System.Windows.Forms.TreeView();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripTop1 = new System.Windows.Forms.ToolStrip();
            this.btnBaoCun = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.tsBtnClose = new System.Windows.Forms.ToolStripButton();
            this.toolStripTop1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tv
            // 
            this.tv.CheckBoxes = true;
            this.tv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tv.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tv.Location = new System.Drawing.Point(0, 38);
            this.tv.Name = "tv";
            this.tv.Size = new System.Drawing.Size(553, 290);
            this.tv.TabIndex = 40;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 328);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(553, 22);
            this.statusStrip1.TabIndex = 39;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripTop1
            // 
            this.toolStripTop1.AutoSize = false;
            this.toolStripTop1.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.toolStripTop1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnBaoCun,
            this.toolStripSeparator5,
            this.tsBtnClose});
            this.toolStripTop1.Location = new System.Drawing.Point(0, 0);
            this.toolStripTop1.Name = "toolStripTop1";
            this.toolStripTop1.Size = new System.Drawing.Size(553, 38);
            this.toolStripTop1.TabIndex = 38;
            this.toolStripTop1.Text = "toolStrip2";
            // 
            // btnBaoCun
            // 
            this.btnBaoCun.BackColor = System.Drawing.Color.Transparent;
            this.btnBaoCun.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnBaoCun.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnBaoCun.Image = global::NursingManage.Win.Properties.Resources.save;
            this.btnBaoCun.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnBaoCun.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnBaoCun.Name = "btnBaoCun";
            this.btnBaoCun.Size = new System.Drawing.Size(101, 35);
            this.btnBaoCun.Text = "保存退出";
            this.btnBaoCun.Click += new System.EventHandler(this.btnBaoCun_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 38);
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
            // FrmKeShiXuanZeTree
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(553, 350);
            this.Controls.Add(this.tv);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStripTop1);
            this.KeyPreview = true;
            this.Name = "FrmKeShiXuanZeTree";
            this.Text = "科室选择";
            this.Load += new System.EventHandler(this.FrmKeShiXuanZeTree_Load);
            this.Controls.SetChildIndex(this.toolStripTop1, 0);
            this.Controls.SetChildIndex(this.statusStrip1, 0);
            this.Controls.SetChildIndex(this.tv, 0);
            this.toolStripTop1.ResumeLayout(false);
            this.toolStripTop1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView tv;
        private System.Windows.Forms.StatusStrip statusStrip1;
        public System.Windows.Forms.ToolStrip toolStripTop1;
        public System.Windows.Forms.ToolStripButton btnBaoCun;
        public System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        public System.Windows.Forms.ToolStripButton tsBtnClose;
    }
}