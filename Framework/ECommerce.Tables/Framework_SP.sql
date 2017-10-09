/* DROP THE EXISTING PROCEDURE [AccountInsert] */
IF EXISTS (SELECT * FROM dbo.[SysObjects] WHERE ID = OBJECT_ID(N'[dbo].[AccountInsert]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
	DROP PROCEDURE [dbo].[AccountInsert]
GO

/* DROP THE EXISTING PROCEDURE [AccountGetByID] */
IF EXISTS (SELECT * FROM dbo.[SysObjects] WHERE ID = OBJECT_ID(N'[dbo].[AccountGetByID]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
	DROP PROCEDURE [dbo].[AccountGetByID]
GO

/* DROP THE EXISTING PROCEDURE [AccountGetByEmail] */
IF EXISTS (SELECT * FROM dbo.[SysObjects] WHERE ID = OBJECT_ID(N'[dbo].[AccountGetByEmail]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
	DROP PROCEDURE [dbo].[AccountGetByEmail]
GO

/* DROP THE EXISTING PROCEDURE [AccountList] */
IF EXISTS (SELECT * FROM dbo.[SysObjects] WHERE ID = OBJECT_ID(N'[dbo].[AccountList]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
	DROP PROCEDURE [dbo].[AccountList]
GO

/* DROP THE EXISTING PROCEDURE [AccountUpdate] */
IF EXISTS (SELECT * FROM dbo.[SysObjects] WHERE ID = OBJECT_ID(N'[dbo].[AccountUpdate]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
	DROP PROCEDURE [dbo].[AccountUpdate]
GO

/* DROP THE EXISTING PROCEDURE [AccountDelete] */
IF EXISTS (SELECT * FROM dbo.[SysObjects] WHERE ID = OBJECT_ID(N'[dbo].[AccountDelete]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
	DROP PROCEDURE [dbo].[AccountDelete]
GO

/* DROP THE EXISTING PROCEDURE [CategoryInsert] */
IF EXISTS (SELECT * FROM dbo.[SysObjects] WHERE ID = OBJECT_ID(N'[dbo].[CategoryInsert]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
	DROP PROCEDURE [dbo].[CategoryInsert]
GO

/* DROP THE EXISTING PROCEDURE [CategoryGetByID] */
IF EXISTS (SELECT * FROM dbo.[SysObjects] WHERE ID = OBJECT_ID(N'[dbo].[CategoryGetByID]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
	DROP PROCEDURE [dbo].[CategoryGetByID]
GO

/* DROP THE EXISTING PROCEDURE [CategoryList] */
IF EXISTS (SELECT * FROM dbo.[SysObjects] WHERE ID = OBJECT_ID(N'[dbo].[CategoryList]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
	DROP PROCEDURE [dbo].[CategoryList]
GO

/* DROP THE EXISTING PROCEDURE [CategoryUpdate] */
IF EXISTS (SELECT * FROM dbo.[SysObjects] WHERE ID = OBJECT_ID(N'[dbo].[CategoryUpdate]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
	DROP PROCEDURE [dbo].[CategoryUpdate]
GO

/* DROP THE EXISTING PROCEDURE [CategoryDelete] */
IF EXISTS (SELECT * FROM dbo.[SysObjects] WHERE ID = OBJECT_ID(N'[dbo].[CategoryDelete]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
	DROP PROCEDURE [dbo].[CategoryDelete]
GO

/* DROP THE EXISTING PROCEDURE [CategoryListByStatus] */
IF EXISTS (SELECT * FROM dbo.[SysObjects] WHERE ID = OBJECT_ID(N'[dbo].[CategoryListByStatus]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
	DROP PROCEDURE [dbo].[CategoryListByStatus]
GO

/* DROP THE EXISTING PROCEDURE [OrderInsert] */
IF EXISTS (SELECT * FROM dbo.[SysObjects] WHERE ID = OBJECT_ID(N'[dbo].[OrderInsert]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
	DROP PROCEDURE [dbo].[OrderInsert]
GO

/* DROP THE EXISTING PROCEDURE [OrderGetByID] */
IF EXISTS (SELECT * FROM dbo.[SysObjects] WHERE ID = OBJECT_ID(N'[dbo].[OrderGetByID]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
	DROP PROCEDURE [dbo].[OrderGetByID]
GO

/* DROP THE EXISTING PROCEDURE [OrderList] */
IF EXISTS (SELECT * FROM dbo.[SysObjects] WHERE ID = OBJECT_ID(N'[dbo].[OrderList]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
	DROP PROCEDURE [dbo].[OrderList]
GO

/* DROP THE EXISTING PROCEDURE [OrderUpdate] */
IF EXISTS (SELECT * FROM dbo.[SysObjects] WHERE ID = OBJECT_ID(N'[dbo].[OrderUpdate]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
	DROP PROCEDURE [dbo].[OrderUpdate]
GO

/* DROP THE EXISTING PROCEDURE [OrderDelete] */
IF EXISTS (SELECT * FROM dbo.[SysObjects] WHERE ID = OBJECT_ID(N'[dbo].[OrderDelete]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
	DROP PROCEDURE [dbo].[OrderDelete]
GO

/* DROP THE EXISTING PROCEDURE [OrderListByAccountID] */
IF EXISTS (SELECT * FROM dbo.[SysObjects] WHERE ID = OBJECT_ID(N'[dbo].[OrderListByAccountID]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
	DROP PROCEDURE [dbo].[OrderListByAccountID]
GO

/* DROP THE EXISTING PROCEDURE [OrderListByStatus] */
IF EXISTS (SELECT * FROM dbo.[SysObjects] WHERE ID = OBJECT_ID(N'[dbo].[OrderListByStatus]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
	DROP PROCEDURE [dbo].[OrderListByStatus]
GO

/* DROP THE EXISTING PROCEDURE [OrderItemInsert] */
IF EXISTS (SELECT * FROM dbo.[SysObjects] WHERE ID = OBJECT_ID(N'[dbo].[OrderItemInsert]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
	DROP PROCEDURE [dbo].[OrderItemInsert]
GO

/* DROP THE EXISTING PROCEDURE [OrderItemGetByID] */
IF EXISTS (SELECT * FROM dbo.[SysObjects] WHERE ID = OBJECT_ID(N'[dbo].[OrderItemGetByID]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
	DROP PROCEDURE [dbo].[OrderItemGetByID]
GO

/* DROP THE EXISTING PROCEDURE [OrderItemList] */
IF EXISTS (SELECT * FROM dbo.[SysObjects] WHERE ID = OBJECT_ID(N'[dbo].[OrderItemList]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
	DROP PROCEDURE [dbo].[OrderItemList]
GO

/* DROP THE EXISTING PROCEDURE [OrderItemUpdate] */
IF EXISTS (SELECT * FROM dbo.[SysObjects] WHERE ID = OBJECT_ID(N'[dbo].[OrderItemUpdate]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
	DROP PROCEDURE [dbo].[OrderItemUpdate]
GO

/* DROP THE EXISTING PROCEDURE [OrderItemDelete] */
IF EXISTS (SELECT * FROM dbo.[SysObjects] WHERE ID = OBJECT_ID(N'[dbo].[OrderItemDelete]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
	DROP PROCEDURE [dbo].[OrderItemDelete]
GO

/* DROP THE EXISTING PROCEDURE [OrderItemListByOrderID] */
IF EXISTS (SELECT * FROM dbo.[SysObjects] WHERE ID = OBJECT_ID(N'[dbo].[OrderItemListByOrderID]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
	DROP PROCEDURE [dbo].[OrderItemListByOrderID]
GO

/* DROP THE EXISTING PROCEDURE [ProductInsert] */
IF EXISTS (SELECT * FROM dbo.[SysObjects] WHERE ID = OBJECT_ID(N'[dbo].[ProductInsert]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
	DROP PROCEDURE [dbo].[ProductInsert]
GO

/* DROP THE EXISTING PROCEDURE [ProductGetByID] */
IF EXISTS (SELECT * FROM dbo.[SysObjects] WHERE ID = OBJECT_ID(N'[dbo].[ProductGetByID]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
	DROP PROCEDURE [dbo].[ProductGetByID]
GO

/* DROP THE EXISTING PROCEDURE [ProductList] */
IF EXISTS (SELECT * FROM dbo.[SysObjects] WHERE ID = OBJECT_ID(N'[dbo].[ProductList]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
	DROP PROCEDURE [dbo].[ProductList]
GO

/* DROP THE EXISTING PROCEDURE [ProductUpdate] */
IF EXISTS (SELECT * FROM dbo.[SysObjects] WHERE ID = OBJECT_ID(N'[dbo].[ProductUpdate]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
	DROP PROCEDURE [dbo].[ProductUpdate]
GO

/* DROP THE EXISTING PROCEDURE [ProductDelete] */
IF EXISTS (SELECT * FROM dbo.[SysObjects] WHERE ID = OBJECT_ID(N'[dbo].[ProductDelete]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
	DROP PROCEDURE [dbo].[ProductDelete]
GO

/* DROP THE EXISTING PROCEDURE [ProductListByStatus] */
IF EXISTS (SELECT * FROM dbo.[SysObjects] WHERE ID = OBJECT_ID(N'[dbo].[ProductListByStatus]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
	DROP PROCEDURE [dbo].[ProductListByStatus]
GO

/* DROP THE EXISTING PROCEDURE [ShippingInfoInsert] */
IF EXISTS (SELECT * FROM dbo.[SysObjects] WHERE ID = OBJECT_ID(N'[dbo].[ShippingInfoInsert]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
	DROP PROCEDURE [dbo].[ShippingInfoInsert]
GO

/* DROP THE EXISTING PROCEDURE [ShippingInfoGetByID] */
IF EXISTS (SELECT * FROM dbo.[SysObjects] WHERE ID = OBJECT_ID(N'[dbo].[ShippingInfoGetByID]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
	DROP PROCEDURE [dbo].[ShippingInfoGetByID]
GO

/* DROP THE EXISTING PROCEDURE [ShippingInfoList] */
IF EXISTS (SELECT * FROM dbo.[SysObjects] WHERE ID = OBJECT_ID(N'[dbo].[ShippingInfoList]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
	DROP PROCEDURE [dbo].[ShippingInfoList]
GO

/* DROP THE EXISTING PROCEDURE [ShippingInfoUpdate] */
IF EXISTS (SELECT * FROM dbo.[SysObjects] WHERE ID = OBJECT_ID(N'[dbo].[ShippingInfoUpdate]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
	DROP PROCEDURE [dbo].[ShippingInfoUpdate]
GO

/* DROP THE EXISTING PROCEDURE [ShippingInfoDelete] */
IF EXISTS (SELECT * FROM dbo.[SysObjects] WHERE ID = OBJECT_ID(N'[dbo].[ShippingInfoDelete]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
	DROP PROCEDURE [dbo].[ShippingInfoDelete]
GO

/* DROP THE EXISTING PROCEDURE [ShippingInfoListByType] */
IF EXISTS (SELECT * FROM dbo.[SysObjects] WHERE ID = OBJECT_ID(N'[dbo].[ShippingInfoListByType]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
	DROP PROCEDURE [dbo].[ShippingInfoListByType]
GO

CREATE PROCEDURE [dbo].[AccountInsert]
	@first_name NVARCHAR(50),
	@last_name NVARCHAR(50),
	@email NVARCHAR(255),
	@password NVARCHAR(50),
	@salt NVARCHAR(50),
	@contact_no NVARCHAR(30),
	@shipping_address NVARCHAR(250),
	@country NVARCHAR(50),
	@status INT,
	@role INT,
	@date_created DATETIME,
	@date_modified DATETIME,
	@created_account_id INT,
	@modified_account_id INT
AS

	/* Volume Technologies RADA Generator v6.1 */

	INSERT INTO [Account]
	(
		[first_name],
		[last_name],
		[email],
		[password],
		[salt],
		[contact_no],
		[shipping_address],
		[country],
		[status],
		[role],
		[date_created],
		[date_modified],
		[created_account_id],
		[modified_account_id]
	)
	VALUES
	(
		@first_name,
		@last_name,
		@email,
		@password,
		@salt,
		@contact_no,
		@shipping_address,
		@country,
		@status,
		@role,
		@date_created,
		@date_modified,
		@created_account_id,
		@modified_account_id
	)

	SELECT SCOPE_IDENTITY()

GO

CREATE PROCEDURE [dbo].[AccountGetByID]
	@ID INT
AS

	/* Volume Technologies RADA Generator v6.1 */

	SELECT *
	INTO #temp
	FROM [Account]
	WHERE [ID] = @ID

	SELECT *
	FROM #temp

	SELECT *
	FROM [Account]
	WHERE [ID] IN (SELECT [created_account_id] FROM #temp)

	SELECT *
	FROM [Account]
	WHERE [ID] IN (SELECT [modified_account_id] FROM #temp)

GO

CREATE PROCEDURE [dbo].[AccountGetByEmail]
	@email NVARCHAR(255)
AS

	/* Volume Technologies RADA Generator v6.1 */

	SELECT *
	INTO #temp
	FROM [Account]
	WHERE [email] = @email

	SELECT *
	FROM #temp

	SELECT *
	FROM [Account]
	WHERE [ID] IN (SELECT [created_account_id] FROM #temp)

	SELECT *
	FROM [Account]
	WHERE [ID] IN (SELECT [modified_account_id] FROM #temp)

GO

CREATE PROCEDURE [dbo].[AccountList]
	
AS

	/* Volume Technologies RADA Generator v6.1 */

	SELECT *
	INTO #temp
	FROM [Account]

	SELECT *
	FROM #temp

	SELECT *
	FROM [Account]
	WHERE [ID] IN (SELECT [created_account_id] FROM #temp)

	SELECT *
	FROM [Account]
	WHERE [ID] IN (SELECT [modified_account_id] FROM #temp)

GO

CREATE PROCEDURE [dbo].[AccountUpdate]
	@ID INT,
	@first_name NVARCHAR(50),
	@last_name NVARCHAR(50),
	@email NVARCHAR(255),
	@password NVARCHAR(50),
	@salt NVARCHAR(50),
	@contact_no NVARCHAR(30),
	@shipping_address NVARCHAR(250),
	@country NVARCHAR(50),
	@status INT,
	@role INT,
	@date_created DATETIME,
	@date_modified DATETIME,
	@created_account_id INT,
	@modified_account_id INT
AS

	/* Volume Technologies RADA Generator v6.1 */

	UPDATE [Account] SET
		[first_name] = @first_name,
		[last_name] = @last_name,
		[email] = @email,
		[password] = @password,
		[salt] = @salt,
		[contact_no] = @contact_no,
		[shipping_address] = @shipping_address,
		[country] = @country,
		[status] = @status,
		[role] = @role,
		[created_account_id] = @created_account_id,
		[modified_account_id] = @modified_account_id
	WHERE [ID] = @ID

GO

CREATE PROCEDURE [dbo].[AccountDelete]
	@ID INT
AS

	/* Volume Technologies RADA Generator v6.1 */

	DELETE FROM [Account]
	WHERE [ID] = @ID

GO

CREATE PROCEDURE [dbo].[CategoryInsert]
	@name NVARCHAR(200),
	@description NVARCHAR(MAX),
	@image_name NVARCHAR(500),
	@status INT,
	@date_created DATETIME,
	@date_modified DATETIME,
	@created_account_id INT,
	@modified_account_id INT
AS

	/* Volume Technologies RADA Generator v6.1 */

	INSERT INTO [Category]
	(
		[name],
		[description],
		[image_name],
		[status],
		[date_created],
		[date_modified],
		[created_account_id],
		[modified_account_id]
	)
	VALUES
	(
		@name,
		@description,
		@image_name,
		@status,
		@date_created,
		@date_modified,
		@created_account_id,
		@modified_account_id
	)

	SELECT SCOPE_IDENTITY()

GO

CREATE PROCEDURE [dbo].[CategoryGetByID]
	@ID INT
AS

	/* Volume Technologies RADA Generator v6.1 */

	SELECT *
	INTO #temp
	FROM [Category]
	WHERE [ID] = @ID

	SELECT *
	FROM #temp

	SELECT *
	FROM [Account]
	WHERE [ID] IN (SELECT [created_account_id] FROM #temp)

	SELECT *
	FROM [Account]
	WHERE [ID] IN (SELECT [modified_account_id] FROM #temp)

GO

CREATE PROCEDURE [dbo].[CategoryList]
	
AS

	/* Volume Technologies RADA Generator v6.1 */

	SELECT *
	INTO #temp
	FROM [Category]

	SELECT *
	FROM #temp

	SELECT *
	FROM [Account]
	WHERE [ID] IN (SELECT [created_account_id] FROM #temp)

	SELECT *
	FROM [Account]
	WHERE [ID] IN (SELECT [modified_account_id] FROM #temp)

GO

CREATE PROCEDURE [dbo].[CategoryListByStatus]
	@status INT
AS

	/* Volume Technologies RADA Generator v6.1 */

	SELECT *
	INTO #temp
	FROM [Category]
	WHERE [status] = @status

	SELECT *
	FROM #temp

	SELECT *
	FROM [Account]
	WHERE [ID] IN (SELECT [created_account_id] FROM #temp)

	SELECT *
	FROM [Account]
	WHERE [ID] IN (SELECT [modified_account_id] FROM #temp)

GO

CREATE PROCEDURE [dbo].[CategoryUpdate]
	@ID INT,
	@name NVARCHAR(200),
	@description NVARCHAR(MAX),
	@image_name NVARCHAR(500),
	@status INT,
	@date_created DATETIME,
	@date_modified DATETIME,
	@created_account_id INT,
	@modified_account_id INT
AS

	/* Volume Technologies RADA Generator v6.1 */

	UPDATE [Category] SET
		[name] = @name,
		[description] = @description,
		[image_name] = @image_name,
		[status] = @status,
		[created_account_id] = @created_account_id,
		[modified_account_id] = @modified_account_id
	WHERE [ID] = @ID

GO

CREATE PROCEDURE [dbo].[CategoryDelete]
	@ID INT
AS

	/* Volume Technologies RADA Generator v6.1 */

	DELETE FROM [Category]
	WHERE [ID] = @ID

GO

CREATE PROCEDURE [dbo].[OrderInsert]
	@account_id INT,
	@date_created DATETIME,
	@status INT,
	@payment_method INT,
	@total_amount DECIMAL(0, 0)
AS

	/* Volume Technologies RADA Generator v6.1 */

	INSERT INTO [Order]
	(
		[account_id],
		[date_created],
		[status],
		[payment_method],
		[total_amount]
	)
	VALUES
	(
		@account_id,
		@date_created,
		@status,
		@payment_method,
		@total_amount
	)

	SELECT SCOPE_IDENTITY()

GO

CREATE PROCEDURE [dbo].[OrderGetByID]
	@ID INT
AS

	/* Volume Technologies RADA Generator v6.1 */

	SELECT *
	INTO #temp
	FROM [Order]
	WHERE [ID] = @ID

	SELECT *
	FROM #temp

	SELECT *
	FROM [Account]
	WHERE [ID] IN (SELECT [account_id] FROM #temp)

GO

CREATE PROCEDURE [dbo].[OrderList]
	
AS

	/* Volume Technologies RADA Generator v6.1 */

	SELECT *
	INTO #temp
	FROM [Order]

	SELECT *
	FROM #temp

	SELECT *
	FROM [Account]
	WHERE [ID] IN (SELECT [account_id] FROM #temp)

GO

CREATE PROCEDURE [dbo].[OrderListByAccountID]
	@account_id INT
AS

	/* Volume Technologies RADA Generator v6.1 */

	SELECT *
	INTO #temp
	FROM [Order]
	WHERE [account_id] = @account_id

	SELECT *
	FROM #temp

	SELECT *
	FROM [Account]
	WHERE [ID] IN (SELECT [account_id] FROM #temp)

GO

CREATE PROCEDURE [dbo].[OrderListByStatus]
	@status INT
AS

	/* Volume Technologies RADA Generator v6.1 */

	SELECT *
	INTO #temp
	FROM [Order]
	WHERE [status] = @status

	SELECT *
	FROM #temp

	SELECT *
	FROM [Account]
	WHERE [ID] IN (SELECT [account_id] FROM #temp)

GO

CREATE PROCEDURE [dbo].[OrderUpdate]
	@ID INT,
	@account_id INT,
	@date_created DATETIME,
	@status INT,
	@payment_method INT,
	@total_amount DECIMAL(0, 0)
AS

	/* Volume Technologies RADA Generator v6.1 */

	UPDATE [Order] SET
		[account_id] = @account_id,
		[status] = @status,
		[payment_method] = @payment_method,
		[total_amount] = @total_amount
	WHERE [ID] = @ID

GO

CREATE PROCEDURE [dbo].[OrderDelete]
	@ID INT
AS

	/* Volume Technologies RADA Generator v6.1 */

	DELETE FROM [Order]
	WHERE [ID] = @ID

GO

CREATE PROCEDURE [dbo].[OrderItemInsert]
	@order_id INT,
	@product_id INT,
	@quantity INT,
	@unit_cost DECIMAL(0, 0),
	@subtotal DECIMAL(0, 0)
AS

	/* Volume Technologies RADA Generator v6.1 */

	INSERT INTO [OrderItem]
	(
		[order_id],
		[product_id],
		[quantity],
		[unit_cost],
		[subtotal]
	)
	VALUES
	(
		@order_id,
		@product_id,
		@quantity,
		@unit_cost,
		@subtotal
	)

	SELECT SCOPE_IDENTITY()

GO

CREATE PROCEDURE [dbo].[OrderItemGetByID]
	@ID INT
AS

	/* Volume Technologies RADA Generator v6.1 */

	SELECT *
	INTO #temp
	FROM [OrderItem]
	WHERE [ID] = @ID

	SELECT *
	FROM #temp

	SELECT *
	FROM [Order]
	WHERE [ID] IN (SELECT [order_id] FROM #temp)

	SELECT *
	FROM [Product]
	WHERE [ID] IN (SELECT [product_id] FROM #temp)

GO

CREATE PROCEDURE [dbo].[OrderItemList]
	
AS

	/* Volume Technologies RADA Generator v6.1 */

	SELECT *
	INTO #temp
	FROM [OrderItem]

	SELECT *
	FROM #temp

	SELECT *
	FROM [Order]
	WHERE [ID] IN (SELECT [order_id] FROM #temp)

	SELECT *
	FROM [Product]
	WHERE [ID] IN (SELECT [product_id] FROM #temp)

GO

CREATE PROCEDURE [dbo].[OrderItemListByOrderID]
	@order_id INT
AS

	/* Volume Technologies RADA Generator v6.1 */

	SELECT *
	INTO #temp
	FROM [OrderItem]
	WHERE [order_id] = @order_id

	SELECT *
	FROM #temp

	SELECT *
	FROM [Order]
	WHERE [ID] IN (SELECT [order_id] FROM #temp)

	SELECT *
	FROM [Product]
	WHERE [ID] IN (SELECT [product_id] FROM #temp)

GO

CREATE PROCEDURE [dbo].[OrderItemUpdate]
	@ID INT,
	@order_id INT,
	@product_id INT,
	@quantity INT,
	@unit_cost DECIMAL(0, 0),
	@subtotal DECIMAL(0, 0)
AS

	/* Volume Technologies RADA Generator v6.1 */

	UPDATE [OrderItem] SET
		[order_id] = @order_id,
		[product_id] = @product_id,
		[quantity] = @quantity,
		[unit_cost] = @unit_cost,
		[subtotal] = @subtotal
	WHERE [ID] = @ID

GO

CREATE PROCEDURE [dbo].[OrderItemDelete]
	@ID INT
AS

	/* Volume Technologies RADA Generator v6.1 */

	DELETE FROM [OrderItem]
	WHERE [ID] = @ID

GO

CREATE PROCEDURE [dbo].[ProductInsert]
	@category_id INT,
	@name NVARCHAR(200),
	@description NVARCHAR(MAX),
	@price DECIMAL(0, 0),
	@image_name NVARCHAR(500),
	@status INT,
	@date_created DATETIME,
	@date_modified DATETIME,
	@created_account_id INT,
	@modified_account_id INT
AS

	/* Volume Technologies RADA Generator v6.1 */

	INSERT INTO [Product]
	(
		[category_id],
		[name],
		[description],
		[price],
		[image_name],
		[status],
		[date_created],
		[date_modified],
		[created_account_id],
		[modified_account_id]
	)
	VALUES
	(
		@category_id,
		@name,
		@description,
		@price,
		@image_name,
		@status,
		@date_created,
		@date_modified,
		@created_account_id,
		@modified_account_id
	)

	SELECT SCOPE_IDENTITY()

GO

CREATE PROCEDURE [dbo].[ProductGetByID]
	@ID INT
AS

	/* Volume Technologies RADA Generator v6.1 */

	SELECT *
	INTO #temp
	FROM [Product]
	WHERE [ID] = @ID

	SELECT *
	FROM #temp

	SELECT *
	FROM [Category]
	WHERE [ID] IN (SELECT [category_id] FROM #temp)

	SELECT *
	FROM [Account]
	WHERE [ID] IN (SELECT [created_account_id] FROM #temp)

	SELECT *
	FROM [Account]
	WHERE [ID] IN (SELECT [modified_account_id] FROM #temp)

GO

CREATE PROCEDURE [dbo].[ProductList]
	
AS

	/* Volume Technologies RADA Generator v6.1 */

	SELECT *
	INTO #temp
	FROM [Product]

	SELECT *
	FROM #temp

	SELECT *
	FROM [Category]
	WHERE [ID] IN (SELECT [category_id] FROM #temp)

	SELECT *
	FROM [Account]
	WHERE [ID] IN (SELECT [created_account_id] FROM #temp)

	SELECT *
	FROM [Account]
	WHERE [ID] IN (SELECT [modified_account_id] FROM #temp)

GO

CREATE PROCEDURE [dbo].[ProductListByStatus]
	@status INT
AS

	/* Volume Technologies RADA Generator v6.1 */

	SELECT *
	INTO #temp
	FROM [Product]
	WHERE [status] = @status

	SELECT *
	FROM #temp

	SELECT *
	FROM [Category]
	WHERE [ID] IN (SELECT [category_id] FROM #temp)

	SELECT *
	FROM [Account]
	WHERE [ID] IN (SELECT [created_account_id] FROM #temp)

	SELECT *
	FROM [Account]
	WHERE [ID] IN (SELECT [modified_account_id] FROM #temp)

GO

CREATE PROCEDURE [dbo].[ProductUpdate]
	@ID INT,
	@category_id INT,
	@name NVARCHAR(200),
	@description NVARCHAR(MAX),
	@price DECIMAL(0, 0),
	@image_name NVARCHAR(500),
	@status INT,
	@date_created DATETIME,
	@date_modified DATETIME,
	@created_account_id INT,
	@modified_account_id INT
AS

	/* Volume Technologies RADA Generator v6.1 */

	UPDATE [Product] SET
		[category_id] = @category_id,
		[name] = @name,
		[description] = @description,
		[price] = @price,
		[image_name] = @image_name,
		[status] = @status,
		[created_account_id] = @created_account_id,
		[modified_account_id] = @modified_account_id
	WHERE [ID] = @ID

GO

CREATE PROCEDURE [dbo].[ProductDelete]
	@ID INT
AS

	/* Volume Technologies RADA Generator v6.1 */

	DELETE FROM [Product]
	WHERE [ID] = @ID

GO

CREATE PROCEDURE [dbo].[ShippingInfoInsert]
	@order_id INT,
	@type INT,
	@cost DECIMAL(0, 0),
	@address NVARCHAR(250)
AS

	/* Volume Technologies RADA Generator v6.1 */

	INSERT INTO [ShippingInfo]
	(
		[order_id],
		[type],
		[cost],
		[address]
	)
	VALUES
	(
		@order_id,
		@type,
		@cost,
		@address
	)

	SELECT SCOPE_IDENTITY()

GO

CREATE PROCEDURE [dbo].[ShippingInfoGetByID]
	@ID INT
AS

	/* Volume Technologies RADA Generator v6.1 */

	SELECT *
	INTO #temp
	FROM [ShippingInfo]
	WHERE [ID] = @ID

	SELECT *
	FROM #temp

	SELECT *
	FROM [Order]
	WHERE [ID] IN (SELECT [order_id] FROM #temp)

GO

CREATE PROCEDURE [dbo].[ShippingInfoList]
	
AS

	/* Volume Technologies RADA Generator v6.1 */

	SELECT *
	INTO #temp
	FROM [ShippingInfo]

	SELECT *
	FROM #temp

	SELECT *
	FROM [Order]
	WHERE [ID] IN (SELECT [order_id] FROM #temp)

GO

CREATE PROCEDURE [dbo].[ShippingInfoListByType]
	@type INT
AS

	/* Volume Technologies RADA Generator v6.1 */

	SELECT *
	INTO #temp
	FROM [ShippingInfo]
	WHERE [type] = @type

	SELECT *
	FROM #temp

	SELECT *
	FROM [Order]
	WHERE [ID] IN (SELECT [order_id] FROM #temp)

GO

CREATE PROCEDURE [dbo].[ShippingInfoUpdate]
	@ID INT,
	@order_id INT,
	@type INT,
	@cost DECIMAL(0, 0),
	@address NVARCHAR(250)
AS

	/* Volume Technologies RADA Generator v6.1 */

	UPDATE [ShippingInfo] SET
		[order_id] = @order_id,
		[type] = @type,
		[cost] = @cost,
		[address] = @address
	WHERE [ID] = @ID

GO

CREATE PROCEDURE [dbo].[ShippingInfoDelete]
	@ID INT
AS

	/* Volume Technologies RADA Generator v6.1 */

	DELETE FROM [ShippingInfo]
	WHERE [ID] = @ID

GO

