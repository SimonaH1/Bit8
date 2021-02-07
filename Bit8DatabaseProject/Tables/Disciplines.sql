CREATE TABLE [dbo].[Disciplines](
	[ID] [int] IDENTITY(1,1) NOT NULL PRIMARY KEY,
	[DisciplineName] [nchar](100) NOT NULL,
	[ProfesorName] [nchar](100) NOT NULL,
) ON [PRIMARY]