/*
	2017.4.6 修改了培训考核模块的试题模板外的所有业务逻辑；
	2017.5.3 修改了质控功能的表结构；

*/
create table T_DANGAN
(
  id              VARCHAR2(38) default sys_guid() not null,
  bianhao         VARCHAR2(20),
  xingming        VARCHAR2(20),
  xingming_py     VARCHAR2(20),
  chushengriqi    VARCHAR2(20) default '1980-01-01',
  minzu           VARCHAR2(50),
  hunfou          VARCHAR2(10) default '未知',
  zhengzhimianmao VARCHAR2(50),
  shenfenzheng    VARCHAR2(18),
  jiatingdizhi    VARCHAR2(20),
  jiatingdianhua  VARCHAR2(20),
  shouji          VARCHAR2(20),
  dianziyoujian   VARCHAR2(100),
  zhiwu           VARCHAR2(50),
  zhicheng        VARCHAR2(50),
  gongzuoshijian  VARCHAR2(20) default '1970-01-01',
  laiyuanshijian  VARCHAR2(20),
  liyuanshijian   VARCHAR2(20),
  shifouzaizhi    VARCHAR2(10) default '在职',
  keshixingzhi    VARCHAR2(20),
  xueli           VARCHAR2(50),
  addtime         TIMESTAMP(6) default sysdate,
  lasttime        TIMESTAMP(6) default sysdate,
  pc              VARCHAR2(100),
  operatorid      VARCHAR2(38),
  userid          VARCHAR2(38),
  isdel           NUMBER(1) default 0,
  nengji          VARCHAR2(20),
  keshiid         VARCHAR2(38),
  keshi           NVARCHAR2(20)
)
;
comment on table T_DANGAN
  is '护士档案';
comment on column T_DANGAN.bianhao
  is '员工编号';
comment on column T_DANGAN.xingming
  is '姓名';
comment on column T_DANGAN.xingming_py
  is '姓名助记码';
comment on column T_DANGAN.chushengriqi
  is '出生日期';
comment on column T_DANGAN.minzu
  is '民族';
comment on column T_DANGAN.hunfou
  is '婚否';
comment on column T_DANGAN.zhengzhimianmao
  is '政治面貌';
comment on column T_DANGAN.shenfenzheng
  is '身份证';
comment on column T_DANGAN.jiatingdizhi
  is '家庭地址';
comment on column T_DANGAN.jiatingdianhua
  is '家庭电话';
comment on column T_DANGAN.shouji
  is '手机号码';
comment on column T_DANGAN.dianziyoujian
  is '电子邮件';
comment on column T_DANGAN.zhiwu
  is '职务';
comment on column T_DANGAN.zhicheng
  is '职称';
comment on column T_DANGAN.gongzuoshijian
  is '工作时间';
comment on column T_DANGAN.laiyuanshijian
  is '来院时间';
comment on column T_DANGAN.liyuanshijian
  is '离院时间';
comment on column T_DANGAN.shifouzaizhi
  is '是否在职';
comment on column T_DANGAN.keshixingzhi
  is '科室性质,1、门诊 2、住院  3、住院门诊  4、其他';
comment on column T_DANGAN.xueli
  is '学历';
comment on column T_DANGAN.userid
  is '用户Id';
comment on column T_DANGAN.isdel
  is '是否已删除';
comment on column T_DANGAN.nengji
  is '能级，N1,N2,N3';
comment on column T_DANGAN.keshiid
  is '科室Id';
comment on column T_DANGAN.keshi
  is '科室名称';
alter table T_DANGAN
  add constraint PK_DANGAN primary key (ID);

create table T_DANGAN_EX
(
  id          VARCHAR2(38) default sys_guid() not null,
  danganid    VARCHAR2(38),
  bianhao     VARCHAR2(20),
  xingming    VARCHAR2(20),
  xingming_py VARCHAR2(20),
  ex1         VARCHAR2(500),
  ex2         VARCHAR2(500),
  ex3         VARCHAR2(500),
  ex4         VARCHAR2(500),
  ex5         VARCHAR2(500),
  ex6         VARCHAR2(500),
  ex7         VARCHAR2(500),
  ex8         VARCHAR2(500),
  ex9         VARCHAR2(500),
  ex10        VARCHAR2(500),
  ex11        VARCHAR2(500),
  ex12        VARCHAR2(500),
  ex13        VARCHAR2(500),
  ex14        VARCHAR2(500),
  ex15        VARCHAR2(500),
  ex16        VARCHAR2(500),
  ex17        VARCHAR2(500),
  ex18        VARCHAR2(500),
  ex19        VARCHAR2(500),
  ex20        VARCHAR2(500)
)
;
comment on table T_DANGAN_EX
  is '护士档案扩展表';
comment on column T_DANGAN_EX.danganid
  is '档案ID';
comment on column T_DANGAN_EX.bianhao
  is '工号(编号)';
comment on column T_DANGAN_EX.xingming
  is '姓名';
comment on column T_DANGAN_EX.xingming_py
  is '助记码';
alter table T_DANGAN_EX
  add constraint PK_DANGAN_EX primary key (ID);
create table T_DANGAN_EX_PEIZHI
(
  id             VARCHAR2(38) default sys_guid() not null,
  column_no      INTEGER,
  colunm_caption VARCHAR2(20),
  control_type   VARCHAR2(20),
  value_type     VARCHAR2(20)
)
;
comment on table T_DANGAN_EX_PEIZHI
  is '档案扩展配置';
comment on column T_DANGAN_EX_PEIZHI.column_no
  is '扩展字段编号';
comment on column T_DANGAN_EX_PEIZHI.colunm_caption
  is '列标题';
comment on column T_DANGAN_EX_PEIZHI.control_type
  is '控件类型';
comment on column T_DANGAN_EX_PEIZHI.value_type
  is '值类型';
alter table T_DANGAN_EX_PEIZHI
  add constraint PK_DANGAN_EX_PEIZHI primary key (ID);


create table T_DICTIONARY
(
  id             VARCHAR2(32) default sys_guid() not null,
  dicttype       INTEGER not null,
  dictcode       INTEGER,
  dictvalue      VARCHAR2(100),
  dictvalue_py   VARCHAR2(50),
  dictvalueorder INTEGER,
  isdelete       INTEGER,
  remark         NVARCHAR2(50)
)
;
comment on table T_DICTIONARY
  is '字典表';
comment on column T_DICTIONARY.dicttype
  is '字典类型,100X为系统字典';
comment on column T_DICTIONARY.dictcode
  is '字典key';
comment on column T_DICTIONARY.dictvalue
  is '字典值';
comment on column T_DICTIONARY.dictvalueorder
  is '字典排序';
comment on column T_DICTIONARY.isdelete
  is '是否删除';
alter table T_DICTIONARY
  add constraint PK_DICTIONARY primary key (ID);


