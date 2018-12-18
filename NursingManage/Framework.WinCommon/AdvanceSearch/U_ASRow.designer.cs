namespace Framework.WinCommon.AdvanceSearch
{
    partial class U_ASRow
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.coBoxField = new System.Windows.Forms.ComboBox();
            this.coBoxCompareSign = new System.Windows.Forms.ComboBox();
            this.txtValue = new System.Windows.Forms.TextBox();
            this.coBoxConnectSign = new System.Windows.Forms.ComboBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // coBoxField
            // 
            this.coBoxField.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.coBoxField.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.coBoxField.FormattingEnabled = true;
            this.coBoxField.Location = new System.Drawing.Point(68, 2);
            this.coBoxField.Margin = new System.Windows.Forms.Padding(0);
            this.coBoxField.Name = "coBoxField";
            this.coBoxField.Size = new System.Drawing.Size(137, 22);
            this.coBoxField.TabIndex = 3;
            // 
            // coBoxCompareSign
            // 
            this.coBoxCompareSign.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.coBoxCompareSign.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.coBoxCompareSign.FormattingEnabled = true;
            this.coBoxCompareSign.ItemHeight = 14;
            this.coBoxCompareSign.Location = new System.Drawing.Point(207, 2);
            this.coBoxCompareSign.Margin = new System.Windows.Forms.Padding(0);
            this.coBoxCompareSign.MaxDropDownItems = 10;
            this.coBoxCompareSign.Name = "coBoxCompareSign";
            this.coBoxCompareSign.Size = new System.Drawing.Size(84, 22);
            this.coBoxCompareSign.TabIndex = 7;
            // 
            // txtValue
            // 
            this.txtValue.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtValue.Location = new System.Drawing.Point(294, 2);
            this.txtValue.Margin = new System.Windows.Forms.Padding(0);
            this.txtValue.Name = "txtValue";
            this.txtValue.Size = new System.Drawing.Size(202, 23);
            this.txtValue.TabIndex = 8;
            // 
            // coBoxConnectSign
            // 
            this.coBoxConnectSign.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.coBoxConnectSign.DropDownWidth = 65;
            this.coBoxConnectSign.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.coBoxConnectSign.FormattingEnabled = true;
            this.coBoxConnectSign.IntegralHeight = false;
            this.coBoxConnectSign.Items.AddRange(new object[] {
            "And",
            "Or"});
            this.coBoxConnectSign.Location = new System.Drawing.Point(3, 2);
            this.coBoxConnectSign.Margin = new System.Windows.Forms.Padding(0);
            this.coBoxConnectSign.Name = "coBoxConnectSign";
            this.coBoxConnectSign.Size = new System.Drawing.Size(63, 22);
            this.coBoxConnectSign.TabIndex = 9;
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnDelete.Location = new System.Drawing.Point(497, 0);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(0);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(53, 25);
            this.btnDelete.TabIndex = 10;
            this.btnDelete.Text = "删除";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // U_ASRow
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSize = true;
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.coBoxConnectSign);
            this.Controls.Add(this.txtValue);
            this.Controls.Add(this.coBoxCompareSign);
            this.Controls.Add(this.coBoxField);
            this.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "U_ASRow";
            this.Size = new System.Drawing.Size(550, 25);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox coBoxField;
        private System.Windows.Forms.ComboBox coBoxCompareSign;
        private System.Windows.Forms.TextBox txtValue;
        private System.Windows.Forms.ComboBox coBoxConnectSign;
        private System.Windows.Forms.Button btnDelete;
    }
}
