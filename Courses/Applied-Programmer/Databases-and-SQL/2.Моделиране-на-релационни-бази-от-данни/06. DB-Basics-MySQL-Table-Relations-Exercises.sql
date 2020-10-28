-- 01 One-To-One Relationship 
CREATE TABLE passports(
passport_id INT PRIMARY KEY,
passport_number VARCHAR(50)
);

CREATE TABLE persons(
person_id INT PRIMARY KEY,
first_name VARCHAR(50),
salary DECIMAL(8,2),
passport_id INT UNIQUE,
CONSTRAINT fk_persons_passports FOREIGN KEY(passport_id) REFERENCES passports(passport_id)
);

INSERT INTO passports(passport_id, passport_number)
VALUES
(101, 'N34FG21B'),
(102, 'K65LO4R7'),
(103, 'ZE657QP2');


INSERT INTO persons(person_id, first_name, salary, passport_id)
VALUES
(1, 'Roberto', 43300.00, 102),
(2, 'Tom', 56100.00, 103),
(3, 'Yana', 60200.00, 101);

# table persons name and column names check
SELECT lower(table_name)
	 FROM information_schema.TABLES 
WHERE TABLE_SCHEMA = database() and lower(TABLE_NAME) = 'persons';
	 SELECT lower(COLUMN_NAME) 
FROM information_schema.COLUMNS 
WHERE TABLE_SCHEMA = database() and lower(TABLE_NAME) = 'persons';

# table passports name and column names check
SELECT lower(table_name)
	 FROM information_schema.TABLES 
WHERE TABLE_SCHEMA = database() and lower(TABLE_NAME) = 'passports';
	 SELECT lower(COLUMN_NAME) 
FROM information_schema.COLUMNS 
WHERE TABLE_SCHEMA = database() and lower(TABLE_NAME) = 'passports';
   
# primary keys check

SELECT TABLE_NAME, COUNT(*) AS pk_count
  FROM information_schema.COLUMNS
 WHERE TABLE_SCHEMA = DATABASE()
   AND COLUMN_KEY = 'PRI'
   AND TABLE_NAME IN ('passports', 'persons')
 GROUP BY TABLE_NAME
 ORDER BY TABLE_NAME;
 
 # check if persons.passport_id has unique constraint

SELECT lower(column_name)
    FROM INFORMATION_SCHEMA.columns
    WHERE TABLE_SCHEMA = database()
    and lower(table_name) = 'persons '
	and column_name = 'passport_id'
	 and column_key = 'UNI';
	 
	 
# foreign key check

SELECT 
  lower(TABLE_NAME) tn,lower(COLUMN_NAME) cn, lower(REFERENCED_TABLE_NAME) ref_tn,lower(REFERENCED_COLUMN_NAME) ref_cn
FROM
  INFORMATION_SCHEMA.KEY_COLUMN_USAGE
WHERE
  REFERENCED_TABLE_SCHEMA = database() AND
  lower(REFERENCED_COLUMN_NAME) = 'passport_id' AND 
  lower(REFERENCED_TABLE_NAME) = 'passports';
 
# data insertion check

select * from 
persons per inner join passports pas on per.passport_id = pas.passport_id
order by per.person_id; 


-- 02 One-To-Many Relationship
CREATE TABLE manufacturers(
manufacturer_id INT PRIMARY KEY,
name VARCHAR(50),
established_on DATE);

CREATE TABLE models(
model_id INT PRIMARY KEY,
name VARCHAR(50),
manufacturer_id INT,
CONSTRAINT fk_models_manufacturer FOREIGN KEY(manufacturer_id) REFERENCES manufacturers(manufacturer_id)
);

INSERT INTO manufacturers (manufacturer_id, name, established_on)
VALUES
(1, 'BMW', '19160301'),
(2, 'Tesla', '20030101'),
(3, 'Lada', '19660501');

INSERT INTO models(model_id, name, manufacturer_id)
VALUES
(101, 'X1', 1),
(102, 'i6', 1),
(103, 'Model S', 2),
(104, 'Model X', 2),
(105, 'Model 3', 2),
(106, 'Nova', 3);

