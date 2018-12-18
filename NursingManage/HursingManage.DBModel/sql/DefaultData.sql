/* 菜单数据 */
truncate table T_Menu;

insert into T_Menu(Id,MenuName,Menucaption,ButtonName,Pid) values('00','tsMenuXiTongGuanLi','系统管理','','');
insert into T_Menu(Id,MenuName,Menucaption,ButtonName,Pid) values('0001','tsMYongHuGuanLi','用户管理','','00');
insert into T_Menu(Id,MenuName,Menucaption,ButtonName,Pid) values('0002','tsmKeShiGuanLi','科室管理','','00');
insert into T_Menu(Id,MenuName,Menucaption,ButtonName,Pid) values('0003','tsmiRoleRight','角色权限管理','','00');
insert into T_Menu(Id,MenuName,Menucaption,ButtonName,Pid) values('0004','tsmiChangeUser','更改用户','','00');
insert into T_Menu(Id,MenuName,Menucaption,ButtonName,Pid) values('0005','tsmiChangePassword','修改密码','','00');

insert into T_Menu(Id,MenuName,Menucaption,ButtonName,Pid) values('01','tsmiDangAnGuanLi','档案管理','','');
insert into T_Menu(Id,MenuName,Menucaption,ButtonName,Pid) values('0101','tsmiDangAn','员工档案管理','tsBtnDangAn','01');
--insert into T_Menu(Id,MenuName,Menucaption,ButtonName,Pid) values('0102','tsmiDangAnChaXun','个人档案查询','','01');
--insert into T_Menu(Id,MenuName,Menucaption,ButtonName,Pid) values('0103','tsmiDangAnPeiZhi','档案信息配置','','01');

--insert into T_Menu(Id,MenuName,Menucaption,ButtonName,Pid) values('02','tsmiKaoQinGuanLi','考勤管理','','');
--insert into T_Menu(Id,MenuName,Menucaption,ButtonName,Pid) values('0201','tsmiPaiBan','班次维护','','02');
--insert into T_Menu(Id,MenuName,Menucaption,ButtonName,Pid) values('0202','tsKaoQinShangBao','考勤上报','','02');
--insert into T_Menu(Id,MenuName,Menucaption,ButtonName,Pid) values('0203','tsmiBanCiShenPi','班次审批','','02');
--insert into T_Menu(Id,MenuName,Menucaption,ButtonName,Pid) values('0204','tsmiBanCiShenQing','班次申请','','02');
--insert into T_Menu(Id,MenuName,Menucaption,ButtonName,Pid) values('0205','tsmiShenQingChaXun','申请查询','','02');
--insert into T_Menu(Id,MenuName,Menucaption,ButtonName,Pid) values('0206','tsmiHuShiFenChuang','护士分床','','02');

insert into T_Menu(Id,MenuName,Menucaption,ButtonName,Pid) values('03','tsMenuPeiXunGuanLi','培训管理','','');
insert into T_Menu(Id,MenuName,Menucaption,ButtonName,Pid) values('0301','tsMenuTiKuGuanLi','题库管理','','03');
insert into T_Menu(Id,MenuName,Menucaption,ButtonName,Pid) values('0302','tsMenuShiTiMuBan','试题模板','','03');
insert into T_Menu(Id,MenuName,Menucaption,ButtonName,Pid) values('0303','tsMenuPeiXunJiHua','培训计划','','03');
insert into T_Menu(Id,MenuName,Menucaption,ButtonName,Pid) values('0304','tsMenuJiHuaQueRen','计划确认','','03');
insert into T_Menu(Id,MenuName,Menucaption,ButtonName,Pid) values('0305','tsMenuShiJuanPingFen','试卷评分','','03');
insert into T_Menu(Id,MenuName,Menucaption,ButtonName,Pid) values('0306','tsmPingFenMingXi','人员考试明细','','03');
insert into T_Menu(Id,MenuName,Menucaption,ButtonName,Pid) values('0307','tsmiPingFenHuiZong','科室成绩汇总','','03');
insert into T_Menu(Id,MenuName,Menucaption,ButtonName,Pid) values('0308','tsmiWeiKaoMingXi','未考人员明细','','03');

