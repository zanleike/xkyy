using System;
using Framework.Entitys;

namespace HursingManage.DBModel
{
	public partial class T_DICTIONARY : EntityBase
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

		private System.Decimal _DICTTYPE;
		/// <summary>
		/// DICTTYPE
		/// </summary>
		[EntityAttribute(ColumnName = CNDICTTYPE, IsNotNull = true)]
		public System.Decimal DICTTYPE
		{
			get { return _DICTTYPE; }
			set
			{
				_DICTTYPE = value;
				base.SetFieldChanged(CNDICTTYPE) ;
			}
		}

		private System.Decimal _DICTCODE;
		/// <summary>
		/// DICTCODE
		/// </summary>
		[EntityAttribute(ColumnName = CNDICTCODE)]
		public System.Decimal DICTCODE
		{
			get { return _DICTCODE; }
			set
			{
				_DICTCODE = value;
				base.SetFieldChanged(CNDICTCODE) ;
			}
		}

		private System.String _DICTVALUE;
		/// <summary>
		/// DICTVALUE
		/// </summary>
		[EntityAttribute(ColumnName = CNDICTVALUE)]
		public System.String DICTVALUE
		{
			get { return _DICTVALUE; }
			set
			{
				_DICTVALUE = value;
				base.SetFieldChanged(CNDICTVALUE) ;
			}
		}

		private System.String _DICTVALUE_PY;
		/// <summary>
		/// DICTVALUE_PY
		/// </summary>
		[EntityAttribute(ColumnName = CNDICTVALUE_PY)]
		public System.String DICTVALUE_PY
		{
			get { return _DICTVALUE_PY; }
			set
			{
				_DICTVALUE_PY = value;
				base.SetFieldChanged(CNDICTVALUE_PY) ;
			}
		}

		private System.Decimal _DICTVALUEORDER;
		/// <summary>
		/// DICTVALUEORDER
		/// </summary>
		[EntityAttribute(ColumnName = CNDICTVALUEORDER)]
		public System.Decimal DICTVALUEORDER
		{
			get { return _DICTVALUEORDER; }
			set
			{
				_DICTVALUEORDER = value;
				base.SetFieldChanged(CNDICTVALUEORDER) ;
			}
		}

		private System.Decimal _ISDELETE;
		/// <summary>
		/// ISDELETE
		/// </summary>
		[EntityAttribute(ColumnName = CNISDELETE)]
		public System.Decimal ISDELETE
		{
			get { return _ISDELETE; }
			set
			{
				_ISDELETE = value;
				base.SetFieldChanged(CNISDELETE) ;
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
		public const string CNDICTTYPE = "DICTTYPE";
		public const string CNDICTCODE = "DICTCODE";
		public const string CNDICTVALUE = "DICTVALUE";
		public const string CNDICTVALUE_PY = "DICTVALUE_PY";
		public const string CNDICTVALUEORDER = "DICTVALUEORDER";
		public const string CNISDELETE = "ISDELETE";
		public const string CNREMARK = "REMARK";
		#endregion

	}
}
