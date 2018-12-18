using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Framework.WinCommon.Components;
using System.Windows.Forms;
using HursingManage.AL;
using HursingManage.DBModel;

namespace NursingManage.Win
{
    class ComboxListHelper
    {
        static ALComboxListHelper ALObj = new ALComboxListHelper();

        #region 账号信息

        public static void SetUser(ComboxList cboxList, TextBox tb, string keshiId = null)
        {
            cboxList.SetColumns(tb, new ComBoxListColumn[] 
                {   
                    new ComBoxListColumn(){ FieldCaption="姓名", FieldName=T_USER_INFO.CNUSER_NAME ,IsReturnText = true},
                    new ComBoxListColumn(){ FieldCaption="工号", FieldName=T_USER_INFO.CNUSER_NAME_PY },   
                    new ComBoxListColumn(){ FieldCaption="Id", FieldName=T_USER_INFO.CNID,IsReturnTag = true,IsVisible=false}
                });
            cboxList.SetIsUse(tb, true);
            tb.KeyDown += new KeyEventHandler(delegate(object sender, KeyEventArgs e)
            {
                if (e.KeyCode == Keys.Enter)
                {
                    cboxList.GridViewDataSource = ALObj.GetUserData(tb.Text, keshiId);
                }
            });
        }

        #endregion

        #region 角色信息

        public static void SetRole(ComboxList cboxList, TextBox tb)
        {
            cboxList.SetColumns(tb, new ComBoxListColumn[] 
                {   
                    new ComBoxListColumn(){ FieldCaption="姓名", FieldName=T_ROLE.CNROLE_NAME ,IsReturnText = true},                    
                    new ComBoxListColumn(){ FieldCaption="Id", FieldName=T_ROLE.CNID,IsReturnTag = true,IsVisible=false}
                });
            cboxList.SetIsUse(tb, true);
            tb.KeyDown += new KeyEventHandler(delegate(object sender, KeyEventArgs e)
            {
                if (e.KeyCode == Keys.Enter)
                {
                    cboxList.GridViewDataSource = ALObj.GetRoleData(tb.Text);
                }
            });
        }

        #endregion

        #region 科室

        public static void SetKeShi(ComboxList cboxList, TextBox tb)
        {
            cboxList.SetColumns(tb, new ComBoxListColumn[] 
                {   
                    new ComBoxListColumn(){ FieldCaption="科室名称", FieldName=T_KESHI.CNMINGCHENG ,IsReturnText = true},
                    new ComBoxListColumn(){ FieldCaption="科室编码", FieldName=T_KESHI.CNBIANMA },
                    new ComBoxListColumn(){ FieldCaption="Id", FieldName=T_ROLE.CNID,IsReturnTag = true,IsVisible=false}
                });
            cboxList.SetIsUse(tb, true);
            tb.KeyDown += new KeyEventHandler(delegate(object sender, KeyEventArgs e)
            {
                if (e.KeyCode == Keys.Enter)
                {
                    e.Handled = true;
                    cboxList.GridViewDataSource = ALObj.GetKeShiData(tb.Text);
                }
            });
        }

        #endregion

        #region 字典

        public static void SetDict(ComboxList cboxList, TextBox tb, DictType dictType, string caption, string tagField = T_DICTIONARY.CNDICTVALUE)
        {
            SetDict(cboxList, tb, (int)dictType, caption, tagField);
        }

        public static void SetDict(ComboxList cboxList, TextBox tb, int dictType, string caption, string tagField = T_DICTIONARY.CNDICTVALUE)
        {
            cboxList.SetColumns(tb, new ComBoxListColumn[] 
                {   
                    new ComBoxListColumn(){ FieldCaption=caption, FieldName=T_DICTIONARY.CNDICTVALUE ,IsReturnText = true},
                    new ComBoxListColumn(){ FieldCaption="ID", FieldName=tagField,IsVisible=false,IsReturnTag=true }
                });
            cboxList.SetIsUse(tb, true);
            tb.KeyDown += new KeyEventHandler(delegate(object sender, KeyEventArgs e)
            {
                if (e.KeyCode == Keys.Enter)
                {
                    cboxList.GridViewDataSource = ALObj.GetDictData(dictType, tb.Text);
                }
            });
            tb.Leave += (s, e) =>
            {
                if (tb.Tag != null) tb.Text = tb.Tag.ToString();
            };
        }
        public static void SetUserType(ComboxList cboxList, TextBox tb)
        {
            SetDict(cboxList, tb, DictType.UserType, "用户类型");
        }
        public static void SetMinZu(ComboxList cboxList, TextBox tb)
        {
            SetDict(cboxList, tb, DictType.MinZu, "民族名称");
        }

