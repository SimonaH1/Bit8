CREATE PROCEDURE [dbo].[TopStudents]
	@SemesterID INT = 0,
	@MaxResults INT = 10
AS
BEGIN
    SET NOCOUNT ON;
	SELECT DISTINCT TOP(@MaxResults) s.Id AS StudentID,
		s.[Name] AS StudentName,
		AVG(sc.[Value]) AS StudentAvgScore 
	FROM Students s 
	INNER JOIN StudentDisciplines sd ON sd.StudentID = s.Id
	INNER JOIN Scores sc ON sc.DisciplineID = sd.DisciplineID AND sc.StudentID = s.Id
	INNER JOIN SemesterDisciplines semD on semD.DisciplineID = sd.DisciplineID
	GROUP BY s.Id, s.[Name], semD.SemesterID

END
