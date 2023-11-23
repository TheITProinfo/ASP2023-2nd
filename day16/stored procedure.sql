/****** Script for SelectTopNRows command from SSMS  ******/
SELECT TOP (1000) [CustomerID]
      ,[CompanyName]
      ,[ContactName]
      ,[ContactTitle]
      ,[Address]
      ,[City]
      ,[Region]
      ,[PostalCode]
      ,[Country]
      ,[Phone]
      ,[Fax]
  FROM [NORTHWND].[dbo].[Customers]

  Select * from Customers order by CustomerID desc
  ---pageindex --
  --pagesize ==5
  --- 1---5
  --- 6---10
  --start=(pageindex-1)*pagesize+1
  ---end=(pageindex)pagesize
  
  
  select *  from 
  (select * , row_number() over (order by CustomerID   desc)as rownumber from Customers) as t1

  where rownumber between 6 and 10


