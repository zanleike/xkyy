using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HursingManage.DBModel;
using System.Data;
using Framework.Common;
using Framework;

namespace HursingManage.AL.PeiXuNGuanLi
{
    public class ALTiKuGuanLi : ALBase
    {
        public ALTiKuGuanLi(Func<string> GetFenleiHandle)
        {
            this.GetSelectedFenleiHandle = GetFenleiHandle;
        }
        Func<string> GetSelectedFenleiHandle;

        public DataTable GetData(T_SHITI_FENLEI fenLeiModel, string searchValue)
        {
            var query = DB.CreateQueryCondition<T_SHITI>();
            query.WhereAnd(s => s.FENLEIID == fenLeiModel.ID);
            if (!string.IsNullOrWhiteSpace(searchValue))
            {
                searchValue = string.Format("%{0}%", searchValue);
                query.WhereAnd(s =>
                    s.WEx_Like(s.BIANHAO, searchValue) ||
                    s.WEx_Like(s.NEIRONG, searchValue)
                    );
            }
            var ret = DB.QueryWhere<T_SHITI>(query);
            return ret.ToDataTable();
        }
        public bool VerifyModel(T_SHITI model, out string errMsg)
        {
            if (string.IsNullOrWhiteSpace(model.FENLEI) || string.IsNullOrWhiteSpace(model.FENLEIID))
            {
                errMsg = "试题分类不能为空";
                return false;
            }
            if (string.IsNullOrWhiteSpace(model.LEIXING))
            {
                errMsg = "试题类型不能为空";
                return false;
            }
            if (string.IsNullOrWhiteSpace(model.DAAN))
            {
                errMsg = "答案为空";
                return false;
            }
            model.DAAN = model.DAAN.Trim();

            if (model.LEIXING == "简答题" || model.LEIXING == "名词解释")
            { }
            else if (string.IsNullOrWhiteSpace(model.XIANGMUA) || string.IsNullOrWhiteSpace(model.XIANGMUB))
            {
                errMsg = "非问答题至少要有两个选项";
                return false;
            }
            else if (model.LEIXING == "多选题")
            { }
            else if (model.LEIXING == "单选题" || model.LEIXING == "判断题")
            {
                if (model.DAAN.Length != 1)
                {
                    errMsg = "判断题与单选题只能有一个正确答案。";
                    return false;
                }
            }
            else
            {
                errMsg = "试题类型错误";
                LogHelper.LogObj.Error("试题类型未添加到逻辑当中");
                return false;
            }

            //switch (model.LEIXING)
            //{
            //    case "多选题":
            //        break;
            //    case "单选题":
            //    case "判断题":
            //        if (model.DAAN.Length != 1)
            //        {
            //            errMsg = "判断题与单选题只能有一个正确答案。";
            //            return false;
            //        }
            //        break;
            //    case "简答题":
            //    case "名词解释":
            //        break;
            //    default:
            //        errMsg = "试题类型有误，请联系技术人员。";
            //        LogHelper.LogObj.Error("类型未添加到逻辑当中");
            //        break;
            //}
            if (DB.QueryExist<T_SHITI>(s => s.BIANHAO == model.BIANHAO && s.ID != model.ID))
            {
                errMsg = "试题编号已经存在";
                return false;
            }
            errMsg = null;
            return true;
        }
        public bool Add(T_SHITI_FENLEI fenLeiModel, T_SHITI model, out string errMsg)
        {
            model.FENLEI = fenLeiModel.MINGCHENG;
            model.FENLEIID = fenLeiModel.ID;
            model.LEIXING = model.LEIXING.Trim();
            model.NANYICHENGDU = string.IsNullOrWhiteSpace(model.NANYICHENGDU) ? "普通" : model.NANYICHENGDU.Trim();
            model.NEIRONG = model.NEIRONG.Trim();
            model.XIANGMUA = model.XIANGMUA == null ? string.Empty : model.XIANGMUA.Trim();
            model.XIANGMUB = model.XIANGMUB == null ? string.Empty : model.XIANGMUB.Trim();
            model.XIANGMUC = model.XIANGMUC == null ? string.Empty : model.XIANGMUC.Trim();
            model.XIANGMUD = model.XIANGMUD == null ? string.Empty : model.XIANGMUD.Trim();
            model.XIANGMUE = model.XIANGMUE == null ? string.Empty : model.XIANGMUE.Trim();
            model.XIANGMUF = model.XIANGMUF == null ? string.Empty : model.XIANGMUF.Trim();
            if (!VerifyModel(model, out errMsg))
            {
                return false;
            }
            DB.Insert(model);
            return true;
        }
        public bool Update(T_SHITI model, out string errMsg)
        {
            if (!VerifyModel(model, out errMsg))
            {
                return false;
            }
            DB.Update(model);
            return true;
        }
        public bool Delete(T_SHITI model, out string errMsg)
        {
            if (DB.QueryExist<T_SHITI_MUBAN_MINGXI>(s => s.SHITIID == model.ID))
            {
                errMsg = "当前试题已经使用不允许删除。";
                return false;
            }
            DB.Delete(model);
            errMsg = null;
            return true;
        }
        public override DataTable GetADSearchData<TModel>()
        {
            string fenLei = GetSelectedFenleiHandle();
            if (fenLei == null)
            {
                return null;
            }
            ADSqlBuilder.AddSqlTextByGroup("{0}={1}", T_SHITI.CNFENLEI, ADSqlBuilder.AddParam(fenLei));
            return base.GetADSearchData<TModel>();
        }
        public bool ChangeFenLei(T_SHITI model, T_SHITI_FENLEI fenLeiModel, out string errMsg)
        {
            if (fenLeiModel == null)
            {
                errMsg = "要更改的分类为空。";
                return false;
            }
            model.ClearChangedState();
            model.FENLEIID = fenLeiModel.ID;
            model.FENLEI = fenLeiModel.MINGCHENG;
            DB.Update(model);
            errMsg = null;
            return true;
        }

