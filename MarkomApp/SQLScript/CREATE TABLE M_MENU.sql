-- Create a new table called '[M_MENU]' in schema '[dbo]'
-- Drop the table if it already exists
USE MarkomDB
IF OBJECT_ID('[dbo].[M_MENU]', 'U') IS NOT NULL
DROP TABLE [dbo].[M_MENU]
GO
-- Create the table in the specified schema
CREATE TABLE [dbo].[M_MENU]
(
    [Id] INT NOT NULL IDENTITY(1,1) PRIMARY KEY , -- Primary Key column
    [Code] NVARCHAR(50) NOT NULL,
    [Name] NVARCHAR(50) NOT NULL,
	[Controller] NVARCHAR(50) NOT NULL,
	[Parent_Id] INT NULL,
    [Description] NVARCHAR(255) NULL,
    [Is_Delete] BIT NOT NULL DEFAULT 0,
    [Created_By] NVARCHAR(50) NOT NULL,
    [Created_Date] DATETIME NOT NULL,
    [Updated_By] NVARCHAR(50) NULL,
    [Updated_Date] DATETIME NULL,
    -- Specify more columns here
);
GO