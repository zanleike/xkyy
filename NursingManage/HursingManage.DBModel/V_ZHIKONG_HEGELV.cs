using System;
using Framework.Entitys;

namespace HursingManage.DBModel
{
	public partial class V_ZHIKONG_HEGELV : EntityBase
	{
		private System.String _JIHUAID;
		/// <summary>
		/// JIHUAID
		/// </summary>
		[EntityAttribute(ColumnName = CNJIHUAID, IsPrimaryKey = true)]
		public System.String JIHUAID
		{
			get { return _JIHUAID; }
			set
			{
				_JIHUAID = value;
				base.SetFieldChanged(CNJIHUAID) ;
			}
		}

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

		private System.String _JIANCHAKAISHISHIJIAN;
		/// <summary>
		/// JIANCHAKAISHISHIJIAN
		/// </summary>
		[EntityAttribute(ColumnName = CNJIANCHAKAISHISHIJIAN)]
		public System.String JIANCHAKAISHISHIJIAN
		{
			get { return _JIANCHAKAISHISHIJIAN; }
			set
			{
				_JIANCHAKAISHISHIJIAN = value;
				base.SetFieldChanged(CNJIANCHAKAISHISHIJIAN) ;
			}
		}

		#region 字段名的定义
		public const string CNJIHUAID = "JIHUAID";
		public const string CNJIHUA = "JIHUA";
		public const string CNKESHIID = "KESHIID";
		public const string CNKESHI = "KESHI";
		public const string CNBIAOZHUNLEIBIEID = "BIAOZHUNLEIBIEID";
		public const string CNBIAOZHUNLEIBIE = "BIAOZHUNLEIBIE";
		public const string CNBIAOZHUNSHU = "BIAOZHUNSHU";
		public const string CNWENTISHU = "WENTISHU";
		public const string CNHEGELV = "HEGELV";
		public const string CNJIANCHAKAISHISHIJIAN = "JIANCHAKAISHISHIJIAN";
		#endregion

	}
}
