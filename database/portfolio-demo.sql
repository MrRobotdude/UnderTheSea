-- Reconstructed portfolio demonstration, inferred from the existing C# models.
-- This is not the missing original database. Only ticketing is supported here.
-- Run only against a NEW dedicated database called UnderTheSeaPortfolioDemo.
IF DB_NAME() <> 'UnderTheSeaPortfolioDemo'
    THROW 50000, 'Use the dedicated UnderTheSeaPortfolioDemo database.', 1;
IF OBJECT_ID('dbo.MsEmployee') IS NOT NULL
    THROW 50001, 'Demo tables already exist; this script never resets data.', 1;
GO
CREATE TABLE dbo.MsEmployee (
    EmployeeID int IDENTITY PRIMARY KEY,
    UserName nvarchar(100) NOT NULL UNIQUE,
    Password nvarchar(100) NOT NULL,
    DepartmentID int NOT NULL,
    DivisionID int NOT NULL,
    Status nvarchar(30) NOT NULL,
    Salary nvarchar(30) NOT NULL
);
CREATE TABLE dbo.MsTicket (
    TicketID int IDENTITY PRIMARY KEY,
    TicketDate datetime NOT NULL DEFAULT GETDATE(),
    Status nvarchar(30) NOT NULL DEFAULT 'Available'
);
INSERT dbo.MsEmployee (UserName,Password,DepartmentID,DivisionID,Status,Salary)
VALUES ('demo-attraction','demo-only',3,0,'Active','0');
INSERT dbo.MsTicket(TicketDate,Status) VALUES
(GETDATE(),'Available'),(DATEADD(day,1,GETDATE()),'Available');
GO
CREATE PROCEDURE dbo.Ticket_Insert AS
BEGIN
    SET NOCOUNT ON;
    INSERT dbo.MsTicket DEFAULT VALUES;
END;
GO
CREATE PROCEDURE dbo.Cancel_Ticket @TicketID int AS
BEGIN
    SET NOCOUNT ON;
    UPDATE dbo.MsTicket SET Status='Cancelled' WHERE TicketID=@TicketID;
END;
GO
CREATE PROCEDURE dbo.Ticket_UpdateDate @ticketID int, @newDate datetime AS
BEGIN
    SET NOCOUNT ON;
    UPDATE dbo.MsTicket SET TicketDate=@newDate WHERE TicketID=@ticketID;
END;
GO
CREATE PROCEDURE dbo.Ticket_UpdateStatus @ticketID int, @Status nvarchar(30) AS
BEGIN
    SET NOCOUNT ON;
    UPDATE dbo.MsTicket SET Status=@Status WHERE TicketID=@ticketID;
END;
GO
