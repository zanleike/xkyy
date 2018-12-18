//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using HursingManage.DBModel;
//using Framework.BuildSQLText;

//namespace HursingManage.AL.PeiXuNGuanLi
//{
//    /// <summary>
//    /// 题库管理
//    /// </summary>
//    public class ALTiKu : ALBase
//    {
//        public class SearchParam
//        {

//        }
//        public List<T_QUESTIONS> GetData(SearchParam sp)
//        {
//            var queryCondition = DB.CreateQueryCondition<T_QUESTIONS>();

//            var sqlBuilder = DB.CreateSqlBuilder();
//            sqlBuilder.AddSQLText("ID is Not null");
//            queryCondition.WhereAnd(s => s.SIMPLE_LEVEL != "adfg");
//            var r = DB.QueryWhere<T_QUESTIONS>(queryCondition, sqlBuilder);
//            var r2 = r.ToList();
//            return r2;
//        }

//        public override List<TModel> GetADSearchData<TModel>()
//        {
//            return base.GetADSearchData<TModel>();
//        }

//        public bool VerifyModel(T_QUESTIONS model, out string errMsg)
//        {
//            errMsg = null;
//            if (string.IsNullOrWhiteSpace(model.OPTION_A)) model.OPTION_A_IS = 0;
//            if (string.IsNullOrWhiteSpace(model.OPTION_B)) model.OPTION_B_IS = 0;
//            if (string.IsNullOrWhiteSpace(model.OPTION_C)) model.OPTION_C_IS = 0;
//            if (string.IsNullOrWhiteSpace(model.OPTION_D)) model.OPTION_D_IS = 0;
//            if (string.IsNullOrWhiteSpace(model.OPTION_E)) model.OPTION_E_IS = 0;
//            if (string.IsNullOrWhiteSpace(model.OPTION_F)) model.OPTION_F_IS = 0;
//            if (string.IsNullOrWhiteSpace(model.OPTION_G)) model.OPTION_G_IS = 0;
//            int isCount = (int)(model.OPTION_A_IS + model.OPTION_B_IS + model.OPTION_C_IS + model.OPTION_D_IS + model.OPTION_E_IS + model.OPTION_F_IS + model.OPTION_G_IS);
//            if (isCount == 0)
//            {
//                errMsg = "至少有两个及以上选项,并且需要有一个及以上答案";
//                return false;
//            }
//            if (model.QUESTIONS_TYPE != "多选题")
//            {
//                if (isCount > 1)
//                {
//                    errMsg = "非多选题只能有一个答案!";
//                    return false;
//                }
//            }
//            if (DB.QueryExist<T_QUESTIONS>(s => s.QUESTIONS_NO == model.QUESTIONS_NO && s.ID != model.ID))
//            {
//                errMsg = "实体编号已已经存在";
//                return false;
//            }
//            return true;
//        }
//        public bool Add(T_QUESTIONS model, out string errMsg)
//        {
//            if (!VerifyModel(model, out errMsg))
//            {
//                return false;
//            }
//            model.OPERATORID = CurrentLoginUser.ID;
//            DB.Insert(model);
//            return true;
//        }
//        public bool Update(T_QUESTIONS model, out string errMsg)
//        {
//            if (!VerifyModel(model, out errMsg))
//            {
//                return false;
//            }
//            model.LASTTIME = GetNowTime();
//            DB.Update(model);
//            return true;
//        }
//        public bool Delete(T_QUESTIONS model, out string errMsg)
//        {
//            DB.Delete(model);
//            errMsg = null;
//            return true;
//        }



//    }
//}