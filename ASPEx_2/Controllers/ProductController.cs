using ASPEx_2.Helpers;
using ASPEx_2.Models;
using ECommerce.Tables.Content;
using System;
using System.IO;
using System.Web;
using System.Web.Mvc;

namespace ASPEx_2.Controllers
{
    public class ProductController : Controller
    {
		
		#region Properties

		public ProductModels TempSession
		{
			get
			{
				ProductModels					result					=  null;

				if(Session[Constants.SESSION_NAME_CATEGORY] != null)
				{
					result												= Session[Constants.SESSION_NAME_CATEGORY] as ProductModels;
				}

				return  result;
			}
			set
			{
				Session[Constants.SESSION_NAME_CATEGORY]				= value;
			}
		}

		#endregion

		#region Display views
		// GET: ProductList
		public ActionResult List()
        {
            return View(ProductModels.List());
        }
        public ActionResult Edit(int? id)
        {
			ProductModels				result					= null;

			if(this.TempSession != null &&
				id.HasValue &&
				this.TempSession.ID == id.Value)
			{
				result = this.TempSession;
				CheckIfIdHasValue(id, result);
			}
			else
			{
				Session.Remove(Constants.SESSION_NAME_CATEGORY);				
				result											= ProductModels.ExecuteCreate(id);
				CheckIfIdHasValue(id, result);
				this.TempSession								= result;
			}

			if(result == null)
			{
				return new HttpNotFoundResult();
			}

            return View(result);
        }

		private static void CheckIfIdHasValue(int? id, ProductModels result)
		{
			if (id.HasValue)
			{
				result.EditField = "true";
			}
		}
        #endregion

        #region Get methods
        
		[HttpGet]
        public ActionResult Delete(string id)
        {
            Product.Delete(Int32.Parse(id));

            return View();
        }

        [HttpGet]
        public ActionResult Details(string id)
		{
			ProductModels productModels = new ProductModels();

			SessionSingleton.Current.CurrentProduct			= productModels;
			SessionSingleton.Current.CurrentProduct.ShowProductFromId(id);
			return View(SessionSingleton.Current.CurrentProduct);
		}
		#endregion

		#region Post methods
		[ValidateAntiForgeryToken]
		[HttpPost]
		public ActionResult Edit(ProductModels model)
        {
			if(ModelState.IsValid)
			{
				this.TempSession.Sync(model);

				if(this.TempSession.Validate(ModelState))
				{
					this.TempSession.Save();
					Session.Remove(Constants.SESSION_NAME_CATEGORY);
					return RedirectToAction("List");
				}
			}
			
            return View(this.TempSession);
        }

		[HttpPost]
        public ActionResult List(string idField)
		{
			ProductModels		product						= new ProductModels();
			SessionSingleton.Current.CurrentProduct			= product;

			SessionSingleton.Current.CurrentProduct.AddProductToShoppingCart(idField);

			return PartialView("_AddedCorrectlyView");
		}
		#endregion
	}

}