﻿CREATE TABLE [dbo].[Scores]
(
	[Id] INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
	[Value] INT NOT NULL,
	DisciplineID INT NOT NULL FOREIGN KEY REFERENCES Disciplines(ID),
	StudentID INT NOT NULL FOREIGN KEY REFERENCES Students(ID)
)