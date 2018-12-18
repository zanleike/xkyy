using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HursingManage.WebServer.Models
{
    /// <summary>
    /// 请求试卷参数
    /// </summary>
    public class ExaminationPaperParam
    {
        /// <summary>
        /// 人员编号
        /// </summary>
        public string BianHao { set; get; }
        /// <summary>
        /// 姓名
        /// </summary>
        public string KaoHao { set; get; }
        /// <summary>
        /// 当非第一次登陆时会传入该参数，
        /// </summary>
        public string MingXiId { set; get; }
    }

    public class AnswerResultParam
    {
        public string MingXiId { set; get; }
        public string MuBanId { set; get; }
        public string KaoHao { set; get; }
        public string AnswerStr { set; get; }
        public long StartTime { set; get; }
    }

    /// <summary>
    /// 提交试题内容
    /// </summary>
    public class ExaminationParam
    {
        /// <summary>
        /// 编号（用于验证）
        /// </summary>
        public string BianHao { set; get; }
        /// <summary>
        /// 姓名（用于验证）
        /// </summary>
        public string XingMing { set; get; }
        /// <summary>
        /// 计划明细Id
        /// </summary>
        public string Id { set; get; }
        /// <summary>
        /// 模板Id
        /// </summary>
        public string MuBanId { set; get; }
        /// <summary>
        /// 答案,每道题以英文半角逗号（,） 隔开；
        /// </summary>
        public string AnswerStr { set; get; }
        /// <summary>
        /// 开始答题时间，格式：yyyy-MM-dd HH:mm:ss
        /// </summary>
        public string StartTime { set; get; }
        /// <summary>
        /// 结束答题时间，格式：yyyy-MM-dd HH:mm:ss
        /// </summary>
        public string EndTime { set; get; }
        /// <summary>
        /// 答案列表
        /// </summary>
        public List<AnswerModel> AnswerList { set; get; }

        public class AnswerModel
        {
            /// <summary>
            /// 试题序号
            /// </summary>
            public int ShiTiXuHao { set; get; }
            /// <summary>
            /// 随机顺序号
            /// </summary>
            public int RandomNo { set; get; }
            /// <summary>
            /// 对应的答案
            /// </summary>
            public string Answer { set; get; }
        }
    }
    
}