
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