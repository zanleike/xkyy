using System;
using Framework.Entitys;

namespace HursingManage.DBModel
{
	public partial class T_USER_INFO : EntityBase
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

		private System.String _USER_NO;
		/// <summary>
		/// USER_NO
		/// </summary>
		[EntityAttribute(ColumnName = CNUSER_NO, IsNotNull = true)]
		public System.String USER_NO
		{
			get { return _USER_NO; }
			set
			{
				_USER_NO = value;
				base.SetFieldChanged(CNUSER_NO) ;
			}
		}

		private System.String _USER_NAME;
		/// <summary>
		/// USER_NAME
		/// </summary>
		[EntityAttribute(ColumnName = CNUSER_NAME, IsNotNull = true)]
		public System.String USER_NAME
		{
			get { return _USER_NAME; }
			set
			{
				_USER_NAME = value;
				base.SetFieldChanged(CNUSER_NAME) ;
			}
		}

		private System.String _USER_NAME_PY;
		/// <summary>
		/// USER_NAME_PY
		/// </summary>
		[EntityAttribute(ColumnName = CNUSER_NAME_PY)]
		public System.String USER_NAME_PY
		{
			get { return _USER_NAME_PY; }
			set
			{
				_USER_NAME_PY = value;
				base.SetFieldChanged(CNUSER_NAME_PY) ;
			}
		}

		private System.String _PWD;
		/// <summary>
		/// PWD
		/// </summary>
		[EntityAttribute(ColumnName = CNPWD, IsNotNull = true)]
		public System.String PWD
		{
			get { return _PWD; }
			set
			{
				_PWD = value;
				base.SetFieldChanged(CNPWD) ;
			}
		}

		private System.String _USER_TYPE;
		/// <summary>
		/// USER_TYPE
		/// </summary>
		[EntityAttribute(ColumnName = CNUSER_TYPE, IsNotNull = true)]
		public System.String USER_TYPE
		{
			get { return _USER_TYPE; }
			set
			{
				_USER_TYPE = value;
				base.SetFieldChanged(CNUSER_TYPE) ;
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

		private System.Decimal _ADDINFO;
		/// <summary>
		/// ADDINFO
		/// </summary>
		[EntityAttribute(ColumnName = CNADDINFO)]
		public System.Decimal ADDINFO
		{
			get { return _ADDINFO; }
			set
			{
				_ADDINFO = value;
				base.SetFieldChanged(CNADDINFO) ;
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

		private System.Decimal _LOGINCOUNT;
		/// <summary>
		/// LOGINCOUNT
		/// </summary>
		[EntityAttribute(ColumnName = CNLOGINCOUNT)]
		public System.Decimal LOGINCOUNT
		{
			get { return _LOGINCOUNT; }
			set
			{
				_LOGINCOUNT = value;
				base.SetFieldChanged(CNLOGINCOUNT) ;
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

		private System.String _ROLE_ID;
		/// <summary>
		/// ROLE_ID
		/// </summary>
		[EntityAttribute(ColumnName = CNROLE_ID)]
		public System.String ROLE_ID
		{
			get { return _ROLE_ID; }
			set
			{
				_ROLE_ID = value;
				base.SetFieldChanged(CNROLE_ID) ;
			}
		}

		private System.String _ROLE_NAME;
		/// <summary>
		/// ROLE_NAME
		/// </summary>
		[EntityAttribute(ColumnName = CNROLE_NAME)]
		public System.String ROLE_NAME
		{
			get { return _ROLE_NAME; }
			set
			{
				_ROLE_NAME = value;
				base.SetFieldChanged(CNROLE_NAME) ;
			}
		}

		private System.String _KESHIID;
		/// <summary>
		/// KESHIID
		/// </summary>
		[EntityAttribute(ColumnName = CNKESHIID)]
		public System.String KESHIID
		{
			get { return _KESHIID; }
			set
			{
				_KESHIID = value;
				base.SetFieldChanged(CNKESHIID) ;
			}
		}

		private System.String _KESHIMINGCHENG;
		/// <summary>
		/// KESHIMINGCHENG
		/// </summary>
		[EntityAttribute(ColumnName = CNKESHIMINGCHENG)]
		public System.String KESHIMINGCHENG
		{
			get { return _KESHIMINGCHENG; }
			set
			{
				_KESHIMINGCHENG = value;
				base.SetFieldChanged(CNKESHIMINGCHENG) ;
			}
		}

		#region 字段名的定义
		public const string CNID = "ID";
		public const string CNUSER_NO = "USER_NO";
		public const string CNUSER_NAME = "USER_NAME";
		public const string CNUSER_NAME_PY = "USER_NAME_PY";
		public const string CNPWD = "PWD";
		public const string CNUSER_TYPE = "USER_TYPE";
		public const string CNISDEL = "ISDEL";
		public const string CNADDINFO = "ADDINFO";
		public const string CNADDTIME = "ADDTIME";
		public const string CNLASTTIME = "LASTTIME";
		public const string CNLOGINCOUNT = "LOGINCOUNT";
		public const string CNPC = "PC";
		public const string CNROLE_ID = "ROLE_ID";
		public const string CNROLE_NAME = "ROLE_NAME";
		public const string CNKESHIID = "KESHIID";
		public const string CNKESHIMINGCHENG = "KESHIMINGCHENG";
		#endregion

	}
}
