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





  ---page navigation
  --start
  --end
  --pageIndex
  --pageSize
  --pageCount  total pages
  -------------- example create stored procedure-----
  
    DROP PROCEDURE GetPageList
    GO 

  Create PROC GetPageList

  @pageIndex int,
  @pageSize int,
  @rowCount int output

  as 

  begin
     
	  set nocount on

      select @rowCount=count(*) from customers
		
		select * from

	  (select *,ROW_NUMBER() over (order by CustomerID desc) as rowIndex
	  from customers) as t1

	  where rowIndex between(@pageIndex-1)*@pageSize+1   and @pageIndex*@pageSize
  
  
  end

  --select * from

  --(select *,ROW_NUMBER() over (order by CustomerID desc) as rowIndex
  --from customers) as t1

  --where rowIndex between 11 and 20

  --select @@VERSION
   
   ---- execute stored procedure--
  declare @temp int
   exec GetPageList 5,9,@temp output
   print @temp

    use Cstcollege 
	go
