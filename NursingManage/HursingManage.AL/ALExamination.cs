using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HursingManage.AL.PeiXuNGuanLi;
using HursingManage.DBModel;
using Framework;
using Framework.Common;

namespace HursingManage.AL
{
    /// <summary>
    /// 考试客户端答题
    /// </summary>
    public class ALExamination : ALBase
    {
        public T_PEIXUNJIHUA GetJiHuaModel(string jiHuaId)
        {
            var query = DB.QueryWhere<T_PEIXUNJIHUA>(s => s.ID == jiHuaId);
            return query.ToEntity();
        }

        public bool KaoShiQianDao(string keShiid, string renYuanId, out T_PEIXUNJIHUA_MINGXI mingXiModel, out string errMsg)
        {
            mingXiModel = null;
            if (string.IsNullOrWhiteSpace(keShiid))
            {
                errMsg = "请选择科室";
                return false;
            }
            if (string.IsNullOrWhiteSpace(renYuanId))
            {
                errMsg = "请选择考试人员";
                return false;
            }
            var query = DB.CreateQueryCondition<T_PEIXUNJIHUA_MINGXI>();
            query.WhereAnd(s => s.RENYUANID == renYuanId && s.KESHIID == keShiid);
            query.OrderBy(s => s.ADDTIME, Framework.EmOrderByType.Desc);
            var result = DB.QueryWhere<T_PEIXUNJIHUA_MINGXI>(query);
            mingXiModel = result.ToEntity();
            if (mingXiModel == null)
            {
                errMsg = "该科室人员未加入考试计划中。";
                return false;
            }
            if (mingXiModel.DATIBIAOZHI == "是")
            {
                errMsg = "当前人员已经答题";
                return false;
            }
            string jiHuaId = mingXiModel.JIHUAID;
            //随机读取模板
            var queryMuBan = DB.QueryWhere<T_PEIXUNJIHUA_MUBAN>(s => s.JIHUAID == jiHuaId);
            var muBanList = queryMuBan.ToList();
            if (muBanList == null || muBanList.Count == 0)
            {
                errMsg = "当前计划中未添加试题模板。";
                return false;
            }
            Random r = new Random();
            int a = r.Next(0, muBanList.Count);
            var radMuBan = muBanList[a];//随机模板Id
            mingXiModel.ClearChangedState();
            mingXiModel.MUBANID = radMuBan.MUBANID;
            mingXiModel.MUBAN = radMuBan.MUBAN;
            DB.Update(mingXiModel);
            errMsg = "未知";
            return true;
        }
        public bool KaiShiDaTi(T_PEIXUNJIHUA_MINGXI mingXiModel, out string errMsg)
        {
            if (mingXiModel == null)
            {
                errMsg = "未正确签到。";
                return false;
            }
            if (DB.QueryExist<T_PEIXUNJIHUA_MINGXI>(s => s.DATIBIAOZHI == "是" && s.ID == mingXiModel.ID))
            {
                errMsg = "该试题已经答题，不允许再次答题。";
                return false;
            }
            mingXiModel.ClearChangedState();
            mingXiModel.DATIKAISHI = GetNowTime();
            mingXiModel.DATIBIAOZHI = "是";
            DB.Update(mingXiModel);
            errMsg = null;
            return true;
        }

        public List<V_SHITI_MUBAN_MINGXI> GetMBanMingXiData(string muBanId)
        {
            var query = DB.CreateQueryCondition<V_SHITI_MUBAN_MINGXI>();
            query.WhereAnd(s => s.MUBANID == muBanId);
            query.OrderBy(s => s.SHITIXUHAO);
            var result = DB.QueryWhere<V_SHITI_MUBAN_MINGXI>(query);
            return result.ToList();
        }
        public bool SaveDaTi(T_PEIXUNJIHUA_MINGXI model, out string errMsg)
        {
            if (DB.QueryExist<T_PEIXUNJIHUA_MINGXI>(s => s.DATIBIAOZHI == "是" && s.SHITISHU > 0 && s.ID == model.ID))
            {
                errMsg = "该人已经提交了试题，不允许再次提交。";
                return false;
            }
            model.DATIJIESHU = GetNowTime();
            model.PINGFENSHIJIAN = model.DATIJIESHU;
            model.PINGFENREN = "SYSTEM";
            DB.Update(model);
            errMsg = null;
            return true;
        }

        public void SetLoginState(string mingXiId)
        {
            T_PEIXUNJIHUA_MINGXI model = new T_PEIXUNJIHUA_MINGXI();
            model.ID = mingXiId;
            model.DENGLUBIAOZHI = "是";
            var r = DB.Update(model);
            LogHelper.LogObj.Info(r.SQL);
        }

