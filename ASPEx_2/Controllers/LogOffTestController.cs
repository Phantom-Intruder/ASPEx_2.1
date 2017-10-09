using ASPEx_2.Models;
using System.Web.Mvc;

namespace ASPEx_2.Controllers
{
    public class LogOffTestController : Controller
    {
        #region Account logoff 
        // GET: LogOff
        public ActionResult Index()
        {
            return View();
        }
        //
        // POST: /Account/LogOff
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult LogOff()
        {
            ShoppingCartModels      cart        = ShoppingCartModels.GetInstanceOfObject();
			AdminViewModels			model		= AdminViewModels.GetInstanceOfObject();

            cart.DestroyInstance();
			model.DestroyInstance();

			Session.Clear();

            return RedirectToAction("Index", "Home");
        }
        #endregion
    }
}