using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HursingManage.DBModel;
using System.Data;
using Framework.Common;
using Framework.Common.Helpers;

namespace HursingManage.AL.PeiXuNGuanLi
{
    public class ALShiTiMuBan : ALBase
    {
        bool VerifyModel(T_SHITI_MUBAN model, out string errMsg)
        {
            if (model.PANDUANFENSHU + model.DANXUANSHU + model.DUOXUANSHU == 0)
            {
                errMsg = "生成试题数量为 0 ";
                return false;
            }
            if (string.IsNullOrWhiteSpace(model.MINGCHENG))
            {
                errMsg = "模板名称不能为空！";
                return false;
            }
            if (DB.QueryExist<T_SHITI_MUBAN>(s => s.MINGCHENG == model.MINGCHENG && s.SHITILEIBIE == model.SHITILEIBIE && s.ID != model.ID))
            {
                errMsg = "当前试题模板名称已存在！";
                return false;
            }
            model.BEIZHU = string.Format("单选数量：{0}，分数：{1}；多选数量：{2}，分数：{3}；判断数量：{4}，分数：{5}",
                model.DANXUANSHU, model.DANXUANFENSHU, model.DUOXUANSHU, model.DUOXUANFENSHU, model.PANDUANSHU, model.PANDUANFENSHU);
            errMsg = null;
            return true;
        }
        public bool AddByMuBan(T_SHITI_MUBAN model, out string errMsg)
        {
            if (!VerifyModel(model, out errMsg))
            {
                return false;
            }
            model.CHUANGJIANREN = CurrentLoginUser.USER_NAME;
            DB.Insert(model);
            return true;
        }
        public bool UpdateByMuBan(T_SHITI_MUBAN model, out string errMsg)
        {
            if (MuBanUsed(model))
            {
                errMsg = "模板已使用，不允许修改!";
                return false;
            }
            if (!VerifyModel(model, out errMsg))
            {
                return false;
            }
            DB.Update(model);
            V_SHITI_MUBAN_MINGXI mingXi = new V_SHITI_MUBAN_MINGXI();
            mingXi.FENSHU = model.PANDUANFENSHU;
            DB.Update<V_SHITI_MUBAN_MINGXI>(mingXi, s => s.MUBANID == model.ID && s.LEIXING == "判断题");
            mingXi.FENSHU = model.DANXUANFENSHU;
            DB.Update<V_SHITI_MUBAN_MINGXI>(mingXi, s => s.MUBANID == model.ID && s.LEIXING == "单选题");
            mingXi.FENSHU = model.DUOXUANFENSHU;
            DB.Update<V_SHITI_MUBAN_MINGXI>(mingXi, s => s.MUBANID == model.ID && s.LEIXING == "多选题");
            return true;
        }
        public bool DeleteByMuBan(T_SHITI_MUBAN model, out string errMsg)
        {
            if (MuBanUsed(model))
            {
                errMsg = "模板已使用，不允许删除";
                return false;
            }
            //DB.Delete<T_SHITI_MUBAN_MINGXI>(s => s.MUBANID == model.ID);
            DB.Delete(model);
            WriteDBLog("删除试题模板,名称：{0}，ID：{1}", model.MINGCHENG, model.ID);
            errMsg = null;
            return true;
        }
        public DataTable GetDataByMuBan(string searchValue)
        {
            var query = DB.CreateQueryCondition<T_SHITI_MUBAN>();
            if (!string.IsNullOrWhiteSpace(searchValue))
            {
                searchValue = string.Format("%{0}%", searchValue);
                query.WhereAnd(s =>
                    s.WEx_Like(s.MINGCHENG, searchValue) ||
                    s.WEx_Like(s.MINGCHENG_PY, searchValue)
                    );
            }
            query.OrderBy(s => s.ADDTIME, Framework.EmOrderByType.Desc);
            var ret = DB.QueryWhere<T_SHITI_MUBAN>(query);
            return ret.ToDataTable();
        }