insert into T_Menu(Id,MenuName,Menucaption,ButtonName,Pid) values('04','tsmiZhiLiangGuanLi','质量管理','','');
insert into T_Menu(Id,MenuName,Menucaption,ButtonName,Pid) values('0401','tsmiZhiLiangBiaoZhun','质量标准','','04');
insert into T_Menu(Id,MenuName,Menucaption,ButtonName,Pid) values('0402','tsmiZhiKongJiHua','质控计划','','04');
insert into T_Menu(Id,MenuName,Menucaption,ButtonName,Pid) values('0403','tsmiZhiKongJianCha','质控检查','','04');
insert into T_Menu(Id,MenuName,Menucaption,ButtonName,Pid) values('0404','tsmiJianChaQueRen','质控检查确认','','04');
insert into T_Menu(Id,MenuName,Menucaption,ButtonName,Pid) values('0405','tsmiZhiKongWenTiHuiZong','质控问题项汇总','','04');
insert into T_Menu(Id,MenuName,Menucaption,ButtonName,Pid) values('0406','tsmiZhiKongJianChaChaXun','质控检查查询','','04');
insert into T_Menu(Id,MenuName,Menucaption,ButtonName,Pid) values('0407','tsmiZhiKongJianCha_KeShi','质控检查（科室）','','04');


insert into T_Menu(Id,MenuName,Menucaption,ButtonName,Pid) values('05','tsMenuHelper','帮助','','');
--insert into T_Menu(Id,MenuName,Menucaption,ButtonName,Pid) values('0501','tsmiAutoUpdate','在线升级','','05');
insert into T_Menu(Id,MenuName,Menucaption,ButtonName,Pid) values('0502','tsmiAbort','关于','','05');
insert into T_Menu(Id,MenuName,Menucaption,ButtonName,Pid) values('0503','tsmiRegisterPringCom','注册打印组件','','05');

insert into T_Menu(Id,MenuName,Menucaption,ButtonName,Pid) values('06','tsmiTongJiByHis','His统计查询','','');
insert into T_Menu(Id,MenuName,Menucaption,ButtonName,Pid) values('0601','tsmiYaChuangTongJi','压疮统计上报表','','06');
insert into T_Menu(Id,MenuName,Menucaption,ButtonName,Pid) values('0602','tsmiDiDaoTongJi','跌倒坠床高危上报表','','06');

insert into T_Menu(Id,MenuName,Menucaption,ButtonName,Pid) values('0603','tsmiRiDongTaiHuiZong','病房一日动态项目汇总','','06');
insert into T_Menu(Id,MenuName,Menucaption,ButtonName,Pid) values('0604','tsmiHuLiGuanLuTongJi','护理各类管路统计','','06');

insert into T_Menu(Id,MenuName,Menucaption,ButtonName,Pid) values('0605','tsmiRiDongTaiHuiZong','病房一日动态项目汇总','','06');
insert into T_Menu(Id,MenuName,Menucaption,ButtonName,Pid) values('0606','tsmiHuLiGuanLuTongJi','护理各类管路统计','','06');


commit;

/*高级搜索列*/
truncate table T_SEARCH_COLUMN;

insert into T_SEARCH_COLUMN (ORDERNO, COLUMNNAME, COLUMNCAPTION, DATATYPE, MODELCLASS)
select 0, 'BIANHAO', '员工编号', 'string', 'HursingManage.DBModel.T_DANGAN' from dual union all
select 1, 'XINGMING', '姓名', 'string', 'HursingManage.DBModel.T_DANGAN' from dual union all
select 2, 'CHUSHENGRIQI', '出生日期', 'string', 'HursingManage.DBModel.T_DANGAN' from dual union all
select 3, 'MINZU', '民族', 'string', 'HursingManage.DBModel.T_DANGAN' from dual union all
select 4, 'HUNFOU', '婚否', 'string', 'HursingManage.DBModel.T_DANGAN' from dual union all
select 5, 'XINGBIE', '性别', 'string', 'HursingManage.DBModel.T_DANGAN' from dual union all
select 6, 'HUSHIZIGEBIANMA', '护师资格编码', 'string', 'HursingManage.DBModel.T_DANGAN' from dual union all
select 7, 'HUSHIZHIYEBIANMA', '护师执业证书编码', 'string', 'HursingManage.DBModel.T_DANGAN' from dual union all
select 8, 'KESHI', '科室名称', 'string', 'HursingManage.DBModel.T_DANGAN' from dual union all


