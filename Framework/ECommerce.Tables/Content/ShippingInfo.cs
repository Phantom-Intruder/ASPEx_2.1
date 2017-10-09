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
using System.Data;
using System.Collections;
using System.Configuration;
using System.Collections.Generic;

namespace ECommerce.Tables.Content
{
	/// <summary>
	/// This is the class to define the table ShippingInfo
	/// </summary>

	public class ShippingInfo : Object, IComparable
	{

		#region Column Fields

		// V2Generator: Section Start : Database Column Field Names
		/// <summary>
		/// No information available for ID
		/// </summary>
		protected const string Field_ID																		 = "ID";
		/// <summary>
		/// No information available for OrderID
		/// </summary>
		protected const string Field_order_id  																 = "order_id";
		/// <summary>
		/// Relation between ShippingInfo and Order By OrderID
		/// </summary>
		protected const string Relation_ShippingInfo_OrderByOrderID											 = "FK_ShippingInfo_OrderByOrderID";
		/// <summary>
		/// No information available for Type
		/// </summary>
		protected const string Field_type  																	 = "type";
		/// <summary>
		/// No information available for Cost
		/// </summary>
		protected const string Field_cost  																	 = "cost";
		/// <summary>
		/// No information available for Address
		/// </summary>
		protected const string Field_address   																 = "address";
		// V2Generator: Section End :Database Column Field Names
		#endregion

		#region Protected Fields

		// V2Generator: Section Start : Protected fields section
		/// <summary>
		/// No information available for ID
		/// </summary>
		protected int 		m_ID										 = -1;
		/// <summary>
		/// No information available for OrderID
		/// </summary>
		protected int 		m_OrderID   								 = -1;
		/// <summary>
		/// DataRow for Primary Table Order By OrderID
		/// </summary>
		protected DataRow 	m_OrderRowByOrderID 						 = null ;
		/// <summary>
		/// No information available for Type
		/// </summary>
		protected int 		m_Type  									 = -1;
		/// <summary>
		/// No information available for Cost
		/// </summary>
		protected decimal 	m_Cost  									 = -1;
		/// <summary>
		/// No information available for Address
		/// </summary>
		protected string  	m_Address   								 = null;
		// V2Generator: Section End :Protected fields section
		#endregion

		#region List Item

		// V2Generator: Section Start : List Item Attributes
		// V2Generator: Section End :List Item Attributes
		#endregion

		#region Constructors

		/// <summary>
		/// Creates a new ShippingInfo object
		/// </summary>
		/// <param name="ID">No information available for ID</param>
		/// <param name="OrderID">No information available for OrderID</param>
		/// <param name="OrderRowByOrderID">DataRow of Table Order</param>
		/// <param name="Type">No information available for Type</param>
		/// <param name="Cost">No information available for Cost</param>
		/// <param name="Address">No information available for Address</param>
		/// <returns></returns>
		// V2Generator: Section Start : Constructor using all the fields
		protected ShippingInfo (
			int ID,
			int OrderID,
			DataRow OrderRowByOrderID,
			int Type,
			decimal Cost,
			string Address)
		{
			// V2Generator: Body Start
			this.m_ID   								 = ID;
			this.m_OrderID  							 = OrderID;
			this.m_OrderRowByOrderID					 = OrderRowByOrderID;
			this.m_Type 								 = Type;
			this.m_Cost 								 = Cost;
			this.m_Address  							 = Address;
			// V2Generator: Body End
		}
		// V2Generator: Section End :Constructor using all the fields

		/// <summary>
		/// Creates a new ShippingInfo object
		/// </summary>
		/// <param name="OrderID">No information available for OrderID</param>
		/// <param name="Type">No information available for Type</param>
		/// <param name="Cost">No information available for Cost</param>
		/// <param name="Address">No information available for Address</param>
		/// <returns></returns>
		// V2Generator: Section Start : Constructor for insert
		protected ShippingInfo (
			int OrderID,
			int Type,
			decimal Cost,
			string Address)
		{
			// V2Generator: Body Start
			this.m_OrderID  						= OrderID;
			this.m_Type 							= Type;
			this.m_Cost 							= Cost;
			this.m_Address  						= Address;
			// V2Generator: Body End
		}
		// V2Generator: Section End :Constructor for insert

		#endregion

		#region Execute Create

