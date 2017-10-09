using ECommerce.Tables.Content;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Web;
using ECommerce.Tables.Utility.System;
using ASPEx_2.Helpers;
using System.Web.Mvc;
using Volume.Toolkit.Paths;

namespace ASPEx_2.Models
{
	public class ProductModels
    {
		#region Members
		private int						id						= Constants.DEFAULT_VALUE_INT;
		private string					name					= String.Empty;
		private string					description				= String.Empty;
		private string					fileName				= String.Empty;
		private	string					category				= String.Empty;
		private decimal					price					= 0;
		private List<string>			categoryNamesList		= new List<string>();
		private Product					entity					= null;
		private HttpPostedFileBase		fileBase				= null;
		#endregion

        #region Properties
        private List<ECommerce.Tables.Content.Product> ProductsList { get; set; }
        
		[Key]
		public int ID
		{
			get { return this.id; }
		}

        [Required]
        [Display(Name = "Name")]
		[StringLength(30)]
        public string Name {
			get { return this.name; }
			set { this.name = value; }
		}

        [Required]
		[Display(Name = "Description")]
		[DataType(DataType.MultilineText)]
		public string Description
		{
			get { return this.description; }
			set { this.description = value; }
		}

        [Required]
        [Display(Name = "Price")]
        public decimal Price
		{
			get { return this.price; }
			set { this.price = value; }
		}

        [Required]
        [Display(Name = "Category")]
        public string Category
		{
			get { return this.category; }
			set { this.category = value; }
		}

        public HttpPostedFileBase FileUpload {
			get { return this.fileBase; }
			set { this.fileBase = value; }
		}

		[Required]
        public List<string> CategoryNamesList
		{
			get { return this.categoryNamesList; }
			set { this.categoryNamesList = value; }
		}

        [Required]
        public string FilePath {
			get { return this.fileName; }
			set { this.fileName = value; }
		}

        public string EditField { get; set; }

		public string FolderPath
		{
			get
			{
				return  PathUtility.CombinePaths(Config.StoragePath, Config.FOLDER_PRODUCT);
			}
		}
		#endregion

		#region Model methods

		/// <summary>
		/// Create product using model
		/// </summary>
		/// <param name="product"></param>
		public void CreateProduct(Product product)
		{
			this.Name				= product.Name;
			this.Description		= product.Description;
			this.Price				= product.Price;
			this.FilePath			= product.ImageName;
			this.EditField			= "true";
		}

		/// <summary>
		/// Create and insert product
		/// </summary>
		/// <param name="model"></param>
		/// <param name="filePathField"></param>
		/// <param name="idOfCategoryField"></param>
		private void CreateAndInsertNewProduct(string filePathField, int idOfCategoryField)
		{

			Product			record			= Product.ExecuteCreate(Int32.Parse(idOfCategoryField + ""),
																	this.Name,
																	this.Description,
																	this.Price,
																	filePathField, 1, 50, 51);
			record.Insert();
		}

		/// <summary>
		/// Copy selected image into filestore
		/// </summary>
		/// <param name="model"></param>
		/// <returns></returns>
		private string CopyFileIntoFilestore()
		{
			string					filePathField;
			HttpPostedFileBase		file						= this.FileUpload;

			string					directoryWithFolder			= Volume.Toolkit.Paths.PathUtility.CombinePaths(Config.StorageUrl, Config.FOLDER_PRODUCT);
			string[]				directories					= Directory.GetDirectories(directoryWithFolder);
			int						folderNumber				= directories.Length;
			folderNumber										= folderNumber + 1;
			string					targetPath					= directoryWithFolder + "\\" + folderNumber;
			string					destFile					= Volume.Toolkit.Paths.PathUtility.CombinePaths(targetPath, "" + folderNumber + ".png");
			if (!System.IO.Directory.Exists(targetPath))
			{
				System.IO.Directory.CreateDirectory(targetPath);
				file.SaveAs(destFile);
			}
			else
			{
				Console.WriteLine("Source path does not exist!");
			}
			filePathField								= "/" + Config.FOLDER_PRODUCT + "/" + folderNumber + "/" + folderNumber + ".png";
			return filePathField;
		}

		/// <summary>
		/// Get the category ID of a particular product
		/// </summary>
		/// <param name="model"></param>
		/// <param name="idOfCategoryField"></param>
		/// <param name="index"></param>
		private void SetCategoryID(ref int idOfCategoryField, ref int index)
		{
			foreach (Category category in this.GetCategoryList())
			{
				if (category.Name.ToString().Equals(this.Category))
				{
					idOfCategoryField		= category.ID;
				}
				index						= index + 1;
			}
		}

		/// <summary>
		/// Show the product using ID
		/// </summary>
		/// <param name="id"></param>
		public void ShowProductFromId(string id)
		{
			Product product = Product.ExecuteCreate(Int32.Parse(id));
			if (product != null)
			{
				this.Name = product.Name;
				this.Description = product.Description;
				this.Price = product.Price;
				this.FilePath = product.ImageName;
			}
		}

		/// <summary>
		/// Custom validation for model
		/// </summary>
		/// <returns></returns>
		public bool Validation()
		{
			if ((this.EditField == null) && (this.FileUpload == null))
			{
				return false;
			}
			return true;
		}

