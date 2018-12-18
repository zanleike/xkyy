create or replace procedure P_YaChuangTongJi(
       startDate in varchar2,
       endDate in varchar2,
       evaluationId in varchar2, -- 评估单id，78:压疮，79:跌倒坠床
       evaluationScore integer,
       p_ref out sys_refcursor) is
  sd date; --开始时间
  ed date; --结束时间
begin
/*评估单统计查询
修改记录：

*/
  select to_date(startDate,'yyyy-mm-dd') into sd from dual;
  select to_date(endDate,'yyyy-mm-dd') into ed from dual;
  open p_ref for    
  select 
    d.dept_name as 科室名称,
    t.visit_id as 住院次数,t.Patient_Id as 住院号,a.Name as 姓名,t.Item_Value as 压疮评估得分,
    b.admission_date_time as 入院时间,b.discharge_date_time as 出院时间,
    nvl(ceil(
      case when b.discharge_date_time is null then sysdate
           when b.discharge_date_time > ed then ed
           when b.discharge_date_time < sd then null
           else b.discharge_date_time end  --出院时间，如果为null则取当前时间，如果大于结束时间取“结束时间”，如果小于开始时间，则为null
             -
      case when b.admission_date_time< sd 
           then sd else b.admission_date_time end
     ),0) as 本期住院天数,
    e.diagnosis_desc as 诊断说明,
    t.Record_Date as 记录单时间,
    c.admission_date_time as 转入科室时间,
    c.discharge_date_time as 转出科室时间,
    ceil( nvl(c.discharge_date_time,sysdate) -c.admission_date_time) as 科室天数
  from (
    select Dept_Code,Patient_Id,visit_id,Item_Value,Record_Date from (
      SELECT Dept_Code,Patient_Id,visit_id,Item_Value,Record_Date,row_Number() over(Partition by Dept_Code,Patient_Id,visit_id order by visit_id desc,Record_Date) as rowNo
      FROM MOBILE.PAT_EVALUATION_M@his t
      WHERE ITEM_NAME='SCORES' and DICT_ID=evaluationId
          --and Item_Value>8 and DICT_ID='78'
          --order by Dept_Code
    ) t where  t.rowNo=1 and Item_Value>evaluationScore
  ) t
  left join PAT_MASTER_INDEX@his a on a.Patient_id=t.Patient_Id
  left join dept_vs_ward@his f on t.dept_code=f.ward_code
  left join dept_dict@his d on d.dept_code = f.dept_code
  left join pat_visit@his b on b.admission_date_time>=sd and t.Patient_Id=b.Patient_Id and t.visit_id=b.visit_id  --出入院时间
  left join ( --本科室中的天数
    select patient_id,visit_id,Dept_stayed,
    --ceil(max(discharge_date_time) - min(admission_date_time)) as DayCount --在本科室中的天数
    max(discharge_date_time) as discharge_date_time , min(admission_date_time) as admission_date_time
    from transfer@his 
    where admission_date_time>=sd
    group by patient_id,visit_id,Dept_stayed
    order by patient_id
    ) c on t.patient_id=c.patient_id and t.visit_id=c.visit_id and d.Dept_Code=c.Dept_stayed
  left join (  --诊断，如果入院诊断为空，则取门诊诊断
    select t.patient_id,t.visit_id,nvl(t.ryzd,t.mzzd) as diagnosis_desc from (
      select patient_id,visit_id,
         case when diagnosis_type='1' and diagnosis_no=1 then diagnosis_desc else null end as mzzd, 
         case when diagnosis_type='2' and diagnosis_no=1 then diagnosis_desc else null end as ryzd,
         diagnosis_date,
         row_Number() over(Partition by Patient_Id,visit_id order by diagnosis_date desc) as rowNo
      from diagnosis@his
    ) t where t.rowNo=1 ) e on t.patient_id=e.patient_id and t.visit_id=e.visit_id
  where t.Record_Date>=sd and t.Record_Date<= ed
  order by d.dept_code;

end;

--日动态情况查询
create or replace procedure P_RiDongTaiHuiZong(searchDate in varchar2, p_ref out sys_refcursor) is
 sDate date;