        /// <summary>
        /// 试题生成参数
        /// </summary>
        public class ShengChengCanShu
        {
            /// <summary>
            /// 单选题数量
            /// </summary>
            public int DanXuanShuLiang { set; get; }
            /// <summary>
            /// 单选题难易程度
            /// </summary>
            public string DanXuanNanYi { set; get; }
            /// <summary>
            /// 单选题分数
            /// </summary>
            public float DanXuanFenShu { set; get; }
            /// <summary>
            /// 多选题数量
            /// </summary>
            public int DuoXuanShuLiang { set; get; }
            /// <summary>
            /// 多选题难易程度
            /// </summary>
            public string DuoXuanNanYi { set; get; }
            /// <summary>
            /// 多选题分数
            /// </summary>
            public float DuoXuanFenShu { set; get; }
            /// <summary>
            /// 判断题数量
            /// </summary>
            public int PanDuanShuLiang { set; get; }
            /// <summary>
            /// 判断题难易程度
            /// </summary>
            public string PanduanNanYi { set; get; }
            /// <summary>
            /// 判断题分数
            /// </summary>
            public float PanDuanFenShu { set; get; }
            /// <summary>
            /// 问答题数量
            /// </summary>
            public int WenDaShuLiang { set; get; }
            /// <summary>
            /// 问答题难易程度
            /// </summary>
            public string WenDaNanYi { set; get; }
            /// <summary>
            /// 问答题分数
            /// </summary>
            public float WenDaFenShu { set; get; }
        }

        /// <summary>
        /// 模板是否已经使用，使用后不允许再修改或重新生成
        /// </summary>
        public bool MuBanUsed(T_SHITI_MUBAN muBan)
        {
            if (DB.QueryExist<T_PEIXUNJIHUA_MINGXI>(s => s.MUBANID == muBan.ID & s.DATIBIAOZHI=="是"))
            {
                return true;
            }
            return false;
        }

        public bool AddByMuBanShiTi(T_SHITI_MUBAN muBanModel, List<T_SHITI> shiTiList)
        {
            if (MuBanUsed(muBanModel))
            {
                LogHelper.LogObj.Error("模板已经使用，不允许新增、修改、删除");
                return false;
            }
            if (shiTiList == null || shiTiList.Count == 0)
            {
                return false;
            }
            var countRet = DB.QueryCount<T_SHITI_MUBAN_MINGXI>(s => s.MUBANID == muBanModel.ID);
            var count = countRet.ToObject<int>(); //该模板下的试题数量

            foreach (var shiTi in shiTiList)
            {
                if (DB.QueryExist<T_SHITI_MUBAN_MINGXI>(s => s.MUBANID == muBanModel.ID && s.SHITIID == shiTi.ID))
                {
                    LogHelper.LogObj.InfoFormat("试题已存在在该模板库中，模板id：{0}，试题id：{1}", muBanModel.ID, shiTi.ID);
                    return false;
                }
                count++;
                T_SHITI_MUBAN_MINGXI model = new T_SHITI_MUBAN_MINGXI();
                model.SHITIID = shiTi.ID;
                model.MUBANID = muBanModel.ID;
                model.SHITIXUHAO = count;
                DB.Insert(model);
            }
            return true;
        }

