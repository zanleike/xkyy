using System;
using Framework.Entitys;

namespace HursingManage.DBModel
{
	public partial class T_ROLE_MENU : EntityBase
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

		private System.String _ROLE_ID;
		/// <summary>
		/// ROLE_ID
		/// </summary>
		[EntityAttribute(ColumnName = CNROLE_ID)]
		public System.String ROLE_ID
		{
			get { return _ROLE_ID; }
			set
			{
				_ROLE_ID = value;
				base.SetFieldChanged(CNROLE_ID) ;
			}
		}

		private System.String _MENUNAME;
		/// <summary>
		/// MENUNAME
		/// </summary>
		[EntityAttribute(ColumnName = CNMENUNAME, IsNotNull = true)]
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

		private System.String _MENUID;
		/// <summary>
		/// MENUID
		/// </summary>
		[EntityAttribute(ColumnName = CNMENUID)]
		public System.String MENUID
		{
			get { return _MENUID; }
			set
			{
				_MENUID = value;
				base.SetFieldChanged(CNMENUID) ;
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
		public const string CNROLE_ID = "ROLE_ID";
		public const string CNMENUNAME = "MENUNAME";
		public const string CNMENUCAPTION = "MENUCAPTION";
		public const string CNMENUID = "MENUID";
		public const string CNBUTTONNAME = "BUTTONNAME";
		#endregion

	}
}
