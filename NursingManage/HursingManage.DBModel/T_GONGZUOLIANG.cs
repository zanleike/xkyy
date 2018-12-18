using System;
using Framework.Entitys;

namespace HursingManage.DBModel
{
	public partial class T_GONGZUOLIANG : EntityBase
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

		private System.String _STARTDATE;
		/// <summary>
		/// STARTDATE
		/// </summary>
		[EntityAttribute(ColumnName = CNSTARTDATE)]
		public System.String STARTDATE
		{
			get { return _STARTDATE; }
			set
			{
				_STARTDATE = value;
				base.SetFieldChanged(CNSTARTDATE) ;
			}
		}

		private System.String _ENDDATE;
		/// <summary>
		/// ENDDATE
		/// </summary>
		[EntityAttribute(ColumnName = CNENDDATE)]
		public System.String ENDDATE
		{
			get { return _ENDDATE; }
			set
			{
				_ENDDATE = value;
				base.SetFieldChanged(CNENDDATE) ;
			}
		}

		private System.String _KESHIBIANMA;
		/// <summary>
		/// KESHIBIANMA
		/// </summary>
		[EntityAttribute(ColumnName = CNKESHIBIANMA)]
		public System.String KESHIBIANMA
		{
			get { return _KESHIBIANMA; }
			set
			{
				_KESHIBIANMA = value;
				base.SetFieldChanged(CNKESHIBIANMA) ;
			}
		}

		private System.String _HUSHIBIANMA;
		/// <summary>
		/// HUSHIBIANMA
		/// </summary>
		[EntityAttribute(ColumnName = CNHUSHIBIANMA)]
		public System.String HUSHIBIANMA
		{
			get { return _HUSHIBIANMA; }
			set
			{
				_HUSHIBIANMA = value;
				base.SetFieldChanged(CNHUSHIBIANMA) ;
			}
		}

		private System.String _HUSHI;
		/// <summary>
		/// HUSHI
		/// </summary>
		[EntityAttribute(ColumnName = CNHUSHI)]
		public System.String HUSHI
		{
			get { return _HUSHI; }
			set
			{
				_HUSHI = value;
				base.SetFieldChanged(CNHUSHI) ;
			}
		}

		#region 字段名的定义
		public const string CNID = "ID";
		public const string CNADDTIME = "ADDTIME";
		public const string CNLASTTIME = "LASTTIME";
		public const string CNPC = "PC";
		public const string CNSTARTDATE = "STARTDATE";
		public const string CNENDDATE = "ENDDATE";
		public const string CNKESHIBIANMA = "KESHIBIANMA";
		public const string CNHUSHIBIANMA = "HUSHIBIANMA";
		public const string CNHUSHI = "HUSHI";
		#endregion

	}
}