# table names and column names check
SELECT lower(table_name)
	 FROM information_schema.TABLES 
WHERE TABLE_SCHEMA = database() and lower(TABLE_NAME) = 'manufacturers';
	 SELECT lower(COLUMN_NAME) 
FROM information_schema.COLUMNS 
WHERE TABLE_SCHEMA = database() and lower(TABLE_NAME) = 'manufacturers';

SELECT lower(table_name)
	 FROM information_schema.TABLES 
WHERE TABLE_SCHEMA = database() and lower(TABLE_NAME) = 'models';
	 SELECT lower(COLUMN_NAME) 
FROM information_schema.COLUMNS 
WHERE TABLE_SCHEMA = database() and lower(TABLE_NAME) = 'models';
   
# primary kes check

SELECT TABLE_NAME, COUNT(*) AS pk_count
  FROM information_schema.COLUMNS
 WHERE TABLE_SCHEMA = DATABASE()
   AND COLUMN_KEY = 'PRI'
   AND TABLE_NAME IN ('manufacturers', 'models')
 GROUP BY TABLE_NAME
 ORDER BY TABLE_NAME;
 
# FK check

SELECT TABLE_NAME, COLUMN_NAME,  COUNT(*) AS pk_count
  FROM information_schema.COLUMNS
 WHERE TABLE_SCHEMA = DATABASE()
   AND COLUMN_KEY = 'MUL'
   AND TABLE_NAME IN ('manufacturers', 'models')
 GROUP BY TABLE_NAME, COLUMN_NAME
 ORDER BY TABLE_NAME, COLUMN_NAME;
 
 # data check

select man.manufacturer_id, man.name, date(man.established_on), m.model_id, m.name from 
manufacturer man inner join models m on man.manufacturer_id = m.manufacturer_id
order by man.manufacturer_id;
 
-- 03 Many-To-Many Relationship
CREATE TABLE students(
student_id INT PRIMARY KEY,
name VARCHAR(50)
);

CREATE TABLE exams(
exam_id INT PRIMARY KEY,
name VARCHAR(50)
);

CREATE TABLE students_exams(
student_id INT,
exam_id INT,
CONSTRAINT pk_students_exams PRIMARY KEY(student_id, exam_id),
CONSTRAINT fk_students_exams_students FOREIGN KEY(student_id) REFERENCES students(student_id),
CONSTRAINT fk_students_exams_exams FOREIGN KEY(exam_id) REFERENCES exams(exam_id)
);

INSERT INTO students(student_id, name)
VALUES
(1, 'Mila'),                                     
(2, 'Toni'),
(3, 'Ron');

INSERT INTO exams(exam_id, name)
VALUES 
(101, 'Spring MVC'),
(102, 'Neo4j'),
(103, 'Oracle 11g');

INSERT INTO students_exams(student_id, exam_id)
VALUES
(1, 101),
(1, 102),
(2, 101),
(3, 103),
(2, 102),
(2, 103);

# check tables and column names

SELECT lower(table_name)
	 FROM information_schema.TABLES 
WHERE TABLE_SCHEMA = database() and lower(TABLE_NAME) = 'students';
	 SELECT lower(COLUMN_NAME) 
FROM information_schema.COLUMNS 
WHERE TABLE_SCHEMA = database() and lower(TABLE_NAME) = 'students';

SELECT lower(table_name)
	 FROM information_schema.TABLES 
WHERE TABLE_SCHEMA = database() and lower(TABLE_NAME) = 'exams';
	 SELECT lower(COLUMN_NAME) 
FROM information_schema.COLUMNS 
WHERE TABLE_SCHEMA = database() and lower(TABLE_NAME) = 'exams';

SELECT lower(table_name)
	 FROM information_schema.TABLES 
WHERE TABLE_SCHEMA = database() and lower(TABLE_NAME) = 'students_exams';
	 SELECT lower(COLUMN_NAME) 
