namespace Framework.WinCommon.Forms
{
    partial class FrmBase
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
            this.cmsTagPageHead = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiCloseForm = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiColeOtherForm = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiCloseAllForm = new System.Windows.Forms.ToolStripMenuItem();
            this.bw = new System.ComponentModel.BackgroundWorker();
            this.lbMessage = new Framework.WinCommon.Controls.LabelMsg();
            this.cmsTagPageHead.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmsTagPageHead
            // 
            this.cmsTagPageHead.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiCloseForm,
            this.tsmiColeOtherForm,
            this.tsmiCloseAllForm});
            this.cmsTagPageHead.Name = "cmsTagPageHead";
            this.cmsTagPageHead.Size = new System.Drawing.Size(197, 70);
            // 
            // tsmiCloseForm
            // 
            this.tsmiCloseForm.Name = "tsmiCloseForm";
            this.tsmiCloseForm.Size = new System.Drawing.Size(196, 22);
            this.tsmiCloseForm.Text = "关闭";
            this.tsmiCloseForm.Click += new System.EventHandler(this.tsmiCloseForm_Click);
            // 
            // tsmiColeOtherForm
            // 
            this.tsmiColeOtherForm.Name = "tsmiColeOtherForm";
            this.tsmiColeOtherForm.Size = new System.Drawing.Size(196, 22);
            this.tsmiColeOtherForm.Text = "除此之外关闭所有窗体";
            this.tsmiColeOtherForm.Click += new System.EventHandler(this.tsmiColeOtherForm_Click);
            // 
            // tsmiCloseAllForm
            // 
            this.tsmiCloseAllForm.Name = "tsmiCloseAllForm";
            this.tsmiCloseAllForm.Size = new System.Drawing.Size(196, 22);
            this.tsmiCloseAllForm.Text = "关闭所有窗体";
            this.tsmiCloseAllForm.Click += new System.EventHandler(this.tsmiCloseAllForm_Click);
            // 
            // bw
            // 
            this.bw.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bw_DoWork);
            this.bw.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bw_RunWorkerCompleted);
            // 
            // lbMessage
            // 
            this.lbMessage.AutoSize = true;
            this.lbMessage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lbMessage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbMessage.Font = new System.Drawing.Font("微软雅黑", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbMessage.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbMessage.Location = new System.Drawing.Point(0, -50);
            this.lbMessage.Name = "lbMessage";
            this.lbMessage.Padding = new System.Windows.Forms.Padding(5);
            this.lbMessage.Size = new System.Drawing.Size(380, 41);
            this.lbMessage.TabIndex = 0;
            this.lbMessage.Text = "提示消息使用ShowMessage方法";
            this.lbMessage.ViewPosition = Framework.WinCommon.Controls.ControlPosition.Top;
            this.lbMessage.Visible = false;
            // 
            // FrmBase
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(784, 462);
            this.Controls.Add(this.lbMessage);
            this.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Name = "FrmBase";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.TabPageContextMenuStrip = this.cmsTagPageHead;
            this.Text = "BaseForm";
            this.Load += new System.EventHandler(this.FrmBase_Load);
            this.cmsTagPageHead.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Controls.LabelMsg lbMessage;
        private System.Windows.Forms.ContextMenuStrip cmsTagPageHead;
        private System.Windows.Forms.ToolStripMenuItem tsmiCloseForm;
        private System.Windows.Forms.ToolStripMenuItem tsmiColeOtherForm;
        private System.Windows.Forms.ToolStripMenuItem tsmiCloseAllForm;
        private System.ComponentModel.BackgroundWorker bw;
    }
}