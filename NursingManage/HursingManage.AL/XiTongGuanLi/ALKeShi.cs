using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HursingManage.DBModel;
using System.Data;

namespace HursingManage.AL.XiTongGuanLi
{
    public class ALKeShi : ALBase
    {
        public DataTable GetData(string searchValue)
        {
            var query = DB.CreateQueryCondition<T_KESHI>();
            if (!string.IsNullOrWhiteSpace(searchValue))
            {
                string likeStr = string.Format("%{0}%", searchValue);
                query.WhereAnd(s =>
                    s.WEx_Like(s.BIANMA, likeStr) ||
                    s.WEx_Like(s.MINGCHENG, likeStr) ||
                    s.WEx_Like(s.MINGCHENG_PY, likeStr)
                    );

            }
            query.WhereAnd(s => s.ISDEL == 0);
            query.OrderBy(s => s.MINGCHENG);
            var result = DB.QueryWhere<T_KESHI>(query);
            return result.ToDataTable();
        }
        public bool VerifyModel(T_KESHI model, out string errMsg)
        {
            if (string.IsNullOrWhiteSpace(model.BIANMA))
            {
                errMsg = "科室编码不能为空";
                return false;
            }
            if (string.IsNullOrWhiteSpace(model.MINGCHENG))
            {
                errMsg = "科室名称不能为空";
                return false;
            }
            if (DB.QueryExist<T_KESHI>(s => s.MINGCHENG == model.MINGCHENG && s.ID != model.ID && s.ISDEL == 0))
            {
                errMsg = "科室名称已存在";
                return false;
            }
            if (DB.QueryExist<T_KESHI>(s => s.BIANMA == model.BIANMA && s.ID != model.ID && s.ISDEL == 0))
            {
                errMsg = "科室编码已存在";
                return false;
            }
            errMsg = null;
            return true;
        }
        public bool Add(T_KESHI model, out string errMsg)
        {
            if (!VerifyModel(model, out errMsg))
            {
                return false;
            }
            model.ADDTIME = GetNowTime();
            model.LASTTIME = GetNowTime();
            model.OPERATORID = CurrentLoginUser.ID;
            DB.Insert(model);
            errMsg = null;
            return true;
        }
        public bool Update(T_KESHI model, out string errMsg)
        {
            if (!VerifyModel(model, out errMsg))
            {
                return false;
            }
            model.LASTTIME = GetNowTime();
            model.OPERATORID = CurrentLoginUser.ID;
            DB.Update(model);
            errMsg = null;
            return true;
        }
        public bool Delete(T_KESHI model, out string errMsg)
        {
            model.ClearChangedState();
            model.ISDEL = 1;
            DB.Update(model);
            errMsg = null;
            return true;
        }

        /// <summary>
        /// 根据指定科室获取用户列表
        /// </summary>
        /// <param name="keShiId">科室Id</param>
        /// <param name="isSelected">true:查询已选择的用户数据,false:查询未选择的用户信息</param>
        /// <returns></returns>
        public DataTable GetUserData(string keShiId, bool isSelected = false, string serValue = null)
        {
            string isNotStr = isSelected ? "" : "not";
            var sql = DB.CreateSqlBuilder();
            sql.AddSQLText("IsDel=0 and ID {1} in (select YongHuId from T_KeShiRenYuan where KeShiID={0})", sql.AddParam(keShiId), isNotStr);
            if (!string.IsNullOrWhiteSpace(serValue))
            {
                serValue = string.Format("%{0}%", serValue);
                sql.AddSQLText("USER_NO like {0} or USER_NAME like {0} or USER_NAME_PY like {0} ", sql.AddParam(serValue));
            }
            var result = DB.QueryWhere<T_USER_INFO>(sql);
            return result.ToDataTable();
        }

        public void SaveYongHuToKeShi(string keShiId, List<T_USER_INFO> users)
        {
            foreach (var item in users)
            {
                T_KESHIRENYUAN model = new T_KESHIRENYUAN();
                model.KESHIID = keShiId;
                model.YONGHUID = item.ID;
                DB.Insert(model);
            }
        }

        public void RemoveUser(T_KESHI keShiModel, T_USER_INFO userModel)
        {
            DB.Delete<T_KESHIRENYUAN>(s => s.YONGHUID == userModel.ID && s.KESHIID == keShiModel.ID);
        }
    }
}