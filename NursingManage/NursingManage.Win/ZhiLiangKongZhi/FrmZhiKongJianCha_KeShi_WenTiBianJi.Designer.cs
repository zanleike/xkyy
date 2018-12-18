namespace NursingManage.Win.ZhiLiangKongZhi
{
    partial class FrmZhiKongJianCha_KeShi_WenTiBianJi
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
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.txtJianChaJieGuo = new Framework.WinCommon.Controls.ZCTextBox();
            this.txtBiaoZhun = new Framework.WinCommon.Controls.ZCTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtLeiXing2 = new Framework.WinCommon.Controls.ZCTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtLeiXing1 = new Framework.WinCommon.Controls.ZCTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBIAOZHUNLEIBIE = new Framework.WinCommon.Controls.ZCTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dcm1 = new Framework.WinCommon.Components.DCM(this.components);
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(588, 218);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 27);
            this.btnCancel.TabIndex = 20;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(495, 218);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 27);
            this.btnOK.TabIndex = 18;
            this.btnOK.Text = "确定";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // txtJianChaJieGuo
            // 
            this.txtJianChaJieGuo.EmptyTextTip = null;
            this.txtJianChaJieGuo.EmptyTextTipColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.txtJianChaJieGuo.EnterIsTab = false;
            this.dcm1.SetIsUse(this.txtJianChaJieGuo, true);
            this.txtJianChaJieGuo.Location = new System.Drawing.Point(130, 146);
            this.txtJianChaJieGuo.Multiline = true;
            this.txtJianChaJieGuo.Name = "txtJianChaJieGuo";
            this.txtJianChaJieGuo.Size = new System.Drawing.Size(528, 52);
            this.txtJianChaJieGuo.TabIndex = 13;
            this.dcm1.SetTagColumnName(this.txtJianChaJieGuo, null);
            this.dcm1.SetTextColumnName(this.txtJianChaJieGuo, "WENTISHUOMING");
            // 
            // txtBiaoZhun
            // 
            this.txtBiaoZhun.EmptyTextTip = null;
            this.txtBiaoZhun.EmptyTextTipColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.txtBiaoZhun.EnterIsTab = false;
            this.dcm1.SetIsUse(this.txtBiaoZhun, true);
            this.txtBiaoZhun.Location = new System.Drawing.Point(130, 116);
            this.txtBiaoZhun.Name = "txtBiaoZhun";
            this.txtBiaoZhun.ReadOnly = true;
            this.txtBiaoZhun.Size = new System.Drawing.Size(528, 25);
            this.txtBiaoZhun.TabIndex = 24;
            this.dcm1.SetTagColumnName(this.txtBiaoZhun, null);
            this.dcm1.SetTextColumnName(this.txtBiaoZhun, "BIAOZHUN");
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(35, 149);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 15);
            this.label5.TabIndex = 17;
            this.label5.Text = "问题项说明：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 15);
            this.label4.TabIndex = 19;
            this.label4.Text = "标准问题项：";
            // 
            // txtLeiXing2
            // 
            this.txtLeiXing2.EmptyTextTip = null;
            this.txtLeiXing2.EmptyTextTipColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.txtLeiXing2.EnterIsTab = false;
            this.dcm1.SetIsUse(this.txtLeiXing2, true);
            this.txtLeiXing2.Location = new System.Drawing.Point(130, 86);
            this.txtLeiXing2.Name = "txtLeiXing2";
            this.txtLeiXing2.ReadOnly = true;
            this.txtLeiXing2.Size = new System.Drawing.Size(528, 25);
            this.txtLeiXing2.TabIndex = 23;
            this.dcm1.SetTagColumnName(this.txtLeiXing2, null);
            this.dcm1.SetTextColumnName(this.txtLeiXing2, "LEIXING2");
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(50, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 15);
            this.label3.TabIndex = 16;
            this.label3.Text = "二级类型：";
            // 
            // txtLeiXing1
            // 
            this.txtLeiXing1.EmptyTextTip = null;
            this.txtLeiXing1.EmptyTextTipColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.txtLeiXing1.EnterIsTab = false;
            this.dcm1.SetIsUse(this.txtLeiXing1, true);
            this.txtLeiXing1.Location = new System.Drawing.Point(130, 56);
            this.txtLeiXing1.Name = "txtLeiXing1";
            this.txtLeiXing1.ReadOnly = true;
            this.txtLeiXing1.Size = new System.Drawing.Size(528, 25);
            this.txtLeiXing1.TabIndex = 22;
            this.dcm1.SetTagColumnName(this.txtLeiXing1, null);
            this.dcm1.SetTextColumnName(this.txtLeiXing1, "LEIXING1");
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 15);
            this.label2.TabIndex = 15;
            this.label2.Text = "一级类型：";
            // 
            // txtBIAOZHUNLEIBIE
            // 
            this.txtBIAOZHUNLEIBIE.EmptyTextTip = null;
            this.txtBIAOZHUNLEIBIE.EmptyTextTipColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.txtBIAOZHUNLEIBIE.EnterIsTab = false;
            this.dcm1.SetIsUse(this.txtBIAOZHUNLEIBIE, true);
            this.txtBIAOZHUNLEIBIE.Location = new System.Drawing.Point(130, 26);
            this.txtBIAOZHUNLEIBIE.Name = "txtBIAOZHUNLEIBIE";
            this.txtBIAOZHUNLEIBIE.ReadOnly = true;
            this.txtBIAOZHUNLEIBIE.Size = new System.Drawing.Size(528, 25);
            this.txtBIAOZHUNLEIBIE.TabIndex = 21;
            this.dcm1.SetTagColumnName(this.txtBIAOZHUNLEIBIE, null);
            this.dcm1.SetTextColumnName(this.txtBIAOZHUNLEIBIE, "BIAOZHUNLEIBIE");
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 15);
            this.label1.TabIndex = 14;
            this.label1.Text = "标准类别：";
            // 
            // FrmZhiKongJianCha_KeShi_WenTiBianJi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(693, 272);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.txtJianChaJieGuo);
            this.Controls.Add(this.txtBiaoZhun);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtLeiXing2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtLeiXing1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtBIAOZHUNLEIBIE);
            this.Controls.Add(this.label1);
            this.KeyPreview = true;
            this.Name = "FrmZhiKongJianCha_KeShi_WenTiBianJi";
            this.Text = "问题项编辑";
            this.Load += new System.EventHandler(this.FrmZhiKongJianCha_KeShi_WenTiBianJi_Load);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.txtBIAOZHUNLEIBIE, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.txtLeiXing1, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.txtLeiXing2, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.txtBiaoZhun, 0);
            this.Controls.SetChildIndex(this.txtJianChaJieGuo, 0);
            this.Controls.SetChildIndex(this.btnOK, 0);
            this.Controls.SetChildIndex(this.btnCancel, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOK;
        private Framework.WinCommon.Controls.ZCTextBox txtJianChaJieGuo;
        private Framework.WinCommon.Controls.ZCTextBox txtBiaoZhun;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private Framework.WinCommon.Controls.ZCTextBox txtLeiXing2;
        private System.Windows.Forms.Label label3;
        private Framework.WinCommon.Controls.ZCTextBox txtLeiXing1;
        private System.Windows.Forms.Label label2;
        private Framework.WinCommon.Controls.ZCTextBox txtBIAOZHUNLEIBIE;
        private System.Windows.Forms.Label label1;
        private Framework.WinCommon.Components.DCM dcm1;
    }
}