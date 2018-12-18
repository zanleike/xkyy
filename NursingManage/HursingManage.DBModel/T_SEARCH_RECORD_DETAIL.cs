using System;
using Framework.Entitys;

namespace HursingManage.DBModel
{
	public partial class T_SEARCH_RECORD_DETAIL : EntityBase
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

		private System.String _FIELDNAME;
		/// <summary>
		/// FIELDNAME
		/// </summary>
		[EntityAttribute(ColumnName = CNFIELDNAME)]
		public System.String FIELDNAME
		{
			get { return _FIELDNAME; }
			set
			{
				_FIELDNAME = value;
				base.SetFieldChanged(CNFIELDNAME) ;
			}
		}

		private System.String _COMPARESIGN;
		/// <summary>
		/// COMPARESIGN
		/// </summary>
		[EntityAttribute(ColumnName = CNCOMPARESIGN)]
		public System.String COMPARESIGN
		{
			get { return _COMPARESIGN; }
			set
			{
				_COMPARESIGN = value;
				base.SetFieldChanged(CNCOMPARESIGN) ;
			}
		}

		private System.String _CONNECTORSIGN;
		/// <summary>
		/// CONNECTORSIGN
		/// </summary>
		[EntityAttribute(ColumnName = CNCONNECTORSIGN)]
		public System.String CONNECTORSIGN
		{
			get { return _CONNECTORSIGN; }
			set
			{
				_CONNECTORSIGN = value;
				base.SetFieldChanged(CNCONNECTORSIGN) ;
			}
		}

		private System.String _SEARCHVALUE;
		/// <summary>
		/// SEARCHVALUE
		/// </summary>
		[EntityAttribute(ColumnName = CNSEARCHVALUE)]
		public System.String SEARCHVALUE
		{
			get { return _SEARCHVALUE; }
			set
			{
				_SEARCHVALUE = value;
				base.SetFieldChanged(CNSEARCHVALUE) ;
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

		private System.String _RECORDID;
		/// <summary>
		/// RECORDID
		/// </summary>
		[EntityAttribute(ColumnName = CNRECORDID)]
		public System.String RECORDID
		{
			get { return _RECORDID; }
			set
			{
				_RECORDID = value;
				base.SetFieldChanged(CNRECORDID) ;
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

		#region 字段名的定义
		public const string CNID = "ID";
		public const string CNOWNERFORM = "OWNERFORM";
		public const string CNFIELDNAME = "FIELDNAME";
		public const string CNCOMPARESIGN = "COMPARESIGN";
		public const string CNCONNECTORSIGN = "CONNECTORSIGN";
		public const string CNSEARCHVALUE = "SEARCHVALUE";
		public const string CNORDERNO = "ORDERNO";
		public const string CNRECORDID = "RECORDID";
		public const string CNDATATYPE = "DATATYPE";
		#endregion

	}
}
