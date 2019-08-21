CREATE TABLE [STUDENT](
	[StudentID] [int] NOT NULL,
	[FirstName] [varchar](30) NULL,
	[LastName] [varchar](30) NULL,
	[CellNo] [varchar](13) NULL,
	[Email] [varchar](50) NULL,
	[Credits] [money] NULL,
	[InstrumentSignedOut] [int] NULL /*FOREIGN KEY REFERENCES INSTRUMENT(InstrumentID)*/
	);