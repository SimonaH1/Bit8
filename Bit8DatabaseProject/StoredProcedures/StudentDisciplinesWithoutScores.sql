CREATE PROCEDURE [dbo].[StudentDisciplinesWithoutScores]
AS
BEGIN
	SET NOCOUNT ON;

	SELECT s.[Name] AS StudentName, 
		d.DisciplineName, 
		sem.[Name] AS SemesterName,
		sc.Value
	FROM Students s 
	INNER JOIN StudentSemester ss ON ss.StudentID = s.Id
	INNER JOIN Semesters sem ON sem.Id = ss.SemesterID
	INNER JOIN StudentDisciplines sd ON sd.StudentID = s.Id
	INNER JOIN Disciplines d ON d.ID = sd.DisciplineID 
	LEFT JOIN Scores sc ON sc.DisciplineID = d.ID AND sc.StudentID = s.Id
	WHERE sc.[Value] IS NULL AND d.ID IS NOT NULL
	ORDER BY s.[Name], sem.[Name]

END