create table T_KESHI
(
  id           VARCHAR2(38) default sys_guid() not null,
  bianma       VARCHAR2(20),
  mingcheng    VARCHAR2(50),
  mingcheng_py VARCHAR2(50),
  keshileibie  VARCHAR2(20),
  addtime      TIMESTAMP(6) default sysdate,
  lasttime     TIMESTAMP(6) default sysdate,
  operatorid   VARCHAR2(38),
  pc           VARCHAR2(200),
  isdel        INTEGER default 0,
  leixing1     VARCHAR2(50),
  leixing2     VARCHAR2(50)
)
;
comment on table T_KESHI
  is '科室表';
comment on column T_KESHI.bianma
  is '科室编码';
comment on column T_KESHI.mingcheng
  is '科室名称';
comment on column T_KESHI.mingcheng_py
  is '科室名称拼音';
comment on column T_KESHI.keshileibie
  is '科室类别,住院\门诊\药剂科';
comment on column T_KESHI.isdel
  is '是否删除';
comment on column T_KESHI.leixing1
  is '一级类型';
comment on column T_KESHI.leixing2
  is '二级类型';
alter table T_KESHI
  add constraint PK_KESHI primary key (ID);

create table T_KESHIRENYUAN
(
  id         VARCHAR2(38) default sys_guid() not null,
  keshiid    VARCHAR2(38),
  yonghuid   VARCHAR2(38),
  addtime    TIMESTAMP(6) default sysdate,
  lasttime   TIMESTAMP(6) default sysdate,
  operatorid VARCHAR2(38),
  pc         VARCHAR2(100)
)
;
comment on table T_KESHIRENYUAN
  is '科室人员（暂时不用）';
alter table T_KESHIRENYUAN
  add constraint PK_KESHIRENYUAN primary key (ID);

create table T_LOGS
(
  id           VARCHAR2(38) default Sys_GUID() not null,
  logcontent   NVARCHAR2(200),
  operatorid   VARCHAR2(38),
  operatorname VARCHAR2(50),
  logtime      TIMESTAMP(6) default sysdate,
  pc           VARCHAR2(100)
)
;
create index I_LOGTIME on T_LOGS (LOGTIME);
alter table T_LOGS
  add constraint PD_LOGS primary key (ID);

create table T_MENU
(
  id          VARCHAR2(20) not null,
  menuname    VARCHAR2(100),
  menucaption NVARCHAR2(20),
  pid         VARCHAR2(20),
  buttonname  VARCHAR2(100)
)
;
comment on column T_MENU.menuname
  is '下拉菜单名称';
comment on column T_MENU.buttonname
  is '快捷按钮名称';
alter table T_MENU
  add constraint PK_MENU primary key (ID);

create table T_NUMBER_CONFIG
(
  id             INTEGER not null,
  caption        VARCHAR2(20),
  frontstr       VARCHAR2(20),
  lastdate       TIMESTAMP(6),
  dateformat     VARCHAR2(20),
  maxvalue       INTEGER,
  maxvaluelength INTEGER,
  backstr        VARCHAR2(20)
)
;
comment on column T_NUMBER_CONFIG.caption
  is '说明';
comment on column T_NUMBER_CONFIG.frontstr
  is '编号前缀';
comment on column T_NUMBER_CONFIG.lastdate
  is '上一次时间';
comment on column T_NUMBER_CONFIG.dateformat
  is '日期格式化';
comment on column T_NUMBER_CONFIG.maxvalue
  is '当前最大值';
comment on column T_NUMBER_CONFIG.maxvaluelength
  is '最大值的字符串长度';
comment on column T_NUMBER_CONFIG.backstr
  is '后缀字符串';
alter table T_NUMBER_CONFIG
  add constraint PK_NUMBER_CONFIG primary key (ID);

create table T_PEIXUNJIHUA
(
  id              VARCHAR2(38) default sys_guid() not null,
  neirong         NVARCHAR2(100),
  neirongshuoming NVARCHAR2(100),
  peixunkaishi    VARCHAR2(10),
  peixunjieshu    VARCHAR2(10),
  kaohekaishi     VARCHAR2(10),
  kaohejieshu     VARCHAR2(10),
  peixunleixing   INTEGER,
  canjiarenyuan   NVARCHAR2(100),
  chuangjianren   NVARCHAR2(20),
  addtime         TIMESTAMP(6) default sysdate,
  lasttime        TIMESTAMP(6) default sysdate,
  pc              VARCHAR2(100),
  operatorid      VARCHAR2(38)
)
;
comment on table T_PEIXUNJIHUA
  is '培训计划';
comment on column T_PEIXUNJIHUA.neirong
  is '计划内容';
comment on column T_PEIXUNJIHUA.neirongshuoming
  is '内容说明';
comment on column T_PEIXUNJIHUA.peixunkaishi
  is '培训开始时间';
comment on column T_PEIXUNJIHUA.peixunjieshu
  is '培训结束时间';
comment on column T_PEIXUNJIHUA.kaohekaishi
  is '考核开始时间';
comment on column T_PEIXUNJIHUA.kaohejieshu
  is '考核结束时间';
comment on column T_PEIXUNJIHUA.peixunleixing
  is '培训类型，1：三基，2：护理操作';
comment on column T_PEIXUNJIHUA.canjiarenyuan
  is '参加人员描述';
comment on column T_PEIXUNJIHUA.chuangjianren
  is '计划创建人';
alter table T_PEIXUNJIHUA
  add constraint PK_PEIXUNJIHUA primary key (ID);

create table T_PEIXUNJIHUA_KESHI
(
  id            VARCHAR2(38) default sys_guid() not null,
  jihuaid       VARCHAR2(38),
  keshiid       VARCHAR2(38),
  keshi         NVARCHAR2(50),
  shifouqueren  NVARCHAR2(2) default '否',
  querenren     NVARCHAR2(20),
  querenrenid   VARCHAR2(38),
  querenshijian TIMESTAMP(6),
  beizhu        NVARCHAR2(100),
  addtime       TIMESTAMP(6) default sysdate,
  lasttime      TIMESTAMP(6) default sysdate,
  pc            VARCHAR2(100),
  operatorid    VARCHAR2(38)
)
;
comment on table T_PEIXUNJIHUA_KESHI
  is '计划对应的多个科室';
comment on column T_PEIXUNJIHUA_KESHI.jihuaid
  is '计划Id';
comment on column T_PEIXUNJIHUA_KESHI.keshiid
  is '科室id';
comment on column T_PEIXUNJIHUA_KESHI.keshi
  is '科室名称';
comment on column T_PEIXUNJIHUA_KESHI.shifouqueren
  is '是否确认';
comment on column T_PEIXUNJIHUA_KESHI.querenren
  is '确认人';
comment on column T_PEIXUNJIHUA_KESHI.querenrenid
  is '确认人id';
comment on column T_PEIXUNJIHUA_KESHI.querenshijian
  is '确认时间';
comment on column T_PEIXUNJIHUA_KESHI.beizhu
  is '备注';
  
