using System;
using Framework.Entitys;

namespace HursingManage.DBModel
{
	public partial class V_PEIXUNJIHUA_MINGXI_WEIKAO : EntityBase
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

		private System.String _YUANYIN;
		/// <summary>
		/// YUANYIN
		/// </summary>
		[EntityAttribute(ColumnName = CNYUANYIN)]
		public System.String YUANYIN
		{
			get { return _YUANYIN; }
			set
			{
				_YUANYIN = value;
				base.SetFieldChanged(CNYUANYIN) ;
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
		public const string CNKESHIID = "KESHIID";
		public const string CNJIHUAID = "JIHUAID";
		public const string CNKESHI = "KESHI";
		public const string CNNEIRONG = "NEIRONG";
		public const string CNBIANHAO = "BIANHAO";
		public const string CNXINGMING = "XINGMING";
		public const string CNXINGMING_PY = "XINGMING_PY";
		public const string CNYUANYIN = "YUANYIN";
		public const string CNADDTIME = "ADDTIME";
		public const string CNLASTTIME = "LASTTIME";
		public const string CNPC = "PC";
		public const string CNOPERATORID = "OPERATORID";
		#endregion

	}
}
