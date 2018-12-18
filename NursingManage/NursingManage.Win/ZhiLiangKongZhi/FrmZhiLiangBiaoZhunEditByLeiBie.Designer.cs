namespace NursingManage.Win.ZhiLiangKongZhi
{
    partial class FrmZhiLiangBiaoZhunEditByLeiBie
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
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.dcm1 = new Framework.WinCommon.Components.DCM(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.txtMingCheng = new Framework.WinCommon.Controls.ZCTextBox();
            this.zcTextBox1 = new Framework.WinCommon.Controls.ZCTextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "类别名称：";
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(332, 113);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 25);
            this.btnOK.TabIndex = 2;
            this.btnOK.Text = "确定";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(422, 113);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 25);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "备注：";
            // 
            // txtMingCheng
            // 
            this.txtMingCheng.EmptyTextTip = null;
            this.txtMingCheng.EmptyTextTipColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.txtMingCheng.EnterIsTab = true;
            this.dcm1.SetIsUse(this.txtMingCheng, true);
            this.txtMingCheng.Location = new System.Drawing.Point(92, 21);
            this.txtMingCheng.Name = "txtMingCheng";
            this.txtMingCheng.Size = new System.Drawing.Size(405, 21);
            this.txtMingCheng.TabIndex = 0;
            this.dcm1.SetTagColumnName(this.txtMingCheng, null);
            this.dcm1.SetTextColumnName(this.txtMingCheng, "MingCheng");
            // 
            // zcTextBox1
            // 
            this.zcTextBox1.EmptyTextTip = null;
            this.zcTextBox1.EmptyTextTipColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.zcTextBox1.EnterIsTab = true;
            this.dcm1.SetIsUse(this.zcTextBox1, true);
            this.zcTextBox1.Location = new System.Drawing.Point(92, 54);
            this.zcTextBox1.Multiline = true;
            this.zcTextBox1.Name = "zcTextBox1";
            this.zcTextBox1.Size = new System.Drawing.Size(405, 44);
            this.zcTextBox1.TabIndex = 1;
            this.dcm1.SetTagColumnName(this.zcTextBox1, null);
            this.dcm1.SetTextColumnName(this.zcTextBox1, "BEIZHU");
            // 
            // FrmZhiLiangBiaoZhunEditByLeiBie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 158);
            this.Controls.Add(this.zcTextBox1);
            this.Controls.Add(this.txtMingCheng);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.label1);
            this.KeyPreview = true;
            this.Name = "FrmZhiLiangBiaoZhunEditByLeiBie";
            this.Text = "质量标准类别";
            this.Load += new System.EventHandler(this.FrmZhiLiangBiaoZhunEditByLeiBie_Load);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.btnOK, 0);
            this.Controls.SetChildIndex(this.btnCancel, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.txtMingCheng, 0);
            this.Controls.SetChildIndex(this.zcTextBox1, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private Framework.WinCommon.Components.DCM dcm1;
        private System.Windows.Forms.Label label2;
        private Framework.WinCommon.Controls.ZCTextBox txtMingCheng;
        private Framework.WinCommon.Controls.ZCTextBox zcTextBox1;
    }
}