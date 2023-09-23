USE Northwind;

SELECT COUNT(*) AS NumEmployees FROM Employees;

SELECT SUM (Quantity) AS TotalUnits FROM [Order Details] WHERE ProductID=3;

SELECT AVG(UnitPrice) AS AveragePrice FROM Products;

SELECT City, COUNT (EmployeeID) AS NumEmployees FROM Employees GROUP BY City;

SELECT City, COUNT (EmployeeID) AS NumEmployees FROM Employees GROUP BY City HAVING COUNT(EmployeeID) > 1;
-- Invalid 
--SELECT City, COUNT (EmployeeID) AS NumEmployees FROM Employees GROUP BY City HAVING NumEmployees > 1;

/*DISTINCT*/
SELECT DISTINCT City FROM Employees ORDER BY City;

SELECT COUNT(DISTINCT City) AS NumCities FROM Employees;

SELECT ProductID, SUM(Quantity) AS TotalUnits FROM [Order Details]
GROUP BY ProductID HAVING SUM(Quantity) < 200;

SELECT ProductID, AVG(UnitPrice) AS AveragePrice FROM Products
GROUP BY ProductID HAVING AVG(UnitPrice) > 70 ORDER BY AveragePrice;

SELECT CustomerID, COUNT(OrderID) AS NumOrders FROM Orders
GROUP BY CustomerID HAVING COUNT(OrderID) > 15 ORDER BY NumOrders DESC;

SELECT ProductID, UnitPrice FROM Products WHERE UnitPrice > 70 ORDER BY UnitPrice;

/*EXERCISE*/

/*
List freight as is and freight rounded to the first decimal
(e.g. 1.150 becomes 1.200) from the Orders tables
*/

SELECT Freight, ROUND(Freight,1) AS ApproxFreight, ROUND(Freight,0) '0', ROUND(Freight,-1) '-1' FROM Orders;

/*
Select the unit price as is and unit price as a CHAR(10) from the Products tables.
*/

SELECT UnitPrice, CAST(UnitPrice AS CHAR(10)) FROM Products;
--Once converted to char no arithmetic operations can be performed
SELECT UnitPrice, '$' + CAST(UnitPrice AS CHAR(10)) FROM Products;

SELECT UPPER(FirstName), UPPER(LastName) FROM Employees;

SELECT SUBSTRING(Address, 1, 10) FROM Customers;

/* Date Function*/
SELECT LastName, BirthDate, HireDate, DATEDIFF(year, BirthDate, HireDate) AS HireAge FROM Employees
ORDER BY HireAge;

SELECT FirstName, LastName, DATENAME(month, BirthDate) AS BirthMonth_InWords,
DATEPART(month, BirthDate) AS BirthMonth_InNumber FROM Employees
ORDER BY DATEPART(month, BirthDate);

/*SUB QUERIES*/

/*Find the name of the company that placed order 10290*/
SELECT CompanyName FROM Customers WHERE CustomerID = (SELECT CustomerID FROM Orders WHERE OrderID = 10290);

/*Find the Companies that placed orders in 1997*/
SELECT CompanyName FROM Customers WHERE CustomerID IN (SELECT CustomerID FROM Orders WHERE OrderDate 
BETWEEN '1-Jan-1997' AND '31-Dec-1997');

SELECT CompanyName FROM Customers WHERE CustomerID IN (SELECT CustomerID FROM Orders WHERE OrderDate 
BETWEEN '1997-01-01' AND '1997-12-31');

--Escape sequence for ' (not double quotes single quote entered twice)
SELECT * FROM Suppliers WHERE CompanyName = 'Grandma Kelly''s Homestead';

/*HW*/

SELECT ProductName FROM Products WHERE CategoryID = (SELECT CategoryID FROM Categories WHERE CategoryName = 'Seafood')
ORDER BY ProductName;

SELECT CompanyName FROM Suppliers WHERE SupplierID IN (SELECT SupplierID FROM Products WHERE CategoryID = 8) ORDER BY CompanyName;

SELECT CompanyName FROM Suppliers WHERE SupplierID IN 
(SELECT SupplierID FROM Products WHERE CategoryID = 
(SELECT CategoryID FROM Categories WHERE CategoryName = 'Seafood')) ORDER BY CompanyName;

/*JOINS*/
--Equi Join
SELECT Employees.EmployeeID, Employees.FirstName, Employees.LastName, Orders.OrderID, Orders.OrderDate
FROM Employees JOIN Orders ON (Employees.EmployeeID = Orders.EmployeeID) ORDER BY Orders.OrderDate;

--Using Aliases
SELECT e.EmployeeID, e.FirstName, e.LastName, o.OrderID, o.OrderDate
FROM Employees e JOIN Orders o ON (e.EmployeeID = o.EmployeeID) ORDER BY o.OrderDate;

/*HW2*/
SELECT o.OrderID, c.CompanyName, e.FirstName, e.LastName FROM Orders o
JOIN Employees e ON (e.EmployeeID = o.EmployeeID)
JOIN Customers c ON (c.CustomerID = o.CustomerID)
WHERE o.ShippedDate > o.RequiredDate AND o.OrderDate > '1-Jan-1998' ORDER BY c.CompanyName;

