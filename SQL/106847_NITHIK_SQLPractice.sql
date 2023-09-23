use TestDb;
/*
Creating CUSTOMER TABLE
*/
CREATE TABLE CUSTOMER
(
CustomerId int IDENTITY(1,1) PRIMARY KEY,/*Auto Generated*/
CustomerNumber int NOT NULL UNIQUE,
LastName varchar(50) NOT NULL,
FirstName varchar(50) NOT NULL,
AreaCode int NULL,
Address varchar(50) NULL,
Phone varchar(50) NULL
)
ALTER TABLE CUSTOMER ADD CONSTRAINT Check_CustomerNumber CHECK(CustomerNumber>0);
/*
Creating SCHOOL TABLE
*/
CREATE TABLE SCHOOL
(
SchoolId int IDENTITY(1,1) PRIMARY KEY,
SchoolName varchar(50) NOT NULL UNIQUE,
Description varchar(1000) NULL,
Address varchar(50) NULL,
Phone varchar(50) NULL,
PostCode varchar(50) NULL,
PostAddress varchar(50) NULL
)
/*
Creating CLASS TABLE and Foreign Key
*/
CREATE TABLE CLASS
(
ClassId int IDENTITY(1,1) PRIMARY KEY,
SchoolId int NOT NULL FOREIGN KEY REFERENCES SCHOOL (SchoolId),
ClassName varchar(50) NOT NULL UNIQUE,
Description varchar(1000) NULL,
)
/*
Default 
*/
CREATE TABLE [CUSTOMER 2]
(
CustomerId int IDENTITY(1,1) PRIMARY KEY,
CustomerNumber int NOT NULL UNIQUE,
LastName varchar(50) NOT NULL,
FirstName varchar(50) NOT NULL,
Country varchar(20) DEFAULT 'Norway',
AreaCode int NULL,
Address varchar(50) NULL,
Phone varchar(50) NULL
)
/*
if...else condition
*/
if not exists (select * from dbo.sysobjects where id = object_id(N'[CUSTOMER]') and 
OBJECTPROPERTY(id, N'IsUserTable') = 1)
CREATE TABLE CUSTOMER
(
CustomerId int PRIMARY KEY,
CustomerNumber int NOT NULL UNIQUE,
LastName varchar(50) NOT NULL,
FirstName varchar(50) NOT NULL,
AreaCode int NULL,
Address varchar(50) NULL,
Phone varchar(50) NULL
)
/*---------------------------------------*/
IF exists(SELECT * FROM dbo.syscolumns WHERE id = object_id(N'[CUSTOMER]') AND OBJECTPROPERTY(id, 
N'IsUserTable') = 1 and name = 'CustomerId')
	ALTER TABLE CUSTOMER ALTER COLUMN CustomerId int;
ELSE
	ALTER TABLE CUSTOMER ADD CustomerId int;
/*---------------------------------------*/
IF exists(SELECT * FROM dbo.syscolumns WHERE id = object_id(N'[CUSTOMER]') AND OBJECTPROPERTY(id, 
N'IsUserTable') = 1 and name = 'CustomerNumber')
	ALTER TABLE CUSTOMER ALTER COLUMN CustomerNumber int;
ELSE
	ALTER TABLE CUSTOMER ADD CustomerNumber int;
