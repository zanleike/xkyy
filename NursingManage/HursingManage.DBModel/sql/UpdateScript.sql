--2017.5.22
--增加质控检查结果中操作员姓名，因修改删除只能自己操作，体现出来更加友好；
alter table T_ZHIKONGJIHUA_JIEGUO add operator nvarchar2(20);
alter table T_ZHIKONGJIHUA_JIEGUO add YUANYINFENXI nvarchar2(200);

-- Add comments to the columns 
comment on column T_ZHIKONGJIHUA_JIEGUO.operator is '操作员姓名';
comment on column T_ZHIKONGJIHUA_JIEGUO.YUANYINFENXI is '检查结果原因分析';

-- 2017.5.8
--培训管理-试题模板创建时选择录入 试题的出题情况（试题数量分值 等）
-- Add/modify columns 
alter table T_SHITI_MUBAN add danxuanshu INTEGER default 0;
alter table T_SHITI_MUBAN add danxuanfenshu NUMBER default 0;
alter table T_SHITI_MUBAN add duoxuanshu INTEGER default 0;
alter table T_SHITI_MUBAN add duoxuanfenshu NUMBER default 0;
alter table T_SHITI_MUBAN add panduanshu INTEGER default 0;
alter table T_SHITI_MUBAN add panduanfenshu NUMBER default 0;
-- Add comments to the columns 
comment on column T_SHITI_MUBAN.danxuanshu
  is '单选题数量';
comment on column T_SHITI_MUBAN.danxuanfenshu
  is '单选题分数';
comment on column T_SHITI_MUBAN.duoxuanshu
  is '多选题数量';
comment on column T_SHITI_MUBAN.duoxuanfenshu
  is '多选题分数';
comment on column T_SHITI_MUBAN.panduanshu
  is '判断题数量';
comment on column T_SHITI_MUBAN.panduanfenshu
  is '判断题分数';
--2017.5.8 其更新脚本在再此处