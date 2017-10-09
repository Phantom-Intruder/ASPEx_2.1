
CREATE PROCEDURE [dbo].[ShippingInfoDelete]
	@ID INT
AS

	/* Volume Technologies RADA Generator v6.1 */

	DELETE FROM [ShippingInfo]
	WHERE [ID] = @ID