create table T_PEIXUNJIHUA_MINGXI
(
  id             VARCHAR2(38) default sys_guid() not null,
  jihuaid        VARCHAR2(38),
  keshiid        VARCHAR2(38),
  jihuamubanid   VARCHAR2(38),
  mubanid        VARCHAR2(38),
  muban          NVARCHAR2(100),
  renyuanid      VARCHAR2(38),
  dati           VARCHAR2(1000),
  shitishu       INTEGER,
  zhengqueshu    INTEGER,
  pingfenren     NVARCHAR2(20),
  fenshu         NUMBER,
  pingfenrenid   VARCHAR2(38),
  pingfenshijian TIMESTAMP(6),
  addtime        TIMESTAMP(6) default sysdate,
  lasttime       TIMESTAMP(6) default sysdate,
  pc             VARCHAR2(100),
  operatorid     VARCHAR2(38),
  datikaishi     TIMESTAMP(6),
  datijieshu     TIMESTAMP(6),
  datibiaozhi    NVARCHAR2(1) default '否'
);
-- Add comments to the table 
comment on table T_PEIXUNJIHUA_MINGXI
  is '培训考试计划明细（人员）';
-- Add comments to the columns 
comment on column T_PEIXUNJIHUA_MINGXI.jihuaid
  is '计划id';
comment on column T_PEIXUNJIHUA_MINGXI.keshiid
  is '科室id';
comment on column T_PEIXUNJIHUA_MINGXI.jihuamubanid
  is '计划模板id(可能不同人对应不同模板)';
comment on column T_PEIXUNJIHUA_MINGXI.mubanid
  is '试题模板的Id';
comment on column T_PEIXUNJIHUA_MINGXI.muban
  is '试题模板的名称';
comment on column T_PEIXUNJIHUA_MINGXI.renyuanid
  is '人员id';
comment on column T_PEIXUNJIHUA_MINGXI.dati
  is '答题卡“，”号隔开，代表每道题答案';
comment on column T_PEIXUNJIHUA_MINGXI.shitishu
  is '试题数';
comment on column T_PEIXUNJIHUA_MINGXI.zhengqueshu
  is '正确数';
comment on column T_PEIXUNJIHUA_MINGXI.pingfenren
  is '评分人';
comment on column T_PEIXUNJIHUA_MINGXI.fenshu
  is '得分';
comment on column T_PEIXUNJIHUA_MINGXI.pingfenrenid
  is '评分人Id';
comment on column T_PEIXUNJIHUA_MINGXI.pingfenshijian
  is '评分时间';
comment on column T_PEIXUNJIHUA_MINGXI.datikaishi
  is '答题开始时间（在线答题）';
comment on column T_PEIXUNJIHUA_MINGXI.datijieshu
  is '答题结束时间（在线答题）';
comment on column T_PEIXUNJIHUA_MINGXI.datibiaozhi
  is '答题标志，是否考试（在线答题）';
alter table T_PEIXUNJIHUA_MINGXI
  add constraint PK_PEIXUNJIHUA_MINGXI primary key (ID);


create table T_PEIXUNJIHUA_MUBAN
(
  id         VARCHAR2(38) default sys_guid() not null,
  jihuaid    VARCHAR2(38),
  mubanid    VARCHAR2(38),
  muban      NVARCHAR2(50),
  addtime    TIMESTAMP(6) default sysdate,
  lasttime   TIMESTAMP(6) default sysdate,
  pc         VARCHAR2(100),
  operatorid VARCHAR2(38)
)
;
comment on table T_PEIXUNJIHUA_MUBAN
  is '培训计划对应多个模板（多套卷子）';
comment on column T_PEIXUNJIHUA_MUBAN.jihuaid
  is '计划Id';
comment on column T_PEIXUNJIHUA_MUBAN.mubanid
  is '模板分类id';
comment on column T_PEIXUNJIHUA_MUBAN.muban
  is '模板名称';

create table T_ROLE
(
  id           VARCHAR2(38) default sys_guid() not null,
  role_name    NVARCHAR2(20) not null,
  remark       NVARCHAR2(100),
  addtime      TIMESTAMP(6) default sysdate,
  lasttime     TIMESTAMP(6) default sysdate,
  operatorid   VARCHAR2(38),
  pc           VARCHAR2(100),
  role_name_py VARCHAR2(20)
)
;
comment on column T_ROLE.role_name
  is '角色名称';
alter table T_ROLE
  add constraint PK_ROLE primary key (ID);

create table T_ROLE_MENU
(
  id          VARCHAR2(38) default sys_guid() not null,
  role_id     VARCHAR2(38),
  menuname    VARCHAR2(100) not null,
  menucaption NVARCHAR2(50),
  menuid      VARCHAR2(20),
  buttonname  VARCHAR2(100)
)
;
comment on column T_ROLE_MENU.role_id
  is '角色ID';
comment on column T_ROLE_MENU.menuname
  is '菜单名';
comment on column T_ROLE_MENU.menucaption
  is '菜单标题';
comment on column T_ROLE_MENU.menuid
  is '菜单Id';
comment on column T_ROLE_MENU.buttonname
  is '快捷按钮名称';
alter table T_ROLE_MENU
  add constraint PK_ROLE_MENU primary key (ID);

create table T_SEARCH_COLUMN
(
  id            VARCHAR2(38) default sys_guid() not null,
  orderno       INTEGER,
  columnname    VARCHAR2(50) not null,
  columncaption NVARCHAR2(20) not null,
  datatype      VARCHAR2(50),
  addtime       TIMESTAMP(6) default sysdate,
  modelclass    VARCHAR2(200)
)
;
comment on column T_SEARCH_COLUMN.orderno
  is '排序编号';
comment on column T_SEARCH_COLUMN.columnname
  is '字段名';
comment on column T_SEARCH_COLUMN.columncaption
  is '字段标题';
comment on column T_SEARCH_COLUMN.datatype
  is '数据类型';
comment on column T_SEARCH_COLUMN.modelclass
  is '表实体类名称';
alter table T_SEARCH_COLUMN
  add constraint PK_SEARCH_COLUMN primary key (ID);

create table T_SEARCH_RECORD
(
  id              VARCHAR2(38) default sys_guid() not null,
  ownerform       VARCHAR2(200),
  recordremark    NVARCHAR2(50),
  recordremark_py VARCHAR2(50),
  isdefault       INTEGER default 0,
  orderno         INTEGER,
  operatorid      VARCHAR2(38),
  addtime         TIMESTAMP(6) default sysdate,
  lasttime        TIMESTAMP(6) default sysdate
)
;
comment on column T_SEARCH_RECORD.ownerform
  is '所属窗口';
comment on column T_SEARCH_RECORD.recordremark
  is '记录备注';
comment on column T_SEARCH_RECORD.recordremark_py
  is '备注姓名';
comment on column T_SEARCH_RECORD.isdefault
  is '是否缺省值';
comment on column T_SEARCH_RECORD.orderno
  is '排序号';
comment on column T_SEARCH_RECORD.operatorid
  is '操作员id';
