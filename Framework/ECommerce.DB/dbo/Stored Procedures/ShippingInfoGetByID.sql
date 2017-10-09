
CREATE PROCEDURE [dbo].[ShippingInfoGetByID]
	@ID INT
AS

	/* Volume Technologies RADA Generator v6.1 */

	SELECT *
	INTO #temp
	FROM [ShippingInfo]
	WHERE [ID] = @ID

	SELECT *
	FROM #temp

	SELECT *
	FROM [Order]
	WHERE [ID] IN (SELECT [order_id] FROM #temp)