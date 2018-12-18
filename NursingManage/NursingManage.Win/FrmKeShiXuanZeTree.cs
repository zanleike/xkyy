using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Framework.WinCommon.TreeData;
using HursingManage.DBModel;
using Framework.Common;

namespace NursingManage.Win
{
    public partial class FrmKeShiXuanZeTree : BaseEditForm
    {
        public FrmKeShiXuanZeTree(EditModelHandle<List<T_KESHI>> BaoCunBiaoZhunHandle, List<T_KESHI> biaoZhunList)
        {
            InitializeComponent();
            this._KeShiList = biaoZhunList;
            this.BaoCunBiaoZhunHandle = BaoCunBiaoZhunHandle;
        }


        //保存问题标准        
        EditModelHandle<List<T_KESHI>> BaoCunBiaoZhunHandle;
        // 质量标准列表
        List<T_KESHI> _KeShiList;

        void BindDataByTree()
        {
            foreach (var keShi in _KeShiList)
            {
                if (string.IsNullOrWhiteSpace(keShi.LEIXING1))
                {
                    TreeNode tn = new TreeNode();
                    tn.Name = keShi.MINGCHENG;
                    tn.Text = keShi.MINGCHENG;
                    tn.Tag = keShi;
                    tv.Nodes.Add(tn);
                    continue;
                }
                TreeNode node1Level;
                if (tv.Nodes.ContainsKey(keShi.LEIXING1))
                {
                    node1Level = tv.Nodes[keShi.LEIXING1];
                }
                else
                {
                    node1Level = new TreeNode();
                    node1Level.Name = keShi.LEIXING1;
                    node1Level.Text = keShi.LEIXING1;
                    tv.Nodes.Add(node1Level);
                }
                if (string.IsNullOrWhiteSpace(keShi.LEIXING2))
                {
                    TreeNode tn = new TreeNode();
                    tn.Name = keShi.MINGCHENG;
                    tn.Text = keShi.MINGCHENG;
                    tn.Tag = keShi;
                    node1Level.Nodes.Add(tn);
                    continue;
                }
                TreeNode node2Level;
                if (node1Level.Nodes.ContainsKey(keShi.LEIXING2))
                {
                    node2Level = node1Level.Nodes[keShi.LEIXING2];
                }
                else
                {
                    node2Level = new TreeNode();
                    node2Level.Name = keShi.LEIXING2;
                    node2Level.Text = keShi.LEIXING2;
                    node1Level.Nodes.Add(node2Level);
                }
                TreeNode node3Level = new TreeNode();
                node3Level.Name = keShi.MINGCHENG;
                node3Level.Text = keShi.MINGCHENG;
                node3Level.Tag = keShi;
                node2Level.Nodes.Add(node3Level);
            }
        }

        private void FrmKeShiXuanZeTree_Load(object sender, EventArgs e)
        {
            if (_KeShiList == null)
            {
                MessageBox.Show("标准列表为空！");
                this.Close();
                return;
            }
            BindDataByTree();
            TreeViewHelper.SetRelationCheckState(tv);
        }

        private void tsBtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBaoCun_Click(object sender, EventArgs e)
        {
            List<TreeNode> seletedNodes = new List<TreeNode>();
            TreeViewHelper.GetCheckedNodes(seletedNodes, tv);
            if (seletedNodes == null || seletedNodes.Count == 0)
            {
                ShowMessage("没有选中任何内容。");
                return;
            }
            List<T_KESHI> biaoZhunList = new List<T_KESHI>();
            foreach (var item in seletedNodes)
            {
                var biaoZhun = item.Tag as T_KESHI;
                if (biaoZhun != null) biaoZhunList.Add(biaoZhun);
            }
            string errMsg;
            if (BaoCunBiaoZhunHandle(biaoZhunList, out errMsg))
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