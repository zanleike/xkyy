using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using HursingManage.DBModel;

namespace HursingManage.AL.ZhiLiangKongZhi
{
    public class ALZhiLiangBiaoZhun : ALBase
    {
        bool VerifyModelByLeiBie(T_ZHILIANGBIAOZHUN_LEIBIE model, out string errMsg)
        {
            if (string.IsNullOrWhiteSpace(model.MINGCHENG))
            {
                errMsg = "类别名称不能为空";
                return false;
            }
            if (DB.QueryExist<T_ZHILIANGBIAOZHUN_LEIBIE>(s =>
                s.MINGCHENG == model.MINGCHENG && s.ID != model.ID))
            {
                errMsg = "类别名称已经存在";
                return false;
            }
            errMsg = null;
            return true;
        }
        public bool AddByLeiBie(T_ZHILIANGBIAOZHUN_LEIBIE model, out string errMsg)
        {
            if (!VerifyModelByLeiBie(model, out errMsg))
            {
                return false;
            }
            if (IsHuShiZhangLogin)
            {
                model.ISKESHIZHIKONG = 1;
                model.KESHIID = KeShiId;
                model.KESHI = KeShi;
            }
            else
            {
                model.ISKESHIZHIKONG = 0;
            }
            DB.Insert(model);
            return true;
        }
        public bool UpdateByLeiBie(T_ZHILIANGBIAOZHUN_LEIBIE model, out string errMsg)
        {
            if (!VerifyModelByLeiBie(model, out errMsg))
            {
                return false;
            }
            DB.Update(model);
            var sql = DB.CreateSqlBuilder();
            sql.AddSQLText("update T_ZHILIANGBIAOZHUN set LEIBIE='" + model.MINGCHENG + "' WHERE LEIBIEID='" + model.ID + "'");
            DB.ExecSql(sql);
            return true;
        }
        public bool DeleteByLeiBie(T_ZHILIANGBIAOZHUN_LEIBIE model, out string errMsg)
        {
            DB.Delete<T_ZHILIANGBIAOZHUN>(s => s.LEIBIEID == model.ID);
            DB.Delete(model);
            errMsg = null;
            return true;
        }
        public DataTable GetDataByLeiBie(string searchValue)
        {
            var query = DB.CreateQueryCondition<T_ZHILIANGBIAOZHUN_LEIBIE>();
            if (!IsAdminLogin)
            {
                int KeShiZhiKong = IsHuShiZhangLogin ? 1 : 0;
                query.WhereAnd(s => s.ISKESHIZHIKONG == KeShiZhiKong);
                if (IsHuShiZhangLogin)
                {
                    query.WhereAnd(s => s.KESHIID == KeShiId);
                }
            }
            if (!string.IsNullOrWhiteSpace(searchValue))
            {
                searchValue = string.Format("%{0}%", searchValue);
                query.WhereAnd(s => s.WEx_Like(s.MINGCHENG, searchValue));
            }

            //var sql = DB.CreateSqlBuilder();
            //sql.AddSQLText("select count(1) from T_ZHILIANGBIAOZHUN where LEIBIEID='" + leiBieModel.ID + "'");
            //var result = DB.QueryWhereScalar(sql);
            //int n = result.ToObject<int>();

            //sql = DB.CreateSqlBuilder();
            //sql.AddSQLText("update T_ZHILIANGBIAOZHUN_LEIBIE set BIAOZHUNSHU=" + n.ToString() + " WHERE ID='" + leiBieModel.ID + "'");
            //DB.ExecSql(sql);

            var ret = DB.QueryWhere<T_ZHILIANGBIAOZHUN_LEIBIE>(query);
            return ret.ToDataTable();
        }

        bool VerifyModelByNeiRong(T_ZHILIANGBIAOZHUN model, out string errMsg)
        {
            if (model.XUHAO == 0)
            {
                errMsg = "序号不能为空";
                return false;
            }
            if (string.IsNullOrWhiteSpace(model.NEIRONG))
            {
                errMsg = "标准内容不能为空";
                return false;
            }
            if (DB.QueryExist<T_ZHILIANGBIAOZHUN>(s =>
                s.XUHAO == model.XUHAO && s.ID != model.ID && s.LEIBIEID == model.LEIBIEID))
            {
                errMsg = "标准序号已经存在";
                return false;
            }
            errMsg = null;
            return true;
        }
        public bool AddByNeiRong(T_ZHILIANGBIAOZHUN model, out string errMsg)
        {
            if (!VerifyModelByNeiRong(model, out errMsg))
            {
                return false;
            }
            DB.Insert(model);
            return true;
        }
        public bool UpdateByNeiRong(T_ZHILIANGBIAOZHUN model, out string errMsg)
        {
            if (!VerifyModelByNeiRong(model, out errMsg))
            {
                return false;
            }
            DB.Update(model);
            //var sql = DB.CreateSqlBuilder();
            //sql.AddSQLText("select count(1) from T_ZHILIANGBIAOZHUN where LEIBIEID='" + model.LEIBIEID + "'");
            //var result = DB.QueryWhereScalar(sql);
            //int n = result.ToObject<int>();

            //sql = DB.CreateSqlBuilder();
            //sql.AddSQLText("update T_ZHILIANGBIAOZHUN_LEIBIE set BIAOZHUNSHU=" + n.ToString() + " WHERE ID='" + model.LEIBIEID + "'");
            //DB.ExecSql(sql);
            return true;
        }
        public bool DeleteByNeiRong(T_ZHILIANGBIAOZHUN model, out string errMsg)
        {
            DB.Delete(model);
            errMsg = null;
            return true;
        }
        public DataTable GetDataByNeiRong(T_ZHILIANGBIAOZHUN_LEIBIE leiBieModel, string searchValue)
        {
            var query = DB.CreateQueryCondition<T_ZHILIANGBIAOZHUN>();
            query.WhereAnd(s => s.LEIBIEID == leiBieModel.ID);
            if (!string.IsNullOrWhiteSpace(searchValue))
            {
                int xuHao = 0;
                if (int.TryParse(searchValue, out xuHao))
                {
                    query.WhereAnd(s => s.XUHAO == xuHao);
                }
                searchValue = string.Format("%{0}%", searchValue);
                query.WhereOr(s => s.WEx_Like(s.NEIRONG, searchValue));
            }
            query.OrderBy(s => s.XUHAO);


            var ret = DB.QueryWhere<T_ZHILIANGBIAOZHUN>(query);
            return ret.ToDataTable();
        }

