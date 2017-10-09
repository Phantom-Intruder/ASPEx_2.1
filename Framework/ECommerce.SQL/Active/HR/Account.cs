/*----------------------------------------------------------------------------------------
* Page   : Account
* File   : Account.cs
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


namespace ECommerce.SQL.Active.HR
{
	/// <summary>
	/// This class is used to directly access (via Stored Procedures) the table Account
	/// </summary>

	public class Account
	{

		#region Basic Generated Stored Procedure Access Functions

		/// <summary>
		/// Accesses the stored procedure in the database AccountList to list all the records from Account and the related records from primary Tables
		/// </summary>
		/// <returns>A DataSet object, or possibly null. The DataSet returned is a collection of Tables 1) Account 2)Account 3)Account</returns>
		// V2Generator: Section Start : List
		public static DataSet AccountList ()
		{
			// V2Generator: Body Start
			return SqlData.getSelectDataSet(SqlData.MASTER,"AccountList");
			// V2Generator: Body End
		}
		// V2Generator: Section End :List
















		/// <summary>
		/// Accesses the stored procedure in the database AccountGetByID to obtain a record from Account
		/// </summary>
		/// <param name="ID">No information available for ID</param>
		/// <returns>A DataSet object, or possibly null. The DataSet returned is a collection of Tables 1) Account 2)Account 3)Account</returns>
		// V2Generator: Section Start : Get By ID
		public static DataSet AccountGetByID (int ID)
		{
			// V2Generator: Body Start
			SqlParameter[] param			=
				{
					new SqlParameter("@ID", SqlDbType.Int)
				};

			param[0].Value					= ID;

			return SqlData.getSelectDataSet(SqlData.MASTER,"AccountGetByID", param);
			// V2Generator: Body End
		}
		// V2Generator: Section End :Get By ID

		public static DataSet AccountGetByEmail(string email)
		{
			SqlParameter[] param            =
				{
					new SqlParameter("@email", SqlDbType.NVarChar, 250)
				};

			param[0].Value                  = email;

			return SqlData.getSelectDataSet(SqlData.MASTER, "AccountGetByEmail", param);
		}

		/// <summary>
		/// Deletes a single record from Account by selecting it by it's identifier
		/// </summary>
		/// <param name="ID">No information available for ID</param>
		/// <returns>Accesses the stored procedure in the database AccountDelete to delete a record from Account</returns>
		// V2Generator: Section Start : Delete
		public static void AccountDelete (int ID)
		{
			// V2Generator: Body Start
			SqlParameter[] param			=
				{
					new SqlParameter("@ID", SqlDbType.Int)
				};

			param[0].Value					= ID;

			SqlData.getSelectDataTable(SqlData.MASTER,"AccountDelete", param);
			// V2Generator: Body End
		}
		// V2Generator: Section End :Delete

		/// <summary>
		/// Accesses the stored procedure in the database AccountInsert to insert a record into Account
		/// </summary>
		/// <param name="FirstName">No information available for FirstName</param>
		/// <param name="LastName">No information available for LastName</param>
		/// <param name="Email">No information available for Email</param>
		/// <param name="Password">No information available for Password</param>
		/// <param name="Salt">No information available for Salt</param>
		/// <param name="ContactNo">No information available for ContactNo</param>
		/// <param name="ShippingAddress">No information available for ShippingAddress</param>
		/// <param name="Country">No information available for Country</param>
		/// <param name="Status">No information available for Status</param>
		/// <param name="Role">No information available for Role</param>
		/// <param name="DateCreated">No information available for DateCreated</param>
		/// <param name="DateModified">No information available for DateModified</param>
		/// <param name="CreatedAccountID">No information available for CreatedAccountID</param>
		/// <param name="ModifiedAccountID">No information available for ModifiedAccountID</param>
		/// <returns>An integer id or -1</returns>
		// V2Generator: Section Start : Insert
		public static int AccountInsert (
			string FirstName,
			string LastName,
			string Email,
			string Password,
			string Salt,
			string ContactNo,
			string ShippingAddress,
			string Country,
			int Status,
			int Role,
			DateTime DateCreated,
			DateTime DateModified,
			int CreatedAccountID,
			int ModifiedAccountID)
		{
			// V2Generator: Body Start
			SqlParameter[] param			=
				{
					new SqlParameter("@first_name", SqlDbType.NVarChar, 50) ,
					new SqlParameter("@last_name", SqlDbType.NVarChar, 50) ,
					new SqlParameter("@email", SqlDbType.NVarChar, 255) ,
					new SqlParameter("@password", SqlDbType.NVarChar, 50) ,
					new SqlParameter("@salt", SqlDbType.NVarChar, 50) ,
					new SqlParameter("@contact_no", SqlDbType.NVarChar, 30) ,
					new SqlParameter("@shipping_address", SqlDbType.NVarChar, 250) ,
					new SqlParameter("@country", SqlDbType.NVarChar, 50) ,
					new SqlParameter("@status", SqlDbType.Int) ,
					new SqlParameter("@role", SqlDbType.Int) ,
					new SqlParameter("@date_created", SqlDbType.DateTime) ,
					new SqlParameter("@date_modified", SqlDbType.DateTime) ,
					new SqlParameter("@created_account_id", SqlDbType.Int) ,
					new SqlParameter("@modified_account_id", SqlDbType.Int)
				};

			param[0].Value					= FirstName;
			param[1].Value					= LastName;
			param[2].Value					= Email;
			param[3].Value					= Password;
			param[4].Value					= Salt;
			param[5].Value					= ContactNo;
			param[6].Value					= ShippingAddress;
			param[7].Value					= Country;
			param[8].Value					= Status;
			param[9].Value					= Role;
			param[10].Value					= DateCreated;
			param[11].Value					= DateModified;
			param[12].Value					= CreatedAccountID;
			param[13].Value					= ModifiedAccountID;

			DataTable dt					= SqlData.getSelectDataTable(SqlData.MASTER,"AccountInsert",param);

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
		/// Accesses the stored procedure in the database AccountUpdate to update a record from Account
		/// </summary>
		/// <param name="ID">No information available for ID</param>
		/// <param name="FirstName">No information available for FirstName</param>
		/// <param name="LastName">No information available for LastName</param>
		/// <param name="Email">No information available for Email</param>
		/// <param name="Password">No information available for Password</param>
		/// <param name="Salt">No information available for Salt</param>
		/// <param name="ContactNo">No information available for ContactNo</param>
		/// <param name="ShippingAddress">No information available for ShippingAddress</param>
		/// <param name="Country">No information available for Country</param>
		/// <param name="Status">No information available for Status</param>
		/// <param name="Role">No information available for Role</param>
		/// <param name="DateCreated">No information available for DateCreated</param>
		/// <param name="DateModified">No information available for DateModified</param>
		/// <param name="CreatedAccountID">No information available for CreatedAccountID</param>
		/// <param name="ModifiedAccountID">No information available for ModifiedAccountID</param>
		/// <returns></returns>
		// V2Generator: Section Start : Update
		public static void AccountUpdate (
			int ID,
			string FirstName,
			string LastName,
			string Email,
			string Password,
			string Salt,
			string ContactNo,
			string ShippingAddress,
			string Country,
			int Status,
			int Role,
			DateTime DateCreated,
			DateTime DateModified,
			int CreatedAccountID,
			int ModifiedAccountID)
		{
			// V2Generator: Body Start
			SqlParameter[] param			=
				{
					new SqlParameter("@ID", SqlDbType.Int) ,
					new SqlParameter("@first_name", SqlDbType.NVarChar, 50) ,
					new SqlParameter("@last_name", SqlDbType.NVarChar, 50) ,
					new SqlParameter("@email", SqlDbType.NVarChar, 255) ,
					new SqlParameter("@password", SqlDbType.NVarChar, 50) ,
					new SqlParameter("@salt", SqlDbType.NVarChar, 50) ,
					new SqlParameter("@contact_no", SqlDbType.NVarChar, 30) ,
					new SqlParameter("@shipping_address", SqlDbType.NVarChar, 250) ,
					new SqlParameter("@country", SqlDbType.NVarChar, 50) ,
					new SqlParameter("@status", SqlDbType.Int) ,
					new SqlParameter("@role", SqlDbType.Int) ,
					new SqlParameter("@date_created", SqlDbType.DateTime) ,
					new SqlParameter("@date_modified", SqlDbType.DateTime) ,
					new SqlParameter("@created_account_id", SqlDbType.Int) ,
					new SqlParameter("@modified_account_id", SqlDbType.Int)
				};

			param[0].Value					= ID;
			param[1].Value					= FirstName;
			param[2].Value					= LastName;
			param[3].Value					= Email;
			param[4].Value					= Password;
			param[5].Value					= Salt;
			param[6].Value					= ContactNo;
			param[7].Value					= ShippingAddress;
			param[8].Value					= Country;
			param[9].Value					= Status;
			param[10].Value					= Role;
			param[11].Value					= DateCreated;
			param[12].Value					= DateModified;
			param[13].Value					= CreatedAccountID;
			param[14].Value					= ModifiedAccountID;

			SqlData.getSelectDataTable(SqlData.MASTER,"AccountUpdate", param);
			// V2Generator: Body End
		}
		// V2Generator: Section End :Update

		#endregion

	}
}
