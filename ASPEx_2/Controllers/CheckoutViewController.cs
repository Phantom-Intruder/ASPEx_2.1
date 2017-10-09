using ASPEx_2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ASPEx_2.Controllers
{
    public class CheckoutViewController : Controller
    {
        // GET: CheckoutView
        #region Display views
        public ActionResult CheckoutView()
        {
            return View();
        }
        #endregion

        #region Post methods
        [HttpPost]
        public ActionResult CheckoutView(string isUser)
        {
            if (isUser != null)
            {
                UserModel userModel = new UserModel();

                return PartialView("_UserView", userModel);
            }
            else
            {
                ShoppingCartModels cart = ShoppingCartModels.GetInstanceOfObject();

                return PartialView("_ProductView", cart);
            }
        }
        #endregion
    }
}