/*
Create a report that shows the number of employees and customers from each city that has employees in it.
*/

SELECT COUNT(DISTINCT e.EmployeeID) AS numEmployees, COUNT(DISTINCT c.CustomerID) AS numCompanies,
e.City 'Emp_City', c.City 'Customers_City' FROM Employees e JOIN Customers c ON (e.City = c.City) GROUP BY e.City,c.City
ORDER BY numEmployees DESC;

--All employees but not all customers
SELECT COUNT(DISTINCT e.EmployeeID) AS numEmployees, COUNT(DISTINCT c.CustomerID) AS numCompanies,
e.City 'Emp_City', c.City 'Customers_City' FROM Employees e LEFT JOIN Customers c ON (e.City = c.City) GROUP BY e.City,c.City
ORDER BY numEmployees DESC;

--Not all employees but all customers
--DISTINCT is used to avoid cross join because even if it is unique in table it may not be unique in another table
SELECT COUNT(DISTINCT e.EmployeeID) AS numEmployees, COUNT(DISTINCT c.CustomerID) AS numCompanies,
e.City 'Emp_City', c.City 'Customers_City' FROM Employees e RIGHT JOIN Customers c ON (e.City = c.City) GROUP BY e.City,c.City
ORDER BY numEmployees DESC;

--FULL/OUTER JOIN 
SELECT COUNT(DISTINCT e.EmployeeID) AS numEmployees, COUNT(DISTINCT c.CustomerID) AS numCompanies,
e.City 'Emp_City', c.City 'Customers_City' FROM Employees e FULL JOIN Customers c ON (e.City = c.City) GROUP BY e.City,c.City
ORDER BY numEmployees DESC;


--UNION (Column name need not be same its enough if data type is same)
SELECT CompanyName, Phone FROM Shippers
UNION
SELECT CompanyName, Phone FROM Customers
UNION
SELECT CompanyName, Phone FROM Suppliers
ORDER BY CompanyName;

/*HW3*/

SELECT e.FirstName, e.LastName, o.OrderID FROM Orders o JOIN Employees e ON (e.EmployeeID = o.EmployeeID)
WHERE o.ShippedDate > o.RequiredDate ORDER BY e.LastName, e.FirstName;

SELECT p.ProductName, SUM(o.Quantity) AS TotalUnits FROM 
[Order Details] o Join Products p ON (o.ProductID = p.ProductID) GROUP BY p.ProductName
HAVING SUM(o.Quantity) < 200;

SELECT c.CompanyName, COUNT(o.OrderID) AS NumOrders FROM Customers c JOIN Orders o
ON (c.CustomerID = o.CustomerID) WHERE OrderDate > '31-Dec-1996'
GROUP BY c.CompanyName HAVING COUNT(o.OrderID) > 15 ORDER BY NumOrders DESC;

SELECT c.CompanyName, o.OrderID, od.UnitPrice*od.Quantity*(1-od.Discount) AS TotalPrice FROM [Order Details] od
JOIN Orders o ON (o.OrderID = od.OrderID)
JOIN Customers c ON (c.CustomerID = o.CustomerID)
WHERE od.UnitPrice*od.Quantity*(1-od.Discount) > 10000
ORDER BY TotalPrice DESC;

SELECT FirstName+' '+LastName AS ContactName, HomePhone AS Phone FROM Employees
UNION
SELECT ContactName, Phone FROM Customers
UNION
SELECT ContactName AS ContactName, Phone FROM Suppliers
ORDER BY ContactName;

/*
----------------------------TRANSACTION-------------------------------------------
*/

USE Northwind
GO
BEGIN TRANSACTION
UPDATE dbo.Categories
SET CategoryName = 'Fishfood_venkat'
WHERE CategoryName = 'Seafood';
--ROLLBACK TRANSACTION
commit TRANSACTION
Select * from dbo.Categories

BEGIN TRANSACTION
UPDATE dbo.Categories
SET CategoryName = 'Seafood'
WHERE CategoryName = 'Fishfood';
ROLLBACK TRANSACTION
Select * from dbo.Categories

/*---------------------------------------SELF JOIN-----------------------------------------------------*/
SELECT e1.EmployeeID, e1.FirstName, e2.FirstName as managerName, e1.Title 
FROM Employees e1 INNER JOIN Employees e2 on e1.ReportsTo = e2.EmployeeID;

--ORDER BY IN SUB QUERY
Select * from Orders where freight in (select top 3 freight from orders order by Freight desc);

--INLINE OR DERIVED TABLE
Select min(BirthDate) AS Birth_Date From (select top 3 BirthDate from employees order by BirthDate desc) a;

/*HW4*/--see pic
use TestDb;
Select * from emptbl where salary =
(select min(salary) from --sub query
(select top 3 salary from emptbl order by salary desc) a); --derived table

use Northwind
--Third highest freight
select min(freight) from (select top 3 freight from orders order by Freight desc) a;