        #endregion

        #region 试题分类

        public static void SetShiTiFenLei(ComboxList cboxList, TextBox tb)
        {
            cboxList.SetColumns(tb, new ComBoxListColumn[] 
                {   
                    new ComBoxListColumn(){ FieldCaption="类别名称", FieldName=T_SHITI_FENLEI.CNMINGCHENG ,IsReturnText = true},
                    new ComBoxListColumn(){ FieldCaption="助记码", FieldName=T_SHITI_FENLEI.CNMINGCHENG_PY },
                    new ComBoxListColumn(){ FieldCaption="Id", FieldName=T_SHITI_FENLEI.CNID,IsReturnTag = true,IsVisible=false}
                });
            cboxList.SetIsUse(tb, true);
            tb.KeyDown += new KeyEventHandler(delegate(object sender, KeyEventArgs e)
            {
                if (e.KeyCode == Keys.Enter)
                {
                    cboxList.GridViewDataSource = ALObj.GetShiTiLeiBieData(tb.Text);
                }
            });
        }

        #endregion

        #region 试题模板

        public static void SetShiTiMuBan(ComboxList cboxList, TextBox tb)
        {
            cboxList.SetColumns(tb, new ComBoxListColumn[] 
                {   
                    new ComBoxListColumn(){ FieldCaption="试题模板名称", FieldName=T_SHITI_MUBAN.CNMINGCHENG ,IsReturnText = true},
                    new ComBoxListColumn(){ FieldCaption="试题类别", FieldName=T_SHITI_MUBAN.CNSHITILEIBIE },
                    new ComBoxListColumn(){ FieldCaption="创建时间", FieldName=T_SHITI_MUBAN.CNADDTIME },
                    new ComBoxListColumn(){ FieldCaption="Id", FieldName=T_SHITI_MUBAN.CNID,IsReturnTag = true,IsVisible=false}
                });
            cboxList.SetIsUse(tb, true);
            tb.KeyDown += new KeyEventHandler(delegate(object sender, KeyEventArgs e)
            {
                if (e.KeyCode == Keys.Enter)
                {
                    cboxList.GridViewDataSource = ALObj.GetShiTiMuBanData(tb.Text);
                }
            });
        }

        #endregion

        #region 质控计划（复查计划选择使用）

        public static void SetZhiKongJiHua(ComboxList cboxList, TextBox tb)
        {
            cboxList.SetColumns(tb, new ComBoxListColumn[] 
                {   
                    new ComBoxListColumn(){ FieldCaption="计划名称", FieldName=T_ZHIKONGJIHUA.CNMINGCHENG ,IsReturnText = true},
                    new ComBoxListColumn(){ FieldCaption="检查开始时间", FieldName=T_ZHIKONGJIHUA.CNKAISHISHIJIAN },
                    new ComBoxListColumn(){ FieldCaption="检查结束时间", FieldName=T_ZHIKONGJIHUA.CNJIESHUSHIJIAN },
                    new ComBoxListColumn(){ FieldCaption="Id", FieldName=T_ZHIKONGJIHUA.CNID,IsReturnTag = true,IsVisible=false}
                });
            cboxList.SetIsUse(tb, true);
            tb.KeyDown += new KeyEventHandler(delegate(object sender, KeyEventArgs e)
            {
                if (e.KeyCode == Keys.Enter)
                {
                    cboxList.GridViewDataSource = ALObj.GetZhiKongJiHuaByFuCha(tb.Text);
                }
            });
        }

        #endregion
    }
}
