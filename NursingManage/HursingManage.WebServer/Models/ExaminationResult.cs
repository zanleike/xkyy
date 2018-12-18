using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HursingManage.WebServer.Common;
using Framework.Common.Helpers;

namespace HursingManage.WebServer.Models
{
    public class MyDateTimeConverter : IsoDateTimeConverter
    {
        public MyDateTimeConverter()
        {
            DateTimeFormat = "yyyy-MM-dd HH:mm:ss";
        }
    }

    [JsonObject(MemberSerialization.OptOut)]
    public class ExaminationResult
    {
        private static IsoDateTimeConverter dtConverter = new IsoDateTimeConverter { DateTimeFormat = "yyyy-MM-dd HH:mm:ss" };

        /// <summary>
        /// 返回0 未正常，其它为失败
        /// </summary>
        [JsonProperty(PropertyName = "code")]
        public int Code { set; get; }

        [JsonProperty(PropertyName = "message")]
        public string Message { set; get; }

        [JsonIgnore]
        public string remark { set; get; }

        public long ServerTimeStamp
        {
            get
            {
                return DateTimeHelper.DateTimeToTimestamp(DateTime.Now);
            }
        }
        //[JsonConverter(typeof(MyDateTimeConverter))]
        //public DateTime Birthday { get; set; }

        public string ToJson()
        {
            return JsonHelper.ToJson(this);
        }
    }

    /// <summary>
    /// 试卷结果返回
    /// </summary>
    public class ExaminationPaperResult : ExaminationResult
    {
        /// <summary>
        /// 人员编号
        /// </summary>
        public string BianHao { set; get; }
        /// <summary>
        /// 人员姓名
        /// </summary>
        public string XingMing { set; get; }
        /// <summary>
        /// 科室名称
        /// </summary>
        public string KeShi { set; get; }
        /// <summary>
        /// V_PEIXUNJIHUA_MINGXI.ID 映射，上传答案时使用
        /// </summary>
        public string MingXiId { set; get; }
        /// <summary>
        /// 计划名称
        /// </summary>
        public string JiHuaMingCheng { set; get; }
        /// <summary>
        /// 模板Id
        /// </summary>
        public string MuBanId { set; get; }
        /// <summary>
        /// 模板名称
        /// </summary>
        public string MuBanMingCheng { set; get; }        
        /// <summary>
        /// 考号
        /// </summary>
        public string KaoHao { get; set; }
        /// <summary>
        /// 计划明细列表
        /// </summary>
        public List<PaperTemplet> PaperTempletList { set; get; }

        /// <summary>
        /// 试题模板定义
        /// </summary>
        public class PaperTemplet
        {
            /// <summary>
            /// 试题序号
            /// </summary>
            public int ShiTiXuHao { set; get; }
            /// <summary>
            /// 试题编号
            /// </summary>
            public string BianHao { set; get; }
            /// <summary>
            /// 问题内容
            /// </summary>
            public string NeiRong { set; get; }
            /// <summary>
            /// 试题类型（多选，单选，判断）
            /// </summary>
            public string LeiXing { set; get; }
            /// <summary>
            /// 分数
            /// </summary>
            public decimal FenShu { set; get; }

            public string XuanXiangA { set; get; }
            public string XuanXiangB { set; get; }
            public string XuanXiangC { set; get; }
            public string XuanXiangD { set; get; }
            public string XuanXiangE { set; get; }
            public string XuanXiangF { set; get; }
            /// <summary>
            /// 随机顺序序号
            /// </summary>
            public int RandomNo { get; set; }
        }
        
    }
}