# Write your MySQL query statement below
SELECT start.machine_id , ROUND(AVG(end.timestamp-start.timestamp),3) AS processing_time
FROM Activity start
JOIN Activity end 
ON start.machine_id = end.machine_id 
AND start.process_id= end.process_id 
AND end.activity_type ="end" 
AND start.activity_type ="start" 
GROUP BY start.machine_id;