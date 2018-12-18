namespace NursingManage.Win.ZhiLiangKongZhi
{
    partial class FrmZhiLiangBiaoZhunEdit
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtXuHao = new Framework.WinCommon.Controls.ZCTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtLeiXing1 = new Framework.WinCommon.Controls.ZCTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtLeiXing2 = new Framework.WinCommon.Controls.ZCTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNeiRong = new Framework.WinCommon.Controls.ZCTextBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.dcm1 = new Framework.WinCommon.Components.DCM(this.components);
            this.ce = new Framework.WinCommon.Components.ControlExtend(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "序号：";
            // 
            // txtXuHao
            // 
            this.txtXuHao.EmptyTextTip = null;
            this.txtXuHao.EmptyTextTipColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.txtXuHao.EnterIsTab = true;
            this.ce.SetEnterIsTab(this.txtXuHao, true);
            this.dcm1.SetIsUse(this.txtXuHao, true);
            this.txtXuHao.Location = new System.Drawing.Point(97, 27);
            this.txtXuHao.Name = "txtXuHao";
            this.txtXuHao.Size = new System.Drawing.Size(336, 21);
            this.txtXuHao.TabIndex = 0;
            this.dcm1.SetTagColumnName(this.txtXuHao, null);
            this.dcm1.SetTextColumnName(this.txtXuHao, "XUHAO");
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "一级类型：";
            // 
            // txtLeiXing1
            // 
            this.txtLeiXing1.EmptyTextTip = null;
            this.txtLeiXing1.EmptyTextTipColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.txtLeiXing1.EnterIsTab = true;
            this.ce.SetEnterIsTab(this.txtLeiXing1, true);
            this.dcm1.SetIsUse(this.txtLeiXing1, true);
            this.txtLeiXing1.Location = new System.Drawing.Point(97, 57);
            this.txtLeiXing1.Name = "txtLeiXing1";
            this.txtLeiXing1.Size = new System.Drawing.Size(336, 21);
            this.txtLeiXing1.TabIndex = 1;
            this.dcm1.SetTagColumnName(this.txtLeiXing1, null);
            this.dcm1.SetTextColumnName(this.txtLeiXing1, "LEIXING1");
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 1;
            this.label3.Text = "二级类型：";
            // 
            // txtLeiXing2
            // 
            this.txtLeiXing2.EmptyTextTip = null;
            this.txtLeiXing2.EmptyTextTipColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.txtLeiXing2.EnterIsTab = true;
            this.ce.SetEnterIsTab(this.txtLeiXing2, true);
            this.dcm1.SetIsUse(this.txtLeiXing2, true);
            this.txtLeiXing2.Location = new System.Drawing.Point(97, 87);
            this.txtLeiXing2.Name = "txtLeiXing2";
            this.txtLeiXing2.Size = new System.Drawing.Size(336, 21);
            this.txtLeiXing2.TabIndex = 2;
            this.dcm1.SetTagColumnName(this.txtLeiXing2, null);
            this.dcm1.SetTextColumnName(this.txtLeiXing2, "LEIXING2");
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 1;
            this.label4.Text = "评价标准：";
            // 
            // txtNeiRong
            // 
            this.txtNeiRong.EmptyTextTip = null;
            this.txtNeiRong.EmptyTextTipColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.txtNeiRong.EnterIsTab = true;
            this.ce.SetEnterIsTab(this.txtNeiRong, true);
            this.dcm1.SetIsUse(this.txtNeiRong, true);
            this.txtNeiRong.Location = new System.Drawing.Point(97, 117);
            this.txtNeiRong.Multiline = true;
            this.txtNeiRong.Name = "txtNeiRong";
            this.txtNeiRong.Size = new System.Drawing.Size(336, 48);
            this.txtNeiRong.TabIndex = 3;
            this.dcm1.SetTagColumnName(this.txtNeiRong, null);
            this.dcm1.SetTextColumnName(this.txtNeiRong, "NEIRONG");
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(267, 177);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 4;
            this.btnOK.Text = "确定";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(358, 177);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // FrmZhiLiangBiaoZhunEdit
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(481, 222);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.txtNeiRong);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtLeiXing2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtLeiXing1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtXuHao);
            this.Controls.Add(this.label1);
            this.KeyPreview = true;
            this.Name = "FrmZhiLiangBiaoZhunEdit";
            this.Text = "质量评价标准";
            this.Load += new System.EventHandler(this.FrmZhiLiangBiaoZhunEdit_Load);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.txtXuHao, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.txtLeiXing1, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.txtLeiXing2, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.txtNeiRong, 0);
            this.Controls.SetChildIndex(this.btnOK, 0);
            this.Controls.SetChildIndex(this.btnCancel, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Framework.WinCommon.Controls.ZCTextBox txtXuHao;
        private System.Windows.Forms.Label label2;
        private Framework.WinCommon.Controls.ZCTextBox txtLeiXing1;
        private System.Windows.Forms.Label label3;
        private Framework.WinCommon.Controls.ZCTextBox txtLeiXing2;
        private System.Windows.Forms.Label label4;
        private Framework.WinCommon.Controls.ZCTextBox txtNeiRong;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private Framework.WinCommon.Components.DCM dcm1;
        private Framework.WinCommon.Components.ControlExtend ce;
    }
}