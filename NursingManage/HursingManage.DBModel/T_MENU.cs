using System;
using Framework.Entitys;

namespace HursingManage.DBModel
{
	public partial class T_MENU : EntityBase
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

		private System.String _MENUNAME;
		/// <summary>
		/// MENUNAME
		/// </summary>
		[EntityAttribute(ColumnName = CNMENUNAME)]
		public System.String MENUNAME
		{
			get { return _MENUNAME; }
			set
			{
				_MENUNAME = value;
				base.SetFieldChanged(CNMENUNAME) ;
			}
		}

		private System.String _MENUCAPTION;
		/// <summary>
		/// MENUCAPTION
		/// </summary>
		[EntityAttribute(ColumnName = CNMENUCAPTION)]
		public System.String MENUCAPTION
		{
			get { return _MENUCAPTION; }
			set
			{
				_MENUCAPTION = value;
				base.SetFieldChanged(CNMENUCAPTION) ;
			}
		}

		private System.String _PID;
		/// <summary>
		/// PID
		/// </summary>
		[EntityAttribute(ColumnName = CNPID)]
		public System.String PID
		{
			get { return _PID; }
			set
			{
				_PID = value;
				base.SetFieldChanged(CNPID) ;
			}
		}

		private System.String _BUTTONNAME;
		/// <summary>
		/// BUTTONNAME
		/// </summary>
		[EntityAttribute(ColumnName = CNBUTTONNAME)]
		public System.String BUTTONNAME
		{
			get { return _BUTTONNAME; }
			set
			{
				_BUTTONNAME = value;
				base.SetFieldChanged(CNBUTTONNAME) ;
			}
		}

		#region 字段名的定义
		public const string CNID = "ID";
		public const string CNMENUNAME = "MENUNAME";
		public const string CNMENUCAPTION = "MENUCAPTION";
		public const string CNPID = "PID";
		public const string CNBUTTONNAME = "BUTTONNAME";
		#endregion

	}
}
