using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using HursingManage.AL.PeiXuNGuanLi;
using HursingManage.DBModel;
using HursingManage.AL;

namespace NursingManage.Win.PeiXunGuanLi
{
    public partial class FrmPeiXunJiHua : BaseListForm
    {
        public FrmPeiXunJiHua()
        {
            InitializeComponent();
        }
        ALPeiXunJiHua _AL;
        void BindDataByJiHua()
        {
            DataTable dt = _AL.GetData(tsTxtSearchValue.Text);
            dgvJiHua.DataSource = dt;
            dgvKeShi.DataSource = null;
            dgvMuBan.DataSource = null;
        }
        void BindDataByMuBan()
        { 
            var jiHuaModel = dgvJiHua.GetSelectedClassData<T_PEIXUNJIHUA>();
            if (jiHuaModel!=null)
            {
                DataTable dt = _AL.GetMuBanData(jiHuaModel);
                dgvMuBan.DataSource = dt;
            }
        }
        void BindDataByKeShi()
        {
            var jiHuaModel = dgvJiHua.GetSelectedClassData<T_PEIXUNJIHUA>();
            if (jiHuaModel != null)
            {
                DataTable dt = _AL.GetPeiXunKeShiData(jiHuaModel);
                dgvKeShi.DataSource = dt;
            }
        }