comment on column T_SEARCH_RECORD.addtime
  is '增加时间';
alter table T_SEARCH_RECORD
  add constraint PK_SEARCH_RECORD primary key (ID);

create table T_SEARCH_RECORD_DETAIL
(
  id            VARCHAR2(38) default sys_guid() not null,
  ownerform     VARCHAR2(200),
  fieldname     VARCHAR2(50),
  comparesign   VARCHAR2(50),
  connectorsign VARCHAR2(10),
  searchvalue   VARCHAR2(200),
  orderno       INTEGER,
  recordid      VARCHAR2(38),
  datatype      VARCHAR2(50)
)
;
comment on column T_SEARCH_RECORD_DETAIL.ownerform
  is '窗体名称';
comment on column T_SEARCH_RECORD_DETAIL.fieldname
  is '字段名';
comment on column T_SEARCH_RECORD_DETAIL.comparesign
  is '比较符';
comment on column T_SEARCH_RECORD_DETAIL.connectorsign
  is '连接符';
comment on column T_SEARCH_RECORD_DETAIL.searchvalue
  is '搜索值';
comment on column T_SEARCH_RECORD_DETAIL.orderno
  is '顺序号';
comment on column T_SEARCH_RECORD_DETAIL.datatype
  is '数据类型';
alter table T_SEARCH_RECORD_DETAIL
  add constraint PK_SEARCH_RECORD_DETAIL primary key (ID);

create table T_SHITI
(
  id           VARCHAR2(38) default sys_guid() not null,
  bianhao      VARCHAR2(20),
  neirong      NVARCHAR2(500),
  nanyichengdu NVARCHAR2(10),
  leixing      NVARCHAR2(10),
  fenlei       NVARCHAR2(100),
  fenleiid     VARCHAR2(38),
  daan         NVARCHAR2(500),
  xiangmua     NVARCHAR2(100),
  xiangmub     NVARCHAR2(100),
  xiangmuc     NVARCHAR2(100),
  xiangmud     NVARCHAR2(100),
  xiangmue     NVARCHAR2(100),
  xiangmuf     NVARCHAR2(100),
  addtime      TIMESTAMP(6) default sysdate,
  lasttime     TIMESTAMP(6) default sysdate,
  operatorid   VARCHAR2(38),
  pc           VARCHAR2(100)
)
;
comment on table T_SHITI
  is '试题';
comment on column T_SHITI.bianhao
  is '试题编号';
comment on column T_SHITI.neirong
  is '试题内容';
comment on column T_SHITI.nanyichengdu
  is '难易程度';
comment on column T_SHITI.leixing
  is '试题类型，单选、多选、判断、问答等';
comment on column T_SHITI.fenlei
  is '试题分类';
comment on column T_SHITI.fenleiid
  is '试题分类Id';
comment on column T_SHITI.daan
  is '问题答案，选择题为ABCDEF，问答题直接为参考答案';
comment on column T_SHITI.xiangmua
  is '项目A';
alter table T_SHITI
  add constraint PK_SHITI primary key (ID);

create table T_SHITI_FENLEI
(
  id           VARCHAR2(38) default sys_guid() not null,
  mingcheng    NVARCHAR2(50),
  mingcheng_py VARCHAR2(50),
  isdel        INTEGER default 0,
  addtime      TIMESTAMP(6) default sysdate,
  lasttime     TIMESTAMP(6) default sysdate,
  operatorid   VARCHAR2(38),
  pc           VARCHAR2(100)
)
;
comment on table T_SHITI_FENLEI
  is '试题分类';
comment on column T_SHITI_FENLEI.mingcheng
  is '分类名称';
comment on column T_SHITI_FENLEI.mingcheng_py
  is '名称助记码';
comment on column T_SHITI_FENLEI.isdel
  is '是否删除';
alter table T_SHITI_FENLEI
  add constraint PK_T_SHITI_FENLEI primary key (ID);

create table T_SHITI_MUBAN
(
  id            VARCHAR2(38) default sys_guid() not null,
  mingcheng     NVARCHAR2(50),
  mingcheng_py  VARCHAR2(50),
  chuangjianren NVARCHAR2(20),
  shitileibie   NVARCHAR2(100),
  shitileibieid VARCHAR2(38),
  beizhu        NVARCHAR2(100),
  addtime       TIMESTAMP(6) default sysdate,
  lasttime      TIMESTAMP(6) default sysdate,
  operatorid    VARCHAR2(38),
  pc            VARCHAR2(100)
)
;
comment on table T_SHITI_MUBAN
  is '试题模板';
comment on column T_SHITI_MUBAN.mingcheng
  is '名称';
comment on column T_SHITI_MUBAN.mingcheng_py
  is '助记码';
comment on column T_SHITI_MUBAN.chuangjianren
  is '创建人';
comment on column T_SHITI_MUBAN.shitileibie
  is '试题类别(分类)';
comment on column T_SHITI_MUBAN.shitileibieid
  is '试题类别(分类)ID';
comment on column T_SHITI_MUBAN.beizhu
  is '模板备注';
alter table T_SHITI_MUBAN
  add constraint PK_SHITI_MUBAN primary key (ID);

create table T_SHITI_MUBAN_FENLEI
(
  id              VARCHAR2(38) default sys_guid() not null,
  mubanid         VARCHAR2(38),
  fenleiid        VARCHAR2(38),
  fenleimingcheng NVARCHAR2(50),
  addtime         TIMESTAMP(6) default sysdate,
  lasttime        TIMESTAMP(6) default sysdate,
  operatorid      VARCHAR2(38),
  pc              VARCHAR2(100)
)
;
comment on table T_SHITI_MUBAN_FENLEI
  is '试题模板的分类明细';
comment on column T_SHITI_MUBAN_FENLEI.mubanid
  is '模板id';
comment on column T_SHITI_MUBAN_FENLEI.fenleiid
  is '试题分类id';
comment on column T_SHITI_MUBAN_FENLEI.fenleimingcheng
  is '试题分类名称';
alter table T_SHITI_MUBAN_FENLEI
  add constraint PK_SHITI_MUBAN_FENLEI primary key (ID);

create table T_SHITI_MUBAN_MINGXI
(
  id         VARCHAR2(38) default sys_guid() not null,
  mubanid    VARCHAR2(38),
  shitiid    VARCHAR2(38),
  shitixuhao INTEGER,
  fenshu     NUMBER,
  addtime    TIMESTAMP(6) default sysdate,
  lasttime   TIMESTAMP(6) default sysdate,
  operatorid VARCHAR2(38),
  pc         VARCHAR2(100)
)
;
comment on table T_SHITI_MUBAN_MINGXI
  is '试题模板细目（考题）';
comment on column T_SHITI_MUBAN_MINGXI.mubanid
  is '模板ID';
comment on column T_SHITI_MUBAN_MINGXI.shitiid
  is '试题ID';
comment on column T_SHITI_MUBAN_MINGXI.shitixuhao
  is '试题序号，每个试题模板中无重复';
