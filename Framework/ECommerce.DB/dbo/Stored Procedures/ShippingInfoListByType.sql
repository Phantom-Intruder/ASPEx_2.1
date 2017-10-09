
CREATE PROCEDURE [dbo].[ShippingInfoListByType]
	@type INT
AS

	/* Volume Technologies RADA Generator v6.1 */

	SELECT *
	INTO #temp
	FROM [ShippingInfo]
	WHERE [type] = @type

	SELECT *
	FROM #temp

	SELECT *
	FROM [Order]
	WHERE [ID] IN (SELECT [order_id] FROM #temp)