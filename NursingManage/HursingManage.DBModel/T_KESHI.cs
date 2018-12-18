using System;
using Framework.Entitys;

namespace HursingManage.DBModel
{
	public partial class T_KESHI : EntityBase
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

		private System.String _KESHILEIBIE;
		/// <summary>
		/// KESHILEIBIE
		/// </summary>
		[EntityAttribute(ColumnName = CNKESHILEIBIE)]
		public System.String KESHILEIBIE
		{
			get { return _KESHILEIBIE; }
			set
			{
				_KESHILEIBIE = value;
				base.SetFieldChanged(CNKESHILEIBIE) ;
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

		private System.String _LEIXING1;
		/// <summary>
		/// LEIXING1
		/// </summary>
		[EntityAttribute(ColumnName = CNLEIXING1)]
		public System.String LEIXING1
		{
			get { return _LEIXING1; }
			set
			{
				_LEIXING1 = value;
				base.SetFieldChanged(CNLEIXING1) ;
			}
		}

		private System.String _LEIXING2;
		/// <summary>
		/// LEIXING2
		/// </summary>
		[EntityAttribute(ColumnName = CNLEIXING2)]
		public System.String LEIXING2
		{
			get { return _LEIXING2; }
			set
			{
				_LEIXING2 = value;
				base.SetFieldChanged(CNLEIXING2) ;
			}
		}

		#region 字段名的定义
		public const string CNID = "ID";
		public const string CNBIANMA = "BIANMA";
		public const string CNMINGCHENG = "MINGCHENG";
		public const string CNMINGCHENG_PY = "MINGCHENG_PY";
		public const string CNKESHILEIBIE = "KESHILEIBIE";
		public const string CNADDTIME = "ADDTIME";
		public const string CNLASTTIME = "LASTTIME";
		public const string CNOPERATORID = "OPERATORID";
		public const string CNPC = "PC";
		public const string CNISDEL = "ISDEL";
		public const string CNLEIXING1 = "LEIXING1";
		public const string CNLEIXING2 = "LEIXING2";
		#endregion

	}
}
