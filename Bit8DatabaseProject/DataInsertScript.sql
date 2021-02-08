IF NOT EXISTS(SELECT 1 FROM Students)
BEGIN
	-- Insert data for Students
	INSERT INTO Students(Name, DOB)
	VALUES ('Simona Simonovska', '03-07-1992')

	DECLARE @Student1ID INT = SCOPE_IDENTITY();

	INSERT INTO Students(Name, DOB)
	VALUES ('Petar Petrovski', '02-07-1990')

	DECLARE @Student2ID INT = SCOPE_IDENTITY();

	INSERT INTO Students(Name, DOB)
	VALUES ('Jane Hristovska', '05-06-1998')

	DECLARE @Student3ID INT = SCOPE_IDENTITY();

	INSERT INTO Students(Name, DOB)
	VALUES ('Goran Petrovski', '06-07-1994')

	DECLARE @Student4ID INT = SCOPE_IDENTITY();

	--Insert data for Semesters
	INSERT INTO Semesters(Name, StartDate, EndDate)
	VALUES('Semester 1', '01-01-2020', '06-06-2020')

	DECLARE @SemesterID1 INT = SCOPE_IDENTITY();

	INSERT INTO Semesters(Name, StartDate, EndDate)
	VALUES('Semester 2', '09-09-2020', '01-01-2021')

	DECLARE @SemesterID2 INT = SCOPE_IDENTITY();

	INSERT INTO Semesters(Name, StartDate, EndDate)
	VALUES('Semester 3', '01-01-2021', '06-06-2021')

	DECLARE @SemesterID3 INT = SCOPE_IDENTITY();

	INSERT INTO Semesters(Name, StartDate, EndDate)
	VALUES('Semester 4', '06-06-2021', '01-02-2022')

	DECLARE @SemesterID4 INT = SCOPE_IDENTITY();

	--Insert data for Student Semesters
	INSERT INTO StudentSemester (StudentID, SemesterID)
	VALUES (@Student1ID, @SemesterID1),
		(@Student1ID, @SemesterID2),
		(@Student3ID, @SemesterID2),
		(@Student4ID, @SemesterID3),
		(@Student2ID, @SemesterID3)

	--Insert data for Disciplines
	INSERT INTO Disciplines(DisciplineName, ProfesorName)
	VALUES ('Math', 'Simona Hristovska')

	DECLARE @Discipline1ID INT = SCOPE_IDENTITY();

	INSERT INTO Disciplines(DisciplineName, ProfesorName)
	VALUES ('Chemistry', 'Ruth Smith')

	DECLARE @Discipline2ID INT = SCOPE_IDENTITY();


	INSERT INTO Disciplines(DisciplineName, ProfesorName)
	VALUES ('Art', 'Ted Erikson')

	DECLARE @Discipline3ID INT = SCOPE_IDENTITY();


	INSERT INTO Disciplines(DisciplineName, ProfesorName)
	VALUES ('Astrology', 'Nil Amstrong')

	DECLARE @Discipline4ID INT = SCOPE_IDENTITY();


	--Insert data into Scores
	INSERT INTO Scores(Value, DisciplineID, StudentID)
	VALUES(10, @Discipline1ID, @Student1ID),
          (8, @Discipline3ID, @Student2ID),
	      (9, @Discipline4ID, @Student1ID),
		  (10, @Discipline1ID, @Student3ID),
		  (10, @Discipline2ID, @Student1ID),
		  (9, @Discipline2ID, @Student3ID)

	--Insert data for Semester Disciplines
	INSERT INTO SemesterDisciplines(DisciplineID, SemesterID)
	VALUES (@Discipline1ID, @SemesterID1),
		(@Discipline1ID, @SemesterID1),
		(@Discipline2ID, @SemesterID1),
		(@Discipline3ID, @SemesterID2),
		(@Discipline4ID, @SemesterID2),
		(@Discipline1ID, @SemesterID2),
		(@Discipline2ID, @SemesterID3),
		(@Discipline3ID, @SemesterID3),
		(@Discipline4ID, @SemesterID3)

	-- Insert data for Student Disciplines
	INSERT INTO StudentDisciplines(StudentID, DisciplineID)
	VALUES(@Student1ID, @Discipline1ID),
		(@Student1ID, @Discipline2ID),
		(@Student1ID, @Discipline3ID),
		(@Student2ID, @Discipline1ID),
		(@Student2ID, @Discipline2ID),
		(@Student3ID, @Discipline3ID),
		(@Student3ID, @Discipline2ID)

END