--------------------------------------------------------------------
--softuni Databases Basics MySQL - Data Definitions and Data Types--
--Solutions for all exercises                                     --
--------------------------------------------------------------------

--Problem 1. Create Database
USE master;
CREATE DATABASE minions;

--Problem 2. Create Tables
USE minions;

CREATE TABLE IF NOT EXISTS minions
(
id INT NOT NULL AUTO_INCREMENT,
name VARCHAR(50) NOT NULL,
age INT NULL,
CONSTRAINT pk_minions PRIMARY KEY (id)
);

CREATE TABLE IF NOT EXISTS towns
(
id INT NOT NULL AUTO_INCREMENT,
name VARCHAR(50) NOT NULL,
CONSTRAINT pk_towns PRIMARY KEY (id)
);

--Problem 3. Alter minions Table
USE minions;

ALTER TABLE minions
ADD COLUMN town_id INT NOT NULL;
ALTER TABLE minions
ADD CONSTRAINT fk_minions_towns FOREIGN KEY (town_id) REFERENCES towns(id)

--Problem 4. Insert Records in Both Tables
USE minions;

--START Submission in Judge
INSERT INTO towns (name) VALUES ('Sofia');
INSERT INTO towns (name) VALUES ('Plovdiv'); 
INSERT INTO towns (name) VALUES ('Varna');

INSERT INTO minions (name, age, town_id) VALUES ('Kevin', 22, 1);
INSERT INTO minions (name, age, town_id) VALUES ('Bob', 15, 3);
INSERT INTO minions (name, age, town_id) VALUES ('Steward', NULL, 2);

SELECT * FROM minions;
SELECT * FROM towns;
--END Submission in Judge

--Problem 5. Truncate Table minions
USE minions;

TRUNCATE TABLE minions

--Problem 6. Drop All Tables
USE minions;

DROP TABLE towns
DROP TABLE minions

--Problem 7. Create Table people
USE minions;

--START Submission in Judge
CREATE TABLE IF NOT EXISTS people
(
id INT NOT NULL AUTO_INCREMENT,
name VARCHAR(200) NOT NULL,
picture BLOB,
height NUMERIC(10, 2),
weight NUMERIC(10, 2),
gender CHAR(1) NOT NULL,
birthdate DATETIME NOT NULL,
biography VARCHAR(10000),
CONSTRAINT pk_people PRIMARY KEY (id)
);

INSERT INTO people (name, picture, height, weight, gender, birthdate, biography) VALUES ('Kevin', NULL, 1.82, 82.24, 'm', '2001-02-01', 'Some biography here');
INSERT INTO people (name, picture, height, weight, gender, birthdate, biography) VALUES ('Marie Poppinz', NULL, 1.60, 40.55, 'f', '2001-03-01', 'Some biography here');
INSERT INTO people (name, picture, height, weight, gender, birthdate, biography) VALUES ('Steward', NULL, 1.84, 95.00, 'm', '2001-04-01', 'Some biography here');
INSERT INTO people (name, picture, height, weight, gender, birthdate, biography) VALUES ('Bob Bob', NULL, 1.86, 101.99, 'm', '2001-11-06', 'Some biography here');
INSERT INTO people (name, picture, height, weight, gender, birthdate, biography) VALUES ('An Ann Annie', NULL, 1.72, 60.22, 'f', '2001-12-01', 'Some biography here');

SELECT COUNT(*) FROM people;
--END Submission in Judge

--Problem 8. Create Table users
USE minions;

--START Submission in Judge
CREATE TABLE IF NOT EXISTS users
(
id BIGINT NOT NULL AUTO_INCREMENT,
username VARCHAR(30) NOT NULL,
password VARCHAR(26) NOT NULL,
profile_picture BLOB,
last_login_time DATETIME,
is_deleted INT,
CONSTRAINT pk_users PRIMARY KEY (id)
);

