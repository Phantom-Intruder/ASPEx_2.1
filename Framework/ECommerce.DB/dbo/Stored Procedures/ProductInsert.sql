
CREATE PROCEDURE [dbo].[ProductInsert]
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