using System;
using Framework.Entitys;

namespace HursingManage.DBModel
{
	public partial class T_LOGS : EntityBase
	{
		private System.String _ID;
		/// <summary>
		/// ID
		/// </summary>
		[EntityAttribute(ColumnName = CNID, IsPrimaryKey = true, IsNotNull = true)]
		public System.String ID
		{
			get { return _ID; }
			set
			{
				_ID = value;
				base.SetFieldChanged(CNID) ;
			}
		}

		private System.String _LOGCONTENT;
		/// <summary>
		/// LOGCONTENT
		/// </summary>
		[EntityAttribute(ColumnName = CNLOGCONTENT)]
		public System.String LOGCONTENT
		{
			get { return _LOGCONTENT; }
			set
			{
				_LOGCONTENT = value;
				base.SetFieldChanged(CNLOGCONTENT) ;
			}
		}

		private System.String _OPERATORID;
		/// <summary>
		/// OPERATORID
		/// </summary>
		[EntityAttribute(ColumnName = CNOPERATORID)]
		public System.String OPERATORID
		{
			get { return _OPERATORID; }
			set
			{
				_OPERATORID = value;
				base.SetFieldChanged(CNOPERATORID) ;
			}
		}

		private System.String _OPERATORNAME;
		/// <summary>
		/// OPERATORNAME
		/// </summary>
		[EntityAttribute(ColumnName = CNOPERATORNAME)]
		public System.String OPERATORNAME
		{
			get { return _OPERATORNAME; }
			set
			{
				_OPERATORNAME = value;
				base.SetFieldChanged(CNOPERATORNAME) ;
			}
		}

		private System.DateTime _LOGTIME;
		/// <summary>
		/// LOGTIME
		/// </summary>
		[EntityAttribute(ColumnName = CNLOGTIME)]
		public System.DateTime LOGTIME
		{
			get { return _LOGTIME; }
			set
			{
				_LOGTIME = value;
				base.SetFieldChanged(CNLOGTIME) ;
			}
		}

		private System.String _PC;
		/// <summary>
		/// PC
		/// </summary>
		[EntityAttribute(ColumnName = CNPC)]
		public System.String PC
		{
			get { return _PC; }
			set
			{
				_PC = value;
				base.SetFieldChanged(CNPC) ;
			}
		}

		#region 字段名的定义
		public const string CNID = "ID";
		public const string CNLOGCONTENT = "LOGCONTENT";
		public const string CNOPERATORID = "OPERATORID";
		public const string CNOPERATORNAME = "OPERATORNAME";
		public const string CNLOGTIME = "LOGTIME";
		public const string CNPC = "PC";
		#endregion

	}
}