INSERT INTO users (username, password, profile_picture, last_login_time, is_deleted) VALUES ('pesho', '123456', NULL, NOW(), 0);
INSERT INTO users (username, password, profile_picture, last_login_time, is_deleted) VALUES ('gosho', '234567', NULL, NOW(), 0);
INSERT INTO users (username, password, profile_picture, last_login_time, is_deleted) VALUES ('mitko', '345678', NULL, NOW(), 1);
INSERT INTO users (username, password, profile_picture, last_login_time, is_deleted) VALUES ('cecko', '456789', NULL, NOW(), 0);
INSERT INTO users (username, password, profile_picture, last_login_time, is_deleted) VALUES ('bosko', '5678910', NULL, NOW(), 1);

SELECT COUNT(*) FROM users;
--END Submission in Judge

--Problem 9. Change Primary Key
USE minions;

ALTER TABLE users
	DROP PRIMARY KEY,
	ADD CONSTRAINT pk_users PRIMARY KEY (id, username);


--Problem 10. Set Default Value of a Field
USE minions;

ALTER TABLE users
	CHANGE COLUMN last_login_time last_login_time DATETIME NULL DEFAULT CURRENT_TIMESTAMP;

--Problem 11. Set Unique Field
USE minions;

ALTER TABLE users
	DROP PRIMARY KEY,
	ADD CONSTRAINT pk_users PRIMARY KEY (id),
	ADD CONSTRAINT uc_username UNIQUE (username);

--Problem 12. movies Database
CREATE DATABASE movies;
USE movies;

--START Submition in Judge
CREATE TABLE IF NOT EXISTS directors
(
id INT NOT NULL AUTO_INCREMENT,
director_name VARCHAR(50) NOT NULL,
notes VARCHAR(1000),
CONSTRAINT pk_directors PRIMARY KEY (id)
);

CREATE TABLE IF NOT EXISTS genres
(
id INT NOT NULL AUTO_INCREMENT,
genre_name VARCHAR(20) NOT NULL,
notes VARCHAR(1000),
CONSTRAINT pk_genres PRIMARY KEY (id)
);

CREATE TABLE IF NOT EXISTS categories
(
id INT NOT NULL AUTO_INCREMENT,
category_name VARCHAR(20) NOT NULL,
notes VARCHAR(1000),
CONSTRAINT pk_categories PRIMARY KEY (id)
);

CREATE TABLE IF NOT EXISTS movies
(
id INT NOT NULL AUTO_INCREMENT,
title VARCHAR(50) NOT NULL,
director_id INT NOT NULL,
copyright_year SMALLINT,
length INT,
genre_id INT,
category_id INT,
rating FLOAT,
notes VARCHAR(1000),
CONSTRAINT pk_movies PRIMARY KEY (id)
);

INSERT INTO directors (director_name, notes) VALUES ('Ben Affleck', 'sample notes');
INSERT INTO directors (director_name, notes) VALUES ('Woody Allen', 'sample notes');
INSERT INTO directors (director_name, notes) VALUES ('Luc Besson', 'sample notes');
INSERT INTO directors (director_name, notes) VALUES ('Cameron Crowe', 'sample notes');
INSERT INTO directors (director_name, notes) VALUES ('Clint Eastwood', 'sample notes');

INSERT INTO genres (genre_name, notes) VALUES ('Action', 'sample notes');
INSERT INTO genres (genre_name, notes) VALUES ('Comedy', 'sample notes');
INSERT INTO genres (genre_name, notes) VALUES ('Horror', 'sample notes');
INSERT INTO genres (genre_name, notes) VALUES ('Thriller', 'sample notes');
INSERT INTO genres (genre_name, notes) VALUES ('Drama', 'sample notes');

INSERT INTO categories (category_name, notes) VALUES ('0-3', 'suitable for infants');
INSERT INTO categories (category_name, notes) VALUES ('7-12', 'suitable for kids');
INSERT INTO categories (category_name, notes) VALUES ('12-16', 'suitable for teenagers');
INSERT INTO categories (category_name, notes) VALUES ('16-18', NULL);
INSERT INTO categories (category_name, notes) VALUES ('18+', 'suitable for adults');

