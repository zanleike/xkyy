--//{0}：开始日期，{1}：结束日期，{2}：科室编码，{3}：护士编码，{4}：护士名称
--  医嘱
select to_char(ENTER_DATE_TIME,'yyyy-MM-dd') as DateStr,count(1) as DateCount
from ORDERS@his t
inner join dept_vs_ward a on t.ordering_dept = a.Dept_Code
where 
    t.ENTER_DATE_TIME > to_date('{0}','yyyy-mm-dd') 
and t.ENTER_DATE_TIME < to_date('{1}','yyyy-mm-dd')
and a.Ward_code = '{2}'
and '{3}' = '{3}'
and t.Nurse = '{4}'
group by t.Nurse,to_char(ENTER_DATE_TIME,'yyyy-MM-dd')
order by to_char(ENTER_DATE_TIME,'yyyy-MM-dd')