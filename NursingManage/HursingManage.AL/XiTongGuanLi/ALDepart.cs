using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HursingManage.DBModel;

namespace HursingManage.AL.XiTongGuanLi
{
    public class ALDepart : ALBase
    {
        public List<T_DEPART> GetDepartList()
        {
            var query = DB.CreateQueryCondition<T_DEPART>();
            query.OrderBy(s => s.BIANMA);
            var result = DB.QueryWhere<T_DEPART>(query);
            return result.ToList();
        }
        public bool VerifyModel(T_DEPART model, out string errMsg)
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
            if (DB.QueryExist<T_DEPART>(s => s.MINGCHENG == model.MINGCHENG && s.ID != model.ID && s.ISDEL == 0))
            {
                errMsg = "科室名称已存在";
                return false;
            }
            if (DB.QueryExist<T_DEPART>(s => s.BIANMA == model.BIANMA && s.ID != model.ID && s.ISDEL == 0))
            {
                errMsg = "科室编码已存在";
                return false;
            }
            errMsg = null;
            return true;
        }
        public bool Add(T_DEPART model, out string errMsg)
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
        public bool Update(T_DEPART model, out string errMsg)
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
        public bool Delete(T_DEPART model, out string errMsg)
        {
            model.ClearChangedState();
            model.ISDEL = 1;
            DB.Update(model);
            WriteDBLog("删除科室：{0}", model.MINGCHENG);
            errMsg = null;
            return true;
        }
    }
}