INSERT INTO movies (title, director_id, copyright_year, length, genre_id, category_id, rating, notes) VALUES ('Titanic', 1, 1998, 181, 1, 4, 8.2, 'sample notes');
INSERT INTO movies (title, director_id, copyright_year, length, genre_id, category_id, rating, notes) VALUES ('Avatar', 4, 2008, 160, 2, 3, 9.22, 'sample notes');
INSERT INTO movies (title, director_id, copyright_year, length, genre_id, category_id, rating, notes) VALUES ('Rocky 1', 2, 1980, 90, 3, 1, 9.99, 'sample notes');
INSERT INTO movies (title, director_id, copyright_year, length, genre_id, category_id, rating, notes) VALUES ('Rocky 2', 3, 1983, 92, 5, 2, 10.1, 'sample notes');
INSERT INTO movies (title, director_id, copyright_year, length, genre_id, category_id, rating, notes) VALUES ('Rocky 3', 1, 1986, 95, 1, 5, 6.2, 'sample notes');

SELECT COUNT(*) FROM directors;
SELECT COUNT(*) FROM genres;
SELECT COUNT(*) FROM categories;
SELECT COUNT(*) FROM movies;
--END Submission in Judge

--Problem 13. Car Rental Database
CREATE DATABASE car_rental;
USE car_rental;

--START Submission in Judge
CREATE TABLE IF NOT EXISTS categories
(
id INT NOT NULL AUTO_INCREMENT,
category VARCHAR(20) NOT NULL,
daily_rate FLOAT,
weekly_rate FLOAT,
monthly_rate FLOAT,
weekend_rate FLOAT,
CONSTRAINT pk_categories PRIMARY KEY (id)
);

CREATE TABLE IF NOT EXISTS cars
(
id INT NOT NULL AUTO_INCREMENT,
plate_number VARCHAR(8) NOT NULL,
make VARCHAR(20) NOT NULL,
model VARCHAR(20) NOT NULL,
car_year INT,
category_id INT,
doors INT,
picture BLOB,
car_condition VARCHAR(20),
available INT,
CONSTRAINT pk_cars PRIMARY KEY (id)
);

CREATE TABLE IF NOT EXISTS employees
(
id INT NOT NULL AUTO_INCREMENT,
first_name VARCHAR(20) NOT NULL,
last_name VARCHAR(20) NOT NULL,
title VARCHAR(20),
notes VARCHAR(200),
CONSTRAINT pk_employees PRIMARY KEY (id)
);

CREATE TABLE IF NOT EXISTS customers
(
id INT NOT NULL AUTO_INCREMENT,
driver_licence_number VARCHAR(15) NOT NULL,
full_name VARCHAR(100) NOT NULL,
address VARCHAR(500),
city VARCHAR(50),
zip_code VARCHAR(10),
notes VARCHAR(200),
CONSTRAINT pk_customers PRIMARY KEY (id)
);

CREATE TABLE IF NOT EXISTS rental_orders
(
id INT NOT NULL AUTO_INCREMENT,
employee_id INT NOT NULL,
customer_id INT NOT NULL,
car_id INT NOT NULL,
car_condition VARCHAR(20),
tank_level DOUBLE(10, 2),
kilometrage_start INT,
kilometrage_end INT,
total_kilometrage INT,
start_date DATETIME,
end_date DATETIME,
total_days INT,
rate_applied INT,
tax_rate DOUBLE(10,2),
order_status VARCHAR(10),
notes VARCHAR(200),
CONSTRAINT pk_rental_orders PRIMARY KEY (id)
);

INSERT INTO categories (category) VALUES ('Car');
INSERT INTO categories (category) VALUES ('Truck'); 
INSERT INTO categories (category) VALUES ('Van');

INSERT INTO cars (plate_number, make, model) VALUES ('A1234AA', 'Opel', 'Omega');
INSERT INTO cars (plate_number, make, model) VALUES ('A6542AB', 'Ford', 'Focus');
INSERT INTO cars (plate_number, make, model) VALUES ('OB4444AP', 'Lada', 'Niva');

INSERT INTO employees (first_name, last_name) VALUES ('Ivan', 'Ivanov');
INSERT INTO employees (first_name, last_name) VALUES ('Petar', 'Petrov');
INSERT INTO employees (first_name, last_name) VALUES ('Misha', 'Mishav');