select 0, 'QUESTIONS_TYPE', '试题类型', 'string', 'HursingManage.DBModel.T_QUESTIONS' from dual union all
select 1, 'SIMPLE_LEVEL', '难易程度', 'string', 'HursingManage.DBModel.T_QUESTIONS' from dual union all
select 2, 'PURPOSE', '实体用途', 'string', 'HursingManage.DBModel.T_QUESTIONS' from dual union all
select 3, 'CONTENT', '试题内容', 'string', 'HursingManage.DBModel.T_QUESTIONS' from dual union all

select 0, 'BIANHAO', '试题编号', 'string', 'HursingManage.DBModel.T_SHITI' from dual union all
select 1, 'NANYICHENGDU', '难易程度', 'string', 'HursingManage.DBModel.T_SHITI' from dual union all
select 2, 'LEIXING', '试题类型', 'string', 'HursingManage.DBModel.T_SHITI' from dual union all
select 3, 'FENLEI', '试题分类', 'string', 'HursingManage.DBModel.T_SHITI' from dual union all
select 4, 'NEIRONG', '试题内容', 'string', 'HursingManage.DBModel.T_SHITI' from dual union all

select 0, 'KESHI', '科室名称', 'string', 'HursingManage.DBModel.T_PEIXUNJIHUA' from dual union all
select 1, 'SHIFOUQUEREN', '是否确认', 'string', 'HursingManage.DBModel.T_PEIXUNJIHUA' from dual union all
select 2, 'NEIRONG', '内容', 'string', 'HursingManage.DBModel.T_PEIXUNJIHUA' from dual union all
select 3, 'NEIRONGSHUOMING', '内容说明', 'string', 'HursingManage.DBModel.T_PEIXUNJIHUA' from dual union all
select 4, 'KAISHISHIJIAN', '计划开始时间', 'string', 'HursingManage.DBModel.T_PEIXUNJIHUA' from dual union all
select 5, 'JIESHUSHIJIAN', '计划结束时间', 'string', 'HursingManage.DBModel.T_PEIXUNJIHUA' from dual union all
select 6, 'CHUANGJIANREN', '计划创建人', 'string', 'HursingManage.DBModel.T_PEIXUNJIHUA' from dual union all
select 7, 'ADDTIME', '计划创建时间', 'string', 'HursingManage.DBModel.T_PEIXUNJIHUA' from dual union all

select 0, 'jiHuaMingCheng', '计划名称', 'string', 'HursingManage.DBModel.V_PEIXUNJIHUA_MINGXI' from dual union all
select 1, 'KeShi', '科室名称', 'string', 'HursingManage.DBModel.V_PEIXUNJIHUA_MINGXI' from dual union all
select 2, 'MuBan', '模板名称', 'string', 'HursingManage.DBModel.V_PEIXUNJIHUA_MINGXI' from dual union all
select 3, 'BianHao', '人员编号', 'string', 'HursingManage.DBModel.V_PEIXUNJIHUA_MINGXI' from dual union all
select 4, 'XingMing', '人员姓名', 'string', 'HursingManage.DBModel.V_PEIXUNJIHUA_MINGXI' from dual union all
select 5, 'FenShu', '分数', 'string', 'HursingManage.DBModel.V_PEIXUNJIHUA_MINGXI' from dual union all
select 6, 'PingFenShiJian', '评分时间', 'string', 'HursingManage.DBModel.V_PEIXUNJIHUA_MINGXI' from dual union all

select 0, 'KeShi', '科室', 'string', 'HursingManage.DBModel.V_PEIXUNJIHUA_KESHI' from dual union all
select 1, 'ShiFouQueRen', '是否确认', 'string', 'HursingManage.DBModel.V_PEIXUNJIHUA_KESHI' from dual union all
select 2, 'QueRenRen', '确认人', 'string', 'HursingManage.DBModel.V_PEIXUNJIHUA_KESHI' from dual union all
select 3, 'QueRenShiJian', '确认时间', 'string', 'HursingManage.DBModel.V_PEIXUNJIHUA_KESHI' from dual union all
select 4, 'NeiRong', '内容', 'string', 'HursingManage.DBModel.V_PEIXUNJIHUA_KESHI' from dual union all
select 5, 'PeiXunKaiShi', '培训开始时间', 'string', 'HursingManage.DBModel.V_PEIXUNJIHUA_KESHI' from dual union all
select 6, 'PeiXunJieShu', '培训结束时间', 'string', 'HursingManage.DBModel.V_PEIXUNJIHUA_KESHI' from dual union all
select 7, 'KaoHeKaiShi', '考核开始时间', 'string', 'HursingManage.DBModel.V_PEIXUNJIHUA_KESHI' from dual union all
select 8, 'KaoHeJieShu', '考核结束时间', 'string', 'HursingManage.DBModel.V_PEIXUNJIHUA_KESHI' from dual union all

