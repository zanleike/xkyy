namespace NursingManage.Win.ZhiLiangKongZhi
{
    partial class FrmZhiKongJiHuaManYiDuLuRu
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
            this.txtJiHuaMingCheng = new Framework.WinCommon.Controls.ZCTextBox();
            this.txtKeShi = new Framework.WinCommon.Controls.ZCTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.zcTextBox3 = new Framework.WinCommon.Controls.ZCTextBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.dcm1 = new Framework.WinCommon.Components.DCM(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "科室名称：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "计划名称：";
            // 
            // txtJiHuaMingCheng
            // 
            this.txtJiHuaMingCheng.EmptyTextTip = null;
            this.txtJiHuaMingCheng.EmptyTextTipColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.txtJiHuaMingCheng.EnterIsTab = false;
            this.dcm1.SetIsUse(this.txtJiHuaMingCheng, true);
            this.txtJiHuaMingCheng.Location = new System.Drawing.Point(114, 23);
            this.txtJiHuaMingCheng.Name = "txtJiHuaMingCheng";
            this.txtJiHuaMingCheng.ReadOnly = true;
            this.txtJiHuaMingCheng.Size = new System.Drawing.Size(365, 25);
            this.txtJiHuaMingCheng.TabIndex = 0;
            this.dcm1.SetTagColumnName(this.txtJiHuaMingCheng, null);
            this.dcm1.SetTextColumnName(this.txtJiHuaMingCheng, "JiHuaMingCheng");
            // 
            // txtKeShi
            // 
            this.txtKeShi.EmptyTextTip = null;
            this.txtKeShi.EmptyTextTipColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.txtKeShi.EnterIsTab = false;
            this.dcm1.SetIsUse(this.txtKeShi, true);
            this.txtKeShi.Location = new System.Drawing.Point(114, 54);
            this.txtKeShi.Name = "txtKeShi";
            this.txtKeShi.ReadOnly = true;
            this.txtKeShi.Size = new System.Drawing.Size(365, 25);
            this.txtKeShi.TabIndex = 1;
            this.dcm1.SetTagColumnName(this.txtKeShi, null);
            this.dcm1.SetTextColumnName(this.txtKeShi, "KeShi");
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 15);
            this.label3.TabIndex = 1;
            this.label3.Text = "调查结果：";
            // 
            // zcTextBox3
            // 
            this.zcTextBox3.EmptyTextTip = null;
            this.zcTextBox3.EmptyTextTipColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.zcTextBox3.EnterIsTab = false;
            this.dcm1.SetIsUse(this.zcTextBox3, true);
            this.zcTextBox3.Location = new System.Drawing.Point(114, 89);
            this.zcTextBox3.MaxLength = 500;
            this.zcTextBox3.Multiline = true;
            this.zcTextBox3.Name = "zcTextBox3";
            this.zcTextBox3.Size = new System.Drawing.Size(365, 113);
            this.zcTextBox3.TabIndex = 2;
            this.dcm1.SetTagColumnName(this.zcTextBox3, null);
            this.dcm1.SetTextColumnName(this.zcTextBox3, "ManYiDuShuoMing");
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(305, 224);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 32);
            this.btnOK.TabIndex = 3;
            this.btnOK.Text = "确定";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(404, 224);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 32);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // FrmZhiKongJiHuaManYiDuLuRu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(522, 276);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.zcTextBox3);
            this.Controls.Add(this.txtKeShi);
            this.Controls.Add(this.txtJiHuaMingCheng);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.KeyPreview = true;
            this.Name = "FrmZhiKongJiHuaManYiDuLuRu";
            this.Text = "满意度调查结果录入";
            this.Load += new System.EventHandler(this.FrmZhiKongJiHuaManYiDuLuRu_Load);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.txtJiHuaMingCheng, 0);
            this.Controls.SetChildIndex(this.txtKeShi, 0);
            this.Controls.SetChildIndex(this.zcTextBox3, 0);
            this.Controls.SetChildIndex(this.btnOK, 0);
            this.Controls.SetChildIndex(this.btnCancel, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Framework.WinCommon.Controls.ZCTextBox txtJiHuaMingCheng;
        private Framework.WinCommon.Controls.ZCTextBox txtKeShi;
        private System.Windows.Forms.Label label3;
        private Framework.WinCommon.Controls.ZCTextBox zcTextBox3;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private Framework.WinCommon.Components.DCM dcm1;
    }
}