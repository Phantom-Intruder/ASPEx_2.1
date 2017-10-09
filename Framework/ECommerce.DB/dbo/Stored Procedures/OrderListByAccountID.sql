
CREATE PROCEDURE [dbo].[OrderListByAccountID]
	@account_id INT
AS

	/* Volume Technologies RADA Generator v6.1 */

	SELECT *
	INTO #temp
	FROM [Order]
	WHERE [account_id] = @account_id

	SELECT *
	FROM #temp

	SELECT *
	FROM [Account]
	WHERE [ID] IN (SELECT [account_id] FROM #temp)