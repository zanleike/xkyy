using System;
using ZhCun.Framework.Entitys;

namespace ZCJH.HursingManage.DBModel
{
	public partial class T_JINENGBIAOZHUN_LEIBIE : EntityBase
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

		private System.Decimal _ZONGFEN;
		/// <summary>
		/// ZONGFEN
		/// </summary>
		[EntityAttribute(ColumnName = CNZONGFEN)]
		public System.Decimal ZONGFEN
		{
			get { return _ZONGFEN; }
			set
			{
				_ZONGFEN = value;
				base.SetFieldChanged(CNZONGFEN) ;
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
		public const string CNMINGCHENG = "MINGCHENG";
		public const string CNMINGCHENG_PY = "MINGCHENG_PY";
		public const string CNZONGFEN = "ZONGFEN";
		public const string CNBEIZHU = "BEIZHU";
		public const string CNADDTIME = "ADDTIME";
		public const string CNLASTTIME = "LASTTIME";
		public const string CNOPERATORID = "OPERATORID";
		public const string CNPC = "PC";
		#endregion

	}
}
