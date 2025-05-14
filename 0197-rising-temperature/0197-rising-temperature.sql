# Write your MySQL query statement below
SELECT A.id FROM Weather A,Weather B
WHERE DATEDIFF(A.recordDate , b.recordDate) = 1
AND A.temperature>B.temperature