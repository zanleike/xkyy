namespace NursingManage.Win.XiTongGuanLi
{
    partial class FrmYongHuGuanLi
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.toolStripTop1 = new System.Windows.Forms.ToolStrip();
            this.tsBtnAdd = new System.Windows.Forms.ToolStripButton();
            this.tsBtnEditor = new System.Windows.Forms.ToolStripButton();
            this.tsBtnDelete = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.tsBtnClose = new System.Windows.Forms.ToolStripButton();
            this.tsTxtSearchValue = new System.Windows.Forms.ToolStripTextBox();
            this.tsBtnSearch = new System.Windows.Forms.ToolStripButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.dgv = new Framework.WinCommon.Controls.ZCDataGridView();
            this.col_KeShiMingCheng = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_User_No = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_User_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_User_Name_PY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_User_Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Role_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_AddTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStripTop1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStripTop1
            // 
            this.toolStripTop1.AutoSize = false;
            this.toolStripTop1.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.toolStripTop1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsBtnAdd,
            this.tsBtnEditor,
            this.tsBtnDelete,
            this.toolStripSeparator5,
            this.tsBtnClose,
            this.tsTxtSearchValue,
            this.tsBtnSearch});
            this.toolStripTop1.Location = new System.Drawing.Point(0, 0);
            this.toolStripTop1.Name = "toolStripTop1";
            this.toolStripTop1.Size = new System.Drawing.Size(729, 38);
            this.toolStripTop1.TabIndex = 24;
            this.toolStripTop1.Text = "toolStrip2";
            // 
            // tsBtnAdd
            // 
            this.tsBtnAdd.BackColor = System.Drawing.Color.Transparent;
            this.tsBtnAdd.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tsBtnAdd.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.tsBtnAdd.Image = global::NursingManage.Win.Properties.Resources.add;
            this.tsBtnAdd.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsBtnAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnAdd.Name = "tsBtnAdd";
            this.tsBtnAdd.Size = new System.Drawing.Size(73, 35);
            this.tsBtnAdd.Text = "增加";
            this.tsBtnAdd.Click += new System.EventHandler(this.tsBtnAdd_Click);
            // 
            // tsBtnEditor
            // 
            this.tsBtnEditor.BackColor = System.Drawing.Color.Transparent;
            this.tsBtnEditor.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tsBtnEditor.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.tsBtnEditor.Image = global::NursingManage.Win.Properties.Resources.edit;
            this.tsBtnEditor.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsBtnEditor.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnEditor.Name = "tsBtnEditor";
            this.tsBtnEditor.Size = new System.Drawing.Size(73, 35);
            this.tsBtnEditor.Text = "编辑";
            this.tsBtnEditor.Click += new System.EventHandler(this.tsBtnEditor_Click);
            // 
            // tsBtnDelete
            // 
            this.tsBtnDelete.BackColor = System.Drawing.Color.Transparent;
            this.tsBtnDelete.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tsBtnDelete.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.tsBtnDelete.Image = global::NursingManage.Win.Properties.Resources.delete;
            this.tsBtnDelete.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsBtnDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnDelete.Name = "tsBtnDelete";
            this.tsBtnDelete.Size = new System.Drawing.Size(73, 35);
            this.tsBtnDelete.Text = "删除";
            this.tsBtnDelete.Click += new System.EventHandler(this.tsBtnDelete_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 38);
            // 
            // tsBtnClose
            // 
            this.tsBtnClose.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsBtnClose.BackColor = System.Drawing.Color.Transparent;
            this.tsBtnClose.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tsBtnClose.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.tsBtnClose.Image = global::NursingManage.Win.Properties.Resources.exit;
            this.tsBtnClose.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsBtnClose.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnClose.Margin = new System.Windows.Forms.Padding(0, 1, 1, 2);
            this.tsBtnClose.Name = "tsBtnClose";
            this.tsBtnClose.Size = new System.Drawing.Size(73, 35);
            this.tsBtnClose.Text = "退出";
            this.tsBtnClose.Click += new System.EventHandler(this.tsBtnClose_Click);
            // 
            // tsTxtSearchValue
            // 
            this.tsTxtSearchValue.Name = "tsTxtSearchValue";
            this.tsTxtSearchValue.Size = new System.Drawing.Size(100, 38);
            this.tsTxtSearchValue.ToolTipText = "可输入回车进行搜索";
            this.tsTxtSearchValue.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tsTxtSearchValue_KeyDown);
            // 
            // tsBtnSearch
            // 
            this.tsBtnSearch.BackColor = System.Drawing.Color.Transparent;
            this.tsBtnSearch.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tsBtnSearch.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.tsBtnSearch.Image = global::NursingManage.Win.Properties.Resources.search;
            this.tsBtnSearch.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsBtnSearch.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnSearch.Name = "tsBtnSearch";
            this.tsBtnSearch.Size = new System.Drawing.Size(73, 35);
            this.tsBtnSearch.Text = "搜索";
            this.tsBtnSearch.Click += new System.EventHandler(this.tsBtnSearch_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 409);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(729, 22);
            this.statusStrip1.TabIndex = 25;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AllowUserToDeleteRows = false;
            this.dgv.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            this.dgv.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgv.BackgroundColor = System.Drawing.Color.Snow;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_KeShiMingCheng,
            this.col_User_No,
            this.col_User_Name,
            this.col_User_Name_PY,
            this.col_User_Type,
            this.col_Role_Name,
            this.col_AddTime});
            this.dgv.DisplayRowCount = true;
            this.dgv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv.Location = new System.Drawing.Point(0, 38);
            this.dgv.MultiSelect = false;
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgv.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv.RowTemplate.Height = 23;
            this.dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv.Size = new System.Drawing.Size(729, 371);
            this.dgv.TabIndex = 26;
            this.dgv.UseControlStyle = true;
            // 
            // col_KeShiMingCheng
            // 
            this.col_KeShiMingCheng.DataPropertyName = "KeShiMingCheng";
            this.col_KeShiMingCheng.HeaderText = "科室名称";
            this.col_KeShiMingCheng.Name = "col_KeShiMingCheng";
            this.col_KeShiMingCheng.ReadOnly = true;
            this.col_KeShiMingCheng.Width = 78;
            // 
            // col_User_No
            // 
            this.col_User_No.DataPropertyName = "User_No";
            this.col_User_No.HeaderText = "工号";
            this.col_User_No.Name = "col_User_No";
            this.col_User_No.ReadOnly = true;
            this.col_User_No.Width = 54;
            // 
            // col_User_Name
            // 
            this.col_User_Name.DataPropertyName = "User_Name";
            this.col_User_Name.HeaderText = "姓名";
            this.col_User_Name.Name = "col_User_Name";
            this.col_User_Name.ReadOnly = true;
            this.col_User_Name.Width = 54;
            // 
            // col_User_Name_PY
            // 
            this.col_User_Name_PY.DataPropertyName = "User_Name_PY";
            this.col_User_Name_PY.HeaderText = "拼音码";
            this.col_User_Name_PY.Name = "col_User_Name_PY";
            this.col_User_Name_PY.ReadOnly = true;
            this.col_User_Name_PY.Width = 66;
            // 
            // col_User_Type
            // 
            this.col_User_Type.DataPropertyName = "USER_TYPE";
            this.col_User_Type.HeaderText = "用户类型";
            this.col_User_Type.Name = "col_User_Type";
            this.col_User_Type.ReadOnly = true;
            this.col_User_Type.Width = 78;
            // 
            // col_Role_Name
            // 
            this.col_Role_Name.DataPropertyName = "Role_Name";
            this.col_Role_Name.HeaderText = "权限名称";
            this.col_Role_Name.Name = "col_Role_Name";
            this.col_Role_Name.ReadOnly = true;
            this.col_Role_Name.Width = 78;
            // 
            // col_AddTime
            // 
            this.col_AddTime.DataPropertyName = "AddTime";
            this.col_AddTime.HeaderText = "增加时间";
            this.col_AddTime.Name = "col_AddTime";
            this.col_AddTime.ReadOnly = true;
            this.col_AddTime.Width = 78;
            // 
            // FrmYongHuGuanLi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(729, 431);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStripTop1);
            this.Name = "FrmYongHuGuanLi";
            this.Text = "用户管理";
            this.Load += new System.EventHandler(this.FrmYongHuGuanLi_Load);
            this.Controls.SetChildIndex(this.toolStripTop1, 0);
            this.Controls.SetChildIndex(this.statusStrip1, 0);
            this.Controls.SetChildIndex(this.dgv, 0);
            this.toolStripTop1.ResumeLayout(false);
            this.toolStripTop1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.ToolStrip toolStripTop1;
        public System.Windows.Forms.ToolStripButton tsBtnAdd;
        public System.Windows.Forms.ToolStripButton tsBtnEditor;
        public System.Windows.Forms.ToolStripButton tsBtnDelete;
        public System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        public System.Windows.Forms.ToolStripButton tsBtnClose;
        private System.Windows.Forms.ToolStripTextBox tsTxtSearchValue;
        public System.Windows.Forms.ToolStripButton tsBtnSearch;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private Framework.WinCommon.Controls.ZCDataGridView dgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_KeShiMingCheng;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_User_No;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_User_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_User_Name_PY;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_User_Type;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Role_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_AddTime;
    }
}