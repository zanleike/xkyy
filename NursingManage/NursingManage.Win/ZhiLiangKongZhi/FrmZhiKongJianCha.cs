using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using HursingManage.AL.ZhiLiangKongZhi;
using HursingManage.DBModel;
using HursingManage.AL;
using System.Threading;

namespace NursingManage.Win.ZhiLiangKongZhi
{
    public partial class FrmZhiKongJianCha : BaseListForm
    {
        public FrmZhiKongJianCha()
            : this(false)
        { }
        public FrmZhiKongJianCha(bool isKeShiQueRen = false)
        {
            InitializeComponent();
            this._IsKeShiQueRen = isKeShiQueRen;
        }

        readonly bool _IsKeShiQueRen = false; //是否护士长登陆进入的科室确认界面

        void SetFormType()
        {
            btnKeShiQueRen.Visible = _IsKeShiQueRen;
            tStripJianChaJieGuo.Visible = !_IsKeShiQueRen;
            tsJianChaQueRen.Visible = !_IsKeShiQueRen;
            btnJianChaLuRu.Visible = !IsHuShiZhangLogin && !_IsKeShiQueRen; //计划确认由护理部操作，需要判断所有检查项目都已检查完毕；
            btnJianChaLuRuQuXiao.Visible = btnJianChaLuRu.Visible;
            tsbtnManYiDuLuRu.Visible = IsHuLiBuLogin || IsAdminLogin;
        }

        ALZhiKongJianCha _AL;
        void BindDataByJihua()
        {
            var dt = _AL.GetDataByJiHua(txtSearchByJiHua.Text, _IsKeShiQueRen);
            dgvJiHuaKeShi.DataSource = dt;
        }
        void BindDataByJieGuo()
        {
            var model = dgvJiHuaKeShi.GetSelectedClassData<V_ZHIKONGJIHUA_KESHI>();
            if (model != null)
            {
                dgvJieGuo.DataSource = _AL.GetJieGuoData(model);
            }
        }
        void BindDataByNeiRong()
        {
            var model = dgvJiHuaKeShi.GetSelectedClassData<V_ZHIKONGJIHUA_KESHI>();
            if (model != null)
            {
                dgvNeiRong.DataSource = _AL.GetJiHuaNeiRong(model);
            }
        }

