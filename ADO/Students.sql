﻿CREATE TABLE [dbo].[Students]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY,
	Firstname VARCHAR(50) NOT NULL,
	Lastname VARCHAR(50) NOT NULL,
	Birthdate DATETIME2 NOT NULL,
	YearResult int NOT NULL,
	SectionId INT NOT NULL REFERENCES Sections(Id),
	Active BIT NOT NULL DEFAULT 1, 
    CONSTRAINT [CK_Result] CHECK (YearResult BETWEEN 0 AND 20)
)
