using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ZCJH.HursingManage.AL.XiTongGuanLi;
using ZCJH.HursingManage.DBModel;

namespace ZCJH.NursingManage.Win.XiTongGuanLi
{
    public partial class FrmKeShi : BaseListForm
    {
        public FrmKeShi()
        {
            InitializeComponent();
        }

        ALKeShi _AL;

        void BindDataSource()
        {
            string serValue = tsTxtSearchValue.Text;
            var r = _AL.GetData(serValue);
            dgvKeShi.DataSource = r;
        }
        void BindDataSourceUses()
        {
            var keShiIdObj = dgvKeShi.GetFirstSelectItem(col_KeShiID.Name);
            if (keShiIdObj != null)
            {
                string serValue = tsTxtUserSearch.Text;
                var dt = _AL.GetUserData(keShiIdObj.ToString(), true, serValue);
                dgvYongHu.DataSource = dt;
                return;
            }            
        }
        private void FrmKeShi_Load(object sender, EventArgs e)
        {
            _AL = new ALKeShi();
        }
        private void tsBtnAdd_Click(object sender, EventArgs e)
        {
            FrmKeShiEdit frm = new FrmKeShiEdit(_AL.Add, null);
            if (frm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                ShowMessage("新增完成");
                BindDataSource();
            }
        }

        private void tsBtnEdit_Click(object sender, EventArgs e)
        {
            var model = dgvKeShi.GetSelectedClassData<T_KESHI>();
            if (model == null)
            {
                ShowMessage("未选中任何行");
                return;
            }
            FrmKeShiEdit frm = new FrmKeShiEdit(_AL.Update, model);
            if (frm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                ShowMessage("修改完成");
                BindDataSource();
            }
        }

        private void tsBtnDelete_Click(object sender, EventArgs e)
        {
            var model = dgvKeShi.GetSelectedClassData<T_KESHI>();
            if (model == null)
            {
                ShowMessage("没有选中任何要删除的记录!");
                return;
            }
            if (!ShowQuestion("确实要删除当前选中记录吗?", "删除确认")) return;
            string errMsg;
            if (_AL.Delete(model, out errMsg))
            {
                ShowMessage("删除完成");
                BindDataSource();
            }
            else
            {
                ShowMessage("删除失败," + errMsg);
            }
        }

        private void tsBtnSearch_Click(object sender, EventArgs e)
        {
            BindDataSource();
        }

        private void tsTxtSearchValue_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                tsBtnSearch_Click(sender, e);
            }
        }

        private void tsBtnSelectUserInfo_Click(object sender, EventArgs e)
        {
            var keShiObj = dgvKeShi.GetSelectedClassData<T_KESHI>();
            if (keShiObj == null)
            {
                ShowMessage("请先选择科室;");
                return;
            }
            var dt = _AL.GetUserData(keShiObj.ID);
            FrmYongHuXuanZe frm2 = new FrmYongHuXuanZe(dt);
            frm2.Text = string.Format("科室:{0} 分配用户", keShiObj.MINGCHENG);
            frm2.OnSelectedHandle += (users) => 
            {
                StartRunWork(
                () =>
                {
                    //要执行的方法
                    _AL.SaveYongHuToKeShi(keShiObj.ID, users);
                }, () =>
                {
                    //执行完方法之后
                    BindDataSourceUses();
                });
            };
            frm2.ShowDialog();
        }

        private void tsBtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvKeShi_SelectionChangedAndCellClick(object sender, DataGridViewCellEventArgs e)
        {
            BindDataSourceUses();
        }

        private void tsBtnRemoveUser_Click(object sender, EventArgs e)
        {
            var userModel = dgvYongHu.GetSelectedClassData<T_USER_INFO>();
            if (userModel==null)
            {
                ShowMessage("未选中任何行;");
            }
            if (!ShowQuestion("确实要从当前科室中移除改人员吗??", "移除确认")) return;
            var keShiModel = dgvKeShi.GetSelectedClassData<T_KESHI>();
            if (keShiModel == null)
            {
                ShowMessage("未选中任何科室???");
                return;
            }
            _AL.RemoveUser(keShiModel, userModel);
            BindDataSourceUses();
        }

        private void tsbtnUserSearch_Click(object sender, EventArgs e)
        {
            BindDataSourceUses();
        }

        private void tsTxtUserSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                tsbtnUserSearch_Click(sender, e);
            }
        }
    }
}