select 0, 'KeShi', '科室', 'string', 'HursingManage.DBModel.V_PEIXUNJIEGUO_HUIZONG' from dual union all
select 1, 'neirong', '计划内容', 'string', 'HursingManage.DBModel.V_PEIXUNJIEGUO_HUIZONG' from dual union all
select 2, 'KaoShiRenShu', '考试人数', 'string', 'HursingManage.DBModel.V_PEIXUNJIEGUO_HUIZONG' from dual union all
select 3, 'KaoShiZongFen', '考试总分', 'string', 'HursingManage.DBModel.V_PEIXUNJIEGUO_HUIZONG' from dual union all
select 4, 'PingJunFenShu', '平均分数', 'string', 'HursingManage.DBModel.V_PEIXUNJIEGUO_HUIZONG' from dual union all

select 0, 'JiHua', '计划名称', 'string', 'HursingManage.DBModel.V_ZHIKONG_HEGELV' from dual union all
select 1, 'KeShi', '科室名称', 'string', 'HursingManage.DBModel.V_ZHIKONG_HEGELV' from dual union all
select 2, 'BiaoZhunLeiBie', '标准类别名称', 'string', 'HursingManage.DBModel.V_ZHIKONG_HEGELV' from dual union all
select 3, 'BiaoZhunShu', '标准数', 'string', 'HursingManage.DBModel.V_ZHIKONG_HEGELV' from dual union all
select 4, 'WenTiShu', '问题数', 'string', 'HursingManage.DBModel.V_ZHIKONG_HEGELV' from dual union all
select 5, 'HeGeLv', '计划名称', 'string', 'HursingManage.DBModel.V_ZHIKONG_HEGELV' from dual union all
select 6, 'JianChaKaiShiShiJian', '检查时间', 'string', 'HursingManage.DBModel.V_ZHIKONG_HEGELV' from dual union all

select 0, 'KeShi', '科室名称', 'string', 'HursingManage.DBModel.V_PEIXUNJIHUA_MINGXI_WEIKAO' from dual union all
select 1, 'NeiRong', '计划名称', 'string', 'HursingManage.DBModel.V_PEIXUNJIHUA_MINGXI_WEIKAO' from dual union all
select 2, 'BianHao', '编号', 'string', 'HursingManage.DBModel.V_PEIXUNJIHUA_MINGXI_WEIKAO' from dual union all
select 3, 'XingMing', '姓名', 'string', 'HursingManage.DBModel.V_PEIXUNJIHUA_MINGXI_WEIKAO' from dual union all
select 4, 'YuanYin', '原因', 'string', 'HursingManage.DBModel.V_PEIXUNJIHUA_MINGXI_WEIKAO' from dual;

commit;

insert into T_SEARCH_COLUMN (ORDERNO, COLUMNNAME, COLUMNCAPTION, DATATYPE, MODELCLASS)
select 0, 'KESHI', '科室名称', 'string', 'HursingManage.DBModel.V_DANGAN' from dual union all
select 1, 'BIANHAO', '员工编号', 'string', 'HursingManage.DBModel.V_DANGAN' from dual union all
select 2, 'XINGMING', '姓名', 'string', 'HursingManage.DBModel.V_DANGAN' from dual union all
select 3, 'CHUSHENGRIQI', '出生日期', 'string', 'HursingManage.DBModel.V_DANGAN' from dual union all
select 4, 'MINZU', '民族', 'string', 'HursingManage.DBModel.V_DANGAN' from dual union all
select 5, 'HUNFOU', '婚否', 'string', 'HursingManage.DBModel.V_DANGAN' from dual union all
select 6, 'XINGBIE', '性别', 'string', 'HursingManage.DBModel.V_DANGAN' from dual union all
select 7, 'HUSHIZIGEBIANMA', '护师资格编码', 'string', 'HursingManage.DBModel.V_DANGAN' from dual union all
select 8, 'HUSHIZHIYEBIANMA', '护师执业证书编码', 'string', 'HursingManage.DBModel.V_DANGAN' from dual union all
select 9, 'ShouJi', '手机号码', 'string', 'HursingManage.DBModel.V_DANGAN' from dual union all
select 10, 'ZhiCheng', '职称', 'string', 'HursingManage.DBModel.V_DANGAN' from dual union all
select 11, 'NengJi', '能级', 'string', 'HursingManage.DBModel.V_DANGAN' from dual union all
select 12, 'LaiYuanNianXian', '来院年限', 'string', 'HursingManage.DBModel.V_DANGAN' from dual union all
select 12, 'GongZuoNianXian', '工作年限', 'string', 'HursingManage.DBModel.V_DANGAN' from dual union all
select 13, 'RuKeNianXian', '来科年限', 'string', 'HursingManage.DBModel.V_DANGAN' from dual


