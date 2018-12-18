using System;
using Framework.Entitys;

namespace HursingManage.DBModel
{
	public partial class T_DANGAN_EX : EntityBase
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

		private System.String _DANGANID;
		/// <summary>
		/// DANGANID
		/// </summary>
		[EntityAttribute(ColumnName = CNDANGANID)]
		public System.String DANGANID
		{
			get { return _DANGANID; }
			set
			{
				_DANGANID = value;
				base.SetFieldChanged(CNDANGANID) ;
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

		private System.String _XINGMING;
		/// <summary>
		/// XINGMING
		/// </summary>
		[EntityAttribute(ColumnName = CNXINGMING)]
		public System.String XINGMING
		{
			get { return _XINGMING; }
			set
			{
				_XINGMING = value;
				base.SetFieldChanged(CNXINGMING) ;
			}
		}

		private System.String _XINGMING_PY;
		/// <summary>
		/// XINGMING_PY
		/// </summary>
		[EntityAttribute(ColumnName = CNXINGMING_PY)]
		public System.String XINGMING_PY
		{
			get { return _XINGMING_PY; }
			set
			{
				_XINGMING_PY = value;
				base.SetFieldChanged(CNXINGMING_PY) ;
			}
		}

		private System.String _EX1;
		/// <summary>
		/// EX1
		/// </summary>
		[EntityAttribute(ColumnName = CNEX1)]
		public System.String EX1
		{
			get { return _EX1; }
			set
			{
				_EX1 = value;
				base.SetFieldChanged(CNEX1) ;
			}
		}

		private System.String _EX2;
		/// <summary>
		/// EX2
		/// </summary>
		[EntityAttribute(ColumnName = CNEX2)]
		public System.String EX2
		{
			get { return _EX2; }
			set
			{
				_EX2 = value;
				base.SetFieldChanged(CNEX2) ;
			}
		}

		private System.String _EX3;
		/// <summary>
		/// EX3
		/// </summary>
		[EntityAttribute(ColumnName = CNEX3)]
		public System.String EX3
		{
			get { return _EX3; }
			set
			{
				_EX3 = value;
				base.SetFieldChanged(CNEX3) ;
			}
		}

		private System.String _EX4;
		/// <summary>
		/// EX4
		/// </summary>
		[EntityAttribute(ColumnName = CNEX4)]
		public System.String EX4
		{
			get { return _EX4; }
			set
			{
				_EX4 = value;
				base.SetFieldChanged(CNEX4) ;
			}
		}

		private System.String _EX5;
		/// <summary>
		/// EX5
		/// </summary>
		[EntityAttribute(ColumnName = CNEX5)]
		public System.String EX5
		{
			get { return _EX5; }
			set
			{
				_EX5 = value;
				base.SetFieldChanged(CNEX5) ;
			}
		}

		private System.String _EX6;
		/// <summary>
		/// EX6
		/// </summary>
		[EntityAttribute(ColumnName = CNEX6)]
		public System.String EX6
		{
			get { return _EX6; }
			set
			{
				_EX6 = value;
				base.SetFieldChanged(CNEX6) ;
			}
		}

		private System.String _EX7;
		/// <summary>
		/// EX7
		/// </summary>
		[EntityAttribute(ColumnName = CNEX7)]
		public System.String EX7
		{
			get { return _EX7; }
			set
			{
				_EX7 = value;
				base.SetFieldChanged(CNEX7) ;
			}
		}

		private System.String _EX8;
		/// <summary>
		/// EX8
		/// </summary>
		[EntityAttribute(ColumnName = CNEX8)]
		public System.String EX8
		{
			get { return _EX8; }
			set
			{
				_EX8 = value;
				base.SetFieldChanged(CNEX8) ;
			}
		}

		private System.String _EX9;
		/// <summary>
		/// EX9
		/// </summary>
		[EntityAttribute(ColumnName = CNEX9)]
		public System.String EX9
		{
			get { return _EX9; }
			set
			{
				_EX9 = value;
				base.SetFieldChanged(CNEX9) ;
			}
		}

		private System.String _EX10;
		/// <summary>
		/// EX10
		/// </summary>
		[EntityAttribute(ColumnName = CNEX10)]
		public System.String EX10
		{
			get { return _EX10; }
			set
			{
				_EX10 = value;
				base.SetFieldChanged(CNEX10) ;
			}
		}

		private System.String _EX11;
		/// <summary>
		/// EX11
		/// </summary>
		[EntityAttribute(ColumnName = CNEX11)]
		public System.String EX11
		{
			get { return _EX11; }
			set
			{
				_EX11 = value;
				base.SetFieldChanged(CNEX11) ;
			}
		}

		private System.String _EX12;
		/// <summary>
		/// EX12
		/// </summary>
		[EntityAttribute(ColumnName = CNEX12)]
		public System.String EX12
		{
			get { return _EX12; }
			set
			{
				_EX12 = value;
				base.SetFieldChanged(CNEX12) ;
			}
		}

		private System.String _EX13;
		/// <summary>
		/// EX13
		/// </summary>
		[EntityAttribute(ColumnName = CNEX13)]
		public System.String EX13
		{
			get { return _EX13; }
			set
			{
				_EX13 = value;
				base.SetFieldChanged(CNEX13) ;
			}
		}

		private System.String _EX14;
		/// <summary>
		/// EX14
		/// </summary>
		[EntityAttribute(ColumnName = CNEX14)]
		public System.String EX14
		{
			get { return _EX14; }
			set
			{
				_EX14 = value;
				base.SetFieldChanged(CNEX14) ;
			}
		}

		private System.String _EX15;
		/// <summary>
		/// EX15
		/// </summary>
		[EntityAttribute(ColumnName = CNEX15)]
		public System.String EX15
		{
			get { return _EX15; }
			set
			{
				_EX15 = value;
				base.SetFieldChanged(CNEX15) ;
			}
		}

		private System.String _EX16;
		/// <summary>
		/// EX16
		/// </summary>
		[EntityAttribute(ColumnName = CNEX16)]
		public System.String EX16
		{
			get { return _EX16; }
			set
			{
				_EX16 = value;
				base.SetFieldChanged(CNEX16) ;
			}
		}

		private System.String _EX17;
		/// <summary>
		/// EX17
		/// </summary>
		[EntityAttribute(ColumnName = CNEX17)]
		public System.String EX17
		{
			get { return _EX17; }
			set
			{
				_EX17 = value;
				base.SetFieldChanged(CNEX17) ;
			}
		}

		private System.String _EX18;
		/// <summary>
		/// EX18
		/// </summary>
		[EntityAttribute(ColumnName = CNEX18)]
		public System.String EX18
		{
			get { return _EX18; }
			set
			{
				_EX18 = value;
				base.SetFieldChanged(CNEX18) ;
			}
		}

		private System.String _EX19;
		/// <summary>
		/// EX19
		/// </summary>
		[EntityAttribute(ColumnName = CNEX19)]
		public System.String EX19
		{
			get { return _EX19; }
			set
			{
				_EX19 = value;
				base.SetFieldChanged(CNEX19) ;
			}
		}

		private System.String _EX20;
		/// <summary>
		/// EX20
		/// </summary>
		[EntityAttribute(ColumnName = CNEX20)]
		public System.String EX20
		{
			get { return _EX20; }
			set
			{
				_EX20 = value;
				base.SetFieldChanged(CNEX20) ;
			}
		}

		#region 字段名的定义
		public const string CNID = "ID";
		public const string CNDANGANID = "DANGANID";
		public const string CNBIANHAO = "BIANHAO";
		public const string CNXINGMING = "XINGMING";
		public const string CNXINGMING_PY = "XINGMING_PY";
		public const string CNEX1 = "EX1";
		public const string CNEX2 = "EX2";
		public const string CNEX3 = "EX3";
		public const string CNEX4 = "EX4";
		public const string CNEX5 = "EX5";
		public const string CNEX6 = "EX6";
		public const string CNEX7 = "EX7";
		public const string CNEX8 = "EX8";
		public const string CNEX9 = "EX9";
		public const string CNEX10 = "EX10";
		public const string CNEX11 = "EX11";
		public const string CNEX12 = "EX12";
		public const string CNEX13 = "EX13";
		public const string CNEX14 = "EX14";
		public const string CNEX15 = "EX15";
		public const string CNEX16 = "EX16";
		public const string CNEX17 = "EX17";
		public const string CNEX18 = "EX18";
		public const string CNEX19 = "EX19";
		public const string CNEX20 = "EX20";
		#endregion

	}
}
