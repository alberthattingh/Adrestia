USE adrestia
GO

CREATE PROCEDURE sp_CreateAllTables
AS
	BEGIN
		/*
		 * CREATE BACKUP_LOG
		 */

		CREATE TABLE [BACKUP_LOG] (
			BackupID	INT		NOT NULL	IDENTITY(1,1)	PRIMARY KEY,
			BackupDate	DATE,
			BackupTime	TIME
			);

		/*
		 * CREATE USER_TYPE
		 */

		CREATE TABLE [USER_TYPE] (
			UserTypeID		INT				NOT NULL	PRIMARY KEY,
			[Description]	VARCHAR(30)
			);

		/*
		 * CREATE USER
		 */

		CREATE TABLE [USER] (
			UserID		INT				NOT NULL	IDENTITY(1000,1)	PRIMARY KEY,
			[Password]	VARCHAR(40)		NOT NULL,
			UserTypeID	INT,
	
			CONSTRAINT FK_User_Type	FOREIGN KEY	(UserTypeID)	REFERENCES	USER_TYPE(UserTypeID)
				ON DELETE NO ACTION
				ON UPDATE CASCADE
			);

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

		/*
		 * CREATE LESSON_STUDENT
		 */

		CREATE TABLE LESSON_STUDENT(
			LessonID			[int]			NOT NULL,
			StudentID			[int]			NOT NULL,

			CONSTRAINT	PK_LessonStudent		PRIMARY KEY (LessonID, StudentID),

			CONSTRAINT	FK_Lesson_ID			FOREIGN KEY (LessonID)	REFERENCES LESSON (LessonID)
				ON DELETE CASCADE
				ON UPDATE CASCADE,

			CONSTRAINT	FK_Lesson_Student		FOREIGN KEY (StudentID)	REFERENCES STUDENT (StudentID)
				ON DELETE CASCADE
				ON UPDATE CASCADE
			);

		/*
		 * CREATE VENUE
		 */

		 CREATE TABLE VENUE(
			VenueID			INT			NOT NULL,
			[Description]	VARCHAR(30),
			MaxNoOfSeats	INT,

			CONSTRAINT PK_Venue	PRIMARY KEY (VenueID)
			);

		/*
		 * CREATE EVENT_TYPE
		 */

		 CREATE TABLE EVENT_TYPE(
			EventTypeID			INT			NOT NULL,
			[Description]		VARCHAR(30),

			CONSTRAINT PK_EventType	PRIMARY KEY (EventTypeID)
			);

		/*
		 * CREATE SPECIAL_EVENT
		 */

		 CREATE TABLE SPECIAL_EVENT(
			EventID				INT			NOT NULL,
			EventDate			DATE,
			EventTime			TIME,
			CostAdult			MONEY,
			CostChildren		MONEY,
			CostPensioner		MONEY,
			VenueID				INT,
			EventTypeID			INT,

			CONSTRAINT PK_SpecialEvent			PRIMARY KEY (EventID),

			CONSTRAINT FK_SpecialEvent_Venue	FOREIGN KEY	(VenueID)		REFERENCES	VENUE		(VenueID)
				ON DELETE	NO ACTION
				ON UPDATE	CASCADE,

			CONSTRAINT FK_SpecialEvent_Type		FOREIGN KEY	(EventTypeID)	REFERENCES	EVENT_TYPE	(EventTypeID)
				ON DELETE	NO ACTION
				ON UPDATE	CASCADE
			);

		/*
		 * CREATE TICKET_SALE
		 */

		 CREATE TABLE TICKET_SALE(
			SaleID			INT		NOT NULL,
			SaleDate		DATE,
			SaleTime		TIME,
			NoOfAdults		INT,
			NoOfChildren	INT,
			NoOfPensioners	INT,
			TotalOfSale		MONEY,
			EventID			INT,

			CONSTRAINT		PK_TicketSale			PRIMARY KEY (SaleID),
			CONSTRAINT		FK_TicketSale_Event		FOREIGN KEY (EventID) REFERENCES SPECIAL_EVENT (EventID)
				ON DELETE	NO ACTION
				ON UPDATE	CASCADE
			);

		/*
		 * CREATE EVENT_STUDENT
		 */

		 CREATE TABLE EVENT_STUDENT(
			EventID		INT						NOT NULL,
			StudentID	INT						NOT NULL,

			CONSTRAINT	PK_EventStudent			PRIMARY KEY (EventID, StudentID),
	
			CONSTRAINT	FK_EventStudent_Event	FOREIGN KEY (EventID)				REFERENCES	SPECIAL_EVENT	(EventID)
				ON DELETE	CASCADE
				ON UPDATE	CASCADE,

			CONSTRAINT	FK_EventStudent_Student	FOREIGN KEY (StudentID)				REFERENCES	STUDENT	(StudentID)
				ON DELETE	CASCADE
				ON UPDATE	CASCADE
			);

		/*
		 * CREATE MESSAGE
		 */


	END