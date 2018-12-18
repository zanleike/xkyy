using System;
using Framework.Entitys;

namespace HursingManage.DBModel
{
	public partial class T_PEIXUNJIHUA : EntityBase
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

		private System.Decimal _PEIXUNLEIXING;
		/// <summary>
		/// PEIXUNLEIXING
		/// </summary>
		[EntityAttribute(ColumnName = CNPEIXUNLEIXING)]
		public System.Decimal PEIXUNLEIXING
		{
			get { return _PEIXUNLEIXING; }
			set
			{
				_PEIXUNLEIXING = value;
				base.SetFieldChanged(CNPEIXUNLEIXING) ;
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

		private System.String _CHUANGJIANREN;
		/// <summary>
		/// CHUANGJIANREN
		/// </summary>
		[EntityAttribute(ColumnName = CNCHUANGJIANREN)]
		public System.String CHUANGJIANREN
		{
			get { return _CHUANGJIANREN; }
			set
			{
				_CHUANGJIANREN = value;
				base.SetFieldChanged(CNCHUANGJIANREN) ;
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
		public const string CNNEIRONG = "NEIRONG";
		public const string CNNEIRONGSHUOMING = "NEIRONGSHUOMING";
		public const string CNPEIXUNKAISHI = "PEIXUNKAISHI";
		public const string CNPEIXUNJIESHU = "PEIXUNJIESHU";
		public const string CNKAOHEKAISHI = "KAOHEKAISHI";
		public const string CNKAOHEJIESHU = "KAOHEJIESHU";
		public const string CNPEIXUNLEIXING = "PEIXUNLEIXING";
		public const string CNCANJIARENYUAN = "CANJIARENYUAN";
		public const string CNCHUANGJIANREN = "CHUANGJIANREN";
		public const string CNADDTIME = "ADDTIME";
		public const string CNLASTTIME = "LASTTIME";
		public const string CNPC = "PC";
		public const string CNOPERATORID = "OPERATORID";
		#endregion

	}
}
