CREATE TABLE Teachers
(
  TeacherID INT PRIMARY KEY,
  [Name] NVARCHAR(MAX),
  ManagerID INT REFERENCES Teachers(TeacherID) 
)
INSERT INTO Teachers(TeacherID,[Name],ManagerID) VALUES
(101,'John',NULL),
(102,'Toni',106),
(103,'Silvia',106),
(104,'Ted',105),
(105,'Mark',101),
(106,'Greta',101)