        /// <summary>
        /// 从试题中获取随机试题
        /// </summary>
        void GetRandomShiTi(T_SHITI_MUBAN muBanModel, List<T_SHITI> shiTiList, int chuTiShuLiang, float fenShu, string leiXingMing, ref List<T_SHITI_MUBAN_MINGXI> mingXiList)
        {
            if (shiTiList.Count < chuTiShuLiang)
            {
                //题库中的题比参数中输入的试题数量小,全部导入
                foreach (var item in shiTiList)
                {
                    mingXiList.Add(new T_SHITI_MUBAN_MINGXI()
                    {
                        SHITIID = item.ID,
                        MUBANID = muBanModel.ID,
                        FENSHU = (decimal)fenShu,
                        SHITIXUHAO = mingXiList.Count + 1
                    });
                }
                LogHelper.LogObj.Info("出题数量大于试题数量，全部载入:" + leiXingMing);
            }
            else
            {
                List<int> rList = new List<int>(); //判断重复使用
                Random rad = new Random();
                int index; //试题列表index
                while (rList.Count < chuTiShuLiang)
                {
                    index = rad.Next(0, shiTiList.Count);
                    if (rList.Contains(index))
                    {
                        continue;
                    }
                    else
                    {
                        rList.Add(index);
                        var shiTiModel = shiTiList[index];
                        mingXiList.Add(new T_SHITI_MUBAN_MINGXI()
                        {
                            SHITIID = shiTiModel.ID,
                            MUBANID = muBanModel.ID,
                            FENSHU = (decimal)fenShu,
                            SHITIXUHAO = mingXiList.Count + 1
                        });
                    }
                }
            }
        }
        /// <summary>
        /// 生成试题
        /// </summary>
        public bool ShengChengShiTi(T_SHITI_MUBAN muBanModel, ShengChengCanShu paramModel, out string errMsg)
        {
            if (MuBanUsed(muBanModel))
            {
                errMsg = "模板已使用，不允许修改或删除";
                return false;
            }
            if (paramModel.PanDuanShuLiang + paramModel.DanXuanShuLiang + paramModel.DuoXuanShuLiang == 0)
            {
                errMsg = "生成试题数量为 0 ";
                return false;

            }
            DB.Delete<T_SHITI_MUBAN_MINGXI>(s => s.MUBANID == muBanModel.ID);
            var fenLeiQuery = DB.QueryWhere<T_SHITI_MUBAN_FENLEI>(s => s.MUBANID == muBanModel.ID);
            var fenLeiList = fenLeiQuery.ToList();
            var fenLeiIds = fenLeiList.Select(s => s.FENLEIID).ToArray();
            var shiTiQuery = DB.QueryWhere<T_SHITI>(s => s.WEx_In(s.FENLEIID, fenLeiIds));
            var shiTiList = shiTiQuery.ToList();

            var muBanShiTiList = new List<T_SHITI_MUBAN_MINGXI>();
            var danXuanTi = shiTiList.FindAll(s => s.LEIXING == "单选题");
            GetRandomShiTi(muBanModel, danXuanTi, paramModel.DanXuanShuLiang, paramModel.DanXuanFenShu, "单选题", ref muBanShiTiList);
            var panDaunTi = shiTiList.FindAll(s => s.LEIXING == "判断题");
            GetRandomShiTi(muBanModel, panDaunTi, paramModel.PanDuanShuLiang, paramModel.PanDuanFenShu, "判断题", ref muBanShiTiList);
            var duoXuanTi = shiTiList.FindAll(s => s.LEIXING == "多选题");
            GetRandomShiTi(muBanModel, duoXuanTi, paramModel.DuoXuanShuLiang, paramModel.DuoXuanFenShu, "多选题", ref muBanShiTiList);
            var wenDaTi = shiTiList.FindAll(s => s.LEIXING == "问答题");
            GetRandomShiTi(muBanModel, wenDaTi, paramModel.WenDaShuLiang, paramModel.WenDaFenShu, "问答题", ref muBanShiTiList);
            errMsg = null;
            foreach (var item in muBanShiTiList)
            {
                if (DB.QueryExist<T_SHITI_MUBAN_MINGXI>(s => s.MUBANID == item.MUBANID && s.SHITIID == item.SHITIID))
                {
                    LogHelper.LogObj.InfoFormat("试题已存在在该模板库中，模板id：{0}，试题id：{1}", muBanModel.ID, item.ID);
                    return false;
                }
                DB.Insert(item);
            }
            return true;
        }

        /// <summary>
        /// 生成试题，从模板读取生成你参数配置
        /// </summary>
        public bool ShengChengShiTi(T_SHITI_MUBAN muBanModel, out string errMsg)
        {
            ShengChengCanShu paramModel = new ShengChengCanShu();
            paramModel.DanXuanFenShu = (float)muBanModel.DANXUANFENSHU;
            paramModel.DanXuanShuLiang = (int)muBanModel.DANXUANSHU;
            paramModel.DuoXuanFenShu = (float)muBanModel.DUOXUANFENSHU;
            paramModel.DuoXuanShuLiang = (int)muBanModel.DUOXUANSHU;
            paramModel.PanDuanFenShu = (float)muBanModel.PANDUANFENSHU;
            paramModel.PanDuanShuLiang = (int)muBanModel.PANDUANSHU;
            return ShengChengShiTi(muBanModel, paramModel, out errMsg);
        }

