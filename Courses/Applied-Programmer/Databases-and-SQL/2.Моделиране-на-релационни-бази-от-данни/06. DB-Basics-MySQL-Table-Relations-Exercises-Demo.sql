-- MySQL 

CREATE TABLE passports(
passport_id INT PRIMARY KEY,
passport_number VARCHAR(50)
);

CREATE TABLE persons(
person_id INT PRIMARY KEY,
first_name VARCHAR(50),
salary DECIMAL(10,2),
passport_id INT UNIQUE,
CONSTRAINT fk_persons_passports FOREIGN KEY(passport_id)
REFERENCES passports(passport_id)
)


-- 4
CREATE TABLE teachers(
teacher_id INT PRIMARY KEY,
name VARCHAR(50),
manager_id INT,
CONSTRAINT fk_teachers_teachers FOREIGN KEY(manager_id)
REFERENCES teachers(teacher_id)
)


-- 5

CREATE DATABASE online_store;

USE online_store;

CREATE TABLE cities(
city_id INT PRIMARY KEY,
name VARCHAR(50)
);

CREATE TABLE customers(
customer_id INT PRIMARY KEY,
name VARCHAR(50),
birthday DATE,
city_id INT,
CONSTRAINT fk_customers_cities FOREIGN KEY(city_id)
REFERENCES cities(city_id)
);

CREATE TABLE orders(
order_id INT PRIMARY KEY,
customer_id INT,
CONSTRAINT fk_orders_customers FOREIGN KEY(customer_id)
REFERENCES customers(customer_id)
);

CREATE TABLE item_types(
item_type_id INT PRIMARY KEY,
name VARCHAR(50)
);

CREATE TABLE items(
item_id INT PRIMARY KEY,
name VARCHAR(50),
item_type_id INT,
CONSTRAINT fk_items_item_types FOREIGN KEY(item_type_id)
REFERENCES item_types(item_type_id)
);

CREATE TABLE order_items(
order_id INT,
item_id INT,
CONSTRAINT pk_order_items PRIMARY KEY (order_id, item_id),
CONSTRAINT fk_order_items_orders FOREIGN KEY(order_id)
REFERENCES orders(order_id),
CONSTRAINT fk_order_items_items FOREIGN KEY(item_id)
REFERENCES items(item_id)
)

-- 11

SELECT e.employee_id, e.first_name 
  FROM employees AS e
  LEFT JOIN employees_projects AS ep
    ON e.employee_id = ep.employee_id
 WHERE ep.project_id IS NULL
 ORDER BY e.employee_id ASC
 LIMIT 3
