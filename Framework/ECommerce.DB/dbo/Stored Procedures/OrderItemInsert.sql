
CREATE PROCEDURE [dbo].[OrderItemInsert]
	@order_id INT,
	@product_id INT,
	@quantity INT,
	@unit_cost DECIMAL(18, 2),
	@subtotal DECIMAL(18, 2)
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