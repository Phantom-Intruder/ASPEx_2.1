
CREATE PROCEDURE [dbo].[OrderInsert]
	@account_id INT,
	@date_created DATETIME,
	@status INT,
	@payment_method INT,
	@total_amount DECIMAL(18, 2)
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