/*用户表*/
insert into T_User_Info(User_No,User_Name,User_Name_Py,Pwd,User_Type) values('0','管理员','gly','123','管理员');

commit;

/*字典表*/
truncate table T_DICTIONARY;

insert into T_DICTIONARY(DictType,DictCode,DictValue,DictValue_PY,DictValueOrder,IsDelete,Remark) 
values(1000,0,'护士长','hsz',1,0,'用户角色');
insert into T_DICTIONARY(DictType,DictCode,DictValue,DictValue_PY,DictValueOrder,IsDelete,Remark) 
values(1000,0,'护理部','hlb',2,0,'用户角色');

insert into T_DICTIONARY(DictType,DictCode,DictValue,DictValue_PY,DictValueOrder,IsDelete,Remark) 
values(1001,1,'D3BBDC19606A40DAA7DB741CA38C2809','护理部',1,0,'质控权限组Id');
values(1001,2,'CC72EA6D5BED4EBD9D030C60FB421D02','质控护士长',2,0,'质控权限组Id');

insert into T_Dictionary(DictType,DictCode,DictValue,DictValue_Py,DictValueOrder)
select 5001,0,'汉族','hz',1 from dual union all 
select 5001,0,'回族','hz',2 from dual union all 
select 5001,0,'满族','mz',3 from dual union all 
select 5001,0,'壮族','zz',4 from dual union all 
select 5001,0,'维吾尔族','wwez',5 from dual union all 
select 5001,0,'蒙古族','mgz',6 from dual union all 
select 5001,0,'东乡族','dxz',7 from dual union all 
select 5001,0,'乌兹别克族','wcbkz',8 from dual union all 
select 5001,0,'京族','jz',9 from dual union all 
select 5001,0,'仡佬族','glz',10 from dual union all 
select 5001,0,'仫佬族','mlz',11 from dual union all 
select 5001,0,'佤族','wz',12 from dual union all 
select 5001,0,'侗族','dz',13 from dual union all 
select 5001,0,'俄罗斯族','elsz',14 from dual union all 
select 5001,0,'保安族','baz',15 from dual union all 
select 5001,0,'傈僳族','lsz',16 from dual union all 
select 5001,0,'傣族','dz',17 from dual union all 
select 5001,0,'哈尼族','hnz',18 from dual union all 
select 5001,0,'哈萨克族','hskz',19 from dual union all 
select 5001,0,'土家族','tgz',20 from dual union all 
select 5001,0,'土族','tz',21 from dual union all 
select 5001,0,'基诺族','jnz',22 from dual union all 
select 5001,0,'塔吉克族','djkz',23 from dual union all 
select 5001,0,'塔塔尔族','ddez',24 from dual union all 
select 5001,0,'布依族','byz',25 from dual union all 
select 5001,0,'布朗族','blz',26 from dual union all 
select 5001,0,'彝族','yz',27 from dual union all 
select 5001,0,'德昂族','daz',28 from dual union all 
select 5001,0,'怒族','nz',29 from dual union all 
select 5001,0,'拉祜族','lhz',30 from dual union all 
select 5001,0,'撒拉族','slz',31 from dual union all 
select 5001,0,'普米族','pmz',32 from dual union all 
select 5001,0,'景颇族','jpz',33 from dual union all 
select 5001,0,'朝鲜族','cxz',34 from dual union all 
select 5001,0,'柯尔克孜族','kekzz',35 from dual union all 
select 5001,0,'毛南族','mnz',36 from dual union all 
select 5001,0,'水族','sz',37 from dual union all 
select 5001,0,'独龙族','dlz',38 from dual union all 
select 5001,0,'珞巴族','lbz',39 from dual union all 
select 5001,0,'瑶族','yz',40 from dual union all 
select 5001,0,'畲族','sz',41 from dual union all 
select 5001,0,'白族','bz',42 from dual union all 
select 5001,0,'纳西族','nxz',43 from dual union all 
select 5001,0,'羌族','qz',45 from dual union all 
select 5001,0,'苗族','mz',46 from dual union all 
select 5001,0,'裕固族','ygz',47 from dual union all 
select 5001,0,'赫哲族','hzz',48 from dual union all 
select 5001,0,'达斡尔族','dwez',49 from dual union all 
select 5001,0,'鄂伦春族','elcz',50 from dual union all 
select 5001,0,'鄂温克族','ewkz',51 from dual union all 
select 5001,0,'锡伯族','xbz',52 from dual union all 
select 5001,0,'门巴族','mbz',53 from dual union all 
select 5001,0,'阿昌族','acz',54 from dual union all 
select 5001,0,'高山族','gsz',55 from dual union all 
select 5001,0,'黎族','lz',56 from dual

