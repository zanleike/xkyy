namespace NursingManage.Win.PeiXunGuanLi
{
    partial class FrmJiNengBiaoZhunEdit
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
            this.txtLeiXing1 = new Framework.WinCommon.Controls.ZCTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtLeiXing2 = new Framework.WinCommon.Controls.ZCTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNEIRONG = new Framework.WinCommon.Controls.ZCTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtFENSHU = new Framework.WinCommon.Controls.ZCTextBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.dcm1 = new Framework.WinCommon.Components.DCM(this.components);
            this.SuspendLayout();
            // 
            // txtLeiXing1
            // 
            this.txtLeiXing1.EmptyTextTip = null;
            this.txtLeiXing1.EmptyTextTipColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.txtLeiXing1.EnterIsTab = false;
            this.dcm1.SetIsUse(this.txtLeiXing1, true);
            this.txtLeiXing1.Location = new System.Drawing.Point(131, 28);
            this.txtLeiXing1.Name = "txtLeiXing1";
            this.txtLeiXing1.Size = new System.Drawing.Size(443, 25);
            this.txtLeiXing1.TabIndex = 0;
            this.dcm1.SetTagColumnName(this.txtLeiXing1, null);
            this.dcm1.SetTextColumnName(this.txtLeiXing1, "LeiXing1");
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "一级类型：";
            // 
            // txtLeiXing2
            // 
            this.txtLeiXing2.EmptyTextTip = null;
            this.txtLeiXing2.EmptyTextTipColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.txtLeiXing2.EnterIsTab = false;
            this.dcm1.SetIsUse(this.txtLeiXing2, true);
            this.txtLeiXing2.Location = new System.Drawing.Point(131, 65);
            this.txtLeiXing2.Name = "txtLeiXing2";
            this.txtLeiXing2.Size = new System.Drawing.Size(443, 25);
            this.txtLeiXing2.TabIndex = 1;
            this.dcm1.SetTagColumnName(this.txtLeiXing2, null);
            this.dcm1.SetTextColumnName(this.txtLeiXing2, "LeiXing2");
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "二级类型：";
            // 
            // txtNEIRONG
            // 
            this.txtNEIRONG.EmptyTextTip = null;
            this.txtNEIRONG.EmptyTextTipColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.txtNEIRONG.EnterIsTab = false;
            this.dcm1.SetIsUse(this.txtNEIRONG, true);
            this.txtNEIRONG.Location = new System.Drawing.Point(131, 102);
            this.txtNEIRONG.Multiline = true;
            this.txtNEIRONG.Name = "txtNEIRONG";
            this.txtNEIRONG.Size = new System.Drawing.Size(443, 96);
            this.txtNEIRONG.TabIndex = 2;
            this.dcm1.SetTagColumnName(this.txtNEIRONG, null);
            this.dcm1.SetTextColumnName(this.txtNEIRONG, "NEIRONG");
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "扣分内容：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(71, 213);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "分值：";
            // 
            // txtFENSHU
            // 
            this.txtFENSHU.EmptyTextTip = null;
            this.txtFENSHU.EmptyTextTipColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.txtFENSHU.EnterIsTab = false;
            this.dcm1.SetIsUse(this.txtFENSHU, true);
            this.txtFENSHU.Location = new System.Drawing.Point(131, 210);
            this.txtFENSHU.Name = "txtFENSHU";
            this.txtFENSHU.Size = new System.Drawing.Size(443, 25);
            this.txtFENSHU.TabIndex = 3;
            this.dcm1.SetTagColumnName(this.txtFENSHU, null);
            this.dcm1.SetTextColumnName(this.txtFENSHU, "FENSHU");
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(392, 260);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(78, 28);
            this.btnOK.TabIndex = 4;
            this.btnOK.Text = "确定";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(509, 260);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(78, 28);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // FrmJiNengBiaoZhunEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(625, 313);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNEIRONG);
            this.Controls.Add(this.txtFENSHU);
            this.Controls.Add(this.txtLeiXing2);
            this.Controls.Add(this.txtLeiXing1);
            this.KeyPreview = true;
            this.Name = "FrmJiNengBiaoZhunEdit";
            this.Text = "技能标准编辑";
            this.Load += new System.EventHandler(this.FrmJiNengBiaoZhunEdit_Load);
            this.Controls.SetChildIndex(this.txtLeiXing1, 0);
            this.Controls.SetChildIndex(this.txtLeiXing2, 0);
            this.Controls.SetChildIndex(this.txtFENSHU, 0);
            this.Controls.SetChildIndex(this.txtNEIRONG, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.btnOK, 0);
            this.Controls.SetChildIndex(this.btnCancel, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Framework.WinCommon.Controls.ZCTextBox txtLeiXing1;
        private System.Windows.Forms.Label label1;
        private Framework.WinCommon.Controls.ZCTextBox txtLeiXing2;
        private System.Windows.Forms.Label label2;
        private Framework.WinCommon.Controls.ZCTextBox txtNEIRONG;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private Framework.WinCommon.Controls.ZCTextBox txtFENSHU;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private Framework.WinCommon.Components.DCM dcm1;
    }
}