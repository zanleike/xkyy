using System;
using Framework.Entitys;

namespace HursingManage.DBModel
{
	public partial class T_SHITI_MUBAN_MINGXI : EntityBase
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

		private System.String _MUBANID;
		/// <summary>
		/// MUBANID
		/// </summary>
		[EntityAttribute(ColumnName = CNMUBANID)]
		public System.String MUBANID
		{
			get { return _MUBANID; }
			set
			{
				_MUBANID = value;
				base.SetFieldChanged(CNMUBANID) ;
			}
		}

		private System.String _SHITILEIBIEID;
		/// <summary>
		/// SHITILEIBIEID
		/// </summary>
		[EntityAttribute(ColumnName = CNSHITILEIBIEID)]
		public System.String SHITILEIBIEID
		{
			get { return _SHITILEIBIEID; }
			set
			{
				_SHITILEIBIEID = value;
				base.SetFieldChanged(CNSHITILEIBIEID) ;
			}
		}

		private System.String _SHITIID;
		/// <summary>
		/// SHITIID
		/// </summary>
		[EntityAttribute(ColumnName = CNSHITIID)]
		public System.String SHITIID
		{
			get { return _SHITIID; }
			set
			{
				_SHITIID = value;
				base.SetFieldChanged(CNSHITIID) ;
			}
		}

		private System.Decimal _SHITIXUHAO;
		/// <summary>
		/// SHITIXUHAO
		/// </summary>
		[EntityAttribute(ColumnName = CNSHITIXUHAO)]
		public System.Decimal SHITIXUHAO
		{
			get { return _SHITIXUHAO; }
			set
			{
				_SHITIXUHAO = value;
				base.SetFieldChanged(CNSHITIXUHAO) ;
			}
		}

		private System.Decimal _FENSHU;
		/// <summary>
		/// FENSHU
		/// </summary>
		[EntityAttribute(ColumnName = CNFENSHU)]
		public System.Decimal FENSHU
		{
			get { return _FENSHU; }
			set
			{
				_FENSHU = value;
				base.SetFieldChanged(CNFENSHU) ;
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

		#region 字段名的定义
		public const string CNID = "ID";
		public const string CNMUBANID = "MUBANID";
		public const string CNSHITILEIBIEID = "SHITILEIBIEID";
		public const string CNSHITIID = "SHITIID";
		public const string CNSHITIXUHAO = "SHITIXUHAO";
		public const string CNFENSHU = "FENSHU";
		public const string CNADDTIME = "ADDTIME";
		public const string CNLASTTIME = "LASTTIME";
		public const string CNOPERATORID = "OPERATORID";
		public const string CNPC = "PC";
		#endregion

	}
}