FROM information_schema.COLUMNS 
WHERE TABLE_SCHEMA = database() and lower(TABLE_NAME) = 'students_exams';

# tables PK check

SELECT COLUMN_NAME AS pk_count
  FROM information_schema.COLUMNS
 WHERE TABLE_SCHEMA = DATABASE()
   AND COLUMN_KEY = 'PRI'
   AND TABLE_NAME IN ('students');
   
   SELECT COLUMN_NAME AS pk_count
  FROM information_schema.COLUMNS
 WHERE TABLE_SCHEMA = DATABASE()
   AND COLUMN_KEY = 'PRI'
   AND TABLE_NAME IN ('exams');
   
   SELECT COLUMN_NAME AS pk_count
  FROM information_schema.COLUMNS
 WHERE TABLE_SCHEMA = DATABASE()
   AND COLUMN_KEY = 'PRI'
   AND TABLE_NAME IN ('students_exams');
   
   # fk_students_exams_students check

SELECT 
  lower(TABLE_NAME) tn,lower(COLUMN_NAME) cn, lower(REFERENCED_TABLE_NAME) ref_tn,lower(REFERENCED_COLUMN_NAME) ref_cn
FROM
  INFORMATION_SCHEMA.KEY_COLUMN_USAGE
WHERE
  REFERENCED_TABLE_SCHEMA = database() AND
  lower(REFERENCED_COLUMN_NAME) = 'student_id' AND 
  lower(REFERENCED_TABLE_NAME) = 'students';
  
  
  # fk_students_exams_exams check

SELECT 
  lower(TABLE_NAME) tn,lower(COLUMN_NAME) cn, lower(REFERENCED_TABLE_NAME) ref_tn,lower(REFERENCED_COLUMN_NAME) ref_cn
FROM
  INFORMATION_SCHEMA.KEY_COLUMN_USAGE
WHERE
  REFERENCED_TABLE_SCHEMA = database() AND
  lower(REFERENCED_COLUMN_NAME) = 'exam_id' AND 
  lower(REFERENCED_TABLE_NAME) = 'exams';
  
  
  # data check

select * from 
students s inner join students_exams se on s.student_id = se.student_id 
inner join exams e on e.exam_id = se.exam_id
order by s.student_id, e.exam_id;


-- 04 Self-join 

CREATE TABLE teachers(
teacher_id INT PRIMARY KEY,
name VARCHAR(50),
manager_id INT);

INSERT INTO teachers(teacher_id, name, manager_id)
VALUES
(101, 'John', NULL),
(102, 'Maya', 106),
(103, 'Silvia', 106),
(104, 'Ted', 105),
(105, 'Mark', 101),
(106, 'Greta', 101);

ALTER TABLE teachers
ADD CONSTRAINT fk_teachers_teachers FOREIGN KEY(manager_id) REFERENCES teachers(teacher_id);

# test 1 : 'teachers' table name

SELECT lower(table_name)
	 FROM information_schema.TABLES 
WHERE TABLE_SCHEMA = database() and lower(TABLE_NAME) = 'teachers';

# test 2 : 'teachers' column names

SELECT lower(COLUMN_NAME) 
FROM information_schema.COLUMNS 
WHERE TABLE_SCHEMA = database() and lower(TABLE_NAME) = 'teachers';

# test 3 : table teachers PK check

SELECT COLUMN_NAME AS pk_count
  FROM information_schema.COLUMNS
 WHERE TABLE_SCHEMA = DATABASE()
   AND COLUMN_KEY = 'PRI'
   AND TABLE_NAME IN ('teachers');
   
# FK check

SELECT 
  lower(TABLE_NAME) tn,lower(COLUMN_NAME) cn, lower(REFERENCED_TABLE_NAME) ref_tn,lower(REFERENCED_COLUMN_NAME) ref_cn
FROM
  INFORMATION_SCHEMA.KEY_COLUMN_USAGE
WHERE
  REFERENCED_TABLE_SCHEMA = database() AND
  lower(REFERENCED_COLUMN_NAME) = 'teacher_id' AND 
  lower(REFERENCED_TABLE_NAME) = 'teachers';
  
  # test 5 : data check