/*
Insert Into
*/
INSERT INTO CUSTOMER (CustomerNumber, LastName, FirstName, AreaCode, Address, Phone) 
VALUES ('1000', 'Smith', 'John', 12, 'California', '11111111');
INSERT INTO CUSTOMER (CustomerNumber, LastName, FirstName, AreaCode, Address, Phone) 
VALUES ('1001', 'John', 'Wick', 12, 'California', '22222222');
/*
Update Table
*/
UPDATE CUSTOMER SET AreaCode=46 WHERE CustomerId=2;
/*
Delete One Row In Table
*/
DELETE FROM CUSTOMER WHERE CustomerId=2;
/*
Delete All Rows In Table
*/
DELETE FROM CUSTOMER;
/*
Select Queries
*/
SELECT * FROM CUSTOMER
/*----------------------------------*/
INSERT INTO CUSTOMER (CustomerNumber, LastName, FirstName, AreaCode, Address, Phone) 
VALUES ('1001', 'Jackson', 'Smith', 45, 'London', '22222222');
INSERT INTO CUSTOMER (CustomerNumber, LastName, FirstName, AreaCode, Address, Phone) 
VALUES ('1002', 'Johnsen', 'John', 32, 'London', '33333333');
SELECT * FROM CUSTOMER ORDER BY LastName;
/*----------------------------------*/
SELECT * FROM CUSTOMER ORDER BY Address, LastName;
/*----------------------------------*/
SELECT * FROM CUSTOMER ORDER BY LastName DESC;
/*-----------DISTINCT---------------*/
SELECT DISTINCT FirstName FROM CUSTOMER;
/*-------------WHERE-----------------*/
SELECT * FROM CUSTOMER WHERE CustomerNumber='1001';
/*-----------OPERATOR----------------*/
SELECT * FROM CUSTOMER WHERE AreaCode>30;
SELECT * FROM CUSTOMER WHERE LastName LIKE 'J%';
SELECT * FROM CUSTOMER WHERE LastName LIKE '%a%';
SELECT * FROM CUSTOMER WHERE LastName NOT LIKE '%a%';
/*--------------IN-------------------*/
SELECT * FROM CUSTOMER WHERE LastName IN ('Smith', 'Johnsen');
/*------------BETWEEN----------------*/
SELECT * FROM CUSTOMER WHERE CustomerNumber BETWEEN 1000 AND 1003;
/*------------BETWEEN----------------*/
SELECT * FROM CUSTOMER WHERE LastName LIKE 'J_cks_n';
SELECT * FROM CUSTOMER WHERE CustomerNumber LIKE '[10]%';
/*-----------OPERATORS---------------*/
SELECT * FROM CUSTOMER WHERE LastName = 'Smith' AND FirstName = 'John';
SELECT * FROM CUSTOMER WHERE LastName = 'Smith' OR FirstName = 'John';
SELECT * FROM CUSTOMER WHERE LastName = 'Smith' AND (FirstName = 'John' OR FirstName = 'Smith');
/*-------------TOP-------------------*/
SELECT TOP 1 * FROM CUSTOMER;
SELECT TOP 60 PERCENT * FROM CUSTOMER;
/*-----------ALIAS-------------------*/
SELECT FirstName AS Name FROM CUSTOMER;
/*-----------JOINS-------------------*/
INSERT INTO SCHOOL (SchoolName, Description, Address, Phone, PostCode, PostAddress) 
VALUES ('JV', 'wertyuiop', 'Hr.Sec.School', '123456789', '600083', 'Chennai'), 
('SBOA', 'wertyuiop', 'Hr.Sec.School', '987654321', '600073', 'Chennai');

INSERT INTO CLASS (SchoolId, ClassName, Description) 
VALUES ('11', 'History', 'Hr.Sec.School'), 
('10', 'Science', 'Hr.Sec.School');

SELECT SCHOOL.SchoolName, CLASS.ClassName FROM SCHOOL INNER JOIN CLASS
ON SCHOOL.SchoolId = CLASS.SchoolId;

SELECT SCHOOL.SchoolName, CLASS.ClassName FROM SCHOOL CROSS JOIN CLASS;

SELECT SCHOOL.SchoolName, CLASS.ClassName FROM SCHOOL LEFT JOIN CLASS
ON SCHOOL.SchoolId = CLASS.SchoolId;

SELECT SCHOOL.SchoolName, CLASS.ClassName FROM SCHOOL RIGHT JOIN CLASS
ON SCHOOL.SchoolId = CLASS.SchoolId;

SELECT SCHOOL.SchoolName, CLASS.ClassName FROM SCHOOL FULL JOIN CLASS
ON SCHOOL.SchoolId = CLASS.SchoolId;

/*Comments*/
/*
--      - Single Line
/*...*/ - Multi Line
*/

