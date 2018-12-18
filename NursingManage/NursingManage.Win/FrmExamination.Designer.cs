namespace NursingManage.Win
{
    partial class FrmExamination
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
            this.txtKeShi = new Framework.WinCommon.Controls.ZCTextBox();
            this.btnKeShiXuanZe = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtKaoShiRen = new Framework.WinCommon.Controls.ZCTextBox();
            this.btnKaoShiRenXuanZe = new System.Windows.Forms.Button();
            this.btnQianDao = new System.Windows.Forms.Button();
            this.btnKaiShiDaTi = new System.Windows.Forms.Button();
            this.dcm1 = new Framework.WinCommon.Components.DCM(this.components);
            this.txtJiHuaNeiRong = new Framework.WinCommon.Controls.ZCTextBox();
            this.comboxList1 = new Framework.WinCommon.Components.ComboxList(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(82, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "科室：";
            // 
            // txtKeShi
            // 
            this.comboxList1.SetColumns(this.txtKeShi, new Framework.WinCommon.Components.ComBoxListColumn[0]);
            this.comboxList1.SetDisplayRowCount(this.txtKeShi, 0);
            this.txtKeShi.EmptyTextTip = null;
            this.txtKeShi.EmptyTextTipColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.txtKeShi.EnterIsTab = false;
            this.comboxList1.SetGridViewWidth(this.txtKeShi, 0);
            this.dcm1.SetIsUse(this.txtKeShi, true);
            this.comboxList1.SetIsUse(this.txtKeShi, false);
            this.txtKeShi.Location = new System.Drawing.Point(138, 38);
            this.txtKeShi.Name = "txtKeShi";
            this.comboxList1.SetNextControl(this.txtKeShi, this.txtKeShi);
            this.txtKeShi.ReadOnly = true;
            this.txtKeShi.Size = new System.Drawing.Size(229, 25);
            this.txtKeShi.TabIndex = 11;
            this.dcm1.SetTagColumnName(this.txtKeShi, "KeShiId");
            this.dcm1.SetTextColumnName(this.txtKeShi, "KeShi");
            // 
            // btnKeShiXuanZe
            // 
            this.btnKeShiXuanZe.Location = new System.Drawing.Point(378, 36);
            this.btnKeShiXuanZe.Name = "btnKeShiXuanZe";
            this.btnKeShiXuanZe.Size = new System.Drawing.Size(75, 25);
            this.btnKeShiXuanZe.TabIndex = 0;
            this.btnKeShiXuanZe.Text = "选择";
            this.btnKeShiXuanZe.UseVisualStyleBackColor = true;
            this.btnKeShiXuanZe.Click += new System.EventHandler(this.btnKeShiXuanZe_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(65, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "考试人：";
            // 
            // txtKaoShiRen
            // 
            this.comboxList1.SetColumns(this.txtKaoShiRen, new Framework.WinCommon.Components.ComBoxListColumn[0]);
            this.comboxList1.SetDisplayRowCount(this.txtKaoShiRen, 0);
            this.txtKaoShiRen.EmptyTextTip = null;
            this.txtKaoShiRen.EmptyTextTipColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.txtKaoShiRen.EnterIsTab = false;
            this.comboxList1.SetGridViewWidth(this.txtKaoShiRen, 0);
            this.dcm1.SetIsUse(this.txtKaoShiRen, true);
            this.comboxList1.SetIsUse(this.txtKaoShiRen, false);
            this.txtKaoShiRen.Location = new System.Drawing.Point(138, 80);
            this.txtKaoShiRen.Name = "txtKaoShiRen";
            this.comboxList1.SetNextControl(this.txtKaoShiRen, this.txtKaoShiRen);
            this.txtKaoShiRen.ReadOnly = true;
            this.txtKaoShiRen.Size = new System.Drawing.Size(229, 25);
            this.txtKaoShiRen.TabIndex = 1;
            this.dcm1.SetTagColumnName(this.txtKaoShiRen, "RenYuanId");
            this.dcm1.SetTextColumnName(this.txtKaoShiRen, "RenYuan");
            // 
            // btnKaoShiRenXuanZe
            // 
            this.btnKaoShiRenXuanZe.Location = new System.Drawing.Point(378, 78);
            this.btnKaoShiRenXuanZe.Name = "btnKaoShiRenXuanZe";
            this.btnKaoShiRenXuanZe.Size = new System.Drawing.Size(75, 25);
            this.btnKaoShiRenXuanZe.TabIndex = 3;
            this.btnKaoShiRenXuanZe.Text = "选择";
            this.btnKaoShiRenXuanZe.UseVisualStyleBackColor = true;
            this.btnKaoShiRenXuanZe.Click += new System.EventHandler(this.btnKaoShiRenXuanZe_Click);
            // 
            // btnQianDao
            // 
            this.btnQianDao.Location = new System.Drawing.Point(138, 167);
            this.btnQianDao.Name = "btnQianDao";
            this.btnQianDao.Size = new System.Drawing.Size(108, 31);
            this.btnQianDao.TabIndex = 3;
            this.btnQianDao.Text = "签到";
            this.btnQianDao.UseVisualStyleBackColor = true;
            this.btnQianDao.Click += new System.EventHandler(this.btnQianDao_Click);
            // 
            // btnKaiShiDaTi
            // 
            this.btnKaiShiDaTi.Location = new System.Drawing.Point(345, 167);
            this.btnKaiShiDaTi.Name = "btnKaiShiDaTi";
            this.btnKaiShiDaTi.Size = new System.Drawing.Size(108, 31);
            this.btnKaiShiDaTi.TabIndex = 4;
            this.btnKaiShiDaTi.Text = "开始答题";
            this.btnKaiShiDaTi.UseVisualStyleBackColor = true;
            this.btnKaiShiDaTi.Click += new System.EventHandler(this.btnKaiShiDaTi_Click);
            // 
            // txtJiHuaNeiRong
            // 
            this.comboxList1.SetColumns(this.txtJiHuaNeiRong, new Framework.WinCommon.Components.ComBoxListColumn[0]);
            this.comboxList1.SetDisplayRowCount(this.txtJiHuaNeiRong, 0);
            this.txtJiHuaNeiRong.EmptyTextTip = null;
            this.txtJiHuaNeiRong.EmptyTextTipColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.txtJiHuaNeiRong.EnterIsTab = false;
            this.comboxList1.SetGridViewWidth(this.txtJiHuaNeiRong, 0);
            this.dcm1.SetIsUse(this.txtJiHuaNeiRong, false);
            this.comboxList1.SetIsUse(this.txtJiHuaNeiRong, false);
            this.txtJiHuaNeiRong.Location = new System.Drawing.Point(138, 122);
            this.txtJiHuaNeiRong.Name = "txtJiHuaNeiRong";
            this.comboxList1.SetNextControl(this.txtJiHuaNeiRong, this.txtJiHuaNeiRong);
            this.txtJiHuaNeiRong.ReadOnly = true;
            this.txtJiHuaNeiRong.Size = new System.Drawing.Size(229, 25);
            this.txtJiHuaNeiRong.TabIndex = 2;
            this.dcm1.SetTagColumnName(this.txtJiHuaNeiRong, null);
            this.dcm1.SetTextColumnName(this.txtJiHuaNeiRong, null);
            // 
            // comboxList1
            // 
            this.comboxList1.GridViewDataSource = null;
            this.comboxList1.MaxRowCount = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(50, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 15);
            this.label3.TabIndex = 30;
            this.label3.Text = "计划内容：";
            // 
            // FrmExamination
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(504, 239);
            this.Controls.Add(this.txtJiHuaNeiRong);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnKaiShiDaTi);
            this.Controls.Add(this.btnQianDao);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnKaoShiRenXuanZe);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnKeShiXuanZe);
            this.Controls.Add(this.txtKaoShiRen);
            this.Controls.Add(this.txtKeShi);
            this.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Name = "FrmExamination";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "在线考试程序";
            this.Load += new System.EventHandler(this.FrmExamination_Load);
            this.Controls.SetChildIndex(this.txtKeShi, 0);
            this.Controls.SetChildIndex(this.txtKaoShiRen, 0);
            this.Controls.SetChildIndex(this.btnKeShiXuanZe, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.btnKaoShiRenXuanZe, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.btnQianDao, 0);
            this.Controls.SetChildIndex(this.btnKaiShiDaTi, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.txtJiHuaNeiRong, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Framework.WinCommon.Controls.ZCTextBox txtKeShi;
        private System.Windows.Forms.Button btnKeShiXuanZe;
        private System.Windows.Forms.Label label2;
        private Framework.WinCommon.Controls.ZCTextBox txtKaoShiRen;
        private System.Windows.Forms.Button btnKaoShiRenXuanZe;
        private System.Windows.Forms.Button btnQianDao;
        private System.Windows.Forms.Button btnKaiShiDaTi;
        private Framework.WinCommon.Components.DCM dcm1;
        private Framework.WinCommon.Components.ComboxList comboxList1;
        private System.Windows.Forms.Label label3;
        private Framework.WinCommon.Controls.ZCTextBox txtJiHuaNeiRong;
    }
}