using System;
using Framework.Entitys;

namespace HursingManage.DBModel
{
	public partial class T_ZHIKONG_KESHI_WENTI : EntityBase
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

		private System.String _MAINID;
		/// <summary>
		/// MAINID
		/// </summary>
		[EntityAttribute(ColumnName = CNMAINID)]
		public System.String MAINID
		{
			get { return _MAINID; }
			set
			{
				_MAINID = value;
				base.SetFieldChanged(CNMAINID) ;
			}
		}

		private System.String _KESHIID;
		/// <summary>
		/// KESHIID
		/// </summary>
		[EntityAttribute(ColumnName = CNKESHIID)]
		public System.String KESHIID
		{
			get { return _KESHIID; }
			set
			{
				_KESHIID = value;
				base.SetFieldChanged(CNKESHIID) ;
			}
		}

		private System.String _BIAOZHUNLEIBIEID;
		/// <summary>
		/// BIAOZHUNLEIBIEID
		/// </summary>
		[EntityAttribute(ColumnName = CNBIAOZHUNLEIBIEID)]
		public System.String BIAOZHUNLEIBIEID
		{
			get { return _BIAOZHUNLEIBIEID; }
			set
			{
				_BIAOZHUNLEIBIEID = value;
				base.SetFieldChanged(CNBIAOZHUNLEIBIEID) ;
			}
		}

		private System.String _BIAOZHUNLEIBIE;
		/// <summary>
		/// BIAOZHUNLEIBIE
		/// </summary>
		[EntityAttribute(ColumnName = CNBIAOZHUNLEIBIE)]
		public System.String BIAOZHUNLEIBIE
		{
			get { return _BIAOZHUNLEIBIE; }
			set
			{
				_BIAOZHUNLEIBIE = value;
				base.SetFieldChanged(CNBIAOZHUNLEIBIE) ;
			}
		}

		private System.String _LEIXING1;
		/// <summary>
		/// LEIXING1
		/// </summary>
		[EntityAttribute(ColumnName = CNLEIXING1)]
		public System.String LEIXING1
		{
			get { return _LEIXING1; }
			set
			{
				_LEIXING1 = value;
				base.SetFieldChanged(CNLEIXING1) ;
			}
		}

		private System.String _LEIXING2;
		/// <summary>
		/// LEIXING2
		/// </summary>
		[EntityAttribute(ColumnName = CNLEIXING2)]
		public System.String LEIXING2
		{
			get { return _LEIXING2; }
			set
			{
				_LEIXING2 = value;
				base.SetFieldChanged(CNLEIXING2) ;
			}
		}

		private System.String _BIAOZHUNID;
		/// <summary>
		/// BIAOZHUNID
		/// </summary>
		[EntityAttribute(ColumnName = CNBIAOZHUNID)]
		public System.String BIAOZHUNID
		{
			get { return _BIAOZHUNID; }
			set
			{
				_BIAOZHUNID = value;
				base.SetFieldChanged(CNBIAOZHUNID) ;
			}
		}

		private System.String _BIAOZHUN;
		/// <summary>
		/// BIAOZHUN
		/// </summary>
		[EntityAttribute(ColumnName = CNBIAOZHUN)]
		public System.String BIAOZHUN
		{
			get { return _BIAOZHUN; }
			set
			{
				_BIAOZHUN = value;
				base.SetFieldChanged(CNBIAOZHUN) ;
			}
		}

		private System.String _WENTISHUOMING;
		/// <summary>
		/// WENTISHUOMING
		/// </summary>
		[EntityAttribute(ColumnName = CNWENTISHUOMING)]
		public System.String WENTISHUOMING
		{
			get { return _WENTISHUOMING; }
			set
			{
				_WENTISHUOMING = value;
				base.SetFieldChanged(CNWENTISHUOMING) ;
			}
		}

		private System.String _BEIZHU;
		/// <summary>
		/// BEIZHU
		/// </summary>
		[EntityAttribute(ColumnName = CNBEIZHU)]
		public System.String BEIZHU
		{
			get { return _BEIZHU; }
			set
			{
				_BEIZHU = value;
				base.SetFieldChanged(CNBEIZHU) ;
			}
		}

		#region 字段名的定义
		public const string CNID = "ID";
		public const string CNADDTIME = "ADDTIME";
		public const string CNLASTTIME = "LASTTIME";
		public const string CNOPERATORID = "OPERATORID";
		public const string CNPC = "PC";
		public const string CNMAINID = "MAINID";
		public const string CNKESHIID = "KESHIID";
		public const string CNBIAOZHUNLEIBIEID = "BIAOZHUNLEIBIEID";
		public const string CNBIAOZHUNLEIBIE = "BIAOZHUNLEIBIE";
		public const string CNLEIXING1 = "LEIXING1";
		public const string CNLEIXING2 = "LEIXING2";
		public const string CNBIAOZHUNID = "BIAOZHUNID";
		public const string CNBIAOZHUN = "BIAOZHUN";
		public const string CNWENTISHUOMING = "WENTISHUOMING";
		public const string CNBEIZHU = "BEIZHU";
		#endregion

	}
}
