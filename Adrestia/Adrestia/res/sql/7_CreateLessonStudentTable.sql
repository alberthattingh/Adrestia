/*
 * CREATE LESSON_STUDENT
 */

CREATE TABLE LESSON_STUDENT(
	LessonID			[int]			NOT NULL,
	StudentID			[int]			NOT NULL,

	CONSTRAINT	PK_LessonStudent		PRIMARY KEY (LessonID, StudentID),

	CONSTRAINT	FK_Lesson_ID			FOREIGN KEY (LessonID)	REFERENCES LESSON (LessonID)
		ON DELETE NO ACTION
		ON UPDATE NO ACTION,

	CONSTRAINT	FK_Lesson_Student		FOREIGN KEY (StudentID)	REFERENCES STUDENT (StudentID)
		ON DELETE CASCADE
		ON UPDATE CASCADE
	);