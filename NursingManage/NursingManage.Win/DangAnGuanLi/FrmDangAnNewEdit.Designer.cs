namespace ZCJH.NursingManage.Win.DangAnGuanLi
{
    partial class FrmDangAnNewEdit
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
            this.dcm1 = new ZhCun.Framework.WinCommon.Components.DCM(this.components);
            this.comboxList1 = new ZhCun.Framework.WinCommon.Components.ComboxList(this.components);
            this.SuspendLayout();
            // 
            // comboxList1
            // 
            this.comboxList1.GridViewDataSource = null;
            this.comboxList1.MaxRowCount = 5;
            // 
            // FrmDangAnNewEdit
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(982, 553);
            this.KeyPreview = true;
            this.Name = "FrmDangAnNewEdit";
            this.Text = "档案编辑";
            this.Load += new System.EventHandler(this.FrmDangAnNewEdit_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ZhCun.Framework.WinCommon.Components.DCM dcm1;
        private ZhCun.Framework.WinCommon.Components.ComboxList comboxList1;
    }
}