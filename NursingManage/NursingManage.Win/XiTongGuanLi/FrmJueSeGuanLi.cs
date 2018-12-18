using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using HursingManage.AL.XiTongGuanLi;
using HursingManage.DBModel;
using Framework.WinCommon.TreeData;

namespace NursingManage.Win.XiTongGuanLi
{
    public partial class FrmJueSeGuanLi : BaseListForm
    {
        public FrmJueSeGuanLi()
        {
            InitializeComponent();
        }
        ALJueSeGuanLi _AL;
        void BindRoleData()
        {
            var r = _AL.GetRoleData(tsTxtSearchValue.Text);
            dgvRole.DataSource = r;
        }
        void BindRoleUserData(bool bindRoleMenu = false)
        {
            var model = dgvRole.GetSelectedClassData<T_ROLE>();
            if (model == null)
            {
                return;
            }
            string serValue = tsTxtUserSearch.Text;
            var dt = _AL.GetUserData(model, true, serValue);
            dgvYongHu.DataSource = dt;
            if (bindRoleMenu)
            {
                TreeViewHelper.SetAllCancelChecked(tvMenu);
                var roleMenu = _AL.GetRoleMenu(model);
                if (roleMenu != null)
                {
                    var keys = roleMenu.Select(s => s.MENUID).ToArray();
                    TreeViewHelper.SetCheckedState(tvMenu, keys, true);
                }
            }
        }
        void InitMenu(List<T_MENU> menuList, TreeNode pTn = null)
        {
            foreach (var item in menuList)
            {
                if (pTn == null)
                {
                    if (string.IsNullOrWhiteSpace(item.PID))
                    {
                        TreeNode tn = new TreeNode(item.MENUCAPTION);
                        tn.Name = item.ID;
                        tvMenu.Nodes.Add(tn);
                        tn.Tag = item;
                        InitMenu(menuList, tn);
                    }
                }
                else
                {
                    if (item.PID == pTn.Name)
                    {
                        TreeNode tn = new TreeNode(item.MENUCAPTION);
                        tn.Name = item.ID;
                        pTn.Nodes.Add(tn);
                        tn.Tag = item;
                        InitMenu(menuList, tn);
                    }
                }
            }
        }

        private void FrmJueSeGuanLi_Load(object sender, EventArgs e)
        {
            _AL = new ALJueSeGuanLi();
            List<T_MENU> menuList = _AL.GetMenuData();
            tvMenu.Nodes.Clear();
            InitMenu(menuList);
            TreeViewHelper.SetRelationCheckState(tvMenu);
            BindRoleData();
        }

        private void tsBtnSearch_Click(object sender, EventArgs e)
        {
            BindRoleData();
        }
        private void tsTxtSearchValue_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                tsBtnSearch_Click(sender, e);
            }
        }
        private void tsBtnAdd_Click(object sender, EventArgs e)
        {
            FrmFrmJueSeEdit frm = new FrmFrmJueSeEdit(_AL.AddRole);
            if (frm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                ShowMessage("新增完成");
                BindRoleData();
            }
        }

        private void tsBtnEditor_Click(object sender, EventArgs e)
        {
            var model = dgvRole.GetSelectedClassData<T_ROLE>();
            if (model == null)
            {
                ShowMessage("未选中任何行");
                return;
            }
            FrmFrmJueSeEdit frm = new FrmFrmJueSeEdit(_AL.UpdateRole, model);
            if (frm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                ShowMessage("修改完成");
                BindRoleData();
            }
        }

        private void tsBtnDelete_Click(object sender, EventArgs e)
        {
            var model = dgvRole.GetSelectedClassData<T_ROLE>();
            if (model == null)
            {
                ShowMessage("没有选中任何要删除的记录!");
                return;
            }
            if (!ShowQuestion("确实要删除当前选中记录吗?", "删除确认")) return;
            string errMsg;
            if (_AL.DeleteRole(model, out errMsg))
            {
                ShowMessage("删除完成");
                BindRoleData();
            }
            else
            {
                ShowMessage("删除失败," + errMsg);
            }
        }

        private void dgvRole_SelectionChangedAndCellClick(object sender, DataGridViewCellEventArgs e)
        {
            BindRoleUserData(true);
        }

        private void tsBtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tsBtnAddRoleUser_Click(object sender, EventArgs e)
        {
            var roleModel = dgvRole.GetSelectedClassData<T_ROLE>();
            if (roleModel == null)
            {
                ShowMessage("请先选择角色;");
                return;
            }
            var dt = _AL.GetUserData(roleModel);
            FrmYongHuXuanZe frm2 = new FrmYongHuXuanZe(dt);
            frm2.Text = string.Format("为角色:{0} 分配用户", roleModel.ROLE_NAME);
            frm2.OnSelectedHandle += (users) =>
            {
                StartRunWork(
                () =>
                {
                    //要执行的方法
                    _AL.SaveUserToRole(roleModel, users);
                }, () =>
                {
                    //执行完方法之后
                    BindRoleUserData();
                });
            };
            frm2.ShowDialog();
        }

        private void tsBtnRemoveUser_Click(object sender, EventArgs e)
        {
            var userModel = dgvYongHu.GetSelectedClassData<T_USER_INFO>();
            if (userModel == null)
            {
                ShowMessage("未选中任何行;");
            }
            if (!ShowQuestion("确实要从当前角色中移除改人员吗?", "移除确认")) return;
            var roleModel = dgvRole.GetSelectedClassData<T_ROLE>();
            if (roleModel == null)
            {
                ShowMessage("未选中任何角色");
                return;
            }
            _AL.RemoveUser(roleModel, userModel);
            BindRoleUserData();
        }

        private void tsbtnUserSearch_Click(object sender, EventArgs e)
        {
            BindRoleUserData();
        }

        private void tsTxtUserSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                BindRoleUserData();
            }
        }

        private void tsBtnSaveRoleMenu_Click(object sender, EventArgs e)
        {
            var roleModel = dgvRole.GetSelectedClassData<T_ROLE>();
            if (roleModel == null)
            {
                ShowMessage("请先选择角色;");
                return;
            }
            List<TreeNode> rList = new List<TreeNode>();
            TreeViewHelper.GetCheckedNodes(rList, tvMenu);
            List<T_MENU> menuList = new List<T_MENU>();
            foreach (var item in rList)
            {
                menuList.Add(item.Tag as T_MENU);
            }
            _AL.SaveMenuToRole(roleModel, menuList);
            ShowMessage("保存成功");
        }

        private void tvMenu_AfterCheck(object sender, TreeViewEventArgs e)
        {
            
        }
    }
}