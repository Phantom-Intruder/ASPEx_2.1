
CREATE PROCEDURE [dbo].[OrderItemUpdate]
	@ID INT,
	@order_id INT,
	@product_id INT,
	@quantity INT,
	@unit_cost DECIMAL(18, 2),
	@subtotal DECIMAL(18, 2)
AS

	/* Volume Technologies RADA Generator v6.1 */

	UPDATE [OrderItem] SET
		[order_id] = @order_id,
		[product_id] = @product_id,
		[quantity] = @quantity,
		[unit_cost] = @unit_cost,
		[subtotal] = @subtotal
	WHERE [ID] = @ID