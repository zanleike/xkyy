using System;
using Framework.Entitys;

namespace HursingManage.DBModel
{
	public partial class T_ZHIKONGJIHUA : EntityBase
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

		private System.String _KAISHISHIJIAN;
		/// <summary>
		/// KAISHISHIJIAN
		/// </summary>
		[EntityAttribute(ColumnName = CNKAISHISHIJIAN)]
		public System.String KAISHISHIJIAN
		{
			get { return _KAISHISHIJIAN; }
			set
			{
				_KAISHISHIJIAN = value;
				base.SetFieldChanged(CNKAISHISHIJIAN) ;
			}
		}

		private System.String _JIESHUSHIJIAN;
		/// <summary>
		/// JIESHUSHIJIAN
		/// </summary>
		[EntityAttribute(ColumnName = CNJIESHUSHIJIAN)]
		public System.String JIESHUSHIJIAN
		{
			get { return _JIESHUSHIJIAN; }
			set
			{
				_JIESHUSHIJIAN = value;
				base.SetFieldChanged(CNJIESHUSHIJIAN) ;
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

		private System.String _SHIFOUFUCHA;
		/// <summary>
		/// SHIFOUFUCHA
		/// </summary>
		[EntityAttribute(ColumnName = CNSHIFOUFUCHA)]
		public System.String SHIFOUFUCHA
		{
			get { return _SHIFOUFUCHA; }
			set
			{
				_SHIFOUFUCHA = value;
				base.SetFieldChanged(CNSHIFOUFUCHA) ;
			}
		}

		private System.String _FUCHAJIHUAID;
		/// <summary>
		/// FUCHAJIHUAID
		/// </summary>
		[EntityAttribute(ColumnName = CNFUCHAJIHUAID)]
		public System.String FUCHAJIHUAID
		{
			get { return _FUCHAJIHUAID; }
			set
			{
				_FUCHAJIHUAID = value;
				base.SetFieldChanged(CNFUCHAJIHUAID) ;
			}
		}

		private System.String _FUCHAJIHUA;
		/// <summary>
		/// FUCHAJIHUA
		/// </summary>
		[EntityAttribute(ColumnName = CNFUCHAJIHUA)]
		public System.String FUCHAJIHUA
		{
			get { return _FUCHAJIHUA; }
			set
			{
				_FUCHAJIHUA = value;
				base.SetFieldChanged(CNFUCHAJIHUA) ;
			}
		}

		#region 字段名的定义
		public const string CNID = "ID";
		public const string CNMINGCHENG = "MINGCHENG";
		public const string CNKAISHISHIJIAN = "KAISHISHIJIAN";
		public const string CNJIESHUSHIJIAN = "JIESHUSHIJIAN";
		public const string CNBEIZHU = "BEIZHU";
		public const string CNADDTIME = "ADDTIME";
		public const string CNLASTTIME = "LASTTIME";
		public const string CNOPERATORID = "OPERATORID";
		public const string CNPC = "PC";
		public const string CNSHIFOUFUCHA = "SHIFOUFUCHA";
		public const string CNFUCHAJIHUAID = "FUCHAJIHUAID";
		public const string CNFUCHAJIHUA = "FUCHAJIHUA";
		#endregion

	}
}
