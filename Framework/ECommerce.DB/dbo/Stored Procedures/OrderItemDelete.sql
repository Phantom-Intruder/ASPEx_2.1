
CREATE PROCEDURE [dbo].[OrderItemDelete]
	@ID INT
AS

	/* Volume Technologies RADA Generator v6.1 */

	DELETE FROM [OrderItem]
	WHERE [ID] = @ID