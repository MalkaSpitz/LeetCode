# Write your MySQL query statement below
select  Visits.customer_id,COUNT(*) AS count_no_trans
FROM Visits
LEFT JOIN Transactions on Visits.visit_id=Transactions.visit_id
WHERE Transactions.visit_id IS NULL
GROUP BY CUSTOMER_ID