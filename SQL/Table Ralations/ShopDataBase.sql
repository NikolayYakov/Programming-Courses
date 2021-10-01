CREATE DATABASE OnlineStore
CREATE TABLE Cities
(
   CityID INT PRIMARY KEY,
   [Name] VARCHAR(50)
)
CREATE TABLE Customers
(
   CustomerID  INT PRIMARY KEY,
   [Name] VARCHAR(50),
   Birthday  DATE,
   CityID  INT REFERENCES Cities(CityID) NOT NULL
  
)
CREATE TABLE Orders 
(
   OrderID  INT PRIMARY KEY,
   CustomerID  INT REFERENCES Customers(CustomerID) NOT NULL
)
CREATE TABLE ItemTypes
(
   ItemTypeID INT PRIMARY KEY,
   [Name] VARCHAR(50)
)
CREATE TABLE Items
(
   ItemID INT PRIMARY KEY,
   [Name] VARCHAR(50),
   ItemTypeID INT REFERENCES ItemTypes(ItemTypeID) NOT NULL

)
CREATE TABLE OrderItems
(
   OrderID INT REFERENCES Orders(OrderID) NOT NULL,
   ItemID INT REFERENCES Items(ItemID) NOT NULL

)


