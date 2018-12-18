namespace NursingManage.Win.ZhiLiangKongZhi
{
    partial class FrmZhiKongJianCha_KeShi_QueRen
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvJieGuo = new Framework.WinCommon.Controls.ZCDataGridView();
            this.col_BIAOZHUNLEIBIE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_LEIXING1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_LEIXING2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_BIAOZHUN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_WENTISHUOMING = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpJIANCHARIQI = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.txtZHIKONGRENYUAN = new Framework.WinCommon.Controls.ZCTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCANJIARENYUAN = new Framework.WinCommon.Controls.ZCTextBox();
            this.txtYUANYINFENXI = new Framework.WinCommon.Controls.ZCTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtGAIJINCUOSHI = new Framework.WinCommon.Controls.ZCTextBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.dcm1 = new Framework.WinCommon.Components.DCM(this.components);
            this.btnOnlySave = new System.Windows.Forms.Button();
            this.ce = new Framework.WinCommon.Components.ControlExtend(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvJieGuo)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvJieGuo
            // 
            this.dgvJieGuo.AllowUserToAddRows = false;
            this.dgvJieGuo.AllowUserToDeleteRows = false;
            this.dgvJieGuo.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            this.dgvJieGuo.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvJieGuo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvJieGuo.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvJieGuo.BackgroundColor = System.Drawing.Color.Snow;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvJieGuo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvJieGuo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvJieGuo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_BIAOZHUNLEIBIE,
            this.col_LEIXING1,
            this.col_LEIXING2,
            this.col_BIAOZHUN,
            this.col_WENTISHUOMING});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvJieGuo.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvJieGuo.DisplayRowCount = true;
            this.dgvJieGuo.Location = new System.Drawing.Point(109, 111);
            this.dgvJieGuo.MultiSelect = false;
            this.dgvJieGuo.Name = "dgvJieGuo";
            this.dgvJieGuo.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvJieGuo.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvJieGuo.RowsDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvJieGuo.RowTemplate.Height = 23;
            this.dgvJieGuo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvJieGuo.Size = new System.Drawing.Size(676, 164);
            this.dgvJieGuo.TabIndex = 3;
            this.dgvJieGuo.UseControlStyle = true;
            // 
            // col_BIAOZHUNLEIBIE
            // 
            this.col_BIAOZHUNLEIBIE.DataPropertyName = "BIAOZHUNLEIBIE";
            this.col_BIAOZHUNLEIBIE.HeaderText = "标准类型";
            this.col_BIAOZHUNLEIBIE.Name = "col_BIAOZHUNLEIBIE";
            this.col_BIAOZHUNLEIBIE.ReadOnly = true;
            this.col_BIAOZHUNLEIBIE.Width = 92;
            // 
            // col_LEIXING1
            // 
            this.col_LEIXING1.DataPropertyName = "LEIXING1";
            this.col_LEIXING1.HeaderText = "一级类型";
            this.col_LEIXING1.Name = "col_LEIXING1";
            this.col_LEIXING1.ReadOnly = true;
            this.col_LEIXING1.Visible = false;
            this.col_LEIXING1.Width = 92;
            // 
            // col_LEIXING2
            // 
            this.col_LEIXING2.DataPropertyName = "LEIXING2";
            this.col_LEIXING2.HeaderText = "二级类型";
            this.col_LEIXING2.Name = "col_LEIXING2";
            this.col_LEIXING2.ReadOnly = true;
            this.col_LEIXING2.Visible = false;
            this.col_LEIXING2.Width = 92;
            // 
            // col_BIAOZHUN
            // 
            this.col_BIAOZHUN.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.col_BIAOZHUN.DataPropertyName = "BIAOZHUN";
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.col_BIAOZHUN.DefaultCellStyle = dataGridViewCellStyle3;
            this.col_BIAOZHUN.HeaderText = "检查问题项";
            this.col_BIAOZHUN.Name = "col_BIAOZHUN";
            this.col_BIAOZHUN.ReadOnly = true;
            this.col_BIAOZHUN.Width = 200;
            // 
            // col_WENTISHUOMING
            // 
            this.col_WENTISHUOMING.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.col_WENTISHUOMING.DataPropertyName = "WENTISHUOMING";
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.col_WENTISHUOMING.DefaultCellStyle = dataGridViewCellStyle4;
            this.col_WENTISHUOMING.HeaderText = "问题项说明";
            this.col_WENTISHUOMING.Name = "col_WENTISHUOMING";
            this.col_WENTISHUOMING.ReadOnly = true;
            this.col_WENTISHUOMING.Width = 300;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 15);
            this.label1.TabIndex = 43;
            this.label1.Text = "检查日期：";
            // 
            // dtpJIANCHARIQI
            // 
            this.ce.SetEnterIsTab(this.dtpJIANCHARIQI, true);
            this.dcm1.SetIsUse(this.dtpJIANCHARIQI, true);
            this.dtpJIANCHARIQI.Location = new System.Drawing.Point(109, 18);
            this.dtpJIANCHARIQI.Name = "dtpJIANCHARIQI";
            this.dtpJIANCHARIQI.Size = new System.Drawing.Size(200, 25);
            this.dtpJIANCHARIQI.TabIndex = 0;
            this.dcm1.SetTagColumnName(this.dtpJIANCHARIQI, null);
            this.dcm1.SetTextColumnName(this.dtpJIANCHARIQI, "JIANCHARIQI");
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 285);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 15);
            this.label2.TabIndex = 43;
            this.label2.Text = "原因分析：";
            // 
            // txtZHIKONGRENYUAN
            // 
            this.txtZHIKONGRENYUAN.EmptyTextTip = null;
            this.txtZHIKONGRENYUAN.EmptyTextTipColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.txtZHIKONGRENYUAN.EnterIsTab = false;
            this.ce.SetEnterIsTab(this.txtZHIKONGRENYUAN, true);
            this.dcm1.SetIsUse(this.txtZHIKONGRENYUAN, true);
            this.txtZHIKONGRENYUAN.Location = new System.Drawing.Point(109, 49);
            this.txtZHIKONGRENYUAN.Name = "txtZHIKONGRENYUAN";
            this.txtZHIKONGRENYUAN.Size = new System.Drawing.Size(676, 25);
            this.txtZHIKONGRENYUAN.TabIndex = 1;
            this.dcm1.SetTagColumnName(this.txtZHIKONGRENYUAN, null);
            this.dcm1.SetTextColumnName(this.txtZHIKONGRENYUAN, "ZHIKONGRENYUAN");
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 15);
            this.label4.TabIndex = 43;
            this.label4.Text = "参加人员：";
            // 
            // txtCANJIARENYUAN
            // 
            this.txtCANJIARENYUAN.EmptyTextTip = null;
            this.txtCANJIARENYUAN.EmptyTextTipColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.txtCANJIARENYUAN.EnterIsTab = false;
            this.ce.SetEnterIsTab(this.txtCANJIARENYUAN, true);
            this.dcm1.SetIsUse(this.txtCANJIARENYUAN, true);
            this.txtCANJIARENYUAN.Location = new System.Drawing.Point(109, 80);
            this.txtCANJIARENYUAN.Name = "txtCANJIARENYUAN";
            this.txtCANJIARENYUAN.Size = new System.Drawing.Size(676, 25);
            this.txtCANJIARENYUAN.TabIndex = 2;
            this.dcm1.SetTagColumnName(this.txtCANJIARENYUAN, null);
            this.dcm1.SetTextColumnName(this.txtCANJIARENYUAN, "CANJIARENYUAN");
            // 
            // txtYUANYINFENXI
            // 
            this.txtYUANYINFENXI.EmptyTextTip = null;
            this.txtYUANYINFENXI.EmptyTextTipColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.txtYUANYINFENXI.EnterIsTab = false;
            this.ce.SetEnterIsTab(this.txtYUANYINFENXI, false);
            this.dcm1.SetIsUse(this.txtYUANYINFENXI, true);
            this.txtYUANYINFENXI.Location = new System.Drawing.Point(109, 281);
            this.txtYUANYINFENXI.Multiline = true;
            this.txtYUANYINFENXI.Name = "txtYUANYINFENXI";
            this.txtYUANYINFENXI.Size = new System.Drawing.Size(676, 116);
            this.txtYUANYINFENXI.TabIndex = 4;
            this.dcm1.SetTagColumnName(this.txtYUANYINFENXI, null);
            this.dcm1.SetTextColumnName(this.txtYUANYINFENXI, "YUANYINFENXI");
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 15);
            this.label3.TabIndex = 46;
            this.label3.Text = "检查结果：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 54);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 15);
            this.label5.TabIndex = 43;
            this.label5.Text = "质控人员：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(25, 407);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 15);
            this.label6.TabIndex = 43;
            this.label6.Text = "改进措施：";
            // 
            // txtGAIJINCUOSHI
            // 
            this.txtGAIJINCUOSHI.EmptyTextTip = null;
            this.txtGAIJINCUOSHI.EmptyTextTipColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.txtGAIJINCUOSHI.EnterIsTab = false;
            this.ce.SetEnterIsTab(this.txtGAIJINCUOSHI, false);
            this.dcm1.SetIsUse(this.txtGAIJINCUOSHI, true);
            this.txtGAIJINCUOSHI.Location = new System.Drawing.Point(109, 403);
            this.txtGAIJINCUOSHI.Multiline = true;
            this.txtGAIJINCUOSHI.Name = "txtGAIJINCUOSHI";
            this.txtGAIJINCUOSHI.Size = new System.Drawing.Size(676, 116);
            this.txtGAIJINCUOSHI.TabIndex = 5;
            this.dcm1.SetTagColumnName(this.txtGAIJINCUOSHI, null);
            this.dcm1.SetTextColumnName(this.txtGAIJINCUOSHI, "GAIJINCUOSHI");
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(498, 539);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(86, 28);
            this.btnOK.TabIndex = 6;
            this.btnOK.Text = "确定上报";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(712, 539);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(86, 28);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOnlySave
            // 
            this.btnOnlySave.Location = new System.Drawing.Point(609, 539);
            this.btnOnlySave.Name = "btnOnlySave";
            this.btnOnlySave.Size = new System.Drawing.Size(86, 28);
            this.btnOnlySave.TabIndex = 7;
            this.btnOnlySave.Text = "仅保存";
            this.btnOnlySave.UseVisualStyleBackColor = true;
            this.btnOnlySave.Click += new System.EventHandler(this.btnOnlySave_Click);
            // 
            // FrmZhiKongJianCha_KeShi_QueRen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(827, 586);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOnlySave);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.dgvJieGuo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtGAIJINCUOSHI);
            this.Controls.Add(this.txtYUANYINFENXI);
            this.Controls.Add(this.txtCANJIARENYUAN);
            this.Controls.Add(this.txtZHIKONGRENYUAN);
            this.Controls.Add(this.dtpJIANCHARIQI);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.KeyPreview = true;
            this.Name = "FrmZhiKongJianCha_KeShi_QueRen";
            this.Text = "科室质控记录上报";
            this.Load += new System.EventHandler(this.FrmZhiKongJianCha_KeShi_QueRen_Load);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label6, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.dtpJIANCHARIQI, 0);
            this.Controls.SetChildIndex(this.txtZHIKONGRENYUAN, 0);
            this.Controls.SetChildIndex(this.txtCANJIARENYUAN, 0);
            this.Controls.SetChildIndex(this.txtYUANYINFENXI, 0);
            this.Controls.SetChildIndex(this.txtGAIJINCUOSHI, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.dgvJieGuo, 0);
            this.Controls.SetChildIndex(this.btnOK, 0);
            this.Controls.SetChildIndex(this.btnOnlySave, 0);
            this.Controls.SetChildIndex(this.btnCancel, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dgvJieGuo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Framework.WinCommon.Controls.ZCDataGridView dgvJieGuo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpJIANCHARIQI;
        private System.Windows.Forms.Label label2;
        private Framework.WinCommon.Controls.ZCTextBox txtZHIKONGRENYUAN;
        private System.Windows.Forms.Label label4;
        private Framework.WinCommon.Controls.ZCTextBox txtCANJIARENYUAN;
        private Framework.WinCommon.Controls.ZCTextBox txtYUANYINFENXI;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private Framework.WinCommon.Controls.ZCTextBox txtGAIJINCUOSHI;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private Framework.WinCommon.Components.DCM dcm1;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_BIAOZHUNLEIBIE;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_LEIXING1;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_LEIXING2;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_BIAOZHUN;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_WENTISHUOMING;
        private System.Windows.Forms.Button btnOnlySave;
        private Framework.WinCommon.Components.ControlExtend ce;
    }
}