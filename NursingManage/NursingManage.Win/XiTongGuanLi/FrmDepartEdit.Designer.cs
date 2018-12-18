namespace NursingManage.Win.XiTongGuanLi
{
    partial class FrmDepartEdit
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
            this.label3 = new System.Windows.Forms.Label();
            this.txtMingCheng = new Framework.WinCommon.Controls.ZCTextBox();
            this.txtMINGCHENG_PY = new Framework.WinCommon.Controls.ZCTextBox();
            this.zcTextBox3 = new Framework.WinCommon.Controls.ZCTextBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.dcm1 = new Framework.WinCommon.Components.DCM(this.components);
            this.txtPName = new Framework.WinCommon.Controls.ZCTextBox();
            this.ce = new Framework.WinCommon.Components.ControlExtend(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtBianMa = new Framework.WinCommon.Controls.ZCTextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(64, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "科室名称：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(79, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "助记码：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(64, 176);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 15);
            this.label3.TabIndex = 1;
            this.label3.Text = "科室类别：";
            // 
            // txtMingCheng
            // 
            this.txtMingCheng.EmptyTextTip = null;
            this.txtMingCheng.EmptyTextTipColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.txtMingCheng.EnterIsTab = false;
            this.ce.SetEnterIsTab(this.txtMingCheng, true);
            this.dcm1.SetIsUse(this.txtMingCheng, true);
            this.txtMingCheng.Location = new System.Drawing.Point(150, 98);
            this.txtMingCheng.Name = "txtMingCheng";
            this.txtMingCheng.Size = new System.Drawing.Size(241, 25);
            this.txtMingCheng.TabIndex = 1;
            this.dcm1.SetTagColumnName(this.txtMingCheng, null);
            this.dcm1.SetTextColumnName(this.txtMingCheng, "MINGCHENG");
            this.txtMingCheng.Leave += new System.EventHandler(this.txtMingCheng_Leave);
            // 
            // txtMINGCHENG_PY
            // 
            this.txtMINGCHENG_PY.EmptyTextTip = null;
            this.txtMINGCHENG_PY.EmptyTextTipColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.txtMINGCHENG_PY.EnterIsTab = false;
            this.ce.SetEnterIsTab(this.txtMINGCHENG_PY, true);
            this.dcm1.SetIsUse(this.txtMINGCHENG_PY, true);
            this.txtMINGCHENG_PY.Location = new System.Drawing.Point(150, 135);
            this.txtMINGCHENG_PY.Name = "txtMINGCHENG_PY";
            this.txtMINGCHENG_PY.Size = new System.Drawing.Size(241, 25);
            this.txtMINGCHENG_PY.TabIndex = 2;
            this.dcm1.SetTagColumnName(this.txtMINGCHENG_PY, null);
            this.dcm1.SetTextColumnName(this.txtMINGCHENG_PY, "MINGCHENG_PY");
            // 
            // zcTextBox3
            // 
            this.zcTextBox3.EmptyTextTip = null;
            this.zcTextBox3.EmptyTextTipColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.zcTextBox3.EnterIsTab = false;
            this.ce.SetEnterIsTab(this.zcTextBox3, true);
            this.dcm1.SetIsUse(this.zcTextBox3, false);
            this.zcTextBox3.Location = new System.Drawing.Point(150, 172);
            this.zcTextBox3.Name = "zcTextBox3";
            this.zcTextBox3.Size = new System.Drawing.Size(241, 25);
            this.zcTextBox3.TabIndex = 3;
            this.dcm1.SetTagColumnName(this.zcTextBox3, null);
            this.dcm1.SetTextColumnName(this.zcTextBox3, null);
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(234, 217);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 33);
            this.btnOK.TabIndex = 4;
            this.btnOK.Text = "确定";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(334, 217);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 33);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // txtPName
            // 
            this.txtPName.EmptyTextTip = null;
            this.txtPName.EmptyTextTipColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.txtPName.EnterIsTab = false;
            this.ce.SetEnterIsTab(this.txtPName, true);
            this.dcm1.SetIsUse(this.txtPName, true);
            this.txtPName.Location = new System.Drawing.Point(150, 24);
            this.txtPName.Name = "txtPName";
            this.txtPName.ReadOnly = true;
            this.txtPName.Size = new System.Drawing.Size(241, 25);
            this.txtPName.TabIndex = 10;
            this.dcm1.SetTagColumnName(this.txtPName, null);
            this.dcm1.SetTextColumnName(this.txtPName, "ParentName");
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(67, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 15);
            this.label4.TabIndex = 5;
            this.label4.Text = "上级科室：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(64, 65);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 15);
            this.label5.TabIndex = 1;
            this.label5.Text = "科室编码：";
            // 
            // txtBianMa
            // 
            this.txtBianMa.EmptyTextTip = null;
            this.txtBianMa.EmptyTextTipColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.txtBianMa.EnterIsTab = false;
            this.ce.SetEnterIsTab(this.txtBianMa, true);
            this.dcm1.SetIsUse(this.txtBianMa, true);
            this.txtBianMa.Location = new System.Drawing.Point(150, 61);
            this.txtBianMa.Name = "txtBianMa";
            this.txtBianMa.Size = new System.Drawing.Size(241, 25);
            this.txtBianMa.TabIndex = 0;
            this.dcm1.SetTagColumnName(this.txtBianMa, null);
            this.dcm1.SetTextColumnName(this.txtBianMa, "BIANMA");
            this.txtBianMa.Leave += new System.EventHandler(this.txtMingCheng_Leave);
            // 
            // FrmDepartEdit
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(454, 274);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.txtPName);
            this.Controls.Add(this.zcTextBox3);
            this.Controls.Add(this.txtMINGCHENG_PY);
            this.Controls.Add(this.txtBianMa);
            this.Controls.Add(this.txtMingCheng);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.KeyPreview = true;
            this.Name = "FrmDepartEdit";
            this.Text = "科室编辑";
            this.Load += new System.EventHandler(this.FrmDepartEdit_Load);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.txtMingCheng, 0);
            this.Controls.SetChildIndex(this.txtBianMa, 0);
            this.Controls.SetChildIndex(this.txtMINGCHENG_PY, 0);
            this.Controls.SetChildIndex(this.zcTextBox3, 0);
            this.Controls.SetChildIndex(this.txtPName, 0);
            this.Controls.SetChildIndex(this.btnOK, 0);
            this.Controls.SetChildIndex(this.btnCancel, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private Framework.WinCommon.Controls.ZCTextBox txtMingCheng;
        private Framework.WinCommon.Controls.ZCTextBox txtMINGCHENG_PY;
        private Framework.WinCommon.Controls.ZCTextBox zcTextBox3;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private Framework.WinCommon.Components.DCM dcm1;
        private Framework.WinCommon.Components.ControlExtend ce;
        private System.Windows.Forms.Label label4;
        private Framework.WinCommon.Controls.ZCTextBox txtPName;
        private System.Windows.Forms.Label label5;
        private Framework.WinCommon.Controls.ZCTextBox txtBianMa;
    }
}