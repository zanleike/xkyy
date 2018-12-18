using System;
using Framework.Entitys;

namespace HursingManage.DBModel
{
	public partial class T_DANGAN : EntityBase
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

		private System.String _CHUSHENGRIQI;
		/// <summary>
		/// CHUSHENGRIQI
		/// </summary>
		[EntityAttribute(ColumnName = CNCHUSHENGRIQI)]
		public System.String CHUSHENGRIQI
		{
			get { return _CHUSHENGRIQI; }
			set
			{
				_CHUSHENGRIQI = value;
				base.SetFieldChanged(CNCHUSHENGRIQI) ;
			}
		}

		private System.String _MINZU;
		/// <summary>
		/// MINZU
		/// </summary>
		[EntityAttribute(ColumnName = CNMINZU)]
		public System.String MINZU
		{
			get { return _MINZU; }
			set
			{
				_MINZU = value;
				base.SetFieldChanged(CNMINZU) ;
			}
		}

		private System.String _HUNFOU;
		/// <summary>
		/// HUNFOU
		/// </summary>
		[EntityAttribute(ColumnName = CNHUNFOU)]
		public System.String HUNFOU
		{
			get { return _HUNFOU; }
			set
			{
				_HUNFOU = value;
				base.SetFieldChanged(CNHUNFOU) ;
			}
		}

		private System.String _ZHENGZHIMIANMAO;
		/// <summary>
		/// ZHENGZHIMIANMAO
		/// </summary>
		[EntityAttribute(ColumnName = CNZHENGZHIMIANMAO)]
		public System.String ZHENGZHIMIANMAO
		{
			get { return _ZHENGZHIMIANMAO; }
			set
			{
				_ZHENGZHIMIANMAO = value;
				base.SetFieldChanged(CNZHENGZHIMIANMAO) ;
			}
		}

		private System.String _SHENFENZHENG;
		/// <summary>
		/// SHENFENZHENG
		/// </summary>
		[EntityAttribute(ColumnName = CNSHENFENZHENG)]
		public System.String SHENFENZHENG
		{
			get { return _SHENFENZHENG; }
			set
			{
				_SHENFENZHENG = value;
				base.SetFieldChanged(CNSHENFENZHENG) ;
			}
		}

		private System.String _JIATINGDIZHI;
		/// <summary>
		/// JIATINGDIZHI
		/// </summary>
		[EntityAttribute(ColumnName = CNJIATINGDIZHI)]
		public System.String JIATINGDIZHI
		{
			get { return _JIATINGDIZHI; }
			set
			{
				_JIATINGDIZHI = value;
				base.SetFieldChanged(CNJIATINGDIZHI) ;
			}
		}

		private System.String _JIATINGDIANHUA;
		/// <summary>
		/// JIATINGDIANHUA
		/// </summary>
		[EntityAttribute(ColumnName = CNJIATINGDIANHUA)]
		public System.String JIATINGDIANHUA
		{
			get { return _JIATINGDIANHUA; }
			set
			{
				_JIATINGDIANHUA = value;
				base.SetFieldChanged(CNJIATINGDIANHUA) ;
			}
		}

		private System.String _SHOUJI;
		/// <summary>
		/// SHOUJI
		/// </summary>
		[EntityAttribute(ColumnName = CNSHOUJI)]
		public System.String SHOUJI
		{
			get { return _SHOUJI; }
			set
			{
				_SHOUJI = value;
				base.SetFieldChanged(CNSHOUJI) ;
			}
		}

		private System.String _DIANZIYOUJIAN;
		/// <summary>
		/// DIANZIYOUJIAN
		/// </summary>
		[EntityAttribute(ColumnName = CNDIANZIYOUJIAN)]
		public System.String DIANZIYOUJIAN
		{
			get { return _DIANZIYOUJIAN; }
			set
			{
				_DIANZIYOUJIAN = value;
				base.SetFieldChanged(CNDIANZIYOUJIAN) ;
			}
		}

		private System.String _ZHIWU;
		/// <summary>
		/// ZHIWU
		/// </summary>
		[EntityAttribute(ColumnName = CNZHIWU)]
		public System.String ZHIWU
		{
			get { return _ZHIWU; }
			set
			{
				_ZHIWU = value;
				base.SetFieldChanged(CNZHIWU) ;
			}
		}

		private System.String _ZHICHENG;
		/// <summary>
		/// ZHICHENG
		/// </summary>
		[EntityAttribute(ColumnName = CNZHICHENG)]
		public System.String ZHICHENG
		{
			get { return _ZHICHENG; }
			set
			{
				_ZHICHENG = value;
				base.SetFieldChanged(CNZHICHENG) ;
			}
		}

