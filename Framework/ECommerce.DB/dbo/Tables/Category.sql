CREATE TABLE [dbo].[Category] (
    [ID]                  INT            IDENTITY (1, 1) NOT NULL,
    [name]                NVARCHAR (200) NOT NULL,
    [description]         NVARCHAR (MAX) NOT NULL,
    [image_name]          NVARCHAR (500) NOT NULL,
    [status]              INT            NOT NULL,
    [date_created]        DATETIME       NOT NULL,
    [date_modified]       DATETIME       NOT NULL,
    [created_account_id]  INT            NOT NULL,
    [modified_account_id] INT            NOT NULL,
    CONSTRAINT [PK_Category] PRIMARY KEY CLUSTERED ([ID] ASC)
);

