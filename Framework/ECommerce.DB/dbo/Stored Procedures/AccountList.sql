
CREATE PROCEDURE [dbo].[AccountList]
	
AS

	/* Volume Technologies RADA Generator v6.1 */

	SELECT *
	INTO #temp
	FROM [Account]

	SELECT *
	FROM #temp

	SELECT *
	FROM [Account]
	WHERE [ID] IN (SELECT [created_account_id] FROM #temp)

	SELECT *
	FROM [Account]
	WHERE [ID] IN (SELECT [modified_account_id] FROM #temp)