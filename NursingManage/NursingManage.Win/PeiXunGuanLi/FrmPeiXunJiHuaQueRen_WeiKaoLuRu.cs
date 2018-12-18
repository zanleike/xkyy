using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using HursingManage.AL;
using HursingManage.DBModel;
using HursingManage.AL.PeiXuNGuanLi;

namespace NursingManage.Win.PeiXunGuanLi
{
    public partial class FrmPeiXunJiHuaQueRen_WeiKaoLuRu : BaseEditForm
    {
        public FrmPeiXunJiHuaQueRen_WeiKaoLuRu(V_PEIXUNJIHUA_KESHI keShiJiHuaModel)
        {
            InitializeComponent();
            this._KeShiJiHuaModel = keShiJiHuaModel;
        }
        /// <summary>
        /// 科室计划实体
        /// </summary>
        V_PEIXUNJIHUA_KESHI _KeShiJiHuaModel;

        ALPeiXunWeiKao _AL;

        private void FrmPeiXunJiHuaQueRen_WeiKaoLuRu_Load(object sender, EventArgs e)
        {
            _AL = new ALPeiXunWeiKao();
            int kaoShiRenShu = _AL.GetKaoShiRenShu(_KeShiJiHuaModel);
            int keShiRenShu = _AL.GetKeShiRenShu(_KeShiJiHuaModel);
            int weiKaoRenShu = keShiRenShu - kaoShiRenShu;
            txtKeShiRenShu.Text = keShiRenShu.ToString();
            txtKaoShiRenShu.Text = kaoShiRenShu.ToString();
            txtWeiKaoRenShu.Text = weiKaoRenShu.ToString();            
            dgv.DataSource = _AL.GetWeiKaoRenYuan(_KeShiJiHuaModel);
            txtZhuanChuRenShu.Text = Math.Abs(dgv.Rows.Count - weiKaoRenShu).ToString();
        }

        private void dgv_SelectionChangedAndCellClick(object sender, DataGridViewCellEventArgs e)
        {
            var sel = dgv.GetSelectedClassData<T_PEIXUNJIHUA_MINGXI_WEIKAO>();
            txtXingMing.Text = sel.XINGMING;
            txtYuanYin.Text = sel.YUANYIN;
        }

        private void btnBaoCunYuanYin_Click(object sender, EventArgs e)
        {
            //保存原因
            var sel = dgv.GetSelectedClassData<T_PEIXUNJIHUA_MINGXI_WEIKAO>();
            dgv.Rows[dgv.SelectedRows[0].Index].Cells[col_YuanYin.Index].Value = txtYuanYin.Text;
            dgv.EndEdit();
            ShowMessage("设置完成");
            //dgv.RefreshEdi();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            var weiKaoList = dgv.DataSource as List<T_PEIXUNJIHUA_MINGXI_WEIKAO>;
            string errMsg;
            if (_AL.BaoCunWeiKaoYuanYin(_KeShiJiHuaModel, weiKaoList, out errMsg))
            {
                this.DialogResult = System.Windows.Forms.DialogResult.OK;
            }
            else
            {
                ShowMessage(errMsg);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
