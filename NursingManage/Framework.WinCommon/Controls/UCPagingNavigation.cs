/*    
    时间:2013.6.15
    创建人:张存
    邮箱:zhangcunliang@126.com
        
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace Framework.WinCommon.Controls
{
    public delegate void PadeChangedHandle(int pageNo, int onePageCount, out int recordCount);

    public partial class UCPagingNavigation : UserControl
    {
        #region 构造方法

        public UCPagingNavigation()
        {
            InitializeComponent();
            tsCoBoxOnePage.SelectedIndex = 0;
        }

        #endregion

        public event PadeChangedHandle PageChangedEvent;

        int _RecordCount = 0;

        /// <summary>
        /// 初始化控件,当前页1,重新刷新数据源时调用它
        /// </summary>
        public void InitiControl(int recordCount)
        {
            _RecordCount = recordCount;
            int onePageCount = OnePageCount;
            
            int pageCount;
            if (onePageCount <= 0)
            {
                pageCount = 0;
            }
            else
            {
                pageCount = (int)(Math.Ceiling(recordCount * 1.0 / onePageCount));
            }
            //if (pageCount <= 0 || recordCount <= 0)
            //{
            //    return;
            //}
            //当前页下拉列表
            tsCoBoxSkipPage.Items.Clear();
            for (int i = 1; i <= pageCount; i++)
            {
                tsCoBoxSkipPage.Items.Add(i);
            }
            if (tsCoBoxSkipPage.Items.Count > 0)
                //tsCoBoxSkipPage.SelectedIndex = this.PageNo;
            //页总数Label
            tsLblPageCount.Text = pageCount.ToString();
            //记录数显示
            tsLblRecordCount.Text = recordCount.ToString();
        }
        /// <summary>
        /// 初始化每页显示列表
        /// </summary>
        public void InitiOnePageList(int[] onePages)
        {
            if (onePages == null || onePages.Length == 0)
            {
                return;
            }
            tsCoBoxOnePage.Items.Clear();
            foreach (var item in onePages)
            {
                tsCoBoxOnePage.Items.Add(item);
            }
            tsCoBoxOnePage.Items.Add("不分页");
        }
        /// <summary>
        /// 返回当前页码
        /// </summary>
        public int PageNo
        {
            get
            {
                int skipPageNo;
                if (int.TryParse(tsCoBoxSkipPage.Text, out skipPageNo))
                {
                    return skipPageNo;
                }
                return 0;
            }
        }
        /// <summary>
        /// 返回当前每页显示数
        /// </summary>
        public int OnePageCount
        {
            get
            {
                int r = 0;
                if (int.TryParse(tsCoBoxOnePage.Text, out r))
                {
                    return r;
                }
                return 0;
            }
        }
        /// <summary>
        /// 返回页总数
        /// </summary>
        public int PageCount
        {
            get
            {
                int r = 0;
                if (int.TryParse(tsLblPageCount.Text, out r))
                {
                    return r;
                }
                return 0;
            }
        }

        #region 改变页码的方法们

        /// <summary>
        /// 跳转到指定页
        /// </summary>
        void SkipPage(int pageNo)
        {
            if (PageChangedEvent != null)
            {
                if (tsCoBoxSkipPage.Items.Count <= 0) return;
                if (pageNo > PageCount) pageNo = PageCount;
                if (pageNo < 1) pageNo = 1;
                tsCoBoxSkipPage.SelectedIndex = pageNo - 1;
                int recordCount;
                PageChangedEvent(pageNo, OnePageCount, out recordCount);
            }
        }
        //首页
        private void tsBtnFirstPage_Click(object sender, EventArgs e)
        {
            SkipPage(1);
        }
        //下一页
        private void tsBtnNextPage_Click(object sender, EventArgs e)
        {
            SkipPage(PageNo + 1);
        }
        //上一页
        private void tsBtnBackPage_Click(object sender, EventArgs e)
        {
            SkipPage(PageNo - 1);
        }
        //末页
        private void tsBtnLastPage_Click(object sender, EventArgs e)
        {
            SkipPage(PageCount);
        }

        #endregion

        #region 当每页显示数的值改变后触发

        /// <summary>
        /// 非分页的绑定锁
        /// </summary>
        void LockPageChange()
        {
            tsBtnBackPage.Enabled = false;
            tsBtnFirstPage.Enabled = false;
            tsBtnLastPage.Enabled = false;
            tsBtnNextPage.Enabled = false;
            tsCoBoxSkipPage.Enabled = false;
        }
        /// <summary>
        /// 分页的绑定解锁
        /// </summary>
        void UnLockPageChange()
        {
            tsBtnBackPage.Enabled = true;
            tsBtnFirstPage.Enabled = true;
            tsBtnLastPage.Enabled = true;
            tsBtnNextPage.Enabled = true;
            tsCoBoxSkipPage.Enabled = true;
        }
        /// <summary>
        /// 当每页显示数发生变化时触发的方法
        /// </summary>
        void InitiOnePageChanged()
        {
            //if (_RecordCount <= 0) return;
            if (PageChangedEvent != null)
            {
                int onePageCount;
                //int pageCount;
                int recordCount;
                if (int.TryParse(tsCoBoxOnePage.Text, out onePageCount))
                {
                    PageChangedEvent(PageNo, onePageCount, out recordCount);
                    InitiControl(recordCount);
                    UnLockPageChange();
                }
                else
                {
                    PageChangedEvent(0, 0, out recordCount);
                    tsLblPageCount.Text = "1";
                    tsLblRecordCount.Text = recordCount.ToString();
                    LockPageChange();
                }
            }
        }

        //输入每页显示条数并回车,初始化
        private void tsCoBoxOnePage_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                InitiOnePageChanged();

            }
        }

        bool _OnePageClickAndChanged = false;
        /// <summary>
        /// 每页显示条数选项改变后初始化(如果点击后改变的选项才触发)
        /// </summary>
        private void tsCoBoxOnePage_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_OnePageClickAndChanged == false) return;
            InitiOnePageChanged();
            _OnePageClickAndChanged = false;
        }
        private void tsCoBoxOnePage_Click(object sender, EventArgs e)
        {
            _OnePageClickAndChanged = true;
        }

        #endregion

        #region 跳转页

        //跳转页改为回车
        private void tsCoBoxSkipPage_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                int skipPageNo;
                if (int.TryParse(tsCoBoxSkipPage.Text, out skipPageNo))
                {
                    SkipPage(skipPageNo);
                }
            }
        }

        //点击的改变才出发
        bool SkipPageClickAndChange = false;
        private void tsCoBoxSkipPage_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!SkipPageClickAndChange) return;

            int skipPageNo;
            if (int.TryParse(tsCoBoxSkipPage.Text, out skipPageNo))
            {
                SkipPage(skipPageNo);
            }
            SkipPageClickAndChange = false;
        }
        private void tsCoBoxSkipPage_Click(object sender, EventArgs e)
        {
            SkipPageClickAndChange = true;
        }


        #endregion

    }
}
