using ASPEx_2.Helpers;
using ASPEx_2.Models;
using ECommerce.Tables.Content;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ASPEx_2.Controllers
{
    public class ShoppingCartController : Controller
    {
        #region Display views
        // GET: ShoppingCart
        public ActionResult ShoppingCartView()
        {
            ShoppingCartModels cart = ShoppingCartModels.GetInstanceOfObject();

            return View(cart);
        }
        #endregion

        #region Post methods
        [HttpPost]
        public ActionResult ShoppingCartView(string name)
        {
			ShoppingCartModels		cart			= ShoppingCartModels.GetInstanceOfObject();
            if (name != null)
			{				
				cart								= cart.RemoveShoppingCartItems(name);
			}
			else
			{
				cart								= cart.SaveShoppingCartToDatabase();
			}
			return View(cart);

		}
		#endregion
	}
}