
CREATE PROCEDURE [dbo].[OrderDelete]
	@ID INT
AS

	/* Volume Technologies RADA Generator v6.1 */

	DELETE FROM [Order]
	WHERE [ID] = @ID