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
using NursingManage.Win.XiTongGuanLi;

namespace NursingManage.Win.ZhiLiangKongZhi
{
    public partial class FrmZhiKongJiHua : BaseListForm
    {
        public FrmZhiKongJiHua()
        {
            InitializeComponent();
        }
        T_ZHIKONGJIHUA _SelectedJiHuaModel; //当前选中的计划model
        ALZhiKongJiHua _AL;
        void BindDataByJiHua()
        {
            var dt = _AL.GetDataByJiHua(txtSearchByJiHua.Text);
            dgvJiHua.DataSource = dt;
            dgvKeShi.DataSource = null;
            dgvNeiRong.DataSource = null;
        }
        void BindDataByKeShi()
        {
            var jiHuaModel = dgvJiHua.GetSelectedClassData<T_ZHIKONGJIHUA>();
            if (jiHuaModel != null)
            {
                dgvKeShi.DataSource = _AL.GetDataByJiHuakeShi(jiHuaModel);
            }
        }
        void BindDataByNeiRong()
        {
            var jiHuaModel = dgvJiHua.GetSelectedClassData<T_ZHIKONGJIHUA>();
            if (jiHuaModel != null)
            {
                dgvNeiRong.DataSource = _AL.GetDataByNeiRong(jiHuaModel);
            }
        }

