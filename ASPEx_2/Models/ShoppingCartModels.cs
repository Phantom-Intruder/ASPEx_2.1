using ASPEx_2.Helpers;
using ECommerce.Tables.Content;
using System;
using System.Collections.Generic;

namespace ASPEx_2.Models
{
    public class ShoppingCartModels
    {
        #region Class members
        public        Dictionary<string, Product>     ProductsList        = new Dictionary<string, Product>();
        #endregion

        #region Properties
        public      decimal         TotalPrice { get; set; }
		#endregion

		#region Model methods

		/// <summary>
		/// Save the shopping cart to database when user requests 
		/// </summary>
		/// <returns></returns>
		public ShoppingCartModels SaveShoppingCartToDatabase()
		{
			ShoppingCartModels			cart				= ShoppingCartModels.GetInstanceOfObject();
			int							accountID			= Int32.Parse(SessionSingleton.Current.CurrentUserSession.ID.ToString());
			Order						order				= Order.ExecuteCreate(accountID, 1, 1, cart.TotalPrice);
			decimal						subtotal			= 0;
			bool						isPresent			= false;
			List<Order>					orderList			= Order.ListByAccountID(accountID);

			order.Insert();

			foreach (Order o in orderList)
			{
				List<OrderItem>			orderItemList		= OrderItem.ListByOrderID(o.ID);

				foreach (OrderItem item in orderItemList)
				{
					item.Delete();
				}
			}

			foreach (string key in cart.ProductsList.Keys)
			{
				Product					product				= cart.ProductsList[key];
				subtotal									= subtotal + product.Price;
				OrderItem				orderItem			= OrderItem.ExecuteCreate(order.ID, product.ID, 1, product.Price, subtotal);

				if (!isPresent)
				{
					orderItem.Insert();
				}
			}

			return cart;
		}

		/// <summary>
		/// Remove an item from the shopping cart
		/// </summary>
		/// <param name="name"></param>
		/// <returns></returns>
		public ShoppingCartModels RemoveShoppingCartItems(string name)
		{
			ShoppingCartModels		cart			= ShoppingCartModels.GetInstanceOfObject();

			cart.TotalPrice							= cart.TotalPrice - cart.ProductsList[name].Price;
			cart.ProductsList.Remove(name);
			return cart;
		}
		#endregion

		#region Class constructor
		private ShoppingCartModels() { }
        #endregion

        #region Singleton class methods
        /// <summary>
        /// Get the running instance of the class
        /// </summary>
        /// <returns></returns>
        public static ShoppingCartModels GetInstanceOfObject()
        {
            if (SessionSingleton.Current.CurrentUserShoppingCart == null)
            {
				SessionSingleton.Current.CurrentUserShoppingCart		= new ShoppingCartModels();
			}

            return SessionSingleton.Current.CurrentUserShoppingCart;
        }

        /// <summary>
        /// Destroy instance of class
        /// </summary>
        public void DestroyInstance()
        {
			SessionSingleton.Current.CurrentUserShoppingCart		= null;
		}
        #endregion

        #region Class methods
        /// <summary>
        /// Get the product by ID and add it to the cart 
        /// </summary>
        /// <param name="id"></param>
        public void AddProductToCart(int id)
        {
            //Find relevant product
            Product         product                  = Product.ExecuteCreate(id);
            //Increment this.TotalPrice by product.price
            this.TotalPrice                          = this.TotalPrice + product.Price;
            //Add product to this.ProductsList
            ProductsList[product.Name]				 = product;
        }
        #endregion
    }
}
