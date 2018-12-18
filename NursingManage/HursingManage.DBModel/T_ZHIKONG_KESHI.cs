using System;
using Framework.Entitys;

namespace HursingManage.DBModel
{
	public partial class T_ZHIKONG_KESHI : EntityBase
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

		private System.DateTime _JIANCHARIQI;
		/// <summary>
		/// JIANCHARIQI
		/// </summary>
		[EntityAttribute(ColumnName = CNJIANCHARIQI)]
		public System.DateTime JIANCHARIQI
		{
			get { return _JIANCHARIQI; }
			set
			{
				_JIANCHARIQI = value;
				base.SetFieldChanged(CNJIANCHARIQI) ;
			}
		}

		private System.String _ZHIKONGRENYUAN;
		/// <summary>
		/// ZHIKONGRENYUAN
		/// </summary>
		[EntityAttribute(ColumnName = CNZHIKONGRENYUAN)]
		public System.String ZHIKONGRENYUAN
		{
			get { return _ZHIKONGRENYUAN; }
			set
			{
				_ZHIKONGRENYUAN = value;
				base.SetFieldChanged(CNZHIKONGRENYUAN) ;
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

		private System.String _JIANGPINGREN;
		/// <summary>
		/// JIANGPINGREN
		/// </summary>
		[EntityAttribute(ColumnName = CNJIANGPINGREN)]
		public System.String JIANGPINGREN
		{
			get { return _JIANGPINGREN; }
			set
			{
				_JIANGPINGREN = value;
				base.SetFieldChanged(CNJIANGPINGREN) ;
			}
		}

		private System.DateTime _JIANGPINGSHIJIAN;
		/// <summary>
		/// JIANGPINGSHIJIAN
		/// </summary>
		[EntityAttribute(ColumnName = CNJIANGPINGSHIJIAN)]
		public System.DateTime JIANGPINGSHIJIAN
		{
			get { return _JIANGPINGSHIJIAN; }
			set
			{
				_JIANGPINGSHIJIAN = value;
				base.SetFieldChanged(CNJIANGPINGSHIJIAN) ;
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

		private System.String _GAIJINCUOSHI;
		/// <summary>
		/// GAIJINCUOSHI
		/// </summary>
		[EntityAttribute(ColumnName = CNGAIJINCUOSHI)]
		public System.String GAIJINCUOSHI
		{
			get { return _GAIJINCUOSHI; }
			set
			{
				_GAIJINCUOSHI = value;
				base.SetFieldChanged(CNGAIJINCUOSHI) ;
			}
		}

		private System.DateTime _SHANGBAOSHIJIAN;
		/// <summary>
		/// SHANGBAOSHIJIAN
		/// </summary>
		[EntityAttribute(ColumnName = CNSHANGBAOSHIJIAN, IsNotNull = true)]
		public System.DateTime SHANGBAOSHIJIAN
		{
			get { return _SHANGBAOSHIJIAN; }
			set
			{
				_SHANGBAOSHIJIAN = value;
				base.SetFieldChanged(CNSHANGBAOSHIJIAN) ;
			}
		}

		private System.String _SHANGBAOREN;
		/// <summary>
		/// SHANGBAOREN
		/// </summary>
		[EntityAttribute(ColumnName = CNSHANGBAOREN, IsNotNull = true)]
		public System.String SHANGBAOREN
		{
			get { return _SHANGBAOREN; }
			set
			{
				_SHANGBAOREN = value;
				base.SetFieldChanged(CNSHANGBAOREN) ;
			}
		}

		private System.String _SHANGBAOZHUANGTAI;
		/// <summary>
		/// SHANGBAOZHUANGTAI
		/// </summary>
		[EntityAttribute(ColumnName = CNSHANGBAOZHUANGTAI)]
		public System.String SHANGBAOZHUANGTAI
		{
			get { return _SHANGBAOZHUANGTAI; }
			set
			{
				_SHANGBAOZHUANGTAI = value;
				base.SetFieldChanged(CNSHANGBAOZHUANGTAI) ;
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

		#region 字段名的定义
		public const string CNID = "ID";
		public const string CNADDTIME = "ADDTIME";
		public const string CNLASTTIME = "LASTTIME";
		public const string CNOPERATORID = "OPERATORID";
		public const string CNPC = "PC";
		public const string CNKESHIID = "KESHIID";
		public const string CNKESHI = "KESHI";
		public const string CNJIANCHARIQI = "JIANCHARIQI";
		public const string CNZHIKONGRENYUAN = "ZHIKONGRENYUAN";
		public const string CNCANJIARENYUAN = "CANJIARENYUAN";
		public const string CNJIANGPINGREN = "JIANGPINGREN";
		public const string CNJIANGPINGSHIJIAN = "JIANGPINGSHIJIAN";
		public const string CNYUANYINFENXI = "YUANYINFENXI";
		public const string CNGAIJINCUOSHI = "GAIJINCUOSHI";
		public const string CNSHANGBAOSHIJIAN = "SHANGBAOSHIJIAN";
		public const string CNSHANGBAOREN = "SHANGBAOREN";
		public const string CNSHANGBAOZHUANGTAI = "SHANGBAOZHUANGTAI";
		public const string CNBEIZHU = "BEIZHU";
		#endregion

	}
}
