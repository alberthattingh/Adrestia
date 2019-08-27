/*
 * CREATE VENUE
 */

 CREATE TABLE VENUE(
	VenueID			INT			NOT NULL,
	[Description]	VARCHAR(30),
	MaxNoOfSeats	INT,

	CONSTRAINT PK_Venue	PRIMARY KEY (VenueID)
	);