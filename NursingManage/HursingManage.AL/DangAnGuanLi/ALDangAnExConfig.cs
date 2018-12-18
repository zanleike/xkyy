using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HursingManage.DBModel;
using Framework.Common.Helpers;
using System.Data;

namespace HursingManage.AL.DangAnGuanLi
{
    public class ALDangAnExConfig : ALBase
    {
        public Dictionary<string, object> GetConfigDict(int configType)
        {
            var query = DB.QueryWhere<T_DANGAN_PEIZHI>(s => s.CONFIGTYPE == configType);
            var configList = query.ToList();
            Dictionary<string, object> exTableList = new Dictionary<string, object>();
            foreach (var item in configList)
            {
                exTableList.Add(item.CONFIGKEY, item.CONFIGVALUE);
            }
            return exTableList;
        }
        
        static EditFormConfig _EditFormConfig;
        public EditFormConfig GetPeiZhiParam()
        {
            if (_EditFormConfig == null)
            {
                _EditFormConfig = new EditFormConfig();
                var configDict = GetConfigDict(1001);
                
                ReflectionHelper.SetPropertyValue(_EditFormConfig, configDict);
            }
            return _EditFormConfig;
        }
        public List<InputEditConfig> GetExColumns(string groupName)
        {
            var query = DB.CreateQueryCondition<T_DANGAN_TABLE_CONFIG>();
            query.WhereAnd(s => s.GROUPNAME == groupName);
            query.OrderBy(s => s.ORDERNO);
            var reuslt = DB.QueryWhere<T_DANGAN_TABLE_CONFIG>(query);
            var configList = reuslt.ToList();
            if (configList == null) return null;
            List<InputEditConfig> rList = new List<InputEditConfig>();
            foreach (var item in configList)
            {
                rList.Add(new InputEditConfig()
                {
                    CaptionControlLen = (int)item.CAPTIONCONTROLLEN,
                    ControlHeight = (int)item.CONTROLHEIGHT,
                    ControlType = (int)item.CONTROLTYPE,
                    ControlWidht = (int)item.CONTROLWIDHT,
                    DataSource = item.DATASOURCE,
                    FieldCaption = item.FIELDCAPTION,
                    FieldName = item.FIELDNAME,
                    IsRequired = Convert.ToBoolean(item.ISREQUIRED),
                    OrderNo = (int)item.ORDERNO
                });
            }
            return rList;
        }

        public List<ExGroupInfo> GetExGroupInfo()
        {
            var dict = GetConfigDict(2001);
            List<ExGroupInfo> rList = new List<ExGroupInfo>();
            foreach (var item in dict.Keys)
            {
                ExGroupInfo groupInfo = new ExGroupInfo();
                groupInfo.GroupName = item;
                groupInfo.GroupCaption = dict[item].ToString();
                rList.Add(groupInfo);
            }
            return rList;
        }

        public DataTable GetSubTableData(T_DANGAN dangAnModel, string exGroupName)
        {
            var query = DB.QueryWhere<T_DANGAN_TABLE>(s => s.DANGANID == dangAnModel.ID && s.GROUPNAME == exGroupName);
            return query.ToDataTable();
        }
        public bool AddSubTable(T_DANGAN_TABLE model, out string errMsg)
        {
            DB.Insert(model);
            errMsg = null;
            return true;
        }
        public bool UpdateSubTable(T_DANGAN_TABLE model, out string errMsg)
        {
            DB.Update(model);
            errMsg = null;
            return true;
        }
        public bool DeleteSubTable(T_DANGAN_TABLE model, out string errMsg)
        {
            DB.Delete(model);
            errMsg = null;
            return true;
        }
        //获取备注
        public string GetRemark(string key)
        {
            var query = DB.QueryWhere<T_DANGAN_PEIZHI>(s => s.CONFIGKEY == key);
            var configList = query.ToList();
            return configList[0].REMARK;
        }
    }
}
