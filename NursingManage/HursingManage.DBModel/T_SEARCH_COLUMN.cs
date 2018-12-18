using System;
using Framework.Entitys;

namespace HursingManage.DBModel
{
	public partial class T_SEARCH_COLUMN : EntityBase
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

		private System.String _COLUMNNAME;
		/// <summary>
		/// COLUMNNAME
		/// </summary>
		[EntityAttribute(ColumnName = CNCOLUMNNAME, IsNotNull = true)]
		public System.String COLUMNNAME
		{
			get { return _COLUMNNAME; }
			set
			{
				_COLUMNNAME = value;
				base.SetFieldChanged(CNCOLUMNNAME) ;
			}
		}

		private System.String _COLUMNCAPTION;
		/// <summary>
		/// COLUMNCAPTION
		/// </summary>
		[EntityAttribute(ColumnName = CNCOLUMNCAPTION, IsNotNull = true)]
		public System.String COLUMNCAPTION
		{
			get { return _COLUMNCAPTION; }
			set
			{
				_COLUMNCAPTION = value;
				base.SetFieldChanged(CNCOLUMNCAPTION) ;
			}
		}

		private System.String _DATATYPE;
		/// <summary>
		/// DATATYPE
		/// </summary>
		[EntityAttribute(ColumnName = CNDATATYPE)]
		public System.String DATATYPE
		{
			get { return _DATATYPE; }
			set
			{
				_DATATYPE = value;
				base.SetFieldChanged(CNDATATYPE) ;
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

		private System.String _MODELCLASS;
		/// <summary>
		/// MODELCLASS
		/// </summary>
		[EntityAttribute(ColumnName = CNMODELCLASS)]
		public System.String MODELCLASS
		{
			get { return _MODELCLASS; }
			set
			{
				_MODELCLASS = value;
				base.SetFieldChanged(CNMODELCLASS) ;
			}
		}

		#region 字段名的定义
		public const string CNID = "ID";
		public const string CNORDERNO = "ORDERNO";
		public const string CNCOLUMNNAME = "COLUMNNAME";
		public const string CNCOLUMNCAPTION = "COLUMNCAPTION";
		public const string CNDATATYPE = "DATATYPE";
		public const string CNADDTIME = "ADDTIME";
		public const string CNMODELCLASS = "MODELCLASS";
		#endregion

	}
}