INSERT INTO customers (driver_licence_number, full_name) VALUES ('A12345', 'Ivan Ivanov Ivanov');
INSERT INTO customers (driver_licence_number, full_name) VALUES ('A12346', 'Ivan Ivanov Petrov');
INSERT INTO customers (driver_licence_number, full_name) VALUES ('A12342', 'Petar Ivanov Ivanov');

INSERT INTO rental_orders (employee_id, customer_id, car_id) VALUES (1, 2, 3);
INSERT INTO rental_orders (employee_id, customer_id, car_id) VALUES (2, 3, 1);
INSERT INTO rental_orders (employee_id, customer_id, car_id) VALUES (2, 2, 2);

SELECT COUNT(*) FROM categories;
SELECT COUNT(*) FROM cars;
SELECT COUNT(*) FROM employees;
SELECT COUNT(*) FROM customers;
SELECT COUNT(*) FROM rental_orders;
--END Submission in Judge

--Problem 14. hotel Database
CREATE DATABASE hotel;
USE hotel;

--START Submission in Judge
CREATE TABLE IF NOT EXISTS employees
(
id INT NOT NULL AUTO_INCREMENT,
first_name VARCHAR(50) NOT NULL,
last_name VARCHAR(50) NOT NULL,
title VARCHAR(20),
notes VARCHAR(200),
CONSTRAINT pk_employees PRIMARY KEY (id)
);

CREATE TABLE IF NOT EXISTS customers
(
account_number BIGINT NOT NULL,
first_name VARCHAR(50) NOT NULL,
last_name VARCHAR(50) NOT NULL,
phone_number VARCHAR(15) NOT NULL,
emergency_name VARCHAR(50),
emergency_number VARCHAR(15),
notes VARCHAR(200),
CONSTRAINT pk_customers PRIMARY KEY (account_number)
);

CREATE TABLE IF NOT EXISTS room_status
(
room_status VARCHAR(10) NOT NULL,
notes VARCHAR(200),
CONSTRAINT pk_room_status PRIMARY KEY (room_status)
);

CREATE TABLE IF NOT EXISTS room_types
(
room_type VARCHAR(10) NOT NULL,
notes VARCHAR(200),
CONSTRAINT pk_room_types PRIMARY KEY (room_type)
);

CREATE TABLE IF NOT EXISTS bed_types
(
bed_type VARCHAR(10) NOT NULL,
notes VARCHAR(200),
CONSTRAINT pk_bed_types PRIMARY KEY (bed_type)
);

CREATE TABLE IF NOT EXISTS rooms
(
room_number INT NOT NULL,
room_type VARCHAR(10) NOT NULL,
bed_type VARCHAR(10) NOT NULL,
rate DOUBLE(10, 2),
room_status VARCHAR(10) NOT NULL,
notes VARCHAR(200),
CONSTRAINT pk_rooms PRIMARY KEY (room_number)
);

CREATE TABLE IF NOT EXISTS payments
(
id INT NOT NULL AUTO_INCREMENT,
employee_id INT NOT NULL,
payment_date DATETIME NOT NULL,
account_number BIGINT NOT NULL,
first_date_occupied DATETIME,
last_date_occupied DATETIME,
total_days INT,
amount_charged DOUBLE(10,2) NOT NULL,
tax_rate DOUBLE(10,2),
tax_amount DOUBLE(10,2),
payment_total DOUBLE(10,2) NOT NULL,
notes VARCHAR(200),
CONSTRAINT pk_payments PRIMARY KEY (id)
);

CREATE TABLE IF NOT EXISTS occupancies
(
id INT NOT NULL AUTO_INCREMENT,
employee_id INT NOT NULL,
date_occupied DATETIME,
account_number BIGINT NOT NULL,
room_number INT NOT NULL,
rate_applied DOUBLE(10,2),
phone_charge DOUBLE(10,2),
notes VARCHAR(200),
CONSTRAINT pk_occupancies PRIMARY KEY (id)
);

