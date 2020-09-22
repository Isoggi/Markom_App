-- Create a new table called '[M_EMPLOYEE]' in schema '[dbo]'
-- Drop the table if it already exists
USE MarkomDB
IF OBJECT_ID('[dbo].[M_EMPLOYEE]', 'U') IS NOT NULL
DROP TABLE [dbo].[M_EMPLOYEE]
GO
-- Create the table in the specified schema
CREATE TABLE [dbo].[M_EMPLOYEE]
(
    [Id] INT NOT NULL IDENTITY(1,1) PRIMARY KEY , -- Primary Key column
    [Employee_Number] NVARCHAR(50) NOT NULL,
    [First_Name] NVARCHAR(50) NOT NULL,
    [Last_Name] NVARCHAR(50) NULL, 
    [M_Company_Id] INT NULL,
    [Email] NVARCHAR(50) NULL,
    [Is_Delete] BIT NOT NULL DEFAULT 0,
    [Created_By] NVARCHAR(50) NOT NULL,
    [Created_Date] DATETIME NOT NULL,
    [Updated_By] NVARCHAR(50) NULL,
    [Updated_Date] DATETIME NULL,
	CONSTRAINT FK_COMPANYEMPLOYEE FOREIGN KEY (M_Company_Id) REFERENCES M_COMPANY(Id)
    -- Specify more columns here
);
GO