namespace NursingManage.Win.PeiXunGuanLi
{
    partial class FrmJiNengBiaoZhunLeiBieEdit
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
            this.zcTextBox1 = new Framework.WinCommon.Controls.ZCTextBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.dcm1 = new Framework.WinCommon.Components.DCM(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "类别名称：";
            // 
            // zcTextBox1
            // 
            this.zcTextBox1.EmptyTextTip = null;
            this.zcTextBox1.EmptyTextTipColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.zcTextBox1.EnterIsTab = false;
            this.dcm1.SetIsUse(this.zcTextBox1, true);
            this.zcTextBox1.Location = new System.Drawing.Point(126, 38);
            this.zcTextBox1.Name = "zcTextBox1";
            this.zcTextBox1.Size = new System.Drawing.Size(235, 25);
            this.zcTextBox1.TabIndex = 2;
            this.dcm1.SetTagColumnName(this.zcTextBox1, null);
            this.dcm1.SetTextColumnName(this.zcTextBox1, "MingCheng");
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(177, 106);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(87, 30);
            this.btnOK.TabIndex = 3;
            this.btnOK.Text = "确定";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(286, 106);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(87, 30);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // FrmJiNengBiaoZhunLeiBieEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(423, 166);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.zcTextBox1);
            this.Controls.Add(this.label1);
            this.KeyPreview = true;
            this.Name = "FrmJiNengBiaoZhunLeiBieEdit";
            this.Text = "技能标准类别编辑";
            this.Load += new System.EventHandler(this.FrmJiNengBiaoZhunLeiBieEdit_Load);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.zcTextBox1, 0);
            this.Controls.SetChildIndex(this.btnOK, 0);
            this.Controls.SetChildIndex(this.btnCancel, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Framework.WinCommon.Controls.ZCTextBox zcTextBox1;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private Framework.WinCommon.Components.DCM dcm1;
    }
}