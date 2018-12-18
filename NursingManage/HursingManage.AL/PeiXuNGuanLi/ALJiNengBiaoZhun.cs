using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HursingManage.DBModel;
using System.Data;

namespace HursingManage.AL.PeiXuNGuanLi
{
    public class ALJiNengBiaoZhun : ALBase
    {
        bool VerifyLeiBieModel(T_JINENGLEIBIE model, out string errMsg)
        {
            if (string.IsNullOrWhiteSpace(model.MINGCHENG))
            {
                errMsg = "类别名称不能为空。";
                return false;
            }
            if (DB.QueryExist<T_JINENGLEIBIE>(s => s.MINGCHENG == model.MINGCHENG && model.ID != model.ID))
            {
                errMsg = "该类别名称已存在。";
                return false;
            }
            errMsg = null;
            return true;
        }
        public bool AddLeiBie(T_JINENGLEIBIE leiBieMoel, out string errMsg)
        {
            if (!VerifyLeiBieModel(leiBieMoel, out  errMsg))
            {
                return false;
            }
            DB.Insert(leiBieMoel);
            return true;
        }
        public bool UpdateLeiBie(T_JINENGLEIBIE leiBieMoel, out string errMsg)
        {
            if (!VerifyLeiBieModel(leiBieMoel, out  errMsg))
            {
                return false;
            }
            DB.Update(leiBieMoel);
            return true;
        }
        public bool DeleteLeiBie(T_JINENGLEIBIE leiBieMoel, out string errMsg)
        {
            if (leiBieMoel == null || string.IsNullOrWhiteSpace(leiBieMoel.ID))
            {
                errMsg = "未选中正确的标准类别";
                return false;
            }
            if (DB.QueryExist<T_JINENGBIAOZHUN>(s => s.LEIBIEID == leiBieMoel.ID))
            {
                errMsg = "该类别已经使用，不允许删除。";
                return false;
            }
            errMsg = null;
            DB.Delete(leiBieMoel);
            return true;
        }
        public DataTable GetDataByLeiBie(string searchValue)
        {
            var query = DB.CreateQueryCondition<T_JINENGLEIBIE>();
            if (!string.IsNullOrWhiteSpace(searchValue))
            {
                searchValue = string.Format("%{0}%", searchValue);
                query.WhereAnd(s => s.WEx_Like(s.MINGCHENG, searchValue));
            }
            query.OrderBy(s => s.MINGCHENG);
            var result = DB.QueryWhere<T_JINENGLEIBIE>(query);
            return result.ToDataTable();
        }

        bool VerifyBiaoZhunModel(T_JINENGBIAOZHUN model, out string errMsg)
        {
            if (model.FENZHI == 0)
            {
                errMsg = "分值不能为0";
                return false;
            }
            if (model.XUHAO == 0)
            {
                errMsg = "序号不能为空或0";
            }
            if (string.IsNullOrWhiteSpace(model.XIANGMU))
            {
                errMsg = "操作项目不能为空";
                return false;
            }
            if (string.IsNullOrWhiteSpace(model.CAOZUOYAODIAN))
            {
                errMsg = "操作要点不能为空。";
                return false;
            }
            if (DB.QueryExist<T_JINENGBIAOZHUN>(s => s.XUHAO == model.XUHAO && s.ID != model.ID && s.LEIBIEID == model.LEIBIEID))
            {
                errMsg = "当前序号已经存在";
                return false;
            }
            errMsg = null;
            return true;
        }
        public bool AddBiaoZhun(T_JINENGBIAOZHUN leiBieMoel, out string errMsg)
        {
            if (!VerifyBiaoZhunModel(leiBieMoel, out  errMsg))
            {
                return false;
            }
            DB.Insert(leiBieMoel);
            return true;
        }
        public bool UpdateBiaoZhun(T_JINENGBIAOZHUN model, out string errMsg)
        {
            if (!VerifyBiaoZhunModel(model, out  errMsg))
            {
                return false;
            }
            DB.Update(model);
            return true;
        }
        public bool DeleteBiaoZhun(T_JINENGBIAOZHUN model, out string errMsg)
        {
            if (model == null || string.IsNullOrWhiteSpace(model.ID))
            {
                errMsg = "未选中正确的标准类别";
                return false;
            }
            //if (DB.QueryExist<T_JINENGBIAOZHUN>(s => s.LEIBIEID == leiBieMoel.ID))
            //{
            //    errMsg = "该类别已经使用，不允许删除。";
            //    return false;
            //}
            //TODO:技能标准使用后不允许删除，需要添加；
            errMsg = null;
            DB.Delete(model);
            return true;
        }
        public DataTable GetDataByBiaoZhun(T_JINENGLEIBIE leiBieModel, string searchValue)
        {
            var query = DB.CreateQueryCondition<T_JINENGBIAOZHUN>();
            query.WhereAnd(s => s.LEIBIEID == leiBieModel.ID);
            if (!string.IsNullOrWhiteSpace(searchValue))
            {
                searchValue = string.Format("%{0}%", searchValue);
                query.WhereAnd(s => s.WEx_Like(s.CAOZUOYAODIAN, searchValue));
            }
            var result = DB.QueryWhere<T_JINENGBIAOZHUN>(query);
            return result.ToDataTable();
        }
    }
}