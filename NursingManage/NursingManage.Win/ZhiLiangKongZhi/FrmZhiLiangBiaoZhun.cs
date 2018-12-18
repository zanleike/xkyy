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
using Framework.Common.CommonFunction;
using NursingManage.Win.XiTongGuanLi;

namespace NursingManage.Win.ZhiLiangKongZhi
{
    public partial class FrmZhiLiangBiaoZhun : BaseListForm
    {
        public FrmZhiLiangBiaoZhun()
        {
            InitializeComponent();
        }
        ALZhiLiangBiaoZhun _AL;
        void BindDataByLeiBie()
        {
            string searchValue = txtSearchByLeiBie.Text;
            DataTable dt = _AL.GetDataByLeiBie(searchValue);
            dgvLeiBie.DataSource = dt;
            dgvNeiRong.DataSource = null;
        }
        void BindDataByNeiRong()
        {
            var leiBieModel = dgvLeiBie.GetSelectedClassData<T_ZHILIANGBIAOZHUN_LEIBIE>();
            if (leiBieModel == null) return;
            string searchValue = txtSearchByNeiRong.Text;
            DataTable dt = _AL.GetDataByNeiRong(leiBieModel, searchValue);
            dgvNeiRong.DataSource = dt;
        }
        void BindDataByRenYuan()
        {
            var leiBieModel = dgvLeiBie.GetSelectedClassData<T_ZHILIANGBIAOZHUN_LEIBIE>();
            if (leiBieModel == null) return;
            string searchValue = txtSearchByNeiRong.Text;
            DataTable dt = _AL.GetDataByQuanXianRenYuan(leiBieModel);
            dgvQuanXianRenYuan.DataSource = dt;
        }

