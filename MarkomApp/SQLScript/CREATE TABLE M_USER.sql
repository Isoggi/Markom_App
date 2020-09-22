-- Table: master.M_USER

-- DROP TABLE master."M_USER";

-- CREATE TABLE master."M_USER"
-- (
    -- "Id" bigint NOT NULL,
	-- "Username" varchar(50) NOT NULL,
	-- "Password" varchar(50) NOT NULL,
	-- "MRoleId" bigint NOT NULL,
	-- "MEmployeeId" bigint NOT NULL,
	-- "IsDelete" boolean NOT NULL,
	-- "CreatedBy" varchar(50) NOT NULL,
	-- "CreatedDate" date NOT NULL,
	-- "UpdatedBy" varchar(50) NULL,
	-- "UpdatedDate" date NULL,
    -- CONSTRAINT "M_USER_pkey" PRIMARY KEY ("Id")
-- )
-- WITH (
    -- OIDS = FALSE
-- )
-- TABLESPACE pg_default;

-- ALTER TABLE master."M_USER"
    -- OWNER to postgres;
	
USE MarkomDB
IF OBJECT_ID('[dbo].[M_USER]', 'U') IS NOT NULL
DROP TABLE [dbo].[M_USER]
GO
-- Create the table in the specified schema
CREATE TABLE [dbo].[M_USER]
(
    [Id] INT NOT NULL IDENTITY(1,1) PRIMARY KEY , -- Primary Key column
    [Username] NVARCHAR(50) NOT NULL,
    [Password] NVARCHAR(50) NOT NULL,
    [M_Role_Id] INT NOT NULL,
	[M_Employee_Id] INT NOT NULL,
	-- "MEmployeeId" bigint NOT NULL,
    [Is_Delete] BIT NOT NULL DEFAULT 0,
    [Created_By] NVARCHAR(50) NOT NULL,
    [Created_Date] DATETIME NOT NULL,
    [Updated_By] NVARCHAR(50) NULL,
    [Updated_Date] DATETIME NULL,
	CONSTRAINT FK_USERROLE FOREIGN KEY (M_Role_Id) REFERENCES M_ROLE(Id),
	CONSTRAINT FK_USEREMPLOYEE FOREIGN KEY (M_Employee_Id) REFERENCES M_EMPLOYEE(Id)
    -- Specify more columns here
);
GO