        public DataTable GetDataByShiTi(T_SHITI_MUBAN muBanModel)
        {
            var sql = DB.CreateSqlBuilder();
            sql.AddSQLText(@"FenLeiId in ( select FENLEIID from T_ShiTi_Muban_FenLei where MUBANID = {0}) and Id not in (select ShiTiId from t_Shiti_Muban_Mingxi where MuBanId = {0} )",
                sql.AddParam(muBanModel.ID));
            var ret = DB.QueryWhere<T_SHITI>(sql);
            return ret.ToDataTable();
        }
        public DataTable GetDataByMuBanShiTi(T_SHITI_MUBAN muBanModel, string searchValue)
        {
            var query = DB.CreateQueryCondition<V_SHITI_MUBAN_MINGXI>();
            query.WhereAnd(s => s.MUBANID == muBanModel.ID);
            if (!string.IsNullOrWhiteSpace(searchValue))
            {
                int xuHao;
                if (int.TryParse(searchValue, out xuHao))
                {
                    query.WhereAnd(s => s.SHITIXUHAO == xuHao);
                }
                else
                {
                    searchValue = string.Format("%{0}%", searchValue);
                    query.WhereAnd(s => s.WEx_Like(s.NEIRONG, searchValue));
                }

            }
            query.OrderBy(s => s.SHITIXUHAO);
            var ret = DB.QueryWhere<V_SHITI_MUBAN_MINGXI>(query);
            return ret.ToDataTable();
        }
        public List<T_SHITI_MUBAN_FENLEI> GetDataByShiTiLeiBie(T_SHITI_MUBAN muBanModel)
        {
            var query = DB.QueryWhere<T_SHITI_MUBAN_FENLEI>(s => s.MUBANID == muBanModel.ID);
            return query.ToList();
        }
        public List<V_SHITI_MUBAN_MINGXI> GetListDataByShiTi(T_SHITI_MUBAN muBanModel)
        {
            var query = DB.CreateQueryCondition<V_SHITI_MUBAN_MINGXI>();
            query.WhereAnd(s => s.MUBANID == muBanModel.ID);
            query.OrderBy(s => s.SHITIXUHAO);
            var ret = DB.QueryWhere<V_SHITI_MUBAN_MINGXI>(query);
            return ret.ToList();
        }
        public bool DeleteMuBanMingXi(V_SHITI_MUBAN_MINGXI model)
        {
            DB.Delete<T_SHITI_MUBAN_MINGXI>(s => s.ID == model.ID);
            return true;
        }