select * from 
teachers 
order by teacher_id;

-- 05 Online Store Database

CREATE TABLE cities(
	city_id int,
	name varchar(50),
 CONSTRAINT pk_cities PRIMARY KEY (city_id)
 );

CREATE TABLE customers(
	customer_id int,
	name varchar(50),
	birthday date,
	city_id int,
 CONSTRAINT pk_customers PRIMARY KEY(customer_id)
 );

CREATE TABLE items(
	item_id int,
	name varchar(50),
	item_type_id int,
 CONSTRAINT pk_items PRIMARY KEY (item_id)
);

CREATE TABLE item_types(
	item_type_id int,
	name varchar(50),
 CONSTRAINT pk_item_types PRIMARY KEY (item_type_id)
 );

CREATE TABLE order_items(
	order_id int,
	item_id int,
 CONSTRAINT pk_order_items PRIMARY KEY (order_id,item_id)
 );

CREATE TABLE orders(
	order_id int,
	customer_id int,
 CONSTRAINT pk_orders PRIMARY KEY (order_id)
 );

ALTER TABLE customers ADD CONSTRAINT fk_customers_cities FOREIGN KEY(city_id)
REFERENCES cities (city_id);

ALTER TABLE items ADD CONSTRAINT fk_items_item_types FOREIGN KEY(item_type_id)
REFERENCES item_types (item_type_id);

ALTER TABLE order_items ADD CONSTRAINT fk_order_items_items FOREIGN KEY(item_id)
REFERENCES items (item_id);

ALTER TABLE order_items  ADD CONSTRAINT fk_order_items_orders FOREIGN KEY(order_id)
REFERENCES orders (order_id);

ALTER TABLE orders ADD CONSTRAINT fk_orders_customers FOREIGN KEY(customer_id)
REFERENCES customers (customer_id);

# test 1 : 'orders' table name, column names, column types and PK check

SELECT lower(table_name)
	 FROM information_schema.TABLES 
WHERE TABLE_SCHEMA = database() and lower(TABLE_NAME) = 'orders';
	 SELECT lower(COLUMN_NAME), lower(COLUMN_TYPE)
FROM information_schema.COLUMNS 
WHERE TABLE_SCHEMA = database() and lower(TABLE_NAME) = 'orders';

SELECT COLUMN_NAME AS pk_count
  FROM information_schema.COLUMNS
 WHERE TABLE_SCHEMA = DATABASE()
   AND COLUMN_KEY = 'PRI'
   AND TABLE_NAME IN ('orders');
   
# test 2 : 'customers' table name, column names, column types and PK check

SELECT lower(table_name)
	 FROM information_schema.TABLES 
WHERE TABLE_SCHEMA = database() and lower(TABLE_NAME) = 'customers';
	 SELECT lower(COLUMN_NAME), lower(COLUMN_TYPE)
FROM information_schema.COLUMNS 
WHERE TABLE_SCHEMA = database() and lower(TABLE_NAME) = 'customers';

SELECT COLUMN_NAME
  FROM information_schema.COLUMNS
 WHERE TABLE_SCHEMA = database()
   AND COLUMN_KEY = 'PRI'
   AND TABLE_NAME = 'customers';
   
# test 3 : 'cities' table name, column names, column types and PK check

SELECT lower(table_name)
	 FROM information_schema.TABLES 
WHERE TABLE_SCHEMA = database() and lower(TABLE_NAME) = 'cities';
	 SELECT lower(COLUMN_NAME), lower(COLUMN_TYPE)
FROM information_schema.COLUMNS 
WHERE TABLE_SCHEMA = database() and lower(TABLE_NAME) = 'cities';

SELECT COLUMN_NAME
  FROM information_schema.COLUMNS
 WHERE TABLE_SCHEMA = database()
   AND COLUMN_KEY = 'PRI'
   AND TABLE_NAME = 'cities';
   
# test 4 : 'items' table name, column names, column types and PK check

SELECT lower(table_name)
	 FROM information_schema.TABLES 
