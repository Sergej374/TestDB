CREATE DATABASE MyTests
GO
USE MyTests
GO

CREATE TABLE Groups
(
ID_Group int identity not null primary key,
GroupNumber int not null
)
GO

CREATE TABLE Teachers
(
ID_teacher int identity not null primary key,
Login varchar(30) not null,
Password varchar(40) not null,
Name_teacher varchar(40) not null
)
GO

CREATE TABLE Tests
(
ID_test int identity not null primary key,
ID_teacher int not null foreign key references Teachers(ID_teacher),
Name_test varchar(30) not null,
Date_created date not null,
Comment varchar(50) null
)

CREATE TABLE Students
(
ID_student int identity not null primary key,
Name_student varchar(50) not null,
ID_group int not null foreign key references Groups(ID_Group)
)
GO

CREATE TABLE Results
(
ID_result int identity not null primary key,
ID_student int not null foreign key references Students(ID_student),
ID_test int not null foreign key references Tests(ID_test),
Date_testing date not null,
Grade varchar(2) not null
)
GO