        private void FrmPeiXunJiHua_Load(object sender, EventArgs e)
        {
            _AL = new ALPeiXunJiHua();            
        }
        private void tsBtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void tsBtnAdd_Click(object sender, EventArgs e)
        {   
            FrmPeiXunJiHuaEdit frm = new FrmPeiXunJiHuaEdit(_AL.Add, null);
            if (frm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                BindDataByJiHua();
            }
        }
        private void tsbtnEdit_Click(object sender, EventArgs e)
        {
            var model = dgvJiHua.GetSelectedClassData<T_PEIXUNJIHUA>();
            if (model == null)
            {
                ShowMessage("没有选中任何要修改的记录!");
                return;
            }
            FrmPeiXunJiHuaEdit frm = new FrmPeiXunJiHuaEdit(_AL.Update, model);
            if (frm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                ShowMessage("修改完成!");
                BindDataByJiHua();
            }
        }
        private void tsBtnDelete_Click(object sender, EventArgs e)
        {
            var model = dgvJiHua.GetSelectedClassData<T_PEIXUNJIHUA>();
            if (model == null)
            {
                ShowMessage("没有选中任何要修改的记录!");
                return;
            }
            if (!ShowQuestion("确实要删除当前选中记录吗?", "删除确认")) return;
            string errMsg;
            if (_AL.Delete(model, out errMsg))
            {
                ShowMessage("删除完成");
                BindDataByJiHua();
            }
            else
            {
                ShowMessage("删除失败," + errMsg);
            }
        }
        private void tsBtnSearch_Click(object sender, EventArgs e)
        {
            BindDataByJiHua();
        }
        private void tsTxtSearchValue_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                tsBtnSearch_Click(sender, e);
            }
        }
        private void tsbtnADSearch_Click(object sender, EventArgs e)
        {
            AdvanceSearchConfig.ShowAdvanceSearchForm<T_PEIXUNJIHUA>(this, _AL, dgvJiHua);
        }

        private void btnTianJiaMuBan_Click(object sender, EventArgs e)
        {
            var jiHuaModel = dgvJiHua.GetSelectedClassData<T_PEIXUNJIHUA>();
            if (jiHuaModel==null)
            {
                ShowMessage("没有选中任何培训计划记录!");
                return;
            }
            DataTable dt = _AL.GetXuanZeMuBanData(jiHuaModel);
            FrmMuBanXuanXe frm = new FrmMuBanXuanXe(dt);
            frm.OnSelectedHandle += (muBanList) => 
            { 
                string errMsg;
                if (_AL.SaveMuBanToJiHua(jiHuaModel, muBanList,out errMsg))
                {
                    ShowMessage("添加模板成功。");
                    BindDataByMuBan();
                }
                else
                {
                    ShowMessage(errMsg);
                }
                
            };
            frm.ShowDialog();
        }
        private void btnYiChuMuBan_Click(object sender, EventArgs e)
        {
            var muBanModel = dgvMuBan.GetSelectedClassData<T_PEIXUNJIHUA_MUBAN>();
            if (muBanModel == null)
            {
                ShowMessage("没有选中任何模板记录!");
                return;
            }
            if (!ShowQuestion("确实要移除当前选中记录吗？", "移除确认")) return;
            string errMsg;
            if (_AL.YiChuMuBan(muBanModel, out errMsg))
            {
                ShowMessage("移除模板分类成功");
                BindDataByMuBan();
            }
            else
            {
                ShowMessage(errMsg);
            }
        }

        private void tsbtnKaiQiKaoShi_Click(object sender, EventArgs e)
        {
            var muBanModel = dgvMuBan.GetSelectedClassData<T_PEIXUNJIHUA_MUBAN>();
            if (muBanModel == null)
            {
                ShowMessage("没有选中任何模板记录!");
                return;
            }
            string errMsg;
            if (_AL.KaiQiKaoShi(muBanModel, out errMsg))
            {
                ShowMessage("开启考试成功。");
                BindDataByMuBan();
            }
            else
            {
                ShowMessage(errMsg);
            }
        }

        private void tsbtnGuanBiKaoShi_Click(object sender, EventArgs e)
        {
            var muBanModel = dgvMuBan.GetSelectedClassData<T_PEIXUNJIHUA_MUBAN>();
            if (muBanModel == null)
            {
                ShowMessage("没有选中任何模板记录!");
                return;
            }
            string errMsg;
            if (_AL.GuanBiKaoShi(muBanModel, out errMsg))
            {
                ShowMessage("关闭考试成功。");
                BindDataByMuBan();
            }
            else
            {
                ShowMessage(errMsg);
            }
        }

        private void btnXuanZeKeShi_Click(object sender, EventArgs e)
        {
            var jiHuaModel = dgvJiHua.GetSelectedClassData<T_PEIXUNJIHUA>();
            if (jiHuaModel==null)
            {
                ShowMessage("没有选中任何培训计划记录!");
                return;
            }
            List<T_KESHI> keShiList = _AL.GetXuanZeKeShiData(jiHuaModel);
            FrmKeShiXuanZeTree frm = new FrmKeShiXuanZeTree(SaveKeShiToJiHua, keShiList);
            if (frm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                ShowMessage("添加科室到计划完成。");
                BindDataByKeShi();
            }
        }
        bool SaveKeShiToJiHua(List<T_KESHI> keShiList, out string errMsg)
        { 
             var jiHuaModel = dgvJiHua.GetSelectedClassData<T_PEIXUNJIHUA>();
            return _AL.SaveKeShiToJiHua(jiHuaModel, keShiList,out errMsg);
        }

        private void btnYiChuKeShi_Click(object sender, EventArgs e)
        {
            var keShiModel = dgvKeShi.GetSelectedClassData<T_PEIXUNJIHUA_KESHI>();
            if (keShiModel == null)
            {
                ShowMessage("没有选中任何科室记录!");
                return;
            }
            if (!ShowQuestion("确实要移除当前选中记录吗？", "移除确认")) return;
            string errMsg;
            if (_AL.YiChuKeShi(keShiModel, out errMsg))
            {
                ShowMessage("移除科室成功");
                BindDataByKeShi();
            }
            else
            {
                ShowMessage(errMsg);
            }
        }

        private void dgvJiHua_SelectionChangedAndCellClick(object sender, DataGridViewCellEventArgs e)
        {
            BindDataByKeShi();
            BindDataByMuBan();
        }

       

        
    }
}