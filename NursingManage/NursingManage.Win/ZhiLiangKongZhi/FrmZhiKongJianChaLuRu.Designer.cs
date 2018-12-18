namespace NursingManage.Win.ZhiLiangKongZhi
{
    partial class FrmZhiKongJianChaLuRu
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
            this.txtJianChaRenYuan = new Framework.WinCommon.Controls.ZCTextBox();
            this.btnXuanZeRenYuan = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpJianChaKaiShi = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpJianChaJieShu = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpXianQiZhengGai = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.txtkeShi = new Framework.WinCommon.Controls.ZCTextBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.dcm1 = new Framework.WinCommon.Components.DCM(this.components);
            this.ce = new Framework.WinCommon.Components.ControlExtend(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "检查人员：";
            // 
            // txtJianChaRenYuan
            // 
            this.txtJianChaRenYuan.EmptyTextTip = null;
            this.txtJianChaRenYuan.EmptyTextTipColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.txtJianChaRenYuan.EnterIsTab = false;
            this.ce.SetEnterIsTab(this.txtJianChaRenYuan, true);
            this.dcm1.SetIsUse(this.txtJianChaRenYuan, true);
            this.txtJianChaRenYuan.Location = new System.Drawing.Point(127, 124);
            this.txtJianChaRenYuan.Multiline = true;
            this.txtJianChaRenYuan.Name = "txtJianChaRenYuan";
            this.txtJianChaRenYuan.Size = new System.Drawing.Size(330, 47);
            this.txtJianChaRenYuan.TabIndex = 4;
            this.dcm1.SetTagColumnName(this.txtJianChaRenYuan, null);
            this.dcm1.SetTextColumnName(this.txtJianChaRenYuan, "JIANCHARENYUAN");
            // 
            // btnXuanZeRenYuan
            // 
            this.btnXuanZeRenYuan.Location = new System.Drawing.Point(463, 124);
            this.btnXuanZeRenYuan.Name = "btnXuanZeRenYuan";
            this.btnXuanZeRenYuan.Size = new System.Drawing.Size(47, 47);
            this.btnXuanZeRenYuan.TabIndex = 5;
            this.btnXuanZeRenYuan.Text = "选择";
            this.btnXuanZeRenYuan.UseVisualStyleBackColor = true;
            this.btnXuanZeRenYuan.Click += new System.EventHandler(this.btnXuanZeRenYuan_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "检查日期：";
            // 
            // dtpJianChaKaiShi
            // 
            this.dtpJianChaKaiShi.CustomFormat = "yyyy-MM-dd";
            this.ce.SetEnterIsTab(this.dtpJianChaKaiShi, true);
            this.dcm1.SetIsUse(this.dtpJianChaKaiShi, true);
            this.dtpJianChaKaiShi.Location = new System.Drawing.Point(127, 63);
            this.dtpJianChaKaiShi.Name = "dtpJianChaKaiShi";
            this.dtpJianChaKaiShi.Size = new System.Drawing.Size(136, 25);
            this.dtpJianChaKaiShi.TabIndex = 1;
            this.dcm1.SetTagColumnName(this.dtpJianChaKaiShi, null);
            this.dcm1.SetTextColumnName(this.dtpJianChaKaiShi, "JIANCHAKAISHISHIJIAN");
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(277, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(22, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "至";
            // 
            // dtpJianChaJieShu
            // 
            this.dtpJianChaJieShu.CustomFormat = "yyyy-MM-dd";
            this.ce.SetEnterIsTab(this.dtpJianChaJieShu, true);
            this.dcm1.SetIsUse(this.dtpJianChaJieShu, true);
            this.dtpJianChaJieShu.Location = new System.Drawing.Point(321, 63);
            this.dtpJianChaJieShu.Name = "dtpJianChaJieShu";
            this.dtpJianChaJieShu.Size = new System.Drawing.Size(137, 25);
            this.dtpJianChaJieShu.TabIndex = 2;
            this.dcm1.SetTagColumnName(this.dtpJianChaJieShu, null);
            this.dcm1.SetTextColumnName(this.dtpJianChaJieShu, "JIANCHAJIESHUSHIJIAN");
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "限期整改日期：";
            // 
            // dtpXianQiZhengGai
            // 
            this.dtpXianQiZhengGai.CustomFormat = "yyyy-MM-dd";
            this.ce.SetEnterIsTab(this.dtpXianQiZhengGai, true);
            this.dcm1.SetIsUse(this.dtpXianQiZhengGai, true);
            this.dtpXianQiZhengGai.Location = new System.Drawing.Point(127, 93);
            this.dtpXianQiZhengGai.Name = "dtpXianQiZhengGai";
            this.dtpXianQiZhengGai.Size = new System.Drawing.Size(136, 25);
            this.dtpXianQiZhengGai.TabIndex = 3;
            this.dcm1.SetTagColumnName(this.dtpXianQiZhengGai, null);
            this.dcm1.SetTextColumnName(this.dtpXianQiZhengGai, "GAIJINSHIJIAN_XIANQI");
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(68, 33);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 15);
            this.label6.TabIndex = 8;
            this.label6.Text = "科室：";
            // 
            // txtkeShi
            // 
            this.txtkeShi.EmptyTextTip = null;
            this.txtkeShi.EmptyTextTipColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.txtkeShi.EnterIsTab = false;
            this.ce.SetEnterIsTab(this.txtkeShi, true);
            this.dcm1.SetIsUse(this.txtkeShi, true);
            this.txtkeShi.Location = new System.Drawing.Point(126, 30);
            this.txtkeShi.Name = "txtkeShi";
            this.txtkeShi.ReadOnly = true;
            this.txtkeShi.Size = new System.Drawing.Size(332, 25);
            this.txtkeShi.TabIndex = 0;
            this.dcm1.SetTagColumnName(this.txtkeShi, null);
            this.dcm1.SetTextColumnName(this.txtkeShi, "KESHI");
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(273, 187);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 28);
            this.btnOK.TabIndex = 6;
            this.btnOK.Text = "确定";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(383, 187);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 28);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // FrmZhiKongJianChaLuRu
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(533, 238);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.txtkeShi);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtpJianChaJieShu);
            this.Controls.Add(this.dtpXianQiZhengGai);
            this.Controls.Add(this.dtpJianChaKaiShi);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnXuanZeRenYuan);
            this.Controls.Add(this.txtJianChaRenYuan);
            this.Controls.Add(this.label1);
            this.KeyPreview = true;
            this.Name = "FrmZhiKongJianChaLuRu";
            this.Text = "检查结果录入";
            this.Load += new System.EventHandler(this.FrmZhiKongJianChaLuRu_Load);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.txtJianChaRenYuan, 0);
            this.Controls.SetChildIndex(this.btnXuanZeRenYuan, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.dtpJianChaKaiShi, 0);
            this.Controls.SetChildIndex(this.dtpXianQiZhengGai, 0);
            this.Controls.SetChildIndex(this.dtpJianChaJieShu, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.label6, 0);
            this.Controls.SetChildIndex(this.txtkeShi, 0);
            this.Controls.SetChildIndex(this.btnOK, 0);
            this.Controls.SetChildIndex(this.btnCancel, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Framework.WinCommon.Controls.ZCTextBox txtJianChaRenYuan;
        private System.Windows.Forms.Button btnXuanZeRenYuan;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpJianChaKaiShi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpJianChaJieShu;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpXianQiZhengGai;
        private System.Windows.Forms.Label label6;
        private Framework.WinCommon.Controls.ZCTextBox txtkeShi;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private Framework.WinCommon.Components.DCM dcm1;
        private Framework.WinCommon.Components.ControlExtend ce;
    }
}