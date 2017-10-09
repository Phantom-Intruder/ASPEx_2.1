
CREATE PROCEDURE [dbo].[OrderGetByID]
	@ID INT
AS

	/* Volume Technologies RADA Generator v6.1 */

	SELECT *
	INTO #temp
	FROM [Order]
	WHERE [ID] = @ID

	SELECT *
	FROM #temp

	SELECT *
	FROM [Account]
	WHERE [ID] IN (SELECT [account_id] FROM #temp)