
CREATE PROCEDURE [dbo].[ProductList]
	
AS

	/* Volume Technologies RADA Generator v6.1 */

	SELECT *
	INTO #temp
	FROM [Product]

	SELECT *
	FROM #temp

	SELECT *
	FROM [Category]
	WHERE [ID] IN (SELECT [category_id] FROM #temp)

	SELECT *
	FROM [Account]
	WHERE [ID] IN (SELECT [created_account_id] FROM #temp)

	SELECT *
	FROM [Account]
	WHERE [ID] IN (SELECT [modified_account_id] FROM #temp)