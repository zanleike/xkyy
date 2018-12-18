namespace NursingManage.Win.DangAnGuanLi
{
    partial class ucInput
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
            this.panelCaption = new System.Windows.Forms.Panel();
            this.lbCaption = new System.Windows.Forms.Label();
            this.panelText = new System.Windows.Forms.Panel();
            this.txt = new Framework.WinCommon.Controls.ZCTextBox();
            this.panelTxtMultiline = new System.Windows.Forms.Panel();
            this.txtMultiline = new Framework.WinCommon.Controls.ZCTextBox();
            this.panelComBox = new System.Windows.Forms.Panel();
            this.comboBox = new System.Windows.Forms.ComboBox();
            this.panelDatePicker = new System.Windows.Forms.Panel();
            this.datePicker = new System.Windows.Forms.DateTimePicker();
            this.panelRequired = new System.Windows.Forms.Panel();
            this.labe = new System.Windows.Forms.Label();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.panelpicturebox = new System.Windows.Forms.Panel();
            this.panelCaption.SuspendLayout();
            this.panelText.SuspendLayout();
            this.panelTxtMultiline.SuspendLayout();
            this.panelComBox.SuspendLayout();
            this.panelDatePicker.SuspendLayout();
            this.panelRequired.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.panelpicturebox.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelCaption
            // 
            this.panelCaption.Controls.Add(this.lbCaption);
            this.panelCaption.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelCaption.Location = new System.Drawing.Point(0, 0);
            this.panelCaption.Name = "panelCaption";
            this.panelCaption.Size = new System.Drawing.Size(141, 163);
            this.panelCaption.TabIndex = 0;
            // 
            // lbCaption
            // 
            this.lbCaption.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbCaption.Location = new System.Drawing.Point(0, 0);
            this.lbCaption.Name = "lbCaption";
            this.lbCaption.Size = new System.Drawing.Size(141, 163);
            this.lbCaption.TabIndex = 1;
            this.lbCaption.Text = "一二三四五六七：";
            this.lbCaption.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panelText
            // 
            this.panelText.Controls.Add(this.txt);
            this.panelText.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelText.Location = new System.Drawing.Point(141, 0);
            this.panelText.Name = "panelText";
            this.panelText.Padding = new System.Windows.Forms.Padding(5, 3, 5, 0);
            this.panelText.Size = new System.Drawing.Size(250, 163);
            this.panelText.TabIndex = 2;
            // 
            // txt
            // 
            this.txt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt.EmptyTextTip = null;
            this.txt.EmptyTextTipColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.txt.EnterIsTab = false;
            this.txt.Location = new System.Drawing.Point(5, 3);
            this.txt.Name = "txt";
            this.txt.Size = new System.Drawing.Size(240, 21);
            this.txt.TabIndex = 4;
            // 
            // panelTxtMultiline
            // 
            this.panelTxtMultiline.Controls.Add(this.txtMultiline);
            this.panelTxtMultiline.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelTxtMultiline.Location = new System.Drawing.Point(391, 0);
            this.panelTxtMultiline.Name = "panelTxtMultiline";
            this.panelTxtMultiline.Padding = new System.Windows.Forms.Padding(5, 8, 5, 12);
            this.panelTxtMultiline.Size = new System.Drawing.Size(137, 163);
            this.panelTxtMultiline.TabIndex = 3;
            this.panelTxtMultiline.Visible = false;
            // 
            // txtMultiline
            // 
            this.txtMultiline.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtMultiline.EmptyTextTip = null;
            this.txtMultiline.EmptyTextTipColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.txtMultiline.EnterIsTab = false;
            this.txtMultiline.Location = new System.Drawing.Point(5, 8);
            this.txtMultiline.Multiline = true;
            this.txtMultiline.Name = "txtMultiline";
            this.txtMultiline.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtMultiline.Size = new System.Drawing.Size(127, 143);
            this.txtMultiline.TabIndex = 2;
            // 
            // panelComBox
            // 
            this.panelComBox.Controls.Add(this.comboBox);
            this.panelComBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelComBox.Location = new System.Drawing.Point(528, 0);
            this.panelComBox.Name = "panelComBox";
            this.panelComBox.Padding = new System.Windows.Forms.Padding(5, 3, 5, 0);
            this.panelComBox.Size = new System.Drawing.Size(174, 163);
            this.panelComBox.TabIndex = 4;
            this.panelComBox.Visible = false;
            // 
            // comboBox
            // 
            this.comboBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBox.FormattingEnabled = true;
            this.comboBox.Items.AddRange(new object[] {
            "1",
            "2"});
            this.comboBox.Location = new System.Drawing.Point(5, 3);
            this.comboBox.Name = "comboBox";
            this.comboBox.Size = new System.Drawing.Size(164, 20);
            this.comboBox.TabIndex = 3;
            // 
            // panelDatePicker
            // 
            this.panelDatePicker.Controls.Add(this.datePicker);
            this.panelDatePicker.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelDatePicker.Location = new System.Drawing.Point(702, 0);
            this.panelDatePicker.Name = "panelDatePicker";
            this.panelDatePicker.Padding = new System.Windows.Forms.Padding(5, 3, 5, 0);
            this.panelDatePicker.Size = new System.Drawing.Size(199, 163);
            this.panelDatePicker.TabIndex = 5;
            this.panelDatePicker.Visible = false;
            // 
            // datePicker
            // 
            this.datePicker.CustomFormat = "yyyy-MM-dd";
            this.datePicker.Dock = System.Windows.Forms.DockStyle.Fill;
            this.datePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datePicker.Location = new System.Drawing.Point(5, 3);
            this.datePicker.Name = "datePicker";
            this.datePicker.Size = new System.Drawing.Size(189, 21);
            this.datePicker.TabIndex = 0;
            // 
            // panelRequired
            // 
            this.panelRequired.Controls.Add(this.labe);
            this.panelRequired.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelRequired.Location = new System.Drawing.Point(901, 0);
            this.panelRequired.Name = "panelRequired";
            this.panelRequired.Padding = new System.Windows.Forms.Padding(3);
            this.panelRequired.Size = new System.Drawing.Size(31, 163);
            this.panelRequired.TabIndex = 7;
            this.panelRequired.Visible = false;
            // 
            // labe
            // 
            this.labe.Dock = System.Windows.Forms.DockStyle.Left;
            this.labe.ForeColor = System.Drawing.Color.Red;
            this.labe.Location = new System.Drawing.Point(3, 3);
            this.labe.Name = "labe";
            this.labe.Size = new System.Drawing.Size(25, 157);
            this.labe.TabIndex = 8;
            this.labe.Text = "*";
            this.labe.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox
            // 
            this.pictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox.Location = new System.Drawing.Point(0, 0);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(104, 158);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox.TabIndex = 8;
            this.pictureBox.TabStop = false;
            this.pictureBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox_MouseClick);
            // 
            // panelpicturebox
            // 
            this.panelpicturebox.AutoScroll = true;
            this.panelpicturebox.Controls.Add(this.pictureBox);
            this.panelpicturebox.Location = new System.Drawing.Point(940, 5);
            this.panelpicturebox.Name = "panelpicturebox";
            this.panelpicturebox.Size = new System.Drawing.Size(104, 158);
            this.panelpicturebox.TabIndex = 9;
            // 
            // ucInput
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.panelpicturebox);
            this.Controls.Add(this.panelRequired);
            this.Controls.Add(this.panelDatePicker);
            this.Controls.Add(this.panelComBox);
            this.Controls.Add(this.panelTxtMultiline);
            this.Controls.Add(this.panelText);
            this.Controls.Add(this.panelCaption);
            this.Name = "ucInput";
            this.Size = new System.Drawing.Size(1049, 163);
            this.Load += new System.EventHandler(this.ucInput_Load);
            this.panelCaption.ResumeLayout(false);
            this.panelText.ResumeLayout(false);
            this.panelText.PerformLayout();
            this.panelTxtMultiline.ResumeLayout(false);
            this.panelTxtMultiline.PerformLayout();
            this.panelComBox.ResumeLayout(false);
            this.panelDatePicker.ResumeLayout(false);
            this.panelRequired.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.panelpicturebox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelCaption;
        private System.Windows.Forms.Panel panelText;
        private System.Windows.Forms.Panel panelTxtMultiline;
        private Framework.WinCommon.Controls.ZCTextBox txtMultiline;
        private System.Windows.Forms.Panel panelComBox;
        private System.Windows.Forms.ComboBox comboBox;
        private System.Windows.Forms.Panel panelDatePicker;
        private System.Windows.Forms.DateTimePicker datePicker;
        private Framework.WinCommon.Controls.ZCTextBox txt;
        private System.Windows.Forms.Panel panelRequired;
        private System.Windows.Forms.Label labe;
        private System.Windows.Forms.Label lbCaption;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Panel panelpicturebox;
    }
}
