using System;
using Framework.Entitys;

namespace HursingManage.DBModel
{
	public partial class V_PEIXUNJIHUA_MINGXI : EntityBase
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

		private System.String _MUBAN;
		/// <summary>
		/// MUBAN
		/// </summary>
		[EntityAttribute(ColumnName = CNMUBAN)]
		public System.String MUBAN
		{
			get { return _MUBAN; }
			set
			{
				_MUBAN = value;
				base.SetFieldChanged(CNMUBAN) ;
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

		private System.String _XINGMING;
		/// <summary>
		/// XINGMING
		/// </summary>
		[EntityAttribute(ColumnName = CNXINGMING)]
		public System.String XINGMING
		{
			get { return _XINGMING; }
			set
			{
				_XINGMING = value;
				base.SetFieldChanged(CNXINGMING) ;
			}
		}

		private System.String _XINGMING_PY;
		/// <summary>
		/// XINGMING_PY
		/// </summary>
		[EntityAttribute(ColumnName = CNXINGMING_PY)]
		public System.String XINGMING_PY
		{
			get { return _XINGMING_PY; }
			set
			{
				_XINGMING_PY = value;
				base.SetFieldChanged(CNXINGMING_PY) ;
			}
		}

		private System.String _NENGJI;
		/// <summary>
		/// NENGJI
		/// </summary>
		[EntityAttribute(ColumnName = CNNENGJI)]
		public System.String NENGJI
		{
			get { return _NENGJI; }
			set
			{
				_NENGJI = value;
				base.SetFieldChanged(CNNENGJI) ;
			}
		}

		private System.Decimal _SHITISHU;
		/// <summary>
		/// SHITISHU
		/// </summary>
		[EntityAttribute(ColumnName = CNSHITISHU)]
		public System.Decimal SHITISHU
		{
			get { return _SHITISHU; }
			set
			{
				_SHITISHU = value;
				base.SetFieldChanged(CNSHITISHU) ;
			}
		}

		private System.Decimal _ZHENGQUESHU;
		/// <summary>
		/// ZHENGQUESHU
		/// </summary>
		[EntityAttribute(ColumnName = CNZHENGQUESHU)]
		public System.Decimal ZHENGQUESHU
		{
			get { return _ZHENGQUESHU; }
			set
			{
				_ZHENGQUESHU = value;
				base.SetFieldChanged(CNZHENGQUESHU) ;
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

		private System.String _PINGFENREN;
		/// <summary>
		/// PINGFENREN
		/// </summary>
		[EntityAttribute(ColumnName = CNPINGFENREN)]
		public System.String PINGFENREN
		{
			get { return _PINGFENREN; }
			set
			{
				_PINGFENREN = value;
				base.SetFieldChanged(CNPINGFENREN) ;
			}
		}

		private System.DateTime _PINGFENSHIJIAN;
		/// <summary>
		/// PINGFENSHIJIAN
		/// </summary>
		[EntityAttribute(ColumnName = CNPINGFENSHIJIAN)]
		public System.DateTime PINGFENSHIJIAN
		{
			get { return _PINGFENSHIJIAN; }
			set
			{
				_PINGFENSHIJIAN = value;
				base.SetFieldChanged(CNPINGFENSHIJIAN) ;
			}
		}

		private System.String _DATI;
		/// <summary>
		/// DATI
		/// </summary>
		[EntityAttribute(ColumnName = CNDATI)]
		public System.String DATI
		{
			get { return _DATI; }
			set
			{
				_DATI = value;
				base.SetFieldChanged(CNDATI) ;
			}
		}

		private System.String _DATIBIAOZHI;
		/// <summary>
		/// DATIBIAOZHI
		/// </summary>
		[EntityAttribute(ColumnName = CNDATIBIAOZHI)]
		public System.String DATIBIAOZHI
		{
			get { return _DATIBIAOZHI; }
			set
			{
				_DATIBIAOZHI = value;
				base.SetFieldChanged(CNDATIBIAOZHI) ;
			}
		}

		private System.DateTime _DATIKAISHI;
		/// <summary>
		/// DATIKAISHI
		/// </summary>
		[EntityAttribute(ColumnName = CNDATIKAISHI)]
		public System.DateTime DATIKAISHI
		{
			get { return _DATIKAISHI; }
			set
			{
				_DATIKAISHI = value;
				base.SetFieldChanged(CNDATIKAISHI) ;
			}
		}

		private System.DateTime _DATIJIESHU;
		/// <summary>
		/// DATIJIESHU
		/// </summary>
		[EntityAttribute(ColumnName = CNDATIJIESHU)]
		public System.DateTime DATIJIESHU
		{
			get { return _DATIJIESHU; }
			set
			{
				_DATIJIESHU = value;
				base.SetFieldChanged(CNDATIJIESHU) ;
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

		private System.String _KAOHAO;
		/// <summary>
		/// KAOHAO
		/// </summary>
		[EntityAttribute(ColumnName = CNKAOHAO)]
		public System.String KAOHAO
		{
			get { return _KAOHAO; }
			set
			{
				_KAOHAO = value;
				base.SetFieldChanged(CNKAOHAO) ;
			}
		}

		private System.String _DENGLUBIAOZHI;
		/// <summary>
		/// DENGLUBIAOZHI
		/// </summary>
		[EntityAttribute(ColumnName = CNDENGLUBIAOZHI)]
		public System.String DENGLUBIAOZHI
		{
			get { return _DENGLUBIAOZHI; }
			set
			{
				_DENGLUBIAOZHI = value;
				base.SetFieldChanged(CNDENGLUBIAOZHI) ;
			}
		}

		private System.String _TIJIAOIP;
		/// <summary>
		/// TIJIAOIP
		/// </summary>
		[EntityAttribute(ColumnName = CNTIJIAOIP)]
		public System.String TIJIAOIP
		{
			get { return _TIJIAOIP; }
			set
			{
				_TIJIAOIP = value;
				base.SetFieldChanged(CNTIJIAOIP) ;
			}
		}

		#region 字段名的定义
		public const string CNID = "ID";
		public const string CNJIHUAID = "JIHUAID";
		public const string CNJIHUAMINGCHENG = "JIHUAMINGCHENG";
		public const string CNKESHIID = "KESHIID";
		public const string CNKESHI = "KESHI";
		public const string CNMUBANID = "MUBANID";
		public const string CNRENYUANID = "RENYUANID";
		public const string CNMUBAN = "MUBAN";
		public const string CNBIANHAO = "BIANHAO";
		public const string CNXINGMING = "XINGMING";
		public const string CNXINGMING_PY = "XINGMING_PY";
		public const string CNNENGJI = "NENGJI";
		public const string CNSHITISHU = "SHITISHU";
		public const string CNZHENGQUESHU = "ZHENGQUESHU";
		public const string CNFENSHU = "FENSHU";
		public const string CNPINGFENREN = "PINGFENREN";
		public const string CNPINGFENSHIJIAN = "PINGFENSHIJIAN";
		public const string CNDATI = "DATI";
		public const string CNDATIBIAOZHI = "DATIBIAOZHI";
		public const string CNDATIKAISHI = "DATIKAISHI";
		public const string CNDATIJIESHU = "DATIJIESHU";
		public const string CNLASTTIME = "LASTTIME";
		public const string CNKAOHAO = "KAOHAO";
		public const string CNDENGLUBIAOZHI = "DENGLUBIAOZHI";
		public const string CNTIJIAOIP = "TIJIAOIP";
		#endregion

	}
}
