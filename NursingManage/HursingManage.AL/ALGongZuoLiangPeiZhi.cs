using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using HursingManage.DBModel;

namespace HursingManage.AL
{
    public class ALGongZuoLiangPeiZhi : ALBase
    {
        public DataTable GetData()
        {
            var query = DB.CreateQueryCondition<T_GONGZUOLIANG_PEIZHI>();
            query.OrderBy(s => s.ORDERNO);
            var result = DB.QueryWhere<T_GONGZUOLIANG_PEIZHI>(query);
            return result.ToDataTable();
        }
        public bool VerifyModel(T_GONGZUOLIANG_PEIZHI model, out string errMsg)
        {
            if (model.ORDERNO == 0)
            {
                errMsg = "排序不能为0或格式不正确！";
                return false;
            }
            if (string.IsNullOrWhiteSpace(model.ITEMNAME))
            {
                errMsg = "项目名称不能为空";
                return false;
            }
            if (DB.QueryExist<T_GONGZUOLIANG_PEIZHI>(s => s.ITEMNAME == model.ITEMNAME && s.ID != model.ID))
            {
                errMsg = "项目名称已存在";
                return false;
            }
            errMsg = null;
            return true;
        }
        public bool Add(T_GONGZUOLIANG_PEIZHI model, out string errMsg)
        {
            if (!VerifyModel(model, out errMsg))
            {
                return false;
            }
            DB.Insert(model);
            errMsg = null;
            return true;
        }
        public bool Update(T_GONGZUOLIANG_PEIZHI model, out string errMsg)
        {
            if (!VerifyModel(model, out errMsg))
            {
                return false;
            }
            DB.Update(model);
            errMsg = null;
            return true;
        }
        public bool Delete(T_GONGZUOLIANG_PEIZHI model, out string errMsg)
        {
            DB.Delete(model);
            errMsg = null;
            return true;
        }
    }
}
