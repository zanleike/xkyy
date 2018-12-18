using System;
using Framework.Entitys;

namespace HursingManage.DBModel
{
	public partial class T_DANGAN_PEIZHI : EntityBase
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

		private System.Decimal _CONFIGTYPE;
		/// <summary>
		/// CONFIGTYPE
		/// </summary>
		[EntityAttribute(ColumnName = CNCONFIGTYPE)]
		public System.Decimal CONFIGTYPE
		{
			get { return _CONFIGTYPE; }
			set
			{
				_CONFIGTYPE = value;
				base.SetFieldChanged(CNCONFIGTYPE) ;
			}
		}

		private System.String _CONFIGKEY;
		/// <summary>
		/// CONFIGKEY
		/// </summary>
		[EntityAttribute(ColumnName = CNCONFIGKEY)]
		public System.String CONFIGKEY
		{
			get { return _CONFIGKEY; }
			set
			{
				_CONFIGKEY = value;
				base.SetFieldChanged(CNCONFIGKEY) ;
			}
		}

		private System.String _CONFIGVALUE;
		/// <summary>
		/// CONFIGVALUE
		/// </summary>
		[EntityAttribute(ColumnName = CNCONFIGVALUE)]
		public System.String CONFIGVALUE
		{
			get { return _CONFIGVALUE; }
			set
			{
				_CONFIGVALUE = value;
				base.SetFieldChanged(CNCONFIGVALUE) ;
			}
		}

		private System.String _REMARK;
		/// <summary>
		/// REMARK
		/// </summary>
		[EntityAttribute(ColumnName = CNREMARK)]
		public System.String REMARK
		{
			get { return _REMARK; }
			set
			{
				_REMARK = value;
				base.SetFieldChanged(CNREMARK) ;
			}
		}

		#region 字段名的定义
		public const string CNID = "ID";
		public const string CNCONFIGTYPE = "CONFIGTYPE";
		public const string CNCONFIGKEY = "CONFIGKEY";
		public const string CNCONFIGVALUE = "CONFIGVALUE";
		public const string CNREMARK = "REMARK";
		#endregion

	}
}
