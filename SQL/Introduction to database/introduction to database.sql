
USE Minions
CREATE TABLE Minions
(
   Id INT PRIMARY KEY,
   [Name] VARCHAR(150),
   Age INT
)
CREATE TABLE Towns
(
   Id INT PRIMARY KEY,
   [Name] VARCHAR(150),
    
)
ALTER TABLE Minions
Add TownId INT
ALTER TABLE Minions
ADD FOREIGN KEY (TownId) REFERENCES Towns(Id)
INSERT INTO Towns(Id,Name)VALUES
(1,'Sofia'),
(2,'Plovdiv'),
(3,'Varna')
INSERT INTO Minions(id,Name,Age,Townid)VALUES
(1,'Kevin',22,1),
(2,'Bob',15,3),
(3,'Steward',Null,2)
DELETE FROM Minions
DROP TABLE Minions
DROP TABLE Towns
CREATE TABLE People
(
   Id INT PRIMARY KEY,
   [Name] NVARCHAR(200) NOT NULL,
   [Picture] VARBINARY(MAX),
   [Height] DECIMAL(18,2),
   [Weight] DECIMAL(18,2),
   [Gender] NVARCHAR(1) NOT NULL,
   CONSTRAINT chk_Gender CHECK (Gender IN ('M', 'F')),
   [Birthdate] DATE NOT NULL,
   [Biography] NVARCHAR(MAX)  
)
INSERT INTO People(id,Name,Picture,Height,[Weight],[Gender],[Birthdate],[Biography])VALUES
(1,'Kevin',NULL,22,1,'M','2020-01-01','DAS'),
(2,'Kevin',NULL,22,1,'M','2020-01-01','DAS'),
(3,'Kevin',NULL,22,1,'M','2020-01-01','DAS'),
(4,'Kevin',NULL,22,1,'M','2020-01-01','DAS'),
(5,'Kevin',NULL,22,1,'M','2020-01-01','DAS')
CREATE TABLE Users
(
   Id BIGINT IDENTITY(1,1) PRIMARY KEY,
   [Username] VARCHAR(30) NOT NULL,
   [Password] VARCHAR(26) NOT NULL,
   [ProfilePicture] VARBINARY(MAX),
   [LastLoginTime] DATETIME,
   [IsDeleted] BIT  
)
 
INSERT INTO Users([Username],[Password],[ProfilePicture],[LastLoginTime],[IsDeleted])VALUES
('Kevin','12345678',Null,Null, 1),
('Kevin','12345678',Null,Null, 1),
('Kevin','12345678',Null,Null, 1),
('Kevin','12345678',Null,Null, 1),
('Kevin','12345678',Null,Null, 1)
DELETE FROM Users
DROP TABLE Users
ALTER TABLE Users
DROP CONSTRAINT PK__Users__3214EC07844F67B6
ALTER TABLE Users
ADD CONSTRAINT PK__UsernameId PRIMARY KEY(Username,Id)
ALTER TABLE Users
ADD CONSTRAINT CH__PasswordLen CHECK(LEN(Password)>5)
ALTER TABLE Users
ADD CONSTRAINT DF__LastLogin DEFAULT GETDATE() FOR LastLoginTime
ALTER TABLE Users
DROP CONSTRAINT PK__UsernameId
ALTER TABLE Users
ADD CONSTRAINT PK__Id PRIMARY KEY(Id)
ALTER TABLE Users
ADD CONSTRAINT CH__UsernameLen CHECK(LEN(Username)>3)
CREATE TABLE Directors
( 
   Id INT PRIMARY KEY,
   DirectorName VARCHAR(MAX) NOT NULL,
   Notes VARCHAR(MAX)
)
INSERT INTO Directors(Id,[DirectorName],[Notes])VALUES
(1,'Kevin',Null),
(2,'Kevin',Null),
(3,'Kevin',Null),
(4,'Kevin',Null),
(5,'Kevin',Null)
CREATE TABLE Genres
( 
   Id INT PRIMARY KEY,
   GenresName VARCHAR(MAX) NOT NULL,
   Notes VARCHAR(MAX)
)
INSERT INTO Genres(Id,[GenresName],[Notes])VALUES
(1,'Action',Null),
(2,'Romance',Null),
(3,'MMO',Null),
(4,'Sport',Null),
(5,'Drama',Null)
CREATE TABLE Categories
( 
   Id INT PRIMARY KEY,
   CategoriesName VARCHAR(MAX) NOT NULL,
   Notes VARCHAR(MAX)
)
INSERT INTO Categories(Id,[CategoriesName],[Notes])VALUES
(1,'A',Null),
(2,'R',Null),
(3,'M',Null),
(4,'S',Null),
(5,'D',Null)
CREATE TABLE Movies
( 
   Id INT PRIMARY KEY,
   Title VARCHAR(MAX) NOT NULL,
   DirectorId INT NOT NULL,
   CopyrightYear DATETIME,
   [Length] INT,
   GenreId INT NOT NULL,
   CategoryId INT NOT NULL,
   Rating INT,
   Notes VARCHAR(MAX)
   FOREIGN KEY (DirectorId) REFERENCES Directors(Id),
   FOREIGN KEY (GenreId) REFERENCES Genres(Id),
   FOREIGN KEY (CategoryId) REFERENCES Categories(Id)
)
INSERT INTO Movies(Id,[Title],[DirectorId],[CopyrightYear],[Length],[GenreId],[CategoryId],[Rating],[Notes])VALUES
(1,'A',2,NULL,NULL,3,1,NULL,NULL),
(2,'B',3,NULL,NULL,1,5,NULL,NULL),
(3,'C',1,NULL,NULL,4,5,NULL,NULL),
(4,'D',4,NULL,NULL,5,3,NULL,NULL),
(5,'E',5,NULL,NULL,2,2,NULL,NULL)
CREATE TABLE Categories
( 
   Id INT PRIMARY KEY,
   CategoriesName VARCHAR(MAX) NOT NULL,
   DailyRate DECIMAL(18,2) NOT NULL,
   WeeklyRate DECIMAL(18,2) NOT NULL,
   MonthlyRate DECIMAL(18,2) NOT NULL,
   WeekendRate DECIMAL(18,2) NOT NULL

)
INSERT INTO Categories(Id,[CategoriesName],[DailyRate],[WeeklyRate],[MonthlyRate],[WeekendRate])VALUES
(1,'A',20,40,150,60),
(2,'B',25,45,155,65),
(3,'C',23,43,153,63)

