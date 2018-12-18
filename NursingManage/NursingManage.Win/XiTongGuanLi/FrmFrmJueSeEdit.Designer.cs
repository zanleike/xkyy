namespace NursingManage.Win.XiTongGuanLi
{
    partial class FrmFrmJueSeEdit
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
            this.txtRoleName = new Framework.WinCommon.Controls.ZCTextBox();
            this.dcm1 = new Framework.WinCommon.Components.DCM(this.components);
            this.txtRoleNamePY = new Framework.WinCommon.Controls.ZCTextBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "角色名称：";
            // 
            // txtRoleName
            // 
            this.txtRoleName.EmptyTextTip = null;
            this.txtRoleName.EmptyTextTipColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.txtRoleName.EnterIsTab = false;
            this.dcm1.SetIsUse(this.txtRoleName, true);
            this.txtRoleName.Location = new System.Drawing.Point(86, 32);
            this.txtRoleName.Name = "txtRoleName";
            this.txtRoleName.Size = new System.Drawing.Size(200, 21);
            this.txtRoleName.TabIndex = 0;
            this.dcm1.SetTagColumnName(this.txtRoleName, null);
            this.dcm1.SetTextColumnName(this.txtRoleName, "ROLE_NAME");
            this.txtRoleName.Leave += new System.EventHandler(this.txtRoleName_Leave);
            // 
            // txtRoleNamePY
            // 
            this.txtRoleNamePY.EmptyTextTip = null;
            this.txtRoleNamePY.EmptyTextTipColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.txtRoleNamePY.EnterIsTab = false;
            this.dcm1.SetIsUse(this.txtRoleNamePY, true);
            this.txtRoleNamePY.Location = new System.Drawing.Point(87, 64);
            this.txtRoleNamePY.Name = "txtRoleNamePY";
            this.txtRoleNamePY.Size = new System.Drawing.Size(200, 21);
            this.txtRoleNamePY.TabIndex = 1;
            this.dcm1.SetTagColumnName(this.txtRoleNamePY, null);
            this.dcm1.SetTextColumnName(this.txtRoleNamePY, "ROLE_NAME_PY");
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(87, 99);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 26);
            this.btnOK.TabIndex = 2;
            this.btnOK.Text = "确定";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(211, 99);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 26);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "助记码：";
            // 
            // FrmFrmJueSeEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(341, 159);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.txtRoleNamePY);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtRoleName);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Name = "FrmFrmJueSeEdit";
            this.Text = "角色";
            this.Load += new System.EventHandler(this.FrmFrmJueSeEdit_Load);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.txtRoleName, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.txtRoleNamePY, 0);
            this.Controls.SetChildIndex(this.btnOK, 0);
            this.Controls.SetChildIndex(this.btnCancel, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Framework.WinCommon.Controls.ZCTextBox txtRoleName;
        private Framework.WinCommon.Components.DCM dcm1;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label2;
        private Framework.WinCommon.Controls.ZCTextBox txtRoleNamePY;
    }
}