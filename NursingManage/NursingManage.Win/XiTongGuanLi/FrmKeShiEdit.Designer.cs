namespace NursingManage.Win.XiTongGuanLi
{
    partial class FrmKeShiEdit
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
            this.txtBIANMA = new Framework.WinCommon.Controls.ZCTextBox();
            this.dcm1 = new Framework.WinCommon.Components.DCM(this.components);
            this.txtMINGCHENG = new Framework.WinCommon.Controls.ZCTextBox();
            this.txtMINGCHENG_PY = new Framework.WinCommon.Controls.ZCTextBox();
            this.zcTextBox3 = new Framework.WinCommon.Controls.ZCTextBox();
            this.zcTextBox1 = new Framework.WinCommon.Controls.ZCTextBox();
            this.zcTextBox2 = new Framework.WinCommon.Controls.ZCTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.ce = new Framework.WinCommon.Components.ControlExtend(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "科室编码：";
            // 
            // txtBIANMA
            // 
            this.txtBIANMA.EmptyTextTip = null;
            this.txtBIANMA.EmptyTextTipColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.txtBIANMA.EnterIsTab = true;
            this.ce.SetEnterIsTab(this.txtBIANMA, true);
            this.dcm1.SetIsUse(this.txtBIANMA, true);
            this.txtBIANMA.Location = new System.Drawing.Point(132, 26);
            this.txtBIANMA.Name = "txtBIANMA";
            this.txtBIANMA.Size = new System.Drawing.Size(200, 25);
            this.txtBIANMA.TabIndex = 0;
            this.dcm1.SetTagColumnName(this.txtBIANMA, null);
            this.dcm1.SetTextColumnName(this.txtBIANMA, "BIANMA");
            // 
            // txtMINGCHENG
            // 
            this.txtMINGCHENG.EmptyTextTip = null;
            this.txtMINGCHENG.EmptyTextTipColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.txtMINGCHENG.EnterIsTab = true;
            this.ce.SetEnterIsTab(this.txtMINGCHENG, true);
            this.dcm1.SetIsUse(this.txtMINGCHENG, true);
            this.txtMINGCHENG.Location = new System.Drawing.Point(132, 55);
            this.txtMINGCHENG.Name = "txtMINGCHENG";
            this.txtMINGCHENG.Size = new System.Drawing.Size(200, 25);
            this.txtMINGCHENG.TabIndex = 1;
            this.dcm1.SetTagColumnName(this.txtMINGCHENG, null);
            this.dcm1.SetTextColumnName(this.txtMINGCHENG, "MINGCHENG");
            this.txtMINGCHENG.Leave += new System.EventHandler(this.txtMINGCHENG_Leave);
            // 
            // txtMINGCHENG_PY
            // 
            this.txtMINGCHENG_PY.EmptyTextTip = null;
            this.txtMINGCHENG_PY.EmptyTextTipColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.txtMINGCHENG_PY.EnterIsTab = true;
            this.ce.SetEnterIsTab(this.txtMINGCHENG_PY, true);
            this.dcm1.SetIsUse(this.txtMINGCHENG_PY, true);
            this.txtMINGCHENG_PY.Location = new System.Drawing.Point(132, 84);
            this.txtMINGCHENG_PY.Name = "txtMINGCHENG_PY";
            this.txtMINGCHENG_PY.Size = new System.Drawing.Size(200, 25);
            this.txtMINGCHENG_PY.TabIndex = 2;
            this.dcm1.SetTagColumnName(this.txtMINGCHENG_PY, null);
            this.dcm1.SetTextColumnName(this.txtMINGCHENG_PY, "MINGCHENG_PY");
            // 
            // zcTextBox3
            // 
            this.zcTextBox3.EmptyTextTip = null;
            this.zcTextBox3.EmptyTextTipColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.zcTextBox3.EnterIsTab = true;
            this.ce.SetEnterIsTab(this.zcTextBox3, true);
            this.dcm1.SetIsUse(this.zcTextBox3, true);
            this.zcTextBox3.Location = new System.Drawing.Point(132, 171);
            this.zcTextBox3.Name = "zcTextBox3";
            this.zcTextBox3.Size = new System.Drawing.Size(200, 25);
            this.zcTextBox3.TabIndex = 5;
            this.dcm1.SetTagColumnName(this.zcTextBox3, null);
            this.dcm1.SetTextColumnName(this.zcTextBox3, "KESHILEIBIE");
            // 
            // zcTextBox1
            // 
            this.zcTextBox1.EmptyTextTip = null;
            this.zcTextBox1.EmptyTextTipColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.zcTextBox1.EnterIsTab = true;
            this.ce.SetEnterIsTab(this.zcTextBox1, true);
            this.dcm1.SetIsUse(this.zcTextBox1, true);
            this.zcTextBox1.Location = new System.Drawing.Point(132, 113);
            this.zcTextBox1.Name = "zcTextBox1";
            this.zcTextBox1.Size = new System.Drawing.Size(200, 25);
            this.zcTextBox1.TabIndex = 3;
            this.dcm1.SetTagColumnName(this.zcTextBox1, null);
            this.dcm1.SetTextColumnName(this.zcTextBox1, "LeiXing1");
            // 
            // zcTextBox2
            // 
            this.zcTextBox2.EmptyTextTip = null;
            this.zcTextBox2.EmptyTextTipColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.zcTextBox2.EnterIsTab = true;
            this.ce.SetEnterIsTab(this.zcTextBox2, true);
            this.dcm1.SetIsUse(this.zcTextBox2, true);
            this.zcTextBox2.Location = new System.Drawing.Point(132, 142);
            this.zcTextBox2.Name = "zcTextBox2";
            this.zcTextBox2.Size = new System.Drawing.Size(200, 25);
            this.zcTextBox2.TabIndex = 4;
            this.dcm1.SetTagColumnName(this.zcTextBox2, null);
            this.dcm1.SetTextColumnName(this.zcTextBox2, "LeiXing2");
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "科室名称：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(60, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 15);
            this.label3.TabIndex = 1;
            this.label3.Text = "助记码：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(45, 175);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 15);
            this.label4.TabIndex = 1;
            this.label4.Text = "科室类别：";
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(175, 214);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 27);
            this.btnOK.TabIndex = 6;
            this.btnOK.Text = "确定";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(267, 214);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 27);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(45, 117);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 15);
            this.label5.TabIndex = 1;
            this.label5.Text = "一级类型：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(45, 146);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 15);
            this.label6.TabIndex = 1;
            this.label6.Text = "二级类型：";
            // 
            // FrmKeShiEdit
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(390, 266);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.zcTextBox2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.zcTextBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.zcTextBox3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtMINGCHENG_PY);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtMINGCHENG);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtBIANMA);
            this.Controls.Add(this.label1);
            this.KeyPreview = true;
            this.Name = "FrmKeShiEdit";
            this.Text = "科室编辑";
            this.Load += new System.EventHandler(this.FrmKeShiEdit_Load);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.txtBIANMA, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.txtMINGCHENG, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.txtMINGCHENG_PY, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.zcTextBox3, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.zcTextBox1, 0);
            this.Controls.SetChildIndex(this.label6, 0);
            this.Controls.SetChildIndex(this.zcTextBox2, 0);
            this.Controls.SetChildIndex(this.btnOK, 0);
            this.Controls.SetChildIndex(this.btnCancel, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Framework.WinCommon.Controls.ZCTextBox txtBIANMA;
        private Framework.WinCommon.Components.DCM dcm1;
        private System.Windows.Forms.Label label2;
        private Framework.WinCommon.Controls.ZCTextBox txtMINGCHENG;
        private System.Windows.Forms.Label label3;
        private Framework.WinCommon.Controls.ZCTextBox txtMINGCHENG_PY;
        private System.Windows.Forms.Label label4;
        private Framework.WinCommon.Controls.ZCTextBox zcTextBox3;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label5;
        private Framework.WinCommon.Controls.ZCTextBox zcTextBox1;
        private System.Windows.Forms.Label label6;
        private Framework.WinCommon.Controls.ZCTextBox zcTextBox2;
        private Framework.WinCommon.Components.ControlExtend ce;
    }
}