INSERT INTO employees (first_name, last_name) VALUES ('Ivan', 'Ivanov');
INSERT INTO employees (first_name, last_name) VALUES ('Petar', 'Petrov');
INSERT INTO employees (first_name, last_name) VALUES ('Mitko', 'Dimitrov');

INSERT INTO customers(account_number, first_name, last_name, phone_number) VALUES (34545674545, 'Ivan', 'Petrov', '+35988999999');
INSERT INTO customers(account_number, first_name, last_name, phone_number) VALUES (35436554234, 'Misho', 'Petrovanov', '+359889965479');
INSERT INTO customers(account_number, first_name, last_name, phone_number) VALUES (12480934333, 'Nikolay', 'Nikov', '+35988999919');

INSERT INTO room_status (room_status) VALUES ('Occupied');
INSERT INTO room_status (room_status) VALUES ('Available');
INSERT INTO room_status (room_status) VALUES ('Cleaning');

INSERT INTO room_types (room_type) VALUES ('Single');
INSERT INTO room_types (room_type) VALUES ('Double');
INSERT INTO room_types (room_type) VALUES ('Apartment');

INSERT INTO bed_types (bed_type) VALUES ('Double');
INSERT INTO bed_types (bed_type) VALUES ('Queen');
INSERT INTO bed_types (bed_type) VALUES ('King');

INSERT INTO rooms (room_number, room_type, bed_type, room_status) VALUES (1, 'Single', 'Double', 'Available');
INSERT INTO rooms (room_number, room_type, bed_type, room_status) VALUES (2, 'Double', 'King', 'Available');
INSERT INTO rooms (room_number, room_type, bed_type, room_status) VALUES (12, 'Apartment', 'Queen', 'Occupied');

INSERT INTO payments (employee_id, payment_date, account_number, amount_charged, payment_total, tax_rate) VALUES (1, NOW(), 34545675676, 10.20, 12.20, 2.4);
INSERT INTO payments (employee_id, payment_date, account_number, amount_charged, payment_total, tax_rate) VALUES (3, NOW(), 34545675676, 220.20, 240.22, 2.1);
INSERT INTO payments (employee_id, payment_date, account_number, amount_charged, payment_total, tax_rate) VALUES (2, NOW(), 34545675676, 190.20, 215.88, 1.1);

INSERT INTO occupancies (employee_id, account_number, room_number) VALUES (1, 34545675676, 2);
INSERT INTO occupancies (employee_id, account_number, room_number) VALUES (2, 34545675676, 1);
INSERT INTO occupancies (employee_id, account_number, room_number) VALUES (2, 34545675676, 12);

SELECT COUNT(*) FROM employees;
SELECT COUNT(*) FROM customers;
SELECT COUNT(*) FROM room_status;
SELECT COUNT(*) FROM room_types;
SELECT COUNT(*) FROM bed_types;
SELECT COUNT(*) FROM rooms;
SELECT COUNT(*) FROM payments;
SELECT COUNT(*) FROM occupancies;
--END Submission in Judge

--Problem 15. Create softuni Database
CREATE DATABASE softuni;  

USE softuni;

CREATE TABLE IF NOT EXISTS towns
(
	id INT NOT NULL AUTO_INCREMENT,
	name VARCHAR(50),
	CONSTRAINT pk_towns PRIMARY KEY (id)
);

CREATE TABLE IF NOT EXISTS Addresses
(
	id INT NOT NULL AUTO_INCREMENT,
	address_text VARCHAR(100),
	town_id INT,
	CONSTRAINT pk_adresses PRIMARY KEY (id),
	CONSTRAINT fk_adresses_towns FOREIGN KEY (town_id) REFERENCES towns(id)
);

CREATE TABLE IF NOT EXISTS departments
(
	id INT NOT NULL AUTO_INCREMENT,
	name VARCHAR(50),
	CONSTRAINT pk_departments_id PRIMARY KEY (id)
);

