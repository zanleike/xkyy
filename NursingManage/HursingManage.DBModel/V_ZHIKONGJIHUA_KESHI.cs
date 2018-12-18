using System;
using Framework.Entitys;

namespace HursingManage.DBModel
{
	public partial class V_ZHIKONGJIHUA_KESHI : EntityBase
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

		private System.String _JIHUAID;
		/// <summary>
		/// JIHUAID
		/// </summary>
		[EntityAttribute(ColumnName = CNJIHUAID, IsNotNull = true)]
		public System.String JIHUAID
		{
			get { return _JIHUAID; }
			set
			{
				_JIHUAID = value;
				base.SetFieldChanged(CNJIHUAID) ;
			}
		}

		private System.String _JIHUAMINGCHENG;
		/// <summary>
		/// JIHUAMINGCHENG
		/// </summary>
		[EntityAttribute(ColumnName = CNJIHUAMINGCHENG)]
		public System.String JIHUAMINGCHENG
		{
			get { return _JIHUAMINGCHENG; }
			set
			{
				_JIHUAMINGCHENG = value;
				base.SetFieldChanged(CNJIHUAMINGCHENG) ;
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

		private System.String _JIHUASHIJIAN;
		/// <summary>
		/// JIHUASHIJIAN
		/// </summary>
		[EntityAttribute(ColumnName = CNJIHUASHIJIAN)]
		public System.String JIHUASHIJIAN
		{
			get { return _JIHUASHIJIAN; }
			set
			{
				_JIHUASHIJIAN = value;
				base.SetFieldChanged(CNJIHUASHIJIAN) ;
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

		private System.String _JIANCHASHIJIAN;
		/// <summary>
		/// JIANCHASHIJIAN
		/// </summary>
		[EntityAttribute(ColumnName = CNJIANCHASHIJIAN)]
		public System.String JIANCHASHIJIAN
		{
			get { return _JIANCHASHIJIAN; }
			set
			{
				_JIANCHASHIJIAN = value;
				base.SetFieldChanged(CNJIANCHASHIJIAN) ;
			}
		}

		private System.String _JIANCHARENYUAN;
		/// <summary>
		/// JIANCHARENYUAN
		/// </summary>
		[EntityAttribute(ColumnName = CNJIANCHARENYUAN)]
		public System.String JIANCHARENYUAN
		{
			get { return _JIANCHARENYUAN; }
			set
			{
				_JIANCHARENYUAN = value;
				base.SetFieldChanged(CNJIANCHARENYUAN) ;
			}
		}

		private System.String _GAIJINSHIJIAN_XIANQI;
		/// <summary>
		/// GAIJINSHIJIAN_XIANQI
		/// </summary>
		[EntityAttribute(ColumnName = CNGAIJINSHIJIAN_XIANQI)]
		public System.String GAIJINSHIJIAN_XIANQI
		{
			get { return _GAIJINSHIJIAN_XIANQI; }
			set
			{
				_GAIJINSHIJIAN_XIANQI = value;
				base.SetFieldChanged(CNGAIJINSHIJIAN_XIANQI) ;
			}
		}

		private System.String _SHIFOUQUEREN;
		/// <summary>
		/// SHIFOUQUEREN
		/// </summary>
		[EntityAttribute(ColumnName = CNSHIFOUQUEREN)]
		public System.String SHIFOUQUEREN
		{
			get { return _SHIFOUQUEREN; }
			set
			{
				_SHIFOUQUEREN = value;
				base.SetFieldChanged(CNSHIFOUQUEREN) ;
			}
		}

		private System.DateTime _QUERENSHIJIAN;
		/// <summary>
		/// QUERENSHIJIAN
		/// </summary>
		[EntityAttribute(ColumnName = CNQUERENSHIJIAN)]
		public System.DateTime QUERENSHIJIAN
		{
			get { return _QUERENSHIJIAN; }
			set
			{
				_QUERENSHIJIAN = value;
				base.SetFieldChanged(CNQUERENSHIJIAN) ;
			}
		}

		private System.String _GAIJINSHUOMING;
		/// <summary>
		/// GAIJINSHUOMING
		/// </summary>
		[EntityAttribute(ColumnName = CNGAIJINSHUOMING)]
		public System.String GAIJINSHUOMING
		{
			get { return _GAIJINSHUOMING; }
			set
			{
				_GAIJINSHUOMING = value;
				base.SetFieldChanged(CNGAIJINSHUOMING) ;
			}
		}

		private System.String _YUANYINFENXI;
		/// <summary>
		/// YUANYINFENXI
		/// </summary>
		[EntityAttribute(ColumnName = CNYUANYINFENXI)]
		public System.String YUANYINFENXI
		{
			get { return _YUANYINFENXI; }
			set
			{
				_YUANYINFENXI = value;
				base.SetFieldChanged(CNYUANYINFENXI) ;
			}
		}

		private System.DateTime _GAIJINSHIJIAN;
		/// <summary>
		/// GAIJINSHIJIAN
		/// </summary>
		[EntityAttribute(ColumnName = CNGAIJINSHIJIAN)]
		public System.DateTime GAIJINSHIJIAN
		{
			get { return _GAIJINSHIJIAN; }
			set
			{
				_GAIJINSHIJIAN = value;
				base.SetFieldChanged(CNGAIJINSHIJIAN) ;
			}
		}

		private System.String _GAIJINSHANGBAOREN;
		/// <summary>
		/// GAIJINSHANGBAOREN
		/// </summary>
		[EntityAttribute(ColumnName = CNGAIJINSHANGBAOREN)]
		public System.String GAIJINSHANGBAOREN
		{
			get { return _GAIJINSHANGBAOREN; }
			set
			{
				_GAIJINSHANGBAOREN = value;
				base.SetFieldChanged(CNGAIJINSHANGBAOREN) ;
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

		private System.String _ZHENGGAIQINGKUANG;
		/// <summary>
		/// ZHENGGAIQINGKUANG
		/// </summary>
		[EntityAttribute(ColumnName = CNZHENGGAIQINGKUANG)]
		public System.String ZHENGGAIQINGKUANG
		{
			get { return _ZHENGGAIQINGKUANG; }
			set
			{
				_ZHENGGAIQINGKUANG = value;
				base.SetFieldChanged(CNZHENGGAIQINGKUANG) ;
			}
		}

		private System.String _MANYIDUSHUOMING;
		/// <summary>
		/// MANYIDUSHUOMING
		/// </summary>
		[EntityAttribute(ColumnName = CNMANYIDUSHUOMING)]
		public System.String MANYIDUSHUOMING
		{
			get { return _MANYIDUSHUOMING; }
			set
			{
				_MANYIDUSHUOMING = value;
				base.SetFieldChanged(CNMANYIDUSHUOMING) ;
			}
		}

		#region 字段名的定义
		public const string CNID = "ID";
		public const string CNKESHIID = "KESHIID";
		public const string CNKESHI = "KESHI";
		public const string CNLEIXING1 = "LEIXING1";
		public const string CNLEIXING2 = "LEIXING2";
		public const string CNJIHUAID = "JIHUAID";
		public const string CNJIHUAMINGCHENG = "JIHUAMINGCHENG";
		public const string CNBIAOZHUNSHU = "BIAOZHUNSHU";
		public const string CNWENTISHU = "WENTISHU";
		public const string CNHEGELV = "HEGELV";
		public const string CNJIHUASHIJIAN = "JIHUASHIJIAN";
		public const string CNSHIFOUJIANCHA = "SHIFOUJIANCHA";
		public const string CNJIANCHASHIJIAN = "JIANCHASHIJIAN";
		public const string CNJIANCHARENYUAN = "JIANCHARENYUAN";
		public const string CNGAIJINSHIJIAN_XIANQI = "GAIJINSHIJIAN_XIANQI";
		public const string CNSHIFOUQUEREN = "SHIFOUQUEREN";
		public const string CNQUERENSHIJIAN = "QUERENSHIJIAN";
		public const string CNGAIJINSHUOMING = "GAIJINSHUOMING";
		public const string CNYUANYINFENXI = "YUANYINFENXI";
		public const string CNGAIJINSHIJIAN = "GAIJINSHIJIAN";
		public const string CNGAIJINSHANGBAOREN = "GAIJINSHANGBAOREN";
		public const string CNADDTIME = "ADDTIME";
		public const string CNZHENGGAIQINGKUANG = "ZHENGGAIQINGKUANG";
		public const string CNMANYIDUSHUOMING = "MANYIDUSHUOMING";
		#endregion

	}
}
