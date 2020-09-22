-- Create a new table called '[M_UNIT]' in schema '[dbo]'
-- Drop the table if it already exists
USE MarkomDB
IF OBJECT_ID('[dbo].[M_UNIT]', 'U') IS NOT NULL
DROP TABLE [dbo].[M_UNIT]
GO
-- Create the table in the specified schema
CREATE TABLE [dbo].[M_UNIT]
(
    [Id] INT NOT NULL IDENTITY(1,1) PRIMARY KEY , -- Primary Key column
    [Code] NVARCHAR(50) NOT NULL,
    [Name] NVARCHAR(50) NOT NULL,
    [Description] NVARCHAR(255) NULL,
    [Is_Delete] BIT NOT NULL DEFAULT 0,
    [Created_By] NVARCHAR(50) NOT NULL,
    [Created_Date] DATETIME NOT NULL,
    [Updated_By] NVARCHAR(50) NULL,
    [Updated_Date] DATETIME NULL,
    -- Specify more columns here
);
GO