comment on column T_SHITI_MUBAN_MINGXI.fenshu
  is '试题分数';
alter table T_SHITI_MUBAN_MINGXI
  add constraint PK_SHITI_MUBAN_MINGXI primary key (ID);

create table T_USER_INFO
(
  id             VARCHAR2(38) default Sys_GUID() not null,
  user_no        VARCHAR2(20) not null,
  user_name      VARCHAR2(20) not null,
  user_name_py   VARCHAR2(20),
  pwd            VARCHAR2(50) default 123456 not null,
  user_type      VARCHAR2(20) default 0 not null,
  isdel          INTEGER default 0,
  addinfo        NUMBER(1) default 0,
  addtime        TIMESTAMP(6) default sysdate,
  lasttime       TIMESTAMP(6) default sysdate,
  logincount     INTEGER default 0,
  pc             VARCHAR2(100),
  role_id        VARCHAR2(38),
  role_name      NVARCHAR2(20),
  keshiid        VARCHAR2(38),
  keshimingcheng NVARCHAR2(20)
)
;
comment on table T_USER_INFO
  is '用户信息（用于登陆）';
comment on column T_USER_INFO.user_no
  is '用户编号';
comment on column T_USER_INFO.user_name
  is '用户名称';
comment on column T_USER_INFO.user_name_py
  is '名称拼音码';
comment on column T_USER_INFO.pwd
  is '密码';
comment on column T_USER_INFO.user_type
  is '用户类型,0:护士,1:护士长,2:护理部';
comment on column T_USER_INFO.addinfo
  is '是否增加档案信息,0:否,1:是';
comment on column T_USER_INFO.addtime
  is '新增时间';
comment on column T_USER_INFO.lasttime
  is '更新时间';
comment on column T_USER_INFO.logincount
  is '登录次数';
comment on column T_USER_INFO.role_id
  is '权限ID';
comment on column T_USER_INFO.role_name
  is '权限名称';
comment on column T_USER_INFO.keshiid
  is '科室编码';
comment on column T_USER_INFO.keshimingcheng
  is '科室名称';
alter table T_USER_INFO
  add constraint PK_T_USER_INFO primary key (ID);

  
create table T_ZHIKONGJIHUA
(
  id            VARCHAR2(38) default sys_guid() not null,
  mingcheng     NVARCHAR2(50),
  kaishishijian VARCHAR2(10),
  jieshushijian VARCHAR2(10),
  beizhu        NVARCHAR2(100),
  addtime       TIMESTAMP(6) default sysdate,
  lasttime      TIMESTAMP(6) default sysdate,
  operatorid    VARCHAR2(38),
  pc            VARCHAR2(100),
  shifoufucha   NVARCHAR2(1) default '否',
  fuchajihuaid  VARCHAR2(38),
  fuchajihua    NVARCHAR2(50)
)
;
comment on column T_ZHIKONGJIHUA.mingcheng
  is '质控计划名称';
comment on column T_ZHIKONGJIHUA.kaishishijian
  is '检查开始时间';
comment on column T_ZHIKONGJIHUA.jieshushijian
  is '检查结束时间';
comment on column T_ZHIKONGJIHUA.beizhu
  is '备注';
comment on column T_ZHIKONGJIHUA.shifoufucha
  is '是否复查计划';
comment on column T_ZHIKONGJIHUA.fuchajihuaid
  is '要复查的计划Id';
comment on column T_ZHIKONGJIHUA.fuchajihua
  is '要复查的计划名称';
alter table T_ZHIKONGJIHUA
  add constraint PK_ZHIKONGJIHUA primary key (ID);

create table T_ZHIKONGJIHUA_JIEGUO
(
  id               VARCHAR2(38) default sys_guid() not null,
  jihuaid          VARCHAR2(38),
  keshiid          VARCHAR2(38),
  keshi            NVARCHAR2(50),
  neirongid        VARCHAR2(38),
  biaozhunleibieid VARCHAR2(38),
  biaozhunleibie   NVARCHAR2(50),
  biaozhunid       VARCHAR2(38),
  leixing1         NVARCHAR2(50),
  leixing2         NVARCHAR2(50),
  biaozhun         NVARCHAR2(200),
  jianchajieguo    NVARCHAR2(200),
  addtime          TIMESTAMP(6) default sysdate,
  lasttime         TIMESTAMP(6) default sysdate,
  operatorid       VARCHAR2(38),
  pc               VARCHAR2(100)
)
;
comment on table T_ZHIKONGJIHUA_JIEGUO
  is '质控计划检查结果';
comment on column T_ZHIKONGJIHUA_JIEGUO.jihuaid
  is '计划Id';
comment on column T_ZHIKONGJIHUA_JIEGUO.keshiid
  is '科室Id';
comment on column T_ZHIKONGJIHUA_JIEGUO.keshi
  is '科室名称';
comment on column T_ZHIKONGJIHUA_JIEGUO.neirongid
  is '检查内容Id';
comment on column T_ZHIKONGJIHUA_JIEGUO.biaozhunleibieid
  is '标准类别Id';
comment on column T_ZHIKONGJIHUA_JIEGUO.biaozhunleibie
  is '标准类别名称';
comment on column T_ZHIKONGJIHUA_JIEGUO.biaozhunid
  is '标准Id';
comment on column T_ZHIKONGJIHUA_JIEGUO.leixing1
  is '一级标准类型';
comment on column T_ZHIKONGJIHUA_JIEGUO.leixing2
  is '二级标准类型';
comment on column T_ZHIKONGJIHUA_JIEGUO.biaozhun
  is '标准名称';
comment on column T_ZHIKONGJIHUA_JIEGUO.jianchajieguo
  is '检查结果说明';
alter table T_ZHIKONGJIHUA_JIEGUO
  add constraint PK_ZHIKONGJIHUA_JIEGUO primary key (ID);

create table T_ZHIKONGJIHUA_KESHI
(
  id                   VARCHAR2(38) default sys_guid() not null,
  jihuaid              VARCHAR2(38),
  keshiid              VARCHAR2(38),
  keshi                NVARCHAR2(50),
  keshileibie          NVARCHAR2(50),
  shifoujiancha        NVARCHAR2(1) default '否',
  jiancharenyuan       NVARCHAR2(100),
  jianchakaishishijian VARCHAR2(10),
  jianchajieshushijian VARCHAR2(10),
  shifouqueren         NVARCHAR2(1) default '否',
  querenshijian        TIMESTAMP(6),
  gaijinshijian_xianqi VARCHAR2(10),
  gaijinshuoming       NVARCHAR2(500),
  gaijinshijian        TIMESTAMP(6),
  gaijinshangbaoren    NVARCHAR2(20),
  biaozhunshu          INTEGER,
  wentishu             INTEGER,
  addtime              TIMESTAMP(6) default sysdate,
  lasttime             TIMESTAMP(6) default sysdate,
  operatorid           VARCHAR2(38),
  pc                   VARCHAR2(100)
)
;
comment on table T_ZHIKONGJIHUA_KESHI
  is '质控计划对应的科室表';
