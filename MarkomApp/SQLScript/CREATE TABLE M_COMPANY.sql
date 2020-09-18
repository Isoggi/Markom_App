-- Create a new table called '[TableName]' in schema '[dbo]'
-- Drop the table if it already exists
USE MarkomDB
IF OBJECT_ID('[dbo].[M_COMPANY]', 'U') IS NOT NULL
DROP TABLE [dbo].[M_COMPANY]
GO
-- Create the table in the specified schema
CREATE TABLE [dbo].[M_COMPANY]
(
    [Id] INT NOT NULL IDENTITY(1,1) PRIMARY KEY , -- Primary Key column
    [Code] NVARCHAR(50) NOT NULL,
    [Name] NVARCHAR(50) NOT NULL,
    [Address] NVARCHAR(255) NULL,
    [Phone] NVARCHAR(50) NULL,
    [Email] NVARCHAR(50) NULL,
    [Is_Delete] BIT NOT NULL DEFAULT 0,
    [Created_By] NVARCHAR(50) NOT NULL,
    [Created_Date] DATETIME NOT NULL,
    [Updated_By] NVARCHAR(50) NULL,
    [Updated_Date] DATETIME NULL
    -- Specify more columns here
);
GO