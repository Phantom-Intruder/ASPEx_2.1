
CREATE PROCEDURE [dbo].[CategoryDelete]
	@ID INT
AS

	/* Volume Technologies RADA Generator v6.1 */

	DELETE FROM [Category]
	WHERE [ID] = @ID