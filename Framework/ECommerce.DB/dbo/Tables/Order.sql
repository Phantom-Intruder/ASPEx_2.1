CREATE TABLE [dbo].[Order] (
    [ID]             INT             IDENTITY (1, 1) NOT NULL,
    [account_id]     INT             NOT NULL,
    [date_created]   DATETIME        NOT NULL,
    [status]         INT             NOT NULL,
    [payment_method] INT             NOT NULL,
    [total_amount]   DECIMAL (18, 2) NOT NULL,
    CONSTRAINT [PK_Order] PRIMARY KEY CLUSTERED ([ID] ASC)
);

