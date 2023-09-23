use Northwind;

SELECT * FROM Employees;

SELECT EmployeeID, FirstName, LastName, HireDate, City
FROM Employees; /*Virtically Filtering my table*/

SELECT EmployeeID, FirstName, LastName, HireDate, City
FROM Employees WHERE City = 'London';

SELECT EmployeeID, FirstName, LastName, HireDate, City
FROM Employees WHERE City <> 'London';

SELECT EmployeeID, FirstName, LastName, HireDate, City
FROM Employees WHERE HireDate = '1-july-1993';

SELECT CategoryName, Description FROM Categories;

SELECT ContactName, CompanyName, ContactTitle, Phone FROM Customers;

SELECT EmployeeID, Title, FirstName, LastName, Region FROM Employees;

SELECT RegionID, RegionDescription FROM Region;

SELECT CompanyName, Fax, Phone, HomePage FROM Suppliers;

SELECT EmployeeID, FirstName, LastName, HireDate, City FROM Employees
WHERE (HireDate >= '1-june-1992') AND (HireDate <= '15-december-1993');

SELECT EmployeeID, FirstName, LastName, HireDate, City FROM Employees
WHERE HireDate BETWEEN '1-june-1992' AND '15-december-1993';
/*BETWEEN is faster in performance wise*/

SELECT EmployeeID, FirstName, LastName, HireDate, City FROM Employees
WHERE HireDate NOT BETWEEN '1-june-1992' AND '15-december-1993';

SELECT EmployeeID, FirstName, LastName, HireDate, City FROM Employees
WHERE City = 'London' OR City = 'Seattle';

SELECT EmployeeID, FirstName, LastName, HireDate, City FROM Employees
WHERE City IN ('Seattle', 'Tacoma', 'Redmond');

SELECT EmployeeID, FirstName, LastName, HireDate, City FROM Employees
WHERE City NOT IN ('Seattle', 'Tacoma', 'Redmond');

SELECT EmployeeID, FirstName, LastName, HireDate, City FROM Employees
WHERE (FirstName NOT LIKE 'M%') AND (FirstName NOT LIKE 'A%');

SELECT EmployeeID, FirstName, LastName, HireDate, City FROM Employees
WHERE FirstName LIKE '[a-M]%';

SELECT EmployeeID, FirstName, LastName, HireDate, City FROM Employees
WHERE FirstName LIKE '[^a-M]%';

SELECT EmployeeID, FirstName, LastName, HireDate, City FROM Employees
ORDER BY City;

SELECT EmployeeID, FirstName, LastName, HireDate, Country, City FROM Employees
ORDER BY Country, City DESC;

SELECT EmployeeID, FirstName, LastName, HireDate, Country,City FROM Employees
ORDER BY Country Desc, City DESC;

SELECT EmployeeID, FirstName, LastName, HireDate, Country, City FROM Employees
ORDER BY Country ASC, City DESC;

SELECT Title, FirstName, LastName FROM Employees
ORDER BY 1, 3;


SELECT Title, FirstName, LastName FROM Employees
ORDER BY Title, LastName;

/*HW*/
SELECT CategoryName, Description FROM Categories ORDER BY CategoryName;

SELECT ContactName, CompanyName, ContactTitle, Phone FROM Customers ORDER BY Phone;

SELECT FirstName, LastName, HireDate FROM Employees ORDER BY HireDate DESC;

SELECT OrderID, OrderDate, ShippedDate, CustomerID, Freight FROM Orders
ORDER BY Freight DESC;

SELECT CompanyName, Fax, Phone, HomePage, Country FROM Suppliers
ORDER BY Country DESC, CompanyName;

SELECT Title, FirstName, LastName FROM Employees ORDER BY Title, LastName DESC;

/*OVER*/

SELECT FirstName, LastName, Region FROM Employees WHERE Region IS NULL;

SELECT FirstName, LastName, Region FROM Employees WHERE Region IS NOT NULL;

/*HW2*/

SELECT CompanyName, ContactName, City FROM Customers WHERE City = 'Buenos Aires';

SELECT ProductName, UnitPrice, QuantityPerUnit, UnitsInStock
FROM Products WHERE UnitsInStock = 0;

SELECT OrderDate, ShippedDate, CustomerID, Freight
FROM Orders WHERE OrderDate = '19-May-1997';
/*
SELECT OrderDate, ShippedDate, CustomerID, Freight
FROM Orders WHERE OrderDate = '1997-05-19';
*/

SELECT FirstName, LastName, Country
FROM Employees WHERE Country <> 'USA';

/*OVER2*/

/*Calculated Fields*/
SELECT FirstName + '' + LastName FROM Employees;

SELECT [OrderID], [Freight], [Freight]*0.1 Tax
FROM [Orders] WHERE Freight >= 500;
/*Query prefix and query suffix can have space inbetween 
names and can use reserved keywords*/

SELECT OrderID, Freight, Freight*1.1 AS FreightTotal
FROM Orders WHERE Freight >= 500;

