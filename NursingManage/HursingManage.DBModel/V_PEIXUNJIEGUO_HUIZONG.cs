using System;
using Framework.Entitys;

namespace HursingManage.DBModel
{
	public partial class V_PEIXUNJIEGUO_HUIZONG : EntityBase
	{
		private System.String _KESHIID;
		/// <summary>
		/// KESHIID
		/// </summary>
		[EntityAttribute(ColumnName = CNKESHIID, IsPrimaryKey = true)]
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

		private System.Decimal _KAOSHIRENSHU;
		/// <summary>
		/// KAOSHIRENSHU
		/// </summary>
		[EntityAttribute(ColumnName = CNKAOSHIRENSHU)]
		public System.Decimal KAOSHIRENSHU
		{
			get { return _KAOSHIRENSHU; }
			set
			{
				_KAOSHIRENSHU = value;
				base.SetFieldChanged(CNKAOSHIRENSHU) ;
			}
		}

		private System.Decimal _KAOSHIZONGFEN;
		/// <summary>
		/// KAOSHIZONGFEN
		/// </summary>
		[EntityAttribute(ColumnName = CNKAOSHIZONGFEN)]
		public System.Decimal KAOSHIZONGFEN
		{
			get { return _KAOSHIZONGFEN; }
			set
			{
				_KAOSHIZONGFEN = value;
				base.SetFieldChanged(CNKAOSHIZONGFEN) ;
			}
		}

		private System.Decimal _PINGJUNFENSHU;
		/// <summary>
		/// PINGJUNFENSHU
		/// </summary>
		[EntityAttribute(ColumnName = CNPINGJUNFENSHU)]
		public System.Decimal PINGJUNFENSHU
		{
			get { return _PINGJUNFENSHU; }
			set
			{
				_PINGJUNFENSHU = value;
				base.SetFieldChanged(CNPINGJUNFENSHU) ;
			}
		}

		#region 字段名的定义
		public const string CNKESHIID = "KESHIID";
		public const string CNKESHI = "KESHI";
		public const string CNJIHUAID = "JIHUAID";
		public const string CNNEIRONG = "NEIRONG";
		public const string CNKAOSHIRENSHU = "KAOSHIRENSHU";
		public const string CNKAOSHIZONGFEN = "KAOSHIZONGFEN";
		public const string CNPINGJUNFENSHU = "PINGJUNFENSHU";
		#endregion

	}
}