comment on column T_ZHIKONGJIHUA_KESHI.jihuaid
  is '计划id';
comment on column T_ZHIKONGJIHUA_KESHI.keshiid
  is '科室id';
comment on column T_ZHIKONGJIHUA_KESHI.keshi
  is '科室名称';
comment on column T_ZHIKONGJIHUA_KESHI.keshileibie
  is '科室类别';
comment on column T_ZHIKONGJIHUA_KESHI.shifoujiancha
  is '是否已检查';
comment on column T_ZHIKONGJIHUA_KESHI.jiancharenyuan
  is '检查人（多个）';
comment on column T_ZHIKONGJIHUA_KESHI.jianchakaishishijian
  is '检查时间开始';
comment on column T_ZHIKONGJIHUA_KESHI.jianchajieshushijian
  is '检查时间结束';
comment on column T_ZHIKONGJIHUA_KESHI.shifouqueren
  is '科室是否确认';
comment on column T_ZHIKONGJIHUA_KESHI.querenshijian
  is '确认时间';
comment on column T_ZHIKONGJIHUA_KESHI.gaijinshijian_xianqi
  is '改进日期限期';
comment on column T_ZHIKONGJIHUA_KESHI.gaijinshuoming
  is '改进情况说明';
comment on column T_ZHIKONGJIHUA_KESHI.gaijinshijian
  is '改进时间';
comment on column T_ZHIKONGJIHUA_KESHI.gaijinshangbaoren
  is '改进上报人';
comment on column T_ZHIKONGJIHUA_KESHI.biaozhunshu
  is '标准数量';
comment on column T_ZHIKONGJIHUA_KESHI.wentishu
  is '问题数量';
alter table T_ZHIKONGJIHUA_KESHI
  add constraint PK_ZHIKONGJIHUA_KESHI primary key (ID);

create table T_ZHIKONGJIHUA_NEIRONG
(
  id               VARCHAR2(38) default sys_guid() not null,
  jihuaid          VARCHAR2(38),
  biaozhunleibieid VARCHAR2(38),
  biaozhunleibie   NVARCHAR2(50),
  biaozhunshu      INTEGER,
  addtime          TIMESTAMP(6) default sysdate,
  lasttime         TIMESTAMP(6) default sysdate,
  operatorid       VARCHAR2(38),
  pc               VARCHAR2(100)
)
;
comment on table T_ZHIKONGJIHUA_NEIRONG
  is '质控计划（检查）内容';
comment on column T_ZHIKONGJIHUA_NEIRONG.jihuaid
  is '计划id';
comment on column T_ZHIKONGJIHUA_NEIRONG.biaozhunleibieid
  is '质控标准类别Id';
comment on column T_ZHIKONGJIHUA_NEIRONG.biaozhunleibie
  is '质控标准类别名称';
comment on column T_ZHIKONGJIHUA_NEIRONG.biaozhunshu
  is '标准库类别数量';
alter table T_ZHIKONGJIHUA_NEIRONG
  add constraint T_ZHIKONGJIHUA_MINGXI primary key (ID);

create table T_ZHILIANGBIAOZHUN
(
  id         VARCHAR2(38) default sys_guid(),
  leibieid   VARCHAR2(38),
  leibie     NVARCHAR2(50),
  leixing1   NVARCHAR2(50),
  leixing2   NVARCHAR2(50),
  xuhao      INTEGER default 0,
  neirong    NVARCHAR2(200),
  addtime    TIMESTAMP(6) default sysdate,
  lasttime   TIMESTAMP(6) default sysdate,
  operatorid VARCHAR2(38),
  pc         VARCHAR2(100)
)
;
comment on column T_ZHILIANGBIAOZHUN.leibieid
  is '类别Id';
comment on column T_ZHILIANGBIAOZHUN.leibie
  is '类别名称';
comment on column T_ZHILIANGBIAOZHUN.leixing1
  is '标准类型（一级）';
comment on column T_ZHILIANGBIAOZHUN.leixing2
  is '标准类型（二级）';
comment on column T_ZHILIANGBIAOZHUN.xuhao
  is '内容序号（每个类别不重复）';
comment on column T_ZHILIANGBIAOZHUN.neirong
  is '标准内容';


create table T_ZHILIANGBIAOZHUN_LEIBIE
(
  id           VARCHAR2(38) default sys_guid() not null,
  mingcheng    NVARCHAR2(50),
  biaozhunshu  INTEGER,
  mingcheng_py VARCHAR2(50),
  beizhu       NVARCHAR2(100),
  addtime      TIMESTAMP(6) default sysdate,
  lasttime     TIMESTAMP(6) default sysdate,
  operatorid   VARCHAR2(38),
  pc           VARCHAR2(100)
)
;
comment on column T_ZHILIANGBIAOZHUN_LEIBIE.mingcheng
  is '评价标准';
comment on column T_ZHILIANGBIAOZHUN_LEIBIE.biaozhunshu
  is '该类别的内容数量';
comment on column T_ZHILIANGBIAOZHUN_LEIBIE.beizhu
  is '备注';
alter table T_ZHILIANGBIAOZHUN_LEIBIE
  add constraint PK_ZHILIANGBIAOZHUN_LEIBIE primary key (ID);


create table T_ZHILIANGBIAOZHUN_LEIBIE
(
  id           VARCHAR2(38) default sys_guid() not null,
  mingcheng    NVARCHAR2(50),
  biaozhunshu  INTEGER,
  mingcheng_py VARCHAR2(50),
  beizhu       NVARCHAR2(100),
  addtime      TIMESTAMP(6) default sysdate,
  lasttime     TIMESTAMP(6) default sysdate,
  operatorid   VARCHAR2(38),
  pc           VARCHAR2(100)
)
;
comment on column T_ZHILIANGBIAOZHUN_LEIBIE.mingcheng
  is '评价标准';
comment on column T_ZHILIANGBIAOZHUN_LEIBIE.biaozhunshu
  is '该类别的内容数量';
comment on column T_ZHILIANGBIAOZHUN_LEIBIE.beizhu
  is '备注';
alter table T_ZHILIANGBIAOZHUN_LEIBIE
  add constraint PK_ZHILIANGBIAOZHUN_LEIBIE primary key (ID);



create table T_ZHILIANGBIAOZHUN_LEIBIE_KS
(
  id           VARCHAR2(38) default sys_guid() not null,
  KeShiId      varchar2(38),
  KeShiName    nvarchar2(50),
  mingcheng    NVARCHAR2(50),
  biaozhunshu  INTEGER,
  mingcheng_py VARCHAR2(50),
  beizhu       NVARCHAR2(100),
  addtime      TIMESTAMP(6) default sysdate,
  lasttime     TIMESTAMP(6) default sysdate,
  operatorid   VARCHAR2(38),
  pc           VARCHAR2(100)
)
;
comment on column T_ZHILIANGBIAOZHUN_LEIBIE_KS.mingcheng
  is '评价标准';
