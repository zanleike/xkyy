using System;
using Framework.Entitys;

namespace HursingManage.DBModel
{
	public partial class V_PEIXUNJIHUA_KESHI : EntityBase
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

		private System.String _NEIRONG;
		/// <summary>
		/// NEIRONG
		/// </summary>
		[EntityAttribute(ColumnName = CNNEIRONG)]
		public System.String NEIRONG
		{
			get { return _NEIRONG; }
			set
			{
				_NEIRONG = value;
				base.SetFieldChanged(CNNEIRONG) ;
			}
		}

		private System.String _NEIRONGSHUOMING;
		/// <summary>
		/// NEIRONGSHUOMING
		/// </summary>
		[EntityAttribute(ColumnName = CNNEIRONGSHUOMING)]
		public System.String NEIRONGSHUOMING
		{
			get { return _NEIRONGSHUOMING; }
			set
			{
				_NEIRONGSHUOMING = value;
				base.SetFieldChanged(CNNEIRONGSHUOMING) ;
			}
		}

		private System.String _PEIXUNKAISHI;
		/// <summary>
		/// PEIXUNKAISHI
		/// </summary>
		[EntityAttribute(ColumnName = CNPEIXUNKAISHI)]
		public System.String PEIXUNKAISHI
		{
			get { return _PEIXUNKAISHI; }
			set
			{
				_PEIXUNKAISHI = value;
				base.SetFieldChanged(CNPEIXUNKAISHI) ;
			}
		}

		private System.String _PEIXUNJIESHU;
		/// <summary>
		/// PEIXUNJIESHU
		/// </summary>
		[EntityAttribute(ColumnName = CNPEIXUNJIESHU)]
		public System.String PEIXUNJIESHU
		{
			get { return _PEIXUNJIESHU; }
			set
			{
				_PEIXUNJIESHU = value;
				base.SetFieldChanged(CNPEIXUNJIESHU) ;
			}
		}

		private System.String _PEIXUNRIQI;
		/// <summary>
		/// PEIXUNRIQI
		/// </summary>
		[EntityAttribute(ColumnName = CNPEIXUNRIQI)]
		public System.String PEIXUNRIQI
		{
			get { return _PEIXUNRIQI; }
			set
			{
				_PEIXUNRIQI = value;
				base.SetFieldChanged(CNPEIXUNRIQI) ;
			}
		}

		private System.String _KAOSHIRIQI;
		/// <summary>
		/// KAOSHIRIQI
		/// </summary>
		[EntityAttribute(ColumnName = CNKAOSHIRIQI)]
		public System.String KAOSHIRIQI
		{
			get { return _KAOSHIRIQI; }
			set
			{
				_KAOSHIRIQI = value;
				base.SetFieldChanged(CNKAOSHIRIQI) ;
			}
		}

		private System.String _KAOHEKAISHI;
		/// <summary>
		/// KAOHEKAISHI
		/// </summary>
		[EntityAttribute(ColumnName = CNKAOHEKAISHI)]
		public System.String KAOHEKAISHI
		{
			get { return _KAOHEKAISHI; }
			set
			{
				_KAOHEKAISHI = value;
				base.SetFieldChanged(CNKAOHEKAISHI) ;
			}
		}

		private System.String _KAOHEJIESHU;
		/// <summary>
		/// KAOHEJIESHU
		/// </summary>
		[EntityAttribute(ColumnName = CNKAOHEJIESHU)]
		public System.String KAOHEJIESHU
		{
			get { return _KAOHEJIESHU; }
			set
			{
				_KAOHEJIESHU = value;
				base.SetFieldChanged(CNKAOHEJIESHU) ;
			}
		}

		private System.String _CANJIARENYUAN;
		/// <summary>
		/// CANJIARENYUAN
		/// </summary>
		[EntityAttribute(ColumnName = CNCANJIARENYUAN)]
		public System.String CANJIARENYUAN
		{
			get { return _CANJIARENYUAN; }
			set
			{
				_CANJIARENYUAN = value;
				base.SetFieldChanged(CNCANJIARENYUAN) ;
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

		private System.Decimal _YINGKAORENSHU;
		/// <summary>
		/// YINGKAORENSHU
		/// </summary>
		[EntityAttribute(ColumnName = CNYINGKAORENSHU)]
		public System.Decimal YINGKAORENSHU
		{
			get { return _YINGKAORENSHU; }
			set
			{
				_YINGKAORENSHU = value;
				base.SetFieldChanged(CNYINGKAORENSHU) ;
			}
		}

		private System.Decimal _SHIKAORENSHU;
		/// <summary>
		/// SHIKAORENSHU
		/// </summary>
		[EntityAttribute(ColumnName = CNSHIKAORENSHU)]
		public System.Decimal SHIKAORENSHU
		{
			get { return _SHIKAORENSHU; }
			set
			{
				_SHIKAORENSHU = value;
				base.SetFieldChanged(CNSHIKAORENSHU) ;
			}
		}

		private System.Decimal _WEIKAORENSHU;
		/// <summary>
		/// WEIKAORENSHU
		/// </summary>
		[EntityAttribute(ColumnName = CNWEIKAORENSHU)]
		public System.Decimal WEIKAORENSHU
		{
			get { return _WEIKAORENSHU; }
			set
			{
				_WEIKAORENSHU = value;
				base.SetFieldChanged(CNWEIKAORENSHU) ;
			}
		}

		#region 字段名的定义
		public const string CNID = "ID";
		public const string CNKESHIID = "KESHIID";
		public const string CNJIHUAID = "JIHUAID";
		public const string CNKESHI = "KESHI";
		public const string CNSHIFOUQUEREN = "SHIFOUQUEREN";
		public const string CNQUERENREN = "QUERENREN";
		public const string CNQUERENSHIJIAN = "QUERENSHIJIAN";
		public const string CNNEIRONG = "NEIRONG";
		public const string CNNEIRONGSHUOMING = "NEIRONGSHUOMING";
		public const string CNPEIXUNKAISHI = "PEIXUNKAISHI";
		public const string CNPEIXUNJIESHU = "PEIXUNJIESHU";
		public const string CNPEIXUNRIQI = "PEIXUNRIQI";
		public const string CNKAOSHIRIQI = "KAOSHIRIQI";
		public const string CNKAOHEKAISHI = "KAOHEKAISHI";
		public const string CNKAOHEJIESHU = "KAOHEJIESHU";
		public const string CNCANJIARENYUAN = "CANJIARENYUAN";
		public const string CNADDTIME = "ADDTIME";
		public const string CNLASTTIME = "LASTTIME";
		public const string CNOPERATORID = "OPERATORID";
		public const string CNYINGKAORENSHU = "YINGKAORENSHU";
		public const string CNSHIKAORENSHU = "SHIKAORENSHU";
		public const string CNWEIKAORENSHU = "WEIKAORENSHU";
		#endregion

	}
}
