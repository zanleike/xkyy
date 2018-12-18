using System;
using Framework.Entitys;

namespace HursingManage.DBModel
{
	public partial class T_JINENGBIAOZHUN : EntityBase
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

		private System.String _LEIBIEID;
		/// <summary>
		/// LEIBIEID
		/// </summary>
		[EntityAttribute(ColumnName = CNLEIBIEID)]
		public System.String LEIBIEID
		{
			get { return _LEIBIEID; }
			set
			{
				_LEIBIEID = value;
				base.SetFieldChanged(CNLEIBIEID) ;
			}
		}

		private System.String _LEIBIE;
		/// <summary>
		/// LEIBIE
		/// </summary>
		[EntityAttribute(ColumnName = CNLEIBIE)]
		public System.String LEIBIE
		{
			get { return _LEIBIE; }
			set
			{
				_LEIBIE = value;
				base.SetFieldChanged(CNLEIBIE) ;
			}
		}

		private System.Decimal _XUHAO;
		/// <summary>
		/// XUHAO
		/// </summary>
		[EntityAttribute(ColumnName = CNXUHAO)]
		public System.Decimal XUHAO
		{
			get { return _XUHAO; }
			set
			{
				_XUHAO = value;
				base.SetFieldChanged(CNXUHAO) ;
			}
		}

		private System.String _XIANGMU;
		/// <summary>
		/// XIANGMU
		/// </summary>
		[EntityAttribute(ColumnName = CNXIANGMU)]
		public System.String XIANGMU
		{
			get { return _XIANGMU; }
			set
			{
				_XIANGMU = value;
				base.SetFieldChanged(CNXIANGMU) ;
			}
		}

		private System.String _CAOZUOYAODIAN;
		/// <summary>
		/// CAOZUOYAODIAN
		/// </summary>
		[EntityAttribute(ColumnName = CNCAOZUOYAODIAN)]
		public System.String CAOZUOYAODIAN
		{
			get { return _CAOZUOYAODIAN; }
			set
			{
				_CAOZUOYAODIAN = value;
				base.SetFieldChanged(CNCAOZUOYAODIAN) ;
			}
		}

		private System.String _PINGJIAYAODIAN;
		/// <summary>
		/// PINGJIAYAODIAN
		/// </summary>
		[EntityAttribute(ColumnName = CNPINGJIAYAODIAN)]
		public System.String PINGJIAYAODIAN
		{
			get { return _PINGJIAYAODIAN; }
			set
			{
				_PINGJIAYAODIAN = value;
				base.SetFieldChanged(CNPINGJIAYAODIAN) ;
			}
		}

		private System.Decimal _FENZHI;
		/// <summary>
		/// FENZHI
		/// </summary>
		[EntityAttribute(ColumnName = CNFENZHI)]
		public System.Decimal FENZHI
		{
			get { return _FENZHI; }
			set
			{
				_FENZHI = value;
				base.SetFieldChanged(CNFENZHI) ;
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
		public const string CNLEIBIEID = "LEIBIEID";
		public const string CNLEIBIE = "LEIBIE";
		public const string CNXUHAO = "XUHAO";
		public const string CNXIANGMU = "XIANGMU";
		public const string CNCAOZUOYAODIAN = "CAOZUOYAODIAN";
		public const string CNPINGJIAYAODIAN = "PINGJIAYAODIAN";
		public const string CNFENZHI = "FENZHI";
		public const string CNADDTIME = "ADDTIME";
		public const string CNLASTTIME = "LASTTIME";
		public const string CNOPERATORID = "OPERATORID";
		public const string CNPC = "PC";
		#endregion

	}
}
