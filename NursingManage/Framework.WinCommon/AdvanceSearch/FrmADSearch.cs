/*
    创建日期: 2014.9.4
    创建者:张存
    邮箱:zhangcunliang@126.com
    说明:
        
    修改记录:
        2015.1.14 修改当查询文本框为空时报错的bug
        2017.3.21 设计改变,查询只是查询,数据的获取不再有该项目实现
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using System.Reflection;

namespace Framework.WinCommon.AdvanceSearch
{
    public partial class FrmADSearch : Form
    {
        /// <summary>
        /// 指定ownerFormName是为了兼容一个窗体有两个查询
        /// </summary>
        public FrmADSearch(ISearchConfig searchConfig)
        {
            InitializeComponent();
            this._SearchConfig = searchConfig;
        }

        static Dictionary<string, List<ISearchRecord_Detail>> LastSearchDict = new Dictionary<string, List<ISearchRecord_Detail>>();

        void AddToLastSearchDict()
        {
            LastSearchDict[_SearchConfig.OwnerForm] = GetSearchList();
        }

        /// <summary>
        /// 当点击搜索按钮时触发
        /// </summary>
        public event Action<EventSearchArgs> OnSearchClickHandle;

        ISearchConfig _SearchConfig;

        List<ISearchColumn> _SearchColumns;

        /// <summary>
        /// 载入搜索记录
        /// </summary>
        void LoadSearchList(List<ISearchColumn> columns, List<ISearchRecord_Detail> searchList)
        {
            flowLayoutPanel1.Controls.Clear();
            if (searchList == null) return;
            for (int i = 0; i < searchList.Count; i++)
            {
                U_ASRow u1 = new U_ASRow();
                u1.InitiColumns(columns);
                u1.SetCompareSign(searchList[i].CompareSignStr);
                u1.SetConnectorSign(searchList[i].ConnectorSignStr);
                u1.SetSelectColumn(searchList[i].FieldName);
                u1.SetSearchValue(searchList[i].SearchValue);
                u1.SetSearchModel(searchList[i]);
                if (i == 0)
                {
                    u1.IsFirstRow = true;
                }
                flowLayoutPanel1.Controls.Add(u1);
            }
        }
        void LoadSearchList(List<ISearchRecord_Detail> searchList)
        {
            LoadSearchList(_SearchColumns, searchList);
        }
        List<ISearchRecord_Detail> GetSearchList()
        {
            List<ISearchRecord_Detail> list = new List<ISearchRecord_Detail>();
            foreach (U_ASRow item in flowLayoutPanel1.Controls)
            {
                if (item == null) continue;

                ISearchRecord_Detail sm = new ISearchRecord_Detail();
                sm = item.GetSearchRecord();
                if (sm == null) continue;
                list.Add(sm);
            }
            return list;
        }

        private void FrmAdvancedSearch_Load(object sender, EventArgs e)
        {
            if (_SearchConfig == null)
            {
                MessageBox.Show("配置错误.");
                this.Close();
                return;
            }
            _SearchColumns = _SearchConfig.GetSearchColumns();
            if (_SearchColumns == null || _SearchColumns.Count == 0)
            {
                MessageBox.Show("未配置该查询列,查询失败.");
                this.Close();
                return;
            }
            List<ISearchRecord_Detail> detailList = null;
            if (LastSearchDict.ContainsKey(_SearchConfig.OwnerForm))
            {
                detailList = LastSearchDict[_SearchConfig.OwnerForm];
            }

            if (detailList == null || detailList.Count == 0)
            {
                detailList = _SearchConfig.GetDefaultRecordDetail();
            }
            LoadSearchList(_SearchColumns, detailList);
        }

        private void tsBtnAddOneRow_Click(object sender, EventArgs e)
        {
            U_ASRow ua = new U_ASRow();
            ua.InitiColumns(_SearchColumns);
            if (flowLayoutPanel1.Controls.Count == 0)
            {
                ua.IsFirstRow = true;
            }
            flowLayoutPanel1.Controls.Add(ua);
        }
        /// <summary>
        /// 确认查询返回DialogResult.OK,可调用GetWhereHelper获得查询条件
        /// </summary>
        private void btnOK_Click(object sender, EventArgs e)
        {
            List<ISearchRecord_Detail> searchList = GetSearchList();
            if (searchList.Count == 0)
            {
                if (MessageBox.Show("查询条件为空,将查询所有数据,确认要操作吗?!", "查询确认", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) != System.Windows.Forms.DialogResult.OK)
                {
                    return;
                }
            }
            if (OnSearchClickHandle != null)
            {
                EventSearchArgs arg = new EventSearchArgs();
                arg.SearchRecord = searchList;
                arg.Sender = this;
                LastSearchDict[_SearchConfig.OwnerForm] = searchList;
                OnSearchClickHandle(arg);
                if (!arg.IsCancel)
                {
                    this.DialogResult = System.Windows.Forms.DialogResult.OK;
                }
            }
            else
            {
                MessageBox.Show("未绑定搜索事件,查询无效");
            }
        }
        /// <summary>
        /// 取消查询,返回 DialogResult.Cancel;
        /// </summary>
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        Type GetTypeByString(string type)
        {
            switch (type.ToLower())
            {
                case "bool":
                    return Type.GetType("System.Boolean", true, true);
                case "byte":
                    return Type.GetType("System.Byte", true, true);
                case "sbyte":
                    return Type.GetType("System.SByte", true, true);
                case "char":
                    return Type.GetType("System.Char", true, true);
                case "decimal":
                    return Type.GetType("System.Decimal", true, true);
                case "double":
                    return Type.GetType("System.Double", true, true);
                case "float":
                    return Type.GetType("System.Single", true, true);
                case "int":
                    return Type.GetType("System.Int32", true, true);
                case "uint":
                    return Type.GetType("System.UInt32", true, true);
                case "long":
                    return Type.GetType("System.Int64", true, true);
                case "ulong":
                    return Type.GetType("System.UInt64", true, true);
                case "object":
                    return Type.GetType("System.Object", true, true);
                case "short":
                    return Type.GetType("System.Int16", true, true);
                case "ushort":
                    return Type.GetType("System.UInt16", true, true);
                case "string":
                    return Type.GetType("System.String", true, true);
                case "date":
                case "datetime":
                    return Type.GetType("System.DateTime", true, true);
                case "guid":
                    return Type.GetType("System.Guid", true, true);
                default:
                    return Type.GetType(type, true, true);
            }
        }

        private void tsBtnRefeash_Click(object sender, EventArgs e)
        {
            LoadSearchList(_SearchColumns, null);
        }
        private void tsbtnSave_Click(object sender, EventArgs e)
        {
            var recordDetail = GetSearchList();
            FrmSearchSave frm = new FrmSearchSave(_SearchConfig, recordDetail);
            frm.ShowDialog();
        }
        void LoadSearchHandle(ISearchRecord record)
        {
            var detailList = _SearchConfig.GetRecordDetail(record);
            LoadSearchList(detailList);
        }
        private void tsBtnConfigLoad_Click(object sender, EventArgs e)
        {
            FrmSearchList frm = new FrmSearchList(LoadSearchHandle, _SearchConfig);
            frm.ShowDialog();
        }
    }
}