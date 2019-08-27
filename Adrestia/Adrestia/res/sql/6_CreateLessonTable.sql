/*
 * CREATE LESSON
 */

CREATE TABLE LESSON(
	LessonID			[int]			NOT NULL,
	LessonDate			[varchar](30)	NULL,
	LessonTime			[varchar](30)	NULL,
	Price				[varchar](13)	NULL,
	[Description]		[varchar](50)	NULL,
	MaxNoOfStudents		[money]			NULL,
	InstructorID		[int],

	CONSTRAINT	PK_Lesson				PRIMARY KEY (LessonID),
	CONSTRAINT	FK_Lesson_InstructorID	FOREIGN KEY ([InstructorID])	REFERENCES INSTRUCTOR (InstructorID)
		ON DELETE NO ACTION
		ON UPDATE CASCADE
	);