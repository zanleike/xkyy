using System;
using Framework.Entitys;

namespace HursingManage.DBModel
{
	public partial class T_SEARCH_RECORD : EntityBase
	{
		private System.String _ID;
		/// <summary>
		/// ID
		/// </summary>
		[EntityAttribute(ColumnName = CNID, IsPrimaryKey = true)]
		public System.String ID
		{
			get { return _ID; }
			set
			{
				_ID = value;
				base.SetFieldChanged(CNID) ;
			}
		}

		private System.String _OWNERFORM;
		/// <summary>
		/// OWNERFORM
		/// </summary>
		[EntityAttribute(ColumnName = CNOWNERFORM)]
		public System.String OWNERFORM
		{
			get { return _OWNERFORM; }
			set
			{
				_OWNERFORM = value;
				base.SetFieldChanged(CNOWNERFORM) ;
			}
		}

		private System.String _RECORDREMARK;
		/// <summary>
		/// RECORDREMARK
		/// </summary>
		[EntityAttribute(ColumnName = CNRECORDREMARK)]
		public System.String RECORDREMARK
		{
			get { return _RECORDREMARK; }
			set
			{
				_RECORDREMARK = value;
				base.SetFieldChanged(CNRECORDREMARK) ;
			}
		}

		private System.String _RECORDREMARK_PY;
		/// <summary>
		/// RECORDREMARK_PY
		/// </summary>
		[EntityAttribute(ColumnName = CNRECORDREMARK_PY)]
		public System.String RECORDREMARK_PY
		{
			get { return _RECORDREMARK_PY; }
			set
			{
				_RECORDREMARK_PY = value;
				base.SetFieldChanged(CNRECORDREMARK_PY) ;
			}
		}

		private System.Decimal _ISDEFAULT;
		/// <summary>
		/// ISDEFAULT
		/// </summary>
		[EntityAttribute(ColumnName = CNISDEFAULT)]
		public System.Decimal ISDEFAULT
		{
			get { return _ISDEFAULT; }
			set
			{
				_ISDEFAULT = value;
				base.SetFieldChanged(CNISDEFAULT) ;
			}
		}

		private System.Decimal _ORDERNO;
		/// <summary>
		/// ORDERNO
		/// </summary>
		[EntityAttribute(ColumnName = CNORDERNO)]
		public System.Decimal ORDERNO
		{
			get { return _ORDERNO; }
			set
			{
				_ORDERNO = value;
				base.SetFieldChanged(CNORDERNO) ;
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
		public const string CNOWNERFORM = "OWNERFORM";
		public const string CNRECORDREMARK = "RECORDREMARK";
		public const string CNRECORDREMARK_PY = "RECORDREMARK_PY";
		public const string CNISDEFAULT = "ISDEFAULT";
		public const string CNORDERNO = "ORDERNO";
		public const string CNOPERATORID = "OPERATORID";
		public const string CNADDTIME = "ADDTIME";
		public const string CNLASTTIME = "LASTTIME";
		#endregion

	}
}
