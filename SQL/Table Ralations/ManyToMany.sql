CREATE TABLE Students
(
  StudentID INT PRIMARY KEY,
  [Name] NVARCHAR(MAX),
)
INSERT INTO Students(StudentID,[Name]) VALUES
(1,'Mila'),
(2,'Toni'),
(3,'Ron')
CREATE TABLE Exams
(
  ExamID INT PRIMARY KEY,
  [Name] NVARCHAR(MAX),
)
INSERT INTO Exams(ExamID,[Name]) VALUES
(101,'SpringMVC'),
(102,'Neo4j'),
(103,'Oracle 11g')

 CREATE TABLE StudentsExams
(
  StudentID INT REFERENCES Students(StudentID),
  ExamID INT REFERENCES Exams(ExamID),
  CONSTRAINT PK_StudentsExams PRIMARY KEY (StudentID,ExamID)
)

INSERT INTO StudentsExams(StudentID,ExamID) VALUES
(1,101),
(1,102),
(2,101),
(3,103),
(2,102),
(2,103)