        private void FrmZhiKongJiHua_Load(object sender, EventArgs e)
        {
            _AL = new ALZhiKongJiHua();
        }
        private void tsBtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddByJiHua_Click(object sender, EventArgs e)
        {
            FrmZhiKongJiHuaEdit frm = new FrmZhiKongJiHuaEdit(_AL.AddJiHua);
            if (frm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                ShowMessage("新增计划完成。");
                BindDataByJiHua();
            }
        }
        private void btnEditByJiHua_Click(object sender, EventArgs e)
        {
            var jiHuaModel = dgvJiHua.GetSelectedClassData<T_ZHIKONGJIHUA>();
            if (jiHuaModel == null)
            {
                ShowMessage("没有选中任何记录。");
                return;
            }
            FrmZhiKongJiHuaEdit frm = new FrmZhiKongJiHuaEdit(_AL.UpdateJiHua, jiHuaModel);
            if (frm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                ShowMessage("修改计划完成。");
                BindDataByJiHua();
            }
        }
        private void btnDeleteByjiHua_Click(object sender, EventArgs e)
        {
            var jiHuaModel = dgvJiHua.GetSelectedClassData<T_ZHIKONGJIHUA>();
            if (jiHuaModel == null)
            {
                ShowMessage("没有选中任何记录。");
                return;
            }
            if (!ShowQuestion("确实要删除当前选中记录吗？", "删除确认")) return;
            string errMsg;
            if (_AL.DeleteJiHua(jiHuaModel, out errMsg))
            {
                ShowMessage("删除成功！");
                BindDataByJiHua();
            }
            else
            {
                ShowMessage(errMsg);
            }
        }
        private void txtSearchByJiHua_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSearchByJiHua_Click(sender, e);
            }
        }
        private void btnSearchByJiHua_Click(object sender, EventArgs e)
        {
            BindDataByJiHua();
        }
        private void dgvJiHua_SelectionChangedAndCellClick(object sender, DataGridViewCellEventArgs e)
        {   
            BindDataByKeShi();
            BindDataByNeiRong();
        }
        
        //private void btnKeShiDaoRu_Click(object sender, EventArgs e)
        //{
        //    _SelectedJiHuaModel = dgvJiHua.GetSelectedClassData<T_ZHIKONGJIHUA>();
        //    if (_SelectedJiHuaModel == null)
        //    {
        //        ShowMessage("没有选中任何记录。");
        //        return;
        //    }
        //    var dt = _AL.GetDataByKeShi(_SelectedJiHuaModel);
        //    FrmKeShiXuanZe frm = new FrmKeShiXuanZe(dt);
        //    frm.OnSelectedHandle += new Action<List<T_KESHI>>(KeShiXuanZe_OnSelectedHandle);
        //    frm.ShowDialog();
        //}
        //void KeShiXuanZe_OnSelectedHandle(List<T_KESHI> keShiList)
        //{
        //    _AL.DaoRuJiHuaKeShi(_SelectedJiHuaModel, keShiList);
        //    BindDataByKeShi();
        //}
        private void btnKeShiDaoRu_Click(object sender, EventArgs e)
        {
            _SelectedJiHuaModel = dgvJiHua.GetSelectedClassData<T_ZHIKONGJIHUA>();
            if (_SelectedJiHuaModel == null)
            {
                ShowMessage("没有选中任何培训计划记录!");
                return;
            }
            List<T_KESHI> keShiList = _AL.GetDataByKeShi(_SelectedJiHuaModel);

            FrmKeShiXuanZeTree frm = new FrmKeShiXuanZeTree(SaveKeShiToJiHua, keShiList);
            if (frm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                ShowMessage("添加科室到计划完成。");
                BindDataByKeShi();
            }
        }
        bool SaveKeShiToJiHua(List<T_KESHI> keShiList, out string errMsg)
        {
            _AL.DaoRuJiHuaKeShi(_SelectedJiHuaModel, keShiList);
            errMsg = null;
            return true;
        }

        private void btnKeShiYiChu_Click(object sender, EventArgs e)
        {
            var model = dgvKeShi.GetSelectedClassData<T_ZHIKONGJIHUA_KESHI>();
            if (model == null)
            {
                ShowMessage("没有选中任何记录。");
                return;
            }
            if (!ShowQuestion("确认要移除所选择记录吗？", "移除确认")) return;
            string errMsg;
            if (_AL.YiChuJiHuaKeshi(model, out errMsg))
            {
                ShowMessage("移除完成。");
                BindDataByKeShi();
            }
            else
            {
                ShowMessage(errMsg);
            }
        }

        private void btnNeiRongDaoRu_Click(object sender, EventArgs e)
        {
            if (dgvKeShi.Rows.Count == 0)
            {
                ShowMessage("请先添加计划内容科室。");
                return;
            }
            _SelectedJiHuaModel = dgvJiHua.GetSelectedClassData<T_ZHIKONGJIHUA>();
            if (_SelectedJiHuaModel == null)
            {
                ShowMessage("没有选中任何记录。");
                return;
            }
            var dt = _AL.GetDataByBiaoZhunLeiBie(_SelectedJiHuaModel);
            FrmBiaoZhunLeiBieXuanZe frm = new FrmBiaoZhunLeiBieXuanZe(dt);
            frm.OnSelectedHandle += new Action<List<T_ZHILIANGBIAOZHUN_LEIBIE>>(BiaoZhunLeiBie_OnSelectedHandle);
            frm.ShowDialog();
        }

        void BiaoZhunLeiBie_OnSelectedHandle(List<T_ZHILIANGBIAOZHUN_LEIBIE> leiBieList)
        {
            _AL.DaoRuBiaoZhunLeiBie(_SelectedJiHuaModel, leiBieList);
            BindDataByNeiRong();
        }

        private void tsBtnNeiRongYiChu_Click(object sender, EventArgs e)
        {
            var model = dgvNeiRong.GetSelectedClassData<V_ZHIKONGJIHUA_BIAOZHUN>();
            if (model == null)
            {
                ShowMessage("没有选中任何记录。");
                return;
            }
            if (!ShowQuestion("确认要移除所选择记录吗？", "移除确认")) return;
            string errMsg;
            if (_AL.YiChuNeiRong(model, out errMsg))
            {
                ShowMessage("移除完成。");
                BindDataByNeiRong();
            }
            else
            {
                ShowMessage(errMsg);
            }
        }
    }
}