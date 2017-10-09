/*----------------------------------------------------------------------------------------
* Page   : Order
* File   : Order.cs
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
	/// This class is used to directly access (via Stored Procedures) the table Order
	/// </summary>

	public class Order
	{

		#region Basic Generated Stored Procedure Access Functions

		/// <summary>
		/// Accesses the stored procedure in the database OrderList to list all the records from Order and the related records from primary Tables
		/// </summary>
		/// <returns>A DataSet object, or possibly null. The DataSet returned is a collection of Tables 1) Order 2)Account</returns>
		// V2Generator: Section Start : List
		public static DataSet OrderList ()
		{
			// V2Generator: Body Start
			return SqlData.getSelectDataSet(SqlData.MASTER,"OrderList");
			// V2Generator: Body End
		}
		// V2Generator: Section End :List


		/// <summary>
		/// Accesses the stored procedure in the database OrderListByAccountID to list all the records from Order and the related records from primary Tables
		/// </summary>
		/// <param name="AccountID"></param>
		/// <returns>A DataSet object, or possibly null. The DataSet returned is a collection of Tables 1) Order 2)Account</returns>
		// V2Generator: Section Start : ListByAccountID
		public static DataSet OrderListByAccountID (int AccountID)
		{
			// V2Generator: Body Start
			SqlParameter[] param			=
				{
					new SqlParameter("@account_id", SqlDbType.Int)
				};

			param[0].Value					= AccountID;

			return SqlData.getSelectDataSet(SqlData.MASTER,"OrderListByAccountID", param);
			// V2Generator: Body End
		}
		// V2Generator: Section End :ListByAccountID


		/// <summary>
		/// Accesses the stored procedure in the database OrderListByStatus to list all the records from Order and the related records from primary Tables
		/// </summary>
		/// <param name="Status"></param>
		/// <returns>A DataSet object, or possibly null. The DataSet returned is a collection of Tables 1) Order 2)Account</returns>
		// V2Generator: Section Start : ListByStatus
		public static DataSet OrderListByStatus (int Status)
		{
			// V2Generator: Body Start
			SqlParameter[] param			=
				{
					new SqlParameter("@status", SqlDbType.Int)
				};

			param[0].Value					= Status;

			return SqlData.getSelectDataSet(SqlData.MASTER,"OrderListByStatus", param);
			// V2Generator: Body End
		}
		// V2Generator: Section End :ListByStatus



		/// <summary>
		/// Accesses the stored procedure in the database OrderGetByID to obtain a record from Order
		/// </summary>
		/// <param name="ID">No information available for ID</param>
		/// <returns>A DataSet object, or possibly null. The DataSet returned is a collection of Tables 1) Order 2)Account</returns>
		// V2Generator: Section Start : Get By ID
		public static DataSet OrderGetByID (int ID)
		{
			// V2Generator: Body Start
			SqlParameter[] param			=
				{
					new SqlParameter("@ID", SqlDbType.Int)
				};

			param[0].Value					= ID;

			return SqlData.getSelectDataSet(SqlData.MASTER,"OrderGetByID", param);
			// V2Generator: Body End
		}
		// V2Generator: Section End :Get By ID

		/// <summary>
		/// Deletes a single record from Order by selecting it by it's identifier
		/// </summary>
		/// <param name="ID">No information available for ID</param>
		/// <returns>Accesses the stored procedure in the database OrderDelete to delete a record from Order</returns>
		// V2Generator: Section Start : Delete
		public static void OrderDelete (int ID)
		{
			// V2Generator: Body Start
			SqlParameter[] param			=
				{
					new SqlParameter("@ID", SqlDbType.Int)
				};

			param[0].Value					= ID;

			SqlData.getSelectDataTable(SqlData.MASTER,"OrderDelete", param);
			// V2Generator: Body End
		}
		// V2Generator: Section End :Delete

		/// <summary>
		/// Accesses the stored procedure in the database OrderInsert to insert a record into Order
		/// </summary>
		/// <param name="AccountID">No information available for AccountID</param>
		/// <param name="DateCreated">No information available for DateCreated</param>
		/// <param name="Status">No information available for Status</param>
		/// <param name="PaymentMethod">No information available for PaymentMethod</param>
		/// <param name="TotalAmount">No information available for TotalAmount</param>
		/// <returns>An integer id or -1</returns>
		// V2Generator: Section Start : Insert
		public static int OrderInsert (
			int AccountID,
			DateTime DateCreated,
			int Status,
			int PaymentMethod,
			decimal TotalAmount)
		{
			// V2Generator: Body Start
			SqlParameter[] param			=
				{
					new SqlParameter("@account_id", SqlDbType.Int) ,
					new SqlParameter("@date_created", SqlDbType.DateTime) ,
					new SqlParameter("@status", SqlDbType.Int) ,
					new SqlParameter("@payment_method", SqlDbType.Int) ,
					new SqlParameter("@total_amount", SqlDbType.Decimal)
				};

			param[0].Value					= AccountID;
			param[1].Value					= DateCreated;
			param[2].Value					= Status;
			param[3].Value					= PaymentMethod;
			param[4].Value					= TotalAmount;

			DataTable dt					= SqlData.getSelectDataTable(SqlData.MASTER,"OrderInsert",param);

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
		/// Accesses the stored procedure in the database OrderUpdate to update a record from Order
		/// </summary>
		/// <param name="ID">No information available for ID</param>
		/// <param name="AccountID">No information available for AccountID</param>
		/// <param name="DateCreated">No information available for DateCreated</param>
		/// <param name="Status">No information available for Status</param>
		/// <param name="PaymentMethod">No information available for PaymentMethod</param>
		/// <param name="TotalAmount">No information available for TotalAmount</param>
		/// <returns></returns>
		// V2Generator: Section Start : Update
		public static void OrderUpdate (
			int ID,
			int AccountID,
			DateTime DateCreated,
			int Status,
			int PaymentMethod,
			decimal TotalAmount)
		{
			// V2Generator: Body Start
			SqlParameter[] param			=
				{
					new SqlParameter("@ID", SqlDbType.Int) ,
					new SqlParameter("@account_id", SqlDbType.Int) ,
					new SqlParameter("@date_created", SqlDbType.DateTime) ,
					new SqlParameter("@status", SqlDbType.Int) ,
					new SqlParameter("@payment_method", SqlDbType.Int) ,
					new SqlParameter("@total_amount", SqlDbType.Decimal)
				};

			param[0].Value					= ID;
			param[1].Value					= AccountID;
			param[2].Value					= DateCreated;
			param[3].Value					= Status;
			param[4].Value					= PaymentMethod;
			param[5].Value					= TotalAmount;

			SqlData.getSelectDataTable(SqlData.MASTER,"OrderUpdate", param);
			// V2Generator: Body End
		}
		// V2Generator: Section End :Update

		#endregion

	}
}
