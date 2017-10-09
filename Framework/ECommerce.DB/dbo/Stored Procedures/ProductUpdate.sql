
CREATE PROCEDURE [dbo].[ProductUpdate]
	@ID INT,
	@category_id INT,
	@name NVARCHAR(200),
	@description NVARCHAR(MAX),
	@price DECIMAL(18, 2),
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