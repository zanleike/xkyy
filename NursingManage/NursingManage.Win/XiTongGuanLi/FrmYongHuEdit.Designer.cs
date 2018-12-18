namespace NursingManage.Win.XiTongGuanLi
{
    partial class FrmYongHuEdit
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
            this.txtUserNo = new Framework.WinCommon.Controls.ZCTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUSER_NAME = new Framework.WinCommon.Controls.ZCTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtUSER_NAME_PY = new Framework.WinCommon.Controls.ZCTextBox();
            this.dcm1 = new Framework.WinCommon.Components.DCM(this.components);
            this.txtRole = new Framework.WinCommon.Controls.ZCTextBox();
            this.txtKeShi = new Framework.WinCommon.Controls.ZCTextBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.comboxList1 = new Framework.WinCommon.Components.ComboxList(this.components);
            this.label6 = new System.Windows.Forms.Label();
            this.ce = new Framework.WinCommon.Components.ControlExtend(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(63, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "工号：";
            // 
            // txtUserNo
            // 
            this.comboxList1.SetColumns(this.txtUserNo, new Framework.WinCommon.Components.ComBoxListColumn[0]);
            this.comboxList1.SetDisplayRowCount(this.txtUserNo, 0);
            this.txtUserNo.EmptyTextTip = null;
            this.txtUserNo.EmptyTextTipColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ce.SetEnterIsTab(this.txtUserNo, true);
            this.txtUserNo.EnterIsTab = true;
            this.comboxList1.SetGridViewWidth(this.txtUserNo, 0);
            this.comboxList1.SetIsUse(this.txtUserNo, false);
            this.dcm1.SetIsUse(this.txtUserNo, true);
            this.txtUserNo.Location = new System.Drawing.Point(107, 23);
            this.txtUserNo.Name = "txtUserNo";
            this.comboxList1.SetNextControl(this.txtUserNo, this.txtUserNo);
            this.txtUserNo.Size = new System.Drawing.Size(188, 25);
            this.txtUserNo.TabIndex = 0;
            this.dcm1.SetTagColumnName(this.txtUserNo, null);
            this.dcm1.SetTextColumnName(this.txtUserNo, "USER_NO");
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(63, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "姓名：";
            // 
            // txtUSER_NAME
            // 
            this.comboxList1.SetColumns(this.txtUSER_NAME, new Framework.WinCommon.Components.ComBoxListColumn[0]);
            this.comboxList1.SetDisplayRowCount(this.txtUSER_NAME, 0);
            this.txtUSER_NAME.EmptyTextTip = null;
            this.txtUSER_NAME.EmptyTextTipColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ce.SetEnterIsTab(this.txtUSER_NAME, true);
            this.txtUSER_NAME.EnterIsTab = true;
            this.comboxList1.SetGridViewWidth(this.txtUSER_NAME, 0);
            this.comboxList1.SetIsUse(this.txtUSER_NAME, false);
            this.dcm1.SetIsUse(this.txtUSER_NAME, true);
            this.txtUSER_NAME.Location = new System.Drawing.Point(107, 52);
            this.txtUSER_NAME.Name = "txtUSER_NAME";
            this.comboxList1.SetNextControl(this.txtUSER_NAME, this.txtUSER_NAME);
            this.txtUSER_NAME.Size = new System.Drawing.Size(188, 25);
            this.txtUSER_NAME.TabIndex = 1;
            this.dcm1.SetTagColumnName(this.txtUSER_NAME, null);
            this.dcm1.SetTextColumnName(this.txtUSER_NAME, "USER_NAME");
            this.txtUSER_NAME.Leave += new System.EventHandler(this.txtUSER_NAME_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(51, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 15);
            this.label3.TabIndex = 1;
            this.label3.Text = "拼音码：";
            // 
            // txtUSER_NAME_PY
            // 
            this.comboxList1.SetColumns(this.txtUSER_NAME_PY, new Framework.WinCommon.Components.ComBoxListColumn[0]);
            this.comboxList1.SetDisplayRowCount(this.txtUSER_NAME_PY, 0);
            this.txtUSER_NAME_PY.EmptyTextTip = null;
            this.txtUSER_NAME_PY.EmptyTextTipColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ce.SetEnterIsTab(this.txtUSER_NAME_PY, true);
            this.txtUSER_NAME_PY.EnterIsTab = true;
            this.comboxList1.SetGridViewWidth(this.txtUSER_NAME_PY, 0);
            this.comboxList1.SetIsUse(this.txtUSER_NAME_PY, false);
            this.dcm1.SetIsUse(this.txtUSER_NAME_PY, true);
            this.txtUSER_NAME_PY.Location = new System.Drawing.Point(107, 81);
            this.txtUSER_NAME_PY.Name = "txtUSER_NAME_PY";
            this.comboxList1.SetNextControl(this.txtUSER_NAME_PY, this.txtUSER_NAME_PY);
            this.txtUSER_NAME_PY.Size = new System.Drawing.Size(188, 25);
            this.txtUSER_NAME_PY.TabIndex = 2;
            this.dcm1.SetTagColumnName(this.txtUSER_NAME_PY, null);
            this.dcm1.SetTextColumnName(this.txtUSER_NAME_PY, "USER_NAME_PY");
            // 
            // txtRole
            // 
            this.comboxList1.SetColumns(this.txtRole, new Framework.WinCommon.Components.ComBoxListColumn[0]);
            this.comboxList1.SetDisplayRowCount(this.txtRole, 0);
            this.txtRole.EmptyTextTip = "按回车搜索";
            this.txtRole.EmptyTextTipColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ce.SetEnterIsTab(this.txtRole, false);
            this.txtRole.EnterIsTab = false;
            this.comboxList1.SetGridViewWidth(this.txtRole, 0);
            this.comboxList1.SetIsUse(this.txtRole, false);
            this.dcm1.SetIsUse(this.txtRole, true);
            this.txtRole.Location = new System.Drawing.Point(107, 110);
            this.txtRole.Name = "txtRole";
            this.comboxList1.SetNextControl(this.txtRole, this.txtKeShi);
            this.txtRole.Size = new System.Drawing.Size(188, 25);
            this.txtRole.TabIndex = 3;
            this.dcm1.SetTagColumnName(this.txtRole, "ROLE_ID");
            this.dcm1.SetTextColumnName(this.txtRole, "ROLE_NAME");
            // 
            // txtKeShi
            // 
            this.comboxList1.SetColumns(this.txtKeShi, new Framework.WinCommon.Components.ComBoxListColumn[0]);
            this.comboxList1.SetDisplayRowCount(this.txtKeShi, 0);
            this.txtKeShi.EmptyTextTip = "按回车搜索";
            this.txtKeShi.EmptyTextTipColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ce.SetEnterIsTab(this.txtKeShi, false);
            this.txtKeShi.EnterIsTab = false;
            this.comboxList1.SetGridViewWidth(this.txtKeShi, 0);
            this.comboxList1.SetIsUse(this.txtKeShi, false);
            this.dcm1.SetIsUse(this.txtKeShi, true);
            this.txtKeShi.Location = new System.Drawing.Point(107, 139);
            this.txtKeShi.Name = "txtKeShi";
            this.txtKeShi.Size = new System.Drawing.Size(188, 25);
            this.txtKeShi.TabIndex = 4;
            this.dcm1.SetTagColumnName(this.txtKeShi, "KeShiId");
            this.dcm1.SetTextColumnName(this.txtKeShi, "KeShiMingCheng");
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(74, 216);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 27);
            this.btnOK.TabIndex = 6;
            this.btnOK.Text = "确定";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(241, 216);
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
            this.label5.Location = new System.Drawing.Point(39, 114);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 15);
            this.label5.TabIndex = 1;
            this.label5.Text = "权限角色：";
            // 
            // comboxList1
            // 
            this.comboxList1.GridViewDataSource = null;
            this.comboxList1.MaxRowCount = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(63, 143);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 15);
            this.label6.TabIndex = 6;
            this.label6.Text = "科室：";
            // 
            // FrmYongHuEdit
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(367, 272);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.txtKeShi);
            this.Controls.Add(this.txtRole);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtUSER_NAME_PY);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtUSER_NAME);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtUserNo);
            this.Controls.Add(this.label1);
            this.KeyPreview = true;
            this.Name = "FrmYongHuEdit";
            this.Text = "用户信息";
            this.Load += new System.EventHandler(this.FrmYongHuEdit_Load);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.txtUserNo, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.txtUSER_NAME, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.txtUSER_NAME_PY, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.txtRole, 0);
            this.Controls.SetChildIndex(this.txtKeShi, 0);
            this.Controls.SetChildIndex(this.btnOK, 0);
            this.Controls.SetChildIndex(this.btnCancel, 0);
            this.Controls.SetChildIndex(this.label6, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Framework.WinCommon.Controls.ZCTextBox txtUserNo;
        private System.Windows.Forms.Label label2;
        private Framework.WinCommon.Controls.ZCTextBox txtUSER_NAME;
        private System.Windows.Forms.Label label3;
        private Framework.WinCommon.Controls.ZCTextBox txtUSER_NAME_PY;
        private Framework.WinCommon.Components.DCM dcm1;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label5;
        private Framework.WinCommon.Controls.ZCTextBox txtRole;
        private Framework.WinCommon.Components.ComboxList comboxList1;
        private System.Windows.Forms.Label label6;
        private Framework.WinCommon.Controls.ZCTextBox txtKeShi;
        private Framework.WinCommon.Components.ControlExtend ce;
    }
}