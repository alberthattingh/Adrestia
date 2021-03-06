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