		/// <summary>
		/// Save the record
		/// </summary>
		/// <param name="IDNew"></param>
		public void Save(int IDNew)
		{
			string		filePathField			= "";
			int			idOfCategoryField		= 0;
			int			index					= 1;

			this.SetCategoryID(ref idOfCategoryField, ref index);
			if (this.FileUpload != null)
			{
				filePathField					= this.CopyFileIntoFilestore();
			}
			else
			{
				filePathField					= this.FilePath;
			}
			if (this.EditField == null)
			{
				this.CreateAndInsertNewProduct(filePathField, idOfCategoryField);

			}
			else
			{

				Product			record			= Product.ExecuteCreate(Int32.Parse(idOfCategoryField + ""),
																					this.Name,
																					this.Description,
																					this.Price,
																					filePathField, 1, 50, 51);
				record.Update(IDNew, record);

			}
		}

		/// <summary>
		/// Adds a selected product to the cart
		/// </summary>
		/// <param name="idField"></param>
		public void AddProductToShoppingCart(string idField)
		{
			int						id						= Int32.Parse(idField);
			ShoppingCartModels		cart					= ShoppingCartModels.GetInstanceOfObject();
			Product					productToBeUpdated		= Product.ExecuteCreate(id);
			int						newQuantity				= productToBeUpdated.Status + 1;
			int						idfield					= Int32.Parse(idField);
			Product					product					= Product.ExecuteCreate(productToBeUpdated.CategoryID,
																					productToBeUpdated.Name,
																					productToBeUpdated.Description,
																					productToBeUpdated.Price,
																					productToBeUpdated.ImageName,
																					newQuantity,
																					productToBeUpdated.CreatedAccountID,
																					productToBeUpdated.ModifiedAccountID);

			cart.AddProductToCart(id);
			product.Update(idfield, product);
		}
		public List<string> GetCategoryNamesList()
        {
			CategoryNamesList		= new List<string>();
            foreach (Category item in ECommerce.Tables.Content.Category.List())
            {
                CategoryNamesList.Add(item.Name);
            }
            return this.CategoryNamesList;
        }
		#endregion

        #region Class constructor 
        public ProductModels()
        {
            
        }

		private ProductModels(Product entity)
		{

			this.id								= entity.ID;
			this.name							= entity.Name;
			this.description					= entity.Description;
			this.fileName						= entity.ImageName;
			this.price							= entity.Price;
			this.category						= entity.ExecuteCreateCategoryByCategoryID().Name;
			this.categoryNamesList				= GetCategoryNamesList();
			this.entity							= entity;

		}
        #endregion

		#region Execute Create

		public static ProductModels ExecuteCreate(int? id)
		{
			ProductModels 				result				= null;

			if(id.HasValue)
			{
				Product					entity				= Product.ExecuteCreate(id.Value);

				if(entity != null)
				{
					result										= new ProductModels(entity);
				}
			}
			else
			{
				result											= new ProductModels();
			}

			return result;
		}

		#endregion

		#region List 

		public static List<ProductModels> List()
		{
			List<ProductModels>						result				= new List<ProductModels>();
			List<Product>							list				= Product.List();

			foreach (Product item in list)
			{
				result.Add(new ProductModels(item));
			}

			return result;
		}

		#endregion

		#region Methods

		#region Validate
		
		public bool Validate(ModelStateDictionary state)
		{
			bool			result					= true;

			if(String.IsNullOrEmpty(this.fileName))
			{
				result								&= false;
				state.AddModelError("Filename", "Please upload an image");
			}

			return  true;
		}

		#endregion

		#region Sync

		public void Sync(ProductModels model)
		{
			this.name				= model.Name;
			this.description		= model.Description;
			this.fileBase			= model.FileUpload;
			this.fileName			= model.FilePath;
			this.category			= model.category;
			this.price				= model.price;
			this.categoryNamesList	= model.categoryNamesList;
		}

		#endregion

		#region Save

		public void Save()
		{
			string		filePathField			= String.Empty;
			int			idOfCategoryField		= 0;
			int			index					= 1;

			this.SetCategoryID(ref idOfCategoryField, ref index);
			if (this.fileBase != null)
			{
				filePathField					= this.CopyFileIntoFilestore();
			}
			else
			{
				filePathField					= this.FilePath;
			}
			if (this.EditField == null)
			{
				this.CreateAndInsertNewProduct(filePathField, idOfCategoryField);

			}
			else
			{
				Product			record			= Product.ExecuteCreate(Int32.Parse(idOfCategoryField + ""),
																					this.Name,
																					this.Description,
																					this.Price,
																					filePathField, 1, 50, 51);
				record.Update(this.ID, record);

			}
		}

		#endregion 


		#endregion

        #region Getters
        public List<ECommerce.Tables.Content.Product> GetProductsList()
        {
            return ECommerce.Tables.Content.Product.List();
        }

        public List<ECommerce.Tables.Content.Category> GetCategoryList()
        {
            return ECommerce.Tables.Content.Category.List();
        }
		
		#endregion
	}
}