namespace NursingManage.Win.DangAnGuanLi
{
    partial class FrmDangAnNew
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.ucPage = new Framework.WinCommon.Controls.UCPagingNavigation();
            this.toolStripTop1 = new System.Windows.Forms.ToolStrip();
            this.tsBtnAdd = new System.Windows.Forms.ToolStripButton();
            this.tsBtnEdit = new System.Windows.Forms.ToolStripButton();
            this.tsBtnDelete = new System.Windows.Forms.ToolStripButton();
            this.tsbtnOutExcel = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.tsTxtSearchValue = new System.Windows.Forms.ToolStripTextBox();
            this.tsBtnSearch = new System.Windows.Forms.ToolStripButton();
            this.tsBtnClose = new System.Windows.Forms.ToolStripButton();
            this.tsbtnADSearch = new System.Windows.Forms.ToolStripButton();
            this.dgv = new Framework.WinCommon.Controls.ZCDataGridView();
            this.cMenuExTable = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.col_KeShi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_BIANHAO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_XINGMING = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_XINGMING_PY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_MINZU = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_HUNFOU = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_ZHIWU = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_SHOUJI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_ZHICHENG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_NengJi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_GONGZUOSHIJIAN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_gongzuonianxian = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_LAIYUANSHIJIAN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_laiyuannianxian = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_RUKESHIJIAN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_rukenianxian = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_XUELI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_AddTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_jiguan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_zhuanye = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_jiangkang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStripTop1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 494);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(873, 18);
            this.statusStrip1.TabIndex = 35;
            this.statusStrip1.Text = "statusStrip1";
            this.statusStrip1.Visible = false;
            // 
            // ucPage
            // 
            this.ucPage.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ucPage.Location = new System.Drawing.Point(0, 475);
            this.ucPage.Margin = new System.Windows.Forms.Padding(4);
            this.ucPage.Name = "ucPage";
            this.ucPage.Size = new System.Drawing.Size(873, 36);
            this.ucPage.TabIndex = 37;
            this.ucPage.PageChangedEvent += new Framework.WinCommon.Controls.PadeChangedHandle(this.ucPage_PageChangedEvent);
            // 
            // toolStripTop1
            // 
            this.toolStripTop1.AutoSize = false;
            this.toolStripTop1.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.toolStripTop1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsBtnAdd,
            this.tsBtnEdit,
            this.tsBtnDelete,
            this.tsbtnOutExcel,
            this.toolStripSeparator5,
            this.tsTxtSearchValue,
            this.tsBtnSearch,
            this.tsBtnClose,
            this.tsbtnADSearch});
            this.toolStripTop1.Location = new System.Drawing.Point(0, 0);
            this.toolStripTop1.Name = "toolStripTop1";
            this.toolStripTop1.Size = new System.Drawing.Size(873, 38);
            this.toolStripTop1.TabIndex = 39;
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
            // tsBtnEdit
            // 
            this.tsBtnEdit.BackColor = System.Drawing.Color.Transparent;
            this.tsBtnEdit.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tsBtnEdit.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.tsBtnEdit.Image = global::NursingManage.Win.Properties.Resources.edit;
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
            this.tsBtnDelete.Image = global::NursingManage.Win.Properties.Resources.delete;
            this.tsBtnDelete.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsBtnDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnDelete.Name = "tsBtnDelete";
            this.tsBtnDelete.Size = new System.Drawing.Size(73, 35);
            this.tsBtnDelete.Text = "删除";
            this.tsBtnDelete.Click += new System.EventHandler(this.tsBtnDelete_Click);
            // 
            // tsbtnOutExcel
            // 
            this.tsbtnOutExcel.BackColor = System.Drawing.Color.Transparent;
            this.tsbtnOutExcel.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tsbtnOutExcel.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.tsbtnOutExcel.Image = global::NursingManage.Win.Properties.Resources.excel;
            this.tsbtnOutExcel.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbtnOutExcel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnOutExcel.Name = "tsbtnOutExcel";
            this.tsbtnOutExcel.Size = new System.Drawing.Size(73, 35);
            this.tsbtnOutExcel.Text = "导出";
            this.tsbtnOutExcel.Click += new System.EventHandler(this.tsbtnOutExcel_Click);
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
            this.tsBtnSearch.Image = global::NursingManage.Win.Properties.Resources.search;
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
            this.tsBtnClose.Image = global::NursingManage.Win.Properties.Resources.exit;
            this.tsBtnClose.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsBtnClose.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnClose.Margin = new System.Windows.Forms.Padding(0, 1, 1, 2);
            this.tsBtnClose.Name = "tsBtnClose";
            this.tsBtnClose.Size = new System.Drawing.Size(73, 35);
            this.tsBtnClose.Text = "退出";
            this.tsBtnClose.Click += new System.EventHandler(this.tsBtnClose_Click);
            // 
            // tsbtnADSearch
            // 
            this.tsbtnADSearch.BackColor = System.Drawing.Color.Transparent;
            this.tsbtnADSearch.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tsbtnADSearch.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.tsbtnADSearch.Image = global::NursingManage.Win.Properties.Resources.search2;
            this.tsbtnADSearch.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbtnADSearch.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnADSearch.Name = "tsbtnADSearch";
            this.tsbtnADSearch.Size = new System.Drawing.Size(101, 35);
            this.tsbtnADSearch.Text = "高级查询";
            this.tsbtnADSearch.Click += new System.EventHandler(this.tsbtnADSearch_Click);
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
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_KeShi,
            this.col_BIANHAO,
            this.col_XINGMING,
            this.col_XINGMING_PY,
            this.col_MINZU,
            this.col_HUNFOU,
            this.col_ZHIWU,
            this.col_SHOUJI,
            this.col_ZHICHENG,
            this.col_NengJi,
            this.col_GONGZUOSHIJIAN,
            this.col_gongzuonianxian,
            this.col_LAIYUANSHIJIAN,
            this.col_laiyuannianxian,
            this.col_RUKESHIJIAN,
            this.col_rukenianxian,
            this.col_XUELI,
            this.col_AddTime,
            this.col_jiguan,
            this.col_zhuanye,
            this.col_jiangkang});
            this.dgv.ContextMenuStrip = this.cMenuExTable;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgv.DisplayRowCount = true;
            this.dgv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv.IsKeepOldSeldected = true;
            this.dgv.Location = new System.Drawing.Point(0, 38);
            this.dgv.MultiSelect = false;
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgv.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgv.RowTemplate.Height = 23;
            this.dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv.Size = new System.Drawing.Size(873, 437);
            this.dgv.TabIndex = 40;
            this.dgv.UseControlStyle = true;
            // 
            // cMenuExTable
            // 
            this.cMenuExTable.Name = "cMenuExTable";
            this.cMenuExTable.Size = new System.Drawing.Size(61, 4);
            // 
            // col_KeShi
            // 
            this.col_KeShi.DataPropertyName = "KeShi";
            this.col_KeShi.HeaderText = "科室";
            this.col_KeShi.Name = "col_KeShi";
            this.col_KeShi.ReadOnly = true;
            this.col_KeShi.Width = 54;
            // 
            // col_BIANHAO
            // 
            this.col_BIANHAO.DataPropertyName = "BIANHAO";
            this.col_BIANHAO.HeaderText = "员工编号";
            this.col_BIANHAO.Name = "col_BIANHAO";
            this.col_BIANHAO.ReadOnly = true;
            this.col_BIANHAO.Width = 78;
            // 
            // col_XINGMING
            // 
            this.col_XINGMING.DataPropertyName = "XINGMING";
            this.col_XINGMING.HeaderText = "姓名";
            this.col_XINGMING.Name = "col_XINGMING";
            this.col_XINGMING.ReadOnly = true;
            this.col_XINGMING.Width = 54;
            // 
            // col_XINGMING_PY
            // 
            this.col_XINGMING_PY.DataPropertyName = "XINGMING_PY";
            this.col_XINGMING_PY.HeaderText = "助记码";
            this.col_XINGMING_PY.Name = "col_XINGMING_PY";
            this.col_XINGMING_PY.ReadOnly = true;
            this.col_XINGMING_PY.Width = 66;
            // 
            // col_MINZU
            // 
            this.col_MINZU.DataPropertyName = "MINZU";
            this.col_MINZU.HeaderText = "民族";
            this.col_MINZU.Name = "col_MINZU";
            this.col_MINZU.ReadOnly = true;
            this.col_MINZU.Width = 54;
            // 
            // col_HUNFOU
            // 
            this.col_HUNFOU.DataPropertyName = "HUNFOU";
            this.col_HUNFOU.HeaderText = "婚否";
            this.col_HUNFOU.Name = "col_HUNFOU";
            this.col_HUNFOU.ReadOnly = true;
            this.col_HUNFOU.Width = 54;
            // 
            // col_ZHIWU
            // 
            this.col_ZHIWU.DataPropertyName = "ZHIWU";
            this.col_ZHIWU.HeaderText = "职务";
            this.col_ZHIWU.Name = "col_ZHIWU";
            this.col_ZHIWU.ReadOnly = true;
            this.col_ZHIWU.Width = 54;
            // 
            // col_SHOUJI
            // 
            this.col_SHOUJI.DataPropertyName = "SHOUJI";
            this.col_SHOUJI.HeaderText = "手机号码";
            this.col_SHOUJI.Name = "col_SHOUJI";
            this.col_SHOUJI.ReadOnly = true;
            this.col_SHOUJI.Width = 78;
            // 
            // col_ZHICHENG
            // 
            this.col_ZHICHENG.DataPropertyName = "ZHICHENG";
            this.col_ZHICHENG.HeaderText = "职称";
            this.col_ZHICHENG.Name = "col_ZHICHENG";
            this.col_ZHICHENG.ReadOnly = true;
            this.col_ZHICHENG.Width = 54;
            // 
            // col_NengJi
            // 
            this.col_NengJi.DataPropertyName = "NengJi";
            this.col_NengJi.HeaderText = "能级";
            this.col_NengJi.Name = "col_NengJi";
            this.col_NengJi.ReadOnly = true;
            this.col_NengJi.Width = 54;
            // 
            // col_GONGZUOSHIJIAN
            // 
            this.col_GONGZUOSHIJIAN.DataPropertyName = "GONGZUOSHIJIAN";
            this.col_GONGZUOSHIJIAN.HeaderText = "工作时间";
            this.col_GONGZUOSHIJIAN.Name = "col_GONGZUOSHIJIAN";
            this.col_GONGZUOSHIJIAN.ReadOnly = true;
            this.col_GONGZUOSHIJIAN.Width = 78;
            // 
            // col_gongzuonianxian
            // 
            this.col_gongzuonianxian.DataPropertyName = "gongzuonianxian";
            this.col_gongzuonianxian.HeaderText = "工作年限";
            this.col_gongzuonianxian.Name = "col_gongzuonianxian";
            this.col_gongzuonianxian.ReadOnly = true;
            this.col_gongzuonianxian.Width = 78;
            // 
            // col_LAIYUANSHIJIAN
            // 
            this.col_LAIYUANSHIJIAN.DataPropertyName = "LAIYUANSHIJIAN";
            this.col_LAIYUANSHIJIAN.HeaderText = "来院时间";
            this.col_LAIYUANSHIJIAN.Name = "col_LAIYUANSHIJIAN";
            this.col_LAIYUANSHIJIAN.ReadOnly = true;
            this.col_LAIYUANSHIJIAN.Width = 78;
            // 
            // col_laiyuannianxian
            // 
            this.col_laiyuannianxian.DataPropertyName = "laiyuannianxian";
            this.col_laiyuannianxian.HeaderText = "来院年限";
            this.col_laiyuannianxian.Name = "col_laiyuannianxian";
            this.col_laiyuannianxian.ReadOnly = true;
            this.col_laiyuannianxian.Width = 78;
            // 
            // col_RUKESHIJIAN
            // 
            this.col_RUKESHIJIAN.DataPropertyName = "RUKESHIJIAN";
            this.col_RUKESHIJIAN.HeaderText = "来科时间";
            this.col_RUKESHIJIAN.Name = "col_RUKESHIJIAN";
            this.col_RUKESHIJIAN.ReadOnly = true;
            this.col_RUKESHIJIAN.Width = 78;
            // 
            // col_rukenianxian
            // 
            this.col_rukenianxian.DataPropertyName = "rukenianxian";
            this.col_rukenianxian.HeaderText = "来科年限";
            this.col_rukenianxian.Name = "col_rukenianxian";
            this.col_rukenianxian.ReadOnly = true;
            this.col_rukenianxian.Width = 78;
            // 
            // col_XUELI
            // 
            this.col_XUELI.DataPropertyName = "XUELI";
            this.col_XUELI.HeaderText = "最高学历";
            this.col_XUELI.Name = "col_XUELI";
            this.col_XUELI.ReadOnly = true;
            this.col_XUELI.Width = 78;
            // 
            // col_AddTime
            // 
            this.col_AddTime.DataPropertyName = "AddTime";
            this.col_AddTime.HeaderText = "增加时间";
            this.col_AddTime.Name = "col_AddTime";
            this.col_AddTime.ReadOnly = true;
            this.col_AddTime.Width = 78;
            // 
            // col_jiguan
            // 
            this.col_jiguan.DataPropertyName = "JIGUAN";
            this.col_jiguan.HeaderText = "籍贯";
            this.col_jiguan.Name = "col_jiguan";
            this.col_jiguan.ReadOnly = true;
            this.col_jiguan.Width = 54;
            // 
            // col_zhuanye
            // 
            this.col_zhuanye.DataPropertyName = "ZHUANYE";
            this.col_zhuanye.HeaderText = "专业";
            this.col_zhuanye.Name = "col_zhuanye";
            this.col_zhuanye.ReadOnly = true;
            this.col_zhuanye.Width = 54;
            // 
            // col_jiangkang
            // 
            this.col_jiangkang.DataPropertyName = "JIANKANGZHUANGKUANG";
            this.col_jiangkang.HeaderText = "健康状况";
            this.col_jiangkang.Name = "col_jiangkang";
            this.col_jiangkang.ReadOnly = true;
            this.col_jiangkang.Width = 78;
            // 
            // FrmDangAnNew
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(873, 511);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.toolStripTop1);
            this.Controls.Add(this.ucPage);
            this.Controls.Add(this.statusStrip1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmDangAnNew";
            this.Text = "档案管理";
            this.Load += new System.EventHandler(this.FrmDangAnNew_Load);
            this.Controls.SetChildIndex(this.statusStrip1, 0);
            this.Controls.SetChildIndex(this.ucPage, 0);
            this.Controls.SetChildIndex(this.toolStripTop1, 0);
            this.Controls.SetChildIndex(this.dgv, 0);
            this.toolStripTop1.ResumeLayout(false);
            this.toolStripTop1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private Framework.WinCommon.Controls.UCPagingNavigation ucPage;
        public System.Windows.Forms.ToolStrip toolStripTop1;
        public System.Windows.Forms.ToolStripButton tsBtnAdd;
        public System.Windows.Forms.ToolStripButton tsBtnEdit;
        public System.Windows.Forms.ToolStripButton tsBtnDelete;
        public System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripTextBox tsTxtSearchValue;
        public System.Windows.Forms.ToolStripButton tsBtnSearch;
        public System.Windows.Forms.ToolStripButton tsBtnClose;
        public System.Windows.Forms.ToolStripButton tsbtnADSearch;
        private Framework.WinCommon.Controls.ZCDataGridView dgv;
        private System.Windows.Forms.ContextMenuStrip cMenuExTable;
        public System.Windows.Forms.ToolStripButton tsbtnOutExcel;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_KeShi;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_BIANHAO;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_XINGMING;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_XINGMING_PY;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_MINZU;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_HUNFOU;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_ZHIWU;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_SHOUJI;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_ZHICHENG;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_NengJi;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_GONGZUOSHIJIAN;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_gongzuonianxian;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_LAIYUANSHIJIAN;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_laiyuannianxian;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_RUKESHIJIAN;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_rukenianxian;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_XUELI;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_AddTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_jiguan;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_zhuanye;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_jiangkang;
    }
}