CREATE TABLE [dbo].[OrderItem] (
    [ID]         INT             IDENTITY (1, 1) NOT NULL,
    [order_id]   INT             NOT NULL,
    [product_id] INT             NOT NULL,
    [quantity]   INT             NOT NULL,
    [unit_cost]  DECIMAL (18, 2) NOT NULL,
    [subtotal]   DECIMAL (18, 2) NOT NULL,
    CONSTRAINT [PK_OrderItem] PRIMARY KEY CLUSTERED ([ID] ASC)
);