comment on column T_ZHILIANGBIAOZHUN_LEIBIE_KS.biaozhunshu
  is '该类别的内容数量';
comment on column T_ZHILIANGBIAOZHUN_LEIBIE_KS.beizhu
  is '备注';
alter table T_ZHILIANGBIAOZHUN_LEIBIE_KS
  add constraint T_ZHILIANGBIAOZHUN_LEIBIE_KS primary key (ID);



-- 质量标准类别对应的权限人员
create table T_ZHILIANGBIAOZHUN_QUANXIAN
(
  id         VARCHAR2(38) default sys_guid() not null,
  renyuanid  VARCHAR2(38),
  leibieid   VARCHAR2(38),
  leibie     VARCHAR2(50),
  bianhao    VARCHAR2(20),
  mingcheng  NVARCHAR2(20),
  addtime    TIMESTAMP(6) default sysdate,
  lasttime   TIMESTAMP(6) default sysdate,
  operatorid VARCHAR2(38),
  pc         VARCHAR2(100)
)
tablespace USERS
  pctfree 10
  initrans 1
  maxtrans 255;
-- Add comments to the table 
comment on table T_ZHILIANGBIAOZHUN_QUANXIAN
  is '质量标准类别对应的权限人员';
-- Add comments to the columns 
comment on column T_ZHILIANGBIAOZHUN_QUANXIAN.renyuanid
  is '权限人员Id';
comment on column T_ZHILIANGBIAOZHUN_QUANXIAN.leibieid
  is '类别Id';
comment on column T_ZHILIANGBIAOZHUN_QUANXIAN.leibie
  is '类别名称';
comment on column T_ZHILIANGBIAOZHUN_QUANXIAN.bianhao
  is '人员编号';
comment on column T_ZHILIANGBIAOZHUN_QUANXIAN.mingcheng
  is '人员名称';

-- 科室质控表
create table T_ZhiKong_KeShi
(
  id               VARCHAR2(38) default sys_guid() not null,
  addtime          TIMESTAMP(6) default sysdate,
  lasttime         TIMESTAMP(6) default sysdate,
  operatorid       VARCHAR2(38),
  pc               VARCHAR2(100),
  keshiid          varchar2(38),
  keshi            nvarchar2(50),
  jianchariqi      date,
  zhikongrenyuan   nvarchar2(200),
  canjiarenyuan    nvarchar2(200),
  jiangpingren     nvarchar2(10),
  jiangpingshijian timestamp,
  yuanyinfenxi     nvarchar2(500),
  gaijincuoshi     nvarchar2(500),
  beizhu           nvarchar2(200)
)
;
-- Add comments to the columns 
comment on column T_ZhiKong_KeShi.keshiid
  is '科室id';
comment on column T_ZhiKong_KeShi.keshi
  is '科室名称';
comment on column T_ZhiKong_KeShi.jianchariqi
  is '检查日期';
comment on column T_ZhiKong_KeShi.zhikongrenyuan
  is '质控人员';
comment on column T_ZhiKong_KeShi.canjiarenyuan
  is '参加人员';
comment on column T_ZhiKong_KeShi.jiangpingren
  is '讲评人';
comment on column T_ZhiKong_KeShi.jiangpingshijian
  is '讲评时间';
comment on column T_ZhiKong_KeShi.yuanyinfenxi
  is '原因分析';
comment on column T_ZhiKong_KeShi.gaijincuoshi
  is '改进措施';
comment on column T_ZhiKong_KeShi.beizhu
  is '备注';
-- Create/Recreate primary, unique and foreign key constraints 
alter table T_ZhiKong_KeShi  add constraint PK_ZhiKong_KeShi primary key (ID);

-- Create table
create table T_GONGZUOLIANG
(
  id          VARCHAR2(38) default sys_guid() not null,
  addtime     TIMESTAMP(6) default sysdate,
  lasttime    TIMESTAMP(6) default sysdate,
  pc          VARCHAR2(100),
  startdate   VARCHAR2(10),
  enddate     VARCHAR2(10),
  keshibianma VARCHAR2(38),
  hushibianma VARCHAR2(50),
  hushi       NVARCHAR2(20)
);
-- Add comments to the columns 
comment on column T_GONGZUOLIANG.startdate
  is '开始日期(yyyy-MM-dd)';
comment on column T_GONGZUOLIANG.enddate
  is '结束日期(yyyy-MM-dd)';
comment on column T_GONGZUOLIANG.hushibianma
  is '护士His编码';
comment on column T_GONGZUOLIANG.hushi
  is '护士姓名';
-- Create/Recreate primary, unique and foreign key constraints 
alter table T_GONGZUOLIANG  add constraint GONGZUOLIANG_PK primary key (ID);

-- Create table
create table T_GONGZUOLIANG_DETAIL
(
  id      VARCHAR2(38) default sys_guid() not null,
  mainid  VARCHAR2(38),
  xuanmu  NVARCHAR2(20),
  fenzhi  NUMBER,
  cifen   INTEGER,
  zongfen NUMBER,
  day1    INTEGER,
  day2    INTEGER,
  day3    INTEGER,
  day4    INTEGER,
  day5    INTEGER,
  day6    INTEGER,
  day7    INTEGER,
  day8    INTEGER,
  day9    INTEGER,
  day10   INTEGER,
  day11   INTEGER,
  day12   INTEGER,
  day13   INTEGER,
  day14   INTEGER,
  day15   INTEGER,
  day16   INTEGER,
  day17   INTEGER,
  day18   INTEGER,
  day19   INTEGER,
  day20   INTEGER,
  day21   INTEGER,
  day22   INTEGER,
  day23   INTEGER,
  day24   INTEGER,
  day25   INTEGER,
  day26   INTEGER,
  day27   INTEGER,
  day28   INTEGER,
  day29   INTEGER,
  day30   INTEGER not null,
  day31   INTEGER
);
-- Add comments to the columns 
comment on column T_GONGZUOLIANG_DETAIL.xuanmu
  is '项目名称';
comment on column T_GONGZUOLIANG_DETAIL.fenzhi
  is '分值';
comment on column T_GONGZUOLIANG_DETAIL.cifen
  is '次分';
comment on column T_GONGZUOLIANG_DETAIL.zongfen
  is '总分值';
-- Create/Recreate primary, unique and foreign key constraints 
alter table T_GONGZUOLIANG_DETAIL
  add constraint GONGZUOLIANG_DETAIL_PK primary key (ID);


-- Create table
create table T_GONGZUOLIANG_PEIZHI
(
  id         VARCHAR2(38) default sys_guid() not null,
  orderno    INTEGER default 0,
  itemname   NVARCHAR2(50),
  scorevalue NUMBER,
  sqltext    VARCHAR2(2000)
);
-- Add comments to the columns 
comment on column T_GONGZUOLIANG_PEIZHI.orderno
  is '排序';
comment on column T_GONGZUOLIANG_PEIZHI.itemname
  is '项目名称';