        bool VerifyModelByFenLei(T_SHITI_FENLEI model, out string errMsg)
        {
            if (string.IsNullOrWhiteSpace(model.MINGCHENG))
            {
                errMsg = "分类名称不能为空";
                return false;
            }
            if (DB.QueryExist<T_SHITI_FENLEI>(s => s.MINGCHENG == model.MINGCHENG && s.ID != model.ID))
            {
                errMsg = "分类名称已存在";
                return false;
            }
            errMsg = null;
            return true;
        }
        public bool AddByFenLei(T_SHITI_FENLEI model, out string errMsg)
        {
            if (!VerifyModelByFenLei(model, out errMsg))
            {
                return false;
            }
            DB.Insert(model);
            return true;
        }
        public bool UpdateByFenLei(T_SHITI_FENLEI model, out string errMsg)
        {
            if (!VerifyModelByFenLei(model, out errMsg))
            {
                return false;
            }
            DB.Update(model);
            T_SHITI shiti = new T_SHITI();
            shiti.FENLEI = model.MINGCHENG;
            DB.Update<T_SHITI>(shiti, s => s.FENLEIID == model.ID);
            return true;
        }
        public bool DeleteByFenLei(T_SHITI_FENLEI model, out string errMsg)
        {
            if (DB.QueryExist<T_SHITI>(s => s.FENLEIID == model.ID))
            {
                errMsg = "当前分类已有试题，不允许删除。";
                return false;
            }
            DB.Delete(model);
            errMsg = null;
            return true;
        }
        public DataTable GetDataByFenLei(string searchValue)
        {
            var query = DB.CreateQueryCondition<T_SHITI_FENLEI>();
            if (!string.IsNullOrWhiteSpace(searchValue))
            {
                searchValue = string.Format("%{0}%", searchValue);
                query.WhereAnd(s =>
                    s.WEx_Like(s.MINGCHENG, searchValue) ||
                    s.WEx_Like(s.MINGCHENG_PY, searchValue));
            }
            query.OrderBy(s => s.ADDTIME, EmOrderByType.Desc);
            var ret = DB.QueryWhere<T_SHITI_FENLEI>(query);
            return ret.ToDataTable();
        }
   
        public List<T_SHITI> GetListDataByShiTi(T_SHITI_FENLEI shiTiFenLei)
        {
            var query = DB.CreateQueryCondition<T_SHITI>();
            query.WhereAnd(s => s.FENLEIID == shiTiFenLei.ID);
            query.OrderBy(s => s.BIANHAO);
            var ret = DB.QueryWhere<T_SHITI>(query);
            return ret.ToList();
        }
    }
}