USE master 
GO

IF exists (SELECT * FROM sysdatabases WHERE NAME='MillSimDB')
DROP DATABASE MillSimDB
GO

CREATE DATABASE MillSimDB
ON PRIMARY
(
	NAME = MillSimDB,
	FILENAME = 'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\MillSimDB.mdf',
	SIZE = 50MB,
	MAXSIZE = 60MB,
	FILEGROWTH = 5%

)
LOG ON
(
	NAME = MillSimDB_Log,
	FILENAME = 'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\MillSimDB.ldf',
	SIZE = 10MB,
	MAXSIZE = 20MB,
	FILEGROWTH = 5%
)
GO

USE MillSimDB
GO

CREATE TABLE Planes
(
	PlaneID NVARCHAR(5) PRIMARY KEY,
	Speed INT NOT NULL,
	FreightWeight INT,
	FuelEfficency INT--R/km
)
GO

CREATE TABLE Users
(
	UserID INT IDENTITY(1,1) PRIMARY KEY,
	Username NVARCHAR(30) NOT NULL,
	Name NVARCHAR(30) NOT NULL,
	Surname NVARCHAR(30) NOT NULL,
	Age INT NOT NULL,
	Password NVARCHAR(30) NOT NULL,
)
GO

CREATE TABLE Reports
(
	ReportID INT IDENTITY(1,1) PRIMARY KEY,
	Efficency INT NOT NULL,
	Description NVARCHAR(255) NOT NULL,
	Date SMALLDATETIME NOT NULL,
	PlaneID NVARCHAR(5) UNIQUE FOREIGN KEY REFERENCES Planes(PlaneID)
)
GO

INSERT INTO Planes(PlaneID,Speed,FreightWeight,FuelEfficency) VALUES ('JTONE',1000,0,25.0)
INSERT INTO Planes(PlaneID,Speed,FreightWeight,FuelEfficency) VALUES ('JTTWO',750,0,15.0)
INSERT INTO Planes(PlaneID,Speed,FreightWeight,FuelEfficency) VALUES ('JTTHR',800,0,35.0)
INSERT INTO Planes(PlaneID,Speed,FreightWeight,FuelEfficency) VALUES ('JTFOU',2000,0,55.0)
GO

INSERT INTO Users(Username,Name,Surname,Age,Password) VALUES ('Admin','Admin','Admin',100,'123')
INSERT INTO Users(Username,Name,Surname,Age,Password) VALUES ('Gus','Gustaf','Delport',20,'Gus123')
INSERT INTO Users(Username,Name,Surname,Age,Password) VALUES ('Rod','Rodney','Shilenge',18,'Password')
GO


