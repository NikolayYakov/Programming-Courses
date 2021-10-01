CREATE TABLE Passports
(
  PassportID INT PRIMARY KEY,
  PassportNumber NVARCHAR(MAX)
)
INSERT INTO Passports(PassportID, PassportNumber)
VALUES 
(101,'N34FG21B'),
(102,'K65LO4R7'),
(103,'ZE657QP2')
CREATE TABLE Persons
(
  PersonId INT  PRIMARY KEY ,
  FirstName NVARCHAR(MAX) NOT NULL,
  Salary DECIMAL(18,2),
  PassportID INT UNIQUE REFERENCES Passports(PassportID)
)


INSERT INTO Persons(PersonID,FirstName,Salary,PassportID)
VALUES 
(1,'Roberto',43300.00,102),
(2,'Tom',56100.00,103),
(3,'Yana',60200.00,101)

 