        public void WeiHuBiaoZhunShu(T_ZHILIANGBIAOZHUN_LEIBIE leiBieModel)
        {
            var q = DB.QueryCount<T_ZHILIANGBIAOZHUN>(s => s.LEIBIEID == leiBieModel.ID);
            var biaoZhunShu = q.ToObject<int>();
            leiBieModel.ClearChangedState();
            leiBieModel.BIAOZHUNSHU = biaoZhunShu;
            DB.Update(leiBieModel);
        }
        public DataTable GetRenYuanData(T_ZHILIANGBIAOZHUN_LEIBIE leiBieModel)
        {
            var sql = DB.CreateSqlBuilder();
            sql.AddSQLText(@" IsDel=0 and Id not in (select RenYuanId From T_ZhiLiangBiaoZhun_QuanXian where LeiBieId={0}) and Role_Id in (select DictValue from T_Dictionary where DictType ='1001' )"
                , sql.AddParam(leiBieModel.ID));
            var query = DB.QueryWhere<T_USER_INFO>(sql);
            return query.ToDataTable();
        }
        public DataTable GetDataByQuanXianRenYuan(T_ZHILIANGBIAOZHUN_LEIBIE leiBieModel)
        {
            var query = DB.CreateQueryCondition<T_ZHILIANGBIAOZHUN_QUANXIAN>();
            query.WhereAnd(s => s.LEIBIEID == leiBieModel.ID);
            var result = DB.QueryWhere<T_ZHILIANGBIAOZHUN_QUANXIAN>(query);
            return result.ToDataTable();
        }
        public bool SaveRenYuanQuanXian(T_ZHILIANGBIAOZHUN_LEIBIE leiBie, List<T_USER_INFO> userList, out string errMsg)
        {
            foreach (T_USER_INFO userInfo in userList)
            {
                if (DB.QueryExist<T_ZHILIANGBIAOZHUN_QUANXIAN>(s => s.RENYUANID == userInfo.ID & s.LEIBIEID == leiBie.ID))
                {
                    continue;
                }
                T_ZHILIANGBIAOZHUN_QUANXIAN model = new T_ZHILIANGBIAOZHUN_QUANXIAN();
                model.LEIBIEID = leiBie.ID;
                model.BIANHAO = userInfo.USER_NO;
                model.MINGCHENG = userInfo.USER_NAME;
                model.LEIBIE = leiBie.MINGCHENG;
                model.RENYUANID = userInfo.ID;
                DB.Insert(model);
            }
            errMsg = null;
            return true;
        }
        public bool YiChuQuanXianRenYuan(T_ZHILIANGBIAOZHUN_QUANXIAN model, out string errMsg)
        {
            DB.Delete(model);
            errMsg = null;
            return true;
        }

        /// <summary>
        /// 将类别导入到科室，可导入的科室列表
        /// </summary>
        public DataTable GetImportKeShi(T_ZHILIANGBIAOZHUN_LEIBIE leiBie)
        {
            var query = DB.QueryWhere<T_KESHI>(s => s.ISDEL == 0 && s.MINGCHENG != "护理部");
            return query.ToDataTable();
        }

        public void SaveToKeShi(T_ZHILIANGBIAOZHUN_LEIBIE leiBie, List<T_KESHI> keShiList)
        {
            if (keShiList != null)
            {
                foreach (var item in keShiList)
                {
                    T_ZHILIANGBIAOZHUN_LEIBIE keShiLeiBie = new T_ZHILIANGBIAOZHUN_LEIBIE();
                    keShiLeiBie.ID = GetGuid();
                    keShiLeiBie.KESHIID = item.ID;
                    keShiLeiBie.KESHI = item.MINGCHENG;
                    keShiLeiBie.MINGCHENG = leiBie.MINGCHENG;
                    keShiLeiBie.MINGCHENG_PY = leiBie.MINGCHENG_PY;
                    keShiLeiBie.BIAOZHUNSHU = leiBie.BIAOZHUNSHU;
                    keShiLeiBie.BEIZHU = "";
                    keShiLeiBie.ISKESHIZHIKONG = 1;
                    DB.Insert(keShiLeiBie);

                    var biaoZhunQuery = DB.QueryWhere<T_ZHILIANGBIAOZHUN>(s => s.LEIBIEID == leiBie.ID);
                    var biaoZhunList = biaoZhunQuery.ToList();
                    foreach (var biaozhun in biaoZhunList)
                    {
                        biaozhun.LEIBIEID = keShiLeiBie.ID;
                        biaozhun.LEIBIE = keShiLeiBie.MINGCHENG;
                        biaozhun.SetFieldChanged(
                            T_ZHILIANGBIAOZHUN.CNLEIXING1,
                            T_ZHILIANGBIAOZHUN.CNLEIXING2,
                            T_ZHILIANGBIAOZHUN.CNNEIRONG,
                            T_ZHILIANGBIAOZHUN.CNXUHAO);
                        DB.Insert(biaozhun);
                    }
                }
            }
        }
    }
}