WHERE TABLE_SCHEMA = database() and lower(TABLE_NAME) = 'items';
	 SELECT lower(COLUMN_NAME), lower(COLUMN_TYPE)
FROM information_schema.COLUMNS 
WHERE TABLE_SCHEMA = database() and lower(TABLE_NAME) = 'items';

SELECT COLUMN_NAME
  FROM information_schema.COLUMNS
 WHERE TABLE_SCHEMA = database()
   AND COLUMN_KEY = 'PRI'
   AND TABLE_NAME = 'items';
   
# test 5 : 'item_types' table name, column names, column types and PK check

SELECT lower(table_name)
	 FROM information_schema.TABLES 
WHERE TABLE_SCHEMA = database() and lower(TABLE_NAME) = 'item_types';
	 SELECT lower(COLUMN_NAME), lower(COLUMN_TYPE)
FROM information_schema.COLUMNS 
WHERE TABLE_SCHEMA = database() and lower(TABLE_NAME) = 'item_types';

SELECT COLUMN_NAME
  FROM information_schema.COLUMNS
 WHERE TABLE_SCHEMA = database()
   AND COLUMN_KEY = 'PRI'
   AND TABLE_NAME = 'item_types';
   
# test 6 : 'order_items' table name, column names, column types and PK check

SELECT lower(table_name)
	 FROM information_schema.TABLES 
WHERE TABLE_SCHEMA = database() and lower(TABLE_NAME) = 'order_items';
	 SELECT lower(COLUMN_NAME), lower(COLUMN_TYPE)
FROM information_schema.COLUMNS 
WHERE TABLE_SCHEMA = database() and lower(TABLE_NAME) = 'order_items';

SELECT COLUMN_NAME
  FROM information_schema.COLUMNS
 WHERE TABLE_SCHEMA = database()
   AND COLUMN_KEY = 'PRI'
   AND TABLE_NAME = 'order_items';
   
# test 7 : fk_customers_cities check

SELECT 
  lower(TABLE_NAME) tn,lower(COLUMN_NAME) cn, lower(REFERENCED_TABLE_NAME) ref_tn,lower(REFERENCED_COLUMN_NAME) ref_cn
FROM
  INFORMATION_SCHEMA.KEY_COLUMN_USAGE
WHERE
  REFERENCED_TABLE_SCHEMA = database() AND
  lower(REFERENCED_COLUMN_NAME) = 'city_id' AND 
  lower(REFERENCED_TABLE_NAME) = 'cities';
  
# test 8 : fk_items_item_types check

SELECT 
  lower(TABLE_NAME) tn,lower(COLUMN_NAME) cn, lower(REFERENCED_TABLE_NAME) ref_tn,lower(REFERENCED_COLUMN_NAME) ref_cn
FROM
  INFORMATION_SCHEMA.KEY_COLUMN_USAGE
WHERE
  REFERENCED_TABLE_SCHEMA = database() AND
  lower(REFERENCED_COLUMN_NAME) = 'item_type_id' AND 
  lower(REFERENCED_TABLE_NAME) = 'item_types';
  
# test 9 : fk_order_items_items check

SELECT 
  lower(TABLE_NAME) tn,lower(COLUMN_NAME) cn, lower(REFERENCED_TABLE_NAME) ref_tn,lower(REFERENCED_COLUMN_NAME) ref_cn
FROM
  INFORMATION_SCHEMA.KEY_COLUMN_USAGE
WHERE
  REFERENCED_TABLE_SCHEMA = database() AND
  lower(REFERENCED_COLUMN_NAME) = 'item_id' AND 
  lower(REFERENCED_TABLE_NAME) = 'items';
  
# test 10 : fk_order_items_orders check

SELECT 
  lower(TABLE_NAME) tn,lower(COLUMN_NAME) cn, lower(REFERENCED_TABLE_NAME) ref_tn,lower(REFERENCED_COLUMN_NAME) ref_cn
FROM
  INFORMATION_SCHEMA.KEY_COLUMN_USAGE
