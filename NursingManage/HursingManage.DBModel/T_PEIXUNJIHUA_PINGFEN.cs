using System;
using ZhCun.Framework.Entitys;

namespace ZCJH.HursingManage.DBModel
{
	public partial class T_PEIXUNJIHUA_PINGFEN : EntityBase
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

		private System.String _JIHUAMINGXIID;
		/// <summary>
		/// JIHUAMINGXIID
		/// </summary>
		[EntityAttribute(ColumnName = CNJIHUAMINGXIID)]
		public System.String JIHUAMINGXIID
		{
			get { return _JIHUAMINGXIID; }
			set
			{
				_JIHUAMINGXIID = value;
				base.SetFieldChanged(CNJIHUAMINGXIID) ;
			}
		}

		private System.String _KAOSHIDATI;
		/// <summary>
		/// KAOSHIDATI
		/// </summary>
		[EntityAttribute(ColumnName = CNKAOSHIDATI)]
		public System.String KAOSHIDATI
		{
			get { return _KAOSHIDATI; }
			set
			{
				_KAOSHIDATI = value;
				base.SetFieldChanged(CNKAOSHIDATI) ;
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

		private System.String _PINGFENRENID;
		/// <summary>
		/// PINGFENRENID
		/// </summary>
		[EntityAttribute(ColumnName = CNPINGFENRENID)]
		public System.String PINGFENRENID
		{
			get { return _PINGFENRENID; }
			set
			{
				_PINGFENRENID = value;
				base.SetFieldChanged(CNPINGFENRENID) ;
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

		#region 字段名的定义
		public const string CNID = "ID";
		public const string CNJIHUAID = "JIHUAID";
		public const string CNJIHUAMINGXIID = "JIHUAMINGXIID";
		public const string CNKAOSHIDATI = "KAOSHIDATI";
		public const string CNSHITISHU = "SHITISHU";
		public const string CNZHENGQUESHU = "ZHENGQUESHU";
		public const string CNFENSHU = "FENSHU";
		public const string CNPINGFENSHIJIAN = "PINGFENSHIJIAN";
		public const string CNPINGFENREN = "PINGFENREN";
		public const string CNPINGFENRENID = "PINGFENRENID";
		public const string CNADDTIME = "ADDTIME";
		public const string CNLASTTIME = "LASTTIME";
		public const string CNPC = "PC";
		public const string CNOPERATORID = "OPERATORID";
		#endregion

	}
}
