# Write your MySQL query statement below
SELECT project_id, ROUND(SUM(experience_years)/COUNT(p.employee_id),2) AS average_years
FROM Project p
JOIN Employee e
ON e.employee_id = p.employee_id
GROUP BY p.project_id