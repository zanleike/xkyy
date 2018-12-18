using System;
using Framework.Entitys;

namespace HursingManage.DBModel
{
	public partial class T_SHITI : EntityBase
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

		private System.String _NANYICHENGDU;
		/// <summary>
		/// NANYICHENGDU
		/// </summary>
		[EntityAttribute(ColumnName = CNNANYICHENGDU)]
		public System.String NANYICHENGDU
		{
			get { return _NANYICHENGDU; }
			set
			{
				_NANYICHENGDU = value;
				base.SetFieldChanged(CNNANYICHENGDU) ;
			}
		}

		private System.String _LEIXING;
		/// <summary>
		/// LEIXING
		/// </summary>
		[EntityAttribute(ColumnName = CNLEIXING)]
		public System.String LEIXING
		{
			get { return _LEIXING; }
			set
			{
				_LEIXING = value;
				base.SetFieldChanged(CNLEIXING) ;
			}
		}

		private System.String _FENLEI;
		/// <summary>
		/// FENLEI
		/// </summary>
		[EntityAttribute(ColumnName = CNFENLEI)]
		public System.String FENLEI
		{
			get { return _FENLEI; }
			set
			{
				_FENLEI = value;
				base.SetFieldChanged(CNFENLEI) ;
			}
		}

		private System.String _FENLEIID;
		/// <summary>
		/// FENLEIID
		/// </summary>
		[EntityAttribute(ColumnName = CNFENLEIID)]
		public System.String FENLEIID
		{
			get { return _FENLEIID; }
			set
			{
				_FENLEIID = value;
				base.SetFieldChanged(CNFENLEIID) ;
			}
		}

		private System.String _DAAN;
		/// <summary>
		/// DAAN
		/// </summary>
		[EntityAttribute(ColumnName = CNDAAN)]
		public System.String DAAN
		{
			get { return _DAAN; }
			set
			{
				_DAAN = value;
				base.SetFieldChanged(CNDAAN) ;
			}
		}

		private System.String _XIANGMUA;
		/// <summary>
		/// XIANGMUA
		/// </summary>
		[EntityAttribute(ColumnName = CNXIANGMUA)]
		public System.String XIANGMUA
		{
			get { return _XIANGMUA; }
			set
			{
				_XIANGMUA = value;
				base.SetFieldChanged(CNXIANGMUA) ;
			}
		}

		private System.String _XIANGMUB;
		/// <summary>
		/// XIANGMUB
		/// </summary>
		[EntityAttribute(ColumnName = CNXIANGMUB)]
		public System.String XIANGMUB
		{
			get { return _XIANGMUB; }
			set
			{
				_XIANGMUB = value;
				base.SetFieldChanged(CNXIANGMUB) ;
			}
		}

		private System.String _XIANGMUC;
		/// <summary>
		/// XIANGMUC
		/// </summary>
		[EntityAttribute(ColumnName = CNXIANGMUC)]
		public System.String XIANGMUC
		{
			get { return _XIANGMUC; }
			set
			{
				_XIANGMUC = value;
				base.SetFieldChanged(CNXIANGMUC) ;
			}
		}

		private System.String _XIANGMUD;
		/// <summary>
		/// XIANGMUD
		/// </summary>
		[EntityAttribute(ColumnName = CNXIANGMUD)]
		public System.String XIANGMUD
		{
			get { return _XIANGMUD; }
			set
			{
				_XIANGMUD = value;
				base.SetFieldChanged(CNXIANGMUD) ;
			}
		}

		private System.String _XIANGMUE;
		/// <summary>
		/// XIANGMUE
		/// </summary>
		[EntityAttribute(ColumnName = CNXIANGMUE)]
		public System.String XIANGMUE
		{
			get { return _XIANGMUE; }
			set
			{
				_XIANGMUE = value;
				base.SetFieldChanged(CNXIANGMUE) ;
			}
		}

		private System.String _XIANGMUF;
		/// <summary>
		/// XIANGMUF
		/// </summary>
		[EntityAttribute(ColumnName = CNXIANGMUF)]
		public System.String XIANGMUF
		{
			get { return _XIANGMUF; }
			set
			{
				_XIANGMUF = value;
				base.SetFieldChanged(CNXIANGMUF) ;
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
		public const string CNBIANHAO = "BIANHAO";
		public const string CNNEIRONG = "NEIRONG";
		public const string CNNANYICHENGDU = "NANYICHENGDU";
		public const string CNLEIXING = "LEIXING";
		public const string CNFENLEI = "FENLEI";
		public const string CNFENLEIID = "FENLEIID";
		public const string CNDAAN = "DAAN";
		public const string CNXIANGMUA = "XIANGMUA";
		public const string CNXIANGMUB = "XIANGMUB";
		public const string CNXIANGMUC = "XIANGMUC";
		public const string CNXIANGMUD = "XIANGMUD";
		public const string CNXIANGMUE = "XIANGMUE";
		public const string CNXIANGMUF = "XIANGMUF";
		public const string CNADDTIME = "ADDTIME";
		public const string CNLASTTIME = "LASTTIME";
		public const string CNOPERATORID = "OPERATORID";
		public const string CNPC = "PC";
		#endregion

	}
}
