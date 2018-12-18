using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using HursingManage.AL.ZhiLiangKongZhi;
using HursingManage.DBModel;

namespace NursingManage.Win.ZhiLiangKongZhi
{
    public partial class FrmZhiKongJianCha_KeShi : BaseListForm
    {
        public FrmZhiKongJianCha_KeShi()
        {
            InitializeComponent();
        }

        ALKeShiZhiKong _AL;
        bool _IsAdSearch = false;
        string _LastSearchValue = null;

        void BindDataByJianCha()
        {
            int recordCount;
            _LastSearchValue = tsTxtSearchValue.Text;
            var dt = _AL.GetData(ucPage.OnePageCount, ucPage.PageNo, out recordCount, _LastSearchValue, _IsAdSearch);
            dgvJianChaKeShi.DataSource = dt;
            ucPage.InitiControl(recordCount);
            BindDataByNeiRong();
            BindDataByWenTi();
        }
        void BindDataByNeiRong()
        {
            var jianChaJiluModel = dgvJianChaKeShi.GetSelectedClassData<T_ZHIKONG_KESHI>();
            var data = _AL.GetNeiRongData(jianChaJiluModel);
            dgvNeiRong.DataSource = data;
        }
        void BindDataByWenTi()
        {
            var jianChaJiluModel = dgvJianChaKeShi.GetSelectedClassData<T_ZHIKONG_KESHI>();
            var data = _AL.GetJieGuoData(jianChaJiluModel);
            dgvJieGuo.DataSource = data;
        }

        private void FrmZhiKongJianCha_KeShi_Load(object sender, EventArgs e)
        {
            _AL = new ALKeShiZhiKong();
            //col_BIAOZHUN.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
        }

        private void tsBtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ucPage_PageChangedEvent(int pageNo, int onePageCount, out int recordCount)
        {
            var dt = _AL.GetData(onePageCount, pageNo, out recordCount, _LastSearchValue, _IsAdSearch);
            dgvJianChaKeShi.DataSource = dt;
        }

        private void tsbtnKeShiJianChaAdd_Click(object sender, EventArgs e)
        {
            FrmZhiKongJianCha_KeShi_ChuangJian frm = new FrmZhiKongJianCha_KeShi_ChuangJian(_AL.AddKeShiJianCha, null, _AL.GetKeShiRenYuan);
            if (frm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                ShowMessage("新增检查记录完成。");
                BindDataByJianCha();
            }
        }

        private void tsbtnKeShiJianChaEdit_Click(object sender, EventArgs e)
        {
            var model = dgvJianChaKeShi.GetSelectedClassData<T_ZHIKONG_KESHI>();
            if (model == null)
            {
                ShowMessage("未选中任何检查记录");
                return;
            }
            if (model.SHANGBAOZHUANGTAI == "是")
            {
                ShowMessage("已上报检查记录不能编辑。");
                return;
            }
            FrmZhiKongJianCha_KeShi_ChuangJian frm = new FrmZhiKongJianCha_KeShi_ChuangJian(_AL.UpdateKeShiJianCha, model, _AL.GetKeShiRenYuan);
            if (frm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                ShowMessage("修改检查记录完成。");
                BindDataByJianCha();
            }
        }

        private void tsbtnDeleteJianCha_Click(object sender, EventArgs e)
        {
            var model = dgvJianChaKeShi.GetSelectedClassData<T_ZHIKONG_KESHI>();
            if (model == null)
            {
                ShowMessage("未选中任何检查记录");
                return;
            }
            if (model.SHANGBAOZHUANGTAI == "是")
            {
                ShowMessage("已上报检查记录不能删除。");
                return;
            }
            if (!ShowQuestion("确实要删除选中的质控记录吗？该操作不可撤回", "删除质控记录确认"))
            {
                return;
            }
            string errMsg;
            if (_AL.DeleteKeShiJianCha(model, out errMsg))
            {
                ShowMessage("删除检查记录成功");
                BindDataByJianCha();
            }
            else
            {
                ShowMessage(errMsg);
            }
        }

        private void btnSearchByJiHua_Click(object sender, EventArgs e)
        {
            BindDataByJianCha();
        }

