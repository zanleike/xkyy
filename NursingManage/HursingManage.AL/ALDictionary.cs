using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HursingManage.DBModel;
using Framework.Core;

namespace HursingManage.AL
{
    public enum DictType : int
    {
        /// <summary>
        /// 用户类型
        /// </summary>
        UserType = 1000,
        /// <summary>
        /// 民族
        /// </summary>
        MinZu = 5001,
        /// <summary>
        /// 护士能级
        /// </summary>
        NengJi = 5002,
        /// <summary>
        /// 婚否
        /// </summary>
        HunFou = 5003,
        /// <summary>
        /// 学历
        /// </summary>
        XueLi = 5004,
        /// <summary>
        /// 在职情况
        /// </summary>
        ZaiZhiQingKuang = 5005,
        /// <summary>
        /// 职称
        /// </summary>
        ZhiCheng = 5006,
        /// <summary>
        /// 政治面貌
        /// </summary>
        ZhengZhiMianMao = 5007,
        /// <summary>
        /// 职务
        /// </summary>
        ZhiWu = 5008,
        /// <summary>
        /// 学位
        /// </summary>
        XueWei = 5009
    }

    public class ALDictionary : ALBase
    {
        public List<T_DICTIONARY> GetDictList(DictType dictTypeEm)
        {
            int dictType = (int)dictTypeEm;
            return GetDictList(dictType);
        }
        public List<T_DICTIONARY> GetDictList(int dictType)
        {
            var queryCond = DB.CreateQueryCondition<T_DICTIONARY>();
            queryCond.WhereAnd(s => s.DICTTYPE == dictType && s.ISDELETE == 0);
            queryCond.OrderBy(s => s.DICTVALUEORDER);
            IQueryResult<T_DICTIONARY> dictList = DB.QueryWhere<T_DICTIONARY>(s => s.DICTTYPE == dictType);
            return dictList.ToList();
        }
        bool VerifyModel(T_DICTIONARY dict, out string errMsg)
        {
            if (string.IsNullOrWhiteSpace(dict.DICTVALUE))
            {
                errMsg = "字典值为空";
                return false;
            }
            if (DB.QueryExist<T_DICTIONARY>(s => s.DICTTYPE == dict.DICTTYPE && s.DICTVALUE == dict.DICTVALUE && s.ID != dict.ID && s.ISDELETE == 0))
            {
                errMsg = "字典值已存在";
                return false;
            }
            errMsg = null;
            return true;
        }
        bool AddDict(T_DICTIONARY dict, out string errMsg)
        {
            if (!VerifyModel(dict, out errMsg))
            {
                return false;
            }
            DB.Insert(dict);
            errMsg = null;
            return true;
        }
        bool UpdateDict(T_DICTIONARY dict, out string errMsg)
        {
            if (!VerifyModel(dict, out errMsg))
            {
                return false;
            }
            DB.Update(dict);
            return true;
        }
        bool DeleteDict(T_DICTIONARY dict)
        {
            dict.ClearChangedState();
            dict.ISDELETE = 1;
            DB.Update(dict);
            return true;
        }
        /// <summary>
        /// 获得用户类型
        /// </summary>
        public List<T_DICTIONARY> GetUserType()
        {
            return GetDictList(DictType.UserType);
        }

        public List<T_DICTIONARY> GetMinZu()
        {
            return GetDictList(DictType.MinZu);
        }
    }
}