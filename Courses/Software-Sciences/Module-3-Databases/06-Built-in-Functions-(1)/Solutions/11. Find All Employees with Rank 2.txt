SELECT *
FROM (
       SELECT EmployeeID,
              FirstName,
              LastName,
              Salary,
              DENSE_RANK() over (partition by Salary ORDER BY EmployeeID) AS Rank
       FROM Employees
       WHERE Salary BETWEEN 10000 AND 50000) AS MyTable
WHERE Rank = 2
ORDER BY Salary DESC