begin
  select to_date(searchDate,'yyyy-mm-dd') into sDate from dual;
  open p_ref for 
  
  select t.dept_code as 部门编码,t.dept_name as 科室名称,
         a.ct as 新入院患者数,
         b.ct as 原有患者数,
         b2.ct as 原有出院未转出,
         c.ct as 转入患者数,
         c2.ct as 转出患者数,
         d.ct as 手术患者数,
         e.ct as 出院患者数,
         f.ct as 死亡患者数,
         k.ct as 产后患者数,
         l.ct as 新生儿数,
         g.ct as 一级护理人数,
         h.ct as 二级护理人数,
         i.ct as 三级护理人数,
         j.ct as 特级护理人数,
         sdate as 查询日期
         /*,a.dept_code as 新入院患者部门
           ,b.dept_code as 原入院患者部门
           ,c.dept_code as 转科患者科室*/
         
  from 
  (
    select * from dept_dict@his 
    where CLINIC_ATTR = 0 and OUTP_OR_INP=1 --and dept_code not in ('0803','0801')
  ) t 
  left join ( --新入院（转入）患者数
    select dept_admission_to as dept_code,count(1) as ct 
    from pat_visit@his
    where admission_date_time >= sDate
          and admission_date_time < sDate+1
    group by dept_admission_to
  ) a on t.dept_code=a.dept_code
  left join ( -- 前日患者数
    select DEPT_STAYED as dept_code,count(1) as ct
    from TRANSFER@his
    where ADMISSION_DATE_TIME <= sDate  --前日入院如果不算则需要 sDate-1
    and (DISCHARGE_DATE_TIME>= sDate  or DISCHARGE_DATE_TIME is null)
    and SUBSTR(patient_id,0,1)!='Z'
    group by DEPT_STAYED
  ) b on t.dept_code = b.dept_code  
  left join ( -- 前日 出院未转出患者，）
  	select dept_stayed as dept_code,count(1) as ct
    from TRANSFER@his a,PRE_DISCHGED_PATS@his b
    where a.patient_id=b.patient_id 
          and a.DISCHARGE_DATE_TIME is null
          --and a.admission_date_time<sDate
          and b.discharge_date_expcted<sDate
    group by dept_stayed
    
  ) b2 on t.dept_code = b2.dept_code  
  left join ( -- 转入患者数（其它科室转入）
    select dept_transfered_to as dept_code,count(1) as ct
    from transfer@his
    where dept_transfered_to is not null 
          and discharge_date_time>=sDate 
          and discharge_date_time<sDate+1
          and SUBSTR(patient_id,0,1)!='Z'
    group by dept_transfered_to
  ) c on t.dept_code=c.dept_code
  left join ( -- 转出患者数
    select dept_stayed as dept_code,count(1) as ct
    from transfer@his
    where dept_transfered_to is not null 
          and discharge_date_time>=sDate 
          and discharge_date_time<sDate+1
          and SUBSTR(patient_id,0,1)!='Z'
    group by dept_stayed
  ) c2 on t.dept_code=c2.dept_code  
  left join ( --查询手术患者 
    select DEPT_STAYED as dept_code,count(1) as ct
    from OPERATION_MASTER@his 
    where START_DATE_TIME>= sDate and start_date_time<= sDate+1
    group by DEPT_STAYED
  ) d on t.dept_code=d.dept_code
  left join ( -- 出院患者数
    select DEPT_DISCHARGE_FROM as dept_code,count(1) as ct
    from PAT_VISIT@his
    where DISCHARGE_DATE_TIME>= sDate and DISCHARGE_DATE_TIME<= sDate+1
    group by DEPT_DISCHARGE_FROM
  ) e on t.dept_code=e.dept_code
  left join (-- 死亡患者数
    select ordering_dept as dept_code,count(1) as ct
    from ORDERS@his 
    where START_DATE_TIME>= sDate and START_DATE_TIME< sDate+1
          and ORDER_TEXT like '%死亡%'
    group by ordering_dept
  ) f on t.dept_code=f.dept_code
  left join ( -- 一级护理 患者数
    select ORDERING_DEPT as dept_code,count(1) ct 
    from ORDERS@his 
    where START_DATE_TIME>= sDate and START_DATE_TIME < sDate+1 and order_text='一级护理'
    group by ORDERING_DEPT
  ) g on t.dept_code=g.dept_code  
  left join ( -- 二级护理 患者数
    select ORDERING_DEPT as dept_code,count(1) ct 
    from ORDERS@his 
    where START_DATE_TIME>= sDate and START_DATE_TIME < sDate+1 and order_text='二级护理'
    group by ORDERING_DEPT
  ) h on t.dept_code=h.dept_code
  left join ( -- 三级护理 患者数
    select ORDERING_DEPT as dept_code,count(1) ct 
    from ORDERS@his 
    where START_DATE_TIME>= sDate and START_DATE_TIME < sDate+1 and order_text='三级护理'
    group by ORDERING_DEPT
  ) i on t.dept_code=i.dept_code
  left join ( -- 特级护理 患者数
    select ORDERING_DEPT as dept_code,count(1) ct 
    from ORDERS@his 
    where START_DATE_TIME>= sDate and START_DATE_TIME < sDate+1 and order_text='特级护理'
    group by ORDERING_DEPT
  ) j on t.dept_code=j.dept_code
  --产后
  left join (-- 产后
    SELECT ordering_dept as dept_code,count(1) as ct FROM ORDERS@his  
    WHERE START_DATE_TIME>= sDate and START_DATE_TIME < sDate+1 AND 
          STOP_DATE_TIME >= sDate and START_DATE_TIME < sDate+1 AND         
         (ORDER_TEXT like '%单胎顺产接生%' or ORDER_TEXT like '%剖宫产%')         
    group by ordering_dept
  ) k on t.dept_code=k.dept_code
  left join (
    select DEPT_ADMISSION_TO as dept_code,count(1) as ct
    from PAT_VISIT@his
    where length(PATIENT_ID)>8 and DEPT_ADMISSION_TO='0828'
    and  ADMISSION_DATE_TIME>= sDate and ADMISSION_DATE_TIME < sDate+1
    group by DEPT_ADMISSION_TO  
  ) l on t.dept_code=l.dept_code
  
  
  order by t.dept_code;
