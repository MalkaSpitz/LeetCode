# Write your MySQL query statement below
select s.user_id ,
    ROUND(ifnull(
        (sum(CASE WHEN c.action = "confirmed" THEN 1 else 0 END)/count(c.action)),
        0
        )
         ,2 ) as confirmation_rate
from Signups s
left join Confirmations c
on s.user_id = c.user_id 
group by s.user_id