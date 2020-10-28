-- One to Many

CREATE DATABASE one_to_many;

USE one_to_many;

CREATE TABLE mountains(
	mountain_id INT PRIMARY KEY,
	mountain_name VARCHAR(50)
);

CREATE TABLE peaks(
peak_id INT PRIMARY KEY,
peak_name VARCHAR(50),
mountain_id INT,
CONSTRAINT fk_peaks_mountains FOREIGN KEY(mountain_id)
REFERENCES mountains(mountain_id)
);

INSERT INTO mountains(mountain_id, mountain_name)
VALUES (1, 'Rila'), (2, 'Pirin')

INSERT INTO peaks (peak_id, peak_name, mountain_id)
VALUES (101, 'Musala', 1)


INSERT INTO peaks (peak_id, peak_name, mountain_id)
VALUES (102, 'Malyovitsa', 1)


SELECT * FROM mountains AS m
JOIN peaks AS p
 ON m.mountain_id = p.mountain_id

-- Cascade
CREATE DATABASE cascade_demo;

USE cascade_demo;

CREATE TABLE drivers(
driver_id INT PRIMARY KEY,
driver_name VARCHAR(50)
);

CREATE TABLE cars(
car_id INT PRIMARY KEY,
name VARCHAR(50),
driver_id INT UNIQUE,
CONSTRAINT fk_cars_drivers FOREIGN KEY(driver_id)
REFERENCES drivers(driver_id) ON UPDATE CASCADE
);


INSERT INTO drivers (driver_id,driver_name)
VALUES (1, 'Pesho')


INSERT INTO Cars(car_id, driver_id)
VALUES (101, 1)


UPDATE drivers
   SET driver_id = 2
 WHERE driver_id = 1
 
SELECT * FROM drivers;

SELECT * FROM cars;

-- Many to Many


CREATE TABLE Employees(
	EmployeeID INT PRIMARY KEY,
	FirstName VARCHAR(50)
);

CREATE TABLE Projects(
	ProjectID INT PRIMARY KEY,
	ProjectName VARCHAR(50)
);

INSERT INTO Employees (EmployeeID, FirstName)
VALUES (1, 'John'), (2, 'Adam');

INSERT INTO Projects (ProjectID, ProjectName)
VALUES (101, 'Web Store'), (102, 'Database Design'), 
(103, 'Android App');

CREATE TABLE EmployeesProjects(
EmployeeID INT,
ProjectID INT,
CONSTRAINT PK_EmployeesProjects PRIMARY KEY(EmployeeID, ProjectID),
CONSTRAINT FK_EmployeesProjects_Employees FOREIGN KEY(EmployeeID)
REFERENCES Employees(EmployeeID),
CONSTRAINT FK_EmployeesProjects_Projects FOREIGN KEY(ProjectID)
REFERENCES Projects(ProjectID)
);

-- Joins
SELECT e.employee_id, e.first_name, d.*, ep.*, p.*
  FROM employees AS e
 INNER JOIN departments AS d
    ON d.department_id = e.department_id
   AND e.manager_id = d.manager_id
 INNER JOIN employees_projects AS ep
    ON ep.employee_id = e.employee_id
 INNER JOIN projects AS p
    ON p.project_id = ep.project_id


-- Cross join
SELECT e.employee_id, e.first_name, d.*
  FROM employees AS e
 CROSS JOIN departments AS d
	 
-- Natural join 
  SELECT e.employee_id, e.first_name, d.*
    FROM employees AS e
 NATURAL JOIN departments AS d
 
 
 -- Subqueries
 -- 1 ID Department = Finance, Sales
-- 2 Select employees in 1
EXPLAIN
SELECT * 
  FROM employees AS e
 WHERE e.department_id IN
				(SELECT d.department_id
				   FROM departments AS d
				  WHERE d.name IN ('Finance', 'Sales')
				 )

EXPLAIN
SELECT * 
  FROM employees AS e
 INNER JOIN departments AS d
   ON e.department_id = d.department_id
WHERE d.name IN ('Finance', 'Sales')


-- Indexes

-- Secondary Index
EXPLAIN
SELECT e.first_name, e.salary 
  FROM employees AS e
 WHERE e.salary > 5425423


CREATE INDEX ix_employees_first_name_salary
    ON employees(first_name,salary)
    
INSERT INTO employees(....)
VALUES(....)


-- 
USE one_to_many;

CREATE TABLE Countries(
CointryID INT,
CountryName VARCHAR(60)
)

INSERT INTO Countries(CointryID, CountryName)
VALUES(1, 'Bulgaria'), (41, 'USA'), (20, 'UK')

SELECT * FROM Countries


ALTER TABLE countries
ADD CONSTRAINT pk_countries PRIMARY KEY(CointryID)

SELECT * FROM Countries
