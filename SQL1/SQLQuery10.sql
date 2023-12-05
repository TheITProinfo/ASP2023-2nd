USE [NORTHWND]
GO

/****** Object:  Table [dbo].[Customers]    Script Date: 12/3/2023 7:33:52 PM ******/
SELECT * FROM dbo.Customers

SELECT CompanyName, contactName FROM dbo.Customers

SELECT [CompanyName],[ContactName] from[dbo].[Customers]

SELECT country FROM	dbo.Customers

SELECT DISTINCT(country) FROM dbo.Customers
-- where (country=UK)

SELECT companyname,ContactName FROM dbo.Customers WHERE Country='UK'

--order by --

--DESC -- higest to lowest
--ASC ----lowest to highest

SELECT * FROM dbo.[Customers] ORDER BY CustomerID DESC

SELECT productID,UnitPrice FROM  [dbo].[Order Details] ORDER BY UnitPrice ASC
SELECT productID,UnitPrice FROM  [dbo].[Order Details] ORDER BY UnitPrice DESC

--------and

SELECT * FROM dbo.Customers WHERE Country='UK' AND CompanyName LIKE '%e%'

--top-- only the first 5 records

SELECT  TOP 5 * FROM dbo.Customers

--like 

SELECT * FROM dbo.Customers WHERE city LIKE 'lon%'

---in---
SELECT * FROM	dbo.Customers WHERE Country not IN ('UK','Germany')

SELECT city FROM dbo.Customers 

SELECT * FROM dbo.Customers WHERE city IN ('Berlin','Toronto','Bern')

---group by 

--- group by --having

SELECT COUNT(CustomerID), country FROM	dbo.Customers GROUP BY Country
SELECT COUNT(CustomerID), country FROM	dbo.Customers GROUP BY Country ORDER BY  COUNT(CustomerID) DESC
SELECT COUNT(customerid),country  FROM dbo.Customers GROUP BY Country HAVING COUNT(customerid)>9


--between--


SELECT * FROM dbo.Products123 WHERE UnitPrice BETWEEN 22 AND 50

--insert into
--
INSERT INTO	dbo.Customers
(
    CustomerID,
    CompanyName,
    ContactName,
    ContactTitle,
    Address,
    City,
    Region,
    PostalCode,
    Country,
    Phone,
    Fax
)
VALUES
(   N'98001', -- CustomerID - nchar(5)
    N'Cstcollege', -- CompanyName - nvarchar(40)
    N'eric', -- ContactName - nvarchar(30)
    N'Mr.', -- ContactTitle - nvarchar(30)
    N'1858 bayview ave', -- Address - nvarchar(60)
    N'Toronto', -- City - nvarchar(15)
    N'Toronto', -- Region - nvarchar(15)
    N'l2j 8k6', -- PostalCode - nvarchar(10)
    N'Canada', -- Country - nvarchar(15)
    N'12345678', -- Phone - nvarchar(24)
    N'12345678'  -- Fax - nvarchar(24)
    )

	SELECT * FROM dbo.Customers ORDER BY CustomerID ASC

	INSERT INTO dbo.Customers
	(
	    CustomerID,
	    CompanyName,
	    
	    Fax
	)
	VALUES
	(   N'98002', -- CustomerID - nchar(5)
	    N'Cstcollege2', -- CompanyName - nvarchar(40)
	   
	    N'12345678'  -- Fax - nvarchar(24)
	    ) 

		select * from customers where contactname is NULL
        select * from customers where contactname IS not null


		--min 

  SELECT MIN(quantity) from [dbo].[Order Details]
  SELECT Max(quantity) from [dbo].[Order Details]

  SELECT SUM(quantity) FROM [dbo].[Order Details]
  SELECT AVG(quantity) FROM [dbo].[Order Details]

  ----------copy all tables to new table

  SELECT * INTO customersbackup2023 FROM dbo.Customers

  SELECT customerid,companyname,contactname INTO customersbackup2022 FROM dbo.Customers

  INSERT INTO dbo.Suppliers
 
  (   CompanyName,city, Country,fax)

  SELECT CompanyName,city,Country, fax FROM	  dbo.Customers
  
  SELECT * FROM dbo.Suppliers ORDER		BY SupplierID DESC	
              
 UPDATE dbo.Suppliers SET ContactName='eric' ,city='Toronto' WHERE SupplierID=122  
 

 DELETE FROM dbo.Suppliers WHERE SupplierID=120





                                 
                                     