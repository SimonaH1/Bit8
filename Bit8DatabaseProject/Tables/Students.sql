﻿CREATE TABLE [dbo].[Students]
(
	[Id] INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
	[Name] NVARCHAR(256) NOT NULL,
	[DOB] DATETIME NOT NULL,
	[Address] NVARCHAR(256),
	[PhoneNumber] INT
)