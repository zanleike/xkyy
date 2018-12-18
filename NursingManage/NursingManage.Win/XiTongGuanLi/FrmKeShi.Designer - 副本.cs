namespace ZCJH.NursingManage.Win.XiTongGuanLi
{
    partial class FrmKeShi
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripTop1 = new System.Windows.Forms.ToolStrip();
            this.tsBtnAdd = new System.Windows.Forms.ToolStripButton();
            this.tsBtnEdit = new System.Windows.Forms.ToolStripButton();
            this.tsBtnDelete = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.tsTxtSearchValue = new System.Windows.Forms.ToolStripTextBox();
            this.tsBtnSearch = new System.Windows.Forms.ToolStripButton();
            this.tsBtnClose = new System.Windows.Forms.ToolStripButton();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvKeShi = new ZhCun.Framework.WinCommon.Controls.ZCDataGridView();
            this.col_BianMa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_MingCheng = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_MingCheng_PY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_KeShiID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvYongHu = new ZhCun.Framework.WinCommon.Controls.ZCDataGridView();
            this.col_User_No = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_User_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_User_Name_PY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_User_Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsBtnSelectUserInfo = new System.Windows.Forms.ToolStripButton();
            this.tsBtnRemoveUser = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsTxtUserSearch = new System.Windows.Forms.ToolStripTextBox();
            this.tsbtnUserSearch = new System.Windows.Forms.ToolStripButton();
            this.toolStripTop1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKeShi)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvYongHu)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 381);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(869, 22);
            this.statusStrip1.TabIndex = 26;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripTop1
            // 
            this.toolStripTop1.AutoSize = false;
            this.toolStripTop1.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.toolStripTop1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsBtnAdd,
            this.tsBtnEdit,
            this.tsBtnDelete,
            this.toolStripSeparator5,
            this.tsTxtSearchValue,
            this.tsBtnSearch,
            this.tsBtnClose});
            this.toolStripTop1.Location = new System.Drawing.Point(0, 0);
            this.toolStripTop1.Name = "toolStripTop1";
            this.toolStripTop1.Size = new System.Drawing.Size(869, 38);
            this.toolStripTop1.TabIndex = 31;
            this.toolStripTop1.Text = "toolStrip2";
            // 
            // tsBtnAdd
            // 
            this.tsBtnAdd.BackColor = System.Drawing.Color.Transparent;
            this.tsBtnAdd.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tsBtnAdd.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.tsBtnAdd.Image = global::ZCJH.NursingManage.Win.Properties.Resources.add;
            this.tsBtnAdd.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsBtnAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnAdd.Name = "tsBtnAdd";
            this.tsBtnAdd.Size = new System.Drawing.Size(73, 35);
            this.tsBtnAdd.Text = "增加";
            this.tsBtnAdd.Click += new System.EventHandler(this.tsBtnAdd_Click);
            // 
            // tsBtnEdit
            // 
            this.tsBtnEdit.BackColor = System.Drawing.Color.Transparent;
            this.tsBtnEdit.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tsBtnEdit.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.tsBtnEdit.Image = global::ZCJH.NursingManage.Win.Properties.Resources.edit;
            this.tsBtnEdit.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsBtnEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnEdit.Name = "tsBtnEdit";
            this.tsBtnEdit.Size = new System.Drawing.Size(73, 35);
            this.tsBtnEdit.Text = "编辑";
            this.tsBtnEdit.Click += new System.EventHandler(this.tsBtnEdit_Click);
            // 
            // tsBtnDelete
            // 
            this.tsBtnDelete.BackColor = System.Drawing.Color.Transparent;
            this.tsBtnDelete.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tsBtnDelete.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.tsBtnDelete.Image = global::ZCJH.NursingManage.Win.Properties.Resources.delete;
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
            this.tsBtnSearch.Image = global::ZCJH.NursingManage.Win.Properties.Resources.search;
            this.tsBtnSearch.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsBtnSearch.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnSearch.Name = "tsBtnSearch";
            this.tsBtnSearch.Size = new System.Drawing.Size(73, 35);
            this.tsBtnSearch.Text = "搜索";
            this.tsBtnSearch.Click += new System.EventHandler(this.tsBtnSearch_Click);
            // 
            // tsBtnClose
            // 
            this.tsBtnClose.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsBtnClose.BackColor = System.Drawing.Color.Transparent;
            this.tsBtnClose.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tsBtnClose.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.tsBtnClose.Image = global::ZCJH.NursingManage.Win.Properties.Resources.exit;
            this.tsBtnClose.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsBtnClose.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnClose.Margin = new System.Windows.Forms.Padding(0, 1, 1, 2);
            this.tsBtnClose.Name = "tsBtnClose";
            this.tsBtnClose.Size = new System.Drawing.Size(73, 35);
            this.tsBtnClose.Text = "退出";
            this.tsBtnClose.Click += new System.EventHandler(this.tsBtnClose_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.Location = new System.Drawing.Point(0, 38);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.groupBox1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.groupBox2);
            this.splitContainer1.Size = new System.Drawing.Size(869, 343);
            this.splitContainer1.SplitterDistance = 280;
            this.splitContainer1.TabIndex = 32;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvKeShi);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(280, 343);
            this.groupBox1.TabIndex = 28;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "科室列表";
            // 
            // dgvKeShi
            // 
            this.dgvKeShi.AllowUserToAddRows = false;
            this.dgvKeShi.AllowUserToDeleteRows = false;
            this.dgvKeShi.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            this.dgvKeShi.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvKeShi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvKeShi.BackgroundColor = System.Drawing.Color.Snow;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvKeShi.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvKeShi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKeShi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_BianMa,
            this.col_MingCheng,
            this.col_MingCheng_PY,
            this.col_KeShiID});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvKeShi.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvKeShi.DisplayRowCount = true;
            this.dgvKeShi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvKeShi.Location = new System.Drawing.Point(3, 17);
            this.dgvKeShi.MultiSelect = false;
            this.dgvKeShi.Name = "dgvKeShi";
            this.dgvKeShi.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvKeShi.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvKeShi.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvKeShi.RowTemplate.Height = 23;
            this.dgvKeShi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvKeShi.Size = new System.Drawing.Size(274, 323);
            this.dgvKeShi.TabIndex = 29;
            this.dgvKeShi.UseControlStyle = true;
            this.dgvKeShi.SelectionChangedAndCellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvKeShi_SelectionChangedAndCellClick);
            // 
            // col_BianMa
            // 
            this.col_BianMa.DataPropertyName = "BianMa";
            this.col_BianMa.HeaderText = "科室编码";
            this.col_BianMa.Name = "col_BianMa";
            this.col_BianMa.ReadOnly = true;
            this.col_BianMa.Width = 78;
            // 
            // col_MingCheng
            // 
            this.col_MingCheng.DataPropertyName = "MingCheng";
            this.col_MingCheng.HeaderText = "科室名称";
            this.col_MingCheng.Name = "col_MingCheng";
            this.col_MingCheng.ReadOnly = true;
            this.col_MingCheng.Width = 78;
            // 
            // col_MingCheng_PY
            // 
            this.col_MingCheng_PY.DataPropertyName = "MingCheng_PY";
            this.col_MingCheng_PY.HeaderText = "助记码";
            this.col_MingCheng_PY.Name = "col_MingCheng_PY";
            this.col_MingCheng_PY.ReadOnly = true;
            this.col_MingCheng_PY.Visible = false;
            this.col_MingCheng_PY.Width = 66;
            // 
            // col_KeShiID
            // 
            this.col_KeShiID.DataPropertyName = "ID";
            this.col_KeShiID.HeaderText = "科室ID";
            this.col_KeShiID.Name = "col_KeShiID";
            this.col_KeShiID.ReadOnly = true;
            this.col_KeShiID.Visible = false;
            this.col_KeShiID.Width = 66;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvYongHu);
            this.groupBox2.Controls.Add(this.toolStrip1);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(585, 343);
            this.groupBox2.TabIndex = 28;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "所选科室人员列表";
            // 
            // dgvYongHu
            // 
            this.dgvYongHu.AllowUserToAddRows = false;
            this.dgvYongHu.AllowUserToDeleteRows = false;
            this.dgvYongHu.AllowUserToResizeRows = false;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            this.dgvYongHu.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvYongHu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvYongHu.BackgroundColor = System.Drawing.Color.Snow;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvYongHu.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvYongHu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvYongHu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_User_No,
            this.col_User_Name,
            this.col_User_Name_PY,
            this.col_User_Type});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvYongHu.DefaultCellStyle = dataGridViewCellStyle8;
            this.dgvYongHu.DisplayRowCount = true;
            this.dgvYongHu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvYongHu.Location = new System.Drawing.Point(3, 55);
            this.dgvYongHu.MultiSelect = false;
            this.dgvYongHu.Name = "dgvYongHu";
            this.dgvYongHu.ReadOnly = true;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvYongHu.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvYongHu.RowsDefaultCellStyle = dataGridViewCellStyle10;
            this.dgvYongHu.RowTemplate.Height = 23;
            this.dgvYongHu.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvYongHu.Size = new System.Drawing.Size(579, 285);
            this.dgvYongHu.TabIndex = 29;
            this.dgvYongHu.UseControlStyle = true;
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
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsBtnSelectUserInfo,
            this.tsBtnRemoveUser,
            this.toolStripSeparator2,
            this.tsTxtUserSearch,
            this.tsbtnUserSearch});
            this.toolStrip1.Location = new System.Drawing.Point(3, 17);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(579, 38);
            this.toolStrip1.TabIndex = 28;
            this.toolStrip1.Text = "toolStrip2";
            // 
            // tsBtnSelectUserInfo
            // 
            this.tsBtnSelectUserInfo.BackColor = System.Drawing.Color.Transparent;
            this.tsBtnSelectUserInfo.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tsBtnSelectUserInfo.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.tsBtnSelectUserInfo.Image = global::ZCJH.NursingManage.Win.Properties.Resources.shouru;
            this.tsBtnSelectUserInfo.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsBtnSelectUserInfo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnSelectUserInfo.Name = "tsBtnSelectUserInfo";
            this.tsBtnSelectUserInfo.Size = new System.Drawing.Size(101, 35);
            this.tsBtnSelectUserInfo.Text = "添加用户";
            this.tsBtnSelectUserInfo.Click += new System.EventHandler(this.tsBtnSelectUserInfo_Click);
            // 
            // tsBtnRemoveUser
            // 
            this.tsBtnRemoveUser.BackColor = System.Drawing.Color.Transparent;
            this.tsBtnRemoveUser.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tsBtnRemoveUser.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.tsBtnRemoveUser.Image = global::ZCJH.NursingManage.Win.Properties.Resources.cancel;
            this.tsBtnRemoveUser.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsBtnRemoveUser.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnRemoveUser.Name = "tsBtnRemoveUser";
            this.tsBtnRemoveUser.Size = new System.Drawing.Size(101, 35);
            this.tsBtnRemoveUser.Text = "移除用户";
            this.tsBtnRemoveUser.Click += new System.EventHandler(this.tsBtnRemoveUser_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 38);
            // 
            // tsTxtUserSearch
            // 
            this.tsTxtUserSearch.Name = "tsTxtUserSearch";
            this.tsTxtUserSearch.Size = new System.Drawing.Size(100, 38);
            this.tsTxtUserSearch.ToolTipText = "可输入回车进行搜索";
            this.tsTxtUserSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tsTxtUserSearch_KeyDown);
            // 
            // tsbtnUserSearch
            // 
            this.tsbtnUserSearch.BackColor = System.Drawing.Color.Transparent;
            this.tsbtnUserSearch.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tsbtnUserSearch.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.tsbtnUserSearch.Image = global::ZCJH.NursingManage.Win.Properties.Resources.search;
            this.tsbtnUserSearch.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbtnUserSearch.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnUserSearch.Name = "tsbtnUserSearch";
            this.tsbtnUserSearch.Size = new System.Drawing.Size(73, 35);
            this.tsbtnUserSearch.Text = "搜索";
            this.tsbtnUserSearch.Click += new System.EventHandler(this.tsbtnUserSearch_Click);
            // 
            // FrmKeShi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(869, 403);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.toolStripTop1);
            this.Controls.Add(this.statusStrip1);
            this.Name = "FrmKeShi";
            this.Text = "科室管理";
            this.Load += new System.EventHandler(this.FrmKeShi_Load);
            this.Controls.SetChildIndex(this.statusStrip1, 0);
            this.Controls.SetChildIndex(this.toolStripTop1, 0);
            this.Controls.SetChildIndex(this.splitContainer1, 0);
            this.toolStripTop1.ResumeLayout(false);
            this.toolStripTop1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKeShi)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvYongHu)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        public System.Windows.Forms.ToolStrip toolStripTop1;
        public System.Windows.Forms.ToolStripButton tsBtnAdd;
        public System.Windows.Forms.ToolStripButton tsBtnEdit;
        public System.Windows.Forms.ToolStripButton tsBtnDelete;
        public System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripTextBox tsTxtSearchValue;
        public System.Windows.Forms.ToolStripButton tsBtnSearch;
        public System.Windows.Forms.ToolStripButton tsBtnClose;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox groupBox1;
        private ZhCun.Framework.WinCommon.Controls.ZCDataGridView dgvKeShi;
        private System.Windows.Forms.GroupBox groupBox2;
        public System.Windows.Forms.ToolStrip toolStrip1;
        public System.Windows.Forms.ToolStripButton tsBtnSelectUserInfo;
        public System.Windows.Forms.ToolStripButton tsBtnRemoveUser;
        public System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripTextBox tsTxtUserSearch;
        public System.Windows.Forms.ToolStripButton tsbtnUserSearch;
        private ZhCun.Framework.WinCommon.Controls.ZCDataGridView dgvYongHu;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_User_No;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_User_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_User_Name_PY;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_User_Type;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_BianMa;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_MingCheng;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_MingCheng_PY;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_KeShiID;
    }
}