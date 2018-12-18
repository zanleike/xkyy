using System;
using Framework.Entitys;

namespace HursingManage.DBModel
{
	public partial class T_GONGZUOLIANG_PEIZHI : EntityBase
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

		private System.String _ITEMNAME;
		/// <summary>
		/// ITEMNAME
		/// </summary>
		[EntityAttribute(ColumnName = CNITEMNAME)]
		public System.String ITEMNAME
		{
			get { return _ITEMNAME; }
			set
			{
				_ITEMNAME = value;
				base.SetFieldChanged(CNITEMNAME) ;
			}
		}

		private System.Decimal _SCOREVALUE;
		/// <summary>
		/// SCOREVALUE
		/// </summary>
		[EntityAttribute(ColumnName = CNSCOREVALUE)]
		public System.Decimal SCOREVALUE
		{
			get { return _SCOREVALUE; }
			set
			{
				_SCOREVALUE = value;
				base.SetFieldChanged(CNSCOREVALUE) ;
			}
		}

		private System.String _SQLTEXT;
		/// <summary>
		/// SQLTEXT
		/// </summary>
		[EntityAttribute(ColumnName = CNSQLTEXT)]
		public System.String SQLTEXT
		{
			get { return _SQLTEXT; }
			set
			{
				_SQLTEXT = value;
				base.SetFieldChanged(CNSQLTEXT) ;
			}
		}

		#region 字段名的定义
		public const string CNID = "ID";
		public const string CNORDERNO = "ORDERNO";
		public const string CNITEMNAME = "ITEMNAME";
		public const string CNSCOREVALUE = "SCOREVALUE";
		public const string CNSQLTEXT = "SQLTEXT";
		#endregion

	}
}
