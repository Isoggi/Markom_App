-- Create a new table called '[M_MENU_ACCESS]' in schema '[dbo]'
-- Drop the table if it already exists
USE MarkomDB
IF OBJECT_ID('[dbo].[M_MENU_ACCESS]', 'U') IS NOT NULL
DROP TABLE [dbo].[M_MENU_ACCESS]
GO
-- Create the table in the specified schema
CREATE TABLE [dbo].[M_MENU_ACCESS]
(
    [Id] INT NOT NULL IDENTITY(1,1) PRIMARY KEY , -- Primary Key column
    [M_Role_Id] INT(50) NOT NULL,
    [M_Menu_Id] INT(50) NOT NULL,
    [Is_Delete] BIT NOT NULL DEFAULT 0,
    [Created_By] NVARCHAR(50) NOT NULL,
    [Created_Date] DATETIME NOT NULL,
    [Updated_By] NVARCHAR(50) NULL,
    [Updated_Date] DATETIME NULL,
	CONSTRAINT FK_MENUACCESSROLE FOREIGN KEY (M_Role_Id) REFERENCES M_ROLE(Id),
	CONSTRAINT FK_MENUACCESSMENU FOREIGN KEY (M_Menu_Id) REFERENCES M_MENU(Id)
    -- Specify more columns here
);
GO