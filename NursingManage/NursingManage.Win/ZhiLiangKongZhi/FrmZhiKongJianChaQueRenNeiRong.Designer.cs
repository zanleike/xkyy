namespace NursingManage.Win.ZhiLiangKongZhi
{
    partial class FrmZhiKongJianChaQueRenNeiRong
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
            this.label2 = new System.Windows.Forms.Label();
            this.txtKeShi = new Framework.WinCommon.Controls.ZCTextBox();
            this.txtBiaoZhunLeiBie = new Framework.WinCommon.Controls.ZCTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtHeGeLv = new Framework.WinCommon.Controls.ZCTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBiaoZhunShu = new Framework.WinCommon.Controls.ZCTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtWenTiShu = new Framework.WinCommon.Controls.ZCTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtJianChaRenYuan = new Framework.WinCommon.Controls.ZCTextBox();
            this.btnSelect = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.dcm1 = new Framework.WinCommon.Components.DCM(this.components);
            this.label7 = new System.Windows.Forms.Label();
            this.dtpJIANCHASHIJIAN = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(63, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "科室：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "质控标准：";
            // 
            // txtKeShi
            // 
            this.txtKeShi.EmptyTextTip = null;
            this.txtKeShi.EmptyTextTipColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.txtKeShi.EnterIsTab = false;
            this.dcm1.SetIsUse(this.txtKeShi, true);
            this.txtKeShi.Location = new System.Drawing.Point(111, 22);
            this.txtKeShi.Name = "txtKeShi";
            this.txtKeShi.ReadOnly = true;
            this.txtKeShi.Size = new System.Drawing.Size(295, 25);
            this.txtKeShi.TabIndex = 2;
            this.txtKeShi.TabStop = false;
            this.dcm1.SetTagColumnName(this.txtKeShi, null);
            this.dcm1.SetTextColumnName(this.txtKeShi, "KeShi");
            // 
            // txtBiaoZhunLeiBie
            // 
            this.txtBiaoZhunLeiBie.EmptyTextTip = null;
            this.txtBiaoZhunLeiBie.EmptyTextTipColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.txtBiaoZhunLeiBie.EnterIsTab = false;
            this.dcm1.SetIsUse(this.txtBiaoZhunLeiBie, true);
            this.txtBiaoZhunLeiBie.Location = new System.Drawing.Point(111, 56);
            this.txtBiaoZhunLeiBie.Name = "txtBiaoZhunLeiBie";
            this.txtBiaoZhunLeiBie.ReadOnly = true;
            this.txtBiaoZhunLeiBie.Size = new System.Drawing.Size(295, 25);
            this.txtBiaoZhunLeiBie.TabIndex = 2;
            this.txtBiaoZhunLeiBie.TabStop = false;
            this.dcm1.SetTagColumnName(this.txtBiaoZhunLeiBie, null);
            this.dcm1.SetTextColumnName(this.txtBiaoZhunLeiBie, "BIAOZHUNLEIBIE");
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(291, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 15);
            this.label3.TabIndex = 1;
            this.label3.Text = "合格率：";
            // 
            // txtHeGeLv
            // 
            this.txtHeGeLv.EmptyTextTip = null;
            this.txtHeGeLv.EmptyTextTipColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.txtHeGeLv.EnterIsTab = false;
            this.dcm1.SetIsUse(this.txtHeGeLv, true);
            this.txtHeGeLv.Location = new System.Drawing.Point(358, 91);
            this.txtHeGeLv.Name = "txtHeGeLv";
            this.txtHeGeLv.ReadOnly = true;
            this.txtHeGeLv.Size = new System.Drawing.Size(48, 25);
            this.txtHeGeLv.TabIndex = 10;
            this.txtHeGeLv.TabStop = false;
            this.dcm1.SetTagColumnName(this.txtHeGeLv, null);
            this.dcm1.SetTextColumnName(this.txtHeGeLv, "HeGeLv");
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(172, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 15);
            this.label4.TabIndex = 1;
            this.label4.Text = "问题数：";
            // 
            // txtBiaoZhunShu
            // 
            this.txtBiaoZhunShu.EmptyTextTip = null;
            this.txtBiaoZhunShu.EmptyTextTipColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.txtBiaoZhunShu.EnterIsTab = false;
            this.dcm1.SetIsUse(this.txtBiaoZhunShu, true);
            this.txtBiaoZhunShu.Location = new System.Drawing.Point(111, 91);
            this.txtBiaoZhunShu.Name = "txtBiaoZhunShu";
            this.txtBiaoZhunShu.ReadOnly = true;
            this.txtBiaoZhunShu.Size = new System.Drawing.Size(48, 25);
            this.txtBiaoZhunShu.TabIndex = 10;
            this.txtBiaoZhunShu.TabStop = false;
            this.dcm1.SetTagColumnName(this.txtBiaoZhunShu, null);
            this.dcm1.SetTextColumnName(this.txtBiaoZhunShu, "BiaoZhunShu");
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(48, 97);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 15);
            this.label5.TabIndex = 1;
            this.label5.Text = "标准数：";
            // 
            // txtWenTiShu
            // 
            this.txtWenTiShu.EmptyTextTip = null;
            this.txtWenTiShu.EmptyTextTipColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.txtWenTiShu.EnterIsTab = false;
            this.dcm1.SetIsUse(this.txtWenTiShu, true);
            this.txtWenTiShu.Location = new System.Drawing.Point(237, 91);
            this.txtWenTiShu.Name = "txtWenTiShu";
            this.txtWenTiShu.ReadOnly = true;
            this.txtWenTiShu.Size = new System.Drawing.Size(48, 25);
            this.txtWenTiShu.TabIndex = 10;
            this.txtWenTiShu.TabStop = false;
            this.dcm1.SetTagColumnName(this.txtWenTiShu, null);
            this.dcm1.SetTextColumnName(this.txtWenTiShu, "WenTiShu");
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(31, 160);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 15);
            this.label6.TabIndex = 3;
            this.label6.Text = "检查人员：";
            // 
            // txtJianChaRenYuan
            // 
            this.txtJianChaRenYuan.EmptyTextTip = null;
            this.txtJianChaRenYuan.EmptyTextTipColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.txtJianChaRenYuan.EnterIsTab = false;
            this.dcm1.SetIsUse(this.txtJianChaRenYuan, true);
            this.txtJianChaRenYuan.Location = new System.Drawing.Point(111, 160);
            this.txtJianChaRenYuan.Multiline = true;
            this.txtJianChaRenYuan.Name = "txtJianChaRenYuan";
            this.txtJianChaRenYuan.Size = new System.Drawing.Size(295, 52);
            this.txtJianChaRenYuan.TabIndex = 1;
            this.dcm1.SetTagColumnName(this.txtJianChaRenYuan, null);
            this.dcm1.SetTextColumnName(this.txtJianChaRenYuan, "JIANCHAREN");
            // 
            // btnSelect
            // 
            this.btnSelect.Location = new System.Drawing.Point(408, 160);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(48, 52);
            this.btnSelect.TabIndex = 5;
            this.btnSelect.Text = "选择";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(259, 231);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 31);
            this.btnOK.TabIndex = 6;
            this.btnOK.Text = "确定";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(358, 231);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 31);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(31, 128);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 15);
            this.label7.TabIndex = 7;
            this.label7.Text = "检查日期：";
            // 
            // dtpJIANCHASHIJIAN
            // 
            this.dcm1.SetIsUse(this.dtpJIANCHASHIJIAN, true);
            this.dtpJIANCHASHIJIAN.Location = new System.Drawing.Point(111, 126);
            this.dtpJIANCHASHIJIAN.Name = "dtpJIANCHASHIJIAN";
            this.dtpJIANCHASHIJIAN.Size = new System.Drawing.Size(295, 25);
            this.dtpJIANCHASHIJIAN.TabIndex = 0;
            this.dcm1.SetTagColumnName(this.dtpJIANCHASHIJIAN, null);
            this.dcm1.SetTextColumnName(this.dtpJIANCHASHIJIAN, "JIANCHASHIJIAN");
            // 
            // FrmZhiKongJianChaQueRenNeiRong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(485, 279);
            this.Controls.Add(this.dtpJIANCHASHIJIAN);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.btnSelect);
            this.Controls.Add(this.txtJianChaRenYuan);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtWenTiShu);
            this.Controls.Add(this.txtBiaoZhunShu);
            this.Controls.Add(this.txtHeGeLv);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtBiaoZhunLeiBie);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtKeShi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.KeyPreview = true;
            this.Name = "FrmZhiKongJianChaQueRenNeiRong";
            this.Text = "质控检查内容确认";
            this.Load += new System.EventHandler(this.FrmZhiKongJianChaQueRenNeiRong_Load);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.txtKeShi, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.txtBiaoZhunLeiBie, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.txtHeGeLv, 0);
            this.Controls.SetChildIndex(this.txtBiaoZhunShu, 0);
            this.Controls.SetChildIndex(this.txtWenTiShu, 0);
            this.Controls.SetChildIndex(this.label6, 0);
            this.Controls.SetChildIndex(this.txtJianChaRenYuan, 0);
            this.Controls.SetChildIndex(this.btnSelect, 0);
            this.Controls.SetChildIndex(this.btnOK, 0);
            this.Controls.SetChildIndex(this.btnCancel, 0);
            this.Controls.SetChildIndex(this.label7, 0);
            this.Controls.SetChildIndex(this.dtpJIANCHASHIJIAN, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Framework.WinCommon.Controls.ZCTextBox txtKeShi;
        private Framework.WinCommon.Controls.ZCTextBox txtBiaoZhunLeiBie;
        private System.Windows.Forms.Label label3;
        private Framework.WinCommon.Controls.ZCTextBox txtHeGeLv;
        private System.Windows.Forms.Label label4;
        private Framework.WinCommon.Controls.ZCTextBox txtBiaoZhunShu;
        private System.Windows.Forms.Label label5;
        private Framework.WinCommon.Controls.ZCTextBox txtWenTiShu;
        private System.Windows.Forms.Label label6;
        private Framework.WinCommon.Controls.ZCTextBox txtJianChaRenYuan;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private Framework.WinCommon.Components.DCM dcm1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dtpJIANCHASHIJIAN;
    }
}