CREATE TABLE IF NOT EXISTS employees
(
	id INT NOT NULL AUTO_INCREMENT,
	first_name VARCHAR(50),
	middle_name VARCHAR(50),
	last_name VARCHAR(50),
	job_title VARCHAR(20),
	department_id INT,
	hire_date DATETIME,
	salary DOUBLE(12,4),
	address_id INT,
	CONSTRAINT pk_employees PRIMARY KEY (id),
	CONSTRAINT fk_employees_deparments FOREIGN KEY (department_id) REFERENCES departments(id),
	CONSTRAINT fk_employees_addresses FOREIGN KEY (address_id) REFERENCES addresses(id)
);

--Problem 16. Backup Database
--BACKUP DATABASE soft_uni
	C:\> mysqldump -u root -p soft_uni > C:/SoftUni/soft_uni.sql

--RESTORE DATABASE softuni
	-- solution 1 :
	C:\> mysql -u root -p
	mysql> source C:/SoftUni/soft_uni.sql;
	
	-- solution 2 :
    C:\> mysql -u root -p < C:\SoftUni\soft_uni.sql

--Problem 17. Basic Insert
USE softuni;

INSERT INTO towns (name) VALUES ('Sofia');
INSERT INTO towns (name) VALUES ('Plovdiv'); 
INSERT INTO towns (name) VALUES ('Varna');
INSERT INTO towns (name) VALUES ('Burgas');

INSERT INTO departments (name) VALUES ('Engineering');
INSERT INTO departments (name) VALUES ('Sales');
INSERT INTO departments (name) VALUES ('Marketing');
INSERT INTO departments (name) VALUES ('Software Development'); 
INSERT INTO departments (name) VALUES ('Quality Assurance');

INSERT INTO employees (first_name, middle_name, last_name, job_title, department_id, hire_date, salary) VALUES ('Ivan', 'Ivanov', 'Ivanov', '.NET Developer', 4, '2013-02-01', 3500.00);
INSERT INTO employees (first_name, middle_name, last_name, job_title, department_id, hire_date, salary) VALUES ('Petar', 'Petrov', 'Petrov', 'Senior Engineer', 1, '2004-03-02', 4000.00);
INSERT INTO employees (first_name, middle_name, last_name, job_title, department_id, hire_date, salary) VALUES ('Maria', 'Petrova', 'Ivanova', 'Intern', 5, '2016-08-28', 525.25);
INSERT INTO employees (first_name, middle_name, last_name, job_title, department_id, hire_date, salary) VALUES ('Georgi', 'Terziev', 'Ivanov', 'CEO', 2, '2007-12-09', 3000.00);
INSERT INTO employees (first_name, middle_name, last_name, job_title, department_id, hire_date, salary) VALUES ('Peter', 'Pan', 'Pan', 'Intern', 3, '2016-08-28', 599.88);

--Problem 18. Basic Select All Fields
USE softuni;

--START Submission in Judge
SELECT * FROM towns;
SELECT * FROM departments;
SELECT * FROM employees;
--END Submission in Judge

--Problem 19. Basic Select All Fields and Order Them
USE softuni;

--START Submission in Judge
SELECT * FROM towns ORDER BY name;
SELECT * FROM departments ORDER BY name;
SELECT * FROM employees ORDER BY salary DESC;
--END Submission in Judge

--Problem 20. Basic Select Some Fields
USE softuni;

--START Submission in Judge
SELECT name FROM towns ORDER BY name;
SELECT name FROM departments ORDER BY name;
SELECT first_name, last_name, job_title, salary FROM employees ORDER BY salary DESC;
--END Submission in Judge

--Problem 21. Increase employees salary
USE Softuni;

--START Submission in Judge
UPDATE employees
SET salary = salary + salary * 0.1;
SELECT salary FROM employees;
--END Submission in Judge

--Problem 22. Decrease Tax rate
USE hotel;

--START Submission in Judge
UPDATE payments
SET tax_rate = tax_rate - tax_rate * 0.03;
SELECT tax_rate FROM payments;
--END Submission in Judge

--Problem 23. Delete All Records
USE hotel;

--START Submission in Judge
DELETE FROM occupancies;
SELECT COUNT(*) FROM occupancies;
--END Submission in Judge