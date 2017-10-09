
CREATE PROCEDURE [dbo].[ProductDelete]
	@ID INT
AS

	/* Volume Technologies RADA Generator v6.1 */

	DELETE FROM [Product]
	WHERE [ID] = @ID