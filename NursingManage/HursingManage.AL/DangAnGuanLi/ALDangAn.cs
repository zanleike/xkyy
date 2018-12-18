using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HursingManage.DBModel;
using System.Data;
using Framework.Core;
using Framework.Common.Helpers;

namespace HursingManage.AL.DangAnGuanLi
{
    public class ALDangAn : ALBase
    {
        public bool VerifyModel(T_DANGAN model, out string errMsg)
        {
            if (string.IsNullOrWhiteSpace(model.BIANHAO))
            {
                errMsg = "员工编号不能为空";
                return false;
            }
            if (string.IsNullOrWhiteSpace(model.XINGMING))
            {
                errMsg = "员工姓名不能为空";
                return false;
            }
            if (string.IsNullOrWhiteSpace(model.KESHIID) || string.IsNullOrWhiteSpace(model.KESHI))
            {
                errMsg = "科室不能为空";
                return false;
            }
            if (string.IsNullOrWhiteSpace(model.SHIFOUZAIZHI))
            {
                errMsg = "是否在职不能为空";
                return false;
            }
            if (!string.IsNullOrWhiteSpace(model.SHENFENZHENG) && !IdentityHelper.CheckID(model.SHENFENZHENG, out errMsg))
            {
                return false;
            }
            if (DB.QueryExist<T_DANGAN>(s => s.BIANHAO == model.BIANHAO && s.ID != model.ID && s.ISDEL == 0))
            {
                errMsg = "员工编号已存在";
                return false;
            }
            
            errMsg = null;
            return true;
        }
        void AddOrUpdateEx(T_DANGAN model)
        {
            var exModel = model.ExDangAn;
            if (exModel == null)
            {
                exModel = new T_DANGAN_EX();
            }
            exModel.DANGANID = model.ID;
            exModel.BIANHAO = model.BIANHAO;
            exModel.XINGMING = model.XINGMING;
            exModel.XINGMING_PY = model.XINGMING_PY;

            if (!DB.QueryExist<T_DANGAN_EX>(s => s.DANGANID == model.ID))
            {
                //新增
                DB.Insert(exModel);
            }
            else
            {
                DB.Update(exModel, s => s.DANGANID == model.ID);
            }
        }
        public T_DANGAN_EX GetDangAnEx(T_DANGAN model)
        {
            var query = DB.QueryWhere<T_DANGAN_EX>(s => s.DANGANID == model.ID);
            var result = query.ToEntity();
            model.ExDangAn = result;
            return result;
        }
        public bool Add(T_DANGAN model, out string errMsg)
        {
            if (!VerifyModel(model, out errMsg))
            {
                return false;
            }
            model.ID = GetGuid();
            var exModel = model.ExDangAn;
            if (exModel == null)
            {
                exModel = new T_DANGAN_EX();
            }
            AddOrUpdateEx(model);
            DB.Insert(model);
            return true;
        }
        public bool Update(T_DANGAN model, out string errMsg)
        {
            if (!VerifyModel(model, out errMsg))
            {
                return false;
            }
            DB.Update(model);
            AddOrUpdateEx(model);
            return true;
        }
        public bool Delete(T_DANGAN model, out string errMsg)
        {
            model.ClearChangedState();
            model.ISDEL = 1;
            DB.Update(model);
            WriteDBLog("删除人员,编号：{0}，姓名：{1},", model.BIANHAO, model.XINGMING);
            errMsg = null;
            return true;
        }
        public DataTable GetDangAnData(string serValue)
        {
            var queryCondition = DB.CreateQueryCondition<T_DANGAN>();
            queryCondition.WhereAnd(s => s.ISDEL == 0);
            if (!string.IsNullOrWhiteSpace(serValue))
            {
                string likeStr = string.Format("%{0}%", serValue);
                queryCondition.WhereAnd(s =>
                    s.WEx_Like(s.XINGMING, likeStr) ||
                    s.WEx_Like(s.XINGMING_PY, likeStr) ||
                    s.WEx_Like(s.BIANHAO, likeStr)
                    );
            }
            if (IsHuShiZhangLogin)
            {
                queryCondition.WhereAnd(s => s.KESHIID == CurrentLoginUser.KESHIID);
                queryCondition.OrderBy(s => s.BIANHAO);
            }
            else
            {
                queryCondition.OrderBy(s => s.KESHI);
            }

            queryCondition.WhereAnd(s => s.ISDEL == 0);
            var r = DB.QueryWhere<T_DANGAN>(queryCondition);
            var r2 = r.ToDataTable();
            return r2;
        }

        /// <summary>
        /// 获取档案分页数据
        /// </summary>
        public DataTable GetData(int onePage, int pageNo, out int recordCount, bool isAdSearch = false, string serValue = null)
        {
            var query = DB.CreateQueryCondition<V_DANGAN>();
            if (IsHuShiZhangLogin)
            {
                query.WhereAnd(s => s.KESHIID == CurrentLoginUser.KESHIID);
            }
            query.WhereAnd(s => s.ISDEL == 0);
            query.OnePage = onePage;
            query.PageNo = pageNo;
            query.OrderBy(s => s.KESHI).OrderBy(s => s.KESHI).OrderBy(s => s.XINGMING);
            DataTable dt;
            IQueryResult result;
            if (isAdSearch)
            {
                result = DB.QueryWhere<V_DANGAN>(query, ADSqlBuilder);
            }
            else
            {
                if (!string.IsNullOrWhiteSpace(serValue))
                {
                    serValue = string.Format("%{0}%", serValue);
                    query.WhereAnd(s =>
                        s.WEx_Like(s.KESHI, serValue) ||
                        s.WEx_Like(s.BIANHAO, serValue) ||
                        s.WEx_Like(s.XINGMING, serValue) ||
                        s.WEx_Like(s.XINGMING_PY, serValue));
                }
                result = DB.QueryWhere<V_DANGAN>(query);
            }
            dt = result.ToDataTable();
            if (query.OnePage == 0 || query.PageNo == 0)
            {
                recordCount = result.Count;
            }
            else
            {
                recordCount = query.RecordCount;
            }
            return dt;
        }
    }
}