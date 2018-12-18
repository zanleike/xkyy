using System;
using Framework.Entitys;

namespace HursingManage.DBModel
{
	public partial class T_ZHILIANGBIAOZHUN_LEIBIE_KS : EntityBase
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

		private System.String _KESHINAME;
		/// <summary>
		/// KESHINAME
		/// </summary>
		[EntityAttribute(ColumnName = CNKESHINAME)]
		public System.String KESHINAME
		{
			get { return _KESHINAME; }
			set
			{
				_KESHINAME = value;
				base.SetFieldChanged(CNKESHINAME) ;
			}
		}

		private System.String _MINGCHENG;
		/// <summary>
		/// MINGCHENG
		/// </summary>
		[EntityAttribute(ColumnName = CNMINGCHENG)]
		public System.String MINGCHENG
		{
			get { return _MINGCHENG; }
			set
			{
				_MINGCHENG = value;
				base.SetFieldChanged(CNMINGCHENG) ;
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

		private System.String _MINGCHENG_PY;
		/// <summary>
		/// MINGCHENG_PY
		/// </summary>
		[EntityAttribute(ColumnName = CNMINGCHENG_PY)]
		public System.String MINGCHENG_PY
		{
			get { return _MINGCHENG_PY; }
			set
			{
				_MINGCHENG_PY = value;
				base.SetFieldChanged(CNMINGCHENG_PY) ;
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

		#region 字段名的定义
		public const string CNID = "ID";
		public const string CNKESHIID = "KESHIID";
		public const string CNKESHINAME = "KESHINAME";
		public const string CNMINGCHENG = "MINGCHENG";
		public const string CNBIAOZHUNSHU = "BIAOZHUNSHU";
		public const string CNMINGCHENG_PY = "MINGCHENG_PY";
		public const string CNBEIZHU = "BEIZHU";
		public const string CNADDTIME = "ADDTIME";
		public const string CNLASTTIME = "LASTTIME";
		public const string CNOPERATORID = "OPERATORID";
		public const string CNPC = "PC";
		#endregion

	}
}
