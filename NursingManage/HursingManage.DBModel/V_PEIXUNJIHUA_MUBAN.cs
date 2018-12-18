using System;
using Framework.Entitys;

namespace HursingManage.DBModel
{
	public partial class V_PEIXUNJIHUA_MUBAN : EntityBase
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

		private System.String _JIHUAID;
		/// <summary>
		/// JIHUAID
		/// </summary>
		[EntityAttribute(ColumnName = CNJIHUAID)]
		public System.String JIHUAID
		{
			get { return _JIHUAID; }
			set
			{
				_JIHUAID = value;
				base.SetFieldChanged(CNJIHUAID) ;
			}
		}

		private System.String _MUBANID;
		/// <summary>
		/// MUBANID
		/// </summary>
		[EntityAttribute(ColumnName = CNMUBANID)]
		public System.String MUBANID
		{
			get { return _MUBANID; }
			set
			{
				_MUBANID = value;
				base.SetFieldChanged(CNMUBANID) ;
			}
		}

		private System.String _MUBAN;
		/// <summary>
		/// MUBAN
		/// </summary>
		[EntityAttribute(ColumnName = CNMUBAN)]
		public System.String MUBAN
		{
			get { return _MUBAN; }
			set
			{
				_MUBAN = value;
				base.SetFieldChanged(CNMUBAN) ;
			}
		}

		private System.Decimal _MUBANRENSHU;
		/// <summary>
		/// MUBANRENSHU
		/// </summary>
		[EntityAttribute(ColumnName = CNMUBANRENSHU)]
		public System.Decimal MUBANRENSHU
		{
			get { return _MUBANRENSHU; }
			set
			{
				_MUBANRENSHU = value;
				base.SetFieldChanged(CNMUBANRENSHU) ;
			}
		}

		private System.String _KAIQIKAOSHI;
		/// <summary>
		/// KAIQIKAOSHI
		/// </summary>
		[EntityAttribute(ColumnName = CNKAIQIKAOSHI)]
		public System.String KAIQIKAOSHI
		{
			get { return _KAIQIKAOSHI; }
			set
			{
				_KAIQIKAOSHI = value;
				base.SetFieldChanged(CNKAIQIKAOSHI) ;
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

		#region 字段名的定义
		public const string CNID = "ID";
		public const string CNJIHUAID = "JIHUAID";
		public const string CNMUBANID = "MUBANID";
		public const string CNMUBAN = "MUBAN";
		public const string CNMUBANRENSHU = "MUBANRENSHU";
		public const string CNKAIQIKAOSHI = "KAIQIKAOSHI";
		public const string CNADDTIME = "ADDTIME";
		public const string CNLASTTIME = "LASTTIME";
		#endregion

	}
}
