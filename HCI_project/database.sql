IF EXISTS (SELECT name FROM sys.databases WHERE name = N'StudentOrganizerDB')
BEGIN
    -- Force close all connections to the database to ensure we can drop it
    ALTER DATABASE StudentOrganizerDB SET SINGLE_USER WITH ROLLBACK IMMEDIATE;
    DROP DATABASE StudentOrganizerDB;
END
GO
CREATE DATABASE StudentOrganizerDB;
GO

USE StudentOrganizerDB;
GO
USE master;
GO

-- 1. Kick everyone out (close all open connections)
ALTER DATABASE StudentOrganizerDB 
SET SINGLE_USER 
WITH ROLLBACK IMMEDIATE;
GO

-- 2. Now you can delete it safely
DROP DATABASE StudentOrganizerDB;
GO

-- 2. Create Users Table (Parent Table)
CREATE TABLE Users (
    UserID INT PRIMARY KEY IDENTITY(1,1),
    UserName NVARCHAR(100) NOT NULL,
    Password NVARCHAR(255) NOT NULL, 
    Email NVARCHAR(100) UNIQUE NOT NULL,
    Isadmin bit DEFAULT 0 --the default is student
	);
GO
CREATE TABLE Courses (
    CourseID INT PRIMARY KEY IDENTITY(1,1),
    Name NVARCHAR(100) NOT NULL,
    Code NVARCHAR(20) NOT NULL,
    CreditHours INT NOT NULL
    -- No UserID here anymore!
);
GO


-- This creates the Many-to-Many relationship
CREATE TABLE StudentCourses (
    EnrollmentID INT PRIMARY KEY IDENTITY(1,1),
    UserID INT NOT NULL,
    CourseID INT NOT NULL,
    
    CONSTRAINT FK_Enroll_Users FOREIGN KEY (UserID) REFERENCES Users(UserID),
    CONSTRAINT FK_Enroll_Courses FOREIGN KEY (CourseID) REFERENCES Courses(CourseID)
);
GO

CREATE TABLE Tasks (
    TaskID INT PRIMARY KEY IDENTITY(1,1),
    Title NVARCHAR(150) NOT NULL,
    Description NVARCHAR(MAX),
    Deadline DATETIME,
    IsCompleted BIT DEFAULT 0,
	CourseID INT NOT NULL,
    UserID INT NOT NULL,
    CONSTRAINT FK_Tasks_Courses FOREIGN KEY (CourseID) REFERENCES Courses(CourseID),
    CONSTRAINT FK_Tasks_Users FOREIGN KEY (UserID) REFERENCES Users(UserID)
);
GO

-- 5. Create Notes Table
-- A Note belongs to a User and a Course
CREATE TABLE Notes (
    NoteID INT PRIMARY KEY IDENTITY(1,1),
    Content NVARCHAR(MAX) NOT NULL,
    CourseID INT NOT NULL,
    UserID INT NOT NULL,
    CONSTRAINT FK_Notes_Courses FOREIGN KEY (CourseID) REFERENCES Courses(CourseID),
    CONSTRAINT FK_Notes_Users FOREIGN KEY (UserID) REFERENCES Users(UserID)
);
GO

-- 6. Create Grades Table
-- A Grade belongs to a User and a Course
CREATE TABLE Grades (
    GradeID INT PRIMARY KEY IDENTITY(1,1),
    ExamName NVARCHAR(100) NOT NULL, 
    Score FLOAT NOT NULL,
    MaxScore INT NOT NULL,
    CourseID INT NOT NULL,
    UserID INT NOT NULL,
    CONSTRAINT FK_Grades_Courses FOREIGN KEY (CourseID) REFERENCES Courses(CourseID),
    CONSTRAINT FK_Grades_Users FOREIGN KEY (UserID) REFERENCES Users(UserID)
);
GO
