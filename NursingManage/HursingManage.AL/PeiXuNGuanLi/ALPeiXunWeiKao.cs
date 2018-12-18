using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HursingManage.DBModel;

namespace HursingManage.AL.PeiXuNGuanLi
{
    public class ALPeiXunWeiKao : ALBase
    {
        public int GetKeShiRenShu(V_PEIXUNJIHUA_KESHI keShiJiHuaModel)
        {
            var ret = DB.QueryCount<T_DANGAN>(s => s.KESHIID == keShiJiHuaModel.KESHIID && s.ISDEL==0);
            return ret.ToObject<int>();
        }
        public int GetKaoShiRenShu(V_PEIXUNJIHUA_KESHI keShiJiHuaModel)
        {
            var ret = DB.QueryCount<T_PEIXUNJIHUA_MINGXI>(s => s.KESHIID == keShiJiHuaModel.KESHIID && s.JIHUAID == keShiJiHuaModel.JIHUAID);
            return ret.ToObject<int>();
        }
        public List<T_PEIXUNJIHUA_MINGXI_WEIKAO> GetWeiKaoRenYuan(V_PEIXUNJIHUA_KESHI keShiJiHuaModel)
        {
            P_GetWeiKaoShiRenYuan p = new P_GetWeiKaoShiRenYuan();
            p.pJiHuaId = keShiJiHuaModel.JIHUAID;
            p.pKeShiId = keShiJiHuaModel.KESHIID;
            var r = DB.ExecProcedure(p);
            var rList = r.ToList<T_PEIXUNJIHUA_MINGXI_WEIKAO>();
            return rList;
        }

        public bool BaoCunWeiKaoYuanYin(V_PEIXUNJIHUA_KESHI keShiJiHuaModel, List<T_PEIXUNJIHUA_MINGXI_WEIKAO> weiKaoList, out string errMsg)
        {
            keShiJiHuaModel.ClearChangedState();
            keShiJiHuaModel.SHIKAORENSHU = GetKaoShiRenShu(keShiJiHuaModel);
            keShiJiHuaModel.YINGKAORENSHU = GetKeShiRenShu(keShiJiHuaModel);
            DB.Update(keShiJiHuaModel);
            DB.Delete<T_PEIXUNJIHUA_MINGXI_WEIKAO>(s => s.KESHIID == keShiJiHuaModel.KESHIID && s.JIHUAID == keShiJiHuaModel.JIHUAID);

            if (weiKaoList != null)
            {
                foreach (var item in weiKaoList)
                {
                    item.ClearChangedState();
                    item.SetFieldChanged(T_PEIXUNJIHUA_MINGXI_WEIKAO.CNYUANYIN);
                    item.SetFieldChanged(T_PEIXUNJIHUA_MINGXI_WEIKAO.CNBIANHAO);
                    item.SetFieldChanged(T_PEIXUNJIHUA_MINGXI_WEIKAO.CNXINGMING);
                    item.SetFieldChanged(T_PEIXUNJIHUA_MINGXI_WEIKAO.CNRENYUANID);
                    item.SetFieldChanged(T_PEIXUNJIHUA_MINGXI_WEIKAO.CNJIHUAID);
                    item.SetFieldChanged(T_PEIXUNJIHUA_MINGXI_WEIKAO.CNKESHIID);
                    DB.Insert(item);
                }
            }
            errMsg = null;
            return true;
        }
    }
}