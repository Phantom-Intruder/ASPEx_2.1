
CREATE PROCEDURE [dbo].[AccountGetByEmail]
	@email NVARCHAR(255)
AS

	SELECT *
	INTO #temp
	FROM [Account]
	WHERE [email] = @email

	SELECT *
	FROM #temp

	SELECT *
	FROM [Account]
	WHERE [ID] IN (SELECT [created_account_id] FROM #temp)

	SELECT *
	FROM [Account]
	WHERE [ID] IN (SELECT [modified_account_id] FROM #temp)