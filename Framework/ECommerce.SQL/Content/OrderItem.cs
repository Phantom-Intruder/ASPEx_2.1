/*----------------------------------------------------------------------------------------
* Page   : OrderItem
* File   : OrderItem.cs
* Author : Volume RADA Generator (Version 6.1)
* Date   : 2017-08-23
* Comment: Created by Author
* --------------------------------------------------------------------------------------*/

/*---------------------------------Version Control---------------------------------------
 *
 * DATE						 WHO                ACTION
 * 2017-08-23  Volume RADA Generator (Version 6.1)	Created
 *
 *-------------------------------End Version Control-------------------------------------*/

using System;
using System.Collections;
using System.Data;
using System.Data.SqlClient;


namespace ECommerce.SQL.Content
{
	/// <summary>
	/// This class is used to directly access (via Stored Procedures) the table OrderItem
	/// </summary>

	public class OrderItem
	{

		#region Basic Generated Stored Procedure Access Functions

		/// <summary>
		/// Accesses the stored procedure in the database OrderItemList to list all the records from OrderItem and the related records from primary Tables
		/// </summary>
		/// <returns>A DataSet object, or possibly null. The DataSet returned is a collection of Tables 1) OrderItem 2)Order 3)Product</returns>
		// V2Generator: Section Start : List
		public static DataSet OrderItemList ()
		{
			// V2Generator: Body Start
			return SqlData.getSelectDataSet(SqlData.MASTER,"OrderItemList");
			// V2Generator: Body End
		}
		// V2Generator: Section End :List


		/// <summary>
		/// Accesses the stored procedure in the database OrderItemListByOrderID to list all the records from OrderItem and the related records from primary Tables
		/// </summary>
		/// <param name="OrderID"></param>
		/// <returns>A DataSet object, or possibly null. The DataSet returned is a collection of Tables 1) OrderItem 2)Order 3)Product</returns>
		// V2Generator: Section Start : ListByOrderID
		public static DataSet OrderItemListByOrderID (int OrderID)
		{
			// V2Generator: Body Start
			SqlParameter[] param			=
				{
					new SqlParameter("@order_id", SqlDbType.Int)
				};

			param[0].Value					= OrderID;

			return SqlData.getSelectDataSet(SqlData.MASTER,"OrderItemListByOrderID", param);
			// V2Generator: Body End
		}
		// V2Generator: Section End :ListByOrderID





		/// <summary>
		/// Accesses the stored procedure in the database OrderItemGetByID to obtain a record from OrderItem
		/// </summary>
		/// <param name="ID">No information available for ID</param>
		/// <returns>A DataSet object, or possibly null. The DataSet returned is a collection of Tables 1) OrderItem 2)Order 3)Product</returns>
		// V2Generator: Section Start : Get By ID
		public static DataSet OrderItemGetByID (int ID)
		{
			// V2Generator: Body Start
			SqlParameter[] param			=
				{
					new SqlParameter("@ID", SqlDbType.Int)
				};

			param[0].Value					= ID;

			return SqlData.getSelectDataSet(SqlData.MASTER,"OrderItemGetByID", param);
			// V2Generator: Body End
		}
		// V2Generator: Section End :Get By ID

		/// <summary>
		/// Deletes a single record from OrderItem by selecting it by it's identifier
		/// </summary>
		/// <param name="ID">No information available for ID</param>
		/// <returns>Accesses the stored procedure in the database OrderItemDelete to delete a record from OrderItem</returns>
		// V2Generator: Section Start : Delete
		public static void OrderItemDelete (int ID)
		{
			// V2Generator: Body Start
			SqlParameter[] param			=
				{
					new SqlParameter("@ID", SqlDbType.Int)
				};

			param[0].Value					= ID;

			SqlData.getSelectDataTable(SqlData.MASTER,"OrderItemDelete", param);
			// V2Generator: Body End
		}
		// V2Generator: Section End :Delete

		/// <summary>
		/// Accesses the stored procedure in the database OrderItemInsert to insert a record into OrderItem
		/// </summary>
		/// <param name="OrderID">No information available for OrderID</param>
		/// <param name="ProductID">No information available for ProductID</param>
		/// <param name="Quantity">No information available for Quantity</param>
		/// <param name="UnitCost">No information available for UnitCost</param>
		/// <param name="Subtotal">No information available for Subtotal</param>
		/// <returns>An integer id or -1</returns>
		// V2Generator: Section Start : Insert
		public static int OrderItemInsert (
			int OrderID,
			int ProductID,
			int Quantity,
			decimal UnitCost,
			decimal Subtotal)
		{
			// V2Generator: Body Start
			SqlParameter[] param			=
				{
					new SqlParameter("@order_id", SqlDbType.Int) ,
					new SqlParameter("@product_id", SqlDbType.Int) ,
					new SqlParameter("@quantity", SqlDbType.Int) ,
					new SqlParameter("@unit_cost", SqlDbType.Decimal) ,
					new SqlParameter("@subtotal", SqlDbType.Decimal)
				};

			param[0].Value					= OrderID;
			param[1].Value					= ProductID;
			param[2].Value					= Quantity;
			param[3].Value					= UnitCost;
			param[4].Value					= Subtotal;

			DataTable dt					= SqlData.getSelectDataTable(SqlData.MASTER,"OrderItemInsert",param);

			int rtn							= -1;
			if (dt != null)
			{
				if (dt.Rows.Count == 1)
				{
					rtn						= Convert.ToInt32(dt.Rows[0][0]);
				}
			}
			return rtn;
			// V2Generator: Body End
		}
		// V2Generator: Section End :Insert

		/// <summary>
		/// Accesses the stored procedure in the database OrderItemUpdate to update a record from OrderItem
		/// </summary>
		/// <param name="ID">No information available for ID</param>
		/// <param name="OrderID">No information available for OrderID</param>
		/// <param name="ProductID">No information available for ProductID</param>
		/// <param name="Quantity">No information available for Quantity</param>
		/// <param name="UnitCost">No information available for UnitCost</param>
		/// <param name="Subtotal">No information available for Subtotal</param>
		/// <returns></returns>
		// V2Generator: Section Start : Update
		public static void OrderItemUpdate (
			int ID,
			int OrderID,
			int ProductID,
			int Quantity,
			decimal UnitCost,
			decimal Subtotal)
		{
			// V2Generator: Body Start
			SqlParameter[] param			=
				{
					new SqlParameter("@ID", SqlDbType.Int) ,
					new SqlParameter("@order_id", SqlDbType.Int) ,
					new SqlParameter("@product_id", SqlDbType.Int) ,
					new SqlParameter("@quantity", SqlDbType.Int) ,
					new SqlParameter("@unit_cost", SqlDbType.Decimal) ,
					new SqlParameter("@subtotal", SqlDbType.Decimal)
				};

			param[0].Value					= ID;
			param[1].Value					= OrderID;
			param[2].Value					= ProductID;
			param[3].Value					= Quantity;
			param[4].Value					= UnitCost;
			param[5].Value					= Subtotal;

			SqlData.getSelectDataTable(SqlData.MASTER,"OrderItemUpdate", param);
			// V2Generator: Body End
		}
		// V2Generator: Section End :Update

		#endregion

	}
}