        private void FrmZhiLiangBiaoZhun_Load(object sender, EventArgs e)
        {
            _AL = new ALZhiLiangBiaoZhun();
            col_KeShi.Visible = IsAdminLogin;
            grpQuanXian.Visible = !IsHuShiZhangLogin;
            if (IsHuShiZhangLogin)
            {
                this.Text = string.Format("质控标准（{0}）", KeShi);
            }
            BindDataByLeiBie();
        }
        private void tsBtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnAddByLeiBie_Click(object sender, EventArgs e)
        {
            FrmZhiLiangBiaoZhunEditByLeiBie frm = new FrmZhiLiangBiaoZhunEditByLeiBie(_AL.AddByLeiBie);
            if (frm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                ShowMessage("增加类别成功");
                BindDataByLeiBie();
            }
        }
        private void btnEditByLeiBie_Click(object sender, EventArgs e)
        {
            var leiBieModel = dgvLeiBie.GetSelectedClassData<T_ZHILIANGBIAOZHUN_LEIBIE>();
            if (leiBieModel == null)
            {
                ShowMessage("没有选中任何记录.");
                return;
            }
            FrmZhiLiangBiaoZhunEditByLeiBie frm = new FrmZhiLiangBiaoZhunEditByLeiBie(_AL.UpdateByLeiBie, leiBieModel);
            if (frm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                ShowMessage("修改类别成功");
                BindDataByLeiBie();
            }
        }
        private void btnDeleteByLeiBie_Click(object sender, EventArgs e)
        {
            var model = dgvLeiBie.GetSelectedClassData<T_ZHILIANGBIAOZHUN_LEIBIE>();
            if (model == null)
            {
                ShowMessage("没有选中任何要修改的记录!");
                return;
            }
            if (!ShowQuestion("确实要删除当前选中记录吗?", "删除确认")) return;
            string errMsg;
            if (_AL.DeleteByLeiBie(model, out errMsg))
            {
                ShowMessage("删除完成");
                BindDataByLeiBie();
            }
            else
            {
                ShowMessage("删除失败," + errMsg);
            }
        }
        private void txtSearchByLeiBie_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSearchByLeiBie_Click(sender, e);
            }
        }
        private void btnSearchByLeiBie_Click(object sender, EventArgs e)
        {
            BindDataByLeiBie();
        }
        private void dgvLeiBie_SelectionChangedAndCellClick(object sender, DataGridViewCellEventArgs e)
        {
            BindDataByNeiRong();
            BindDataByRenYuan();
        }

        private void btnAddByNeiRong_Click(object sender, EventArgs e)
        {
            var leiBieModel = dgvLeiBie.GetSelectedClassData<T_ZHILIANGBIAOZHUN_LEIBIE>();
            if (leiBieModel == null)
            {
                ShowMessage("请先选中一个类别。");
                return;
            }
            T_ZHILIANGBIAOZHUN model = new T_ZHILIANGBIAOZHUN();
            model.LEIBIEID = leiBieModel.ID;
            model.LEIBIE = leiBieModel.MINGCHENG;
            FrmZhiLiangBiaoZhunEdit frm = new FrmZhiLiangBiaoZhunEdit(_AL.AddByNeiRong, model);
            if (frm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                ShowMessage("新增标准完成.");
                BindDataByNeiRong();
                _AL.WeiHuBiaoZhunShu(leiBieModel);
            }
        }
        private void btnEditByNeiRong_Click(object sender, EventArgs e)
        {
            var model = dgvNeiRong.GetSelectedClassData<T_ZHILIANGBIAOZHUN>();
            if (model == null)
            {
                ShowMessage("未选中任何记录.");
                return;
            }
            FrmZhiLiangBiaoZhunEdit frm = new FrmZhiLiangBiaoZhunEdit(_AL.UpdateByNeiRong, model);
            if (frm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                ShowMessage("新增标准完成.");
                BindDataByNeiRong();

               

            }
        }
        private void btnDeleteByNeiRong_Click(object sender, EventArgs e)
        {
            _ImportLeiBie = dgvLeiBie.GetSelectedClassData<T_ZHILIANGBIAOZHUN_LEIBIE>();
            if (_ImportLeiBie == null)
            {
                ShowMessage("请先选中一个类别。");
                return;
            }
            var model = dgvNeiRong.GetSelectedClassData<T_ZHILIANGBIAOZHUN>();
            if (model == null)
            {
                ShowMessage("没有选中任何要修改的记录!");
                return;
            }
            if (!ShowQuestion("确实要删除当前选中记录吗?", "删除确认")) return;
            string errMsg;
            if (_AL.DeleteByNeiRong(model, out errMsg))
            {
                ShowMessage("删除完成");
                _AL.WeiHuBiaoZhunShu(_ImportLeiBie);
                BindDataByNeiRong();
            }
            else
            {
                ShowMessage("删除失败," + errMsg);
            }
        }
        private void txtSearchByNeiRong_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSearchByNeiRong_Click(sender, e);
            }
        }
        private void btnSearchByNeiRong_Click(object sender, EventArgs e)
        {
            BindDataByNeiRong();
        }

        T_ZHILIANGBIAOZHUN_LEIBIE _ImportLeiBie = null; //用于保存上次导入的类别，减少反射次数
        bool ImportAdd(DataRow item, out string errMsg)
        {
            T_ZHILIANGBIAOZHUN model = new T_ZHILIANGBIAOZHUN();
            model.LEIBIE = _ImportLeiBie.MINGCHENG;
            model.LEIBIEID = _ImportLeiBie.ID;
            model.XUHAO = Utils.ConvertDataRow<int>(item, "序号");
            model.LEIXING1 = Utils.ConvertDataRow<string>(item, "标准类型1");
            model.LEIXING2 = Utils.ConvertDataRow<string>(item, "标准类型2");
            model.NEIRONG = Utils.ConvertDataRow<string>(item, "标准内容");
            return _AL.AddByNeiRong(model, out errMsg);
        }
        private void btnDaoRuBiaoZhun_Click(object sender, EventArgs e)
        {
            _ImportLeiBie = dgvLeiBie.GetSelectedClassData<T_ZHILIANGBIAOZHUN_LEIBIE>();
            if (_ImportLeiBie == null)
            {
                ShowMessage("请先选中一个类别。");
                return;
            }
            FrmExcelImport impFrm = new FrmExcelImport(ImportAdd);
            impFrm.Text = string.Format("向类别：{0} 中导入标准", _ImportLeiBie.MINGCHENG);
            impFrm.ShowDialog();
            _AL.WeiHuBiaoZhunShu(_ImportLeiBie);
            _ImportLeiBie = null;
        }

        private void btnZengJiaRenYuan_Click(object sender, EventArgs e)
        {
            _ImportLeiBie = dgvLeiBie.GetSelectedClassData<T_ZHILIANGBIAOZHUN_LEIBIE>();
            if (_ImportLeiBie == null)
            {
                ShowMessage("请先选中一个标准类别。");
                return;
            }
            //增加标准对应的操作人员
            DataTable dt = _AL.GetRenYuanData(_ImportLeiBie);
            FrmYongHuXuanZe frm = new FrmYongHuXuanZe(dt);
            frm.OnSelectedHandle += new Action<List<T_USER_INFO>>(frm_OnSelectedHandle);
            if (frm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                BindDataByRenYuan();
            }
        }

        void frm_OnSelectedHandle(List<T_USER_INFO> userList)
        {
            string errMsg;
            bool r = _AL.SaveRenYuanQuanXian(_ImportLeiBie, userList, out errMsg);
        }

        private void btnYiChuRenYuan_Click(object sender, EventArgs e)
        {
            //移除标准对应的操作人员
            var model = dgvQuanXianRenYuan.GetSelectedClassData<T_ZHILIANGBIAOZHUN_QUANXIAN>();
            if (model == null)
            {
                ShowMessage("未选中任何记录");
                return;
            }
            if (ShowQuestion("确实要移除当前所选中人员吗？", "移除人员确认"))
            {
                string errMsg;
                if (_AL.YiChuQuanXianRenYuan(model, out errMsg))
                {
                    BindDataByRenYuan();
                    ShowMessage("移除成功");
                }
                else
                {
                    ShowMessage(errMsg);
                }
            }
        }

        private void tsbtnImportKeShi_Click(object sender, EventArgs e)
        {
            var leiBie = dgvLeiBie.GetSelectedClassData<T_ZHILIANGBIAOZHUN_LEIBIE>();
            if (leiBie == null)
            {
                ShowMessage("请先选中一个标准类别。");
                return;
            }
            DataTable keShi = _AL.GetImportKeShi(leiBie);
            FrmKeShiXuanZe frm = new FrmKeShiXuanZe(keShi, true);
            frm.OnSelectedHandle += (keShiList) =>
            {
                _AL.SaveToKeShi(leiBie, keShiList);
                ShowMessage("复制到科室完成。");
                BindDataByLeiBie();
            };
            frm.ShowDialog();
            
        }

        private void tsbtnOutExcel_Click(object sender, EventArgs e)
        {
            DataTable dt = dgvNeiRong.DataSource as DataTable;
            if (dt.Rows.Count == 0)
            {
                ShowMessage("导出记录为空。");
                return;
            }
            string mingCheng = dt.Rows[0][T_ZHILIANGBIAOZHUN.CNLEIBIE].ToString();
            if (!ExcelOut.OutExcelByZhiLiangBiaoZhun(dt, mingCheng))
            {
                ShowMessage("导出失败。");
            }
            else
            {
                ShowMessage("导出成功");
            }
        }
    }
}