		private System.String _GONGZUOSHIJIAN;
		/// <summary>
		/// GONGZUOSHIJIAN
		/// </summary>
		[EntityAttribute(ColumnName = CNGONGZUOSHIJIAN)]
		public System.String GONGZUOSHIJIAN
		{
			get { return _GONGZUOSHIJIAN; }
			set
			{
				_GONGZUOSHIJIAN = value;
				base.SetFieldChanged(CNGONGZUOSHIJIAN) ;
			}
		}

		private System.String _LAIYUANSHIJIAN;
		/// <summary>
		/// LAIYUANSHIJIAN
		/// </summary>
		[EntityAttribute(ColumnName = CNLAIYUANSHIJIAN)]
		public System.String LAIYUANSHIJIAN
		{
			get { return _LAIYUANSHIJIAN; }
			set
			{
				_LAIYUANSHIJIAN = value;
				base.SetFieldChanged(CNLAIYUANSHIJIAN) ;
			}
		}

		private System.String _LIYUANSHIJIAN;
		/// <summary>
		/// LIYUANSHIJIAN
		/// </summary>
		[EntityAttribute(ColumnName = CNLIYUANSHIJIAN)]
		public System.String LIYUANSHIJIAN
		{
			get { return _LIYUANSHIJIAN; }
			set
			{
				_LIYUANSHIJIAN = value;
				base.SetFieldChanged(CNLIYUANSHIJIAN) ;
			}
		}

		private System.String _SHIFOUZAIZHI;
		/// <summary>
		/// SHIFOUZAIZHI
		/// </summary>
		[EntityAttribute(ColumnName = CNSHIFOUZAIZHI)]
		public System.String SHIFOUZAIZHI
		{
			get { return _SHIFOUZAIZHI; }
			set
			{
				_SHIFOUZAIZHI = value;
				base.SetFieldChanged(CNSHIFOUZAIZHI) ;
			}
		}

		private System.String _KESHIXINGZHI;
		/// <summary>
		/// KESHIXINGZHI
		/// </summary>
		[EntityAttribute(ColumnName = CNKESHIXINGZHI)]
		public System.String KESHIXINGZHI
		{
			get { return _KESHIXINGZHI; }
			set
			{
				_KESHIXINGZHI = value;
				base.SetFieldChanged(CNKESHIXINGZHI) ;
			}
		}

