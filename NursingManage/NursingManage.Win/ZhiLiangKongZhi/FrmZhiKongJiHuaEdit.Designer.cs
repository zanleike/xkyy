namespace NursingManage.Win.ZhiLiangKongZhi
{
    partial class FrmZhiKongJiHuaEdit
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
            this.txtMingCheng = new Framework.WinCommon.Controls.ZCTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpKaiShi = new System.Windows.Forms.DateTimePicker();
            this.dtpJieShu = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtBeiZhu = new Framework.WinCommon.Controls.ZCTextBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.ce = new Framework.WinCommon.Components.ControlExtend(this.components);
            this.chbShiFouFuCha = new System.Windows.Forms.CheckBox();
            this.dcm1 = new Framework.WinCommon.Components.DCM(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.txtFuChaJiHua = new Framework.WinCommon.Controls.ZCTextBox();
            this.comboxList1 = new Framework.WinCommon.Components.ComboxList(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "计划名称：";
            // 
            // txtMingCheng
            // 
            this.txtMingCheng.EmptyTextTip = null;
            this.txtMingCheng.EmptyTextTipColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.txtMingCheng.EnterIsTab = false;
            this.ce.SetEnterIsTab(this.txtMingCheng, true);
            this.dcm1.SetIsUse(this.txtMingCheng, true);
            this.txtMingCheng.Location = new System.Drawing.Point(106, 28);
            this.txtMingCheng.Name = "txtMingCheng";
            this.txtMingCheng.Size = new System.Drawing.Size(286, 21);
            this.txtMingCheng.TabIndex = 0;
            this.dcm1.SetTagColumnName(this.txtMingCheng, null);
            this.dcm1.SetTextColumnName(this.txtMingCheng, "MINGCHENG");
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "计划检查日期：";
            // 
            // dtpKaiShi
            // 
            this.dtpKaiShi.CustomFormat = "yyyy-MM-dd";
            this.ce.SetEnterIsTab(this.dtpKaiShi, true);
            this.dcm1.SetIsUse(this.dtpKaiShi, true);
            this.dtpKaiShi.Location = new System.Drawing.Point(106, 95);
            this.dtpKaiShi.Name = "dtpKaiShi";
            this.dtpKaiShi.Size = new System.Drawing.Size(122, 21);
            this.dtpKaiShi.TabIndex = 1;
            this.dcm1.SetTagColumnName(this.dtpKaiShi, null);
            this.dcm1.SetTextColumnName(this.dtpKaiShi, "KAISHISHIJIAN");
            // 
            // dtpJieShu
            // 
            this.dtpJieShu.CustomFormat = "yyyy-MM-dd";
            this.ce.SetEnterIsTab(this.dtpJieShu, true);
            this.dcm1.SetIsUse(this.dtpJieShu, true);
            this.dtpJieShu.Location = new System.Drawing.Point(270, 95);
            this.dtpJieShu.Name = "dtpJieShu";
            this.dtpJieShu.Size = new System.Drawing.Size(122, 21);
            this.dtpJieShu.TabIndex = 2;
            this.dcm1.SetTagColumnName(this.dtpJieShu, null);
            this.dcm1.SetTextColumnName(this.dtpJieShu, "JIESHUSHIJIAN");
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(243, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "至";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(61, 132);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 12);
            this.label5.TabIndex = 1;
            this.label5.Text = "备注：";
            // 
            // txtBeiZhu
            // 
            this.txtBeiZhu.EmptyTextTip = null;
            this.txtBeiZhu.EmptyTextTipColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.txtBeiZhu.EnterIsTab = false;
            this.ce.SetEnterIsTab(this.txtBeiZhu, true);
            this.dcm1.SetIsUse(this.txtBeiZhu, true);
            this.txtBeiZhu.Location = new System.Drawing.Point(106, 129);
            this.txtBeiZhu.Multiline = true;
            this.txtBeiZhu.Name = "txtBeiZhu";
            this.txtBeiZhu.Size = new System.Drawing.Size(286, 55);
            this.txtBeiZhu.TabIndex = 3;
            this.dcm1.SetTagColumnName(this.txtBeiZhu, null);
            this.dcm1.SetTextColumnName(this.txtBeiZhu, "BEIZHU");
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(233, 201);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 28);
            this.btnOK.TabIndex = 4;
            this.btnOK.Text = "确定";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(317, 201);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 28);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // chbShiFouFuCha
            // 
            this.chbShiFouFuCha.AutoSize = true;
            this.ce.SetEnterIsTab(this.chbShiFouFuCha, true);
            this.dcm1.SetIsUse(this.chbShiFouFuCha, false);
            this.chbShiFouFuCha.Location = new System.Drawing.Point(320, 63);
            this.chbShiFouFuCha.Name = "chbShiFouFuCha";
            this.chbShiFouFuCha.Size = new System.Drawing.Size(72, 16);
            this.chbShiFouFuCha.TabIndex = 10;
            this.dcm1.SetTagColumnName(this.chbShiFouFuCha, null);
            this.chbShiFouFuCha.Text = "复查计划";
            this.dcm1.SetTextColumnName(this.chbShiFouFuCha, null);
            this.chbShiFouFuCha.UseVisualStyleBackColor = true;
            this.chbShiFouFuCha.CheckedChanged += new System.EventHandler(this.chbShiFouFuCha_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 11;
            this.label4.Text = "复查计划：";
            // 
            // txtFuChaJiHua
            // 
            this.txtFuChaJiHua.EmptyTextTip = "回车选择复查计划";
            this.txtFuChaJiHua.EmptyTextTipColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.txtFuChaJiHua.EnterIsTab = false;
            this.ce.SetEnterIsTab(this.txtFuChaJiHua, true);
            this.dcm1.SetIsUse(this.txtFuChaJiHua, true);
            this.txtFuChaJiHua.Location = new System.Drawing.Point(106, 61);
            this.txtFuChaJiHua.Name = "txtFuChaJiHua";
            this.txtFuChaJiHua.ReadOnly = true;
            this.txtFuChaJiHua.Size = new System.Drawing.Size(208, 21);
            this.txtFuChaJiHua.TabIndex = 12;
            this.dcm1.SetTagColumnName(this.txtFuChaJiHua, "FuChaJiHuaId");
            this.dcm1.SetTextColumnName(this.txtFuChaJiHua, "FuChaJiHua");
            // 
            // comboxList1
            // 
            this.comboxList1.GridViewDataSource = null;
            this.comboxList1.MaxRowCount = 5;
            // 
            // FrmZhiKongJiHuaEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(425, 246);
            this.Controls.Add(this.txtFuChaJiHua);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.chbShiFouFuCha);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtpJieShu);
            this.Controls.Add(this.dtpKaiShi);
            this.Controls.Add(this.txtBeiZhu);
            this.Controls.Add(this.txtMingCheng);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.KeyPreview = true;
            this.Name = "FrmZhiKongJiHuaEdit";
            this.Text = "计划编辑";
            this.Load += new System.EventHandler(this.FrmZhiKongJiHuaEdit_Load);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.txtMingCheng, 0);
            this.Controls.SetChildIndex(this.txtBeiZhu, 0);
            this.Controls.SetChildIndex(this.dtpKaiShi, 0);
            this.Controls.SetChildIndex(this.dtpJieShu, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.btnOK, 0);
            this.Controls.SetChildIndex(this.btnCancel, 0);
            this.Controls.SetChildIndex(this.chbShiFouFuCha, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.txtFuChaJiHua, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Framework.WinCommon.Controls.ZCTextBox txtMingCheng;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpKaiShi;
        private System.Windows.Forms.DateTimePicker dtpJieShu;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private Framework.WinCommon.Controls.ZCTextBox txtBeiZhu;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private Framework.WinCommon.Components.ControlExtend ce;
        private Framework.WinCommon.Components.DCM dcm1;
        private System.Windows.Forms.CheckBox chbShiFouFuCha;
        private System.Windows.Forms.Label label4;
        private Framework.WinCommon.Controls.ZCTextBox txtFuChaJiHua;
        private Framework.WinCommon.Components.ComboxList comboxList1;
    }
}