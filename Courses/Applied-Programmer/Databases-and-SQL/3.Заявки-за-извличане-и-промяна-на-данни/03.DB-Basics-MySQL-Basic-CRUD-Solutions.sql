-----------------------------------------------
--SoftUni Databases Basics MySQL - Basic CRUD--
--Solutions for all exercises                --
-----------------------------------------------

--PART I: SoftUni Database Queries
USE SoftUni;

--Problem 2. Find All Information About All Departments
SELECT * FROM departments;

--Problem 3. Find All Information About All Departments
SELECT name FROM departments;

--Problem 4. Find salary of Each Employee
SELECT first_name, last_name, salary 
FROM employees;

--Problem 5. Find Full Name of Each Employee
SELECT first_name, middle_name, last_name
FROM employees;

--Problem 6. Find Email Address of Each Employee
SELECT
	CONCAT(first_name, '.', last_name, '@softuni.bg') AS "Full Email Address"
FROM employees;

--Problem 7. Find All Different Employee's Salaries
SELECT DISTINCT salary FROM employees;

--Problem 8. Find All Information About employees
SELECT * FROM employees
WHERE job_title = 'Sales Representative';

--Problem 9. Find Names of All employees by salary in Range
SELECT first_name, last_name, job_title
FROM employees
WHERE salary BETWEEN 20000 AND 30000;

--Problem 10. Find Names of All employees
SELECT
	CONCAT(first_name, ' ', middle_name, ' ', last_name) AS "Full Name"
FROM employees
WHERE salary = 25000 OR salary = 14000 OR salary = 12500 OR salary = 23600;

SELECT
	CONCAT(first_name, ' ', middle_name, ' ', last_name) AS "Full Name"
FROM employees
WHERE salary IN (25000, 14000, 12500, 23600);

--Problem 11. Find All employees Without Manager
SELECT first_name, last_name FROM employees
WHERE manager_id IS NULL;

--Problem 12. Find All employees with salary More Than 50000
SELECT first_name, last_name, salary FROM employees
WHERE salary > 50000
ORDER BY salary DESC;

--Problem 13. Find 5 Best Paid employees
SELECT first_name, last_name FROM employees
ORDER BY salary DESC
LIMIT 5;

--Problem 14. Find All employees Except Marketing
SELECT first_name, last_name
FROM employees
WHERE department_id <> 4;

--Problem 15. Sort employees Table
SELECT * FROM employees
ORDER BY salary DESC, first_name ASC, last_name DESC, middle_name ASC;

--Problem 16. Create View employees with Salaries
CREATE VIEW v_employees_salaries AS
SELECT first_name, last_name, salary FROM employees;

SELECT * FROM v_employees_salaries;

--Problem 17. Create View employees with Job Titles
CREATE VIEW v_employees_job_titles AS
SELECT 
CONCAt(first_name, ' ', (case when middle_name IS NULL THEN '' ELSE middle_name END), ' ', last_name) AS "Full Name",
job_title
FROM employees;


--Problem 18. Distinct Job Titles
SELECT DISTINCT job_title FROM employees;

--Problem 19. Find First 10 Started Projects
SELECT * FROM Projects
ORDER BY start_date ASC, name ASC
LIMIT 10;

--Problem 20. Last 7 Hired employees
SELECT first_name, last_name, hire_date FROM employees
ORDER BY hire_date DESC
LIMIT 7;

--Problem 21. Increase Salaries
UPDATE employees
SET salary = salary + salary * 0.12
WHERE department_id IN (1, 2, 4, 11);

SELECT salary FROM employees;


--Part II: Geography Database Queries
USE Geography;

--Problem 22. All Mountain peaks
SELECT peak_name 
FROM peaks
ORDER BY peak_name;

--Problem 23. Biggest Countries by population
SELECT country_name, population
FROM countries
WHERE continent_code = 'EU'
ORDER BY population DESC, country_name
LIMIT 30;

--Problem 24. countries and Currency (Euro / Not Euro)
SELECT 
  country_name, country_code,
  (CASE WHEN currency_code='EUR' THEN 'Euro' ELSE 'Not Euro' END) AS Currency
FROM countries
ORDER BY country_name;

--PART II: Diablo Database Queries
USE Diablo;

--Problem 25. All Diablo characters
SELECT name
FROM characters
ORDER BY name;