insert into T_DICTIONARY(DictType,DictCode,DictValue,DictValue_PY,DictValueOrder,IsDelete,Remark) 
select 5002,0,'N0','n1',0,0,'能级' from dual union all
select 5002,0,'N1','n1',1,0,'能级' from dual union all
select 5002,0,'N2','n2',2,0,'能级' from dual union all
select 5002,0,'N3','n3',3,0,'能级' from dual union all
select 5002,0,'N4','n4',4,0,'能级' from dual union all
select 5002,0,'护士长','hsz',5,0,'能级' from dual union all
select 5002,0,'其它','qt',6,0,'能级' from dual 

insert into T_DICTIONARY(DictType,DictCode,DictValue,DictValue_PY,DictValueOrder,IsDelete,Remark) 
select 5003,0,'未知','wz',1,0,'婚否' from dual union all
select 5003,0,'已婚','n2',2,0,'婚否' from dual union all
select 5003,0,'未婚','n3',3,0,'婚否' from dual;

insert into T_DICTIONARY(DictType,DictCode,DictValue,DictValue_PY,DictValueOrder,IsDelete,Remark) 
select 5004,0,'中专','zz',1,0,'学历' from dual union all 
select 5004,0,'大专','dz',2,0,'学历' from dual union all 
select 5004,0,'本科','bk',3,0,'学历' from dual union all 
select 5004,0,'研究生','yjs',4,0,'学历' from dual union all 
select 5004,0,'博士','bs',5,0,'学历' from dual union all 
select 5004,0,'其它','qt',6,0,'学历' from dual

insert into T_DICTIONARY(DictType,DictCode,DictValue,DictValue_PY,DictValueOrder,IsDelete,Remark) 
select 5005,0,'在职','zz',1,0,'在职情况' from dual union all
select 5005,0,'离职','lz',2,0,'在职情况' from dual

insert into T_DICTIONARY(DictType,DictCode,DictValue,DictValue_PY,DictValueOrder,IsDelete,Remark) 
select 5006,0,'护士','cjhs',1,0,'职称' from dual union all
select 5006,0,'护师','cjhs',2,0,'职称' from dual union all
select 5006,0,'主管护师','cjhs',3,0,'职称' from dual union all
select 5006,0,'副主任护师','cjhs',4,0,'职称' from dual union all
select 5006,0,'主任护师','zrhs',5,0,'职称' from dual union all

insert into T_DICTIONARY(DictType,DictCode,DictValue,DictValue_PY,DictValueOrder,IsDelete,Remark) 
select 5007,0,'群众','qz',1,0,'政治面貌' from dual union all
select 5007,0,'党员','dy',2,0,'政治面貌' from dual union all
select 5007,0,'预备党员','ybdy',3,0,'政治面貌' from dual union all
select 5007,0,'共青团员','ty',4,0,'政治面貌' from dual union all
select 5007,0,'其它','ty',5,0,'政治面貌' from dual

