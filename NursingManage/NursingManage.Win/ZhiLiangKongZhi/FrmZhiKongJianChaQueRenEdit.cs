using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using HursingManage.DBModel;

namespace NursingManage.Win.ZhiLiangKongZhi
{
    public partial class FrmZhiKongJianChaQueRenEdit : BaseEditForm
    {
        public FrmZhiKongJianChaQueRenEdit(EditModelHandle<V_ZHIKONGJIHUA_KESHI> SaveJianChaShuoMing, List<T_ZHIKONGJIHUA_JIEGUO> jianChajieGuo, V_ZHIKONGJIHUA_KESHI jiHuaKeShi)
        {
            InitializeComponent();
            this._jianChajieGuo = jianChajieGuo;
            this._JiHuaKeShi = jiHuaKeShi;
            this.SaveJianChaShuoMing = SaveJianChaShuoMing;
        }
        /// <summary>
        /// 检查结果
        /// </summary>
        List<T_ZHIKONGJIHUA_JIEGUO> _jianChajieGuo;
        V_ZHIKONGJIHUA_KESHI _JiHuaKeShi;
        EditModelHandle<V_ZHIKONGJIHUA_KESHI> SaveJianChaShuoMing;

        private void FrmZhiKongJianChaQueRenEdit_Load(object sender, EventArgs e)
        {
            dgvJieGuo.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            col_JIANCHAJIEGUO.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            col_BIAOZHUN.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dgvJieGuo.DataSource = _jianChajieGuo;
            dcm1.SetControlValue(_JiHuaKeShi);
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnOK_Click(object sender, EventArgs e)
        {
            dcm1.SetValueToClassObj(_JiHuaKeShi);
            string errMsg;
            if (SaveJianChaShuoMing(_JiHuaKeShi, out errMsg))
            {
                this.DialogResult = System.Windows.Forms.DialogResult.OK;
            }
            else
            {
                ShowMessage(errMsg);
            }
        }
    }
}