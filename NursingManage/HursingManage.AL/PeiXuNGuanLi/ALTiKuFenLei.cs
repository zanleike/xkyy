using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ZCJH.HursingManage.DBModel;
using System.Data;

namespace ZCJH.HursingManage.AL.PeiXuNGuanLi
{
    public class ALTiKuFenLei : ALBase
    {
        bool VerifyModel(T_SHITI_FENLEI model, out string errMsg)
        {
            if (string.IsNullOrWhiteSpace(model.MINGCHENG))
            {
                errMsg = "分类名称不能为空";
                return false;
            }
            if (DB.QueryExist<T_SHITI_FENLEI>(s => s.MINGCHENG == model.MINGCHENG && s.ID != model.ID))
            {
                errMsg = "分类名称已存在";
                return false;
            }
            errMsg = null;
            return true;
        }
        public bool Add(T_SHITI_FENLEI model, out string errMsg)
        {
            if (!VerifyModel(model, out errMsg))
            {
                return false;
            }
            DB.Insert(model);
            return true;
        }
        public bool Update(T_SHITI_FENLEI model, out string errMsg)
        {
            if (!VerifyModel(model, out errMsg))
            {
                return false;
            }
            DB.Update(model);
            return true;
        }
        public bool Delete(T_SHITI_FENLEI model, out string errMsg)
        {
            DB.Delete(model);
            errMsg = null;
            return true;
        }
        public DataTable GetData(string searchValue)
        {
            var query = DB.CreateQueryCondition<T_SHITI_FENLEI>();
            if (!string.IsNullOrWhiteSpace(searchValue))
            {
                searchValue = string.Format("%{0}%", searchValue);
                query.WhereAnd(s => 
                    s.WEx_Like(s.MINGCHENG, searchValue) ||
                    s.WEx_Like(s.MINGCHENG_PY, searchValue));
            }
            query.OrderBy(s => s.ADDTIME, ZhCun.Framework.EmOrderByType.Desc);
            var ret = DB.QueryWhere<T_SHITI_FENLEI>(query);
            return ret.ToDataTable();
        }
    }
}