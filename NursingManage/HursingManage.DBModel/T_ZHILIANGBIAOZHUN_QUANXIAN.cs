using System;
using Framework.Entitys;

namespace HursingManage.DBModel
{
	public partial class T_ZHILIANGBIAOZHUN_QUANXIAN : EntityBase
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

		private System.String _RENYUANID;
		/// <summary>
		/// RENYUANID
		/// </summary>
		[EntityAttribute(ColumnName = CNRENYUANID)]
		public System.String RENYUANID
		{
			get { return _RENYUANID; }
			set
			{
				_RENYUANID = value;
				base.SetFieldChanged(CNRENYUANID) ;
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

		private System.String _BIANHAO;
		/// <summary>
		/// BIANHAO
		/// </summary>
		[EntityAttribute(ColumnName = CNBIANHAO)]
		public System.String BIANHAO
		{
			get { return _BIANHAO; }
			set
			{
				_BIANHAO = value;
				base.SetFieldChanged(CNBIANHAO) ;
			}
		}

		private System.String _MINGCHENG;
		/// <summary>
		/// MINGCHENG
		/// </summary>
		[EntityAttribute(ColumnName = CNMINGCHENG)]
		public System.String MINGCHENG
		{
			get { return _MINGCHENG; }
			set
			{
				_MINGCHENG = value;
				base.SetFieldChanged(CNMINGCHENG) ;
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
		public const string CNRENYUANID = "RENYUANID";
		public const string CNLEIBIEID = "LEIBIEID";
		public const string CNLEIBIE = "LEIBIE";
		public const string CNBIANHAO = "BIANHAO";
		public const string CNMINGCHENG = "MINGCHENG";
		public const string CNADDTIME = "ADDTIME";
		public const string CNLASTTIME = "LASTTIME";
		public const string CNOPERATORID = "OPERATORID";
		public const string CNPC = "PC";
		#endregion

	}
}
