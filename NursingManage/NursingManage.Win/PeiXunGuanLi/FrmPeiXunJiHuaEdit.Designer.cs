namespace NursingManage.Win.PeiXunGuanLi
{
    partial class FrmPeiXunJiHuaEdit
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
            this.dtpJiHuaKaiShi = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpJiHuaJieShu = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.txtJiHuaNeiRong = new Framework.WinCommon.Controls.ZCTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCanJiaRenYuan = new Framework.WinCommon.Controls.ZCTextBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtBeiZhu = new Framework.WinCommon.Controls.ZCTextBox();
            this.dcm1 = new Framework.WinCommon.Components.DCM(this.components);
            this.txtJiHuaShuoMing = new Framework.WinCommon.Controls.ZCTextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.ctlEx = new Framework.WinCommon.Components.ControlExtend(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "培训时间：";
            // 
            // dtpJiHuaKaiShi
            // 
            this.dtpJiHuaKaiShi.CustomFormat = "yyyy-MM-dd";
            this.ctlEx.SetEnterIsTab(this.dtpJiHuaKaiShi, true);
            this.dcm1.SetIsUse(this.dtpJiHuaKaiShi, true);
            this.dtpJiHuaKaiShi.Location = new System.Drawing.Point(137, 111);
            this.dtpJiHuaKaiShi.Name = "dtpJiHuaKaiShi";
            this.dtpJiHuaKaiShi.Size = new System.Drawing.Size(146, 25);
            this.dtpJiHuaKaiShi.TabIndex = 2;
            this.dcm1.SetTagColumnName(this.dtpJiHuaKaiShi, null);
            this.dcm1.SetTextColumnName(this.dtpJiHuaKaiShi, "PEIXUNKAISHI");
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(288, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "至";
            // 
            // dtpJiHuaJieShu
            // 
            this.dtpJiHuaJieShu.CustomFormat = "yyyy-MM-dd";
            this.ctlEx.SetEnterIsTab(this.dtpJiHuaJieShu, true);
            this.dcm1.SetIsUse(this.dtpJiHuaJieShu, true);
            this.dtpJiHuaJieShu.Location = new System.Drawing.Point(313, 110);
            this.dtpJiHuaJieShu.Name = "dtpJiHuaJieShu";
            this.dtpJiHuaJieShu.Size = new System.Drawing.Size(160, 25);
            this.dtpJiHuaJieShu.TabIndex = 3;
            this.dcm1.SetTagColumnName(this.dtpJiHuaJieShu, null);
            this.dcm1.SetTextColumnName(this.dtpJiHuaJieShu, "PEIXUNJIESHU");
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(49, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "计划内容：";
            // 
            // txtJiHuaNeiRong
            // 
            this.txtJiHuaNeiRong.EmptyTextTip = null;
            this.txtJiHuaNeiRong.EmptyTextTipColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.txtJiHuaNeiRong.EnterIsTab = true;
            this.ctlEx.SetEnterIsTab(this.txtJiHuaNeiRong, true);
            this.dcm1.SetIsUse(this.txtJiHuaNeiRong, true);
            this.txtJiHuaNeiRong.Location = new System.Drawing.Point(137, 27);
            this.txtJiHuaNeiRong.Name = "txtJiHuaNeiRong";
            this.txtJiHuaNeiRong.Size = new System.Drawing.Size(337, 25);
            this.txtJiHuaNeiRong.TabIndex = 0;
            this.dcm1.SetTagColumnName(this.txtJiHuaNeiRong, null);
            this.dcm1.SetTextColumnName(this.txtJiHuaNeiRong, "NEIRONG");
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 174);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 15);
            this.label5.TabIndex = 7;
            this.label5.Text = "参加人员描述：";
            // 
            // txtCanJiaRenYuan
            // 
            this.txtCanJiaRenYuan.EmptyTextTip = null;
            this.txtCanJiaRenYuan.EmptyTextTipColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.txtCanJiaRenYuan.EnterIsTab = true;
            this.ctlEx.SetEnterIsTab(this.txtCanJiaRenYuan, true);
            this.dcm1.SetIsUse(this.txtCanJiaRenYuan, true);
            this.txtCanJiaRenYuan.Location = new System.Drawing.Point(137, 170);
            this.txtCanJiaRenYuan.Name = "txtCanJiaRenYuan";
            this.txtCanJiaRenYuan.Size = new System.Drawing.Size(337, 25);
            this.txtCanJiaRenYuan.TabIndex = 6;
            this.dcm1.SetTagColumnName(this.txtCanJiaRenYuan, null);
            this.dcm1.SetTextColumnName(this.txtCanJiaRenYuan, "CANJIARENYUAN");
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(323, 267);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(72, 30);
            this.btnOK.TabIndex = 11;
            this.btnOK.Text = "确定";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(79, 203);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 15);
            this.label7.TabIndex = 14;
            this.label7.Text = "备注：";
            // 
            // txtBeiZhu
            // 
            this.txtBeiZhu.EmptyTextTip = null;
            this.txtBeiZhu.EmptyTextTipColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.txtBeiZhu.EnterIsTab = false;
            this.ctlEx.SetEnterIsTab(this.txtBeiZhu, true);
            this.dcm1.SetIsUse(this.txtBeiZhu, false);
            this.txtBeiZhu.Location = new System.Drawing.Point(137, 199);
            this.txtBeiZhu.Multiline = true;
            this.txtBeiZhu.Name = "txtBeiZhu";
            this.txtBeiZhu.Size = new System.Drawing.Size(337, 51);
            this.txtBeiZhu.TabIndex = 9;
            this.dcm1.SetTagColumnName(this.txtBeiZhu, null);
            this.dcm1.SetTextColumnName(this.txtBeiZhu, null);
            // 
            // txtJiHuaShuoMing
            // 
            this.txtJiHuaShuoMing.EmptyTextTip = null;
            this.txtJiHuaShuoMing.EmptyTextTipColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.txtJiHuaShuoMing.EnterIsTab = true;
            this.ctlEx.SetEnterIsTab(this.txtJiHuaShuoMing, true);
            this.dcm1.SetIsUse(this.txtJiHuaShuoMing, true);
            this.txtJiHuaShuoMing.Location = new System.Drawing.Point(137, 56);
            this.txtJiHuaShuoMing.Multiline = true;
            this.txtJiHuaShuoMing.Name = "txtJiHuaShuoMing";
            this.txtJiHuaShuoMing.Size = new System.Drawing.Size(337, 47);
            this.txtJiHuaShuoMing.TabIndex = 1;
            this.dcm1.SetTagColumnName(this.txtJiHuaShuoMing, null);
            this.dcm1.SetTextColumnName(this.txtJiHuaShuoMing, "NEIRONGSHUOMING");
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "yyyy-MM-dd";
            this.ctlEx.SetEnterIsTab(this.dateTimePicker1, true);
            this.dcm1.SetIsUse(this.dateTimePicker1, true);
            this.dateTimePicker1.Location = new System.Drawing.Point(137, 141);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(146, 25);
            this.dateTimePicker1.TabIndex = 4;
            this.dcm1.SetTagColumnName(this.dateTimePicker1, null);
            this.dcm1.SetTextColumnName(this.dateTimePicker1, "KAOHEKAISHI");
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.CustomFormat = "yyyy-MM-dd";
            this.ctlEx.SetEnterIsTab(this.dateTimePicker2, true);
            this.dcm1.SetIsUse(this.dateTimePicker2, true);
            this.dateTimePicker2.Location = new System.Drawing.Point(313, 140);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(160, 25);
            this.dateTimePicker2.TabIndex = 5;
            this.dcm1.SetTagColumnName(this.dateTimePicker2, null);
            this.dcm1.SetTextColumnName(this.dateTimePicker2, "KAOHEJIESHU");
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(49, 60);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 15);
            this.label8.TabIndex = 3;
            this.label8.Text = "内容说明：";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(411, 267);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(72, 30);
            this.btnCancel.TabIndex = 12;
            this.btnCancel.Text = "关闭";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(49, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 15);
            this.label4.TabIndex = 1;
            this.label4.Text = "考核时间：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(288, 145);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(22, 15);
            this.label6.TabIndex = 1;
            this.label6.Text = "至";
            // 
            // FrmPeiXunJiHuaEdit
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(521, 314);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.txtBeiZhu);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.txtCanJiaRenYuan);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtJiHuaShuoMing);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtJiHuaNeiRong);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dtpJiHuaJieShu);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dtpJiHuaKaiShi);
            this.Controls.Add(this.label1);
            this.KeyPreview = true;
            this.Name = "FrmPeiXunJiHuaEdit";
            this.Text = "培训计划创建";
            this.Load += new System.EventHandler(this.FrmPeiXunJiHuaEdit_Load);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.dtpJiHuaKaiShi, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.dateTimePicker1, 0);
            this.Controls.SetChildIndex(this.dtpJiHuaJieShu, 0);
            this.Controls.SetChildIndex(this.label6, 0);
            this.Controls.SetChildIndex(this.dateTimePicker2, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.txtJiHuaNeiRong, 0);
            this.Controls.SetChildIndex(this.label8, 0);
            this.Controls.SetChildIndex(this.txtJiHuaShuoMing, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.txtCanJiaRenYuan, 0);
            this.Controls.SetChildIndex(this.btnOK, 0);
            this.Controls.SetChildIndex(this.label7, 0);
            this.Controls.SetChildIndex(this.txtBeiZhu, 0);
            this.Controls.SetChildIndex(this.btnCancel, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpJiHuaKaiShi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpJiHuaJieShu;
        private System.Windows.Forms.Label label3;
        private Framework.WinCommon.Controls.ZCTextBox txtJiHuaNeiRong;
        private System.Windows.Forms.Label label5;
        private Framework.WinCommon.Controls.ZCTextBox txtCanJiaRenYuan;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Label label7;
        private Framework.WinCommon.Controls.ZCTextBox txtBeiZhu;
        private Framework.WinCommon.Components.DCM dcm1;
        private System.Windows.Forms.Label label8;
        private Framework.WinCommon.Controls.ZCTextBox txtJiHuaShuoMing;
        private System.Windows.Forms.Button btnCancel;
        private Framework.WinCommon.Components.ControlExtend ctlEx;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
    }
}