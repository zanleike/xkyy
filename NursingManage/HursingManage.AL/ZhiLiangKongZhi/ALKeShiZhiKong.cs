using System;
using System.Collections.Generic;
using System.Linq;
using HursingManage.DBModel;
using System.Data;
using Framework.Core;

namespace HursingManage.AL.ZhiLiangKongZhi
{
    public class ALKeShiZhiKong : ALBase
    {
        /// <summary>
        /// 获取档案分页数据
        /// </summary>
        public DataTable GetData(int onePage, int pageNo, out int recordCount, string serValue = null, bool isAdSearch = false)
        {
            var query = DB.CreateQueryCondition<T_ZHIKONG_KESHI>();
            if (IsHuShiZhangLogin)
            {
                query.WhereAnd(s => s.KESHIID == CurrentLoginUser.KESHIID);
            }
            if (IsHuLiBuLogin)
            {
                query.WhereAnd(s => s.SHANGBAOZHUANGTAI == "是");
            }
            query.OnePage = onePage;
            query.PageNo = pageNo;
            query.OrderBy(s => s.KESHI).OrderBy(s => s.KESHI).OrderBy(s => s.JIANCHARIQI, Framework.EmOrderByType.Desc);
            DataTable dt;
            IQueryResult result;
            if (isAdSearch)
            {
                result = DB.QueryWhere<T_ZHIKONG_KESHI>(query, ADSqlBuilder);
            }
            else
            {
                if (!string.IsNullOrWhiteSpace(serValue))
                {
                    serValue = string.Format("%{0}%", serValue);
                    query.WhereAnd(s =>
                        s.WEx_Like(s.KESHI, serValue) ||
                        s.WEx_Like(s.JIANGPINGREN, serValue) ||
                        s.WEx_Like(s.SHANGBAOREN, serValue));
                }
                result = DB.QueryWhere<T_ZHIKONG_KESHI>(query);
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

        bool VerifyModel(T_ZHIKONG_KESHI model, out string errMsg)
        {
            if (model.JIANCHARIQI > DateTime.Now.AddMonths(1) && model.JIANCHARIQI < DateTime.Now.AddMonths(-2))
            {
                errMsg = "检查时间范围不正确";
                return false;
            }
            if (string.IsNullOrWhiteSpace(model.ZHIKONGRENYUAN))
            {
                errMsg = "质控人员不能为空";
                return false;
            }
            if (string.IsNullOrWhiteSpace(model.CANJIARENYUAN))
            {
                errMsg = "参加人员不能为空";
                return false;
            }
            errMsg = null;
            return true;
        }

        public bool AddKeShiJianCha(T_ZHIKONG_KESHI model, out string errMsg)
        {
            bool r = VerifyModel(model, out errMsg);
            model.KESHIID = CurrentLoginUser.KESHIID;
            model.KESHI = CurrentLoginUser.KESHIMINGCHENG;
            if (r)
            {
                DB.Insert(model);
            }
            return r;
        }
        public bool UpdateKeShiJianCha(T_ZHIKONG_KESHI model, out string errMsg)
        {
            bool r = VerifyModel(model, out errMsg);
            if (r)
            {
                DB.Update(model);
            }
            return r;
        }
        public bool DeleteKeShiJianCha(T_ZHIKONG_KESHI model, out string errMsg)
        {
            if (model.SHANGBAOZHUANGTAI == "是")
            {
                errMsg = "当前质控记录已经上报不允许删除。";
                return false;
            }
            if (DB.QueryExist<T_ZHIKONG_KESHI_NEIRONG>(s => s.MAINID == model.ID))
            {
                errMsg = "当前质控记录检查项不为空，不允许删除。";
                return false;
            }
            if (DB.QueryExist<T_ZHIKONG_KESHI_WENTI>(s => s.MAINID == model.ID))
            {
                errMsg = "当前质控记录 问题项不为空，不允许删除。";
                return false;
            }
            DB.Delete(model);
            //DB.Delete<T_ZHIKONG_KESHI_NEIRONG>(s => s.MAINID == model.ID);
            //DB.Delete<T_ZHIKONG_KESHI_WENTI>(s => s.MAINID == model.ID);
            errMsg = null;
            return true;
        }

        public DataTable GetBiaoZhunLeiBieData(T_ZHIKONG_KESHI keShiModel)
        {
            var querySql = DB.CreateSqlBuilder();
            querySql.AddSQLText(" KeShiId = {0} and IsKeShiZhiKong=1 and ID not in (select BiaoZhunLeiBieId from T_ZhiKong_KeShi_NeiRong where MainId={1})",
                querySql.AddParam(keShiModel.KESHIID),querySql.AddParam(keShiModel.ID));
            var query = DB.QueryWhere<T_ZHILIANGBIAOZHUN_LEIBIE>(querySql);
            var r = query.ToDataTable();
            return r;
        }

        public bool AddBiaoZhunLeiBie(T_ZHIKONG_KESHI zhiKongModel, List<T_ZHILIANGBIAOZHUN_LEIBIE> leiBieList, out string errMsg)
        {
            foreach (var item in leiBieList)
            {
                if (DB.QueryExist<T_ZHIKONG_KESHI_NEIRONG>(s => s.MAINID == zhiKongModel.ID && s.BIAOZHUNLEIBIEID == item.ID))
                {
                    continue;
                }
                T_ZHIKONG_KESHI_NEIRONG neiRongModel = new T_ZHIKONG_KESHI_NEIRONG();
                neiRongModel.MAINID = zhiKongModel.ID;
                neiRongModel.BIAOZHUNLEIBIEID = item.ID;
                neiRongModel.BIAOZHUNLEIBIE = item.MINGCHENG;
                neiRongModel.BIAOZHUNSHU = item.BIAOZHUNSHU;
                DB.Insert(neiRongModel);
            }
            errMsg = null;
            return true;
        }
        public bool RemoveBiaoZhunLeiBie(T_ZHIKONG_KESHI_NEIRONG leiBieModel, out string errMsg)
        {
            if (DB.QueryExist<T_ZHIKONG_KESHI_NEIRONG>(s => s.ID == leiBieModel.ID && s.SHIFOUQUEREN == "是"))
            {
                errMsg = "当前记录已经确认不允许移除";
                return false;
            }
            if (DB.QueryExist<T_ZHIKONG_KESHI_WENTI>(s => s.MAINID == leiBieModel.MAINID && s.BIAOZHUNLEIBIEID == leiBieModel.BIAOZHUNLEIBIEID))
            {
                errMsg = "请将当前类别的问题项删除后再进行移除。";
                return false;
            }
            errMsg = null;
            DB.Delete(leiBieModel);
            return true;
        }

        public bool NeiRongQueRen(T_ZHIKONG_KESHI_NEIRONG neiRongModel, out string errMsg)
        {
            if (DB.QueryExist<T_ZHIKONG_KESHI>(s => s.ID == neiRongModel.MAINID && s.SHANGBAOZHUANGTAI == "是"))
            {
                errMsg = "当前检查记录已经上报，不允许再次确认。";
                return false;
            }
            neiRongModel.ClearChangedState();
            var wenTiShu = DB.QueryCount<T_ZHIKONG_KESHI_WENTI>(s => s.MAINID == neiRongModel.MAINID && s.BIAOZHUNLEIBIEID == neiRongModel.BIAOZHUNLEIBIEID);
            neiRongModel.WENTISHU = wenTiShu.ToObject<int>();
            if (neiRongModel.BIAOZHUNSHU != 0)
            {
                neiRongModel.HEGELV = Math.Round((1 - neiRongModel.WENTISHU / neiRongModel.BIAOZHUNSHU) * 100, 2);
            }
            neiRongModel.SHIFOUQUEREN = "是";
            DB.Update(neiRongModel);
            errMsg = null;
            return true;
        }

        public List<T_ZHILIANGBIAOZHUN> GetBiaoZhunData(T_ZHIKONG_KESHI model)
        {
            var querySql = DB.CreateSqlBuilder();
            querySql.AddSQLText("LEIBIEID in (select BiaoZhunLeiBieId from T_ZHIKONG_KESHI_NEIRONG Where MainId={0})",
                querySql.AddParam(model.ID));
            var query = DB.QueryWhere<T_ZHILIANGBIAOZHUN>(querySql);
            return query.ToList();
        }

        public bool BaoCunWenTiXiang(T_ZHIKONG_KESHI zhiKongJiLuModel, List<T_ZHILIANGBIAOZHUN> wenTiXiang, out string errMsg)
        {
            if (wenTiXiang == null || wenTiXiang.Count == 0)
            {
                errMsg = "要添加的问题列表为空。";
                return false;
            }
            foreach (var item in wenTiXiang)
            {
                T_ZHIKONG_KESHI_WENTI wenTi = new T_ZHIKONG_KESHI_WENTI();
                wenTi.BIAOZHUN = item.NEIRONG;
                wenTi.BIAOZHUNID = item.ID;
                wenTi.BIAOZHUNLEIBIE = item.LEIBIE;
                wenTi.BIAOZHUNLEIBIEID = item.LEIBIEID;
                wenTi.LEIXING1 = item.LEIXING1;
                wenTi.LEIXING2 = item.LEIXING2;
                wenTi.MAINID = zhiKongJiLuModel.ID;
                wenTi.KESHIID = CurrentLoginUser.KESHIID;
                DB.Insert(wenTi);
            }

            var leiBieIds = wenTiXiang.Select(s => s.LEIBIEID).Distinct().ToArray();
            T_ZHIKONG_KESHI_NEIRONG neiRong = new T_ZHIKONG_KESHI_NEIRONG();
            neiRong.SHIFOUQUEREN = "否";
            neiRong.WENTISHU = 0;
            neiRong.HEGELV = 0;
            DB.Update(neiRong, s => s.MAINID == zhiKongJiLuModel.ID && s.WEx_In(T_ZHIKONG_KESHI_NEIRONG.CNBIAOZHUNLEIBIEID, leiBieIds));

            errMsg = null;
            return true;
        }
        public bool RemoveWenTi(T_ZHIKONG_KESHI_WENTI jieGuo, out string errMsg)
        {
            if (DB.QueryExist<T_ZHIKONG_KESHI>(s => s.ID == jieGuo.MAINID && s.SHANGBAOZHUANGTAI == "是"))
            {
                errMsg = "当前记录已经上报，不允许再移除。";
                return false;
            }
            T_ZHIKONG_KESHI_NEIRONG neiRong = new T_ZHIKONG_KESHI_NEIRONG();
            neiRong.SHIFOUQUEREN = "否";
            neiRong.WENTISHU = 0;
            neiRong.HEGELV = 0;
            DB.Update(neiRong, s => s.MAINID == jieGuo.MAINID && s.BIAOZHUNLEIBIEID == jieGuo.BIAOZHUNLEIBIEID);
            DB.Delete<T_ZHIKONG_KESHI_WENTI>(s => s.ID == jieGuo.ID);
            errMsg = null;
            return true;
        }
        public bool BaoCunWenTiShuoMing(T_ZHIKONG_KESHI_WENTI model, out string errMsg)
        {
            if (DB.QueryExist<T_ZHIKONG_KESHI>(s => s.ID == model.MAINID && s.SHANGBAOZHUANGTAI == "是"))
            {
                errMsg = "当前检查记录已经上报，不允许再次编辑。";
                return false;
            }
            model.ClearChangedState();
            model.SetFieldChanged(T_ZHIKONG_KESHI_WENTI.CNWENTISHUOMING);
            DB.Update(model);
            T_ZHIKONG_KESHI_NEIRONG neiRong = new T_ZHIKONG_KESHI_NEIRONG();
            neiRong.SHIFOUQUEREN = "否";
            neiRong.WENTISHU = 0;
            neiRong.HEGELV = 0;
            DB.Update(neiRong, s => s.MAINID == model.MAINID && s.BIAOZHUNLEIBIEID == model.BIAOZHUNLEIBIEID);

            errMsg = null;
            return true;
        }

        public bool ZhiKongJieGuoShangBao(T_ZHIKONG_KESHI model, out string errMsg)
        {
            //if (string.IsNullOrWhiteSpace(model.YUANYINFENXI))
            //{
            //    errMsg = "原因分析不能为空！";
            //    return false;
            //}
            //if (string.IsNullOrWhiteSpace(model.GAIJINCUOSHI))
            //{
            //    errMsg = "改进措施不能为空！";
            //    return false;
            //}
            if (DB.QueryExist<T_ZHIKONG_KESHI>(s => s.ID == model.ID && s.SHANGBAOZHUANGTAI == "是"))
            {
                errMsg = "该记录已经上报，不允许修改";
                return false;
            }
            if (model.SHANGBAOZHUANGTAI == "是")
            {
                if (DB.QueryExist<T_ZHIKONG_KESHI_NEIRONG>(s => s.MAINID == model.ID && s.SHIFOUQUEREN != "是"))
                {
                    errMsg = "检查内容未全部确认不允许上报。";
                    return false;
                }
                model.SHANGBAOREN = CurrentLoginUser.USER_NAME;
                model.SHANGBAOSHIJIAN = GetNowTime();
            }
            else
            {
                model.SHANGBAOREN = string.Empty;
            }
            DB.Update(model);
            errMsg = null;
            return true;
        }

        public List<T_ZHIKONG_KESHI_NEIRONG> GetNeiRongData(T_ZHIKONG_KESHI jianChaJiluModel)
        {
            if (jianChaJiluModel == null) return null;
            var query = DB.QueryWhere<T_ZHIKONG_KESHI_NEIRONG>(s => s.MAINID == jianChaJiluModel.ID);
            return query.ToList();
        }
        public List<T_ZHIKONG_KESHI_WENTI> GetJieGuoData(T_ZHIKONG_KESHI jianChaJiluModel)
        {
            if (jianChaJiluModel == null) return null;
            var query = DB.CreateQueryCondition<T_ZHIKONG_KESHI_WENTI>();
            query.WhereAnd(s => s.MAINID == jianChaJiluModel.ID);
            query.OrderBy(s => s.BIAOZHUNLEIBIEID).OrderBy(s => s.BIAOZHUN);
            var result = DB.QueryWhere<T_ZHIKONG_KESHI_WENTI>(query);
            return result.ToList();
        }

        public DataTable GetKeShiRenYuan()
        {
            var query = DB.QueryWhere<T_DANGAN>(s => s.KESHIID == KeShiId && s.ISDEL == 0);
            return query.ToDataTable();
        }
    }
}