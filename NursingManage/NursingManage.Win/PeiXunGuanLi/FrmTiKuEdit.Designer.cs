namespace NursingManage.Win.PeiXunGuanLi
{
    partial class FrmTiKuEdit
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
            this.txtBianHao = new Framework.WinCommon.Controls.ZCTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtShiTiNeiRong = new Framework.WinCommon.Controls.ZCTextBox();
            this.dcm1 = new Framework.WinCommon.Components.DCM(this.components);
            this.coBoxJianYiChengDu = new System.Windows.Forms.ComboBox();
            this.txtXIANGMUA = new Framework.WinCommon.Controls.ZCTextBox();
            this.chBoxXIANGMUA_OK = new System.Windows.Forms.CheckBox();
            this.txtXIANGMUB = new Framework.WinCommon.Controls.ZCTextBox();
            this.chBoxXIANGMUB_OK = new System.Windows.Forms.CheckBox();
            this.txtXIANGMUC = new Framework.WinCommon.Controls.ZCTextBox();
            this.chBoxXIANGMUC_OK = new System.Windows.Forms.CheckBox();
            this.txtXIANGMUD = new Framework.WinCommon.Controls.ZCTextBox();
            this.chBoxXIANGMUD_OK = new System.Windows.Forms.CheckBox();
            this.txtXIANGMUE = new Framework.WinCommon.Controls.ZCTextBox();
            this.chBoxXIANGMUE_OK = new System.Windows.Forms.CheckBox();
            this.txtXIANGMUF = new Framework.WinCommon.Controls.ZCTextBox();
            this.chBoxXIANGMUF_OK = new System.Windows.Forms.CheckBox();
            this.coBoxShiTiLeiXing = new System.Windows.Forms.ComboBox();
            this.txtDaAn = new Framework.WinCommon.Controls.ZCTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.gBoxDaAn = new System.Windows.Forms.GroupBox();
            this.panelDuoXuan = new System.Windows.Forms.Panel();
            this.panelDuoXuanEx = new System.Windows.Forms.Panel();
            this.panelWenDa = new System.Windows.Forms.Panel();
            this.gBoxDaAn.SuspendLayout();
            this.panelDuoXuan.SuspendLayout();
            this.panelDuoXuanEx.SuspendLayout();
            this.panelWenDa.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "试题编号：";
            // 
            // txtBianHao
            // 
            this.txtBianHao.EmptyTextTip = null;
            this.txtBianHao.EmptyTextTipColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.txtBianHao.EnterIsTab = false;
            this.dcm1.SetIsUse(this.txtBianHao, true);
            this.txtBianHao.Location = new System.Drawing.Point(97, 111);
            this.txtBianHao.Name = "txtBianHao";
            this.txtBianHao.Size = new System.Drawing.Size(71, 25);
            this.txtBianHao.TabIndex = 1;
            this.dcm1.SetTagColumnName(this.txtBianHao, null);
            this.dcm1.SetTextColumnName(this.txtBianHao, "BIANHAO");
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "试题内容：";
            // 
            // txtShiTiNeiRong
            // 
            this.txtShiTiNeiRong.EmptyTextTip = null;
            this.txtShiTiNeiRong.EmptyTextTipColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.txtShiTiNeiRong.EnterIsTab = false;
            this.dcm1.SetIsUse(this.txtShiTiNeiRong, true);
            this.txtShiTiNeiRong.Location = new System.Drawing.Point(19, 33);
            this.txtShiTiNeiRong.Multiline = true;
            this.txtShiTiNeiRong.Name = "txtShiTiNeiRong";
            this.txtShiTiNeiRong.Size = new System.Drawing.Size(494, 69);
            this.txtShiTiNeiRong.TabIndex = 0;
            this.dcm1.SetTagColumnName(this.txtShiTiNeiRong, null);
            this.dcm1.SetTextColumnName(this.txtShiTiNeiRong, "NEIRONG");
            // 
            // coBoxJianYiChengDu
            // 
            this.coBoxJianYiChengDu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.coBoxJianYiChengDu.FormattingEnabled = true;
            this.dcm1.SetIsUse(this.coBoxJianYiChengDu, true);
            this.coBoxJianYiChengDu.Items.AddRange(new object[] {
            "简单",
            "普通",
            "困难"});
            this.coBoxJianYiChengDu.Location = new System.Drawing.Point(255, 111);
            this.coBoxJianYiChengDu.Name = "coBoxJianYiChengDu";
            this.coBoxJianYiChengDu.Size = new System.Drawing.Size(65, 23);
            this.coBoxJianYiChengDu.TabIndex = 2;
            this.dcm1.SetTagColumnName(this.coBoxJianYiChengDu, null);
            this.dcm1.SetTextColumnName(this.coBoxJianYiChengDu, "NANYICHENGDU");
            // 
            // txtXIANGMUA
            // 
            this.txtXIANGMUA.EmptyTextTip = null;
            this.txtXIANGMUA.EmptyTextTipColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.txtXIANGMUA.EnterIsTab = false;
            this.dcm1.SetIsUse(this.txtXIANGMUA, true);
            this.txtXIANGMUA.Location = new System.Drawing.Point(32, 9);
            this.txtXIANGMUA.Name = "txtXIANGMUA";
            this.txtXIANGMUA.Size = new System.Drawing.Size(404, 25);
            this.txtXIANGMUA.TabIndex = 5;
            this.dcm1.SetTagColumnName(this.txtXIANGMUA, null);
            this.dcm1.SetTextColumnName(this.txtXIANGMUA, "XIANGMUA");
            // 
            // chBoxXIANGMUA_OK
            // 
            this.chBoxXIANGMUA_OK.AutoSize = true;
            this.dcm1.SetIsUse(this.chBoxXIANGMUA_OK, true);
            this.chBoxXIANGMUA_OK.Location = new System.Drawing.Point(450, 12);
            this.chBoxXIANGMUA_OK.Name = "chBoxXIANGMUA_OK";
            this.chBoxXIANGMUA_OK.Size = new System.Drawing.Size(18, 17);
            this.chBoxXIANGMUA_OK.TabIndex = 6;
            this.dcm1.SetTagColumnName(this.chBoxXIANGMUA_OK, null);
            this.dcm1.SetTextColumnName(this.chBoxXIANGMUA_OK, "XIANGMUA_OK");
            this.chBoxXIANGMUA_OK.UseVisualStyleBackColor = true;
            this.chBoxXIANGMUA_OK.Click += new System.EventHandler(this.chBoxXIANGMU_CheckedChanged);
            // 
            // txtXIANGMUB
            // 
            this.txtXIANGMUB.EmptyTextTip = null;
            this.txtXIANGMUB.EmptyTextTipColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.txtXIANGMUB.EnterIsTab = false;
            this.dcm1.SetIsUse(this.txtXIANGMUB, true);
            this.txtXIANGMUB.Location = new System.Drawing.Point(32, 36);
            this.txtXIANGMUB.Name = "txtXIANGMUB";
            this.txtXIANGMUB.Size = new System.Drawing.Size(404, 25);
            this.txtXIANGMUB.TabIndex = 7;
            this.dcm1.SetTagColumnName(this.txtXIANGMUB, null);
            this.dcm1.SetTextColumnName(this.txtXIANGMUB, "XIANGMUB");
            // 
            // chBoxXIANGMUB_OK
            // 
            this.chBoxXIANGMUB_OK.AutoSize = true;
            this.dcm1.SetIsUse(this.chBoxXIANGMUB_OK, true);
            this.chBoxXIANGMUB_OK.Location = new System.Drawing.Point(450, 39);
            this.chBoxXIANGMUB_OK.Name = "chBoxXIANGMUB_OK";
            this.chBoxXIANGMUB_OK.Size = new System.Drawing.Size(18, 17);
            this.chBoxXIANGMUB_OK.TabIndex = 8;
            this.dcm1.SetTagColumnName(this.chBoxXIANGMUB_OK, null);
            this.dcm1.SetTextColumnName(this.chBoxXIANGMUB_OK, "XIANGMUB_OK");
            this.chBoxXIANGMUB_OK.UseVisualStyleBackColor = true;
            this.chBoxXIANGMUB_OK.Click += new System.EventHandler(this.chBoxXIANGMU_CheckedChanged);
            // 
            // txtXIANGMUC
            // 
            this.txtXIANGMUC.EmptyTextTip = null;
            this.txtXIANGMUC.EmptyTextTipColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.txtXIANGMUC.EnterIsTab = false;
            this.dcm1.SetIsUse(this.txtXIANGMUC, true);
            this.txtXIANGMUC.Location = new System.Drawing.Point(29, 6);
            this.txtXIANGMUC.Name = "txtXIANGMUC";
            this.txtXIANGMUC.Size = new System.Drawing.Size(404, 25);
            this.txtXIANGMUC.TabIndex = 9;
            this.dcm1.SetTagColumnName(this.txtXIANGMUC, null);
            this.dcm1.SetTextColumnName(this.txtXIANGMUC, "XIANGMUC");
            // 
            // chBoxXIANGMUC_OK
            // 
            this.chBoxXIANGMUC_OK.AutoSize = true;
            this.dcm1.SetIsUse(this.chBoxXIANGMUC_OK, true);
            this.chBoxXIANGMUC_OK.Location = new System.Drawing.Point(447, 9);
            this.chBoxXIANGMUC_OK.Name = "chBoxXIANGMUC_OK";
            this.chBoxXIANGMUC_OK.Size = new System.Drawing.Size(18, 17);
            this.chBoxXIANGMUC_OK.TabIndex = 10;
            this.dcm1.SetTagColumnName(this.chBoxXIANGMUC_OK, null);
            this.dcm1.SetTextColumnName(this.chBoxXIANGMUC_OK, "XIANGMUC_OK");
            this.chBoxXIANGMUC_OK.UseVisualStyleBackColor = true;
            this.chBoxXIANGMUC_OK.Click += new System.EventHandler(this.chBoxXIANGMU_CheckedChanged);
            // 
            // txtXIANGMUD
            // 
            this.txtXIANGMUD.EmptyTextTip = null;
            this.txtXIANGMUD.EmptyTextTipColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.txtXIANGMUD.EnterIsTab = false;
            this.dcm1.SetIsUse(this.txtXIANGMUD, true);
            this.txtXIANGMUD.Location = new System.Drawing.Point(29, 33);
            this.txtXIANGMUD.Name = "txtXIANGMUD";
            this.txtXIANGMUD.Size = new System.Drawing.Size(404, 25);
            this.txtXIANGMUD.TabIndex = 11;
            this.dcm1.SetTagColumnName(this.txtXIANGMUD, null);
            this.dcm1.SetTextColumnName(this.txtXIANGMUD, "XIANGMUD");
            // 
            // chBoxXIANGMUD_OK
            // 
            this.chBoxXIANGMUD_OK.AutoSize = true;
            this.dcm1.SetIsUse(this.chBoxXIANGMUD_OK, true);
            this.chBoxXIANGMUD_OK.Location = new System.Drawing.Point(447, 36);
            this.chBoxXIANGMUD_OK.Name = "chBoxXIANGMUD_OK";
            this.chBoxXIANGMUD_OK.Size = new System.Drawing.Size(18, 17);
            this.chBoxXIANGMUD_OK.TabIndex = 12;
            this.dcm1.SetTagColumnName(this.chBoxXIANGMUD_OK, null);
            this.dcm1.SetTextColumnName(this.chBoxXIANGMUD_OK, "XIANGMUD_OK");
            this.chBoxXIANGMUD_OK.UseVisualStyleBackColor = true;
            this.chBoxXIANGMUD_OK.Click += new System.EventHandler(this.chBoxXIANGMU_CheckedChanged);
            // 
            // txtXIANGMUE
            // 
            this.txtXIANGMUE.EmptyTextTip = null;
            this.txtXIANGMUE.EmptyTextTipColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.txtXIANGMUE.EnterIsTab = false;
            this.dcm1.SetIsUse(this.txtXIANGMUE, true);
            this.txtXIANGMUE.Location = new System.Drawing.Point(29, 60);
            this.txtXIANGMUE.Name = "txtXIANGMUE";
            this.txtXIANGMUE.Size = new System.Drawing.Size(404, 25);
            this.txtXIANGMUE.TabIndex = 13;
            this.dcm1.SetTagColumnName(this.txtXIANGMUE, null);
            this.dcm1.SetTextColumnName(this.txtXIANGMUE, "XIANGMUE");
            // 
            // chBoxXIANGMUE_OK
            // 
            this.chBoxXIANGMUE_OK.AutoSize = true;
            this.dcm1.SetIsUse(this.chBoxXIANGMUE_OK, true);
            this.chBoxXIANGMUE_OK.Location = new System.Drawing.Point(447, 63);
            this.chBoxXIANGMUE_OK.Name = "chBoxXIANGMUE_OK";
            this.chBoxXIANGMUE_OK.Size = new System.Drawing.Size(18, 17);
            this.chBoxXIANGMUE_OK.TabIndex = 14;
            this.dcm1.SetTagColumnName(this.chBoxXIANGMUE_OK, null);
            this.dcm1.SetTextColumnName(this.chBoxXIANGMUE_OK, "XIANGMUE_OK");
            this.chBoxXIANGMUE_OK.UseVisualStyleBackColor = true;
            this.chBoxXIANGMUE_OK.Click += new System.EventHandler(this.chBoxXIANGMU_CheckedChanged);
            // 
            // txtXIANGMUF
            // 
            this.txtXIANGMUF.EmptyTextTip = null;
            this.txtXIANGMUF.EmptyTextTipColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.txtXIANGMUF.EnterIsTab = false;
            this.dcm1.SetIsUse(this.txtXIANGMUF, true);
            this.txtXIANGMUF.Location = new System.Drawing.Point(29, 87);
            this.txtXIANGMUF.Name = "txtXIANGMUF";
            this.txtXIANGMUF.Size = new System.Drawing.Size(404, 25);
            this.txtXIANGMUF.TabIndex = 15;
            this.dcm1.SetTagColumnName(this.txtXIANGMUF, null);
            this.dcm1.SetTextColumnName(this.txtXIANGMUF, "XIANGMUF");
            // 
            // chBoxXIANGMUF_OK
            // 
            this.chBoxXIANGMUF_OK.AutoSize = true;
            this.dcm1.SetIsUse(this.chBoxXIANGMUF_OK, true);
            this.chBoxXIANGMUF_OK.Location = new System.Drawing.Point(447, 90);
            this.chBoxXIANGMUF_OK.Name = "chBoxXIANGMUF_OK";
            this.chBoxXIANGMUF_OK.Size = new System.Drawing.Size(18, 17);
            this.chBoxXIANGMUF_OK.TabIndex = 16;
            this.dcm1.SetTagColumnName(this.chBoxXIANGMUF_OK, null);
            this.dcm1.SetTextColumnName(this.chBoxXIANGMUF_OK, "XIANGMUF_OK");
            this.chBoxXIANGMUF_OK.UseVisualStyleBackColor = true;
            this.chBoxXIANGMUF_OK.Click += new System.EventHandler(this.chBoxXIANGMU_CheckedChanged);
            // 
            // coBoxShiTiLeiXing
            // 
            this.coBoxShiTiLeiXing.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.coBoxShiTiLeiXing.FormattingEnabled = true;
            this.dcm1.SetIsUse(this.coBoxShiTiLeiXing, true);
            this.coBoxShiTiLeiXing.Items.AddRange(new object[] {
            "单选题",
            "多选题",
            "判断题",
            "名词解释",
            "问答题"});
            this.coBoxShiTiLeiXing.Location = new System.Drawing.Point(403, 111);
            this.coBoxShiTiLeiXing.Name = "coBoxShiTiLeiXing";
            this.coBoxShiTiLeiXing.Size = new System.Drawing.Size(110, 23);
            this.coBoxShiTiLeiXing.TabIndex = 4;
            this.dcm1.SetTagColumnName(this.coBoxShiTiLeiXing, null);
            this.dcm1.SetTextColumnName(this.coBoxShiTiLeiXing, "LEIXING");
            this.coBoxShiTiLeiXing.SelectedIndexChanged += new System.EventHandler(this.coBoxShiTiLeiXing_SelectedIndexChanged);
            // 
            // txtDaAn
            // 
            this.txtDaAn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtDaAn.EmptyTextTip = null;
            this.txtDaAn.EmptyTextTipColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.txtDaAn.EnterIsTab = false;
            this.dcm1.SetIsUse(this.txtDaAn, true);
            this.txtDaAn.Location = new System.Drawing.Point(0, 0);
            this.txtDaAn.Multiline = true;
            this.txtDaAn.Name = "txtDaAn";
            this.txtDaAn.Size = new System.Drawing.Size(397, 48);
            this.txtDaAn.TabIndex = 0;
            this.dcm1.SetTagColumnName(this.txtDaAn, null);
            this.dcm1.SetTextColumnName(this.txtDaAn, "DAAN");
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(172, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 15);
            this.label3.TabIndex = 1;
            this.label3.Text = "难易程度：";
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(357, 358);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 26);
            this.btnOK.TabIndex = 6;
            this.btnOK.Text = "确定";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(438, 358);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 26);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 90);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(23, 15);
            this.label10.TabIndex = 0;
            this.label10.Text = "F:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 63);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(23, 15);
            this.label9.TabIndex = 0;
            this.label9.Text = "E:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 36);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(23, 15);
            this.label8.TabIndex = 0;
            this.label8.Text = "D:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(23, 15);
            this.label7.TabIndex = 0;
            this.label7.Text = "C:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 39);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(23, 15);
            this.label6.TabIndex = 0;
            this.label6.Text = "B:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(23, 15);
            this.label5.TabIndex = 0;
            this.label5.Text = "A:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(326, 115);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(82, 15);
            this.label17.TabIndex = 1;
            this.label17.Text = "试题类型：";
            // 
            // gBoxDaAn
            // 
            this.gBoxDaAn.Controls.Add(this.panelDuoXuan);
            this.gBoxDaAn.Location = new System.Drawing.Point(18, 147);
            this.gBoxDaAn.Name = "gBoxDaAn";
            this.gBoxDaAn.Size = new System.Drawing.Size(505, 203);
            this.gBoxDaAn.TabIndex = 9;
            this.gBoxDaAn.TabStop = false;
            this.gBoxDaAn.Text = "试题答案";
            // 
            // panelDuoXuan
            // 
            this.panelDuoXuan.Controls.Add(this.panelDuoXuanEx);
            this.panelDuoXuan.Controls.Add(this.txtXIANGMUA);
            this.panelDuoXuan.Controls.Add(this.txtXIANGMUB);
            this.panelDuoXuan.Controls.Add(this.chBoxXIANGMUB_OK);
            this.panelDuoXuan.Controls.Add(this.chBoxXIANGMUA_OK);
            this.panelDuoXuan.Controls.Add(this.label5);
            this.panelDuoXuan.Controls.Add(this.label6);
            this.panelDuoXuan.Location = new System.Drawing.Point(10, 19);
            this.panelDuoXuan.Name = "panelDuoXuan";
            this.panelDuoXuan.Size = new System.Drawing.Size(477, 176);
            this.panelDuoXuan.TabIndex = 10;
            // 
            // panelDuoXuanEx
            // 
            this.panelDuoXuanEx.Controls.Add(this.chBoxXIANGMUF_OK);
            this.panelDuoXuanEx.Controls.Add(this.label7);
            this.panelDuoXuanEx.Controls.Add(this.label8);
            this.panelDuoXuanEx.Controls.Add(this.chBoxXIANGMUE_OK);
            this.panelDuoXuanEx.Controls.Add(this.label9);
            this.panelDuoXuanEx.Controls.Add(this.label10);
            this.panelDuoXuanEx.Controls.Add(this.chBoxXIANGMUD_OK);
            this.panelDuoXuanEx.Controls.Add(this.txtXIANGMUF);
            this.panelDuoXuanEx.Controls.Add(this.txtXIANGMUC);
            this.panelDuoXuanEx.Controls.Add(this.txtXIANGMUE);
            this.panelDuoXuanEx.Controls.Add(this.chBoxXIANGMUC_OK);
            this.panelDuoXuanEx.Controls.Add(this.txtXIANGMUD);
            this.panelDuoXuanEx.Location = new System.Drawing.Point(3, 59);
            this.panelDuoXuanEx.Name = "panelDuoXuanEx";
            this.panelDuoXuanEx.Size = new System.Drawing.Size(471, 113);
            this.panelDuoXuanEx.TabIndex = 10;
            // 
            // panelWenDa
            // 
            this.panelWenDa.Controls.Add(this.txtDaAn);
            this.panelWenDa.Location = new System.Drawing.Point(610, 203);
            this.panelWenDa.Name = "panelWenDa";
            this.panelWenDa.Size = new System.Drawing.Size(397, 48);
            this.panelWenDa.TabIndex = 0;
            this.panelWenDa.Visible = false;
            // 
            // FrmTiKuEdit
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(545, 400);
            this.Controls.Add(this.panelWenDa);
            this.Controls.Add(this.gBoxDaAn);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.coBoxShiTiLeiXing);
            this.Controls.Add(this.coBoxJianYiChengDu);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.txtShiTiNeiRong);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtBianHao);
            this.Controls.Add(this.label1);
            this.KeyPreview = true;
            this.Name = "FrmTiKuEdit";
            this.Text = "题库维护";
            this.Load += new System.EventHandler(this.FrmTiKuEdit_Load);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.txtBianHao, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.txtShiTiNeiRong, 0);
            this.Controls.SetChildIndex(this.label17, 0);
            this.Controls.SetChildIndex(this.coBoxJianYiChengDu, 0);
            this.Controls.SetChildIndex(this.coBoxShiTiLeiXing, 0);
            this.Controls.SetChildIndex(this.btnOK, 0);
            this.Controls.SetChildIndex(this.btnCancel, 0);
            this.Controls.SetChildIndex(this.gBoxDaAn, 0);
            this.Controls.SetChildIndex(this.panelWenDa, 0);
            this.gBoxDaAn.ResumeLayout(false);
            this.panelDuoXuan.ResumeLayout(false);
            this.panelDuoXuan.PerformLayout();
            this.panelDuoXuanEx.ResumeLayout(false);
            this.panelDuoXuanEx.PerformLayout();
            this.panelWenDa.ResumeLayout(false);
            this.panelWenDa.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Framework.WinCommon.Controls.ZCTextBox txtBianHao;
        private System.Windows.Forms.Label label2;
        private Framework.WinCommon.Controls.ZCTextBox txtShiTiNeiRong;
        private Framework.WinCommon.Components.DCM dcm1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox coBoxJianYiChengDu;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label5;
        private Framework.WinCommon.Controls.ZCTextBox txtXIANGMUA;
        private System.Windows.Forms.CheckBox chBoxXIANGMUA_OK;
        private System.Windows.Forms.CheckBox chBoxXIANGMUF_OK;
        private System.Windows.Forms.CheckBox chBoxXIANGMUE_OK;
        private System.Windows.Forms.CheckBox chBoxXIANGMUD_OK;
        private System.Windows.Forms.CheckBox chBoxXIANGMUC_OK;
        private System.Windows.Forms.CheckBox chBoxXIANGMUB_OK;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private Framework.WinCommon.Controls.ZCTextBox txtXIANGMUF;
        private Framework.WinCommon.Controls.ZCTextBox txtXIANGMUE;
        private Framework.WinCommon.Controls.ZCTextBox txtXIANGMUD;
        private Framework.WinCommon.Controls.ZCTextBox txtXIANGMUC;
        private Framework.WinCommon.Controls.ZCTextBox txtXIANGMUB;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.ComboBox coBoxShiTiLeiXing;
        private System.Windows.Forms.GroupBox gBoxDaAn;
        private System.Windows.Forms.Panel panelDuoXuan;
        private System.Windows.Forms.Panel panelWenDa;
        private Framework.WinCommon.Controls.ZCTextBox txtDaAn;
        private System.Windows.Forms.Panel panelDuoXuanEx;
    }
}