/*Declaring variables*/
/*
declare @local_variable data_type

If	you	have	more	than	one	variable	you	want	to	declare:
declare
@myvariable1 data_type,
@myvariable2 data_type,
...

declare @myvariable int
set @myvariable=4
print @myvariable
*/
DECLARE @mylastname varchar(50);
SELECT @mylastname=LastName FROM CUSTOMER WHERE CustomerId=3;
PRINT @mylastname;
--Can use like the below one too
DECLARE @find varchar(30);
SET @find = 'J%';
SELECT * FROM CUSTOMER WHERE LastName LIKE @find;

/*Creating required tables*/
DELETE FROM CLASS;
DELETE FROM SCHOOL;
CREATE TABLE COURSE
(
CourseId int IDENTITY(1,1) PRIMARY KEY,
CourseName varchar(50) NOT NULL UNIQUE,
SchoolId int FOREIGN KEY REFERENCES SCHOOL(SchoolId),
Description varchar(50)
)

INSERT INTO SCHOOL (SchoolName, Description, Address, Phone, PostCode, PostAddress) 
VALUES ('TUC', NULL, NULL, NULL, NULL, NULL), 
('NTNU', NULL, NULL, NULL, NULL, NULL),
('MIT', NULL, NULL, NULL, NULL, NULL);
Select * From SCHOOL;

INSERT INTO COURSE(CourseName, SchoolId, Description) 
VALUES ('SCE2006', 3, NULL), 
('SCE1106', 3, NULL),
('SCE4206', 3, NULL),
('SCE4106', 3, NULL),
('MIT-101', 5, NULL),
('MIT-201', 5, NULL);

/*IF...ELSE*/
DECLARE @customerNumber int;
SELECT @customerNumber = CustomerNumber FROM CUSTOMER WHERE CustomerId=2;
IF @customerNumber > 1000
	BEGIN
		PRINT 'The Customer Number is larger than 1000';
		UPDATE CUSTOMER set AreaCode=46 where CustomerId=2;
	END
ELSE
	PRINT 'The Customer Number is not larger than 1000';

/*WHILE*/
WHILE (SELECT AreaCode FROM CUSTOMER WHERE CustomerId=1) < 20
	BEGIN
		UPDATE CUSTOMER SET AreaCode = AreaCode + 1;
	END
SELECT * FROM CUSTOMER;

/*CASE*/

CREATE TABLE GRADE
(
GradeId int IDENTITY(1,1) PRIMARY KEY,
StudentId int NOT NULL,
CourseId int NOT NULL,
Grade int NOT NULL
)


INSERT INTO GRADE(StudentId, CourseId, Grade) 
VALUES (1, 1, 4),
(2, 1, 5),
(3, 3, 0),
(4, 3, 3),
(1, 3, 5);

SELECT GradeId, StudentId, CourseId,
CASE Grade 
	WHEN 5 THEN 'A'
	WHEN 4 THEN 'B'
	WHEN 3 THEN 'C'
	WHEN 2 THEN 'D'
	WHEN 1 THEN 'E'
	WHEN 0 THEN 'F'
	ELSE '-'
END AS Grade 
FROM GRADE;

/*CURSORS*/
DECLARE
@CustomerId int, 
@phone varchar(50);
DECLARE mydbcursor CURSOR 
FOR SELECT CustomerId FROM CUSTOMER;
OPEN mydbcursor;
FETCH NEXT FROM mydbcursor INTO @CustomerId; 
WHILE @@FETCH_STATUS = 0 
	BEGIN
		 SELECT @phone=Phone FROM CUSTOMER WHERE CustomerId=@CustomerId;
		 IF LEN(@phone) < 8
			UPDATE CUSTOMER SET Phone='Phone number is not valid' WHERE CustomerId=@CustomerId;
			FETCH NEXT FROM mydbcursor INTO @CustomerId;
	END 
CLOSE mydbcursor; 
DEALLOCATE mydbcursor;

