using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Framework.Entitys;

namespace HursingManage.DBModel
{
    public partial class T_NUMBER_CONFIG : EntityBase
    {
        private System.Int32 _Id;
        /// <summary>
        /// Id
        /// </summary>
        [EntityAttribute(ColumnName = CNId, IsPrimaryKey = true, IsNotNull = true)]
        public System.Int32 Id
        {
            get { return _Id; }
            set
            {
                _Id = value;
                base.SetFieldChanged(CNId);
            }
        }

        private System.String _Caption;
        /// <summary>
        /// Caption
        /// </summary>
        [EntityAttribute(ColumnName = CNCaption)]
        public System.String Caption
        {
            get { return _Caption; }
            set
            {
                _Caption = value;
                base.SetFieldChanged(CNCaption);
            }
        }

        private System.String _FrontStr;
        /// <summary>
        /// FrontStr
        /// </summary>
        [EntityAttribute(ColumnName = CNFrontStr)]
        public System.String FrontStr
        {
            get { return _FrontStr; }
            set
            {
                _FrontStr = value;
                base.SetFieldChanged(CNFrontStr);
            }
        }

        private System.DateTime _LastDate;
        /// <summary>
        /// LastDate
        /// </summary>
        [EntityAttribute(ColumnName = CNLastDate)]
        public System.DateTime LastDate
        {
            get { return _LastDate; }
            set
            {
                _LastDate = value;
                base.SetFieldChanged(CNLastDate);
            }
        }

        private System.String _DateFormat;
        /// <summary>
        /// DateFormat
        /// </summary>
        [EntityAttribute(ColumnName = CNDateFormat)]
        public System.String DateFormat
        {
            get { return _DateFormat; }
            set
            {
                _DateFormat = value;
                base.SetFieldChanged(CNDateFormat);
            }
        }

        private System.Int32 _MaxValue;
        /// <summary>
        /// MaxValue
        /// </summary>
        [EntityAttribute(ColumnName = CNMaxValue)]
        public System.Int32 MaxValue
        {
            get { return _MaxValue; }
            set
            {
                _MaxValue = value;
                base.SetFieldChanged(CNMaxValue);
            }
        }

        private System.Int32 _MaxValueLength;
        /// <summary>
        /// MaxValueLength
        /// </summary>
        [EntityAttribute(ColumnName = CNMaxValueLength)]
        public System.Int32 MaxValueLength
        {
            get { return _MaxValueLength; }
            set
            {
                _MaxValueLength = value;
                base.SetFieldChanged(CNMaxValueLength);
            }
        }

        private System.String _BackStr;
        /// <summary>
        /// BackStr
        /// </summary>
        [EntityAttribute(ColumnName = CNBackStr)]
        public System.String BackStr
        {
            get { return _BackStr; }
            set
            {
                _BackStr = value;
                base.SetFieldChanged(CNBackStr);
            }
        }

        #region 字段名的定义
        public const string CNId = "Id";
        public const string CNCaption = "Caption";
        public const string CNFrontStr = "FrontStr";
        public const string CNLastDate = "LastDate";
        public const string CNDateFormat = "DateFormat";
        public const string CNMaxValue = "MaxValue";
        public const string CNMaxValueLength = "MaxValueLength";
        public const string CNBackStr = "BackStr";
        #endregion

    }
}
