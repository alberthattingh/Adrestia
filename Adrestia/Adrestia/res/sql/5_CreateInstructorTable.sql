/*
 * CREATE INSTRUCTOR
 */

CREATE TABLE INSTRUCTOR(
	[InstructorID]	[int]			NOT NULL,
	[FirstName]		[varchar](30)	NULL,
	[LastName]		[varchar](30)	NULL,
	[CellNo]		[varchar](13)	NULL,
	[Email]			[varchar](50)	NULL,
	[Salary]		[money]			NULL,

	CONSTRAINT	PK_Instructor			PRIMARY KEY ([InstructorID]),
	CONSTRAINT	FK_Instructor_UserID	FOREIGN KEY ([InstructorID])	REFERENCES [USER] (UserID)
		ON DELETE CASCADE
		ON UPDATE CASCADE
	);