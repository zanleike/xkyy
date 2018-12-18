using System;
using Framework.Entitys;

namespace HursingManage.DBModel
{
	public partial class V_ZHIKONGJIHUA_NEIRONG : EntityBase
	{
		private System.String _JIHUA;
		/// <summary>
		/// JIHUA
		/// </summary>
		[EntityAttribute(ColumnName = CNJIHUA)]
		public System.String JIHUA
		{
			get { return _JIHUA; }
			set
			{
				_JIHUA = value;
				base.SetFieldChanged(CNJIHUA) ;
			}
		}

		private System.String _KESHI;
		/// <summary>
		/// KESHI
		/// </summary>
		[EntityAttribute(ColumnName = CNKESHI)]
		public System.String KESHI
		{
			get { return _KESHI; }
			set
			{
				_KESHI = value;
				base.SetFieldChanged(CNKESHI) ;
			}
		}

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

		private System.String _JIHUAID;
		/// <summary>
		/// JIHUAID
		/// </summary>
		[EntityAttribute(ColumnName = CNJIHUAID)]
		public System.String JIHUAID
		{
			get { return _JIHUAID; }
			set
			{
				_JIHUAID = value;
				base.SetFieldChanged(CNJIHUAID) ;
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

		private System.String _JIANCHARENID;
		/// <summary>
		/// JIANCHARENID
		/// </summary>
		[EntityAttribute(ColumnName = CNJIANCHARENID)]
		public System.String JIANCHARENID
		{
			get { return _JIANCHARENID; }
			set
			{
				_JIANCHARENID = value;
				base.SetFieldChanged(CNJIANCHARENID) ;
			}
		}

		private System.String _JIANCHAREN;
		/// <summary>
		/// JIANCHAREN
		/// </summary>
		[EntityAttribute(ColumnName = CNJIANCHAREN)]
		public System.String JIANCHAREN
		{
			get { return _JIANCHAREN; }
			set
			{
				_JIANCHAREN = value;
				base.SetFieldChanged(CNJIANCHAREN) ;
			}
		}

		private System.String _SHIFOUJIANCHA;
		/// <summary>
		/// SHIFOUJIANCHA
		/// </summary>
		[EntityAttribute(ColumnName = CNSHIFOUJIANCHA)]
		public System.String SHIFOUJIANCHA
		{
			get { return _SHIFOUJIANCHA; }
			set
			{
				_SHIFOUJIANCHA = value;
				base.SetFieldChanged(CNSHIFOUJIANCHA) ;
			}
		}

		private System.DateTime _JIANCHASHIJIAN;
		/// <summary>
		/// JIANCHASHIJIAN
		/// </summary>
		[EntityAttribute(ColumnName = CNJIANCHASHIJIAN)]
		public System.DateTime JIANCHASHIJIAN
		{
			get { return _JIANCHASHIJIAN; }
			set
			{
				_JIANCHASHIJIAN = value;
				base.SetFieldChanged(CNJIANCHASHIJIAN) ;
			}
		}

		#region 字段名的定义
		public const string CNJIHUA = "JIHUA";
		public const string CNKESHI = "KESHI";
		public const string CNID = "ID";
		public const string CNJIHUAID = "JIHUAID";
		public const string CNBIAOZHUNLEIBIEID = "BIAOZHUNLEIBIEID";
		public const string CNBIAOZHUNLEIBIE = "BIAOZHUNLEIBIE";
		public const string CNBIAOZHUNSHU = "BIAOZHUNSHU";
		public const string CNADDTIME = "ADDTIME";
		public const string CNLASTTIME = "LASTTIME";
		public const string CNOPERATORID = "OPERATORID";
		public const string CNPC = "PC";
		public const string CNKESHIID = "KESHIID";
		public const string CNWENTISHU = "WENTISHU";
		public const string CNHEGELV = "HEGELV";
		public const string CNJIANCHARENID = "JIANCHARENID";
		public const string CNJIANCHAREN = "JIANCHAREN";
		public const string CNSHIFOUJIANCHA = "SHIFOUJIANCHA";
		public const string CNJIANCHASHIJIAN = "JIANCHASHIJIAN";
		#endregion

	}
}