comment on column T_GONGZUOLIANG_PEIZHI.scorevalue
  is '分值';
comment on column T_GONGZUOLIANG_PEIZHI.sqltext
  is 'sql文本';
-- Create/Recreate primary, unique and foreign key constraints 
alter table T_GONGZUOLIANG_PEIZHI  add constraint GONGZUOLIANG_PEIZHI_PK primary key (ID);



create or replace view v_peixunjihua_keshi as
select t.Id,t.Keshiid,a.Id as JiHuaId ,t.Keshi,t.shifouqueren,t.querenren,
       t.querenshijian,a.neirong,a.neirongshuoming,a.peixunkaishi,a.peixunjieshu,a.PeiXunKaiShi || ' 至 ' || a.peixunjieshu as PeiXunRiQi,
       a.Kaohekaishi || ' 至 ' || a.KaoheJieShu as KaoShiRiQi,
       a.kaohekaishi,a.kaohejieshu,a.CANJIARENYUAN,t.AddTime,t.Lasttime,t.operatorid
from T_PeiXunJiHua_KeShi t
inner join T_PeiXunJiHua a on t.Jihuaid = a.id;

create or replace view v_peixunjihua_mingxi as
select t.id, t.jihuaid,c.neirong as JiHuaMingCheng ,t.keshiid,b.Mingcheng as KeShi, t.Mubanid ,t.renyuanid,t.MuBan, a.bianhao,a.xingming,a.xingming_py,a.nengji,
       t.ShiTiShu,t.zhengqueshu,t.fenshu,t.pingfenren,t.pingfenshijian,t.DATI,t.datibiaozhi,t.datikaishi,t.datijieshu
from T_PEIXUNJIHUA_MINGXI t
inner join T_DangAn a on t.renyuanid= a.id
inner join T_KeShi b on t.KeShiId=b.Id
inner join T_PeiXunJiHua c on t.JiHuaId = c.Id;


create or replace force view v_shiti_muban_mingxi as
select
   t.id,t.mubanid,a.Fenleiid ,t.shitiid,b.mingcheng as MuBanMingCheng,b.chuangjianren,t.ShiTiXuhao,
   a.bianhao,a.neirong,a.leixing,a.fenlei,a.nanyichengdu,t.addtime,
   a.xiangmua,a.xiangmub,a.xiangmuc,a.xiangmud,a.xiangmue,a.xiangmuf,a.daan,t.FenShu
from t_shiti_muban_mingxi t
inner join t_Shiti a on t.shitiid=a.id
inner join t_shiti_muban b on t.mubanid=b.id;

create or replace view v_zhikongjihua_keshi as
select t.Id,t.KeShiId,t.KeShi,b.LeiXing1,b.Leixing2 ,a.id as JiHuaId, a.mingcheng as JiHuaMingCheng,
       t.Biaozhunshu,t.wentishu,
       round((t.BiaoZhunShu - t.WenTiShu) /t.BiaoZhunShu*100,2) as HeGeLv,
       a.kaishishijian || ' 至 ' || a.jieshushijian as JiHuaShiJian, t.ShiFouJianCha,
       case when t.ShiFouJianCha='是' then  t.JianChaKaiShiShiJian || ' 至 ' || t.JianChaJieShuShiJian else '' end as JianChaShiJian,
       t.JianChaRenYuan,t.GaiJinShiJian_XianQi,
       t.ShiFouQueRen,t.QueRenShiJian,t.GaiJinShuoMing,t.YuanYinFenXi,t.GaiJinShiJian,t.GaiJinShangBaoRen,t.AddTime
from T_ZhiKongJiHua_KeShi t
inner join T_ZhiKongJiHua a on t.JiHuaId = a.Id
inner join T_Keshi b on t.KeShiId= b.Id;

create or replace view V_PeiXunJieGuo_HuiZong
as
select tt.KeShiId,a.MingCheng as KeShi,tt.JiHuaId,b.neirong ,tt.KaoShiRenShu,tt.KaoShiZongFen,round(tt.KaoShiZongFen/tt.KaoShiRenShu,2) as PingJunFenShu
from (
  select t.KeShiId,t.JiHuaId,count(1) as KaoShiRenShu,sum(FenShu) as KaoShiZongFen
  from T_PeiXunJiHua_MingXi t
  group by t.KeShiId,t.JiHuaId
) tt
inner join T_KeShi a on a.id = tt.keshiid
inner join T_PeiXunJiHua b on b.Id=tt.Jihuaid

create or replace view v_zhikong_hegelv as
select t.JiHuaId,t1.MingCheng as JiHua,t.KeShiId,t.KeShi,a.BiaoZhunLeiBieId,a.BiaoZhunLeiBie ,
       a.BiaoZhunShu,nvl(b.WenTiShu,0) as WenTiShu,round((1 - nvl(b.WenTiShu,0)/a.BiaoZhunShu ) *100 ,2) as HeGeLv,
       t.JianChaKaiShiShiJian
from T_ZhiKongJiHua_KeShi t
inner join T_ZhiKongJiHua t1 on t.JiHuaId=t1.ID
inner join T_ZhiKongJiHua_NeiRong a on a.jihuaid = t.JiHuaId and a.KeShiId=t.KeShiId
left join (
  select t.JiHuaId,t.KeShiId,t.BiaoZhunLeiBieId,count(1) as WenTiShu
  from t_zhikongjihua_jieguo t
  group by t.JiHuaId,t.KeShiId,t.BiaoZhunLeiBieId) b on t.JiHuaId=b.JiHuaId and t.KeShiId=b.KeShiId and a.BiaoZhunLeiBieId=b.BiaoZhunLeiBieId
where t.ShiFouJianCha = '是';

--查询计划模板中的人数
create or replace view V_PEIXUNJIHUA_MUBAN as
select t.Id,t.JiHuaId,t.MuBanId,t.MuBan,a.MuBanRenShu,t.AddTime,t.LastTime from  T_PEIXUNJIHUA_MUBAN t
inner join (select MuBanId,count(1) as MuBanRenShu from t_peixunjihua_mingxi where MuBanId is not null group by MuBanId) a on t.MuBanId = a.MuBanId

-- Create table 2017.9.25
create table T_GongZuoLiang_PeiZhi
(
  id         varchar2(38) default sys_guid(),
  orderno    integer default 0,
  itemname   nvarchar2(50),
  scorevalue number,
  sqltext    varchar2(2000)
)
;
-- Add comments to the columns 
comment on column T_GongZuoLiang_PeiZhi.orderno
  is '排序';
comment on column T_GongZuoLiang_PeiZhi.itemname
  is '项目名称';
comment on column T_GongZuoLiang_PeiZhi.scorevalue
  is '分值';
comment on column T_GongZuoLiang_PeiZhi.sqltext
  is 'sql文本';
-- Create/Recreate primary, unique and foreign key constraints 
alter table T_GongZuoLiang_PeiZhi
  add constraint T_GongZuoLiang_PeiZhi_PK primary key (ID);

