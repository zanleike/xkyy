using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HursingManage.DBModel;

namespace HursingManage.AL
{
    public class ALMain : ALBase
    {
        public string GetUserName()
        {
            return CurrentLoginUser.USER_NAME;
        }
        public string GetKeShiName()
        {
            return CurrentLoginUser.KESHIMINGCHENG;
        }
        public List<T_ROLE_MENU> GetRoleMenu()
        {
            var query = DB.QueryWhere<T_ROLE_MENU>(s => s.ROLE_ID == CurrentLoginUser.ROLE_ID);
            return query.ToList();
        }
        ///// <summary>
        ///// 获取没有权限的菜单，隐藏起来
        ///// </summary>        
        //public List<T_MENU> GetNotRightMenu()
        //{
        //    var sql = DB.CreateSqlBuilder();
        //    sql.AddSQLText("ID not in (select MENUID from T_ROLE_MENU where ROLE_ID = {0})", sql.AddParam(CurrentLoginUser.ROLE_ID));
        //    var ret = DB.QueryWhere<T_MENU>(sql);
        //    return ret.ToList();
        //}

        public string GetUserType()
        {
            return CurrentLoginUser.USER_TYPE;
        }


        public string GetRoleID()
        {
            return CurrentLoginUser.ROLE_ID;
        }

        public string GetRoleName()
        {
            return CurrentLoginUser.ROLE_NAME;
        }
    }
}
