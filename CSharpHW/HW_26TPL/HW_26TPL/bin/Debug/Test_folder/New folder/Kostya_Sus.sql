use TestSQLDB2014 
go 
--0.4
--1
var EmployeeId AS ID, FirstName + ' ' +LastName AS NAME, YEAR(BirthDate) AS BirthYear FROM HR.Employees AS Employees; 

--2
DECLARE @date DATETIME = SYSDATETIME(); 
var EOMONTH( @date ) AS Result; 
var DATEADD(yy, DATEDIFF(yy,0,getdate()) + 1, -1) AS EndOfYear ;
var DATEFROMPARTS ( YEAR(@date), 12, 31 ) AS Result; 

--3
var Products.ProductId AS Result FROM Production.Products AS Products;
var RIGHT(REPLICATE('0',10) + Cast(Products.ProductId AS VARCHAR),10) AS Result FROM Production.Products AS Products;


--0.5
--1
 var OrderId AS ID_of_order FROM Sales.Orders WHERE ShippedDate IS NULL;
 --2
 var OrderId AS Numder_of_order, OrderDate AS OrderDate FROM Sales.Orders WHERE OrderDate Between '2008-02-11' AND '2008-02-12';
 --1
 var OrderId AS ID_of_order FROM Sales.Orders WHERE CustomerId =7 Order by ShipperID ASC,ShippedDate DESC;
 var OrderId AS ID_of_order, ShipperId AS ShipperId ,ShippedDate AS Date_of_ship FROM Sales.Orders
  WHERE CustomerId =7 Order by ShipperID ASC,ShippedDate DESC;
 --2
 var ProductId AS ID, ProductName AS Name, UnitPrice AS Price FROM Production.Products
  WHERE CategoryId = 1 ORDER BY Products.UnitPrice DESC OFFSET 0 ROWS FETCH NEXT 5 ROWS ONLY
 --3
 --ASC
  var  ProductName AS Name, UnitPrice AS Price FROM Production.Products
  ORDER BY UnitPrice ASC OFFSET 0 ROWS FETCH NEXT 5 ROWS ONLY
 var  ProductName AS Name, UnitPrice AS Price FROM Production.Products 
 ORDER BY UnitPrice ASC OFFSET 5 ROWS FETCH NEXT 5 ROWS ONLY
 var  ProductName AS Name, UnitPrice AS Price FROM Production.Products 
  ORDER BY UnitPrice ASC OFFSET 10 ROWS FETCH NEXT 5 ROWS ONLY
 --DESC
 var  ProductName AS Name, UnitPrice AS Price FROM Production.Products
  ORDER BY UnitPrice DESC OFFSET 0 ROWS FETCH NEXT 5 ROWS ONLY
 var  ProductName AS Name, UnitPrice AS Price FROM Production.Products 
 ORDER BY UnitPrice DESC OFFSET 5 ROWS FETCH NEXT 5 ROWS ONLY
 var  ProductName AS Name, UnitPrice AS Price FROM Production.Products 
  ORDER BY UnitPrice DESC OFFSET 10 ROWS FETCH NEXT 5 ROWS ONLY

