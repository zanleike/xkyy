using System;
using Framework.Entitys;

namespace HursingManage.DBModel
{
	public partial class T_DANGAN_EX_PEIZHI : EntityBase
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

		private System.Decimal _COLUMN_NO;
		/// <summary>
		/// COLUMN_NO
		/// </summary>
		[EntityAttribute(ColumnName = CNCOLUMN_NO)]
		public System.Decimal COLUMN_NO
		{
			get { return _COLUMN_NO; }
			set
			{
				_COLUMN_NO = value;
				base.SetFieldChanged(CNCOLUMN_NO) ;
			}
		}

		private System.String _COLUNM_CAPTION;
		/// <summary>
		/// COLUNM_CAPTION
		/// </summary>
		[EntityAttribute(ColumnName = CNCOLUNM_CAPTION)]
		public System.String COLUNM_CAPTION
		{
			get { return _COLUNM_CAPTION; }
			set
			{
				_COLUNM_CAPTION = value;
				base.SetFieldChanged(CNCOLUNM_CAPTION) ;
			}
		}

		private System.String _CONTROL_TYPE;
		/// <summary>
		/// CONTROL_TYPE
		/// </summary>
		[EntityAttribute(ColumnName = CNCONTROL_TYPE)]
		public System.String CONTROL_TYPE
		{
			get { return _CONTROL_TYPE; }
			set
			{
				_CONTROL_TYPE = value;
				base.SetFieldChanged(CNCONTROL_TYPE) ;
			}
		}

		private System.String _VALUE_TYPE;
		/// <summary>
		/// VALUE_TYPE
		/// </summary>
		[EntityAttribute(ColumnName = CNVALUE_TYPE)]
		public System.String VALUE_TYPE
		{
			get { return _VALUE_TYPE; }
			set
			{
				_VALUE_TYPE = value;
				base.SetFieldChanged(CNVALUE_TYPE) ;
			}
		}

		#region 字段名的定义
		public const string CNID = "ID";
		public const string CNCOLUMN_NO = "COLUMN_NO";
		public const string CNCOLUNM_CAPTION = "COLUNM_CAPTION";
		public const string CNCONTROL_TYPE = "CONTROL_TYPE";
		public const string CNVALUE_TYPE = "VALUE_TYPE";
		#endregion

	}
}
