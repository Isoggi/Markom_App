-- Table: master.M_USER

-- DROP TABLE master."M_USER";

CREATE TABLE master."M_USER"
(
    "Id" bigint NOT NULL,
	"Username" varchar(50) NOT NULL,
	"Password" varchar(50) NOT NULL,
	"MRoleId" bigint NOT NULL,
	"MEmployeeId" bigint NOT NULL,
	"IsDelete" boolean NOT NULL,
	"CreatedBy" varchar(50) NOT NULL,
	"CreatedDate" date NOT NULL,
	"UpdatedBy" varchar(50) NULL,
	"UpdatedDate" date NULL,
    CONSTRAINT "M_USER_pkey" PRIMARY KEY ("Id")
)
WITH (
    OIDS = FALSE
)
TABLESPACE pg_default;

ALTER TABLE master."M_USER"
    OWNER to postgres;