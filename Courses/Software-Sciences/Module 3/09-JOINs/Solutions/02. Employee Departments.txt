  SELECT TOP (5)
		 e.EmployeeID,
		 e.FirstName,
		 e.Salary,
		 d.[Name] AS DepartmentName
    FROM Employees AS e
    JOIN Departments AS d
      ON (d.DepartmentID = e.DepartmentID AND e.Salary > 15000)
ORDER BY e.DepartmentID