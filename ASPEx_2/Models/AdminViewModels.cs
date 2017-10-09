using ASPEx_2.Helpers;
using ECommerce.Tables.Content;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace ASPEx_2.Models
{
    public class AdminViewModels
    {   
        #region Properties
        private List<ECommerce.Tables.Content.Category>         CategoriesList { get; set; }
        private List<ECommerce.Tables.Content.Product>          ProductsList { get; set; }
        #endregion

        #region members
        private static      AdminViewModels                         instanceOfObject;

        private IOrderedEnumerable<KeyValuePair<string, int>>       sortedDictionary;
        private Dictionary<string, int>                             productsDictionary              = new Dictionary<string, int>();
        private Dictionary<string, Product>                         categoryProductsDictionary      = new Dictionary<string, Product>();
        private List<KeyValuePair<string, int>>                     listOfItems                     = new List<KeyValuePair<string, int>>();
        private List<KeyValuePair<string, Product>>                 listOfCategoryItems             = new List<KeyValuePair<string, Product>>();
        private List<KeyValuePair<string, Product>>                 listOfCategoryItemsUsed         = new List<KeyValuePair<string, Product>>();
        #endregion

        #region Get data for admin view models 
        /// <summary>
        /// Get the products of a particular category 
        /// </summary>
        /// <param name="id"></param>
        public void GetCategoriesInProduct(int id)
        {
            foreach (KeyValuePair<string, Product> item in listOfCategoryItems)
            {
                if (item.Value.CategoryID == id)
                {
                    listOfCategoryItemsUsed.Add(item);
                }
            }
        }

		public int GetProductId(string name)
		{
			int			returnID		= categoryProductsDictionary[name].ID;
			return returnID;
		}

        /// <summary>
        /// Gets the product by ID
        /// </summary>
        /// <param name="id"></param>
        public void GetProduct(int id)
        {
            listOfCategoryItemsUsed     = new List<KeyValuePair<string, Product>>();
            foreach (KeyValuePair<string, Product> item in listOfCategoryItems)
            {
                if (item.Value.ID == id)
                {
                    listOfCategoryItemsUsed.Add(item);
                }
            }
        }

        /// <summary>
        /// Get category list
        /// </summary>
        /// <returns>category list</returns>
        public List<Category> GetCategoriesList()
        {
            return this.CategoriesList;
        }

        /// <summary>
        /// Get list of category items used 
        /// </summary>
        /// <returns>category items used </returns>
        public List<KeyValuePair<string, Product>> GetListOfCategoryItemsUsed()
        {
            return this.listOfCategoryItemsUsed;
        }

        /// <summary>
        /// Get list of category items
        /// </summary>
        /// <returns>list of category items</returns>
        public List<KeyValuePair<string, Product>> GetListOfCategoryItems()
        {
            return this.listOfCategoryItems;
        }

        /// <summary>
        /// Get list of items 
        /// </summary>
        /// <returns>Get list of items</returns>
        public List<KeyValuePair<string, int>> GetListOfItems()
        {
            return this.listOfItems;
        }

        /// <summary>
        /// Gets a dictionary of products
        /// </summary>
        /// <returns></returns>
        public Dictionary<string, int> GetProductsDictionary()
        {
            return this.productsDictionary;
        }
        #endregion

        #region Singleton class methods 
        /// <summary>
        /// Get the current running instance of the object 
        /// </summary>
        /// <returns></returns>
        public static AdminViewModels GetInstanceOfObject()
        {
            if (instanceOfObject == null)
            {
                instanceOfObject							= new AdminViewModels();
            }
			SessionSingleton.Current.CurrentAdminData		= instanceOfObject;
			instanceOfObject.DestroyInstance();
			instanceOfObject								= new AdminViewModels();
            return instanceOfObject;
        }

		/// <summary>
		/// Destroys the current running instance
		/// </summary>
		public void DestroyInstance()
        {
            instanceOfObject            = null;
        }

        /// <summary>
        /// Constructor for class
        /// </summary>
        private AdminViewModels()
        {
            this.ProductsList                                   = ECommerce.Tables.Content.Product.List();
            this.CategoriesList                                 = ECommerce.Tables.Content.Category.List();

            foreach (Product product in ProductsList)
            {
                productsDictionary[product.Name]                = product.Status;
                categoryProductsDictionary[product.Name]        = product;
            }

            sortedDictionary                                    = from entry in productsDictionary orderby entry.Value descending select entry;
            var         sortedCategoryDict                      = from entry in categoryProductsDictionary orderby entry.Value descending select entry;
            listOfItems                                         = sortedDictionary.ToList();
            listOfCategoryItems                                 = sortedCategoryDict.ToList();
        }
		#endregion

		#region Model methods
		/// <summary>
		/// Saves all the data to the tables without filters
		/// </summary>
		/// <param name="adminViewModels"></param>
		/// <param name="dataTable"></param>
		private void SaveAllDataToTable(DataTable dataTable)
		{
			dataTable.Columns.Add(Constants.CATEGORY_COLUMN, Type.GetType(Constants.DATA_TYPE_STRING));
			dataTable.Columns.Add(Constants.UNITS_SOLD_COLUMN, Type.GetType(Constants.DATA_TYPE_STRING));

			foreach (KeyValuePair<string, Product> item in this.GetListOfCategoryItems())
			{
				DataRow			dataRow						= dataTable.NewRow();

				dataRow[Constants.CATEGORY_COLUMN]			= item.Value.Name;
				dataRow[Constants.UNITS_SOLD_COLUMN]		= item.Value.Status;
				dataTable.Rows.Add(dataRow);
			}

			DataSet				dataSet						= new DataSet();

			dataSet.Tables.Add(dataTable);
			ConvertToExcel(dataTable);
		}

		/// <summary>
		/// Saves all data about the product to a table 
		/// </summary>
		/// <param name="adminViewModels"></param>
		/// <param name="dataTable"></param>
		private void SaveProductDataToTable(DataTable dataTable)
		{
			dataTable.Columns.Add(Constants.CATEGORY_COLUMN, Type.GetType(Constants.DATA_TYPE_STRING));
			dataTable.Columns.Add(Constants.UNITS_SOLD_COLUMN, Type.GetType(Constants.DATA_TYPE_STRING));

			foreach (KeyValuePair<string, Product> item in this.GetListOfCategoryItemsUsed())
			{
				DataRow			dataRow						= dataTable.NewRow();

				dataRow[Constants.CATEGORY_COLUMN]			= item.Value.Name;
				dataRow[Constants.UNITS_SOLD_COLUMN]		= item.Value.Status;
				dataTable.Rows.Add(dataRow);
			}

			DataSet				dataSet						= new DataSet();

			dataSet.Tables.Add(dataTable);
			ConvertToExcel(dataTable);
		}

		/// <summary>
		/// Saves all data about a category to a table 
		/// </summary>
		/// <param name="adminViewModels"></param>
		/// <param name="dataTable"></param>
		private void SaveCategoryDataToTable(DataTable dataTable)
		{
			dataTable.Columns.Add(Constants.CATEGORY_COLUMN, Type.GetType(Constants.DATA_TYPE_STRING));
			dataTable.Columns.Add(Constants.UNITS_SOLD_COLUMN, Type.GetType(Constants.DATA_TYPE_STRING));

			foreach (KeyValuePair<string, Product> item in this.GetListOfCategoryItemsUsed())
			{
				DataRow			dataRow						= dataTable.NewRow();
				dataRow[Constants.CATEGORY_COLUMN]			= item.Value.Name;
				dataRow[Constants.UNITS_SOLD_COLUMN]		= item.Value.Status;
				dataTable.Rows.Add(dataRow);
			}

			DataSet				dataSet						= new DataSet();

			dataSet.Tables.Add(dataTable);
			ConvertToExcel(dataTable);
		}

		/// <summary>
		/// Get data about a product using product ID
		/// </summary>
		/// <param name="productField"></param>
		/// <param name="adminViewModels"></param>
		/// <returns></returns>
		public AdminViewModels GetProductData(string productField, AdminViewModels adminViewModels)
		{
			int			ID			= adminViewModels.GetProductId(productField);
			adminViewModels.DestroyInstance();
			adminViewModels			= AdminViewModels.GetInstanceOfObject();
			adminViewModels.GetProduct(ID);
			return adminViewModels;
		}

		/// <summary>
		/// Gets a list of category items used 
		/// </summary>
		/// <param name="categoryField"></param>
		/// <param name="adminViewModels"></param>
		/// <returns></returns>
		public AdminViewModels GetCategoryDetails(string categoryField, AdminViewModels adminViewModels)
		{
			adminViewModels.DestroyInstance();
			adminViewModels					= AdminViewModels.GetInstanceOfObject();
			adminViewModels.GetCategoriesInProduct(Int32.Parse(categoryField));
			listOfCategoryItemsUsed			= adminViewModels.GetListOfCategoryItemsUsed();
			return adminViewModels;
		}

		public void SaveTableToFile(string typeOfModel)
		{
			DataTable		dataTable		= new DataTable();
			if (typeOfModel == Constants.MODEL_CATEGORY)
			{
				typeOfModel					= "";
				this.SaveCategoryDataToTable(dataTable);
			}
			else if (typeOfModel == Constants.MODEL_PRODUCT)
			{
				typeOfModel					= "";
				this.SaveProductDataToTable(dataTable);
			}
			else
			{
				this.SaveAllDataToTable(dataTable);
			}
		}
		#endregion

		#region Helpers

		/// <summary>
		/// Converts data table to Excel file and saves it 
		/// </summary>
		/// <param name="dt"></param>
		private void ConvertToExcel(DataTable dt)
		{
			string		attachment							= Constants.FILE_NAME;
			HttpContext.Current.Response.ClearContent();
			HttpContext.Current.Response.AddHeader(Constants.CONTENT_DISPOSITION, attachment);
			HttpContext.Current.Response.ContentType		= Constants.APPLICATION_VND;
			string		tab									= "";
			foreach (DataColumn dc in dt.Columns)
			{
				HttpContext.Current.Response.Write(tab + dc.ColumnName);
				tab											= "\t";
			}
			HttpContext.Current.Response.Write("\n");
			int			i									=0;
			foreach (DataRow dr in dt.Rows)
			{
				tab											= "";
				for (i = 0; i < dt.Columns.Count; i++)
				{
					HttpContext.Current.Response.Write(tab + dr[i].ToString());
					tab										= "\t";
				}
				HttpContext.Current.Response.Write("\n");
			}
			HttpContext.Current.Response.End();
		}

		#endregion
	}
}