CREATE TABLE Cars
( 
   Id INT PRIMARY KEY,
   PlateNumber VARCHAR(MAX) NOT NULL,
   Manufacturer VARCHAR(MAX) NOT NULL,
   Model VARCHAR(MAX) NOT NULL,
   CarYear INT NOT NULL,
   CategoryId INT NOT NULL,
   Doors INT,
   Picture VARBINARY(MAX),
   Condition VARCHAR(MAX),
   Available BIT,
   FOREIGN KEY (CategoryId) REFERENCES Categories(Id)

)
INSERT INTO Cars(Id,[PlateNumber],[Manufacturer],[Model],[CarYear],[CategoryId],[Doors],[Picture],[Condition],[Available])VALUES
(1,'A1456B','A','A',2000,1,NULL,NULL,NULL,NULL),
(2,'A1456B','A','A',2000,1,NULL,NULL,NULL,NULL),
(3,'A1456B','A','A',2000,1,NULL,NULL,NULL,NULL)
 
 CREATE TABLE Employees
( 
   Id INT PRIMARY KEY,
   FirstName VARCHAR(MAX) NOT NULL,
   LastName VARCHAR(MAX) NOT NULL,
   Title VARCHAR(MAX) NOT NULL,
   Notes VARCHAR(MAX)
 

)
INSERT INTO Employees(Id,[FirstName],[LastName],[Title],[Notes])VALUES
(1,'A','A','A',NULL),
(2,'B','B','B',NULL),
(3,'C','C','C',NULL)
CREATE TABLE Customers
( 
   Id INT PRIMARY KEY,
   DriverLicenceNumber VARCHAR(MAX) NOT NULL,
   FullName VARCHAR(MAX) NOT NULL,
   [Address] VARCHAR(MAX) NOT NULL,
   City VARCHAR(MAX) NOT NULL,
   ZIPCode VARCHAR(MAX) NOT NULL,
   Notes VARCHAR(MAX)
 

)
INSERT INTO Customers(Id,[DriverLicenceNumber],[FullName],[Address],[City],[ZIPCode],[Notes])VALUES
(1,'1313','AA','A','A','123',NULL),
(2,'1311','BB','B','B','132',NULL),
(3,'12312','CC','C','C','131',NULL)

