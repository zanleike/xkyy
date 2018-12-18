namespace NursingManage.Win.PeiXunGuanLi
{
    partial class FrmShiTiMuBanShengCheng
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
            this.label8 = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.dcm1 = new Framework.WinCommon.Components.DCM(this.components);
            this.zcTextBox1 = new Framework.WinCommon.Controls.ZCTextBox();
            this.zcTextBox2 = new Framework.WinCommon.Controls.ZCTextBox();
            this.zcTextBox3 = new Framework.WinCommon.Controls.ZCTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtDanXuanShuLiang = new Framework.WinCommon.Controls.ZCTextBox();
            this.txtDuoXuanShuliang = new Framework.WinCommon.Controls.ZCTextBox();
            this.txtPanDuanShuLiang = new Framework.WinCommon.Controls.ZCTextBox();
            this.ce = new Framework.WinCommon.Components.ControlExtend(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "单选题数量：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "多选题数量：";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(32, 91);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 12);
            this.label8.TabIndex = 1;
            this.label8.Text = "判断题数量：";
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(148, 125);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 25);
            this.btnOK.TabIndex = 9;
            this.btnOK.Text = "确定";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(233, 125);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 25);
            this.btnCancel.TabIndex = 10;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // zcTextBox1
            // 
            this.zcTextBox1.EmptyTextTip = null;
            this.zcTextBox1.EmptyTextTipColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.zcTextBox1.EnterIsTab = false;
            this.ce.SetEnterIsTab(this.zcTextBox1, true);
            this.dcm1.SetIsUse(this.zcTextBox1, true);
            this.zcTextBox1.Location = new System.Drawing.Point(239, 26);
            this.zcTextBox1.Name = "zcTextBox1";
            this.zcTextBox1.Size = new System.Drawing.Size(64, 21);
            this.zcTextBox1.TabIndex = 1;
            this.dcm1.SetTagColumnName(this.zcTextBox1, null);
            this.dcm1.SetTextColumnName(this.zcTextBox1, "DanXuanFenShu");
            // 
            // zcTextBox2
            // 
            this.zcTextBox2.EmptyTextTip = null;
            this.zcTextBox2.EmptyTextTipColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.zcTextBox2.EnterIsTab = false;
            this.ce.SetEnterIsTab(this.zcTextBox2, true);
            this.dcm1.SetIsUse(this.zcTextBox2, true);
            this.zcTextBox2.Location = new System.Drawing.Point(239, 56);
            this.zcTextBox2.Name = "zcTextBox2";
            this.zcTextBox2.Size = new System.Drawing.Size(64, 21);
            this.zcTextBox2.TabIndex = 3;
            this.dcm1.SetTagColumnName(this.zcTextBox2, null);
            this.dcm1.SetTextColumnName(this.zcTextBox2, "DuoXuanFenShu");
            // 
            // zcTextBox3
            // 
            this.zcTextBox3.EmptyTextTip = null;
            this.zcTextBox3.EmptyTextTipColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.zcTextBox3.EnterIsTab = false;
            this.ce.SetEnterIsTab(this.zcTextBox3, true);
            this.dcm1.SetIsUse(this.zcTextBox3, true);
            this.zcTextBox3.Location = new System.Drawing.Point(239, 86);
            this.zcTextBox3.Name = "zcTextBox3";
            this.zcTextBox3.Size = new System.Drawing.Size(64, 21);
            this.zcTextBox3.TabIndex = 5;
            this.dcm1.SetTagColumnName(this.zcTextBox3, null);
            this.dcm1.SetTextColumnName(this.zcTextBox3, "PanDuanFenShu");
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(197, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 12);
            this.label5.TabIndex = 11;
            this.label5.Text = "分值：";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(197, 60);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(41, 12);
            this.label10.TabIndex = 11;
            this.label10.Text = "分值：";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(197, 91);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(41, 12);
            this.label11.TabIndex = 11;
            this.label11.Text = "分值：";
            // 
            // txtDanXuanShuLiang
            // 
            this.txtDanXuanShuLiang.EmptyTextTip = null;
            this.txtDanXuanShuLiang.EmptyTextTipColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.txtDanXuanShuLiang.EnterIsTab = false;
            this.ce.SetEnterIsTab(this.txtDanXuanShuLiang, true);
            this.dcm1.SetIsUse(this.txtDanXuanShuLiang, true);
            this.txtDanXuanShuLiang.Location = new System.Drawing.Point(108, 24);
            this.txtDanXuanShuLiang.Name = "txtDanXuanShuLiang";
            this.txtDanXuanShuLiang.Size = new System.Drawing.Size(64, 21);
            this.txtDanXuanShuLiang.TabIndex = 0;
            this.dcm1.SetTagColumnName(this.txtDanXuanShuLiang, null);
            this.dcm1.SetTextColumnName(this.txtDanXuanShuLiang, "DanXuanShuLiang");
            // 
            // txtDuoXuanShuliang
            // 
            this.txtDuoXuanShuliang.EmptyTextTip = null;
            this.txtDuoXuanShuliang.EmptyTextTipColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.txtDuoXuanShuliang.EnterIsTab = false;
            this.ce.SetEnterIsTab(this.txtDuoXuanShuliang, true);
            this.dcm1.SetIsUse(this.txtDuoXuanShuliang, true);
            this.txtDuoXuanShuliang.Location = new System.Drawing.Point(108, 55);
            this.txtDuoXuanShuliang.Name = "txtDuoXuanShuliang";
            this.txtDuoXuanShuliang.Size = new System.Drawing.Size(64, 21);
            this.txtDuoXuanShuliang.TabIndex = 2;
            this.dcm1.SetTagColumnName(this.txtDuoXuanShuliang, null);
            this.dcm1.SetTextColumnName(this.txtDuoXuanShuliang, "DuoXuanShuLiang");
            // 
            // txtPanDuanShuLiang
            // 
            this.txtPanDuanShuLiang.EmptyTextTip = null;
            this.txtPanDuanShuLiang.EmptyTextTipColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.txtPanDuanShuLiang.EnterIsTab = false;
            this.ce.SetEnterIsTab(this.txtPanDuanShuLiang, true);
            this.dcm1.SetIsUse(this.txtPanDuanShuLiang, true);
            this.txtPanDuanShuLiang.Location = new System.Drawing.Point(108, 86);
            this.txtPanDuanShuLiang.Name = "txtPanDuanShuLiang";
            this.txtPanDuanShuLiang.Size = new System.Drawing.Size(64, 21);
            this.txtPanDuanShuLiang.TabIndex = 4;
            this.dcm1.SetTagColumnName(this.txtPanDuanShuLiang, null);
            this.dcm1.SetTextColumnName(this.txtPanDuanShuLiang, "PanDuanShuLiang");
            // 
            // FrmShiTiMuBanShengCheng
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(339, 171);
            this.Controls.Add(this.zcTextBox3);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.zcTextBox2);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtPanDuanShuLiang);
            this.Controls.Add(this.txtDuoXuanShuliang);
            this.Controls.Add(this.txtDanXuanShuLiang);
            this.Controls.Add(this.zcTextBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.KeyPreview = true;
            this.Name = "FrmShiTiMuBanShengCheng";
            this.Text = "试题生成";
            this.Load += new System.EventHandler(this.FrmShiTiMuBanShengCheng_Load);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label8, 0);
            this.Controls.SetChildIndex(this.btnOK, 0);
            this.Controls.SetChildIndex(this.btnCancel, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.zcTextBox1, 0);
            this.Controls.SetChildIndex(this.txtDanXuanShuLiang, 0);
            this.Controls.SetChildIndex(this.txtDuoXuanShuliang, 0);
            this.Controls.SetChildIndex(this.txtPanDuanShuLiang, 0);
            this.Controls.SetChildIndex(this.label10, 0);
            this.Controls.SetChildIndex(this.zcTextBox2, 0);
            this.Controls.SetChildIndex(this.label11, 0);
            this.Controls.SetChildIndex(this.zcTextBox3, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private Framework.WinCommon.Components.DCM dcm1;
        private System.Windows.Forms.Label label5;
        private Framework.WinCommon.Controls.ZCTextBox zcTextBox1;
        private System.Windows.Forms.Label label10;
        private Framework.WinCommon.Controls.ZCTextBox zcTextBox2;
        private System.Windows.Forms.Label label11;
        private Framework.WinCommon.Controls.ZCTextBox zcTextBox3;
        private Framework.WinCommon.Controls.ZCTextBox txtDanXuanShuLiang;
        private Framework.WinCommon.Controls.ZCTextBox txtDuoXuanShuliang;
        private Framework.WinCommon.Controls.ZCTextBox txtPanDuanShuLiang;
        private Framework.WinCommon.Components.ControlExtend ce;
    }
}