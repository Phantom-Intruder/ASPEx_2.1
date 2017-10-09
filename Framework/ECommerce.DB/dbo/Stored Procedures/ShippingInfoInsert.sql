
CREATE PROCEDURE [dbo].[ShippingInfoInsert]
	@order_id INT,
	@type INT,
	@cost DECIMAL(18, 2),
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