		/// <summary>
		/// Creates a new ShippingInfo object based on the given record id from the database
		/// </summary>
		/// <param name="ID">No information available for ID</param>
		/// <returns>null or a new ShippingInfo object</returns>
		// V2Generator: Section Start : ExecuteCreate By ID
		public static ShippingInfo ExecuteCreate (int ID)
		{
			// V2Generator: Body Start
			ShippingInfo				  result     = null;

			DataSet 					  ds  		  = ECommerce.SQL.Content.ShippingInfo.ShippingInfoGetByID(ID);

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
		/// Creates a new ShippingInfo object for inserting a new record into the database
		/// </summary>
		/// <param name="OrderID">No information available for OrderID</param>
		/// <param name="Type">No information available for Type</param>
		/// <param name="Cost">No information available for Cost</param>
		/// <param name="Address">No information available for Address</param>
		/// <returns>null or a new ShippingInfo object</returns>
		/// <Exception cref="System.Exception">
		/// Throws an exception if Address is null. 
		/// </Exception>
		// V2Generator: Section Start : ExecuteCreate Insert
		public static ShippingInfo ExecuteCreate (
			int OrderID,
			int Type,
			decimal Cost,
			string Address)
		{
			// V2Generator: Body Start
			ShippingInfo	result		= null;

			#region Validate the input parameter(s)

			if (Address == null)
			{
				throw new System.Exception("ShippingInfo ExecuteCreate :: Address cannot be null (Database Constraint)");
			}
			#endregion

			result			= new ShippingInfo(OrderID, Type, Cost, Address);
			return result;
			// V2Generator: Body End
		}
		// V2Generator: Section End :ExecuteCreate Insert

		/// <summary>
		/// Creates a new ShippingInfo object
		/// </summary>
		/// <param name="row"></param>
		/// <returns>null or a new ShippingInfo object</returns>
		// V2Generator: Section Start : ExecuteCreate Row
		internal static ShippingInfo ExecuteCreate (DataRow row)
		{
			// V2Generator: Body Start
			return Create(row);
			// V2Generator: Body End
		}
		// V2Generator: Section End :ExecuteCreate Row

		/// <summary>
		/// Creates a new Order object
		/// </summary>
		/// <returns>null or a new Order object</returns>
		// V2Generator: Section Start : ExecuteCreate Primary Table object OrderByOrderID
		public ECommerce.Tables.Content.Order ExecuteCreateOrderByOrderID ()
		{
			// V2Generator: Body Start
			ECommerce.Tables.Content.Order Result = null;
			if (m_OrderRowByOrderID!=null)
			{
				Result  											   = ECommerce.Tables.Content.Order.ExecuteCreate(m_OrderRowByOrderID);
			}
			else
			{
				Result  											   = ECommerce.Tables.Content.Order.ExecuteCreate(m_OrderID);
			}
			return Result;
			// V2Generator: Body End
		}
		// V2Generator: Section End :ExecuteCreate Primary Table object OrderByOrderID


		#endregion

		#region Create

		/// <summary>
		/// Creates a new ShippingInfo object based on the given row obtained from the database. The row is from the table ShippingInfo.
		/// </summary>
		/// <param name="row"></param>
		/// <returns>null or a ShippingInfo object</returns>
		// V2Generator: Section Start : Create section
		private static ShippingInfo Create (DataRow row)
		{
			// V2Generator: Body Start
			ShippingInfo result  			 = null;
			
			int 	   ID  				 = -1;
			int 	   OrderID 			 = -1;
			int 	   Type				 = -1;
			decimal    Cost				 = -1;
			string     Address 			 = null;

			#region get the values
			ID  							 = (int) row[Field_ID];
			if (row[Field_order_id]!=System.DBNull.Value)
			{
				OrderID 					 = (int) row[Field_order_id];
			}
			if (row[Field_type]!=System.DBNull.Value)
			{
				Type						 = (int) row[Field_type];
			}
			if (row[Field_cost]!=System.DBNull.Value)
			{
				Cost						 = (decimal) row[Field_cost];
			}
			if (row[Field_address]!=System.DBNull.Value)
			{
				Address 					 = (string) row[Field_address];
			}
			#endregion
			result  						 = new ShippingInfo(ID, OrderID, row.GetParentRow(Relation_ShippingInfo_OrderByOrderID), Type, Cost, Address);

			return result;
			// V2Generator: Body End
		}
		// V2Generator: Section End :Create section

		#endregion

		#region Relation

		/// <summary>
		/// Creates relationship between ShippingInfo and primary tables
		/// </summary>
		/// <param name="ds"></param>
		/// <returns>null or a ShippingInfoDataTable</returns>
		// V2Generator: Section Start : Relations
		protected static DataTable  AddRelation (DataSet ds)
		{
			// V2Generator: Body Start
			ds.Relations.Add(new DataRelation(
					Relation_ShippingInfo_OrderByOrderID,
					ds.Tables[1].Columns["ID"],
					ds.Tables[0].Columns[Field_order_id],false));
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
		public static List<ShippingInfo> List ()
		{
			// V2Generator: Body Start
			List<ShippingInfo>			list				= new List<ShippingInfo>();
			DataSet				ds					= ECommerce.SQL.Content.ShippingInfo.ShippingInfoList();

			DataTable			dt					= AddRelation(ds);
			for (int i=0; i<dt.Rows.Count; i++)
			{
				ShippingInfo	result				= Create(dt.Rows[i]);
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
		/// <param name="Type">The condition element in the database</param>
		/// <returns></returns>
		// V2Generator: Section Start : ListAllByType
		public static List<ShippingInfo> ListByType (int Type)
		{
			// V2Generator: Body Start
			List<ShippingInfo>			list				= new List<ShippingInfo>();
			DataSet				ds					= ECommerce.SQL.Content.ShippingInfo.ShippingInfoListByType(Type);

			DataTable			dt					= AddRelation(ds);
			for (int i=0; i<dt.Rows.Count; i++)
			{
				ShippingInfo	result				= Create(dt.Rows[i]);
				if (result!=null)
				{
					list.Add(result);
				}
			}

			list.Sort();

			return list;
			// V2Generator: Body End
		}
		// V2Generator: Section End :ListAllByType


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
			ECommerce.SQL.Content.ShippingInfo.ShippingInfoDelete (this.m_ID);
			// V2Generator: Body End
		}
		// V2Generator: Section End :Delete

		/// <summary>
		/// Updates the object members and the corresponding row in the database.
		/// </summary>
		/// <param name="OrderID">No information available for OrderID</param>
		/// <param name="Type">No information available for Type</param>
		/// <param name="Cost">No information available for Cost</param>
		/// <param name="Address">No information available for Address</param>
		/// <returns></returns>
		// V2Generator: Section Start : Update
		protected void Update (
			int OrderID,
			int Type,
			decimal Cost,
			string Address)
		{
			// V2Generator: Body Start
			ECommerce.SQL.Content.ShippingInfo.ShippingInfoUpdate (ID, OrderID, Type, Cost, Address);

			if (this.m_OrderID != OrderID)
			{
				m_OrderRowByOrderID = null;
			}
			this.m_OrderID  			  = OrderID;
			this.m_Type 				  = Type;
			this.m_Cost 				  = Cost;
			this.m_Address  			  = Address;
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
			this.m_ID			= ECommerce.SQL.Content.ShippingInfo.ShippingInfoInsert (this.m_OrderID, this.m_Type, this.m_Cost, this.m_Address);
			// V2Generator: Body End
		}
		// V2Generator: Section End :Insert

		#endregion

		#region Compare

		/// <summary>
		/// Compares the current ShippingInfo object with the given ShippingInfo object
		/// </summary>
		/// <param name="row">The ShippingInfo object to compare with</param>
		/// <returns>The compared difference between the ShippingInfo objects</returns>
		// V2Generator: Section Start : CompareTo
		public int CompareTo (object row)
		{
			// V2Generator: Body Start
			if(row is ShippingInfo)
			{
				ShippingInfo temp = (ShippingInfo) row;
				return ID.CompareTo(temp.ID);
			}
			else
			{
				throw new System.ArgumentException("object is not a ShippingInfo");
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
		/// <param name="obj">The ShippingInfo object to compare with</param>
		/// <returns>True if equal else false</returns>
		// V2Generator: Section Start : Equals
		public override bool  Equals (object obj)
		{
			// V2Generator: Body Start
		bool  result     = false;
		if (this.ID ==((ShippingInfo)obj).ID)
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
		/// No information available for OrderID
		/// </summary>
		public int OrderID
		{
			get{return this.m_OrderID;}
		}
		/// <summary>
		/// No information available for Type
		/// </summary>
		public int Type
		{
			get{return this.m_Type;}
		}
		/// <summary>
		/// No information available for Cost
		/// </summary>
		public decimal Cost
		{
			get{return this.m_Cost;}
		}
		/// <summary>
		/// No information available for Address
		/// </summary>
		public string Address
		{
			get{return this.m_Address;}
		}
		// V2Generator: Section End :Assessors section
		// V2Generator: Section Start : List Item Assessor
		// V2Generator: Section End :List Item Assessor
		#endregion

	}

}