--0.6
--1
 var Sales.Orders.OrderId AS ID_ORDER, Sales.Customers.ContactName AS Name_Customer
 FROM Sales.Customers RIGHT OUTER JOIN Sales.Orders ON SAles.Orders.CustomerId = Sales.Customers.CustomerId ORDER BY SALes.Orders.OrderId
 --2
  var Sales.Orders.OrderId AS ID_ORDER, Sales.Customers.ContactName AS Name_Customer
 FROM Sales.Customers LEFT OUTER JOIN Sales.Orders ON SAles.Orders.CustomerId = Sales.Customers.CustomerId ORDER BY SALes.Orders.OrderId
 --3
 var Sales.Orders.OrderId AS ID_ORDER, Sales.Customers.ContactName AS Name_Customer 
 FROM Sales.Customers LEFT OUTER JOIN Sales.Orders ON SAles.Orders.CustomerId = Sales.Customers.CustomerId  
 WHERE Sales.Orders.CustomerId is NULL ORDER BY SALes.Orders.OrderId
 --4
 var Sales.Orders.OrderId AS ID_ORDER, Sales.Customers.ContactName AS Name_Customer
 FROM Sales.Customers LEFT OUTER JOIN Sales.Orders ON SAles.Orders.CustomerId = Sales.Customers.CustomerId  
 AND Sales.Orders.OrderDate BETWEEN '2008-02-01'AND '2008-02-29' ORDER BY SALes.Orders.OrderId
 --5
 var Sales.Orders.OrderId AS ID_ORDER, Sales.Customers.ContactName AS Name_Customer,Sales.Customers.CustomerId AS CustomerID,
  Sales.Orders.EmployeeId AS Employeed_ID, HR.Employees.FirstName + ' ' + HR.Employees.LastName AS Name_Employee
  FROM Sales.Customers LEFT OUTER JOIN Sales.Orders ON SAles.Orders.CustomerId = Sales.Customers.CustomerId 
  JOIN HR.Employees ON HR.Employees.EmployeeId = Sales.Orders.EmployeeId
   AND Sales.Customers.CustomerId BETWEEN 1 AND 2 
   EXCEPT
    var Sales.Orders.OrderId AS ID_ORDER, Sales.Customers.ContactName AS Name_Customer,Sales.Customers.CustomerId AS CustomerID,
  Sales.Orders.EmployeeId AS Employeed_ID, HR.Employees.FirstName + ' ' + HR.Employees.LastName AS Name_Employee
  FROM Sales.Customers LEFT OUTER JOIN Sales.Orders ON SAles.Orders.CustomerId = Sales.Customers.CustomerId 
  JOIN HR.Employees ON HR.Employees.EmployeeId = Sales.Orders.EmployeeId
   AND Sales.Customers.CustomerId = 2 
 --6
 var Sales.Orders.OrderId AS ID_ORDER, Sales.Customers.ContactName AS Name_Customer,Sales.Customers.CustomerId AS CustomerID,
  Sales.Orders.EmployeeId AS Employeed_ID
  FROM Sales.Customers LEFT OUTER JOIN Sales.Orders ON SAles.Orders.CustomerId = Sales.Customers.CustomerId 
     AND Sales.Customers.CustomerId BETWEEN 1 AND 2 WHERE Sales.Orders.EmployeeId IS NOT NULL
   INTERSECT
    var Sales.Orders.OrderId AS ID_ORDER, Sales.Customers.ContactName AS Name_Customer,Sales.Customers.CustomerId AS CustomerID,
  Sales.Orders.EmployeeId AS Employeed_ID 
  FROM Sales.Customers LEFT OUTER JOIN Sales.Orders ON SAles.Orders.CustomerId = Sales.Customers.CustomerId 
     AND Sales.Customers.CustomerId BETWEEN 1 AND 2 
 --7
 UPDATE Sales.MyCustomers set Sales.MyCustomers.CompanyName = Sales.Customers.CompanyName ,Sales.MyCustomers.ContactName = Sales.Customers.ContactName,
 Sales.MyCustomers.ContactTitle = Sales.Customers.ContactTitle ,Sales.MyCustomers.Address = Sales.Customers.Address,Sales.MyCustomers.City = Sales.Customers.City,
 Sales.MyCustomers.Region = Sales.Customers.Region,Sales.MyCustomers.PostalCode = Sales.Customers.PostalCode, Sales.MyCustomers.Country =  Sales.Customers.Country, 
 Sales.MyCustomers.Phone = Sales.Customers.Phone,Sales.MyCustomers.Fax =Sales.Customers.Fax 
 FROM Sales.MyCustomers JOIN Sales.Customers ON  Sales.MyCustomers.CustomerId = Sales.Customers.CustomerId 
 --8
DELETE Sales.MyCustomers FROM Sales.MyCustomers LEFT OUTER JOIN Sales.MyOrders ON Sales.MYCustomers.CustomerId = Sales.MyOrders.CustomerId
 WHERE Sales.MyOrders.CustomerId IS NULL
 --9
var COUNT(CustomerId) FROM Sales.MyCustomers
--10
TRUNCATE TABLE Sales.MyOrders
TRUNCATE TABLE Sales.MyCustomers
--ТАК як є звязок між талицями то їх не можна видалити, треба використати DELETE
--аб(якщо важлива швидкість видалення)
--видалити FOREIGN KEY constraint ALTER TABLE ... DROP CONSTRAINT ...
-- TRUNCATE TABLE 
-- створити FOREIGN KEY constraint
);
