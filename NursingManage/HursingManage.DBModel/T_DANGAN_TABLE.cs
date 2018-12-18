using System;
using Framework.Entitys;

namespace HursingManage.DBModel
{
	public partial class T_DANGAN_TABLE : EntityBase
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

		private System.String _GROUPNAME;
		/// <summary>
		/// GROUPNAME
		/// </summary>
		[EntityAttribute(ColumnName = CNGROUPNAME)]
		public System.String GROUPNAME
		{
			get { return _GROUPNAME; }
			set
			{
				_GROUPNAME = value;
				base.SetFieldChanged(CNGROUPNAME) ;
			}
		}

		private System.String _GROUPCAPTION;
		/// <summary>
		/// GROUPCAPTION
		/// </summary>
		[EntityAttribute(ColumnName = CNGROUPCAPTION)]
		public System.String GROUPCAPTION
		{
			get { return _GROUPCAPTION; }
			set
			{
				_GROUPCAPTION = value;
				base.SetFieldChanged(CNGROUPCAPTION) ;
			}
		}

		private System.String _COL1;
		/// <summary>
		/// COL1
		/// </summary>
		[EntityAttribute(ColumnName = CNCOL1)]
		public System.String COL1
		{
			get { return _COL1; }
			set
			{
				_COL1 = value;
				base.SetFieldChanged(CNCOL1) ;
			}
		}

		private System.String _COL2;
		/// <summary>
		/// COL2
		/// </summary>
		[EntityAttribute(ColumnName = CNCOL2)]
		public System.String COL2
		{
			get { return _COL2; }
			set
			{
				_COL2 = value;
				base.SetFieldChanged(CNCOL2) ;
			}
		}

		private System.String _COL3;
		/// <summary>
		/// COL3
		/// </summary>
		[EntityAttribute(ColumnName = CNCOL3)]
		public System.String COL3
		{
			get { return _COL3; }
			set
			{
				_COL3 = value;
				base.SetFieldChanged(CNCOL3) ;
			}
		}

		private System.String _COL4;
		/// <summary>
		/// COL4
		/// </summary>
		[EntityAttribute(ColumnName = CNCOL4)]
		public System.String COL4
		{
			get { return _COL4; }
			set
			{
				_COL4 = value;
				base.SetFieldChanged(CNCOL4) ;
			}
		}

		private System.String _COL5;
		/// <summary>
		/// COL5
		/// </summary>
		[EntityAttribute(ColumnName = CNCOL5)]
		public System.String COL5
		{
			get { return _COL5; }
			set
			{
				_COL5 = value;
				base.SetFieldChanged(CNCOL5) ;
			}
		}

		private System.String _COL6;
		/// <summary>
		/// COL6
		/// </summary>
		[EntityAttribute(ColumnName = CNCOL6)]
		public System.String COL6
		{
			get { return _COL6; }
			set
			{
				_COL6 = value;
				base.SetFieldChanged(CNCOL6) ;
			}
		}

		private System.String _COL7;
		/// <summary>
		/// COL7
		/// </summary>
		[EntityAttribute(ColumnName = CNCOL7)]
		public System.String COL7
		{
			get { return _COL7; }
			set
			{
				_COL7 = value;
				base.SetFieldChanged(CNCOL7) ;
			}
		}

		private System.String _COL8;
		/// <summary>
		/// COL8
		/// </summary>
		[EntityAttribute(ColumnName = CNCOL8)]
		public System.String COL8
		{
			get { return _COL8; }
			set
			{
				_COL8 = value;
				base.SetFieldChanged(CNCOL8) ;
			}
		}

		private System.String _COL9;
		/// <summary>
		/// COL9
		/// </summary>
		[EntityAttribute(ColumnName = CNCOL9)]
		public System.String COL9
		{
			get { return _COL9; }
			set
			{
				_COL9 = value;
				base.SetFieldChanged(CNCOL9) ;
			}
		}

		private System.String _COL10;
		/// <summary>
		/// COL10
		/// </summary>
		[EntityAttribute(ColumnName = CNCOL10)]
		public System.String COL10
		{
			get { return _COL10; }
			set
			{
				_COL10 = value;
				base.SetFieldChanged(CNCOL10) ;
			}
		}

		private System.String _COL11;
		/// <summary>
		/// COL11
		/// </summary>
		[EntityAttribute(ColumnName = CNCOL11)]
		public System.String COL11
		{
			get { return _COL11; }
			set
			{
				_COL11 = value;
				base.SetFieldChanged(CNCOL11) ;
			}
		}

		private System.String _COL12;
		/// <summary>
		/// COL12
		/// </summary>
		[EntityAttribute(ColumnName = CNCOL12)]
		public System.String COL12
		{
			get { return _COL12; }
			set
			{
				_COL12 = value;
				base.SetFieldChanged(CNCOL12) ;
			}
		}

		private System.String _COL13;
		/// <summary>
		/// COL13
		/// </summary>
		[EntityAttribute(ColumnName = CNCOL13)]
		public System.String COL13
		{
			get { return _COL13; }
			set
			{
				_COL13 = value;
				base.SetFieldChanged(CNCOL13) ;
			}
		}

		private System.String _COL14;
		/// <summary>
		/// COL14
		/// </summary>
		[EntityAttribute(ColumnName = CNCOL14)]
		public System.String COL14
		{
			get { return _COL14; }
			set
			{
				_COL14 = value;
				base.SetFieldChanged(CNCOL14) ;
			}
		}

		private System.String _COL15;
		/// <summary>
		/// COL15
		/// </summary>
		[EntityAttribute(ColumnName = CNCOL15)]
		public System.String COL15
		{
			get { return _COL15; }
			set
			{
				_COL15 = value;
				base.SetFieldChanged(CNCOL15) ;
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

        private System.Byte[] _PIC;
        /// <summary>
        /// Pic
        /// </summary>
        [EntityAttribute(ColumnName = CNPIC)]
        public System.Byte[] PIC
        {
            get { return _PIC; }
            set
            {
                _PIC = value;
                base.SetFieldChanged(CNPIC);
            }
        }

        #region 字段名的定义
        public const string CNID = "ID";
		public const string CNDANGANID = "DANGANID";
		public const string CNGROUPNAME = "GROUPNAME";
		public const string CNGROUPCAPTION = "GROUPCAPTION";
		public const string CNCOL1 = "COL1";
		public const string CNCOL2 = "COL2";
		public const string CNCOL3 = "COL3";
		public const string CNCOL4 = "COL4";
		public const string CNCOL5 = "COL5";
		public const string CNCOL6 = "COL6";
		public const string CNCOL7 = "COL7";
		public const string CNCOL8 = "COL8";
		public const string CNCOL9 = "COL9";
		public const string CNCOL10 = "COL10";
		public const string CNCOL11 = "COL11";
		public const string CNCOL12 = "COL12";
		public const string CNCOL13 = "COL13";
		public const string CNCOL14 = "COL14";
		public const string CNCOL15 = "COL15";
		public const string CNADDTIME = "ADDTIME";
		public const string CNLASTTIME = "LASTTIME";
		public const string CNPC = "PC";
		public const string CNOPERATORID = "OPERATORID";
        public const string CNPIC = "PIC";
		#endregion

	}
}
