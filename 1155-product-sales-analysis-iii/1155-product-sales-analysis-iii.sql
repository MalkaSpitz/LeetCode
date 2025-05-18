# Write your MySQL query statement below
SELECT  p.product_id, year AS first_year,  p.quantity,p.price 
FROM Sales p
WHERE (product_id,year) in (
    SELECT product_id, MIN(year)
    FROM Sales
    GROUP BY product_id 
)
