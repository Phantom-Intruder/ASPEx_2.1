
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