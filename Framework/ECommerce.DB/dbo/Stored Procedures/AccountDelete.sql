
CREATE PROCEDURE [dbo].[AccountDelete]
	@ID INT
AS

	/* Volume Technologies RADA Generator v6.1 */

	DELETE FROM [Account]
	WHERE [ID] = @ID