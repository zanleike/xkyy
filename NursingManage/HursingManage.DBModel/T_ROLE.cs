using System;
using Framework.Entitys;

namespace HursingManage.DBModel
{
	public partial class T_ROLE : EntityBase
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

		private System.String _ROLE_NAME;
		/// <summary>
		/// ROLE_NAME
		/// </summary>
		[EntityAttribute(ColumnName = CNROLE_NAME, IsNotNull = true)]
		public System.String ROLE_NAME
		{
			get { return _ROLE_NAME; }
			set
			{
				_ROLE_NAME = value;
				base.SetFieldChanged(CNROLE_NAME) ;
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

		private System.String _PC;
		/// <summary>
		/// PC
		/// </summary>
		[EntityAttribute(ColumnName = CNPC)]
		public System.String PC
		{
			get { return _PC; }
			set
			{
				_PC = value;
				base.SetFieldChanged(CNPC) ;
			}
		}

		private System.String _ROLE_NAME_PY;
		/// <summary>
		/// ROLE_NAME_PY
		/// </summary>
		[EntityAttribute(ColumnName = CNROLE_NAME_PY)]
		public System.String ROLE_NAME_PY
		{
			get { return _ROLE_NAME_PY; }
			set
			{
				_ROLE_NAME_PY = value;
				base.SetFieldChanged(CNROLE_NAME_PY) ;
			}
		}

		#region 字段名的定义
		public const string CNID = "ID";
		public const string CNROLE_NAME = "ROLE_NAME";
		public const string CNREMARK = "REMARK";
		public const string CNADDTIME = "ADDTIME";
		public const string CNLASTTIME = "LASTTIME";
		public const string CNOPERATORID = "OPERATORID";
		public const string CNPC = "PC";
		public const string CNROLE_NAME_PY = "ROLE_NAME_PY";
		#endregion

	}
}
