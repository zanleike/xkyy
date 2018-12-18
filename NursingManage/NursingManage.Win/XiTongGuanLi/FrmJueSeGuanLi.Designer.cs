namespace NursingManage.Win.XiTongGuanLi
{
    partial class FrmJueSeGuanLi
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("系统管理");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("员工档案管理");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("档案管理", new System.Windows.Forms.TreeNode[] {
            treeNode2});
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("考勤管理");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("题库管理");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("培训计划");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("培训管理", new System.Windows.Forms.TreeNode[] {
            treeNode5,
            treeNode6});
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("质量管理");
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripTop1 = new System.Windows.Forms.ToolStrip();
            this.tsBtnAdd = new System.Windows.Forms.ToolStripButton();
            this.tsBtnEditor = new System.Windows.Forms.ToolStripButton();
            this.tsBtnDelete = new System.Windows.Forms.ToolStripButton();
            this.tsBtnSaveRoleMenu = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.tsBtnClose = new System.Windows.Forms.ToolStripButton();
            this.tsTxtSearchValue = new System.Windows.Forms.ToolStripTextBox();
            this.tsBtnSearch = new System.Windows.Forms.ToolStripButton();
            this.dgvRole = new Framework.WinCommon.Controls.ZCDataGridView();
            this.col_RoleName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tvMenu = new System.Windows.Forms.TreeView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgvYongHu = new Framework.WinCommon.Controls.ZCDataGridView();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsBtnAddRoleUser = new System.Windows.Forms.ToolStripButton();
            this.tsBtnRemoveUser = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsTxtUserSearch = new System.Windows.Forms.ToolStripTextBox();
            this.tsbtnUserSearch = new System.Windows.Forms.ToolStripButton();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_KeShi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStripTop1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRole)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvYongHu)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 371);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(851, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripTop1
            // 
            this.toolStripTop1.AutoSize = false;
            this.toolStripTop1.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.toolStripTop1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsBtnAdd,
            this.tsBtnEditor,
            this.tsBtnDelete,
            this.tsBtnSaveRoleMenu,
            this.toolStripSeparator5,
            this.tsBtnClose,
            this.tsTxtSearchValue,
            this.tsBtnSearch});
            this.toolStripTop1.Location = new System.Drawing.Point(0, 0);
            this.toolStripTop1.Name = "toolStripTop1";
            this.toolStripTop1.Size = new System.Drawing.Size(851, 38);
            this.toolStripTop1.TabIndex = 25;
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
            // tsBtnSaveRoleMenu
            // 
            this.tsBtnSaveRoleMenu.BackColor = System.Drawing.Color.Transparent;
            this.tsBtnSaveRoleMenu.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tsBtnSaveRoleMenu.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.tsBtnSaveRoleMenu.Image = global::NursingManage.Win.Properties.Resources.save;
            this.tsBtnSaveRoleMenu.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsBtnSaveRoleMenu.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnSaveRoleMenu.Name = "tsBtnSaveRoleMenu";
            this.tsBtnSaveRoleMenu.Size = new System.Drawing.Size(129, 35);
            this.tsBtnSaveRoleMenu.Text = "保存菜单权限";
            this.tsBtnSaveRoleMenu.Click += new System.EventHandler(this.tsBtnSaveRoleMenu_Click);
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
            // dgvRole
            // 
            this.dgvRole.AllowUserToAddRows = false;
            this.dgvRole.AllowUserToDeleteRows = false;
            this.dgvRole.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            this.dgvRole.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvRole.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRole.BackgroundColor = System.Drawing.Color.Snow;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvRole.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvRole.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRole.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_RoleName});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvRole.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvRole.DisplayRowCount = true;
            this.dgvRole.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvRole.Location = new System.Drawing.Point(3, 17);
            this.dgvRole.MultiSelect = false;
            this.dgvRole.Name = "dgvRole";
            this.dgvRole.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvRole.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvRole.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvRole.RowTemplate.Height = 23;
            this.dgvRole.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRole.Size = new System.Drawing.Size(213, 313);
            this.dgvRole.TabIndex = 26;
            this.dgvRole.UseControlStyle = true;
            this.dgvRole.SelectionChangedAndCellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRole_SelectionChangedAndCellClick);
            // 
            // col_RoleName
            // 
            this.col_RoleName.DataPropertyName = "ROLE_NAME";
            this.col_RoleName.HeaderText = "角色名称";
            this.col_RoleName.Name = "col_RoleName";
            this.col_RoleName.ReadOnly = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvRole);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox1.Location = new System.Drawing.Point(0, 38);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(219, 333);
            this.groupBox1.TabIndex = 27;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "角色列表";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tvMenu);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox2.Location = new System.Drawing.Point(219, 38);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 333);
            this.groupBox2.TabIndex = 28;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "菜单";
            // 
            // tvMenu
            // 
            this.tvMenu.CheckBoxes = true;
            this.tvMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tvMenu.Location = new System.Drawing.Point(3, 17);
            this.tvMenu.Name = "tvMenu";
            treeNode1.Name = "节点0";
            treeNode1.Text = "系统管理";
            treeNode2.Name = "节点5";
            treeNode2.Text = "员工档案管理";
            treeNode3.Name = "节点3";
            treeNode3.Text = "档案管理";
            treeNode4.Name = "节点2";
            treeNode4.Text = "考勤管理";
            treeNode5.Name = "节点6";
            treeNode5.Text = "题库管理";
            treeNode6.Name = "节点7";
            treeNode6.Text = "培训计划";
            treeNode7.Name = "节点1";
            treeNode7.Text = "培训管理";
            treeNode8.Name = "节点4";
            treeNode8.Text = "质量管理";
            this.tvMenu.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode3,
            treeNode4,
            treeNode7,
            treeNode8});
            this.tvMenu.Size = new System.Drawing.Size(194, 313);
            this.tvMenu.TabIndex = 0;
            this.tvMenu.AfterCheck += new System.Windows.Forms.TreeViewEventHandler(this.tvMenu_AfterCheck);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dgvYongHu);
            this.groupBox3.Controls.Add(this.toolStrip1);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point(419, 38);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(432, 333);
            this.groupBox3.TabIndex = 29;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "选中角色用户列表";
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
            this.Column1,
            this.Column2,
            this.Column3,
            this.col_KeShi});
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
            this.dgvYongHu.Size = new System.Drawing.Size(426, 275);
            this.dgvYongHu.TabIndex = 30;
            this.dgvYongHu.UseControlStyle = true;
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsBtnAddRoleUser,
            this.tsBtnRemoveUser,
            this.toolStripSeparator2,
            this.tsTxtUserSearch,
            this.tsbtnUserSearch});
            this.toolStrip1.Location = new System.Drawing.Point(3, 17);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(426, 38);
            this.toolStrip1.TabIndex = 29;
            this.toolStrip1.Text = "toolStrip2";
            // 
            // tsBtnAddRoleUser
            // 
            this.tsBtnAddRoleUser.BackColor = System.Drawing.Color.Transparent;
            this.tsBtnAddRoleUser.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tsBtnAddRoleUser.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.tsBtnAddRoleUser.Image = global::NursingManage.Win.Properties.Resources.shouru;
            this.tsBtnAddRoleUser.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsBtnAddRoleUser.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnAddRoleUser.Name = "tsBtnAddRoleUser";
            this.tsBtnAddRoleUser.Size = new System.Drawing.Size(101, 35);
            this.tsBtnAddRoleUser.Text = "添加用户";
            this.tsBtnAddRoleUser.Click += new System.EventHandler(this.tsBtnAddRoleUser_Click);
            // 
            // tsBtnRemoveUser
            // 
            this.tsBtnRemoveUser.BackColor = System.Drawing.Color.Transparent;
            this.tsBtnRemoveUser.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tsBtnRemoveUser.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.tsBtnRemoveUser.Image = global::NursingManage.Win.Properties.Resources.cancel;
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
            this.tsbtnUserSearch.Image = global::NursingManage.Win.Properties.Resources.search;
            this.tsbtnUserSearch.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbtnUserSearch.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnUserSearch.Name = "tsbtnUserSearch";
            this.tsbtnUserSearch.Size = new System.Drawing.Size(73, 35);
            this.tsbtnUserSearch.Text = "搜索";
            this.tsbtnUserSearch.Click += new System.EventHandler(this.tsbtnUserSearch_Click);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "USER_NO";
            this.Column1.HeaderText = "工号";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 54;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "USER_NAME";
            this.Column2.HeaderText = "姓名";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 54;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "USER_TYPE";
            this.Column3.HeaderText = "类型";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 54;
            // 
            // col_KeShi
            // 
            this.col_KeShi.DataPropertyName = "KESHIMINGCHENG";
            this.col_KeShi.HeaderText = "科室";
            this.col_KeShi.Name = "col_KeShi";
            this.col_KeShi.ReadOnly = true;
            this.col_KeShi.Width = 54;
            // 
            // FrmJueSeGuanLi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(851, 393);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.toolStripTop1);
            this.Controls.Add(this.statusStrip1);
            this.Name = "FrmJueSeGuanLi";
            this.Text = "角色管理";
            this.Load += new System.EventHandler(this.FrmJueSeGuanLi_Load);
            this.Controls.SetChildIndex(this.statusStrip1, 0);
            this.Controls.SetChildIndex(this.toolStripTop1, 0);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.groupBox2, 0);
            this.Controls.SetChildIndex(this.groupBox3, 0);
            this.toolStripTop1.ResumeLayout(false);
            this.toolStripTop1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRole)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
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
        public System.Windows.Forms.ToolStripButton tsBtnEditor;
        public System.Windows.Forms.ToolStripButton tsBtnDelete;
        public System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        public System.Windows.Forms.ToolStripButton tsBtnClose;
        private Framework.WinCommon.Controls.ZCDataGridView dgvRole;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TreeView tvMenu;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ToolStripTextBox tsTxtSearchValue;
        public System.Windows.Forms.ToolStripButton tsBtnSearch;
        public System.Windows.Forms.ToolStrip toolStrip1;
        public System.Windows.Forms.ToolStripButton tsBtnAddRoleUser;
        public System.Windows.Forms.ToolStripButton tsBtnRemoveUser;
        public System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripTextBox tsTxtUserSearch;
        public System.Windows.Forms.ToolStripButton tsbtnUserSearch;
        private Framework.WinCommon.Controls.ZCDataGridView dgvYongHu;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_RoleName;
        public System.Windows.Forms.ToolStripButton tsBtnSaveRoleMenu;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_KeShi;
    }
}