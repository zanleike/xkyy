namespace NursingManage.Win.TongJiByHis
{
    partial class FrmGongZuoLiangPeiZhiEdit
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
            this.txtORDERNO = new Framework.WinCommon.Controls.ZCTextBox();
            this.dcm1 = new Framework.WinCommon.Components.DCM(this.components);
            this.txtITEMNAME = new Framework.WinCommon.Controls.ZCTextBox();
            this.txtSCOREVALUE = new Framework.WinCommon.Controls.ZCTextBox();
            this.txtSQLTEXT = new Framework.WinCommon.Controls.ZCTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "排序：";
            // 
            // txtORDERNO
            // 
            this.txtORDERNO.EmptyTextTip = null;
            this.txtORDERNO.EmptyTextTipColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.txtORDERNO.EnterIsTab = false;
            this.dcm1.SetIsUse(this.txtORDERNO, true);
            this.txtORDERNO.Location = new System.Drawing.Point(109, 22);
            this.txtORDERNO.Name = "txtORDERNO";
            this.txtORDERNO.Size = new System.Drawing.Size(107, 25);
            this.txtORDERNO.TabIndex = 2;
            this.dcm1.SetTagColumnName(this.txtORDERNO, null);
            this.dcm1.SetTextColumnName(this.txtORDERNO, "ORDERNO");
            // 
            // txtITEMNAME
            // 
            this.txtITEMNAME.EmptyTextTip = null;
            this.txtITEMNAME.EmptyTextTipColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.txtITEMNAME.EnterIsTab = false;
            this.dcm1.SetIsUse(this.txtITEMNAME, true);
            this.txtITEMNAME.Location = new System.Drawing.Point(333, 22);
            this.txtITEMNAME.Name = "txtITEMNAME";
            this.txtITEMNAME.Size = new System.Drawing.Size(166, 25);
            this.txtITEMNAME.TabIndex = 2;
            this.dcm1.SetTagColumnName(this.txtITEMNAME, null);
            this.dcm1.SetTextColumnName(this.txtITEMNAME, "ITEMNAME");
            // 
            // txtSCOREVALUE
            // 
            this.txtSCOREVALUE.EmptyTextTip = null;
            this.txtSCOREVALUE.EmptyTextTipColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.txtSCOREVALUE.EnterIsTab = false;
            this.dcm1.SetIsUse(this.txtSCOREVALUE, true);
            this.txtSCOREVALUE.Location = new System.Drawing.Point(577, 22);
            this.txtSCOREVALUE.Name = "txtSCOREVALUE";
            this.txtSCOREVALUE.Size = new System.Drawing.Size(115, 25);
            this.txtSCOREVALUE.TabIndex = 2;
            this.dcm1.SetTagColumnName(this.txtSCOREVALUE, null);
            this.dcm1.SetTextColumnName(this.txtSCOREVALUE, "SCOREVALUE");
            // 
            // txtSQLTEXT
            // 
            this.txtSQLTEXT.EmptyTextTip = null;
            this.txtSQLTEXT.EmptyTextTipColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.txtSQLTEXT.EnterIsTab = false;
            this.dcm1.SetIsUse(this.txtSQLTEXT, true);
            this.txtSQLTEXT.Location = new System.Drawing.Point(109, 71);
            this.txtSQLTEXT.Multiline = true;
            this.txtSQLTEXT.Name = "txtSQLTEXT";
            this.txtSQLTEXT.Size = new System.Drawing.Size(813, 468);
            this.txtSQLTEXT.TabIndex = 2;
            this.dcm1.SetTagColumnName(this.txtSQLTEXT, null);
            this.dcm1.SetTextColumnName(this.txtSQLTEXT, "SQLTEXT");
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(245, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "项目名称：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(519, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 15);
            this.label3.TabIndex = 1;
            this.label3.Text = "分值：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 15);
            this.label4.TabIndex = 1;
            this.label4.Text = "sql文本：";
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(753, 558);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 32);
            this.btnOK.TabIndex = 3;
            this.btnOK.Text = "确定";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(847, 558);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 32);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // FrmGongZuoLiangPeiZhiEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(952, 610);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.txtSQLTEXT);
            this.Controls.Add(this.txtSCOREVALUE);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtITEMNAME);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtORDERNO);
            this.Controls.Add(this.label1);
            this.KeyPreview = true;
            this.Name = "FrmGongZuoLiangPeiZhiEdit";
            this.Text = "工作量配置编辑";
            this.Load += new System.EventHandler(this.FrmGongZuoLiangPeiZhiEdit_Load);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.txtORDERNO, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.txtITEMNAME, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.txtSCOREVALUE, 0);
            this.Controls.SetChildIndex(this.txtSQLTEXT, 0);
            this.Controls.SetChildIndex(this.btnOK, 0);
            this.Controls.SetChildIndex(this.btnCancel, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Framework.WinCommon.Controls.ZCTextBox txtORDERNO;
        private Framework.WinCommon.Components.DCM dcm1;
        private System.Windows.Forms.Label label2;
        private Framework.WinCommon.Controls.ZCTextBox txtITEMNAME;
        private System.Windows.Forms.Label label3;
        private Framework.WinCommon.Controls.ZCTextBox txtSCOREVALUE;
        private System.Windows.Forms.Label label4;
        private Framework.WinCommon.Controls.ZCTextBox txtSQLTEXT;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
    }
}