  SELECT e.EmployeeID,
  	     e.FirstName,
  	     e.ManagerID,
  	     emp.FirstName AS ManagerName
    FROM Employees AS e
    JOIN Employees AS emp
      ON emp.EmployeeID = e.ManagerID
   WHERE e.ManagerID IN (3, 7)
ORDER BY E.EmployeeID