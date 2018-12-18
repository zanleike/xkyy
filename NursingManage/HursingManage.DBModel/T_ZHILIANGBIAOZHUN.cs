using System;
using Framework.Entitys;

namespace HursingManage.DBModel
{
	public partial class T_ZHILIANGBIAOZHUN : EntityBase
	{
		private System.String _ID;
		/// <summary>
		/// ID
		/// </summary>
		[EntityAttribute(ColumnName = CNID, IsPrimaryKey = true)]
		public System.String ID
		{
			get { return _ID; }
			set
			{
				_ID = value;
				base.SetFieldChanged(CNID) ;
			}
		}

		private System.String _LEIBIEID;
		/// <summary>
		/// LEIBIEID
		/// </summary>
		[EntityAttribute(ColumnName = CNLEIBIEID)]
		public System.String LEIBIEID
		{
			get { return _LEIBIEID; }
			set
			{
				_LEIBIEID = value;
				base.SetFieldChanged(CNLEIBIEID) ;
			}
		}

		private System.String _LEIBIE;
		/// <summary>
		/// LEIBIE
		/// </summary>
		[EntityAttribute(ColumnName = CNLEIBIE)]
		public System.String LEIBIE
		{
			get { return _LEIBIE; }
			set
			{
				_LEIBIE = value;
				base.SetFieldChanged(CNLEIBIE) ;
			}
		}

		private System.String _LEIXING1;
		/// <summary>
		/// LEIXING1
		/// </summary>
		[EntityAttribute(ColumnName = CNLEIXING1)]
		public System.String LEIXING1
		{
			get { return _LEIXING1; }
			set
			{
				_LEIXING1 = value;
				base.SetFieldChanged(CNLEIXING1) ;
			}
		}

		private System.String _LEIXING2;
		/// <summary>
		/// LEIXING2
		/// </summary>
		[EntityAttribute(ColumnName = CNLEIXING2)]
		public System.String LEIXING2
		{
			get { return _LEIXING2; }
			set
			{
				_LEIXING2 = value;
				base.SetFieldChanged(CNLEIXING2) ;
			}
		}

		private System.Decimal _XUHAO;
		/// <summary>
		/// XUHAO
		/// </summary>
		[EntityAttribute(ColumnName = CNXUHAO)]
		public System.Decimal XUHAO
		{
			get { return _XUHAO; }
			set
			{
				_XUHAO = value;
				base.SetFieldChanged(CNXUHAO) ;
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
		public const string CNLEIBIEID = "LEIBIEID";
		public const string CNLEIBIE = "LEIBIE";
		public const string CNLEIXING1 = "LEIXING1";
		public const string CNLEIXING2 = "LEIXING2";
		public const string CNXUHAO = "XUHAO";
		public const string CNNEIRONG = "NEIRONG";
		public const string CNADDTIME = "ADDTIME";
		public const string CNLASTTIME = "LASTTIME";
		public const string CNOPERATORID = "OPERATORID";
		public const string CNPC = "PC";
		#endregion

	}
}
