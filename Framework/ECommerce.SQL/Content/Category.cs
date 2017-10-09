/*----------------------------------------------------------------------------------------
* Page   : Category
* File   : Category.cs
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
	/// This class is used to directly access (via Stored Procedures) the table Category
	/// </summary>

	public class Category
	{

		#region Basic Generated Stored Procedure Access Functions

		/// <summary>
		/// Accesses the stored procedure in the database CategoryList to list all the records from Category and the related records from primary Tables
		/// </summary>
		/// <returns>A DataSet object, or possibly null. The DataSet returned is a collection of Tables 1) Category 2)Account 3)Account</returns>
		// V2Generator: Section Start : List
		public static DataSet CategoryList ()
		{
			// V2Generator: Body Start
			return SqlData.getSelectDataSet(SqlData.MASTER,"CategoryList");
			// V2Generator: Body End
		}
		// V2Generator: Section End :List





		/// <summary>
		/// Accesses the stored procedure in the database CategoryListByStatus to list all the records from Category and the related records from primary Tables
		/// </summary>
		/// <param name="Status"></param>
		/// <returns>A DataSet object, or possibly null. The DataSet returned is a collection of Tables 1) Category 2)Account 3)Account</returns>
		// V2Generator: Section Start : ListByStatus
		public static DataSet CategoryListByStatus (int Status)
		{
			// V2Generator: Body Start
			SqlParameter[] param			=
				{
					new SqlParameter("@status", SqlDbType.Int)
				};

			param[0].Value					= Status;

			return SqlData.getSelectDataSet(SqlData.MASTER,"CategoryListByStatus", param);
			// V2Generator: Body End
		}
		// V2Generator: Section End :ListByStatus





		/// <summary>
		/// Accesses the stored procedure in the database CategoryGetByID to obtain a record from Category
		/// </summary>
		/// <param name="ID">No information available for ID</param>
		/// <returns>A DataSet object, or possibly null. The DataSet returned is a collection of Tables 1) Category 2)Account 3)Account</returns>
		// V2Generator: Section Start : Get By ID
		public static DataSet CategoryGetByID (int ID)
		{
			// V2Generator: Body Start
			SqlParameter[] param			=
				{
					new SqlParameter("@ID", SqlDbType.Int)
				};

			param[0].Value					= ID;

			return SqlData.getSelectDataSet(SqlData.MASTER,"CategoryGetByID", param);
			// V2Generator: Body End
		}
		// V2Generator: Section End :Get By ID

		/// <summary>
		/// Deletes a single record from Category by selecting it by it's identifier
		/// </summary>
		/// <param name="ID">No information available for ID</param>
		/// <returns>Accesses the stored procedure in the database CategoryDelete to delete a record from Category</returns>
		// V2Generator: Section Start : Delete
		public static void CategoryDelete (int ID)
		{
			// V2Generator: Body Start
			SqlParameter[] param			=
				{
					new SqlParameter("@ID", SqlDbType.Int)
				};

			param[0].Value					= ID;

			SqlData.getSelectDataTable(SqlData.MASTER,"CategoryDelete", param);
			// V2Generator: Body End
		}
		// V2Generator: Section End :Delete

		/// <summary>
		/// Accesses the stored procedure in the database CategoryInsert to insert a record into Category
		/// </summary>
		/// <param name="Name">No information available for Name</param>
		/// <param name="Description">No information available for Description</param>
		/// <param name="ImageName">No information available for ImageName</param>
		/// <param name="Status">No information available for Status</param>
		/// <param name="DateCreated">No information available for DateCreated</param>
		/// <param name="DateModified">No information available for DateModified</param>
		/// <param name="CreatedAccountID">No information available for CreatedAccountID</param>
		/// <param name="ModifiedAccountID">No information available for ModifiedAccountID</param>
		/// <returns>An integer id or -1</returns>
		// V2Generator: Section Start : Insert
		public static int CategoryInsert (
			string Name,
			string Description,
			string ImageName,
			int Status,
			DateTime DateCreated,
			DateTime DateModified,
			int CreatedAccountID,
			int ModifiedAccountID)
		{
			// V2Generator: Body Start
			SqlParameter[] param			=
				{
					new SqlParameter("@name", SqlDbType.NVarChar, 200) ,
					new SqlParameter("@description", SqlDbType.NVarChar, -1) ,
					new SqlParameter("@image_name", SqlDbType.NVarChar, 500) ,
					new SqlParameter("@status", SqlDbType.Int) ,
					new SqlParameter("@date_created", SqlDbType.DateTime) ,
					new SqlParameter("@date_modified", SqlDbType.DateTime) ,
					new SqlParameter("@created_account_id", SqlDbType.Int) ,
					new SqlParameter("@modified_account_id", SqlDbType.Int)
				};

			param[0].Value					= Name;
			param[1].Value					= Description;
			param[2].Value					= ImageName;
			param[3].Value					= Status;
			param[4].Value					= DateCreated;
			param[5].Value					= DateModified;
			param[6].Value					= CreatedAccountID;
			param[7].Value					= ModifiedAccountID;

			DataTable dt					= SqlData.getSelectDataTable(SqlData.MASTER,"CategoryInsert",param);

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
		/// Accesses the stored procedure in the database CategoryUpdate to update a record from Category
		/// </summary>
		/// <param name="ID">No information available for ID</param>
		/// <param name="Name">No information available for Name</param>
		/// <param name="Description">No information available for Description</param>
		/// <param name="ImageName">No information available for ImageName</param>
		/// <param name="Status">No information available for Status</param>
		/// <param name="DateCreated">No information available for DateCreated</param>
		/// <param name="DateModified">No information available for DateModified</param>
		/// <param name="CreatedAccountID">No information available for CreatedAccountID</param>
		/// <param name="ModifiedAccountID">No information available for ModifiedAccountID</param>
		/// <returns></returns>
		// V2Generator: Section Start : Update
		public static void CategoryUpdate (
			int ID,
			string Name,
			string Description,
			string ImageName,
			int Status,
			DateTime DateCreated,
			DateTime DateModified,
			int CreatedAccountID,
			int ModifiedAccountID)
		{
			// V2Generator: Body Start
			SqlParameter[] param			=
				{
					new SqlParameter("@ID", SqlDbType.Int) ,
					new SqlParameter("@name", SqlDbType.NVarChar, 200) ,
					new SqlParameter("@description", SqlDbType.NVarChar, -1) ,
					new SqlParameter("@image_name", SqlDbType.NVarChar, 500) ,
					new SqlParameter("@status", SqlDbType.Int) ,
					new SqlParameter("@date_created", SqlDbType.DateTime) ,
					new SqlParameter("@date_modified", SqlDbType.DateTime) ,
					new SqlParameter("@created_account_id", SqlDbType.Int) ,
					new SqlParameter("@modified_account_id", SqlDbType.Int)
				};

			param[0].Value					= ID;
			param[1].Value					= Name;
			param[2].Value					= Description;
			param[3].Value					= ImageName;
			param[4].Value					= Status;
			param[5].Value					= DateCreated;
			param[6].Value					= DateModified;
			param[7].Value					= CreatedAccountID;
			param[8].Value					= ModifiedAccountID;

			SqlData.getSelectDataTable(SqlData.MASTER,"CategoryUpdate", param);
			// V2Generator: Body End
		}
		// V2Generator: Section End :Update

		#endregion

	}
}
