use Cstcollege
go

Create Table UserInfo(
id int primary Key Identity(10,1),
FirstName nvarchar(50),
CreatDatetime datetime default getdate()

)

select * from userInfo

insert into userInfo
(FirstName,CreatDatetime )
values
( 'John',getdate())