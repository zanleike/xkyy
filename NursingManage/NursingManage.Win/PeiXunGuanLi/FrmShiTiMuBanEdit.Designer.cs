namespace NursingManage.Win.PeiXunGuanLi
{
    partial class FrmShiTiMuBanEdit
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
            this.txtMingChengPY = new Framework.WinCommon.Controls.ZCTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtBeiZhu = new Framework.WinCommon.Controls.ZCTextBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.dcm1 = new Framework.WinCommon.Components.DCM(this.components);
            this.zcTextBox3 = new Framework.WinCommon.Controls.ZCTextBox();
            this.zcTextBox4 = new Framework.WinCommon.Controls.ZCTextBox();
            this.zcTextBox1 = new Framework.WinCommon.Controls.ZCTextBox();
            this.zcTextBox2 = new Framework.WinCommon.Controls.ZCTextBox();
            this.zcTextBox5 = new Framework.WinCommon.Controls.ZCTextBox();
            this.zcTextBox6 = new Framework.WinCommon.Controls.ZCTextBox();
            this.cEx = new Framework.WinCommon.Components.ControlExtend(this.components);
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(81, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "名称：";
            // 
            // txtMingCheng
            // 
            this.txtMingCheng.EmptyTextTip = null;
            this.txtMingCheng.EmptyTextTipColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.txtMingCheng.EnterIsTab = true;
            this.cEx.SetEnterIsTab(this.txtMingCheng, true);
            this.dcm1.SetIsUse(this.txtMingCheng, true);
            this.txtMingCheng.Location = new System.Drawing.Point(139, 27);
            this.txtMingCheng.Name = "txtMingCheng";
            this.txtMingCheng.Size = new System.Drawing.Size(355, 25);
            this.txtMingCheng.TabIndex = 0;
            this.dcm1.SetTagColumnName(this.txtMingCheng, null);
            this.dcm1.SetTextColumnName(this.txtMingCheng, "MINGCHENG");
            this.txtMingCheng.Leave += new System.EventHandler(this.txtMingCheng_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(66, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "助记码：";
            // 
            // txtMingChengPY
            // 
            this.txtMingChengPY.EmptyTextTip = null;
            this.txtMingChengPY.EmptyTextTipColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.txtMingChengPY.EnterIsTab = true;
            this.cEx.SetEnterIsTab(this.txtMingChengPY, true);
            this.dcm1.SetIsUse(this.txtMingChengPY, true);
            this.txtMingChengPY.Location = new System.Drawing.Point(139, 64);
            this.txtMingChengPY.Name = "txtMingChengPY";
            this.txtMingChengPY.Size = new System.Drawing.Size(355, 25);
            this.txtMingChengPY.TabIndex = 1;
            this.dcm1.SetTagColumnName(this.txtMingChengPY, null);
            this.dcm1.SetTextColumnName(this.txtMingChengPY, "MINGCHENG_PY");
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(81, 216);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 15);
            this.label5.TabIndex = 1;
            this.label5.Text = "备注：";
            // 
            // txtBeiZhu
            // 
            this.txtBeiZhu.EmptyTextTip = null;
            this.txtBeiZhu.EmptyTextTipColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.txtBeiZhu.EnterIsTab = true;
            this.cEx.SetEnterIsTab(this.txtBeiZhu, true);
            this.dcm1.SetIsUse(this.txtBeiZhu, true);
            this.txtBeiZhu.Location = new System.Drawing.Point(139, 216);
            this.txtBeiZhu.Multiline = true;
            this.txtBeiZhu.Name = "txtBeiZhu";
            this.txtBeiZhu.Size = new System.Drawing.Size(355, 59);
            this.txtBeiZhu.TabIndex = 8;
            this.dcm1.SetTagColumnName(this.txtBeiZhu, null);
            this.dcm1.SetTextColumnName(this.txtBeiZhu, "BeiZhu");
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(327, 297);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 30);
            this.btnOK.TabIndex = 9;
            this.btnOK.Text = "确定";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(419, 297);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 30);
            this.btnCancel.TabIndex = 10;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // zcTextBox3
            // 
            this.zcTextBox3.EmptyTextTip = null;
            this.zcTextBox3.EmptyTextTipColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.zcTextBox3.EnterIsTab = true;
            this.cEx.SetEnterIsTab(this.zcTextBox3, true);
            this.dcm1.SetIsUse(this.zcTextBox3, true);
            this.zcTextBox3.Location = new System.Drawing.Point(402, 101);
            this.zcTextBox3.Name = "zcTextBox3";
            this.zcTextBox3.Size = new System.Drawing.Size(92, 25);
            this.zcTextBox3.TabIndex = 3;
            this.dcm1.SetTagColumnName(this.zcTextBox3, null);
            this.zcTextBox3.Text = "0";
            this.dcm1.SetTextColumnName(this.zcTextBox3, "DANXUANFENSHU");
            // 
            // zcTextBox4
            // 
            this.zcTextBox4.EmptyTextTip = null;
            this.zcTextBox4.EmptyTextTipColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.zcTextBox4.EnterIsTab = true;
            this.cEx.SetEnterIsTab(this.zcTextBox4, true);
            this.dcm1.SetIsUse(this.zcTextBox4, true);
            this.zcTextBox4.Location = new System.Drawing.Point(139, 101);
            this.zcTextBox4.Name = "zcTextBox4";
            this.zcTextBox4.Size = new System.Drawing.Size(92, 25);
            this.zcTextBox4.TabIndex = 2;
            this.dcm1.SetTagColumnName(this.zcTextBox4, null);
            this.zcTextBox4.Text = "0";
            this.dcm1.SetTextColumnName(this.zcTextBox4, "DANXUANSHU");
            // 
            // zcTextBox1
            // 
            this.zcTextBox1.EmptyTextTip = null;
            this.zcTextBox1.EmptyTextTipColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.zcTextBox1.EnterIsTab = true;
            this.cEx.SetEnterIsTab(this.zcTextBox1, true);
            this.dcm1.SetIsUse(this.zcTextBox1, true);
            this.zcTextBox1.Location = new System.Drawing.Point(402, 138);
            this.zcTextBox1.Name = "zcTextBox1";
            this.zcTextBox1.Size = new System.Drawing.Size(92, 25);
            this.zcTextBox1.TabIndex = 5;
            this.dcm1.SetTagColumnName(this.zcTextBox1, null);
            this.zcTextBox1.Text = "0";
            this.dcm1.SetTextColumnName(this.zcTextBox1, "DUOXUANFENSHU");
            // 
            // zcTextBox2
            // 
            this.zcTextBox2.EmptyTextTip = null;
            this.zcTextBox2.EmptyTextTipColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.zcTextBox2.EnterIsTab = true;
            this.cEx.SetEnterIsTab(this.zcTextBox2, true);
            this.dcm1.SetIsUse(this.zcTextBox2, true);
            this.zcTextBox2.Location = new System.Drawing.Point(139, 138);
            this.zcTextBox2.Name = "zcTextBox2";
            this.zcTextBox2.Size = new System.Drawing.Size(92, 25);
            this.zcTextBox2.TabIndex = 4;
            this.dcm1.SetTagColumnName(this.zcTextBox2, null);
            this.zcTextBox2.Text = "0";
            this.dcm1.SetTextColumnName(this.zcTextBox2, "DUOXUANSHU");
            // 
            // zcTextBox5
            // 
            this.zcTextBox5.EmptyTextTip = null;
            this.zcTextBox5.EmptyTextTipColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.zcTextBox5.EnterIsTab = true;
            this.cEx.SetEnterIsTab(this.zcTextBox5, true);
            this.dcm1.SetIsUse(this.zcTextBox5, true);
            this.zcTextBox5.Location = new System.Drawing.Point(402, 175);
            this.zcTextBox5.Name = "zcTextBox5";
            this.zcTextBox5.Size = new System.Drawing.Size(92, 25);
            this.zcTextBox5.TabIndex = 7;
            this.dcm1.SetTagColumnName(this.zcTextBox5, null);
            this.zcTextBox5.Text = "0";
            this.dcm1.SetTextColumnName(this.zcTextBox5, "PANDUANFENSHU");
            // 
            // zcTextBox6
            // 
            this.zcTextBox6.EmptyTextTip = null;
            this.zcTextBox6.EmptyTextTipColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.zcTextBox6.EnterIsTab = true;
            this.cEx.SetEnterIsTab(this.zcTextBox6, true);
            this.dcm1.SetIsUse(this.zcTextBox6, true);
            this.zcTextBox6.Location = new System.Drawing.Point(139, 175);
            this.zcTextBox6.Name = "zcTextBox6";
            this.zcTextBox6.Size = new System.Drawing.Size(92, 25);
            this.zcTextBox6.TabIndex = 6;
            this.dcm1.SetTagColumnName(this.zcTextBox6, null);
            this.zcTextBox6.Text = "0";
            this.dcm1.SetTextColumnName(this.zcTextBox6, "PANDUANSHU");
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(299, 109);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 15);
            this.label6.TabIndex = 1;
            this.label6.Text = "单选题分值：";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(36, 104);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(97, 15);
            this.label7.TabIndex = 1;
            this.label7.Text = "单选题数量：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(299, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 15);
            this.label3.TabIndex = 1;
            this.label3.Text = "多选题分值：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 15);
            this.label4.TabIndex = 1;
            this.label4.Text = "多选题数量：";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(299, 181);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(97, 15);
            this.label8.TabIndex = 1;
            this.label8.Text = "判断题分值：";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(36, 178);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(97, 15);
            this.label9.TabIndex = 1;
            this.label9.Text = "判断题数量：";
            // 
            // FrmShiTiMuBanEdit
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(571, 348);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.zcTextBox6);
            this.Controls.Add(this.zcTextBox2);
            this.Controls.Add(this.zcTextBox4);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.zcTextBox5);
            this.Controls.Add(this.zcTextBox1);
            this.Controls.Add(this.zcTextBox3);
            this.Controls.Add(this.txtBeiZhu);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtMingChengPY);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtMingCheng);
            this.Controls.Add(this.label1);
            this.KeyPreview = true;
            this.Name = "FrmShiTiMuBanEdit";
            this.Text = "试题模板编辑";
            this.Load += new System.EventHandler(this.FrmShiTiMuBanEdit_Load);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.txtMingCheng, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.txtMingChengPY, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.txtBeiZhu, 0);
            this.Controls.SetChildIndex(this.zcTextBox3, 0);
            this.Controls.SetChildIndex(this.zcTextBox1, 0);
            this.Controls.SetChildIndex(this.zcTextBox5, 0);
            this.Controls.SetChildIndex(this.btnOK, 0);
            this.Controls.SetChildIndex(this.label6, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.label8, 0);
            this.Controls.SetChildIndex(this.btnCancel, 0);
            this.Controls.SetChildIndex(this.zcTextBox4, 0);
            this.Controls.SetChildIndex(this.zcTextBox2, 0);
            this.Controls.SetChildIndex(this.zcTextBox6, 0);
            this.Controls.SetChildIndex(this.label7, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.label9, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Framework.WinCommon.Controls.ZCTextBox txtMingCheng;
        private System.Windows.Forms.Label label2;
        private Framework.WinCommon.Controls.ZCTextBox txtMingChengPY;
        private System.Windows.Forms.Label label5;
        private Framework.WinCommon.Controls.ZCTextBox txtBeiZhu;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private Framework.WinCommon.Components.DCM dcm1;
        private Framework.WinCommon.Components.ControlExtend cEx;
        private Framework.WinCommon.Controls.ZCTextBox zcTextBox3;
        private System.Windows.Forms.Label label6;
        private Framework.WinCommon.Controls.ZCTextBox zcTextBox4;
        private System.Windows.Forms.Label label7;
        private Framework.WinCommon.Controls.ZCTextBox zcTextBox1;
        private System.Windows.Forms.Label label3;
        private Framework.WinCommon.Controls.ZCTextBox zcTextBox2;
        private System.Windows.Forms.Label label4;
        private Framework.WinCommon.Controls.ZCTextBox zcTextBox5;
        private System.Windows.Forms.Label label8;
        private Framework.WinCommon.Controls.ZCTextBox zcTextBox6;
        private System.Windows.Forms.Label label9;
    }
}