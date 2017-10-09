using ECommerce.Tables.Content;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ASPEx_2.Models
{
    public class CategoryProductModels
    {
		#region members
		private	List<Product>       listOfProducts                = ECommerce.Tables.Content.Product.List();
        private List<Product>       listOfProductsInACategory     = new List<Product>();
		#endregion

		#region Constructor
		public CategoryProductModels(int id) {
            foreach (Product item in listOfProducts)
            {
                if (item.CategoryID == id)
                {
                    listOfProductsInACategory.Add(item);
                }
            }
}
        #endregion

        #region Getters
		/// <summary>
		/// Get list of all products 
		/// </summary>
		/// <returns></returns>
        public List<Product> GetListOfProducts()
        {
            return this.listOfProducts;
        }

		/// <summary>
		/// Get list of products in a category
		/// </summary>
		/// <returns></returns>
        public List<Product> GetListOfProductsInACategory()
        {
            return this.listOfProductsInACategory;
        }
        #endregion
    }
}