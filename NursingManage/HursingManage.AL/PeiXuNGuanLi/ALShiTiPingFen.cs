using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using HursingManage.DBModel;
using Framework.Common.Helpers;

namespace HursingManage.AL.PeiXuNGuanLi
{
    public class ALShiTiPingFen : ALBase
    {
        public DataTable GetDataByJiHuaKeShi(string serValue)
        {
            var query = DB.CreateQueryCondition<V_PEIXUNJIHUA_KESHI>();
            if (!string.IsNullOrWhiteSpace(serValue))
            {
                serValue = string.Format("%{0}%", serValue);
                query.WhereAnd(s =>
                    s.WEx_Like(s.KESHI, serValue) ||
                    s.WEx_Like(s.NEIRONG, serValue));
            }
            query.OrderBy(s => s.ADDTIME, Framework.EmOrderByType.Desc);
            var ret = DB.QueryWhere<V_PEIXUNJIHUA_KESHI>(query);
            return ret.ToDataTable();
        }
        public DataTable GetDataByRenYuan(V_PEIXUNJIHUA_KESHI model, string serValue)
        {
            var query = DB.CreateQueryCondition<V_PEIXUNJIHUA_MINGXI>();
            if (!string.IsNullOrWhiteSpace(serValue))
            {
                query.WhereAnd(s =>
                    s.WEx_Like(s.BIANHAO, serValue) ||
                    s.WEx_Like(s.XINGMING, serValue) ||
                    s.WEx_Like(s.XINGMING_PY, serValue));
            }
            query.WhereAnd(s => s.JIHUAID == model.JIHUAID && s.KESHIID == model.KESHIID);
            query.OrderBy(s => s.MUBAN);
            var ret = DB.QueryWhere<V_PEIXUNJIHUA_MINGXI>(query);
            return ret.ToDataTable();
        }
        public List<V_SHITI_MUBAN_MINGXI> GetMuBanMingXiData(V_PEIXUNJIHUA_MINGXI jiHuaModel)
        {
            var query = DB.CreateQueryCondition<V_SHITI_MUBAN_MINGXI>();
            query.WhereAnd(s => s.MUBANID == jiHuaModel.MUBANID);
            query.OrderBy(s => s.SHITIXUHAO);
            var ret = DB.QueryWhere<V_SHITI_MUBAN_MINGXI>(query);
            return ret.ToList();
        }
        /// <summary>
        /// 试题评分
        /// </summary>
        public bool SavePingFeng(T_PEIXUNJIHUA_MINGXI jiHuaXimu, out string errMsg)
        {
            jiHuaXimu.PINGFENREN = CurrentLoginUser.USER_NAME;
            jiHuaXimu.PINGFENRENID = CurrentLoginUser.ID;
            jiHuaXimu.PINGFENSHIJIAN = GetNowTime();
            jiHuaXimu.DATIBIAOZHI = "是";
            DB.Update(jiHuaXimu);
            errMsg = null;
            return true;
        }

        public bool ChongZhiZhuangTai(V_PEIXUNJIHUA_MINGXI jiHuaXimu, out string errMsg)
        {
            T_PEIXUNJIHUA_MINGXI model = new T_PEIXUNJIHUA_MINGXI();
            model.ID = jiHuaXimu.ID;
            model.DATIBIAOZHI = "否";
            model.DENGLUBIAOZHI = "否";
            //model.KAOHAO = StringHelper.GetRoamdNumberStr(jiHuaXimu.BIANHAO, 6);
            WriteDBLog("重置：{0} 答题状态，可重新考试,新考号：{1}", jiHuaXimu.XINGMING, model.KAOHAO);
            DB.Update(model);
            errMsg = null;
            return true;
        }
        /// <summary>
        /// 重新对人员进行评分
        /// </summary>
        public static bool ChongXinPingFen(T_PEIXUNJIHUA_MINGXI renYuan, out string errMsg)
        {
            if (string.IsNullOrWhiteSpace(renYuan.DATI))
            {
                errMsg = "答题内容为空，评分失败。";
                return false;
            }
            var muBanShiTiQuery = ALCommon.Instance.DB.CreateQueryCondition<V_SHITI_MUBAN_MINGXI>();
            muBanShiTiQuery.WhereAnd(s => s.MUBANID == renYuan.MUBANID);
            muBanShiTiQuery.OrderBy(s => s.SHITIXUHAO);
            var muBanReuslt = ALCommon.Instance.DB.QueryWhere<V_SHITI_MUBAN_MINGXI>(muBanShiTiQuery);
            var muBanShiTi = muBanReuslt.ToList();
            string[] daTi = renYuan.DATI.Split(',');
            if (daTi.Length > muBanShiTi.Count)
            {
                errMsg = string.Format("重新评分发生程序逻辑异常，答题数量大于模板试题数量，T_PEIXUNJIHUA_MINGXI.ID：" + renYuan.ID);
                return false;
            }
            decimal newFenShu = 0; //分数
            int zqs = 0; //正确数；
            for (int i = 0; i < daTi.Length; i++)
            {
                if (StringHelper.StringEquals(muBanShiTi[i].DAAN, daTi[i]))
                {
                    newFenShu += muBanShiTi[i].FENSHU;
                    zqs++;
                }
            }
            if (renYuan.ZHENGQUESHU != zqs || renYuan.FENSHU != newFenShu)
            {
                ALCommon.Instance.WriteDBLog("T_PEIXUNJIHUA_MINGXI.ID = {0},原分值:{1},原正确数,{2},新分值:{3}，新正确数:{4}",
                    renYuan.ID, renYuan.FENSHU, renYuan.ZHENGQUESHU, newFenShu, zqs);
            }
            //renYuan.ClearChangedState();
            renYuan.SHITISHU = muBanShiTi.Count;
            renYuan.FENSHU = newFenShu;
            renYuan.ZHENGQUESHU = zqs;
            var queryResult = ALCommon.Instance.DB.Update(renYuan);
            if (queryResult.Count != 1)
            {
                errMsg = "提交答案更新失败。";
                return false;
            }
            errMsg = null;
            return true;
        }
    }
}