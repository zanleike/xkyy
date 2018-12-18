using System;
using Framework.Entitys;

namespace HursingManage.DBModel
{
	public partial class T_DEPART : EntityBase
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

		private System.String _PID;
		/// <summary>
		/// PID
		/// </summary>
		[EntityAttribute(ColumnName = CNPID)]
		public System.String PID
		{
			get { return _PID; }
			set
			{
				_PID = value;
				base.SetFieldChanged(CNPID) ;
			}
		}

		private System.String _BIANMA;
		/// <summary>
		/// BIANMA
		/// </summary>
		[EntityAttribute(ColumnName = CNBIANMA)]
		public System.String BIANMA
		{
			get { return _BIANMA; }
			set
			{
				_BIANMA = value;
				base.SetFieldChanged(CNBIANMA) ;
			}
		}

		private System.String _MINGCHENG;
		/// <summary>
		/// MINGCHENG
		/// </summary>
		[EntityAttribute(ColumnName = CNMINGCHENG)]
		public System.String MINGCHENG
		{
			get { return _MINGCHENG; }
			set
			{
				_MINGCHENG = value;
				base.SetFieldChanged(CNMINGCHENG) ;
			}
		}

		private System.String _MINGCHENG_PY;
		/// <summary>
		/// MINGCHENG_PY
		/// </summary>
		[EntityAttribute(ColumnName = CNMINGCHENG_PY)]
		public System.String MINGCHENG_PY
		{
			get { return _MINGCHENG_PY; }
			set
			{
				_MINGCHENG_PY = value;
				base.SetFieldChanged(CNMINGCHENG_PY) ;
			}
		}

		private System.Decimal _ISDEL;
		/// <summary>
		/// ISDEL
		/// </summary>
		[EntityAttribute(ColumnName = CNISDEL)]
		public System.Decimal ISDEL
		{
			get { return _ISDEL; }
			set
			{
				_ISDEL = value;
				base.SetFieldChanged(CNISDEL) ;
			}
		}

		private System.DateTime _ADDTIME;
		/// <summary>
		/// ADDTIME
		/// </summary>
		[EntityAttribute(ColumnName = CNADDTIME)]
		public System.DateTime ADDTIME
		{
			get { return _ADDTIME; }
			set
			{
				_ADDTIME = value;
				base.SetFieldChanged(CNADDTIME) ;
			}
		}

		private System.DateTime _LASTTIME;
		/// <summary>
		/// LASTTIME
		/// </summary>
		[EntityAttribute(ColumnName = CNLASTTIME)]
		public System.DateTime LASTTIME
		{
			get { return _LASTTIME; }
			set
			{
				_LASTTIME = value;
				base.SetFieldChanged(CNLASTTIME) ;
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

		#region 字段名的定义
		public const string CNID = "ID";
		public const string CNPID = "PID";
		public const string CNBIANMA = "BIANMA";
		public const string CNMINGCHENG = "MINGCHENG";
		public const string CNMINGCHENG_PY = "MINGCHENG_PY";
		public const string CNISDEL = "ISDEL";
		public const string CNADDTIME = "ADDTIME";
		public const string CNLASTTIME = "LASTTIME";
		public const string CNOPERATORID = "OPERATORID";
		#endregion

	}
}