end;




/*
  * Oracle 创建 split 和 splitstr 函数
  */
 
 /* 创建一个表类型 */
 create or replace type tabletype as table of VARCHAR2(32676)

 
 /* 创建 split 函数 */
 CREATE OR REPLACE FUNCTION split (p_list CLOB, p_sep VARCHAR2 := ',')
    RETURN tabletype
    PIPELINED
 /**************************************
  * Name:        split
  * Author:      Sean Zhang.
  * Date:        2012-09-03.
  * Function:    返回字符串被指定字符分割后的表类型。
  * Parameters:  p_list: 待分割的字符串。
                 p_sep: 分隔符，默认逗号，也可以指定字符或字符串。
  * Example:     SELECT *
                   FROM users
                  WHERE u_id IN (SELECT COLUMN_VALUE
                                 FROM table (split ('1,2')))
                 返回u_id为1和2的两行数据。
  **************************************/
 IS
    l_idx    PLS_INTEGER;
    v_list   VARCHAR2 (32676) := p_list;
 BEGIN
    LOOP
       l_idx   := INSTR (v_list, p_sep);
 
       IF l_idx > 0
       THEN
          PIPE ROW (SUBSTR (v_list, 1, l_idx - 1));
          v_list   := SUBSTR (v_list, l_idx + LENGTH (p_sep));
       ELSE
          PIPE ROW (v_list);
          EXIT;
       END IF;
    END LOOP;
 END;

 
 /* 创建 splitstr 函数 */
 CREATE OR REPLACE FUNCTION splitstr (str IN CLOB,
                                        i   IN NUMBER := 0,
                                        sep IN VARCHAR2 := ','
 )
    RETURN VARCHAR2
 /**************************************
  * Name:        splitstr
  * Author:      Sean Zhang.
  * Date:        2012-09-03.
  * Function:    返回字符串被指定字符分割后的指定节点字符串。
  * Parameters:  str: 待分割的字符串。
                 i: 返回第几个节点。当i为0返回str中的所有字符，当i 超过可被分割的个数时返回空。
                 sep: 分隔符，默认逗号，也可以指定字符或字符串。当指定的分隔符不存在于str中时返回sep中的字符。
  * Example:     select splitstr('abc,def', 1) as str from dual;  得到 abc
                 select splitstr('abc,def', 3) as str from dual;  得到 空
  **************************************/
 IS
    t_i       NUMBER;
    t_count   NUMBER;
    t_str     VARCHAR2 (4000);
 BEGIN
    IF i = 0
    THEN
       t_str   := str;
    ELSIF INSTR (str, sep) = 0
    THEN
       t_str   := sep;
    ELSE
       SELECT COUNT ( * )
       INTO t_count
       FROM table (split (str, sep));
 
       IF i <= t_count
       THEN
          SELECT str
          INTO t_str
          FROM (SELECT ROWNUM AS item, COLUMN_VALUE AS str
                FROM table (split (str, sep)))
          WHERE item = i;
       END IF;
    END IF;
 
    RETURN t_str;
 END;