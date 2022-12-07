create table Student
(

StudentID int Identity (1,1) not null primary  key,
StudentName varchar(255),
StudentCourse varchar(255)

)
Insert into Student (StudentID, StudentName, StudentCourse) values ( 1, 'Ali', 'Maths' );
Insert into Student (StudentID, StudentName, StudentCourse) values ( 2, 'Ali2', 'Maths2' );
Insert into Student (StudentID, StudentName, StudentCourse) values ( 3, 'Ali3', 'Maths3' )



create table Course
(

CourseID int Identity (1,1) not null primary  key,
CourseName varchar(50),
CreditHours varchar(50)
)
Insert into Course(CourseID, CourseName, CreditHours) values ( 1, 'Ali', 'Maths' );
Insert into Course (CourseID, CourseName, CreditHours) values ( 2, 'Ali2', 'Maths2' );
Insert into Course (CourseID, CourseName, CreditHours) values ( 3, 'Ali3', 'Maths3' )

create table Enrollment 
(

EnrollemtNumber int Identity (1,1) not null primary  key,
StudentID int,
CourseID int,
FOREIGN KEY  (StudentID) REFERENCES Student(StudentId),
FOREIGN KEY (CourseID) REFERENCES Course(CourseID)
)