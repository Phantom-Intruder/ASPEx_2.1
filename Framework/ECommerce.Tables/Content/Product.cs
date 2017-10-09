/*----------------------------------------------------------------------------------------
* Page   : Product
* File   : Product.cs
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
using System.Data;
using System.Collections;
using System.Configuration;
using System.Collections.Generic;

namespace ECommerce.Tables.Content
{
	/// <summary>
	/// This is the class to define the table Product
	/// </summary>

	public class Product : Object, IComparable
	{

		#region Column Fields

		// V2Generator: Section Start : Database Column Field Names
		/// <summary>
		/// No information available for ID
		/// </summary>
		protected const string Field_ID																		 = "ID";
		/// <summary>
		/// No information available for CategoryID
		/// </summary>
		protected const string Field_category_id   															 = "category_id";
		/// <summary>
		/// Relation between Product and Category By CategoryID
		/// </summary>
		protected const string Relation_Product_CategoryByCategoryID   										 = "FK_Product_CategoryByCategoryID";
		/// <summary>
		/// No information available for Name
		/// </summary>
		protected const string Field_name  																	 = "name";
		/// <summary>
		/// No information available for Description
		/// </summary>
		protected const string Field_description   															 = "description";
		/// <summary>
		/// No information available for Price
		/// </summary>
		protected const string Field_price 																	 = "price";
		/// <summary>
		/// No information available for ImageName
		/// </summary>
		protected const string Field_image_name																 = "image_name";
		/// <summary>
		/// No information available for Status
		/// </summary>
		protected const string Field_status																	 = "status";
		/// <summary>
		/// No information available for DateCreated
		/// </summary>
		protected const string Field_date_created  															 = "date_created";
		/// <summary>
		/// No information available for DateModified
		/// </summary>
		protected const string Field_date_modified 															 = "date_modified";
		/// <summary>
		/// No information available for CreatedAccountID
		/// </summary>
		protected const string Field_created_account_id														 = "created_account_id";
		/// <summary>
		/// Relation between Product and Account By CreatedAccountID
		/// </summary>
		protected const string Relation_Product_AccountByCreatedAccountID  									 = "FK_Product_AccountByCreatedAccountID";
		/// <summary>
		/// No information available for ModifiedAccountID
		/// </summary>
		protected const string Field_modified_account_id   													 = "modified_account_id";
		/// <summary>
		/// Relation between Product and Account By ModifiedAccountID
		/// </summary>
		protected const string Relation_Product_AccountByModifiedAccountID 									 = "FK_Product_AccountByModifiedAccountID";
		// V2Generator: Section End :Database Column Field Names
		#endregion

		#region Protected Fields

		// V2Generator: Section Start : Protected fields section
		/// <summary>
		/// No information available for ID
		/// </summary>
		protected int 		m_ID										 = -1;
		/// <summary>
		/// No information available for CategoryID
		/// </summary>
		protected int 		m_CategoryID								 = -1;
		/// <summary>
		/// DataRow for Primary Table Category By CategoryID
		/// </summary>
		protected DataRow 	m_CategoryRowByCategoryID   				 = null ;
		/// <summary>
		/// No information available for Name
		/// </summary>
		protected string  	m_Name  									 = null;
		/// <summary>
		/// No information available for Description
		/// </summary>
		protected string  	m_Description   							 = null;
		/// <summary>
		/// No information available for Price
		/// </summary>
		protected decimal 	m_Price 									 = -1;
		/// <summary>
		/// No information available for ImageName
		/// </summary>
		protected string  	m_ImageName 								 = null;
		/// <summary>
		/// No information available for Status
		/// </summary>
		protected int 		m_Status									 = -1;
		/// <summary>
		/// No information available for DateCreated
		/// </summary>
		protected DateTime	m_DateCreated   							 = Convert.ToDateTime("1753/01/01 12:00:00");
		/// <summary>
		/// No information available for DateModified
		/// </summary>
		protected DateTime	m_DateModified  							 = Convert.ToDateTime("1753/01/01 12:00:00");
		/// <summary>
		/// No information available for CreatedAccountID
		/// </summary>
		protected int 		m_CreatedAccountID  						 = -1;
		/// <summary>
		/// DataRow for Primary Table Account By CreatedAccountID
		/// </summary>
		protected DataRow 	m_AccountRowByCreatedAccountID  			 = null ;
		/// <summary>
		/// No information available for ModifiedAccountID
		/// </summary>
		protected int 		m_ModifiedAccountID 						 = -1;
		/// <summary>
		/// DataRow for Primary Table Account By ModifiedAccountID
		/// </summary>
		protected DataRow 	m_AccountRowByModifiedAccountID 			 = null ;
		// V2Generator: Section End :Protected fields section
		#endregion

		#region List Item

		// V2Generator: Section Start : List Item Attributes
		// V2Generator: Section End :List Item Attributes
		#endregion

		#region Constructors

		/// <summary>
		/// Creates a new Product object
		/// </summary>
		/// <param name="ID">No information available for ID</param>
		/// <param name="CategoryID">No information available for CategoryID</param>
		/// <param name="CategoryRowByCategoryID">DataRow of Table Category</param>
		/// <param name="Name">No information available for Name</param>
		/// <param name="Description">No information available for Description</param>
		/// <param name="Price">No information available for Price</param>
		/// <param name="ImageName">No information available for ImageName</param>
		/// <param name="Status">No information available for Status</param>
		/// <param name="DateCreated">No information available for DateCreated</param>
		/// <param name="DateModified">No information available for DateModified</param>
		/// <param name="CreatedAccountID">No information available for CreatedAccountID</param>
		/// <param name="AccountRowByCreatedAccountID">DataRow of Table Account</param>
		/// <param name="ModifiedAccountID">No information available for ModifiedAccountID</param>
		/// <param name="AccountRowByModifiedAccountID">DataRow of Table Account</param>
		/// <returns></returns>
		// V2Generator: Section Start : Constructor using all the fields
		protected Product (
			int ID,
			int CategoryID,
			DataRow CategoryRowByCategoryID,
			string Name,
			string Description,
			decimal Price,
			string ImageName,
			int Status,
			DateTime DateCreated,
			DateTime DateModified,
			int CreatedAccountID,
			DataRow AccountRowByCreatedAccountID,
			int ModifiedAccountID,
			DataRow AccountRowByModifiedAccountID)
		{
			// V2Generator: Body Start
			this.m_ID   								 = ID;
			this.m_CategoryID   						 = CategoryID;
			this.m_CategoryRowByCategoryID  			 = CategoryRowByCategoryID;
			this.m_Name 								 = Name;
			this.m_Description  						 = Description;
			this.m_Price								 = Price;
			this.m_ImageName							 = ImageName;
			this.m_Status   							 = Status;
			this.m_DateCreated  						 = DateCreated;
			this.m_DateModified 						 = DateModified;
			this.m_CreatedAccountID 					 = CreatedAccountID;
			this.m_AccountRowByCreatedAccountID 		 = AccountRowByCreatedAccountID;
			this.m_ModifiedAccountID					 = ModifiedAccountID;
			this.m_AccountRowByModifiedAccountID		 = AccountRowByModifiedAccountID;
			// V2Generator: Body End
		}
		// V2Generator: Section End :Constructor using all the fields

		/// <summary>
		/// Creates a new Product object
		/// </summary>
		/// <param name="CategoryID">No information available for CategoryID</param>
		/// <param name="Name">No information available for Name</param>
		/// <param name="Description">No information available for Description</param>
		/// <param name="Price">No information available for Price</param>
		/// <param name="ImageName">No information available for ImageName</param>
		/// <param name="Status">No information available for Status</param>
		/// <param name="CreatedAccountID">No information available for CreatedAccountID</param>
		/// <param name="ModifiedAccountID">No information available for ModifiedAccountID</param>
		/// <returns></returns>
		// V2Generator: Section Start : Constructor for insert
		protected Product (
			int CategoryID,
			string Name,
			string Description,
			decimal Price,
			string ImageName,
			int Status,
			int CreatedAccountID,
			int ModifiedAccountID)
		{
			// V2Generator: Body Start
			this.m_CategoryID   					= CategoryID;
			this.m_Name 							= Name;
			this.m_Description  					= Description;
			this.m_Price							= Price;
			this.m_ImageName						= ImageName;
			this.m_Status   						= Status;
			this.m_CreatedAccountID 				= CreatedAccountID;
			this.m_ModifiedAccountID				= ModifiedAccountID;
			// V2Generator: Body End
		}
		// V2Generator: Section End :Constructor for insert

		#endregion

		#region Execute Create

		/// <summary>
		/// Creates a new Product object based on the given record id from the database
		/// </summary>
		/// <param name="ID">No information available for ID</param>
		/// <returns>null or a new Product object</returns>
		// V2Generator: Section Start : ExecuteCreate By ID
		public static Product ExecuteCreate (int ID)
		{
			// V2Generator: Body Start
			Product 					  result     = null;

			DataSet 					  ds  		  = ECommerce.SQL.Content.Product.ProductGetByID(ID);

			DataTable   				  dt  		  = AddRelation(ds);
			if (dt.Rows.Count>0)
			{
				result									= Create(dt.Rows[0]);
			}

			return result;
			// V2Generator: Body End
		}
		// V2Generator: Section End :ExecuteCreate By ID

		/// <summary>
		/// Creates a new Product object for inserting a new record into the database
		/// </summary>
		/// <param name="CategoryID">No information available for CategoryID</param>
		/// <param name="Name">No information available for Name</param>
		/// <param name="Description">No information available for Description</param>
		/// <param name="Price">No information available for Price</param>
		/// <param name="ImageName">No information available for ImageName</param>
		/// <param name="Status">No information available for Status</param>
		/// <param name="CreatedAccountID">No information available for CreatedAccountID</param>
		/// <param name="ModifiedAccountID">No information available for ModifiedAccountID</param>
		/// <returns>null or a new Product object</returns>
		/// <Exception cref="System.Exception">
		/// Throws an exception if Name is null. Throws an exception if Description is null. Throws an exception if ImageName is null. 
		/// </Exception>
		// V2Generator: Section Start : ExecuteCreate Insert
		public static Product ExecuteCreate (
			int CategoryID,
			string Name,
			string Description,
			decimal Price,
			string ImageName,
			int Status,
			int CreatedAccountID,
			int ModifiedAccountID)
		{
			// V2Generator: Body Start
			Product	result		= null;

			#region Validate the input parameter(s)

			if (Name == null)
			{
				throw new System.Exception("Product ExecuteCreate :: Name cannot be null (Database Constraint)");
			}
			if (Description == null)
			{
				throw new System.Exception("Product ExecuteCreate :: Description cannot be null (Database Constraint)");
			}
			if (ImageName == null)
			{
				throw new System.Exception("Product ExecuteCreate :: ImageName cannot be null (Database Constraint)");
			}
			#endregion

			result			= new Product(CategoryID, Name, Description, Price, ImageName, Status, CreatedAccountID, ModifiedAccountID);
			return result;
			// V2Generator: Body End
		}
		// V2Generator: Section End :ExecuteCreate Insert

		/// <summary>
		/// Creates a new Product object
		/// </summary>
		/// <param name="row"></param>
		/// <returns>null or a new Product object</returns>
		// V2Generator: Section Start : ExecuteCreate Row
		internal static Product ExecuteCreate (DataRow row)
		{
			// V2Generator: Body Start
			return Create(row);
			// V2Generator: Body End
		}
		// V2Generator: Section End :ExecuteCreate Row

		/// <summary>
		/// Creates a new Category object
		/// </summary>
		/// <returns>null or a new Category object</returns>
		// V2Generator: Section Start : ExecuteCreate Primary Table object CategoryByCategoryID
		public ECommerce.Tables.Content.Category ExecuteCreateCategoryByCategoryID ()
		{
			// V2Generator: Body Start
			ECommerce.Tables.Content.Category Result = null;
			if (m_CategoryRowByCategoryID!=null)
			{
				Result  											   = ECommerce.Tables.Content.Category.ExecuteCreate(m_CategoryRowByCategoryID);
			}
			else
			{
				Result  											   = ECommerce.Tables.Content.Category.ExecuteCreate(m_CategoryID);
			}
			return Result;
			// V2Generator: Body End
		}
		// V2Generator: Section End :ExecuteCreate Primary Table object CategoryByCategoryID

		/// <summary>
		/// Creates a new Account object
		/// </summary>
		/// <returns>null or a new Account object</returns>
		// V2Generator: Section Start : ExecuteCreate Primary Table object AccountByCreatedAccountID
		public ECommerce.Tables.Active.HR.Account ExecuteCreateAccountByCreatedAccountID ()
		{
			// V2Generator: Body Start
			ECommerce.Tables.Active.HR.Account Result = null;
			if (m_AccountRowByCreatedAccountID!=null)
			{
				Result  											   = ECommerce.Tables.Active.HR.Account.ExecuteCreate(m_AccountRowByCreatedAccountID);
			}
			else
			{
				Result  											   = ECommerce.Tables.Active.HR.Account.ExecuteCreate(m_CreatedAccountID);
			}
			return Result;
			// V2Generator: Body End
		}
		// V2Generator: Section End :ExecuteCreate Primary Table object AccountByCreatedAccountID

		/// <summary>
		/// Creates a new Account object
		/// </summary>
		/// <returns>null or a new Account object</returns>
		// V2Generator: Section Start : ExecuteCreate Primary Table object AccountByModifiedAccountID
		public ECommerce.Tables.Active.HR.Account ExecuteCreateAccountByModifiedAccountID ()
		{
			// V2Generator: Body Start
			ECommerce.Tables.Active.HR.Account Result = null;
			if (m_AccountRowByModifiedAccountID!=null)
			{
				Result  											   = ECommerce.Tables.Active.HR.Account.ExecuteCreate(m_AccountRowByModifiedAccountID);
			}
			else
			{
				Result  											   = ECommerce.Tables.Active.HR.Account.ExecuteCreate(m_ModifiedAccountID);
			}
			return Result;
			// V2Generator: Body End
		}
		// V2Generator: Section End :ExecuteCreate Primary Table object AccountByModifiedAccountID


		#endregion

		#region Create

		/// <summary>
		/// Creates a new Product object based on the given row obtained from the database. The row is from the table Product.
		/// </summary>
		/// <param name="row"></param>
		/// <returns>null or a Product object</returns>
		// V2Generator: Section Start : Create section
		private static Product Create (DataRow row)
		{
			// V2Generator: Body Start
			Product    result  			 = null;
			
			int 	   ID  				 = -1;
			int 	   CategoryID  		 = -1;
			string     Name				 = null;
			string     Description 		 = null;
			decimal    Price   			 = -1;
			string     ImageName   		 = null;
			int 	   Status  			 = -1;
			DateTime   DateCreated 		 = Convert.ToDateTime("1753/01/01 12:00:00");
			DateTime   DateModified		 = Convert.ToDateTime("1753/01/01 12:00:00");
			int 	   CreatedAccountID	 = -1;
			int 	   ModifiedAccountID    = -1;

			#region get the values
			ID  							 = (int) row[Field_ID];
			if (row[Field_category_id]!=System.DBNull.Value)
			{
				CategoryID  				 = (int) row[Field_category_id];
			}
			if (row[Field_name]!=System.DBNull.Value)
			{
				Name						 = (string) row[Field_name];
			}
			if (row[Field_description]!=System.DBNull.Value)
			{
				Description 				 = (string) row[Field_description];
			}
			if (row[Field_price]!=System.DBNull.Value)
			{
				Price   					 = (decimal) row[Field_price];
			}
			if (row[Field_image_name]!=System.DBNull.Value)
			{
				ImageName   				 = (string) row[Field_image_name];
			}
			if (row[Field_status]!=System.DBNull.Value)
			{
				Status  					 = (int) row[Field_status];
			}
			if (row[Field_date_created]!=System.DBNull.Value)
			{
				DateCreated 				 = (DateTime) row[Field_date_created];
			}
			if (row[Field_date_modified]!=System.DBNull.Value)
			{
				DateModified				 = (DateTime) row[Field_date_modified];
			}
			if (row[Field_created_account_id]!=System.DBNull.Value)
			{
				CreatedAccountID			 = (int) row[Field_created_account_id];
			}
			if (row[Field_modified_account_id]!=System.DBNull.Value)
			{
				ModifiedAccountID   		 = (int) row[Field_modified_account_id];
			}
			#endregion
			result  						 = new Product(ID, CategoryID, row.GetParentRow(Relation_Product_CategoryByCategoryID), Name, Description, Price, ImageName, Status, DateCreated, DateModified, CreatedAccountID, row.GetParentRow(Relation_Product_AccountByCreatedAccountID), ModifiedAccountID, row.GetParentRow(Relation_Product_AccountByModifiedAccountID));

			return result;
			// V2Generator: Body End
		}
		// V2Generator: Section End :Create section

		#endregion

		#region Relation

		/// <summary>
		/// Creates relationship between Product and primary tables
		/// </summary>
		/// <param name="ds"></param>
		/// <returns>null or a ProductDataTable</returns>
		// V2Generator: Section Start : Relations
		protected static DataTable  AddRelation (DataSet ds)
		{
			// V2Generator: Body Start
			/*ds.Relations.Add(new DataRelation(
					Relation_Product_CategoryByCategoryID,
					ds.Tables[1].Columns["ID"],
					ds.Tables[0].Columns[Field_category_id],false));
			ds.Relations.Add(new DataRelation(
					Relation_Product_AccountByCreatedAccountID,
					ds.Tables[2].Columns["ID"],
					ds.Tables[0].Columns[Field_created_account_id],false));
			ds.Relations.Add(new DataRelation(
					Relation_Product_AccountByModifiedAccountID,
					ds.Tables[3].Columns["ID"],
					ds.Tables[0].Columns[Field_modified_account_id],false));*/
			return ds.Tables[0];
			// V2Generator: Body End
		}
		// V2Generator: Section End :Relations

		#endregion

		#region List Methods

		/// <summary>
		/// Lists all the records from the database
		/// </summary>
		/// <returns></returns>
		// V2Generator: Section Start : List all
		public static List<Product> List ()
		{
			// V2Generator: Body Start
			List<Product>			list				= new List<Product>();
			DataSet				ds					= ECommerce.SQL.Content.Product.ProductList();

			DataTable			dt					= AddRelation(ds);
			for (int i=0; i<dt.Rows.Count; i++)
			{
				Product 		result				= Create(dt.Rows[i]);
				if (result!=null)
				{
					list.Add(result);
				}
			}

			list.Sort();

			return list;
			// V2Generator: Body End
		}
		// V2Generator: Section End :List all

		/// <summary>
		/// Lists all the records from the database
		/// </summary>
		/// <param name="Status">The condition element in the database</param>
		/// <returns></returns>
		// V2Generator: Section Start : ListAllByStatus
		public static List<Product> ListByStatus (int Status)
		{
			// V2Generator: Body Start
			List<Product>			list				= new List<Product>();
			DataSet				ds					= ECommerce.SQL.Content.Product.ProductListByStatus(Status);

			DataTable			dt					= AddRelation(ds);
			for (int i=0; i<dt.Rows.Count; i++)
			{
				Product 		result				= Create(dt.Rows[i]);
				if (result!=null)
				{
					list.Add(result);
				}
			}

			list.Sort();

			return list;
			// V2Generator: Body End
		}
        // V2Generator: Section End :ListAllByStatus


        #endregion

        #region DB Methods

        /// <summary>
        /// Deletes the object record from the database (Does not act as a destructor)
        /// </summary>
        /// <returns></returns>
        // V2Generator: Section Start : Delete
        public static void Delete(int idNew)
        {
            // V2Generator: Body Start
            ECommerce.SQL.Content.Product.ProductDelete(idNew);
            // V2Generator: Body End
        }

        public void Delete ()
		{
			// V2Generator: Body Start
			ECommerce.SQL.Content.Product.ProductDelete (this.m_ID);
			// V2Generator: Body End
		}
        // V2Generator: Section End :Delete
        public void Update(int ID, Product record)
        {
            this.Update(
                ID,
                record.CategoryID,
                record.Name,
                record.Description,
                record.Price,
                record.ImageName,
                record.Status,
                record.DateModified,
                record.ModifiedAccountID);
        }
        protected void Update(
            int IDNew,
            int CategoryID,
            string Name,
            string Description,
            decimal Price,
            string ImageName,
            int Status,
            DateTime DateModified,
            int ModifiedAccountID)
        {
            DateTime date = DateTime.Now;
            ECommerce.SQL.Content.Product.ProductUpdate(IDNew, CategoryID, Name, Description, Price, ImageName, Status, date, date, 1, ModifiedAccountID);

            if (this.m_CategoryID != CategoryID)
            {
                m_CategoryRowByCategoryID = null;
            }
            if (this.m_CreatedAccountID != CreatedAccountID)
            {
                m_AccountRowByCreatedAccountID = null;
            }
            if (this.m_ModifiedAccountID != ModifiedAccountID)
            {
                m_AccountRowByModifiedAccountID = null;
            }
            this.m_CategoryID             = CategoryID;
            this.m_Name                   = Name;
            this.m_Description            = Description;
            this.m_Price                  = Price;
            this.m_ImageName              = ImageName;
            this.m_Status                 = Status;
            this.m_DateModified           = DateModified;
            this.m_ModifiedAccountID      = ModifiedAccountID;
        }
        /// <summary>
        /// Updates the object members and the corresponding row in the database.
        /// </summary>
        /// <param name="CategoryID">No information available for CategoryID</param>
        /// <param name="Name">No information available for Name</param>
        /// <param name="Description">No information available for Description</param>
        /// <param name="Price">No information available for Price</param>
        /// <param name="ImageName">No information available for ImageName</param>
        /// <param name="Status">No information available for Status</param>
        /// <param name="DateCreated">No information available for DateCreated</param>
        /// <param name="DateModified">No information available for DateModified</param>
        /// <param name="CreatedAccountID">No information available for CreatedAccountID</param>
        /// <param name="ModifiedAccountID">No information available for ModifiedAccountID</param>
        /// <returns></returns>
        // V2Generator: Section Start : Update
        protected void Update (
			int CategoryID,
			string Name,
			string Description,
			decimal Price,
			string ImageName,
			int Status,
			DateTime DateCreated,
			DateTime DateModified,
			int CreatedAccountID,
			int ModifiedAccountID)
		{
			// V2Generator: Body Start
			ECommerce.SQL.Content.Product.ProductUpdate (ID, CategoryID, Name, Description, Price, ImageName, Status, DateCreated, DateModified, CreatedAccountID, ModifiedAccountID);

			if (this.m_CategoryID != CategoryID)
			{
				m_CategoryRowByCategoryID = null;
			}
			if (this.m_CreatedAccountID != CreatedAccountID)
			{
				m_AccountRowByCreatedAccountID = null;
			}
			if (this.m_ModifiedAccountID != ModifiedAccountID)
			{
				m_AccountRowByModifiedAccountID = null;
			}
			this.m_CategoryID   		  = CategoryID;
			this.m_Name 				  = Name;
			this.m_Description  		  = Description;
			this.m_Price				  = Price;
			this.m_ImageName			  = ImageName;
			this.m_Status   			  = Status;
			this.m_DateCreated  		  = DateCreated;
			this.m_DateModified 		  = DateModified;
			this.m_CreatedAccountID 	  = CreatedAccountID;
			this.m_ModifiedAccountID	  = ModifiedAccountID;
			// V2Generator: Body End
		}
		// V2Generator: Section End :Update

		public void Update(int CategoryID,
			string Name,
			string Description,
			decimal Price,
			string ImageName,
			int Status,
			DateTime DateModified,
			int ModifiedAccountID)
		{
			this.Update(CategoryID, Name, Description, Price, ImageName, Status, this.m_DateCreated, DateModified, this.m_CreatedAccountID, ModifiedAccountID);
		}

		/// <summary>
		/// Inserts a new record into the database, and updates the identity field in this object.
		/// </summary>
		/// <returns></returns>
		// V2Generator: Section Start : Insert
		public void Insert ()
		{
			// V2Generator: Body Start
			this.m_DateCreated			= DateTime.Now;
			this.m_DateModified			= DateTime.Now;
			this.m_ID			= ECommerce.SQL.Content.Product.ProductInsert (this.m_CategoryID, this.m_Name, this.m_Description, this.m_Price, this.m_ImageName, this.m_Status, this.m_DateCreated, this.m_DateModified, this.m_CreatedAccountID, this.m_ModifiedAccountID);
			// V2Generator: Body End
		}
		// V2Generator: Section End :Insert

		#endregion

		#region Compare

		/// <summary>
		/// Compares the current Product object with the given Product object
		/// </summary>
		/// <param name="row">The Product object to compare with</param>
		/// <returns>The compared difference between the Product objects</returns>
		// V2Generator: Section Start : CompareTo
		public int CompareTo (object row)
		{
			// V2Generator: Body Start
			if(row is Product)
			{
				Product temp = (Product) row;
				return ID.CompareTo(temp.ID);
			}
			else
			{
				throw new System.ArgumentException("object is not a Product");
			}
			// V2Generator: Body End
		}
		// V2Generator: Section End :CompareTo

		/// <summary>
		/// Get HashCode
		/// </summary>
		/// <returns>HashCode</returns>
		// V2Generator: Section Start : GetHashCode
		public override int  GetHashCode ()
		{
			// V2Generator: Body Start
		return base.GetHashCode ();
			// V2Generator: Body End
		}
		// V2Generator: Section End :GetHashCode

		/// <summary>
		/// Equals from Object class
		/// </summary>
		/// <param name="obj">The Product object to compare with</param>
		/// <returns>True if equal else false</returns>
		// V2Generator: Section Start : Equals
		public override bool  Equals (object obj)
		{
			// V2Generator: Body Start
		bool  result     = false;
		if (this.ID ==((Product)obj).ID)
		{
			result     = true;
		}
		 return result;
			// V2Generator: Body End
		}
		// V2Generator: Section End :Equals

		#endregion

		#region Assessors

		// V2Generator: Section Start : Assessors section
		/// <summary>
		/// No information available for ID
		/// </summary>
		public int ID
		{
			get{return this.m_ID;}
		}
		/// <summary>
		/// No information available for CategoryID
		/// </summary>
		public int CategoryID
		{
			get{return this.m_CategoryID;}
		}
		/// <summary>
		/// No information available for Name
		/// </summary>
		public string Name
		{
			get{return this.m_Name;}
		}
		/// <summary>
		/// No information available for Description
		/// </summary>
		public string Description
		{
			get{return this.m_Description;}
		}
		/// <summary>
		/// No information available for Price
		/// </summary>
		public decimal Price
		{
			get{return this.m_Price;}
		}
		/// <summary>
		/// No information available for ImageName
		/// </summary>
		public string ImageName
		{
			get{return this.m_ImageName;}
		}
		/// <summary>
		/// No information available for Status
		/// </summary>
		public int Status
		{
			get{return this.m_Status;}
		}
		/// <summary>
		/// No information available for DateCreated
		/// </summary>
		public DateTime DateCreated
		{
			get{return this.m_DateCreated;}
		}
		/// <summary>
		/// No information available for DateModified
		/// </summary>
		public DateTime DateModified
		{
			get{return this.m_DateModified;}
		}
		/// <summary>
		/// No information available for CreatedAccountID
		/// </summary>
		public int CreatedAccountID
		{
			get{return this.m_CreatedAccountID;}
		}
		/// <summary>
		/// No information available for ModifiedAccountID
		/// </summary>
		public int ModifiedAccountID
		{
			get{return this.m_ModifiedAccountID;}
		}
		// V2Generator: Section End :Assessors section
		// V2Generator: Section Start : List Item Assessor
		// V2Generator: Section End :List Item Assessor
		#endregion

	}

}