        private void FrmZhiKongJianCha_Load(object sender, EventArgs e)
        {
            SetFormType();
            _AL = new ALZhiKongJianCha();
            dgvJieGuo.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            col_JIANCHAJIEGUO.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            BindDataByJihua();
        }
        private void tsBtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnSearchByJiHua_Click(object sender, EventArgs e)
        {
            BindDataByJihua();
        }
        private void txtSearchByJiHua_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                BindDataByJihua();
            }
        }
        private void btnJianChaLuRu_Click(object sender, EventArgs e)
        {
            var model = dgvJiHuaKeShi.GetSelectedClassData<V_ZHIKONGJIHUA_KESHI>();
            if (model == null)
            {
                ShowMessage("没有选中任何质控计划");
                return;
            }
            var neiRongList = dgvNeiRong.DataSource as List<V_ZHIKONGJIHUA_NEIRONG>;
            if (neiRongList == null || neiRongList.Count == 0)
            {
                ShowMessage("检查内容未空，不可确认。");
                return;
            }
            if (neiRongList.Exists(s => s.SHIFOUJIANCHA != "是"))
            {
                ShowMessage("检查内容有未确认内容，不可确认。");
                return;
            }
            var jiHuaKeShiModel = _AL.GetJiHuaKeShiData(model.ID);
            if (jiHuaKeShiModel.SHIFOUJIANCHA != "是")
            {
                var jianChaRenList = neiRongList.Select(s => s.JIANCHAREN).ToArray().Distinct();

                var jcry = string.Join(",", jianChaRenList);
                var jcryArr = jcry.Split(',');
                var jcryDist = jcryArr.Distinct();
                var jcryStr = string.Join(",", jcryDist);
                jiHuaKeShiModel.JIANCHARENYUAN = jcryStr;
                jiHuaKeShiModel.JIANCHAKAISHISHIJIAN = neiRongList.Select(s => s.JIANCHASHIJIAN).Min().ToString("yyyy-MM-dd HH:mm:ss");
                jiHuaKeShiModel.JIANCHAJIESHUSHIJIAN = neiRongList.Select(s => s.JIANCHASHIJIAN).Max().ToString("yyyy-MM-dd HH:mm:ss");
            }
            FrmZhiKongJianChaLuRu frm = new FrmZhiKongJianChaLuRu(_AL.JianChaChuangJian, _AL.GetJianChaRenYuan, jiHuaKeShiModel);
            if (frm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                BindDataByJihua();
                ShowMessage("创建计划检查完成。");
            }
        }
        /// <summary>
        /// 计划取消确认
        /// </summary>
        private void btnJianChaLuRuQuXiao_Click(object sender, EventArgs e)
        {
            var model = dgvJiHuaKeShi.GetSelectedClassData<V_ZHIKONGJIHUA_KESHI>();
            if (model == null)
            {
                ShowMessage("没有选中任何质控计划");
                return;
            }
            if (model.SHIFOUJIANCHA == "否")
            {
                ShowMessage("当前记录未进行确认，不必取消");
                return;
            }
            if (!ShowQuestion("确实要对该计划进行取消确认吗？", "计划取消确认"))
            {
                return;
            }
            string errMsg;
            if (_AL.JiHuaQenRenQuXiao(model, out errMsg))
            {
                ShowMessage("取消确认成功。");
                BindDataByJihua();
            }
            else
            {
                ShowMessage(errMsg);
            }
        }

        private void dgvJiHuaKeShi_SelectionChangedAndCellClick(object sender, DataGridViewCellEventArgs e)
        {
            BindDataByJieGuo();
            BindDataByNeiRong();
        }
        private void btnWenTiXuanZe_Click(object sender, EventArgs e)
        {
            var model = dgvJiHuaKeShi.GetSelectedClassData<V_ZHIKONGJIHUA_KESHI>();
            if (model == null)
            {
                ShowMessage("没有选中任何质控计划");
                return;
            }
            List<T_ZHILIANGBIAOZHUN> biaoZhunList = _AL.GetBiaoZhunData(model);
            FrmZhiLiangBiaoZhunXuanZe frm = new FrmZhiLiangBiaoZhunXuanZe(SaveWenTiXiang, biaoZhunList);
            if (frm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                //BindDataByJihua();
                BindDataByJieGuo();
            }
        }
        bool SaveWenTiXiang(List<T_ZHILIANGBIAOZHUN> wenTiXiang, out string errMsg)
        {
            var jiHuaModel = dgvJiHuaKeShi.GetSelectedClassData<V_ZHIKONGJIHUA_KESHI>();
            if (jiHuaModel == null)
            {
                errMsg = "当前选中的计划科室为空！";
                return false;
            }
            return _AL.BaoCunWenTiXiang(jiHuaModel, wenTiXiang, out errMsg);
        }
        private void tsbtnYiChuWenTi_Click(object sender, EventArgs e)
        {
            var jieGuo = dgvJieGuo.GetSelectedClassData<T_ZHIKONGJIHUA_JIEGUO>();
            if (jieGuo == null)
            {
                ShowMessage("没有选中任何记录！");
                return;
            }
            if (jieGuo.OPERATORID != _AL.CurrentLoginUser.ID)
            {
                ShowMessage("不能修改其他人创建的问题项。");
                return;
            }
            var jiHuaModel = dgvJiHuaKeShi.GetSelectedClassData<V_ZHIKONGJIHUA_KESHI>();
            if (jiHuaModel == null)
            {
                ShowMessage("未选中任何计划，数据可能出现错误！");
                return;
            }
            if (!ShowQuestion("确认要移除所选中的问题记录吗？", "移除确认")) return;
            string errMsg;
            if (_AL.YiChuWenTi(jiHuaModel, jieGuo, out errMsg))
            {
                ShowMessage("移除问题项完成。");
                BindDataByJieGuo();
            }
            else
            {
                ShowMessage(errMsg);
            }
        }
        private void tsbtnBianJiShuoMing_Click(object sender, EventArgs e)
        {
            var model = dgvJieGuo.GetSelectedClassData<T_ZHIKONGJIHUA_JIEGUO>();
            if (model.OPERATORID != _AL.CurrentLoginUser.ID)
            {
                ShowMessage("不能修改其他人创建的问题项。");
                return;
            }
            FrmZhiKongJianChaShuoMingEdit frm = new FrmZhiKongJianChaShuoMingEdit(model, _AL.BaoCunWenTiXiangShuoMing);
            if (frm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                ShowMessage("编辑说明完成。");
                BindDataByJieGuo();
            }
        }

        private void btnJianChaQueRen_Click(object sender, EventArgs e)
        {
            V_ZHIKONGJIHUA_KESHI jiHuaKeShi = dgvJiHuaKeShi.GetSelectedClassData<V_ZHIKONGJIHUA_KESHI>();
            if (jiHuaKeShi == null)
            {
                ShowMessage("当前选中记录为空。");
                return;
            }
            if (jiHuaKeShi.SHIFOUJIANCHA != "是")
            {
                ShowMessage("未检查项目不可确认。");
                return;
            }
            var jianChaJieGuo = dgvJieGuo.DataSource as List<T_ZHIKONGJIHUA_JIEGUO>;
            FrmZhiKongJianChaQueRenEdit frm = new FrmZhiKongJianChaQueRenEdit(_AL.SaveJianChaShuoMing, jianChaJieGuo, jiHuaKeShi);
            if (frm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                BindDataByJihua();
            }
        }

        private void tsbtnLeiBieQueRen_Click(object sender, EventArgs e)
        {
            var model = dgvNeiRong.GetSelectedClassData<V_ZHIKONGJIHUA_NEIRONG>();
            if (model == null)
            {
                ShowMessage("未选中要确认的记录。");
                return;
            }
            if (model.SHIFOUJIANCHA == "是")
            {
                ShowMessage("该检查已经确认。");
                return;
            }
            //if (!ShowQuestion("确实要对 {0} 进行确认吗？", "检查内容确认", model.BIAOZHUNLEIBIE))
            //{
            //    return;
            //}
            _AL.GetJianChaJieGuo(model);
            FrmZhiKongJianChaQueRenNeiRong frm = new FrmZhiKongJianChaQueRenNeiRong(
                model, _AL.GetJianChaRenYuan, _AL.JianChaNeiRongQueRen);
            if (frm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                ShowMessage("确认完成。");
                BindDataByNeiRong();
            }
        }

        private void tsbtnLeiBieQueRenQuXiao_Click(object sender, EventArgs e)
        {
            var model = dgvNeiRong.GetSelectedClassData<T_ZHIKONGJIHUA_NEIRONG>();
            if (model == null)
            {
                ShowMessage("未选中要取消确认的记录。");
                return;
            }
            if (model.SHIFOUJIANCHA == "否")
            {
                ShowMessage("该检查未进行过确认。");
                return;
            }
            if (!ShowQuestion("确实要对 {0} 进行取消确认吗?", "取消内容确认", model.BIAOZHUNLEIBIE))
            {
                return;
            }
            string errMsg;
            if (_AL.JianChaNeiRongQueRenQuXiao(model, out errMsg))
            {
                ShowMessage("取消确认完成。");
                BindDataByNeiRong();
            }
            else
            {
                ShowMessage(errMsg);
            }
        }

        private void dgvJiHuaKeShi_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            for (int i = 0; i < dgvJiHuaKeShi.SelectedRows.Count; i++)
            {
                dgvJiHuaKeShi.SelectedRows[i].Selected = false;
            }
        }

        private void tsbtnPrint_Click(object sender, EventArgs e)
        {
            var jiLuModel = dgvJiHuaKeShi.GetSelectedClassData<V_ZHIKONGJIHUA_KESHI>();
            if (jiLuModel == null)
            {
                ShowMessage("请选中一条要打印的检查记录!");
                return;
            }
            var neiRongList = dgvNeiRong.DataSource as List<V_ZHIKONGJIHUA_NEIRONG>;
            var jieGuoList = dgvJieGuo.DataSource as List<T_ZHIKONGJIHUA_JIEGUO>;
            PrintHelper.ZhiKongJiLu(jiLuModel, neiRongList, jieGuoList);
        }

        private void tsbtnManYiDuLuRu_Click(object sender, EventArgs e)
        {
            var jiLuModel = dgvJiHuaKeShi.GetSelectedClassData<V_ZHIKONGJIHUA_KESHI>();
            if (jiLuModel == null)
            {
                ShowMessage("未选中任何计划记录");
                return;
            }
            FrmZhiKongJiHuaManYiDuLuRu frm = new FrmZhiKongJiHuaManYiDuLuRu(jiLuModel, _AL.ManYiDuLuRu);
            if (frm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                ShowMessage("满意度调查结果录入完成。");
                BindDataByJihua();
            }
        }
    }
}