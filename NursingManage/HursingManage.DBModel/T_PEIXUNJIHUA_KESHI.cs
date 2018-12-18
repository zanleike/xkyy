using System;
using Framework.Entitys;

namespace HursingManage.DBModel
{
	public partial class T_PEIXUNJIHUA_KESHI : EntityBase
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

		private System.String _QUERENRENID;
		/// <summary>
		/// QUERENRENID
		/// </summary>
		[EntityAttribute(ColumnName = CNQUERENRENID)]
		public System.String QUERENRENID
		{
			get { return _QUERENRENID; }
			set
			{
				_QUERENRENID = value;
				base.SetFieldChanged(CNQUERENRENID) ;
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

		#region 字段名的定义
		public const string CNID = "ID";
		public const string CNJIHUAID = "JIHUAID";
		public const string CNKESHIID = "KESHIID";
		public const string CNKESHI = "KESHI";
		public const string CNSHIFOUQUEREN = "SHIFOUQUEREN";
		public const string CNQUERENREN = "QUERENREN";
		public const string CNQUERENRENID = "QUERENRENID";
		public const string CNQUERENSHIJIAN = "QUERENSHIJIAN";
		public const string CNBEIZHU = "BEIZHU";
		public const string CNADDTIME = "ADDTIME";
		public const string CNLASTTIME = "LASTTIME";
		public const string CNPC = "PC";
		public const string CNOPERATORID = "OPERATORID";
		public const string CNYINGKAORENSHU = "YINGKAORENSHU";
		public const string CNSHIKAORENSHU = "SHIKAORENSHU";
		#endregion

	}
}
