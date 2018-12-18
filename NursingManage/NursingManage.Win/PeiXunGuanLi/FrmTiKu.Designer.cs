namespace ZCJH.NursingManage.Win.PeiXunGuanLi
{
    partial class FrmTiKu
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
            this.tsBtnImport = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsTxtSearchValue = new System.Windows.Forms.ToolStripTextBox();
            this.tsBtnSearch = new System.Windows.Forms.ToolStripButton();
            this.tsbtnADSearch = new System.Windows.Forms.ToolStripButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.dgv = new ZhCun.Framework.WinCommon.Controls.ZCDataGridView();
            this.col_QUESTIONS_NO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_QuestionsType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_SimpleLevel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Purpose = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Content = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Option_A = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Option_B = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Option_C = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Option_D = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Option_E = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Option_F = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Option_G = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.tsBtnImport,
            this.toolStripSeparator1,
            this.tsTxtSearchValue,
            this.tsBtnSearch,
            this.tsbtnADSearch});
            this.toolStripTop1.Location = new System.Drawing.Point(0, 0);
            this.toolStripTop1.Name = "toolStripTop1";
            this.toolStripTop1.Size = new System.Drawing.Size(850, 38);
            this.toolStripTop1.TabIndex = 25;
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
            // tsBtnEditor
            // 
            this.tsBtnEditor.BackColor = System.Drawing.Color.Transparent;
            this.tsBtnEditor.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tsBtnEditor.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.tsBtnEditor.Image = global::ZCJH.NursingManage.Win.Properties.Resources.edit;
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
            // tsBtnImport
            // 
            this.tsBtnImport.BackColor = System.Drawing.Color.Transparent;
            this.tsBtnImport.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tsBtnImport.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.tsBtnImport.Image = global::ZCJH.NursingManage.Win.Properties.Resources.excel;
            this.tsBtnImport.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsBtnImport.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnImport.Name = "tsBtnImport";
            this.tsBtnImport.Size = new System.Drawing.Size(101, 35);
            this.tsBtnImport.Text = "导入题库";
            this.tsBtnImport.Click += new System.EventHandler(this.tsBtnImport_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 38);
            // 
            // tsTxtSearchValue
            // 
            this.tsTxtSearchValue.Name = "tsTxtSearchValue";
            this.tsTxtSearchValue.Size = new System.Drawing.Size(100, 38);
            this.tsTxtSearchValue.ToolTipText = "可输入回车进行搜索";
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
            // tsbtnADSearch
            // 
            this.tsbtnADSearch.BackColor = System.Drawing.Color.Transparent;
            this.tsbtnADSearch.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tsbtnADSearch.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.tsbtnADSearch.Image = global::ZCJH.NursingManage.Win.Properties.Resources.search2;
            this.tsbtnADSearch.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbtnADSearch.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnADSearch.Name = "tsbtnADSearch";
            this.tsbtnADSearch.Size = new System.Drawing.Size(101, 35);
            this.tsbtnADSearch.Text = "高级查询";
            this.tsbtnADSearch.Click += new System.EventHandler(this.tsbtnADSearch_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 364);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(850, 22);
            this.statusStrip1.TabIndex = 26;
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
            this.col_QUESTIONS_NO,
            this.col_QuestionsType,
            this.col_SimpleLevel,
            this.col_Purpose,
            this.col_Content,
            this.col_Option_A,
            this.col_Option_B,
            this.col_Option_C,
            this.col_Option_D,
            this.col_Option_E,
            this.col_Option_F,
            this.col_Option_G});
            this.dgv.DisplayRowCount = false;
            this.dgv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv.Location = new System.Drawing.Point(0, 38);
            this.dgv.MultiSelect = false;
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.RowHeadersVisible = false;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgv.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv.RowTemplate.Height = 23;
            this.dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv.Size = new System.Drawing.Size(850, 326);
            this.dgv.TabIndex = 27;
            this.dgv.UseControlStyle = true;
            // 
            // col_QUESTIONS_NO
            // 
            this.col_QUESTIONS_NO.DataPropertyName = "QUESTIONS_NO";
            this.col_QUESTIONS_NO.HeaderText = "试题编号";
            this.col_QUESTIONS_NO.Name = "col_QUESTIONS_NO";
            this.col_QUESTIONS_NO.ReadOnly = true;
            this.col_QUESTIONS_NO.Width = 78;
            // 
            // col_QuestionsType
            // 
            this.col_QuestionsType.DataPropertyName = "Questions_Type";
            this.col_QuestionsType.HeaderText = "试题类型";
            this.col_QuestionsType.Name = "col_QuestionsType";
            this.col_QuestionsType.ReadOnly = true;
            this.col_QuestionsType.Width = 78;
            // 
            // col_SimpleLevel
            // 
            this.col_SimpleLevel.DataPropertyName = "Simple_Level";
            this.col_SimpleLevel.HeaderText = "难易程度";
            this.col_SimpleLevel.Name = "col_SimpleLevel";
            this.col_SimpleLevel.ReadOnly = true;
            this.col_SimpleLevel.Width = 78;
            // 
            // col_Purpose
            // 
            this.col_Purpose.DataPropertyName = "Purpose";
            this.col_Purpose.HeaderText = "试题用途";
            this.col_Purpose.Name = "col_Purpose";
            this.col_Purpose.ReadOnly = true;
            this.col_Purpose.Width = 78;
            // 
            // col_Content
            // 
            this.col_Content.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.col_Content.DataPropertyName = "Content";
            this.col_Content.HeaderText = "试题内容";
            this.col_Content.MaxInputLength = 10;
            this.col_Content.Name = "col_Content";
            this.col_Content.ReadOnly = true;
            this.col_Content.Width = 200;
            // 
            // col_Option_A
            // 
            this.col_Option_A.DataPropertyName = "Option_A";
            this.col_Option_A.HeaderText = "选项A";
            this.col_Option_A.Name = "col_Option_A";
            this.col_Option_A.ReadOnly = true;
            this.col_Option_A.Width = 60;
            // 
            // col_Option_B
            // 
            this.col_Option_B.DataPropertyName = "Option_B";
            this.col_Option_B.HeaderText = "选项B";
            this.col_Option_B.Name = "col_Option_B";
            this.col_Option_B.ReadOnly = true;
            this.col_Option_B.Width = 60;
            // 
            // col_Option_C
            // 
            this.col_Option_C.DataPropertyName = "Option_C";
            this.col_Option_C.HeaderText = "选项C";
            this.col_Option_C.Name = "col_Option_C";
            this.col_Option_C.ReadOnly = true;
            this.col_Option_C.Width = 60;
            // 
            // col_Option_D
            // 
            this.col_Option_D.DataPropertyName = "Option_D";
            this.col_Option_D.HeaderText = "选项D";
            this.col_Option_D.Name = "col_Option_D";
            this.col_Option_D.ReadOnly = true;
            this.col_Option_D.Width = 60;
            // 
            // col_Option_E
            // 
            this.col_Option_E.DataPropertyName = "Option_E";
            this.col_Option_E.HeaderText = "选项E";
            this.col_Option_E.Name = "col_Option_E";
            this.col_Option_E.ReadOnly = true;
            this.col_Option_E.Width = 60;
            // 
            // col_Option_F
            // 
            this.col_Option_F.DataPropertyName = "Option_F";
            this.col_Option_F.HeaderText = "选项F";
            this.col_Option_F.Name = "col_Option_F";
            this.col_Option_F.ReadOnly = true;
            this.col_Option_F.Width = 60;
            // 
            // col_Option_G
            // 
            this.col_Option_G.DataPropertyName = "Option_G";
            this.col_Option_G.HeaderText = "选项G";
            this.col_Option_G.Name = "col_Option_G";
            this.col_Option_G.ReadOnly = true;
            this.col_Option_G.Width = 60;
            // 
            // FrmTiKu
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(850, 386);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStripTop1);
            this.Name = "FrmTiKu";
            this.Text = "题库管理";
            this.Load += new System.EventHandler(this.FrmTiKu_Load);
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
        public System.Windows.Forms.ToolStripButton tsBtnImport;
        public System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripTextBox tsTxtSearchValue;
        public System.Windows.Forms.ToolStripButton tsBtnSearch;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private ZhCun.Framework.WinCommon.Controls.ZCDataGridView dgv;
        public System.Windows.Forms.ToolStripButton tsbtnADSearch;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_QUESTIONS_NO;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_QuestionsType;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_SimpleLevel;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Purpose;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Content;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Option_A;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Option_B;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Option_C;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Option_D;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Option_E;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Option_F;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Option_G;
    }
}