insert into T_DICTIONARY(DictType,DictCode,DictValue,DictValue_PY,DictValueOrder,IsDelete,Remark)
select 5008,0,'职员','zy',1,0,'职务' from dual union all
select 5008,0,'护士长','hsz',2,0,'职务' from dual union all
select 5008,0,'护理部主任','hlbzr',3,0,'职务' from dual union all
select 5008,0,'护理部副主任','hlbfzr',4,0,'职务' from dual 

insert into T_DICTIONARY(DictType,DictCode,DictValue,DictValue_PY,DictValueOrder,IsDelete,Remark)
select 5009,0,'无','w',0,0,'职务' from dual union all
select 5009,0,'学士','xs',1,0,'职务' from dual union all
select 5009,0,'硕士','ss',2,0,'职务' from dual union all
select 5009,0,'博士','bs',3,0,'职务' from dual 

commit;


/*档案扩展表 */
delete from T_DangAn_PeiZhi where ConfigType=2001;
Insert into T_DangAn_PeiZhi(ConfigType,ConfigKey,ConfigValue)
select 2001,'ExTable1','专业技术职称晋升情况' from dual union all
select 2001,'ExTable2','其它资格证书取得情况' from dual union all
select 2001,'ExTable3','工作经历' from dual union all
select 2001,'ExTable4','学习培训情况' from dual union all
select 2001,'ExTable5','论文专著情况' from dual union all
select 2001,'ExTable6','科研情况' from dual union all
select 2001,'ExTable7','新技术情况' from dual union all
select 2001,'ExTable8','培训考核情况' from dual union all
select 2001,'ExTable9','护理安全记录' from dual union all
select 2001,'ExTable10','奖惩情况' from dual union all
select 2001,'ExTable11','继续教育情况' from dual union all
select 2001,'ExTable12','专业学会情况' from dual union all

truncate table T_DangAn_Table_Config;
--ControlType :   Text = 1,TextComboxBox = 2, TextMultiline = 3, ComboBox = 4, ComboBoxDropDownList = 5,  DateTimePicker = 6
insert into T_DangAn_Table_Config(GroupName,GroupCaption,OrderNo,ControlType,FieldName,FieldCaption,ControlHeight,
       ControlWidht,CaptionControlLen,DataSource,IsRequired)
select 'ExTable1','专业技术职称晋升情况',1,6,'col1','批准时间',30,300,100,'',0 from dual union all
select 'ExTable1','专业技术职称晋升情况',2,1,'col2','技术职称',30,300,100,'',0 from dual union all
select 'ExTable1','专业技术职称晋升情况',3,1,'col3','批准机关',30,300,100,'',0 from dual union all

select 'ExTable2','其它资格证书取得情况',1,1,'col1','序号',    30,300,100,'',0 from dual union all
select 'ExTable2','其它资格证书取得情况',2,1,'col2','证书名称',30,300,100,'',0 from dual union all
select 'ExTable2','其它资格证书取得情况',3,1,'col3','证书编号',30,300,100,'',0 from dual union all
select 'ExTable2','其它资格证书取得情况',4,6,'col4','取得时间',30,300,100,'',0 from dual union all
select 'ExTable2','其它资格证书取得情况',5,3,'col5','备注',    60,600,100,'',0 from dual union all

select 'ExTable3','工作经历',1,1,'col1','起止时间',30,300,100 ,'',0 from dual union all
select 'ExTable3','工作经历',2,1,'col2','单位',30,300,100,'',0 from dual union all
select 'ExTable3','工作经历',3,1,'col3','技术职务',30,300,100,'',0 from dual union all
select 'ExTable3','工作经历',4,6,'col4','职务受聘时间',30,300,100,'',0 from dual union all
select 'ExTable3','工作经历',5,1,'col5','专业',    30,300,100,'',0 from dual union all

select 'ExTable4','学习培训情况',1,1,'col1','起止时间',30,300,100 ,'',0 from dual union all
select 'ExTable4','学习培训情况',2,1,'col2','学习方式',30,300,100,'',0 from dual union all
select 'ExTable4','学习培训情况',3,1,'col3','学习情况',30,300,100,'',0 from dual union all
select 'ExTable4','学习培训情况',4,1,'col4','主办单位',30,300,100,'',0 from dual union all
select 'ExTable4','学习培训情况',5,3,'col5','学习内容',90,600,100,'',0 from dual union all

