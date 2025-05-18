# Write your MySQL query statement below
SELECT contest_id ,ROUND(
    (COUNT(r.user_id)/(SELECT COUNT(*) FROM Users))*100
    ,2) AS percentage
FROM  Register r
GROUP BY r.contest_id
order by percentage desc,contest_id