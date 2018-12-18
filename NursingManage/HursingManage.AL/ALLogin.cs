using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Framework.Common;
using HursingManage.DBModel;

namespace HursingManage.AL
{
    public class ALLogin : ALBase
    {
        /// <summary>
        /// 当前登录用户
        /// </summary>
        internal static T_USER_INFO CurrentLoginUser { get; private set; }

        public ViewResultString FindName(string gongHao)
        {
            ViewResultString r = new ViewResultString();
            try
            {
                if (string.IsNullOrWhiteSpace(gongHao))
                {
                    r.ErrMessage = "工号不能为空";
                    return r;
                }
                //TODO:根据工号查找姓名
                var query = DB.QueryWhere<T_USER_INFO>(s => s.USER_NO == gongHao);
                var userInfo = query.ToEntity();
                if (userInfo == null)
                {
                    r.ErrMessage = "该工号不存在";
                    return r;
                }
                r.ReusltValue = userInfo.USER_NAME;
            }
            catch (Exception ex)
            {
                r.ErrMessage = "查找姓名出现异常";
                LogHelper.LogObj.Error(r.ErrMessage, ex);
            }
            return r;
        }

        public ViewResultBase Login(string gongHao, string pwd)
        {
            ViewResultBase r = new ViewResultBase();
            if (string.IsNullOrWhiteSpace(gongHao))
            {
                r.ErrMessage = "工号不能为空！";
                return r;
            }
            if (string.IsNullOrWhiteSpace(pwd))
            {
                r.ErrMessage = "密码不能为空！";
                return r;
            }
            var query = DB.QueryWhere<T_USER_INFO>(s => s.USER_NO == gongHao && s.PWD == pwd);
            var userInfo = query.ToEntity();
            if (userInfo == null)
            {
                r.ErrMessage = "用户名或密码错误!";
                return r;
            }
            CurrentLoginUser = userInfo;
            return r;
        }

        public bool ChangePassword(string oldPwd, string newPwd, string rNewPwd, out string errMsg)
        {
            if (newPwd != rNewPwd)
            {
                errMsg = "两次密码输入不一致!";
                return false;
            }
            if (!DB.QueryExist<T_USER_INFO>(s => s.ID == CurrentLoginUser.ID && s.PWD == oldPwd))
            {
                errMsg = "原密码不正确!";
                return false;
            }
            T_USER_INFO model = new T_USER_INFO();
            model.PWD = newPwd;
            DB.Update<T_USER_INFO>(model, s => s.ID == CurrentLoginUser.ID);
            errMsg = string.Empty;
            return true;
        }
    }
}