-- Create a new table called '[TableName]' in schema '[dbo]'
-- Drop the table if it already exists
CT_ID('[dbo].[M_COMPANY]', 'U') IS NOT NULL
BLE [dbo].[M_COMPANY]
GO
-- Create the table in the specified schema
TABLE [dbo].[M_COMPANY]
(
    [Id] INT NOT NULL IDENTITY(1,1) PRIMARY KEY , -- Primary Key column
    [Code] NVARCHAR(50) NOT NULL,
    [Name] NVARCHAR(50) NOT NULL,
    [Address] NVARCHAR(255) NULL,
    [Phone] NVARCHAR(50) NULL,
    [Email] NVARCHAR(50) NULL,
    
    -- Specify more columns here
);
GO