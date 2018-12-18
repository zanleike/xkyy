using System;
using Framework.Entitys;

namespace HursingManage.DBModel
{
	public partial class T_ZHIKONG_KESHI_NEIRONG : EntityBase
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

		private System.Decimal _BIAOZHUNSHU;
		/// <summary>
		/// BIAOZHUNSHU
		/// </summary>
		[EntityAttribute(ColumnName = CNBIAOZHUNSHU)]
		public System.Decimal BIAOZHUNSHU
		{
			get { return _BIAOZHUNSHU; }
			set
			{
				_BIAOZHUNSHU = value;
				base.SetFieldChanged(CNBIAOZHUNSHU) ;
			}
		}

		private System.Decimal _WENTISHU;
		/// <summary>
		/// WENTISHU
		/// </summary>
		[EntityAttribute(ColumnName = CNWENTISHU)]
		public System.Decimal WENTISHU
		{
			get { return _WENTISHU; }
			set
			{
				_WENTISHU = value;
				base.SetFieldChanged(CNWENTISHU) ;
			}
		}

		private System.Decimal _HEGELV;
		/// <summary>
		/// HEGELV
		/// </summary>
		[EntityAttribute(ColumnName = CNHEGELV)]
		public System.Decimal HEGELV
		{
			get { return _HEGELV; }
			set
			{
				_HEGELV = value;
				base.SetFieldChanged(CNHEGELV) ;
			}
		}

		private System.String _SHIFOUQUEREN;
		/// <summary>
		/// SHIFOUQUEREN
		/// </summary>
		[EntityAttribute(ColumnName = CNSHIFOUQUEREN, IsNotNull = true)]
		public System.String SHIFOUQUEREN
		{
			get { return _SHIFOUQUEREN; }
			set
			{
				_SHIFOUQUEREN = value;
				base.SetFieldChanged(CNSHIFOUQUEREN) ;
			}
		}

		private System.String _QUERENREN;
		/// <summary>
		/// QUERENREN
		/// </summary>
		[EntityAttribute(ColumnName = CNQUERENREN)]
		public System.String QUERENREN
		{
			get { return _QUERENREN; }
			set
			{
				_QUERENREN = value;
				base.SetFieldChanged(CNQUERENREN) ;
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
		public const string CNBIAOZHUNLEIBIEID = "BIAOZHUNLEIBIEID";
		public const string CNBIAOZHUNLEIBIE = "BIAOZHUNLEIBIE";
		public const string CNBIAOZHUNSHU = "BIAOZHUNSHU";
		public const string CNWENTISHU = "WENTISHU";
		public const string CNHEGELV = "HEGELV";
		public const string CNSHIFOUQUEREN = "SHIFOUQUEREN";
		public const string CNQUERENREN = "QUERENREN";
		public const string CNBEIZHU = "BEIZHU";
		#endregion

	}
}
