using System;
using Framework.Entitys;

namespace HursingManage.DBModel
{
	public partial class T_DANGAN_TABLE_CONFIG : EntityBase
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

		private System.String _GROUPNAME;
		/// <summary>
		/// GROUPNAME
		/// </summary>
		[EntityAttribute(ColumnName = CNGROUPNAME)]
		public System.String GROUPNAME
		{
			get { return _GROUPNAME; }
			set
			{
				_GROUPNAME = value;
				base.SetFieldChanged(CNGROUPNAME) ;
			}
		}

		private System.String _GROUPCAPTION;
		/// <summary>
		/// GROUPCAPTION
		/// </summary>
		[EntityAttribute(ColumnName = CNGROUPCAPTION)]
		public System.String GROUPCAPTION
		{
			get { return _GROUPCAPTION; }
			set
			{
				_GROUPCAPTION = value;
				base.SetFieldChanged(CNGROUPCAPTION) ;
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

		private System.String _FIELDCAPTION;
		/// <summary>
		/// FIELDCAPTION
		/// </summary>
		[EntityAttribute(ColumnName = CNFIELDCAPTION)]
		public System.String FIELDCAPTION
		{
			get { return _FIELDCAPTION; }
			set
			{
				_FIELDCAPTION = value;
				base.SetFieldChanged(CNFIELDCAPTION) ;
			}
		}

		private System.Decimal _CONTROLHEIGHT;
		/// <summary>
		/// CONTROLHEIGHT
		/// </summary>
		[EntityAttribute(ColumnName = CNCONTROLHEIGHT)]
		public System.Decimal CONTROLHEIGHT
		{
			get { return _CONTROLHEIGHT; }
			set
			{
				_CONTROLHEIGHT = value;
				base.SetFieldChanged(CNCONTROLHEIGHT) ;
			}
		}

		private System.Decimal _CONTROLWIDHT;
		/// <summary>
		/// CONTROLWIDHT
		/// </summary>
		[EntityAttribute(ColumnName = CNCONTROLWIDHT)]
		public System.Decimal CONTROLWIDHT
		{
			get { return _CONTROLWIDHT; }
			set
			{
				_CONTROLWIDHT = value;
				base.SetFieldChanged(CNCONTROLWIDHT) ;
			}
		}

		private System.Decimal _CAPTIONCONTROLLEN;
		/// <summary>
		/// CAPTIONCONTROLLEN
		/// </summary>
		[EntityAttribute(ColumnName = CNCAPTIONCONTROLLEN)]
		public System.Decimal CAPTIONCONTROLLEN
		{
			get { return _CAPTIONCONTROLLEN; }
			set
			{
				_CAPTIONCONTROLLEN = value;
				base.SetFieldChanged(CNCAPTIONCONTROLLEN) ;
			}
		}

		private System.Decimal _CONTROLTYPE;
		/// <summary>
		/// CONTROLTYPE
		/// </summary>
		[EntityAttribute(ColumnName = CNCONTROLTYPE)]
		public System.Decimal CONTROLTYPE
		{
			get { return _CONTROLTYPE; }
			set
			{
				_CONTROLTYPE = value;
				base.SetFieldChanged(CNCONTROLTYPE) ;
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

		private System.String _DATASOURCE;
		/// <summary>
		/// DATASOURCE
		/// </summary>
		[EntityAttribute(ColumnName = CNDATASOURCE)]
		public System.String DATASOURCE
		{
			get { return _DATASOURCE; }
			set
			{
				_DATASOURCE = value;
				base.SetFieldChanged(CNDATASOURCE) ;
			}
		}

		private System.Decimal _ISREQUIRED;
		/// <summary>
		/// ISREQUIRED
		/// </summary>
		[EntityAttribute(ColumnName = CNISREQUIRED)]
		public System.Decimal ISREQUIRED
		{
			get { return _ISREQUIRED; }
			set
			{
				_ISREQUIRED = value;
				base.SetFieldChanged(CNISREQUIRED) ;
			}
		}

		#region 字段名的定义
		public const string CNID = "ID";
		public const string CNGROUPNAME = "GROUPNAME";
		public const string CNGROUPCAPTION = "GROUPCAPTION";
		public const string CNFIELDNAME = "FIELDNAME";
		public const string CNFIELDCAPTION = "FIELDCAPTION";
		public const string CNCONTROLHEIGHT = "CONTROLHEIGHT";
		public const string CNCONTROLWIDHT = "CONTROLWIDHT";
		public const string CNCAPTIONCONTROLLEN = "CAPTIONCONTROLLEN";
		public const string CNCONTROLTYPE = "CONTROLTYPE";
		public const string CNORDERNO = "ORDERNO";
		public const string CNDATASOURCE = "DATASOURCE";
		public const string CNISREQUIRED = "ISREQUIRED";
		#endregion

	}
}
