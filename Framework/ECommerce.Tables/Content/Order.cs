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
using System.Data;
using System.Collections;
using System.Configuration;
using System.Collections.Generic;

namespace ECommerce.Tables.Content
{
	/// <summary>
	/// This is the class to define the table Order
	/// </summary>

	public class Order : Object, IComparable
	{

		#region Column Fields

		// V2Generator: Section Start : Database Column Field Names
		/// <summary>
		/// No information available for ID
		/// </summary>
		protected const string Field_ID																		 = "ID";
		/// <summary>
		/// No information available for AccountID
		/// </summary>
		protected const string Field_account_id																 = "account_id";
		/// <summary>
		/// Relation between Order and Account By AccountID
		/// </summary>
		protected const string Relation_Order_AccountByAccountID   											 = "FK_Order_AccountByAccountID";
		/// <summary>
		/// No information available for DateCreated
		/// </summary>
		protected const string Field_date_created  															 = "date_created";
		/// <summary>
		/// No information available for Status
		/// </summary>
		protected const string Field_status																	 = "status";
		/// <summary>
		/// No information available for PaymentMethod
		/// </summary>
		protected const string Field_payment_method															 = "payment_method";
		/// <summary>
		/// No information available for TotalAmount
		/// </summary>
		protected const string Field_total_amount  															 = "total_amount";
		// V2Generator: Section End :Database Column Field Names
		#endregion

		#region Protected Fields

		// V2Generator: Section Start : Protected fields section
		/// <summary>
		/// No information available for ID
		/// </summary>
		protected int 		m_ID										 = -1;
		/// <summary>
		/// No information available for AccountID
		/// </summary>
		protected int 		m_AccountID 								 = -1;
		/// <summary>
		/// DataRow for Primary Table Account By AccountID
		/// </summary>
		protected DataRow 	m_AccountRowByAccountID 					 = null ;
		/// <summary>
		/// No information available for DateCreated
		/// </summary>
		protected DateTime	m_DateCreated   							 = Convert.ToDateTime("1753/01/01 12:00:00");
		/// <summary>
		/// No information available for Status
		/// </summary>
		protected int 		m_Status									 = -1;
		/// <summary>
		/// No information available for PaymentMethod
		/// </summary>
		protected int 		m_PaymentMethod 							 = -1;
		/// <summary>
		/// No information available for TotalAmount
		/// </summary>
		protected decimal 	m_TotalAmount   							 = -1;
		// V2Generator: Section End :Protected fields section
		#endregion

		#region List Item

		// V2Generator: Section Start : List Item Attributes
		// V2Generator: Section End :List Item Attributes
		#endregion

		#region Constructors

		/// <summary>
		/// Creates a new Order object
		/// </summary>
		/// <param name="ID">No information available for ID</param>
		/// <param name="AccountID">No information available for AccountID</param>
		/// <param name="AccountRowByAccountID">DataRow of Table Account</param>
		/// <param name="DateCreated">No information available for DateCreated</param>
		/// <param name="Status">No information available for Status</param>
		/// <param name="PaymentMethod">No information available for PaymentMethod</param>
		/// <param name="TotalAmount">No information available for TotalAmount</param>
		/// <returns></returns>
		// V2Generator: Section Start : Constructor using all the fields
		protected Order (
			int ID,
			int AccountID,
			DataRow AccountRowByAccountID,
			DateTime DateCreated,
			int Status,
			int PaymentMethod,
			decimal TotalAmount)
		{
			// V2Generator: Body Start
			this.m_ID   								 = ID;
			this.m_AccountID							 = AccountID;
			this.m_AccountRowByAccountID				 = AccountRowByAccountID;
			this.m_DateCreated  						 = DateCreated;
			this.m_Status   							 = Status;
			this.m_PaymentMethod						 = PaymentMethod;
			this.m_TotalAmount  						 = TotalAmount;
			// V2Generator: Body End
		}
		// V2Generator: Section End :Constructor using all the fields

		/// <summary>
		/// Creates a new Order object
		/// </summary>
		/// <param name="AccountID">No information available for AccountID</param>
		/// <param name="Status">No information available for Status</param>
		/// <param name="PaymentMethod">No information available for PaymentMethod</param>
		/// <param name="TotalAmount">No information available for TotalAmount</param>
		/// <returns></returns>
		// V2Generator: Section Start : Constructor for insert
		protected Order (
			int AccountID,
			int Status,
			int PaymentMethod,
			decimal TotalAmount)
		{
			// V2Generator: Body Start
			this.m_AccountID						= AccountID;
			this.m_Status   						= Status;
			this.m_PaymentMethod					= PaymentMethod;
			this.m_TotalAmount  					= TotalAmount;
			// V2Generator: Body End
		}
		// V2Generator: Section End :Constructor for insert

		#endregion

		#region Execute Create