CREATE TABLE RentalOrders
( 
   Id INT PRIMARY KEY,
   EmployeeId INT NOT NULL,
   CustomerId INT NOT NULL,
   CarId INT NOT NULL,
   TankLevel INT NOT NULL,
   KilometrageStart INT,
   KilometrageEnd INT,
   TotalKilometrage INT NOT NULL,
   StartDate DATE,
   EndDate DATE,
   TotalDays INT NOT NULL,
   RateApplied INT NOT NULL,
   TaxRate INT NOT NULL,
   OrderStatus INT,
   Notes VARCHAR(MAX),
   FOREIGN KEY (EmployeeId) REFERENCES Employees(Id),
   FOREIGN KEY (CustomerId) REFERENCES Customers(Id),
   FOREIGN KEY (CarId) REFERENCES Cars(Id)


)
INSERT INTO RentalOrders(Id,[EmployeeId],[CustomerId],[CarId],[TankLevel],[KilometrageStart],[KilometrageEnd],[TotalKilometrage],[StartDate],[EndDate],[TotalDays],[RateApplied],[TaxRate],[OrderStatus],[Notes])VALUES
(1,1,1,1,20,NULL,NULL,300,NULL,NULL,3,40,5,NULL,NULL),
(2,1,1,1,20,NULL,NULL,300,NULL,NULL,3,40,5,NULL,NULL),
(3,1,1,1,20,NULL,NULL,300,NULL,NULL,3,40,5,NULL,NULL)
DROP TABLE RentalOrders
DROP TABLE Customers
DROP TABLE Employees
CREATE TABLE Employees
( 
   Id INT PRIMARY KEY,
   FirstName VARCHAR(MAX) NOT NULL,
   LastName VARCHAR(MAX) NOT NULL,
   Title VARCHAR(MAX) NOT NULL,
   Notes VARCHAR(MAX)
 

)
INSERT INTO Employees(Id,[FirstName],[LastName],[Title],[Notes])VALUES
(1,'A','A','A',NULL),
(2,'B','B','B',NULL),
(3,'C','C','C',NULL)
CREATE TABLE Customers
( 
   Id INT PRIMARY KEY,
   AccountNumber VARCHAR(MAX) NOT NULL,
   FirstName VARCHAR(MAX) NOT NULL,
   LastName VARCHAR(MAX) NOT NULL,
   PhoneNumber VARCHAR(MAX) NOT NULL,
   EmergencyName VARCHAR(MAX),
   EmergencyNumber VARCHAR(MAX),
   Notes VARCHAR(MAX)
 

)
INSERT INTO Customers(Id,[AccountNumber],[FirstName],[LastName],[PhoneNumber],[EmergencyName],[EmergencyNumber],[Notes])VALUES
(1,'1313','A','A','131213',NULL,NULL,NULL),
(2,'1311','B','B','1311313',NULL,NULL,NULL),
(3,'12312','C','C','31312131',NULL,NULL,NULL)
Create Table RoomStatus
(
RoomStatus INT PRIMARY KEY,
NOTES VARCHAR(MAX)

)
INSERT INTO RoomStatus( [RoomStatus],[Notes])VALUES
 (1,NULL),
 (2,NULL),
 (3,NULL)
 Create Table RoomTypes
(
RoomType INT PRIMARY KEY,
NOTES VARCHAR(MAX)

)
INSERT INTO RoomTypes( [RoomType],[Notes])VALUES
 (1,NULL),
 (2,NULL),
 (3,NULL) 
 Create Table BedTypes
(
BedType INT PRIMARY KEY,
NOTES VARCHAR(MAX)

)
INSERT INTO BedTypes( [BedType],[Notes])VALUES
 (1,NULL),
 (2,NULL),
 (3,NULL)  
 Create Table Rooms
(
RoomNumber INT PRIMARY KEY NOT NULL ,
RoomType INT NOT NULL,
BedType INT NOT NULL,
Rate INT,
RoomStatus INT NOT NULL,
NOTES VARCHAR(MAX)
FOREIGN KEY (RoomType) REFERENCES RoomTypes(RoomType),
FOREIGN KEY (BedType) REFERENCES BedTypes(BedType),
FOREIGN KEY (RoomStatus) REFERENCES RoomStatus(RoomStatus),
)
INSERT INTO Rooms( [RoomNumber],[RoomType],[BedType],[Rate],[RoomStatus],[Notes])VALUES
 (1,2,2,2,2,NULL),
 (2,2,2,2,2,NULL),
 (3,2,2,2,2,NULL)
 