		private System.String _XUELI;
		/// <summary>
		/// XUELI
		/// </summary>
		[EntityAttribute(ColumnName = CNXUELI)]
		public System.String XUELI
		{
			get { return _XUELI; }
			set
			{
				_XUELI = value;
				base.SetFieldChanged(CNXUELI) ;
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

		private System.String _USERID;
		/// <summary>
		/// USERID
		/// </summary>
		[EntityAttribute(ColumnName = CNUSERID)]
		public System.String USERID
		{
			get { return _USERID; }
			set
			{
				_USERID = value;
				base.SetFieldChanged(CNUSERID) ;
			}
		}

		private System.Decimal _ISDEL;
		/// <summary>
		/// ISDEL
		/// </summary>
		[EntityAttribute(ColumnName = CNISDEL)]
		public System.Decimal ISDEL
		{
			get { return _ISDEL; }
			set
			{
				_ISDEL = value;
				base.SetFieldChanged(CNISDEL) ;
			}
		}

		private System.String _NENGJI;
		/// <summary>
		/// NENGJI
		/// </summary>
		[EntityAttribute(ColumnName = CNNENGJI)]
		public System.String NENGJI
		{
			get { return _NENGJI; }
			set
			{
				_NENGJI = value;
				base.SetFieldChanged(CNNENGJI) ;
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

		private System.String _XINGBIE;
		/// <summary>
		/// XINGBIE
		/// </summary>
		[EntityAttribute(ColumnName = CNXINGBIE)]
		public System.String XINGBIE
		{
			get { return _XINGBIE; }
			set
			{
				_XINGBIE = value;
				base.SetFieldChanged(CNXINGBIE) ;
			}
		}

		private System.String _HUSHIZIGEBIANMA;
		/// <summary>
		/// HUSHIZIGEBIANMA
		/// </summary>
		[EntityAttribute(ColumnName = CNHUSHIZIGEBIANMA)]
		public System.String HUSHIZIGEBIANMA
		{
			get { return _HUSHIZIGEBIANMA; }
			set
			{
				_HUSHIZIGEBIANMA = value;
				base.SetFieldChanged(CNHUSHIZIGEBIANMA) ;
			}
		}

		private System.String _HUSHIZIGESHIJIAN;
		/// <summary>
		/// HUSHIZIGESHIJIAN
		/// </summary>
		[EntityAttribute(ColumnName = CNHUSHIZIGESHIJIAN)]
		public System.String HUSHIZIGESHIJIAN
		{
			get { return _HUSHIZIGESHIJIAN; }
			set
			{
				_HUSHIZIGESHIJIAN = value;
				base.SetFieldChanged(CNHUSHIZIGESHIJIAN) ;
			}
		}

		private System.String _HUSHIZHIYEBIANMA;
		/// <summary>
		/// HUSHIZHIYEBIANMA
		/// </summary>
		[EntityAttribute(ColumnName = CNHUSHIZHIYEBIANMA)]
		public System.String HUSHIZHIYEBIANMA
		{
			get { return _HUSHIZHIYEBIANMA; }
			set
			{
				_HUSHIZHIYEBIANMA = value;
				base.SetFieldChanged(CNHUSHIZHIYEBIANMA) ;
			}
		}

		private System.String _HUSHIZHIYESHIJIAN;
		/// <summary>
		/// HUSHIZHIYESHIJIAN
		/// </summary>
		[EntityAttribute(ColumnName = CNHUSHIZHIYESHIJIAN)]
		public System.String HUSHIZHIYESHIJIAN
		{
			get { return _HUSHIZHIYESHIJIAN; }
			set
			{
				_HUSHIZHIYESHIJIAN = value;
				base.SetFieldChanged(CNHUSHIZHIYESHIJIAN) ;
			}
		}

		private System.String _BIYEXUEXIAO;
		/// <summary>
		/// BIYEXUEXIAO
		/// </summary>
		[EntityAttribute(ColumnName = CNBIYEXUEXIAO)]
		public System.String BIYEXUEXIAO
		{
			get { return _BIYEXUEXIAO; }
			set
			{
				_BIYEXUEXIAO = value;
				base.SetFieldChanged(CNBIYEXUEXIAO) ;
			}
		}

		private System.String _XUEWEI;
		/// <summary>
		/// XUEWEI
		/// </summary>
		[EntityAttribute(ColumnName = CNXUEWEI)]
		public System.String XUEWEI
		{
			get { return _XUEWEI; }
			set
			{
				_XUEWEI = value;
				base.SetFieldChanged(CNXUEWEI) ;
			}
		}

		private System.String _CHUSHIXUELI;
		/// <summary>
		/// CHUSHIXUELI
		/// </summary>
		[EntityAttribute(ColumnName = CNCHUSHIXUELI)]
		public System.String CHUSHIXUELI
		{
			get { return _CHUSHIXUELI; }
			set
			{
				_CHUSHIXUELI = value;
				base.SetFieldChanged(CNCHUSHIXUELI) ;
			}
		}

		private System.String _CHUSHIBIYEYUANXIAO;
		/// <summary>
		/// CHUSHIBIYEYUANXIAO
		/// </summary>
		[EntityAttribute(ColumnName = CNCHUSHIBIYEYUANXIAO)]
		public System.String CHUSHIBIYEYUANXIAO
		{
			get { return _CHUSHIBIYEYUANXIAO; }
			set
			{
				_CHUSHIBIYEYUANXIAO = value;
				base.SetFieldChanged(CNCHUSHIBIYEYUANXIAO) ;
			}
		}

		private System.String _RUKESHIJIAN;
		/// <summary>
		/// RUKESHIJIAN
		/// </summary>
		[EntityAttribute(ColumnName = CNRUKESHIJIAN)]
		public System.String RUKESHIJIAN
		{
			get { return _RUKESHIJIAN; }
			set
			{
				_RUKESHIJIAN = value;
				base.SetFieldChanged(CNRUKESHIJIAN) ;
			}
		}

		private System.String _HIS_SYS_NAME;
		/// <summary>
		/// HIS_SYS_NAME
		/// </summary>
		[EntityAttribute(ColumnName = CNHIS_SYS_NAME)]
		public System.String HIS_SYS_NAME
		{
			get { return _HIS_SYS_NAME; }
			set
			{
				_HIS_SYS_NAME = value;
				base.SetFieldChanged(CNHIS_SYS_NAME) ;
			}
		}

        private System.Byte[] _Pic;
        /// <summary>
        /// Pic
        /// </summary>
        [EntityAttribute(ColumnName = CNPic)]
        public System.Byte[] PIC
        {
            get { return _Pic; }
            set
            {
                _Pic = value;
                base.SetFieldChanged(CNPic);
            }
        }

        private System.String _JIGUAN;
        /// <summary>
        /// JIGUAN
        /// </summary>
        [EntityAttribute(ColumnName = CNJIGUAN)]
        public string JIGUAN
        {
            get { return _JIGUAN; }
            set
            {
                _JIGUAN = value;
                base.SetFieldChanged(CNJIGUAN);
            }
        }

        private System.String _ZHUANYE;
        /// <summary>
        /// ZHUANYE
        /// </summary>
        [EntityAttribute(ColumnName = CNZHUANYE)]
        public string ZHUANYE
        {
            get { return _ZHUANYE; }
            set
            {
                _ZHUANYE = value;
                base.SetFieldChanged(CNZHUANYE);
            }
        }

        private System.String _JIANKANGZHUANGKUANG;
        /// <summary>
        /// JIANKANGZHUANGKUANG
        /// </summary>
        [EntityAttribute(ColumnName = CNJIANKANGZHUANGKUANG)]
        public string JIANKANGZHUANGKUANG
        {
            get { return _JIANKANGZHUANGKUANG; }
            set
            {
                _JIANKANGZHUANGKUANG = value;
                base.SetFieldChanged(CNJIANKANGZHUANGKUANG);
            }
        }

        #region 字段名的定义
        public const string CNID = "ID";
		public const string CNBIANHAO = "BIANHAO";
		public const string CNXINGMING = "XINGMING";
		public const string CNXINGMING_PY = "XINGMING_PY";
		public const string CNCHUSHENGRIQI = "CHUSHENGRIQI";
		public const string CNMINZU = "MINZU";
		public const string CNHUNFOU = "HUNFOU";
		public const string CNZHENGZHIMIANMAO = "ZHENGZHIMIANMAO";
		public const string CNSHENFENZHENG = "SHENFENZHENG";
		public const string CNJIATINGDIZHI = "JIATINGDIZHI";
		public const string CNJIATINGDIANHUA = "JIATINGDIANHUA";
		public const string CNSHOUJI = "SHOUJI";
		public const string CNDIANZIYOUJIAN = "DIANZIYOUJIAN";
		public const string CNZHIWU = "ZHIWU";
		public const string CNZHICHENG = "ZHICHENG";
		public const string CNGONGZUOSHIJIAN = "GONGZUOSHIJIAN";
		public const string CNLAIYUANSHIJIAN = "LAIYUANSHIJIAN";
		public const string CNLIYUANSHIJIAN = "LIYUANSHIJIAN";
		public const string CNSHIFOUZAIZHI = "SHIFOUZAIZHI";
		public const string CNKESHIXINGZHI = "KESHIXINGZHI";
		public const string CNXUELI = "XUELI";
		public const string CNADDTIME = "ADDTIME";
		public const string CNLASTTIME = "LASTTIME";
		public const string CNPC = "PC";
		public const string CNOPERATORID = "OPERATORID";
		public const string CNUSERID = "USERID";
		public const string CNISDEL = "ISDEL";
		public const string CNNENGJI = "NENGJI";
		public const string CNKESHIID = "KESHIID";
		public const string CNKESHI = "KESHI";
		public const string CNXINGBIE = "XINGBIE";
		public const string CNHUSHIZIGEBIANMA = "HUSHIZIGEBIANMA";
		public const string CNHUSHIZIGESHIJIAN = "HUSHIZIGESHIJIAN";
		public const string CNHUSHIZHIYEBIANMA = "HUSHIZHIYEBIANMA";
		public const string CNHUSHIZHIYESHIJIAN = "HUSHIZHIYESHIJIAN";
		public const string CNBIYEXUEXIAO = "BIYEXUEXIAO";
		public const string CNXUEWEI = "XUEWEI";
		public const string CNCHUSHIXUELI = "CHUSHIXUELI";
		public const string CNCHUSHIBIYEYUANXIAO = "CHUSHIBIYEYUANXIAO";
		public const string CNRUKESHIJIAN = "RUKESHIJIAN";
		public const string CNHIS_SYS_NAME = "HIS_SYS_NAME";
        public const string CNPic = "PIC";
        public const string CNJIGUAN = "JIGUAN";
        public const string CNZHUANYE = "ZHUANYE";
        public const string CNJIANKANGZHUANGKUANG = "JIANKANGZHUANGKUANG";
        #endregion

    }
}
