SELECT
    manager.name    -- מספר העובדים הכפופים לו
FROM
    Employee reporter                   -- טבלה עבור העובדים (כפופים)
JOIN
    Employee manager ON reporter.managerId = manager.id -- הצמדה של כל עובד למנהל שלו
GROUP BY
    manager.id, manager.name            -- קיבוץ לפי מזהה ושם המנהל
HAVING
    COUNT(reporter.id) >= 5;  