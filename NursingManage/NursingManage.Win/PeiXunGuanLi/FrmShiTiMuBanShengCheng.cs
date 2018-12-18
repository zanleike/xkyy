using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using HursingManage.AL.PeiXuNGuanLi;

namespace NursingManage.Win.PeiXunGuanLi
{
    public partial class FrmShiTiMuBanShengCheng : BaseEditForm
    {
        public FrmShiTiMuBanShengCheng(EditModelHandle<ALShiTiMuBan.ShengChengCanShu> SaveHandle)
        {
            InitializeComponent();
            this.SaveShengChengHandle = SaveHandle;
        }

        ALShiTiMuBan.ShengChengCanShu _Model;
        EditModelHandle<ALShiTiMuBan.ShengChengCanShu> SaveShengChengHandle;


        private void FrmShiTiMuBanShengCheng_Load(object sender, EventArgs e)
        {
            //coBoxDanXuan.SelectedIndex = 1;
            //coBoxDuoXuan.SelectedIndex = 1;
            //coBoxPanDuan.SelectedIndex = 1;
            //coBoxWenDa.SelectedIndex = 1;
            _Model = new ALShiTiMuBan.ShengChengCanShu();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            dcm1.SetValueToClassObj(_Model);
            string errMsg;
            string prompt = string.Format("单选题 数量：{0}，分数：{1}；\r\n多选题 数量：{2}，分数：{3}；\r\n判断题 数量：{4}，分数：{5}",
                _Model.DanXuanShuLiang, _Model.DanXuanFenShu, _Model.DuoXuanShuLiang, _Model.DuoXuanFenShu, _Model.PanDuanShuLiang, _Model.PanDuanFenShu);
            if (!ShowQuestion(prompt, "生成模板试题确认"))
            {
                return;
            }
            if (SaveShengChengHandle(_Model, out errMsg))
            {
                this.DialogResult = System.Windows.Forms.DialogResult.OK;
            }
            else
            {
                ShowMessage(errMsg);
            }
        }

        private void numDanXuan_ValueChanged(object sender, EventArgs e)
        {
            //var count = numDanXuan.Value + numDuoXuan.Value + numPanDuan.Value + numWenDa.Value;
            //txtResult.Text = string.Format("总共出题：{0} 道",count);
        }
    }
}