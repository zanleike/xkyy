using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using HursingManage.AL;
using HursingManage.DBModel;
using HursingManage.WebServer.Common;
using HursingManage.WebServer.Models;
using Framework.Common.Helpers;

namespace HursingManage.WebServer.Controllers
{
    public class HomeController : BaseController
    {
        /// <summary>
        /// 用户试卷信息
        /// </summary>
        public const string SessionKey_USERPAPER = "UserPaper";

        public ActionResult Index()
        {
            if (Session[SessionKey_USERPAPER] == null)
            {
                return RedirectToAction("Login");
            }
            else
            {
                var viewModel = Session[SessionKey_USERPAPER] as ExaminationPaperResult;
                ViewBag.PaperInfo = Common.JsonHelper.ToJson(viewModel);
                ViewData.Model = viewModel;
                ALExamination al = new ALExamination();
                al.SetLoginState(viewModel.MingXiId);
                al.WriteDBLog("考试登陆,编号：{0}，IP：{1}", WebCommon.GetWebClientIp());
                return View("Index", Session[SessionKey_USERPAPER]);
            }
        }
        public ActionResult Login()
        {
            return View("Login");
        }

        public ActionResult LoginOut()
        {
            Session.Clear();
            return Content("out success");
        }


        /// <summary>
        /// 登陆并得到试题列表
        /// </summary>
        [HttpPost]
        public ActionResult GetPaper(ExaminationPaperParam param)
        {
            ExaminationPaperResult r = new ExaminationPaperResult();
            if (param == null)
            {
                r.Code = 101;
                r.Message = "system error: param is null";
                return Json(r);
            }
            if (string.IsNullOrWhiteSpace(param.BianHao) || string.IsNullOrWhiteSpace(param.KaoHao))
            {
                //ViewBag.IsLoginErr = true;
                //ViewBag.ErrMessage = "system error: BianHao is empty or kaoHao is empty。";
                //return Login();
                r.Code = 101;
                r.Message = "system error: BianHao is empty or kaoHao is empty。";
                return Json(r);
            }
            string errMsg;
            ALExamination al = new ALExamination();
            var jiHuaMingXi = al.GetJiHuaMingXiModel(param.BianHao, param.KaoHao, param.MingXiId, out errMsg);
           
            if (jiHuaMingXi == null)
            {
                //ViewBag.IsLoginErr = true;
                //ViewBag.ErrMessage = "未获取到该人员的考试计划。";
                //return Login();
                r.Code = 102;
                r.Message = errMsg;
                return Json(r);
            }

            r.BianHao = jiHuaMingXi.BIANHAO;
            r.XingMing = jiHuaMingXi.XINGMING;
            r.KaoHao = jiHuaMingXi.KAOHAO;
            r.KeShi = jiHuaMingXi.KESHI;
            r.JiHuaMingCheng = jiHuaMingXi.JIHUAMINGCHENG;
            r.MuBanMingCheng = jiHuaMingXi.MUBAN;
            r.MuBanId = jiHuaMingXi.MUBANID;
            r.MingXiId = jiHuaMingXi.ID;

            var muBan = al.GetMBanMingXiData(r.MuBanId);
            if (muBan == null || muBan.Count == 0)
            {
                //ViewBag.IsLoginErr = true;
                //ViewBag.ErrMessage = "未获取到该人员的试题模板或试题记录为空。";
                //return Login();
                r.Code = 102;
                r.Message = "未获取到该人员的试题模板或试题记录为空";
                return Json(r);
            }
            r.PaperTempletList = new List<ExaminationPaperResult.PaperTemplet>();
            var randomTemplet = muBan.OrderBy(s => s.LEIXING).ThenBy(s => Guid.NewGuid()).ToList();
            int randomNo = 0;
            foreach (var shiti in randomTemplet)
            {
                randomNo++;
                r.PaperTempletList.Add(new ExaminationPaperResult.PaperTemplet()
                {
                    RandomNo = randomNo,
                    BianHao = shiti.BIANHAO,
                    FenShu = shiti.FENSHU,
                    LeiXing = shiti.LEIXING,
                    NeiRong = shiti.NEIRONG,
                    ShiTiXuHao = (int)shiti.SHITIXUHAO,
                    XuanXiangA = shiti.XIANGMUA,
                    XuanXiangB = shiti.XIANGMUB,
                    XuanXiangC = shiti.XIANGMUC,
                    XuanXiangD = shiti.XIANGMUD,
                    XuanXiangE = shiti.XIANGMUE,
                    XuanXiangF = shiti.XIANGMUF
                });
            }
            Session[SessionKey_USERPAPER] = r;
            r.Code = 0;
            
            return Json(r);
        }


        [HttpPost]
        public ActionResult SavePaperResult(AnswerResultParam param)
        {
            ExaminationResult r = new ExaminationResult();
            if (param == null)
            {
                r.Code = 101;
                r.Message = "param is null";
            }
            else if (string.IsNullOrWhiteSpace(param.MingXiId))
            {
                r.Code = 101;
                r.Message = "MingXiId is null";
            }
            else if (string.IsNullOrWhiteSpace(param.KaoHao))
            {
                r.Code = 101;
                r.Message = "KaoHao is null";
            }
            else if (string.IsNullOrWhiteSpace(param.AnswerStr))
            {
                r.Code = 101;
                r.Message = "AnswerStr is null";
            }
            else if (param.StartTime <= 0)
            {
                r.Code = 101;
                r.Message = "StartTime is null";
            }
            else
            {
                DateTime startTime = DateTimeHelper.GetTimeByTimestamp(param.StartTime);
                V_PEIXUNJIHUA_MINGXI renYuan = new V_PEIXUNJIHUA_MINGXI();
                renYuan.ID = param.MingXiId;
                renYuan.DATI = param.AnswerStr;
                renYuan.DATIKAISHI = startTime;
                renYuan.DATIJIESHU = DateTime.Now;
                renYuan.KAOHAO = param.KaoHao;
                renYuan.MUBANID = param.MuBanId;
                renYuan.TIJIAOIP = WebCommon.GetWebClientIp();
                
                ALExamination al = new ALExamination();
                string errMsg;
                if (!al.SaveDaAn(renYuan, out errMsg))
                {
                    r.Code = 102;
                    r.Message = errMsg;
                }
                else
                {
                    r.Code = 0;
                    r.Message = string.Empty;
                }
            }
            return Json(r);
        }
    }
}