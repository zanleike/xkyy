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
    public partial class FrmDepart : BaseListForm
    {
        public FrmDepart()
        {
            InitializeComponent();
        }

        ALDepart _AL;

        void InitDepartTree()
        {
            List<T_DEPART> departList = _AL.GetDepartList();
            tvDepart.Nodes.Clear();
            if (departList != null && departList.Count > 0)
            {
                foreach (var item in departList)
                {
                    if (string.IsNullOrWhiteSpace(item.PID))
                    {
                        TreeNode tn = new TreeNode();
                        tn.Name = item.ID;
                        tn.Text = item.MINGCHENG;
                        tn.Tag = item;
                        tvDepart.Nodes.Add(tn);
                        InitDepartTree(departList, tn);
                    }
                }
            }
        }
        void InitDepartTree(List<T_DEPART> departList, TreeNode pNode)
        {
            foreach (var item in departList)
            {
                if (item.PID == pNode.Name)
                {
                    TreeNode tn = new TreeNode();
                    tn.Name = item.ID;
                    tn.Text = item.MINGCHENG;
                    tn.Tag = item;
                    pNode.Nodes.Add(tn);
                    InitDepartTree(departList, tn);
                }
            }
        }

        private void FrmDepart_Load(object sender, EventArgs e)
        {
            _AL = new ALDepart();
        }

        private void tsBtnAdd_Click(object sender, EventArgs e)
        {
            T_DEPART model = new T_DEPART();
            if (tvDepart.SelectedNode != null)
            {
                var selectedModel = tvDepart.SelectedNode.Tag as T_DEPART;
                model.PID = selectedModel.ID;
                model.ParentName = selectedModel.MINGCHENG;
            }
            FrmDepartEdit frm = new FrmDepartEdit(model, _AL.Add);
            if (frm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                InitDepartTree();
                ShowMessage("新增科室成功。");
            }
        }

        private void tsBtnEdit_Click(object sender, EventArgs e)
        {
            if (tvDepart.SelectedNode == null)
            {
                ShowMessage("所选科室为空。");
                return;
            }
            T_DEPART model = tvDepart.SelectedNode.Tag as T_DEPART;
            if (tvDepart.SelectedNode.Parent != null)
            {
                model.ParentName = tvDepart.SelectedNode.Parent.Text;
            }
            FrmDepartEdit frm = new FrmDepartEdit(model, _AL.Update);
            if (frm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                InitDepartTree();
                ShowMessage("修改科室成功。");
            }
        }

        private void tsBtnDelete_Click(object sender, EventArgs e)
        {
            if (tvDepart.SelectedNode == null)
            {
                ShowMessage("所选科室为空。");
                return;
            }
            if (ShowQuestion("确实要删除当前选中科室吗？", "删除确认"))
            {
                T_DEPART depart = tvDepart.SelectedNode.Tag as T_DEPART;
                string errMsg;
                if (_AL.Delete(depart, out errMsg))
                {
                    ShowMessage("删除成功！");
                    InitDepartTree();
                }
                else
                {
                    ShowMessage(errMsg);
                }
            }
        }

        private void tsBtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
