namespace ZCJH.NursingManage.Win.DangAnGuanLi
{
    partial class FrmDangAn
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
            this.tsBtnEdit = new System.Windows.Forms.ToolStripButton();
            this.tsBtnDelete = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.tsTxtSearchValue = new System.Windows.Forms.ToolStripTextBox();
            this.tsBtnSearch = new System.Windows.Forms.ToolStripButton();
            this.tsBtnClose = new System.Windows.Forms.ToolStripButton();
            this.tsbtnADSearch = new System.Windows.Forms.ToolStripButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tslbRecordCount = new System.Windows.Forms.ToolStripStatusLabel();
            this.dgv = new ZhCun.Framework.WinCommon.Controls.ZCDataGridView();
            this.col_KeShi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_BIANHAO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_XINGMING = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_XINGMING_PY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_CHUSHENGRIQI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_MINZU = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_HUNFOU = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_ZHIWU = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_ZHENGZHIMIANMAO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_SHENFENZHENG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_JIATINGDIZHI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_JIATINGDIANHUA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_SHOUJI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_DIANZIYOUJIAN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_ZHICHENG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_GONGZUOSHIJIAN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_LAIYUANSHIJIAN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_LIYUANSHIJIAN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_SHIFOUZAIZHI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_XUELI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_AddTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStripTop1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
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
            this.tsBtnClose,
            this.tsbtnADSearch});
            this.toolStripTop1.Location = new System.Drawing.Point(0, 0);
            this.toolStripTop1.Name = "toolStripTop1";
            this.toolStripTop1.Size = new System.Drawing.Size(1133, 48);
            this.toolStripTop1.TabIndex = 32;
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
            this.tsBtnAdd.Size = new System.Drawing.Size(82, 45);
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
            this.tsBtnEdit.Size = new System.Drawing.Size(82, 45);
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
            this.tsBtnDelete.Size = new System.Drawing.Size(82, 45);
            this.tsBtnDelete.Text = "删除";
            this.tsBtnDelete.Click += new System.EventHandler(this.tsBtnDelete_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 48);
            // 
            // tsTxtSearchValue
            // 
            this.tsTxtSearchValue.Name = "tsTxtSearchValue";
            this.tsTxtSearchValue.Size = new System.Drawing.Size(132, 48);
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
            this.tsBtnSearch.Size = new System.Drawing.Size(82, 45);
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
            this.tsBtnClose.Size = new System.Drawing.Size(82, 45);
            this.tsBtnClose.Text = "退出";
            this.tsBtnClose.Click += new System.EventHandler(this.tsBtnClose_Click);
            // 
            // tsbtnADSearch
            // 
            this.tsbtnADSearch.BackColor = System.Drawing.Color.Transparent;
            this.tsbtnADSearch.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tsbtnADSearch.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.tsbtnADSearch.Image = global::ZCJH.NursingManage.Win.Properties.Resources.search2;
            this.tsbtnADSearch.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbtnADSearch.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnADSearch.Name = "tsbtnADSearch";
            this.tsbtnADSearch.Size = new System.Drawing.Size(118, 45);
            this.tsbtnADSearch.Text = "高级查询";
            this.tsbtnADSearch.Click += new System.EventHandler(this.tsbtnADSearch_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.tslbRecordCount});
            this.statusStrip1.Location = new System.Drawing.Point(0, 591);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.statusStrip1.Size = new System.Drawing.Size(1133, 25);
            this.statusStrip1.TabIndex = 33;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.BackColor = System.Drawing.Color.Transparent;
            this.toolStripStatusLabel1.ForeColor = System.Drawing.Color.Blue;
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(69, 20);
            this.toolStripStatusLabel1.Text = "记录数：";
            // 
            // tslbRecordCount
            // 
            this.tslbRecordCount.BackColor = System.Drawing.Color.Transparent;
            this.tslbRecordCount.ForeColor = System.Drawing.Color.Blue;
            this.tslbRecordCount.Name = "tslbRecordCount";
            this.tslbRecordCount.Size = new System.Drawing.Size(18, 20);
            this.tslbRecordCount.Text = "0";
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AllowUserToDeleteRows = false;
            this.dgv.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            this.dgv.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgv.BackgroundColor = System.Drawing.Color.Snow;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_KeShi,
            this.col_BIANHAO,
            this.col_XINGMING,
            this.col_XINGMING_PY,
            this.col_CHUSHENGRIQI,
            this.col_MINZU,
            this.col_HUNFOU,
            this.col_ZHIWU,
            this.col_ZHENGZHIMIANMAO,
            this.col_SHENFENZHENG,
            this.col_JIATINGDIZHI,
            this.col_JIATINGDIANHUA,
            this.col_SHOUJI,
            this.col_DIANZIYOUJIAN,
            this.col_ZHICHENG,
            this.col_GONGZUOSHIJIAN,
            this.col_LAIYUANSHIJIAN,
            this.col_LIYUANSHIJIAN,
            this.col_SHIFOUZAIZHI,
            this.col_XUELI,
            this.col_AddTime});
            this.dgv.DisplayRowCount = false;
            this.dgv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv.Location = new System.Drawing.Point(0, 48);
            this.dgv.Margin = new System.Windows.Forms.Padding(4);
            this.dgv.MultiSelect = false;
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.RowHeadersVisible = false;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgv.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv.RowTemplate.Height = 23;
            this.dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv.Size = new System.Drawing.Size(1133, 543);
            this.dgv.TabIndex = 34;
            this.dgv.UseControlStyle = true;
            // 
            // col_KeShi
            // 
            this.col_KeShi.DataPropertyName = "KeShi";
            this.col_KeShi.HeaderText = "科室";
            this.col_KeShi.Name = "col_KeShi";
            this.col_KeShi.ReadOnly = true;
            this.col_KeShi.Width = 62;
            // 
            // col_BIANHAO
            // 
            this.col_BIANHAO.DataPropertyName = "BIANHAO";
            this.col_BIANHAO.HeaderText = "编号";
            this.col_BIANHAO.Name = "col_BIANHAO";
            this.col_BIANHAO.ReadOnly = true;
            this.col_BIANHAO.Width = 62;
            // 
            // col_XINGMING
            // 
            this.col_XINGMING.DataPropertyName = "XINGMING";
            this.col_XINGMING.HeaderText = "姓名";
            this.col_XINGMING.Name = "col_XINGMING";
            this.col_XINGMING.ReadOnly = true;
            this.col_XINGMING.Width = 62;
            // 
            // col_XINGMING_PY
            // 
            this.col_XINGMING_PY.DataPropertyName = "XINGMING_PY";
            this.col_XINGMING_PY.HeaderText = "助记码";
            this.col_XINGMING_PY.Name = "col_XINGMING_PY";
            this.col_XINGMING_PY.ReadOnly = true;
            this.col_XINGMING_PY.Width = 77;
            // 
            // col_CHUSHENGRIQI
            // 
            this.col_CHUSHENGRIQI.DataPropertyName = "CHUSHENGRIQI";
            this.col_CHUSHENGRIQI.HeaderText = "出生日期";
            this.col_CHUSHENGRIQI.Name = "col_CHUSHENGRIQI";
            this.col_CHUSHENGRIQI.ReadOnly = true;
            this.col_CHUSHENGRIQI.Width = 92;
            // 
            // col_MINZU
            // 
            this.col_MINZU.DataPropertyName = "MINZU";
            this.col_MINZU.HeaderText = "民族";
            this.col_MINZU.Name = "col_MINZU";
            this.col_MINZU.ReadOnly = true;
            this.col_MINZU.Width = 62;
            // 
            // col_HUNFOU
            // 
            this.col_HUNFOU.DataPropertyName = "HUNFOU";
            this.col_HUNFOU.HeaderText = "婚否";
            this.col_HUNFOU.Name = "col_HUNFOU";
            this.col_HUNFOU.ReadOnly = true;
            this.col_HUNFOU.Width = 62;
            // 
            // col_ZHIWU
            // 
            this.col_ZHIWU.DataPropertyName = "ZHIWU";
            this.col_ZHIWU.HeaderText = "岗位";
            this.col_ZHIWU.Name = "col_ZHIWU";
            this.col_ZHIWU.ReadOnly = true;
            this.col_ZHIWU.Width = 62;
            // 
            // col_ZHENGZHIMIANMAO
            // 
            this.col_ZHENGZHIMIANMAO.DataPropertyName = "ZHENGZHIMIANMAO";
            this.col_ZHENGZHIMIANMAO.HeaderText = "政治面貌";
            this.col_ZHENGZHIMIANMAO.Name = "col_ZHENGZHIMIANMAO";
            this.col_ZHENGZHIMIANMAO.ReadOnly = true;
            this.col_ZHENGZHIMIANMAO.Width = 92;
            // 
            // col_SHENFENZHENG
            // 
            this.col_SHENFENZHENG.DataPropertyName = "SHENFENZHENG";
            this.col_SHENFENZHENG.HeaderText = "身份证号";
            this.col_SHENFENZHENG.Name = "col_SHENFENZHENG";
            this.col_SHENFENZHENG.ReadOnly = true;
            this.col_SHENFENZHENG.Width = 92;
            // 
            // col_JIATINGDIZHI
            // 
            this.col_JIATINGDIZHI.DataPropertyName = "JIATINGDIZHI";
            this.col_JIATINGDIZHI.HeaderText = "家庭地址";
            this.col_JIATINGDIZHI.Name = "col_JIATINGDIZHI";
            this.col_JIATINGDIZHI.ReadOnly = true;
            this.col_JIATINGDIZHI.Width = 92;
            // 
            // col_JIATINGDIANHUA
            // 
            this.col_JIATINGDIANHUA.DataPropertyName = "JIATINGDIANHUA";
            this.col_JIATINGDIANHUA.HeaderText = "家庭电话";
            this.col_JIATINGDIANHUA.Name = "col_JIATINGDIANHUA";
            this.col_JIATINGDIANHUA.ReadOnly = true;
            this.col_JIATINGDIANHUA.Width = 92;
            // 
            // col_SHOUJI
            // 
            this.col_SHOUJI.DataPropertyName = "SHOUJI";
            this.col_SHOUJI.HeaderText = "手机号码";
            this.col_SHOUJI.Name = "col_SHOUJI";
            this.col_SHOUJI.ReadOnly = true;
            this.col_SHOUJI.Width = 92;
            // 
            // col_DIANZIYOUJIAN
            // 
            this.col_DIANZIYOUJIAN.DataPropertyName = "DIANZIYOUJIAN";
            this.col_DIANZIYOUJIAN.HeaderText = "电子邮件";
            this.col_DIANZIYOUJIAN.Name = "col_DIANZIYOUJIAN";
            this.col_DIANZIYOUJIAN.ReadOnly = true;
            this.col_DIANZIYOUJIAN.Width = 92;
            // 
            // col_ZHICHENG
            // 
            this.col_ZHICHENG.DataPropertyName = "ZHICHENG";
            this.col_ZHICHENG.HeaderText = "职称";
            this.col_ZHICHENG.Name = "col_ZHICHENG";
            this.col_ZHICHENG.ReadOnly = true;
            this.col_ZHICHENG.Width = 62;
            // 
            // col_GONGZUOSHIJIAN
            // 
            this.col_GONGZUOSHIJIAN.DataPropertyName = "GONGZUOSHIJIAN";
            this.col_GONGZUOSHIJIAN.HeaderText = "工作时间";
            this.col_GONGZUOSHIJIAN.Name = "col_GONGZUOSHIJIAN";
            this.col_GONGZUOSHIJIAN.ReadOnly = true;
            this.col_GONGZUOSHIJIAN.Width = 92;
            // 
            // col_LAIYUANSHIJIAN
            // 
            this.col_LAIYUANSHIJIAN.DataPropertyName = "LAIYUANSHIJIAN";
            this.col_LAIYUANSHIJIAN.HeaderText = "来院时间";
            this.col_LAIYUANSHIJIAN.Name = "col_LAIYUANSHIJIAN";
            this.col_LAIYUANSHIJIAN.ReadOnly = true;
            this.col_LAIYUANSHIJIAN.Width = 92;
            // 
            // col_LIYUANSHIJIAN
            // 
            this.col_LIYUANSHIJIAN.DataPropertyName = "LIYUANSHIJIAN";
            this.col_LIYUANSHIJIAN.HeaderText = "离院时间";
            this.col_LIYUANSHIJIAN.Name = "col_LIYUANSHIJIAN";
            this.col_LIYUANSHIJIAN.ReadOnly = true;
            this.col_LIYUANSHIJIAN.Width = 92;
            // 
            // col_SHIFOUZAIZHI
            // 
            this.col_SHIFOUZAIZHI.DataPropertyName = "SHIFOUZAIZHI";
            this.col_SHIFOUZAIZHI.HeaderText = "是否在职";
            this.col_SHIFOUZAIZHI.Name = "col_SHIFOUZAIZHI";
            this.col_SHIFOUZAIZHI.ReadOnly = true;
            this.col_SHIFOUZAIZHI.Width = 92;
            // 
            // col_XUELI
            // 
            this.col_XUELI.DataPropertyName = "XUELI";
            this.col_XUELI.HeaderText = "学历";
            this.col_XUELI.Name = "col_XUELI";
            this.col_XUELI.ReadOnly = true;
            this.col_XUELI.Width = 62;
            // 
            // col_AddTime
            // 
            this.col_AddTime.DataPropertyName = "AddTime";
            this.col_AddTime.HeaderText = "增加时间";
            this.col_AddTime.Name = "col_AddTime";
            this.col_AddTime.ReadOnly = true;
            this.col_AddTime.Width = 92;
            // 
            // FrmDangAn
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1133, 616);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStripTop1);
            this.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmDangAn";
            this.Text = "档案管理";
            this.Load += new System.EventHandler(this.FrmDangAn_Load);
            this.Controls.SetChildIndex(this.toolStripTop1, 0);
            this.Controls.SetChildIndex(this.statusStrip1, 0);
            this.Controls.SetChildIndex(this.dgv, 0);
            this.toolStripTop1.ResumeLayout(false);
            this.toolStripTop1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.ToolStrip toolStripTop1;
        public System.Windows.Forms.ToolStripButton tsBtnAdd;
        public System.Windows.Forms.ToolStripButton tsBtnEdit;
        public System.Windows.Forms.ToolStripButton tsBtnDelete;
        public System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripTextBox tsTxtSearchValue;
        public System.Windows.Forms.ToolStripButton tsBtnSearch;
        public System.Windows.Forms.ToolStripButton tsBtnClose;
        private System.Windows.Forms.StatusStrip statusStrip1;
        public System.Windows.Forms.ToolStripButton tsbtnADSearch;
        private ZhCun.Framework.WinCommon.Controls.ZCDataGridView dgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_KeShi;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_BIANHAO;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_XINGMING;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_XINGMING_PY;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_CHUSHENGRIQI;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_MINZU;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_HUNFOU;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_ZHIWU;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_ZHENGZHIMIANMAO;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_SHENFENZHENG;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_JIATINGDIZHI;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_JIATINGDIANHUA;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_SHOUJI;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_DIANZIYOUJIAN;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_ZHICHENG;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_GONGZUOSHIJIAN;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_LAIYUANSHIJIAN;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_LIYUANSHIJIAN;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_SHIFOUZAIZHI;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_XUELI;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_AddTime;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel tslbRecordCount;

    }
}