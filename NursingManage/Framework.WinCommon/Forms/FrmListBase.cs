using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Framework.WinCommon.Controls;
using Framework.Common.Models;
using System.Threading;

namespace Framework.WinCommon.Forms
{
    //public interface IFrmList
    //{
    //    bool Insert();
    //    bool Edit();
    //    bool Delete();
    //    void View();
    //    void BindDataSource();
    //    DataTable QuickSearch(string searchCondition);
    //    DataTable AdvancedSearch();
    //}
    public partial class FrmListBase : FrmBase
    {
        public FrmListBase()
        {
            InitializeComponent();
        }

        protected event EventHandler InsertHandel;
        protected event EventHandler EditHandel;
        protected event EventHandler DeleteHandel;
        protected event EventHandler ViewHandel;
        protected event EventHandler QuickSearchHandel;
        protected event EventHandler ClearQuickSearchHandel;
        protected event EventHandler AdvancedSearchHandel;


        //窗体加载
        private void ListForm_Load(object sender, EventArgs e)
        {

        }
        //关闭按钮
        private void tsBtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //高级搜索
        private void tsBtnAdvancedSearch_Click(object sender, EventArgs e)
        {
            if (AdvancedSearchHandel != null) AdvancedSearchHandel(sender, e);
        }
        //快速搜索文本框的键盘按下
        private void tsTxtQuickSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                tsBtnQuickSearch_Click(sender, e);
            }
        }
        //快速搜索按钮的点击
        private void tsBtnQuickSearch_Click(object sender, EventArgs e)
        {
            if (QuickSearchHandel != null) QuickSearchHandel(sender, e);
        }
        //清空快速搜索
        private void tsBtnQuickSearchClear_Click(object sender, EventArgs e)
        {
            if (ClearQuickSearchHandel != null) ClearQuickSearchHandel(sender, e);
        }
        //增加按钮
        private void tsBtnAdd_Click(object sender, EventArgs e)
        {
            if (InsertHandel != null) InsertHandel(sender, e);
        }
        //编辑按钮
        private void tsBtnEditor_Click(object sender, EventArgs e)
        {
            if (EditHandel != null) EditHandel(sender, e);
        }
        //查看按钮
        private void tsBtnView_Click(object sender, EventArgs e)
        {
            if (ViewHandel != null) ViewHandel(sender, e);
        }
        //删除按钮
        private void tsBtnDelete_Click(object sender, EventArgs e)
        {
            if (DeleteHandel != null) ViewHandel(sender, e);
        }

        //#region IFrmList成员
        
        //protected virtual bool Insert()
        //{
        //    throw new NotImplementedException();
        //}

        //protected virtual bool Edit()
        //{
        //    throw new NotImplementedException();
        //}

        //protected virtual bool Delete()
        //{
        //    throw new NotImplementedException();
        //}

        //protected virtual void View()
        //{
        //    throw new NotImplementedException();
        //}

        //protected virtual DataTable QuickSearch(string searchCondition)
        //{
        //    throw new NotImplementedException();
        //}

        //protected virtual DataTable AdvancedSearch()
        //{
        //    throw new NotImplementedException();
        //}

        //public virtual void BindDataSource()
        //{ }

        //#endregion

        
    }
}