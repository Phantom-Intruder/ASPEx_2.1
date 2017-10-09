
CREATE PROCEDURE [dbo].[ShippingInfoUpdate]
	@ID INT,
	@order_id INT,
	@type INT,
	@cost DECIMAL(18, 2),
	@address NVARCHAR(250)
AS

	/* Volume Technologies RADA Generator v6.1 */

	UPDATE [ShippingInfo] SET
		[order_id] = @order_id,
		[type] = @type,
		[cost] = @cost,
		[address] = @address
	WHERE [ID] = @ID