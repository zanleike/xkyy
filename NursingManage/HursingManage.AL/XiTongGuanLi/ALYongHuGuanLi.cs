using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HursingManage.DBModel;
using System.Data;

namespace HursingManage.AL.XiTongGuanLi
{
    public class ALYongHuGuanLi : ALBase
    {
        public DataTable GetData(string serValue)
        {
            var queryCond = DB.CreateQueryCondition<T_USER_INFO>();
            if (!string.IsNullOrWhiteSpace(serValue))
            {
                serValue = string.Format("%{0}%", serValue);
                var query = queryCond.WhereAnd(s =>
                      s.WEx_Like(s.USER_NO, serValue) ||
                      s.WEx_Like(s.USER_NAME, serValue) ||
                      s.WEx_Like(s.USER_NAME_PY, serValue) ||
                      s.WEx_Like(s.KESHIMINGCHENG, serValue));
            }
            queryCond.OrderBy(s => s.KESHIMINGCHENG).OrderBy(s => s.USER_NO);
            queryCond.WhereAnd(s => s.ISDEL == 0);
            var r = DB.QueryWhere<T_USER_INFO>(queryCond);
            return r.ToDataTable();
        }
        public bool VerifyModel(T_USER_INFO model, out string errMsg)
        {
            if (string.IsNullOrWhiteSpace(model.USER_NAME))
            {
                errMsg = "用户名不能为空!";
                return false;
            }
            if (string.IsNullOrWhiteSpace(model.USER_NO))
            {
                errMsg = "用户编号不能为空";
                return false;
            }
            if (string.IsNullOrWhiteSpace(model.KESHIID) || string.IsNullOrWhiteSpace(model.KESHIMINGCHENG))
            {
                errMsg = "必须选择科室";
                return false;
            }
            //if (string.IsNullOrWhiteSpace(model.USER_TYPE))
            //{
            //    errMsg = "请选择用户类型!";
            //    return false;
            //}
            if (DB.QueryExist<T_USER_INFO>(s => s.USER_NAME == model.USER_NAME && s.ID != model.ID && s.ISDEL == 0))
            {
                errMsg = "用户名称已存在!";
                return false;
            }
            if (DB.QueryExist<T_USER_INFO>(s => s.USER_NO == model.USER_NO && s.ID != model.ID))
            {
                errMsg = "用户编号已经存在!";
                return false;
            }
            errMsg = null;
            return true;
        }

        public bool Add(T_USER_INFO userInfo, out string errMsg)
        {
            if (!VerifyModel(userInfo, out errMsg))
            {
                return false;
            }
            userInfo.PWD = "12345";
            T_DANGAN dangAnModel = new T_DANGAN();
            userInfo.ID = GetGuid();
            dangAnModel.USERID = userInfo.ID;
            dangAnModel.XINGMING = userInfo.USER_NAME;
            dangAnModel.XINGMING_PY = userInfo.USER_NAME_PY;
            DB.Insert(dangAnModel);
            DB.Insert(userInfo);
            return true;
        }
        public bool Update(T_USER_INFO userInfo, out string errMsg)
        {
            if (!VerifyModel(userInfo, out errMsg))
            {
                return false;
            }
            var query = DB.QueryWhere<T_DANGAN>(s => s.USERID == userInfo.ID);
            var dangAnModel = query.ToEntity();
            if (dangAnModel != null)
            {
                dangAnModel.XINGMING = userInfo.USER_NAME;
                dangAnModel.XINGMING_PY = userInfo.USER_NAME_PY;
                DB.Update(dangAnModel);
            }
            DB.Update(userInfo);
            return true;
        }
        public bool Delete(T_USER_INFO model, out string errMsg)
        {
            model.ClearChangedState();
            model.ISDEL = 1;
            model.LASTTIME = GetNowTime();
            T_DANGAN dangAn = new T_DANGAN();
            dangAn.ISDEL = 1;
            DB.Update<T_DANGAN>(dangAn, s => s.USERID == model.ID);
            DB.Update(model);
            errMsg = string.Empty;
            WriteDBLog("删除用户 {0}", model.USER_NAME);
            return true;
        }
        
        public DataTable GetKeShiByUserId(T_USER_INFO model)
        {
            var sql = DB.CreateSqlBuilder();
            sql.AddSQLText("IsDel=0 and ID not in (select KeShiId from T_KeShiRenYuan where YONGHUID={0})", sql.AddParam(model.ID));
            var result = DB.QueryWhere<T_KESHI>(sql);
            return result.ToDataTable();
        }

        public void SaveKeShiByUser(T_USER_INFO user, List<T_KESHI> datas)
        {
            foreach (var item in datas)
            {
                T_KESHIRENYUAN model = new T_KESHIRENYUAN();
                model.KESHIID = item.ID;
                model.YONGHUID = user.ID;
                DB.Insert(model);
            }
        }
    }
}
