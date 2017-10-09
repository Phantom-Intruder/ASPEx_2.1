/*----------------------------------------------------------------------------------------
* Page   : ShippingInfo
* File   : ShippingInfo.cs
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
	/// This class is used to directly access (via Stored Procedures) the table ShippingInfo
	/// </summary>

	public class ShippingInfo
	{

		#region Basic Generated Stored Procedure Access Functions

		/// <summary>
		/// Accesses the stored procedure in the database ShippingInfoList to list all the records from ShippingInfo and the related records from primary Tables
		/// </summary>
		/// <returns>A DataSet object, or possibly null. The DataSet returned is a collection of Tables 1) ShippingInfo 2)Order</returns>
		// V2Generator: Section Start : List
		public static DataSet ShippingInfoList ()
		{
			// V2Generator: Body Start
			return SqlData.getSelectDataSet(SqlData.MASTER,"ShippingInfoList");
			// V2Generator: Body End
		}
		// V2Generator: Section End :List



		/// <summary>
		/// Accesses the stored procedure in the database ShippingInfoListByType to list all the records from ShippingInfo and the related records from primary Tables
		/// </summary>
		/// <param name="Type"></param>
		/// <returns>A DataSet object, or possibly null. The DataSet returned is a collection of Tables 1) ShippingInfo 2)Order</returns>
		// V2Generator: Section Start : ListByType
		public static DataSet ShippingInfoListByType (int Type)
		{
			// V2Generator: Body Start
			SqlParameter[] param			=
				{
					new SqlParameter("@type", SqlDbType.Int)
				};

			param[0].Value					= Type;

			return SqlData.getSelectDataSet(SqlData.MASTER,"ShippingInfoListByType", param);
			// V2Generator: Body End
		}
		// V2Generator: Section End :ListByType



		/// <summary>
		/// Accesses the stored procedure in the database ShippingInfoGetByID to obtain a record from ShippingInfo
		/// </summary>
		/// <param name="ID">No information available for ID</param>
		/// <returns>A DataSet object, or possibly null. The DataSet returned is a collection of Tables 1) ShippingInfo 2)Order</returns>
		// V2Generator: Section Start : Get By ID
		public static DataSet ShippingInfoGetByID (int ID)
		{
			// V2Generator: Body Start
			SqlParameter[] param			=
				{
					new SqlParameter("@ID", SqlDbType.Int)
				};

			param[0].Value					= ID;

			return SqlData.getSelectDataSet(SqlData.MASTER,"ShippingInfoGetByID", param);
			// V2Generator: Body End
		}
		// V2Generator: Section End :Get By ID

		/// <summary>
		/// Deletes a single record from ShippingInfo by selecting it by it's identifier
		/// </summary>
		/// <param name="ID">No information available for ID</param>
		/// <returns>Accesses the stored procedure in the database ShippingInfoDelete to delete a record from ShippingInfo</returns>
		// V2Generator: Section Start : Delete
		public static void ShippingInfoDelete (int ID)
		{
			// V2Generator: Body Start
			SqlParameter[] param			=
				{
					new SqlParameter("@ID", SqlDbType.Int)
				};

			param[0].Value					= ID;

			SqlData.getSelectDataTable(SqlData.MASTER,"ShippingInfoDelete", param);
			// V2Generator: Body End
		}
		// V2Generator: Section End :Delete

		/// <summary>
		/// Accesses the stored procedure in the database ShippingInfoInsert to insert a record into ShippingInfo
		/// </summary>
		/// <param name="OrderID">No information available for OrderID</param>
		/// <param name="Type">No information available for Type</param>
		/// <param name="Cost">No information available for Cost</param>
		/// <param name="Address">No information available for Address</param>
		/// <returns>An integer id or -1</returns>
		// V2Generator: Section Start : Insert
		public static int ShippingInfoInsert (
			int OrderID,
			int Type,
			decimal Cost,
			string Address)
		{
			// V2Generator: Body Start
			SqlParameter[] param			=
				{
					new SqlParameter("@order_id", SqlDbType.Int) ,
					new SqlParameter("@type", SqlDbType.Int) ,
					new SqlParameter("@cost", SqlDbType.Decimal) ,
					new SqlParameter("@address", SqlDbType.NVarChar, 250)
				};

			param[0].Value					= OrderID;
			param[1].Value					= Type;
			param[2].Value					= Cost;
			param[3].Value					= Address;

			DataTable dt					= SqlData.getSelectDataTable(SqlData.MASTER,"ShippingInfoInsert",param);

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
		/// Accesses the stored procedure in the database ShippingInfoUpdate to update a record from ShippingInfo
		/// </summary>
		/// <param name="ID">No information available for ID</param>
		/// <param name="OrderID">No information available for OrderID</param>
		/// <param name="Type">No information available for Type</param>
		/// <param name="Cost">No information available for Cost</param>
		/// <param name="Address">No information available for Address</param>
		/// <returns></returns>
		// V2Generator: Section Start : Update
		public static void ShippingInfoUpdate (
			int ID,
			int OrderID,
			int Type,
			decimal Cost,
			string Address)
		{
			// V2Generator: Body Start
			SqlParameter[] param			=
				{
					new SqlParameter("@ID", SqlDbType.Int) ,
					new SqlParameter("@order_id", SqlDbType.Int) ,
					new SqlParameter("@type", SqlDbType.Int) ,
					new SqlParameter("@cost", SqlDbType.Decimal) ,
					new SqlParameter("@address", SqlDbType.NVarChar, 250)
				};

			param[0].Value					= ID;
			param[1].Value					= OrderID;
			param[2].Value					= Type;
			param[3].Value					= Cost;
			param[4].Value					= Address;

			SqlData.getSelectDataTable(SqlData.MASTER,"ShippingInfoUpdate", param);
			// V2Generator: Body End
		}
		// V2Generator: Section End :Update

		#endregion

	}
}