Create Table Payments
(
Id INT PRIMARY KEY NOT NULL ,
EmployeeId INT NOT NULL,
PaymentDate VARCHAR(MAX),
AccountNumber VARCHAR(MAX),
FirstDateOccupied DATE,
LastDateOccupied DATE,
TotalDays INT NOT NULL,
AmountCharged DECIMAL(18,2) NOT NULL,
TaxRate INT,
TaxAmount INT,
PaymentTotal DECIMAL(18,2) NOT NULL,
NOTES VARCHAR(MAX)
FOREIGN KEY (EmployeeId) REFERENCES Employees(Id)
)
INSERT INTO Payments( Id,[EmployeeId],[PaymentDate],[AccountNumber],[FirstDateOccupied],[LastDateOccupied],[TotalDays],[AmountCharged],[TaxRate],[TaxAmount],[PaymentTotal],[Notes])VALUES
 (1, 1,'A','12313',NULL,NULL,3,150,NULL,NULL,175,NULL),
 (2, 1,'A','12313',NULL,NULL,3,150,NULL,NULL,175,NULL),
 (3, 1,'A','12313',NULL,NULL,3,150,NULL,NULL,175,NULL)

 Create Table Occupancies
(
Id INT PRIMARY KEY,
EmployeeId INT NOT NULL,
DateOccupied VARCHAR(MAX),
AccountNumber VARCHAR(MAX),
RoomNumber INT NOT NULL,
RateApplied INT,
PhoneCharge DECIMAL(18,2),
NOTES VARCHAR(MAX)
FOREIGN KEY (EmployeeId) REFERENCES Employees(Id)
)
INSERT INTO Occupancies(Id, [EmployeeId],[DateOccupied],[AccountNumber],[RoomNumber],[RateApplied],[PhoneCharge],[Notes])VALUES
 (1,1,'DA','123',12,NULL,NULL,NULL),
 (2,1,'DA','123',12,NULL,NULL,NULL),
 (3,1,'DA','123',12,NULL,NULL,NULL)
 
  Create Table Towns
(
Id INT PRIMARY KEY,
[Name] VARCHAR(MAX)

)
INSERT INTO Towns( [Id],[Name])VALUES
 (1,NULL),
 (2,NULL),
 (3,NULL) 
 Create Table Addresses
(
Id INT PRIMARY KEY,
[AddressText] VARCHAR(MAX),
TownId INT NOT NULL,
FOREIGN KEY (TownId) REFERENCES Towns(Id)

)
INSERT INTO Addresses( [Id],[AddressText],[TownId])VALUES
 (1,NULL,1),
 (2,NULL,1),
 (3,NULL,1) 

  Create Table Departments
(
Id INT PRIMARY KEY,
[Name] VARCHAR(MAX)

)
INSERT INTO Departments( [Id],[Name])VALUES
 (1,NULL),
 (2,NULL),
 (3,NULL)
 DROP TABLE Employees
 Create Table Employees
(
Id INT PRIMARY KEY,
[FirstName] VARCHAR(MAX) NOT NULL,
[MiddleName] VARCHAR(MAX),
[LastName] VARCHAR(MAX),
[JobTitle] VARCHAR(MAX),
DepartmentId INT NOT NULL,
HireDate DATE,
Salary DECIMAL(18,2),
AddressId INT NOT NULL,
FOREIGN KEY (DepartmentId) REFERENCES Departments(Id),
FOREIGN KEY (AddressId) REFERENCES Addresses(Id)



)
INSERT INTO Employees( [Id],[FirstName],[MiddleName],[LastName],[JobTitle],[DepartmentId],[HireDate],[Salary],[AddressId])VALUES
 (1,'a','a','a','a',2,NULL,NULL,1),
 (2,'a','a','a','a',2,NULL,NULL,1),
 (3,'a','a','a','a',2,NULL,NULL,1)
  
 SELECT [Name] FROM Towns  Order By [Name] ASC 
 SELECT [Name] FROM Departments Order By [Name] ASC  
 SELECT [FirstName],[LastName],[JobTitle],[Salary] FROM Employees  ORDER BY SALARY DESC
 UPDATE Employees SET Salary = Salary + 10*Salary/100
 SELECT [Salary] FROM Employees 

DELETE Occupancies
UPDATE Payments SET TaxRate = TaxRate - 3*TaxRate/100
 SELECT [TaxRate] FROM Payments 