----create Table Student 
CREATE TABLE Student(
id INT PRIMARY KEY IDENTITY(1,1),
Name NVARCHAR(50),
Section INT,
Branch NVARCHAR(20),
Email NVARCHAR(100)



)

INSERT INTO dbo.Student
(
    Name,
    Section,
    Branch,
    Email
)
VALUES
(   N'John', -- Name - nvarchar(50)
    1,   -- Section - int
    N'NTS', -- Branch - nvarchar(20)
    N'zzname@hotmail.com'  -- Email - nvarchar(100)
    )