select 'ExTable5','论文专著情况',1,6,'col1','发表时间',30,300,100 ,'',0 from dual union all
select 'ExTable5','论文专著情况',2,1,'col2','题目',30,300,100,'',0 from dual union all
select 'ExTable5','论文专著情况',3,1,'col3','刊期名称',30,300,100,'',0 from dual union all
select 'ExTable5','论文专著情况',4,1,'col4','获奖情况',30,300,100,'',0 from dual union all

select 'ExTable6','科研情况',1,6,'col1','立项时间',30,300,100,'',0 from dual union all
select 'ExTable6','科研情况',2,1,'col2','科研名称',30,300,100,'',0 from dual union all
select 'ExTable6','科研情况',3,1,'col3','第一年',30,300,100,'',0 from dual union all
select 'ExTable6','科研情况',4,1,'col4','第二年',30,300,100,'',0 from dual union all
select 'ExTable6','科研情况',5,1,'col5','第三年',30,300,100,'',0 from dual union all
select 'ExTable6','科研情况',6,1,'col5','获奖情况',30,300,100,'',0 from dual union all
select 'ExTable6','科研情况',7,3,'col5','备注',90,600,100,'',0 from dual union all

select 'ExTable7','开展新技术情况',1,6,'col1','开展时间',30,300,100 ,'',0 from dual union all
select 'ExTable7','开展新技术情况',2,1,'col2','新技术名称',30,300,100,'',0 from dual union all
select 'ExTable7','开展新技术情况',3,1,'col3','第一年',30,300,100,'',0 from dual union all
select 'ExTable7','开展新技术情况',4,1,'col4','第二年',30,300,100,'',0 from dual union all
select 'ExTable7','开展新技术情况',5,1,'col5','第三年',30,300,100,'',0 from dual union all
select 'ExTable7','开展新技术情况',6,1,'col6','第四年',30,300,100,'',0 from dual union all
select 'ExTable7','开展新技术情况',7,1,'col7','第五年',30,300,100,'',0 from dual union all
select 'ExTable7','开展新技术情况',8,3,'col8','备注',90,600,100,'',0 from dual union all

select 'ExTable8','培训考核情况',1,6,'col1','时间',30,300,100 ,'',0 from dual union all
select 'ExTable8','培训考核情况',2,1,'col2','培训考试、考核内容',30,300,100 ,'',0 from dual union all
select 'ExTable8','培训考核情况',3,1,'col3','方式',30,300,100,'',0 from dual union all
select 'ExTable8','培训考核情况',4,1,'col4','结果',30,300,100,'',0 from dual union all
select 'ExTable8','培训考核情况',5,3,'col5','备注',90,600,100,'',0 from dual union all

select 'ExTable9','护理安全记录',1,6,'col1','时间',30,300,100 ,'',0 from dual union all
select 'ExTable9','护理安全记录',2,1,'col2','时间性质',30,300,100 ,'',0 from dual union all
select 'ExTable9','护理安全记录',3,3,'col3','情况摘要',120,600,100,'',0 from dual union all

select 'ExTable10','奖惩情况',1,6,'col1','时间',30,300,100 ,'',0 from dual union all
select 'ExTable10','奖惩情况',2,1,'col2','奖惩单位',30,300,100 ,'',0 from dual union all
select 'ExTable10','奖惩情况',3,3,'col3','奖惩情况',120,600,100,'',0 from dual union all

select 'ExTable11','继续教育情况',1,6,'col1','年度',30,300,100 ,'',0 from dual union all
select 'ExTable11','继续教育情况',2,1,'col2','一类学分',30,300,100 ,'',0 from dual union all
select 'ExTable11','继续教育情况',3,1,'col3','二类学分',30,300,100 ,'',0 from dual union all
select 'ExTable11','继续教育情况',4,1,'col4','三类学分',30,300,100 ,'',0 from dual union all
select 'ExTable11','继续教育情况',5,1,'col5','合计',30,300,100 ,'',0 from dual union all
select 'ExTable11','继续教育情况',6,1,'col6','验证结果',30,300,100 ,'',0 from dual union all
select 'ExTable11','继续教育情况',7,3,'col7','备注',120,600,100,'',0 from dual union all

select 'ExTable12','专业学会情况',1,6,'col1','时间',30,300,100 ,'',0 from dual union all
select 'ExTable12','专业学会情况',2,1,'col2','学会名称',30,300,100 ,'',0 from dual union all
select 'ExTable12','专业学会情况',3,3,'col3','任职情况',90,600,100,'',0 from dual

commit;