        public bool AddMuBanFenLei(T_SHITI_MUBAN muBanModel, T_SHITI_FENLEI fenLeiModel)
        {
            if (DB.QueryExist<T_SHITI_MUBAN_FENLEI>(s => s.MUBANID == muBanModel.ID && s.FENLEIID == fenLeiModel.ID))
            {
                return false;
            }
            T_SHITI_MUBAN_FENLEI model = new T_SHITI_MUBAN_FENLEI();
            model.MUBANID = muBanModel.ID;
            model.FENLEIID = fenLeiModel.ID;
            model.FENLEIMINGCHENG = fenLeiModel.MINGCHENG;
            DB.Insert(model);
            return true;
        }
        public bool RemoveMuBanFenLei(T_SHITI_MUBAN_FENLEI muBanFenLeiModel, out string errMsg)
        {
            DB.Delete<T_SHITI_MUBAN_FENLEI>(muBanFenLeiModel);
            DB.Delete<T_SHITI_MUBAN_MINGXI>(s => s.SHITILEIBIEID == muBanFenLeiModel.FENLEIID);
            errMsg = null;
            return true;
        }
        public DataTable GetMuBanFenLeiData(T_SHITI_MUBAN muBanModel)
        {
            var sql = DB.CreateSqlBuilder();
            sql.AddSQLText("Id not in (select FENLEIID from T_ShiTi_Muban_FenLei where MUBANID = {0} )", sql.AddParam(muBanModel.ID));
            var ret = DB.QueryWhere<T_SHITI_FENLEI>(sql);
            return ret.ToDataTable();
        }
        public DataTable GetJiHuHuaData()
        {
            var query = DB.CreateQueryCondition<T_PEIXUNJIHUA>();
            var lastTime = GetNowTime().AddMonths(-3);
            query.WhereAnd(s => s.ADDTIME >= lastTime);
            query.OrderBy(s => s.ADDTIME, Framework.EmOrderByType.Desc);
            var result = DB.QueryWhere<T_PEIXUNJIHUA>(query);
            return result.ToDataTable();
        }
        public T_SHITI_MUBAN GetBuKaoMuBan(T_PEIXUNJIHUA jihuaModel)
        {
            //获取补考的缺省模板，用户编辑框赋值
            var jiHuaMuBanQuery = DB.QueryWhere<T_PEIXUNJIHUA_MUBAN>(s => s.JIHUAID == jihuaModel.ID);
            T_PEIXUNJIHUA_MUBAN jiHuaMuBanModel = jiHuaMuBanQuery.ToEntity();
            var muBanQuery = DB.QueryWhere<T_SHITI_MUBAN>(s => s.ID == jiHuaMuBanModel.MUBANID);
            return muBanQuery.ToEntity();
        }
        /// <summary>
        /// 原题补考保存试题
        /// </summary>
        public bool SaveBuKaoMuBan(T_SHITI_MUBAN muBanModel, out string errMsg)
        {
            if (!VerifyModel(muBanModel, out errMsg))
            {
                return false;
            }
            muBanModel.CHUANGJIANREN = CurrentLoginUser.USER_NAME;
            T_PEIXUNJIHUA jihuaModel = muBanModel.JiHuaModel;
            var jiHuaMuBanQuery = DB.QueryWhere<T_PEIXUNJIHUA_MUBAN>(s => s.JIHUAID == jihuaModel.ID);
            var jiHuaMuBanList = jiHuaMuBanQuery.ToList();
            //获取试题
            var muBanIds = jiHuaMuBanList.Select(s => s.MUBANID).ToArray();
            //所属该计划的所有模板试题
            var muBanShiTiQuery = DB.QueryWhere<V_SHITI_MUBAN_MINGXI>(s => s.WEx_In(s.MUBANID, muBanIds));
            var muBanShiTiList = muBanShiTiQuery.ToList();
            if (muBanModel.PANDUANSHU + muBanModel.DANXUANSHU + muBanModel.DUOXUANSHU == 0)
            {
                errMsg = "生成试题数量为 0 ";
                return false;
            }
            List<T_SHITI_MUBAN_MINGXI> mingXiList = new List<T_SHITI_MUBAN_MINGXI>();
            var danXuanList = muBanShiTiList.FindAll(s => s.LEIXING == "单选题");
            GetRandomShiTi(danXuanList, (int)muBanModel.DANXUANSHU, muBanModel.DANXUANFENSHU, ref mingXiList);
            var panDuanList = muBanShiTiList.FindAll(s => s.LEIXING == "判断题");
            GetRandomShiTi(panDuanList, (int)muBanModel.PANDUANSHU, muBanModel.PANDUANFENSHU, ref mingXiList);
            var duoXuanList = muBanShiTiList.FindAll(s => s.LEIXING == "多选题");
            GetRandomShiTi(duoXuanList, (int)muBanModel.DUOXUANSHU, muBanModel.DUOXUANFENSHU, ref mingXiList);
            if (mingXiList.Count == 0)
            {
                errMsg = "要添加的试题记录为空。";
                return false;
            }
            errMsg = null;
            muBanModel.ID = GetGuid();
            foreach (var item in mingXiList)
            {
                item.MUBANID = muBanModel.ID;
                DB.Insert(item);
            }
            DB.Insert(muBanModel);
            return true;
        }
        void GetRandomShiTi(List<V_SHITI_MUBAN_MINGXI> source, int chuTiShuLiang, decimal fenShu, ref List<T_SHITI_MUBAN_MINGXI> mingXiList)
        {
            if (source.Count < chuTiShuLiang)
            {
                //题库中的题比参数中输入的试题数量小,全部导入
                foreach (var item in source)
                {
                    mingXiList.Add(new T_SHITI_MUBAN_MINGXI()
                    {
                        SHITIID = item.SHITIID,
                        MUBANID = item.MUBANID,
                        //FENSHU = item.FENSHU,
                        FENSHU = fenShu,
                        SHITIXUHAO = mingXiList.Count + 1
                    });
                }
                LogHelper.LogObj.Info("出题数量大于试题数量，全部载入.");
            }
            else
            {
                List<int> rList = new List<int>(); //判断重复使用
                Random rad = new Random();
                int index; //试题列表index
                while (rList.Count < chuTiShuLiang)
                {
                    index = rad.Next(0, source.Count);
                    if (rList.Contains(index))
                    {
                        continue;
                    }
                    else
                    {
                        var shiTiModel = source[index];
                        if (mingXiList.Exists(s => s.SHITIID == shiTiModel.SHITIID))
                        {
                            continue;
                        }
                        rList.Add(index);
                        mingXiList.Add(new T_SHITI_MUBAN_MINGXI()
                        {
                            SHITIID = shiTiModel.SHITIID,
                            MUBANID = shiTiModel.MUBANID,
                            FENSHU = fenShu,
                            SHITIXUHAO = mingXiList.Count + 1
                        });
                    }
                }
            }
        }
        /// <summary>
        /// 重新对该模板的所有人员进行评分
        /// </summary>
        public int ChongXinPingFen(T_SHITI_MUBAN model)
        {
            WriteDBLog("重新评分，模板Id：{0}", model.ID);

            var renYuanMingXiQuery = DB.QueryWhere<T_PEIXUNJIHUA_MINGXI>(s => s.MUBANID == model.ID);
            var renYuanList = renYuanMingXiQuery.ToList();

            //decimal newFenShu = 0; //分数
            //int zqs = 0; //正确数；
            int updateCount = 0;
            string errMsg;
            StringBuilder newDaTi = new StringBuilder();
            foreach (var renYuan in renYuanList)
            {
                if (ALShiTiPingFen.ChongXinPingFen(renYuan, out errMsg))
                {
                    updateCount++;
                }
                else
                {
                    WriteDBLog("评分错误：" + errMsg);
                    continue;
                }

                //if (string.IsNullOrWhiteSpace(renYuan.DATI))
                //{
                //    continue;
                //}
                //string[] daTi = renYuan.DATI.Split(',');
                //if (daTi.Length > muBanShiTi.Count)
                //{
                //    WriteDBLog("重新评分发生程序逻辑异常，答题数量大于模板试题数量，T_PEIXUNJIHUA_MINGXI.ID：" + renYuan.ID);
                //    continue;
                //}
                //for (int i = 0; i < daTi.Length; i++)
                //{
                //    if (StringHelper.StringEquals(muBanShiTi[i].DAAN, daTi[i]))
                //    {
                //        updateCount++;
                //        newFenShu += muBanShiTi[i].FENSHU;
                //        zqs++;
                //    }
                //}
                //if (renYuan.ZHENGQUESHU != zqs || renYuan.FENSHU != newFenShu)
                //{
                //    WriteDBLog("T_PEIXUNJIHUA_MINGXI.ID = {0},原分值:{1},原正确数,{2},新分值:{3}，新正确数:{4}",
                //        renYuan.ID, renYuan.FENSHU, renYuan.ZHENGQUESHU, newFenShu, zqs);
                //    updateCount++;
                //}
                //renYuan.ClearChangedState();
                //renYuan.FENSHU = newFenShu;
                //renYuan.ZHENGQUESHU = zqs;
                //DB.Update(renYuan);
            }
            WriteDBLog("重新评分结束，更新人数：", updateCount);
            return updateCount;
        }

        public T_SHITI GetShiTiModel(V_SHITI_MUBAN_MINGXI mingXi)
        {
            var query = DB.QueryWhere<T_SHITI>(s => s.ID == mingXi.SHITIID);
            return query.ToEntity();
        }
        public bool UpdateShiTi(T_SHITI model, out string errMsg)
        {
            ALTiKuGuanLi tiKuAl = new ALTiKuGuanLi(null);
            return tiKuAl.Update(model, out errMsg);
        }
    }
}