/*VIEWS*/
CREATE VIEW SchoolView AS
SELECT SCHOOL.SchoolName, CLASS.ClassName FROM SCHOOL
INNER JOIN CLASS ON SCHOOL.SchoolId = CLASS.SchoolId;

SELECT * FROM SchoolView;

/*STORED PROCEDURE*/
CREATE PROCEDURE GetAllSchoolClasses AS
SELECT SCHOOL.SchoolName, CLASS.ClassName FROM SCHOOL
INNER JOIN CLASS ON SCHOOL.SchoolId = CLASS.SchoolId
ORDER BY SchoolName, ClassName;

EXECUTE GetAllSchoolClasses;

/*With PARAMETERS*/
IF EXISTS (SELECT name FROM sysobjects WHERE name = 'GetSpecificSchoolClasses' AND type = 'P')
	--'P' for Procedure
	DROP PROCEDURE GetSpecificSchoolClasses;
GO
CREATE PROCEDURE GetSpecificSchoolClasses
@SchoolName varchar(50)
AS
SELECT SCHOOL.SchoolName, CLASS.ClassName FROM SCHOOL
INNER JOIN CLASS ON SCHOOL.SchoolId = CLASS.SchoolId
WHERE SchoolName=@SchoolName
ORDER BY ClassName;

execute GetSpecificSchoolClasses 'JV';

/*NOCOUNT*/
--MAkes procedure run faster
--abstracts display of rows affected for the ones within NOCOUNT
IF EXISTS (SELECT name FROM sysobjects WHERE name = 'sp_LIMS_IMPORT_REAGENT' AND type = 'P')
	DROP PROCEDURE sp_LIMS_IMPORT_REAGENT
GO
CREATE PROCEDURE sp_LIMS_IMPORT_REAGENT
@Name varchar(100),
@LotNumber varchar(100),
@ProductNumber varchar(100),
@Manufacturer varchar(100)
AS
SET NOCOUNT ON
IF not exists (SELECT ReagentId FROM LIMS_REAGENTS WHERE [Name]=@Name)
	INSERT INTO LIMS_REAGENTS ([Name], ProductNumber, Manufacturer)
	VALUES (@Name, @ProductNumber, @Manufacturer);
ELSE
	UPDATE LIMS_REAGENTS SET [Name] = @Name, ProductNumber = @ProductNumber, Manufacturer = @Manufacturer,
	WHERE [Name] = @Name;
SET NOCOUNT OFF
GO

/*FUNCTIONS*/
SELECT AVG(Grade) as AvgGrade FROM GRADE WHERE StudentId = 1;
SELECT COUNT(SchoolName) FROM SCHOOL;
SELECT COUNT(*) FROM emptbl;
SELECT FirstName, MAX(AreaCode) FROM CUSTOMER GROUP BY FirstName;

/*Having CLAUSE*/
SELECT CourseId, AVG(Grade) FROM GRADE GROUP BY CourseId
HAVING AVG(Grade)>3;

/*TRIGGERS*/
IF EXISTS (SELECT name FROM sysobjects WHERE name = 'CheckPhoneNumber' AND type = 'TR')
	DROP TRIGGER CheckPhoneNumber;
GO

CREATE TRIGGER CheckPhoneNumber ON CUSTOMER
FOR UPDATE, INSERT
AS
DECLARE @CustomerId int,
@Phone varchar(50),
@Message varchar(50);
SET NOCOUNT ON

SELECT @CustomerId = CustomerId FROM INSERTED;
SELECT @Phone = Phone FROM INSERTED;
SET @Message = 'Phone Number ' + @Phone + ' is not valid!!!';

IF LEN(@Phone) < 8 
	UPDATE CUSTOMER SET Phone = @Message WHERE CustomerId = @CustomerId
SET NOCOUNT OFF

INSERT INTO CUSTOMER (CustomerNumber, LastName, FirstName, AreaCode, Address, Phone) VALUES
('1003', 'Obama', 'Barak', 51, 'Nevada', '4444');

SELECT * FROM CUSTOMER;
-- so once the trigger oversee's the validation and after viewing the table we can update the right one 















