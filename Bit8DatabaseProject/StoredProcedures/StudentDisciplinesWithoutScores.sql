CREATE PROCEDURE [dbo].[StudentDisciplinesWithoutScores]
AS
	SELECT s.[Name], 
		d.DisciplineName, 
		sem.[Name] 
	FROM Students s 
	INNER JOIN StudentSemester ss ON ss.StudentID = s.Id
	INNER JOIN Semesters sem ON sem.Id = ss.SemesterID
	LEFT JOIN StudentDisciplines sd ON sd.StudentID = s.Id
	LEFT JOIN Disciplines d ON d.ID = sd.DisciplineID
	LEFT JOIN Scores sc ON sc.DisciplineID = d.ID
	WHERE sc.[Value] IS NULL
	ORDER BY s.[Name], sem.[Name]
