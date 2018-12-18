namespace NursingManage.Win.ZhiLiangKongZhi
{
    partial class FrmZhiKongJianCha_KeShi_ChuangJian
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
            this.dtpJianChaShiJian = new System.Windows.Forms.DateTimePicker();
            this.dcm1 = new Framework.WinCommon.Components.DCM(this.components);
            this.txtZHIKONGRENYUAN = new Framework.WinCommon.Controls.ZCTextBox();
            this.txtCANJIARENYUAN = new Framework.WinCommon.Controls.ZCTextBox();
            this.txtJIANGPINGREN = new Framework.WinCommon.Controls.ZCTextBox();
            this.txtJIANGPINGSHIJIAN = new System.Windows.Forms.DateTimePicker();
            this.txtBEIZHU = new Framework.WinCommon.Controls.ZCTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.ce = new Framework.WinCommon.Components.ControlExtend(this.components);
            this.btnZhiKongRenYuanXuanZe = new System.Windows.Forms.Button();
            this.btnCanJiaRenYuanXuanZe = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "检查时间：";
            // 
            // dtpJianChaShiJian
            // 
            this.ce.SetEnterIsTab(this.dtpJianChaShiJian, true);
            this.dcm1.SetIsUse(this.dtpJianChaShiJian, true);
            this.dtpJianChaShiJian.Location = new System.Drawing.Point(121, 24);
            this.dtpJianChaShiJian.Name = "dtpJianChaShiJian";
            this.dtpJianChaShiJian.Size = new System.Drawing.Size(168, 25);
            this.dtpJianChaShiJian.TabIndex = 0;
            this.dcm1.SetTagColumnName(this.dtpJianChaShiJian, null);
            this.dcm1.SetTextColumnName(this.dtpJianChaShiJian, "JIANCHARIQI");
            // 
            // txtZHIKONGRENYUAN
            // 
            this.txtZHIKONGRENYUAN.EmptyTextTip = null;
            this.txtZHIKONGRENYUAN.EmptyTextTipColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.txtZHIKONGRENYUAN.EnterIsTab = false;
            this.ce.SetEnterIsTab(this.txtZHIKONGRENYUAN, true);
            this.dcm1.SetIsUse(this.txtZHIKONGRENYUAN, true);
            this.txtZHIKONGRENYUAN.Location = new System.Drawing.Point(121, 60);
            this.txtZHIKONGRENYUAN.Name = "txtZHIKONGRENYUAN";
            this.txtZHIKONGRENYUAN.Size = new System.Drawing.Size(370, 25);
            this.txtZHIKONGRENYUAN.TabIndex = 1;
            this.dcm1.SetTagColumnName(this.txtZHIKONGRENYUAN, null);
            this.dcm1.SetTextColumnName(this.txtZHIKONGRENYUAN, "ZHIKONGRENYUAN");
            // 
            // txtCANJIARENYUAN
            // 
            this.txtCANJIARENYUAN.EmptyTextTip = null;
            this.txtCANJIARENYUAN.EmptyTextTipColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.txtCANJIARENYUAN.EnterIsTab = false;
            this.ce.SetEnterIsTab(this.txtCANJIARENYUAN, true);
            this.dcm1.SetIsUse(this.txtCANJIARENYUAN, true);
            this.txtCANJIARENYUAN.Location = new System.Drawing.Point(121, 96);
            this.txtCANJIARENYUAN.Name = "txtCANJIARENYUAN";
            this.txtCANJIARENYUAN.Size = new System.Drawing.Size(370, 25);
            this.txtCANJIARENYUAN.TabIndex = 2;
            this.dcm1.SetTagColumnName(this.txtCANJIARENYUAN, null);
            this.dcm1.SetTextColumnName(this.txtCANJIARENYUAN, "CANJIARENYUAN");
            // 
            // txtJIANGPINGREN
            // 
            this.txtJIANGPINGREN.EmptyTextTip = null;
            this.txtJIANGPINGREN.EmptyTextTipColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.txtJIANGPINGREN.EnterIsTab = false;
            this.ce.SetEnterIsTab(this.txtJIANGPINGREN, true);
            this.dcm1.SetIsUse(this.txtJIANGPINGREN, true);
            this.txtJIANGPINGREN.Location = new System.Drawing.Point(433, 132);
            this.txtJIANGPINGREN.Name = "txtJIANGPINGREN";
            this.txtJIANGPINGREN.Size = new System.Drawing.Size(135, 25);
            this.txtJIANGPINGREN.TabIndex = 4;
            this.dcm1.SetTagColumnName(this.txtJIANGPINGREN, null);
            this.dcm1.SetTextColumnName(this.txtJIANGPINGREN, "JIANGPINGREN");
            // 
            // txtJIANGPINGSHIJIAN
            // 
            this.ce.SetEnterIsTab(this.txtJIANGPINGSHIJIAN, true);
            this.dcm1.SetIsUse(this.txtJIANGPINGSHIJIAN, true);
            this.txtJIANGPINGSHIJIAN.Location = new System.Drawing.Point(121, 132);
            this.txtJIANGPINGSHIJIAN.Name = "txtJIANGPINGSHIJIAN";
            this.txtJIANGPINGSHIJIAN.Size = new System.Drawing.Size(168, 25);
            this.txtJIANGPINGSHIJIAN.TabIndex = 3;
            this.dcm1.SetTagColumnName(this.txtJIANGPINGSHIJIAN, null);
            this.dcm1.SetTextColumnName(this.txtJIANGPINGSHIJIAN, "JIANGPINGSHIJIAN");
            // 
            // txtBEIZHU
            // 
            this.txtBEIZHU.EmptyTextTip = null;
            this.txtBEIZHU.EmptyTextTipColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.txtBEIZHU.EnterIsTab = false;
            this.ce.SetEnterIsTab(this.txtBEIZHU, true);
            this.dcm1.SetIsUse(this.txtBEIZHU, true);
            this.txtBEIZHU.Location = new System.Drawing.Point(121, 170);
            this.txtBEIZHU.Multiline = true;
            this.txtBEIZHU.Name = "txtBEIZHU";
            this.txtBEIZHU.Size = new System.Drawing.Size(447, 61);
            this.txtBEIZHU.TabIndex = 5;
            this.dcm1.SetTagColumnName(this.txtBEIZHU, null);
            this.dcm1.SetTextColumnName(this.txtBEIZHU, "BEIZHU");
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "质控人员：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "参加人员：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 138);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "讲评时间：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(360, 141);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 15);
            this.label5.TabIndex = 3;
            this.label5.Text = "讲评人：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(63, 173);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 15);
            this.label6.TabIndex = 3;
            this.label6.Text = "备注：";
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(393, 248);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 32);
            this.btnOK.TabIndex = 6;
            this.btnOK.Text = "确定";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(500, 248);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 32);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnZhiKongRenYuanXuanZe
            // 
            this.btnZhiKongRenYuanXuanZe.Location = new System.Drawing.Point(500, 58);
            this.btnZhiKongRenYuanXuanZe.Name = "btnZhiKongRenYuanXuanZe";
            this.btnZhiKongRenYuanXuanZe.Size = new System.Drawing.Size(68, 25);
            this.btnZhiKongRenYuanXuanZe.TabIndex = 8;
            this.btnZhiKongRenYuanXuanZe.Text = "选择";
            this.btnZhiKongRenYuanXuanZe.UseVisualStyleBackColor = true;
            this.btnZhiKongRenYuanXuanZe.Click += new System.EventHandler(this.btnZhiKongRenYuanXuanZe_Click);
            // 
            // btnCanJiaRenYuanXuanZe
            // 
            this.btnCanJiaRenYuanXuanZe.Location = new System.Drawing.Point(500, 95);
            this.btnCanJiaRenYuanXuanZe.Name = "btnCanJiaRenYuanXuanZe";
            this.btnCanJiaRenYuanXuanZe.Size = new System.Drawing.Size(68, 25);
            this.btnCanJiaRenYuanXuanZe.TabIndex = 8;
            this.btnCanJiaRenYuanXuanZe.Text = "选择";
            this.btnCanJiaRenYuanXuanZe.UseVisualStyleBackColor = true;
            this.btnCanJiaRenYuanXuanZe.Click += new System.EventHandler(this.btnCanJiaRenYuanXuanZe_Click);
            // 
            // FrmZhiKongJianCha_KeShi_ChuangJian
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(609, 302);
            this.Controls.Add(this.btnCanJiaRenYuanXuanZe);
            this.Controls.Add(this.btnZhiKongRenYuanXuanZe);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.txtBEIZHU);
            this.Controls.Add(this.txtJIANGPINGREN);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtCANJIARENYUAN);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtZHIKONGRENYUAN);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtJIANGPINGSHIJIAN);
            this.Controls.Add(this.dtpJianChaShiJian);
            this.Controls.Add(this.label1);
            this.KeyPreview = true;
            this.Name = "FrmZhiKongJianCha_KeShi_ChuangJian";
            this.Text = "科室质控检查创建";
            this.Load += new System.EventHandler(this.FrmZhiKongJianCha_KeShi_ChuangJian_Load);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.dtpJianChaShiJian, 0);
            this.Controls.SetChildIndex(this.txtJIANGPINGSHIJIAN, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.txtZHIKONGRENYUAN, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.txtCANJIARENYUAN, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.label6, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.txtJIANGPINGREN, 0);
            this.Controls.SetChildIndex(this.txtBEIZHU, 0);
            this.Controls.SetChildIndex(this.btnOK, 0);
            this.Controls.SetChildIndex(this.btnCancel, 0);
            this.Controls.SetChildIndex(this.btnZhiKongRenYuanXuanZe, 0);
            this.Controls.SetChildIndex(this.btnCanJiaRenYuanXuanZe, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpJianChaShiJian;
        private Framework.WinCommon.Components.DCM dcm1;
        private System.Windows.Forms.Label label2;
        private Framework.WinCommon.Controls.ZCTextBox txtZHIKONGRENYUAN;
        private System.Windows.Forms.Label label3;
        private Framework.WinCommon.Controls.ZCTextBox txtCANJIARENYUAN;
        private System.Windows.Forms.Label label4;
        private Framework.WinCommon.Controls.ZCTextBox txtJIANGPINGREN;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker txtJIANGPINGSHIJIAN;
        private System.Windows.Forms.Label label6;
        private Framework.WinCommon.Controls.ZCTextBox txtBEIZHU;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private Framework.WinCommon.Components.ControlExtend ce;
        private System.Windows.Forms.Button btnZhiKongRenYuanXuanZe;
        private System.Windows.Forms.Button btnCanJiaRenYuanXuanZe;
    }
}