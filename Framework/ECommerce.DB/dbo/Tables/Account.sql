CREATE TABLE [dbo].[Account] (
    [ID]                  INT            IDENTITY (1, 1) NOT NULL,
    [first_name]          NVARCHAR (50)  NOT NULL,
    [last_name]           NVARCHAR (50)  NOT NULL,
    [email]               NVARCHAR (255) NOT NULL,
    [password]            NVARCHAR (50)  NOT NULL,
    [salt]                NVARCHAR (50)  NOT NULL,
    [contact_no]          NVARCHAR (30)  NOT NULL,
    [shipping_address]    NVARCHAR (250) NOT NULL,
    [country]             NVARCHAR (50)  NOT NULL,
    [status]              INT            NOT NULL,
    [role]                INT            NOT NULL,
    [date_created]        DATETIME       NOT NULL,
    [date_modified]       DATETIME       NOT NULL,
    [created_account_id]  INT            NOT NULL,
    [modified_account_id] INT            NOT NULL,
    CONSTRAINT [PK_Account] PRIMARY KEY CLUSTERED ([ID] ASC)
);

