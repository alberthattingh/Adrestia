/*
 * CREATE STUDENT
 */

CREATE TABLE [STUDENT](
	[StudentID] [int]			NOT NULL,
	[FirstName] [varchar](30)	NULL,
	[LastName]	[varchar](30)	NULL,
	[CellNo]	[varchar](13)	NULL,
	[Email]		[varchar](50)	NULL,
	[Credits]	[money]			NULL,

	CONSTRAINT	PK_Student			PRIMARY KEY (StudentID),
	CONSTRAINT	FK_Student_UserID	FOREIGN KEY (StudentID)	REFERENCES [USER] (UserID)
		ON DELETE CASCADE
		ON UPDATE CASCADE
	);