WHERE
  REFERENCED_TABLE_SCHEMA = database() AND
  lower(REFERENCED_COLUMN_NAME) = 'order_id' AND 
  lower(REFERENCED_TABLE_NAME) = 'orders';
  
# test 11 : fk_orders_customers check

SELECT 
  lower(TABLE_NAME) tn,lower(COLUMN_NAME) cn, lower(REFERENCED_TABLE_NAME) ref_tn,lower(REFERENCED_COLUMN_NAME) ref_cn
FROM
  INFORMATION_SCHEMA.KEY_COLUMN_USAGE
WHERE
  REFERENCED_TABLE_SCHEMA = database() AND
  lower(REFERENCED_COLUMN_NAME) = 'customer_id' AND 
  lower(REFERENCED_TABLE_NAME) = 'customers';

-- 06 University Database

CREATE TABLE majors(
major_id INT PRIMARY KEY,
name VARCHAR(50)
);

CREATE TABLE students(
student_id INT PRIMARY KEY,
student_number VARCHAR(12),
student_name VARCHAR(50),
major_id INT,
CONSTRAINT fk_students_majors FOREIGN KEY(major_id) REFERENCES majors(major_id)
);

CREATE TABLE payments(
payment_id INT PRIMARY KEY, 
payment_date DATE,
payment_amount DECIMAL(8,2),
student_id INT,
CONSTRAINT fk_payments_students FOREIGN KEY (student_id) REFERENCES students(student_id)
);

CREATE TABLE subjects(
subject_id INT PRIMARY KEY,
subject_name VARCHAR(50)
);

CREATE TABLE agenda(
student_id INT,
subject_id INT,
CONSTRAINT pk_agenda PRIMARY KEY(student_id, subject_id),
CONSTRAINT fk_agenda_subjects FOREIGN KEY(subject_id) REFERENCES subjects(subject_id),
CONSTRAINT fk_agenda_students FOREIGN KEY(student_id) REFERENCES students(student_id)
);

# test 1 : 'majors' table name, column names, column types and PK check

SELECT lower(table_name)
	 FROM information_schema.TABLES 
WHERE TABLE_SCHEMA = database() and lower(TABLE_NAME) = 'majors';
	 SELECT lower(COLUMN_NAME), lower(COLUMN_TYPE)
FROM information_schema.COLUMNS 
WHERE TABLE_SCHEMA = database() and lower(TABLE_NAME) = 'majors';

SELECT COLUMN_NAME AS pk_count
  FROM information_schema.COLUMNS
 WHERE TABLE_SCHEMA = DATABASE()
   AND COLUMN_KEY = 'PRI'
   AND TABLE_NAME IN ('majors');
   
# test 2 : 'students' table name, column names, column types and PK check

SELECT lower(table_name)
	 FROM information_schema.TABLES 
WHERE TABLE_SCHEMA = database() and lower(TABLE_NAME) = 'students';
	 SELECT lower(COLUMN_NAME), lower(COLUMN_TYPE)
FROM information_schema.COLUMNS 
WHERE TABLE_SCHEMA = database() and lower(TABLE_NAME) = 'students';

SELECT COLUMN_NAME
  FROM information_schema.COLUMNS
 WHERE TABLE_SCHEMA = database()
   AND COLUMN_KEY = 'PRI'
   AND TABLE_NAME = 'students';
   
# test 3 : 'payments' table name, column names, column types and PK check

SELECT lower(table_name)
	 FROM information_schema.TABLES 
WHERE TABLE_SCHEMA = database() and lower(TABLE_NAME) = 'payments';
	 SELECT lower(COLUMN_NAME), lower(COLUMN_TYPE)
FROM information_schema.COLUMNS 
WHERE TABLE_SCHEMA = database() and lower(TABLE_NAME) = 'payments';

SELECT COLUMN_NAME
  FROM information_schema.COLUMNS
 WHERE TABLE_SCHEMA = database()
   AND COLUMN_KEY = 'PRI'
   AND TABLE_NAME = 'payments';
   
# test 4 : 'subjects' table name, column names, column types and PK check