        private void tsTxtSearchValue_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSearchByJiHua_Click(sender, e);
            }
        }

        private void tsbtnTianJianBiaoZhun_Click(object sender, EventArgs e)
        {
            var keShiZhiKongModel = dgvJianChaKeShi.GetSelectedClassData<T_ZHIKONG_KESHI>();
            if (keShiZhiKongModel == null)
            {
                ShowMessage("请先选中一个检查记录");
                return;
            }
            if (keShiZhiKongModel.SHANGBAOZHUANGTAI == "是")
            {
                ShowMessage("当前选中的质控记录已经上报，不允许再添加检查内容。");
                return;
            }
            DataTable biaoZhunLeiBieList = _AL.GetBiaoZhunLeiBieData(keShiZhiKongModel);
            FrmZhiLiangBiaoZunLeiBieXuanZe frm = new FrmZhiLiangBiaoZunLeiBieXuanZe(biaoZhunLeiBieList);
            frm.OnSelectedHandle += (leiBieList) =>
            {
                string errMsg;
                if (_AL.AddBiaoZhunLeiBie(keShiZhiKongModel, leiBieList, out errMsg))
                {
                    BindDataByNeiRong();
                }
                else
                {
                    ShowMessage(errMsg);
                }
            };
            if (frm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                BindDataByNeiRong();
            }
        }
        private void tsbtnYiChuBiaoZhun_Click(object sender, EventArgs e)
        {
            var neiRongModel = dgvNeiRong.GetSelectedClassData<T_ZHIKONG_KESHI_NEIRONG>();
            if (neiRongModel == null)
            {
                ShowMessage("所选择检查内容为空");
                return;
            }
            if (!ShowQuestion("确认要移除当前选中的检查内容吗？", "移除检查内容确认"))
            {
                return;
            }
            string errMsg;
            if (_AL.RemoveBiaoZhunLeiBie(neiRongModel, out errMsg))
            {
                ShowMessage("移除内容完成。");
                BindDataByNeiRong();
            }
            else
            {
                ShowMessage(errMsg);
            }
        }

        private void tsbtnLeiBieQueRen_Click(object sender, EventArgs e)
        {
            var neiRongModel = dgvNeiRong.GetSelectedClassData<T_ZHIKONG_KESHI_NEIRONG>();
            if (neiRongModel == null)
            {
                ShowMessage("所选择检查内容为空");
                return;
            }
            var wenTiList = dgvJieGuo.DataSource as List<T_ZHIKONG_KESHI_WENTI>;
            StringBuilder questionStr = new StringBuilder();
            if (wenTiList != null && wenTiList.Count > 0)
            {
                if (wenTiList.Exists(s =>
                    s.BIAOZHUNLEIBIEID == neiRongModel.BIAOZHUNLEIBIEID &&
                    string.IsNullOrWhiteSpace(s.WENTISHUOMING)))
                {
                    ShowMessage("问题说明未全部填写！");
                    return;
                }
                else
                {
                    neiRongModel.WENTISHU = wenTiList.Count(s => s.BIAOZHUNLEIBIEID == neiRongModel.BIAOZHUNLEIBIEID);
                }
            }
            else
            {
                neiRongModel.WENTISHU = 0;
            }
            questionStr.AppendFormat("确实要对 {0} 进行检查确认吗？ \r\n标准数：{1}，问题数：{2}，合格率：{3}",
                    neiRongModel.BIAOZHUNLEIBIE,
                    neiRongModel.BIAOZHUNSHU.ToString("N0"),
                    neiRongModel.WENTISHU.ToString("N0"),
                    Math.Round((1 - neiRongModel.WENTISHU / neiRongModel.BIAOZHUNSHU) * 100, 2)
                    );
            if (!ShowQuestion(questionStr.ToString(), "检查内容确认")) return;
            string errMsg;
            if (_AL.NeiRongQueRen(neiRongModel, out errMsg))
            {
                ShowMessage("检查内容确认完成。");
                BindDataByNeiRong();
            }
            else
            {
                ShowMessage(errMsg);
            }
        }
        private void tsbtnLeiBieQueRenQuXiao_Click(object sender, EventArgs e)
        {

        }
        private void btnWenTiXuanZe_Click(object sender, EventArgs e)
        {
            var keShiZhiKong = dgvJianChaKeShi.GetSelectedClassData<T_ZHIKONG_KESHI>();
            if (keShiZhiKong == null)
            {
                ShowMessage("未选中记录！");
                return;
            }
            if (keShiZhiKong.SHANGBAOZHUANGTAI == "是")
            {
                ShowMessage("当前质控记录已经上报不允许再添加新项；");
                return;
            }
            var jianChaJiLuModel = dgvJianChaKeShi.GetSelectedClassData<T_ZHIKONG_KESHI>();
            if (jianChaJiLuModel == null || dgvNeiRong.RowCount == 0)
            {
                ShowMessage("未选定检查记录或检查内容为空。");
                return;
            }
            List<T_ZHILIANGBIAOZHUN> biaoZhunList = _AL.GetBiaoZhunData(jianChaJiLuModel);
            FrmZhiLiangBiaoZhunXuanZe frm = new FrmZhiLiangBiaoZhunXuanZe(BaoCunWenTiXiang, biaoZhunList);
            if (frm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                BindDataByWenTi();
                BindDataByNeiRong();
            }
        }
        bool BaoCunWenTiXiang(List<T_ZHILIANGBIAOZHUN> wenTiXiang, out string errMsg)
        {
            var neiRongModel = dgvJianChaKeShi.GetSelectedClassData<T_ZHIKONG_KESHI>();
            bool r = _AL.BaoCunWenTiXiang(neiRongModel, wenTiXiang, out errMsg);
            return r;
        }

        private void tsbtnYiChuWenTi_Click(object sender, EventArgs e)
        {
            var keShiZhiKong = dgvJianChaKeShi.GetSelectedClassData<T_ZHIKONG_KESHI>();
            if (keShiZhiKong.SHANGBAOZHUANGTAI == "是")
            {
                ShowMessage("当前质控记录已经上报不允许移除；");
                return;
            }
            var jieGuo = dgvJieGuo.GetSelectedClassData<T_ZHIKONG_KESHI_WENTI>();
            if (jieGuo == null)
            {
                ShowMessage("未选中任何问题项。");
                return;
            }
            if (!ShowQuestion("是否要移除当前选中问题项？该操作不可撤回", "移除问题项确认"))
            {
                return;
            }
            string errMsg;
            if (_AL.RemoveWenTi(jieGuo, out errMsg))
            {
                BindDataByWenTi();
                BindDataByNeiRong();
            }
            else
            {
                ShowMessage(errMsg);
            }
        }

        private void tsbtnBianJiShuoMing_Click(object sender, EventArgs e)
        {
            var keShiZhiKong = dgvJianChaKeShi.GetSelectedClassData<T_ZHIKONG_KESHI>();
            if (keShiZhiKong.SHANGBAOZHUANGTAI == "是")
            {
                ShowMessage("当前质控记录已经上报不允许再编辑问题说明；");
                return;
            }
            var jieGuo = dgvJieGuo.GetSelectedClassData<T_ZHIKONG_KESHI_WENTI>();
            if (jieGuo == null)
            {
                ShowMessage("未选中任何问题项。");
                return;
            }

            FrmZhiKongJianCha_KeShi_WenTiBianJi frm = new FrmZhiKongJianCha_KeShi_WenTiBianJi(_AL.BaoCunWenTiShuoMing, jieGuo);
            if (frm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                BindDataByWenTi();
            }
        }

        private void btnJieGuoShangBao_Click(object sender, EventArgs e)
        {
            var jianChaJiLu = dgvJianChaKeShi.GetSelectedClassData<T_ZHIKONG_KESHI>();
            FrmZhiKongJianCha_KeShi_QueRen frm = new FrmZhiKongJianCha_KeShi_QueRen(jianChaJiLu, dgvJieGuo.DataSource, _AL.ZhiKongJieGuoShangBao);
            if (frm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                BindDataByJianCha();
            }
        }

        private void dgvJianChaKeShi_SelectionChangedAndCellClick(object sender, DataGridViewCellEventArgs e)
        {
            BindDataByJianCha();
        }

        private void tsbtnPrint_Click(object sender, EventArgs e)
        {
            var jiLuModel = dgvJianChaKeShi.GetSelectedClassData<T_ZHIKONG_KESHI>();
            if (jiLuModel == null)
            {
                ShowMessage("请选中一条要打印的检查记录!");
                return;
            }
            List<T_ZHIKONG_KESHI_NEIRONG> neiRonList = dgvNeiRong.DataSource as List<T_ZHIKONG_KESHI_NEIRONG>;
            List<T_ZHIKONG_KESHI_WENTI> wenTiList = dgvJieGuo.DataSource as List<T_ZHIKONG_KESHI_WENTI>;
            PrintHelper.ZhiKongJiLuByKeShi(jiLuModel, neiRonList, wenTiList);
        }
    }
}