        /// <summary>
        /// 根据人员编号和姓名计划明细
        /// </summary>
        /// <param name="bianHao">员工编号</param>
        /// <param name="kaoHao">考号</param>
        /// <returns>返回人员考试记录</returns>
        public V_PEIXUNJIHUA_MINGXI GetJiHuaMingXiModel(string bianHao, string kaoHao, string mingXiId, out string errMsg)
        {
            V_PEIXUNJIHUA_MINGXI mingXiModel;
            if (!string.IsNullOrWhiteSpace(mingXiId))
            {
                mingXiModel = DB.QueryWhere<V_PEIXUNJIHUA_MINGXI>(s => s.ID == mingXiId).ToEntity();
            }
            else
            {
                mingXiModel = DB.QueryWhere<V_PEIXUNJIHUA_MINGXI>(s => s.BIANHAO == bianHao && s.KAOHAO == kaoHao).ToEntity();
            }
            if (mingXiModel == null)
            {
                errMsg = "未获取到指定人员考试内容或考号不正确。";
                return null;
            }
            if (mingXiModel.DATIBIAOZHI == "是")
            {
                errMsg = "当前试题已提交。";
                return null;
            }
            if (mingXiModel.DENGLUBIAOZHI == "是" && string.IsNullOrWhiteSpace(mingXiId))
            {
                errMsg = "当前用户已登陆。";
                return null;
            }
            if (!DB.QueryExist<T_PEIXUNJIHUA_MUBAN>(s => s.JIHUAID == mingXiModel.JIHUAID && s.MUBANID == mingXiModel.MUBANID && s.KAIQIKAOSHI == "是"))
            {
                errMsg = "当前考题未开启，请联系护理部人员";
                return null;
            }

            //var renYuanQuery = DB.CreateQueryCondition<V_PEIXUNJIHUA_MINGXI>();

            //renYuanQuery.WhereAnd(s => s.DATIBIAOZHI == "否" && (s.DENGLUBIAOZHI == "否" || s.ID == mingXiId) && s.BIANHAO == bianHao && s.KAOHAO == kaoHao);
            //renYuanQuery.OrderBy(s => s.LASTTIME, EmOrderByType.Desc);
            ////查询已确定但未考试的人员，如果存在多条则表示有其它计划未考的计划
            //var kaoShiRenYuanResult = DB.QueryWhere<V_PEIXUNJIHUA_MINGXI>(renYuanQuery);
            //var model = kaoShiRenYuanResult.ToEntity();
            //if (model == null)
            //{
            //    errMsg = "未获取到该人员的考试计划或该人员已登陆";
            //    return null;
            //}


            //LogHelper.LogObj.InfoFormat("获取计划明细记录：{0}", kaoShiRenYuanResult.SQL);
            errMsg = null;
            return mingXiModel;
        }

        /// <summary>
        /// 提交答案
        /// </summary>
        public bool SaveDaAn(V_PEIXUNJIHUA_MINGXI mingXiModel, out string errMsg)
        {


            if (DB.QueryExist<V_PEIXUNJIHUA_MINGXI>(s => s.DATIBIAOZHI == "是" && s.KAOHAO == mingXiModel.KAOHAO && s.ID == mingXiModel.ID))
            {
                errMsg = "该试题已经提交过试题或该人员不存。";
                return false;
            }
            if (!DB.QueryExist<V_PEIXUNJIHUA_MINGXI>(s => s.KAOHAO == mingXiModel.KAOHAO && s.ID == mingXiModel.ID))
            {
                errMsg = "该试卷考号不正确，请确认是否重置状态。";
                return false;
            }
           
            LogHelper.LogObj.InfoFormat("JIHUAID:{0},MUBANID:{1}", mingXiModel.JIHUAID, mingXiModel.MUBANID);
            var jiHuaMIngXi = DB.QueryWhere<T_PEIXUNJIHUA_MINGXI>(s => s.ID == mingXiModel.ID).ToEntity();
            if (!DB.QueryExist<T_PEIXUNJIHUA_MUBAN>(s => s.JIHUAID == jiHuaMIngXi.JIHUAID && s.MUBANID == jiHuaMIngXi.MUBANID && s.KAIQIKAOSHI == "是"))
            {
                errMsg = "当前考题已关闭，不允许再提交答案";
                return false;
            }
            //mingXiModel.ClearChangedState();
            //mingXiModel.DATIKAISHI = GetNowTime();
            // DB.Update(jiHuaMIngXi);
            //T_PEIXUNJIHUA_MINGXI jiHuaMIngXi = new T_PEIXUNJIHUA_MINGXI();
            jiHuaMIngXi.ClearChangedState();
            jiHuaMIngXi.DATIBIAOZHI = "是";
            jiHuaMIngXi.ID = mingXiModel.ID;
            jiHuaMIngXi.DATI = mingXiModel.DATI;
            jiHuaMIngXi.MUBANID = mingXiModel.MUBANID;
            jiHuaMIngXi.PINGFENREN = "SYSTEM";
            jiHuaMIngXi.PINGFENSHIJIAN = GetNowTime();
            jiHuaMIngXi.DATIKAISHI = mingXiModel.DATIKAISHI;
            jiHuaMIngXi.DATIJIESHU = mingXiModel.DATIJIESHU;
            jiHuaMIngXi.TIJIAOIP = mingXiModel.TIJIAOIP;
            return ALShiTiPingFen.ChongXinPingFen(jiHuaMIngXi, out errMsg);
        }
    }
}