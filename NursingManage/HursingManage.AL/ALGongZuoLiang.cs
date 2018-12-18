using System;
using System.Collections.Generic;
using HursingManage.DBModel;
using System.Data;
using Framework.Common.Helpers;
using Framework.Common;

namespace HursingManage.AL
{
    public class ALGongZuoLiang : ALBase
    {
        public List<T_KESHI> GetDepartList()
        {
            var queryCond = DB.CreateQueryCondition<T_KESHI>();
            queryCond.WhereAnd(s => s.ISDEL == 0);
            if (IsHuShiZhangLogin)
            {
                queryCond.WhereAnd(s => s.ID == KeShiId);
            }
            queryCond.OrderBy(s => s.MINGCHENG);
            var queryReuslt = DB.QueryWhere<T_KESHI>(queryCond);
            return queryReuslt.ToList();
        }

        public List<T_DANGAN> GetDangAnList()
        {
            var queryCond = DB.CreateQueryCondition<T_DANGAN>();
            queryCond.WhereAnd(s => s.ISDEL == 0);
            queryCond.OrderBy(s => s.BIANHAO);
            var queryReuslt = DB.QueryWhere<T_DANGAN>(queryCond);
            return queryReuslt.ToList();
        }
        
        public List<T_GONGZUOLIANG_DETAIL> GetGongZuoLiang(T_GONGZUOLIANG param, bool isReset = true)
        {
            var hisResult = DB.QueryWhere<T_GONGZUOLIANG>(s =>
                    s.HUSHI == param.HUSHI &&
                    s.HUSHIBIANMA == param.HUSHIBIANMA &&
                    s.KESHIBIANMA == param.KESHIBIANMA &&
                    s.STARTDATE == param.STARTDATE &&
                    s.ENDDATE == param.ENDDATE).ToEntity();
            if (!isReset)
            {
                if (hisResult != null)
                {
                    var r = DB.QueryWhere<T_GONGZUOLIANG_DETAIL>(s => s.MAINID == hisResult.ID).ToList();
                    return r;
                }
            }
            else
            {
                if (hisResult != null)
                {
                    DB.Delete<T_GONGZUOLIANG_DETAIL>(s => s.MAINID == hisResult.ID);
                    DB.Delete<T_GONGZUOLIANG>(s => s.ID == hisResult.ID);
                }
            }
            var peiZhiQuery = DB.CreateQueryCondition<T_GONGZUOLIANG_PEIZHI>();
            peiZhiQuery.OrderBy(s => s.ORDERNO);
            var peiZhi = DB.QueryWhere<T_GONGZUOLIANG_PEIZHI>(peiZhiQuery).ToList();
            var sqlBuilder = DB.CreateSqlBuilder();
            List<T_GONGZUOLIANG_DETAIL> rList = new List<T_GONGZUOLIANG_DETAIL>();
            if (peiZhi != null)
            {
                int ciFen;
                foreach (var item in peiZhi)
                {
                    ciFen = 0;
                    sqlBuilder.ClearResult();
                    //{0}：开始日期，{1}：结束日期，{2}：科室编码，{3}：护士编码，{4}：护士名称
                    sqlBuilder.AddSQLText(item.SQLTEXT,
                            param.STARTDATE,
                            param.ENDDATE,
                            param.KESHIBIANMA,
                            param.HUSHIBIANMA,
                            param.HUSHI
                    );
                    //TODOP://测试打印出sql
                    LogHelper.LogObj.Debug(sqlBuilder.SQLText);
                    DataTable searchResult = DB.QueryWhere(sqlBuilder).ToDataTable();
                    Dictionary<string, object> propertyDict = new Dictionary<string, object>();

                    for (int i = 1; i <= 31; i++)
                    {
                        if (searchResult == null || searchResult.Rows.Count == 0)
                        {
                            continue;
                        }
                        var rRow = searchResult.Select(string.Format("DateStr = '{0}-{1}'", param.STARTDATE.Substring(0, 7), i.ToString("00")));
                        if (rRow != null && rRow.Length > 0)
                        {
                            int dateCount = Convert.ToInt32(rRow[0][1]);
                            propertyDict.Add("DAY" + i, dateCount);
                            ciFen += dateCount;
                        }
                    }
                    T_GONGZUOLIANG_DETAIL detail = new T_GONGZUOLIANG_DETAIL();
                    detail.XUANMU = item.ITEMNAME;
                    detail.FENZHI = item.SCOREVALUE;
                    detail.CIFEN = ciFen;
                    detail.ZONGFEN = ciFen * item.SCOREVALUE;
                    ReflectionHelper.SetPropertyValue(detail, propertyDict);
                    rList.Add(detail);
                    
                }
            }
            if (isReset)
            {
                param.ID = GetGuid();
                foreach (var item in rList)
                {
                    item.MAINID = param.ID;
                    DB.Insert(item);
                }
                DB.Insert(param);
            }
            return rList;
        }
    }
}