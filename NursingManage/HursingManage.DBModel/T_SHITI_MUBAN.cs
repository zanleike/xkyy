using System;
using Framework.Entitys;

namespace HursingManage.DBModel
{
	public partial class T_SHITI_MUBAN : EntityBase
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

		private System.String _SHITILEIBIE;
		/// <summary>
		/// SHITILEIBIE
		/// </summary>
		[EntityAttribute(ColumnName = CNSHITILEIBIE)]
		public System.String SHITILEIBIE
		{
			get { return _SHITILEIBIE; }
			set
			{
				_SHITILEIBIE = value;
				base.SetFieldChanged(CNSHITILEIBIE) ;
			}
		}

		private System.String _SHITILEIBIEID;
		/// <summary>
		/// SHITILEIBIEID
		/// </summary>
		[EntityAttribute(ColumnName = CNSHITILEIBIEID)]
		public System.String SHITILEIBIEID
		{
			get { return _SHITILEIBIEID; }
			set
			{
				_SHITILEIBIEID = value;
				base.SetFieldChanged(CNSHITILEIBIEID) ;
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

		private System.Decimal _DANXUANSHU;
		/// <summary>
		/// DANXUANSHU
		/// </summary>
		[EntityAttribute(ColumnName = CNDANXUANSHU)]
		public System.Decimal DANXUANSHU
		{
			get { return _DANXUANSHU; }
			set
			{
				_DANXUANSHU = value;
				base.SetFieldChanged(CNDANXUANSHU) ;
			}
		}

		private System.Decimal _DANXUANFENSHU;
		/// <summary>
		/// DANXUANFENSHU
		/// </summary>
		[EntityAttribute(ColumnName = CNDANXUANFENSHU)]
		public System.Decimal DANXUANFENSHU
		{
			get { return _DANXUANFENSHU; }
			set
			{
				_DANXUANFENSHU = value;
				base.SetFieldChanged(CNDANXUANFENSHU) ;
			}
		}

		private System.Decimal _DUOXUANSHU;
		/// <summary>
		/// DUOXUANSHU
		/// </summary>
		[EntityAttribute(ColumnName = CNDUOXUANSHU)]
		public System.Decimal DUOXUANSHU
		{
			get { return _DUOXUANSHU; }
			set
			{
				_DUOXUANSHU = value;
				base.SetFieldChanged(CNDUOXUANSHU) ;
			}
		}

		private System.Decimal _DUOXUANFENSHU;
		/// <summary>
		/// DUOXUANFENSHU
		/// </summary>
		[EntityAttribute(ColumnName = CNDUOXUANFENSHU)]
		public System.Decimal DUOXUANFENSHU
		{
			get { return _DUOXUANFENSHU; }
			set
			{
				_DUOXUANFENSHU = value;
				base.SetFieldChanged(CNDUOXUANFENSHU) ;
			}
		}

		private System.Decimal _PANDUANSHU;
		/// <summary>
		/// PANDUANSHU
		/// </summary>
		[EntityAttribute(ColumnName = CNPANDUANSHU)]
		public System.Decimal PANDUANSHU
		{
			get { return _PANDUANSHU; }
			set
			{
				_PANDUANSHU = value;
				base.SetFieldChanged(CNPANDUANSHU) ;
			}
		}

		private System.Decimal _PANDUANFENSHU;
		/// <summary>
		/// PANDUANFENSHU
		/// </summary>
		[EntityAttribute(ColumnName = CNPANDUANFENSHU)]
		public System.Decimal PANDUANFENSHU
		{
			get { return _PANDUANFENSHU; }
			set
			{
				_PANDUANFENSHU = value;
				base.SetFieldChanged(CNPANDUANFENSHU) ;
			}
		}

		#region 字段名的定义
		public const string CNID = "ID";
		public const string CNMINGCHENG = "MINGCHENG";
		public const string CNMINGCHENG_PY = "MINGCHENG_PY";
		public const string CNCHUANGJIANREN = "CHUANGJIANREN";
		public const string CNSHITILEIBIE = "SHITILEIBIE";
		public const string CNSHITILEIBIEID = "SHITILEIBIEID";
		public const string CNBEIZHU = "BEIZHU";
		public const string CNADDTIME = "ADDTIME";
		public const string CNLASTTIME = "LASTTIME";
		public const string CNOPERATORID = "OPERATORID";
		public const string CNPC = "PC";
		public const string CNDANXUANSHU = "DANXUANSHU";
		public const string CNDANXUANFENSHU = "DANXUANFENSHU";
		public const string CNDUOXUANSHU = "DUOXUANSHU";
		public const string CNDUOXUANFENSHU = "DUOXUANFENSHU";
		public const string CNPANDUANSHU = "PANDUANSHU";
		public const string CNPANDUANFENSHU = "PANDUANFENSHU";
		#endregion

	}
}
