select @@VERSION as version
--create database
create database market on
( 
  name='market',
  size=8MB,
  filegrowth=64MB,
  filename="d:\SqlData\market.mdf"
)

log on 
(
 name='_log',
 size=8MB,
 filegrowth=64Mb,
 filename="d:\SqlLog\market_log.ldf"

)

use market;
go

create table customers 
(
customerID int identity(10,1) primary key not null,
customerName varchar(250) not null,
customerContact varchar(250) not null,
customerCity varchar(100) not null,
customerBirthday datetime

)
insert into customers (customerName,customerContact,customerCity,customerBirthday)values('Cstcollege2','Tom2','Markham','1980-04-01')
-- add one column
alter Table customers 

add email varchar(255)
---delete colum
alter Table customers 

drop column email

select * from customers