		/// <summary>
		/// Creates a new Order object based on the given record id from the database
		/// </summary>
		/// <param name="ID">No information available for ID</param>
		/// <returns>null or a new Order object</returns>
		// V2Generator: Section Start : ExecuteCreate By ID
		public static Order ExecuteCreate (int ID)
		{
			// V2Generator: Body Start
			Order   					  result     = null;

			DataSet 					  ds  		  = ECommerce.SQL.Content.Order.OrderGetByID(ID);

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
		/// Creates a new Order object for inserting a new record into the database
		/// </summary>
		/// <param name="AccountID">No information available for AccountID</param>
		/// <param name="Status">No information available for Status</param>
		/// <param name="PaymentMethod">No information available for PaymentMethod</param>
		/// <param name="TotalAmount">No information available for TotalAmount</param>
		/// <returns>null or a new Order object</returns>
		// V2Generator: Section Start : ExecuteCreate Insert
		public static Order ExecuteCreate (
			int AccountID,
			int Status,
			int PaymentMethod,
			decimal TotalAmount)
		{
			// V2Generator: Body Start
			Order	result		= null;

			#region Validate the input parameter(s)

			#endregion

			result			= new Order(AccountID, Status, PaymentMethod, TotalAmount);
			return result;
			// V2Generator: Body End
		}
		// V2Generator: Section End :ExecuteCreate Insert

		/// <summary>
		/// Creates a new Order object
		/// </summary>
		/// <param name="row"></param>
		/// <returns>null or a new Order object</returns>
		// V2Generator: Section Start : ExecuteCreate Row
		internal static Order ExecuteCreate (DataRow row)
		{
			// V2Generator: Body Start
			return Create(row);
			// V2Generator: Body End
		}
		// V2Generator: Section End :ExecuteCreate Row

		/// <summary>
		/// Creates a new Account object
		/// </summary>
		/// <returns>null or a new Account object</returns>
		// V2Generator: Section Start : ExecuteCreate Primary Table object AccountByAccountID
		public ECommerce.Tables.Active.HR.Account ExecuteCreateAccountByAccountID ()
		{
			// V2Generator: Body Start
			ECommerce.Tables.Active.HR.Account Result = null;
			if (m_AccountRowByAccountID!=null)
			{
				Result  											   = ECommerce.Tables.Active.HR.Account.ExecuteCreate(m_AccountRowByAccountID);
			}
			else
			{
				Result  											   = ECommerce.Tables.Active.HR.Account.ExecuteCreate(m_AccountID);
			}
			return Result;
			// V2Generator: Body End
		}
		// V2Generator: Section End :ExecuteCreate Primary Table object AccountByAccountID


		#endregion

		#region Create

		/// <summary>
		/// Creates a new Order object based on the given row obtained from the database. The row is from the table Order.
		/// </summary>
		/// <param name="row"></param>
		/// <returns>null or a Order object</returns>
		// V2Generator: Section Start : Create section
		private static Order Create (DataRow row)
		{
			// V2Generator: Body Start
			Order      result  			 = null;
			
			int 	   ID  				 = -1;
			int 	   AccountID   		 = -1;
			DateTime   DateCreated 		 = Convert.ToDateTime("1753/01/01 12:00:00");
			int 	   Status  			 = -1;
			int 	   PaymentMethod   	 = -1;
			decimal    TotalAmount 		 = -1;

			#region get the values
			ID  							 = (int) row[Field_ID];
			if (row[Field_account_id]!=System.DBNull.Value)
			{
				AccountID   				 = (int) row[Field_account_id];
			}
			if (row[Field_date_created]!=System.DBNull.Value)
			{
				DateCreated 				 = (DateTime) row[Field_date_created];
			}
			if (row[Field_status]!=System.DBNull.Value)
			{
				Status  					 = (int) row[Field_status];
			}
			if (row[Field_payment_method]!=System.DBNull.Value)
			{
				PaymentMethod   			 = (int) row[Field_payment_method];
			}
			if (row[Field_total_amount]!=System.DBNull.Value)
			{
				TotalAmount 				 = (decimal) row[Field_total_amount];
			}
			#endregion
			result  						 = new Order(ID, AccountID, row.GetParentRow(Relation_Order_AccountByAccountID), DateCreated, Status, PaymentMethod, TotalAmount);

			return result;
			// V2Generator: Body End
		}
		// V2Generator: Section End :Create section

		#endregion

		#region Relation

		/// <summary>
		/// Creates relationship between Order and primary tables
		/// </summary>
		/// <param name="ds"></param>
		/// <returns>null or a OrderDataTable</returns>
		// V2Generator: Section Start : Relations
		protected static DataTable  AddRelation (DataSet ds)
		{
			// V2Generator: Body Start
			ds.Relations.Add(new DataRelation(
					Relation_Order_AccountByAccountID,
					ds.Tables[1].Columns["ID"],
					ds.Tables[0].Columns[Field_account_id],false));
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
		public static List<Order> List ()
		{
			// V2Generator: Body Start
			List<Order>			list				= new List<Order>();
			DataSet				ds					= ECommerce.SQL.Content.Order.OrderList();

			DataTable			dt					= AddRelation(ds);
			for (int i=0; i<dt.Rows.Count; i++)
			{
				Order   		result				= Create(dt.Rows[i]);
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
		/// <param name="AccountID">The condition element in the database</param>
		/// <returns></returns>
		// V2Generator: Section Start : ListAllByAccountID
		public static List<Order> ListByAccountID (int AccountID)
		{
			// V2Generator: Body Start
			List<Order>			list				= new List<Order>();
			DataSet				ds					= ECommerce.SQL.Content.Order.OrderListByAccountID(AccountID);

			DataTable			dt					= AddRelation(ds);
			for (int i=0; i<dt.Rows.Count; i++)
			{
				Order   		result				= Create(dt.Rows[i]);
				if (result!=null)
				{
					list.Add(result);
				}
			}

			list.Sort();

			return list;
			// V2Generator: Body End
		}
		// V2Generator: Section End :ListAllByAccountID

		/// <summary>
		/// Lists all the records from the database
		/// </summary>
		/// <param name="Status">The condition element in the database</param>
		/// <returns></returns>
		// V2Generator: Section Start : ListAllByStatus
		public static List<Order> ListByStatus (int Status)
		{
			// V2Generator: Body Start
			List<Order>			list				= new List<Order>();
			DataSet				ds					= ECommerce.SQL.Content.Order.OrderListByStatus(Status);

			DataTable			dt					= AddRelation(ds);
			for (int i=0; i<dt.Rows.Count; i++)
			{
				Order   		result				= Create(dt.Rows[i]);
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
		public void Delete ()
		{
			// V2Generator: Body Start
			ECommerce.SQL.Content.Order.OrderDelete (this.m_ID);
			// V2Generator: Body End
		}
		// V2Generator: Section End :Delete

		/// <summary>
		/// Updates the object members and the corresponding row in the database.
		/// </summary>
		/// <param name="AccountID">No information available for AccountID</param>
		/// <param name="DateCreated">No information available for DateCreated</param>
		/// <param name="Status">No information available for Status</param>
		/// <param name="PaymentMethod">No information available for PaymentMethod</param>
		/// <param name="TotalAmount">No information available for TotalAmount</param>
		/// <returns></returns>
		// V2Generator: Section Start : Update
		protected void Update (
			int AccountID,
			DateTime DateCreated,
			int Status,
			int PaymentMethod,
			decimal TotalAmount)
		{
			// V2Generator: Body Start
			ECommerce.SQL.Content.Order.OrderUpdate (ID, AccountID, DateCreated, Status, PaymentMethod, TotalAmount);

			if (this.m_AccountID != AccountID)
			{
				m_AccountRowByAccountID = null;
			}
			this.m_AccountID			  = AccountID;
			this.m_DateCreated  		  = DateCreated;
			this.m_Status   			  = Status;
			this.m_PaymentMethod		  = PaymentMethod;
			this.m_TotalAmount  		  = TotalAmount;
			// V2Generator: Body End
		}
		// V2Generator: Section End :Update

		/// <summary>
		/// Inserts a new record into the database, and updates the identity field in this object.
		/// </summary>
		/// <returns></returns>
		// V2Generator: Section Start : Insert
		public void Insert ()
		{
			// V2Generator: Body Start
			this.m_DateCreated			= DateTime.Now;
			this.m_ID			= ECommerce.SQL.Content.Order.OrderInsert (this.m_AccountID, this.m_DateCreated, this.m_Status, this.m_PaymentMethod, this.m_TotalAmount);
			// V2Generator: Body End
		}
		// V2Generator: Section End :Insert

		#endregion

		#region Compare

		/// <summary>
		/// Compares the current Order object with the given Order object
		/// </summary>
		/// <param name="row">The Order object to compare with</param>
		/// <returns>The compared difference between the Order objects</returns>
		// V2Generator: Section Start : CompareTo
		public int CompareTo (object row)
		{
			// V2Generator: Body Start
			if(row is Order)
			{
				Order temp = (Order) row;
				return ID.CompareTo(temp.ID);
			}
			else
			{
				throw new System.ArgumentException("object is not a Order");
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
		/// <param name="obj">The Order object to compare with</param>
		/// <returns>True if equal else false</returns>
		// V2Generator: Section Start : Equals
		public override bool  Equals (object obj)
		{
			// V2Generator: Body Start
		bool  result     = false;
		if (this.ID ==((Order)obj).ID)
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
		/// No information available for AccountID
		/// </summary>
		public int AccountID
		{
			get{return this.m_AccountID;}
		}
		/// <summary>
		/// No information available for DateCreated
		/// </summary>
		public DateTime DateCreated
		{
			get{return this.m_DateCreated;}
		}
		/// <summary>
		/// No information available for Status
		/// </summary>
		public int Status
		{
			get{return this.m_Status;}
		}
		/// <summary>
		/// No information available for PaymentMethod
		/// </summary>
		public int PaymentMethod
		{
			get{return this.m_PaymentMethod;}
		}
		/// <summary>
		/// No information available for TotalAmount
		/// </summary>
		public decimal TotalAmount
		{
			get{return this.m_TotalAmount;}
		}
		// V2Generator: Section End :Assessors section
		// V2Generator: Section Start : List Item Assessor
		// V2Generator: Section End :List Item Assessor
		#endregion

	}

}