SELECT lower(table_name)
	 FROM information_schema.TABLES 
WHERE TABLE_SCHEMA = database() and lower(TABLE_NAME) = 'subjects';
	 SELECT lower(COLUMN_NAME), lower(COLUMN_TYPE)
FROM information_schema.COLUMNS 
WHERE TABLE_SCHEMA = database() and lower(TABLE_NAME) = 'subjects';

SELECT COLUMN_NAME
  FROM information_schema.COLUMNS
 WHERE TABLE_SCHEMA = database()
   AND COLUMN_KEY = 'PRI'
   AND TABLE_NAME = 'subjects';
   
   
# test 5 : 'agenda' table name, column names, column types and PK check

SELECT lower(table_name)
	 FROM information_schema.TABLES 
WHERE TABLE_SCHEMA = database() and lower(TABLE_NAME) = 'agenda';
	 SELECT lower(COLUMN_NAME), lower(COLUMN_TYPE)
FROM information_schema.COLUMNS 
WHERE TABLE_SCHEMA = database() and lower(TABLE_NAME) = 'agenda';

SELECT COLUMN_NAME
  FROM information_schema.COLUMNS
 WHERE TABLE_SCHEMA = database()
   AND COLUMN_KEY = 'PRI'
   AND TABLE_NAME = 'agenda';
   
# test 6 : fk_students_majors check

SELECT 
  lower(TABLE_NAME) tn,lower(COLUMN_NAME) cn, lower(REFERENCED_TABLE_NAME) ref_tn,lower(REFERENCED_COLUMN_NAME) ref_cn
FROM
  INFORMATION_SCHEMA.KEY_COLUMN_USAGE
WHERE
  REFERENCED_TABLE_SCHEMA = database() AND
  lower(REFERENCED_COLUMN_NAME) = 'major_id' AND 
  lower(REFERENCED_TABLE_NAME) = 'majors';
  
  
# test 7 : fk_payment_students check

SELECT 
  lower(TABLE_NAME) tn,lower(COLUMN_NAME) cn, lower(REFERENCED_TABLE_NAME) ref_tn,lower(REFERENCED_COLUMN_NAME) ref_cn
FROM
  INFORMATION_SCHEMA.KEY_COLUMN_USAGE
WHERE
  REFERENCED_TABLE_SCHEMA = database() AND
  lower(TABLE_NAME) = 'payments' AND
  lower(REFERENCED_COLUMN_NAME) = 'student_id' AND 
  lower(REFERENCED_TABLE_NAME) = 'students';
  
  
# test 8 : fk_agenda_subjects check

SELECT 
  lower(TABLE_NAME) tn,lower(COLUMN_NAME) cn, lower(REFERENCED_TABLE_NAME) ref_tn,lower(REFERENCED_COLUMN_NAME) ref_cn
FROM
  INFORMATION_SCHEMA.KEY_COLUMN_USAGE
WHERE
  REFERENCED_TABLE_SCHEMA = database() AND
  lower(REFERENCED_COLUMN_NAME) = 'subject_id' AND 
  lower(REFERENCED_TABLE_NAME) = 'subjects';
  
# test 9 : fk_agenda_students check

SELECT 
  lower(TABLE_NAME) tn,lower(COLUMN_NAME) cn, lower(REFERENCED_TABLE_NAME) ref_tn,lower(REFERENCED_COLUMN_NAME) ref_cn
FROM
  INFORMATION_SCHEMA.KEY_COLUMN_USAGE
WHERE
  REFERENCED_TABLE_SCHEMA = database() AND
  lower(TABLE_NAME) = 'agenda' AND
  lower(REFERENCED_COLUMN_NAME) = 'student_id' AND 
  lower(REFERENCED_TABLE_NAME) = 'students';

-- 07 SoftUni Design

-- 08 Geography Design

# 09 Peaks in Rila

select m.mountain_range, p.peak_name, p.elevation
from peaks p inner join mountains m on p.mountain_id = m.id 
where m.mountain_range = 'Rila'
order by p.elevation desc;