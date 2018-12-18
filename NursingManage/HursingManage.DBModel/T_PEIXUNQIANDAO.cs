using System;
using Framework.Entitys;

namespace HursingManage.DBModel
{
	public partial class T_PEIXUNQIANDAO : EntityBase
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

		private System.String _RENYUANID;
		/// <summary>
		/// RENYUANID
		/// </summary>
		[EntityAttribute(ColumnName = CNRENYUANID)]
		public System.String RENYUANID
		{
			get { return _RENYUANID; }
			set
			{
				_RENYUANID = value;
				base.SetFieldChanged(CNRENYUANID) ;
			}
		}

		private System.String _RENYUAN;
		/// <summary>
		/// RENYUAN
		/// </summary>
		[EntityAttribute(ColumnName = CNRENYUAN)]
		public System.String RENYUAN
		{
			get { return _RENYUAN; }
			set
			{
				_RENYUAN = value;
				base.SetFieldChanged(CNRENYUAN) ;
			}
		}

		private System.DateTime _QIANDAOSHIJIAN;
		/// <summary>
		/// QIANDAOSHIJIAN
		/// </summary>
		[EntityAttribute(ColumnName = CNQIANDAOSHIJIAN)]
		public System.DateTime QIANDAOSHIJIAN
		{
			get { return _QIANDAOSHIJIAN; }
			set
			{
				_QIANDAOSHIJIAN = value;
				base.SetFieldChanged(CNQIANDAOSHIJIAN) ;
			}
		}

		private System.String _KAOSHIZHUANGTAI;
		/// <summary>
		/// KAOSHIZHUANGTAI
		/// </summary>
		[EntityAttribute(ColumnName = CNKAOSHIZHUANGTAI)]
		public System.String KAOSHIZHUANGTAI
		{
			get { return _KAOSHIZHUANGTAI; }
			set
			{
				_KAOSHIZHUANGTAI = value;
				base.SetFieldChanged(CNKAOSHIZHUANGTAI) ;
			}
		}

		#region 字段名的定义
		public const string CNID = "ID";
		public const string CNKESHIID = "KESHIID";
		public const string CNKESHI = "KESHI";
		public const string CNRENYUANID = "RENYUANID";
		public const string CNRENYUAN = "RENYUAN";
		public const string CNQIANDAOSHIJIAN = "QIANDAOSHIJIAN";
		public const string CNKAOSHIZHUANGTAI = "KAOSHIZHUANGTAI";
		#endregion

	}
}
