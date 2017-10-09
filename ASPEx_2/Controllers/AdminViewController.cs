using ASPEx_2.Models;
using ASPEx_2.Helpers;
using ECommerce.Tables.Content;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ASPEx_2.Controllers
{
    public class AdminViewController : Controller
    {
        #region Class fields
        public static string typeOfModel        = "";

        public List<KeyValuePair<string, Product>> listOfCategoryItemsUsed =
                new List<KeyValuePair<string, Product>>();
        #endregion

        #region Display views
        // GET: AdminView
        public ActionResult AdminView()
        {
			
			AdminViewModels adminViewModels         = AdminViewModels.GetInstanceOfObject();
			
            return View(adminViewModels);
        }
        #endregion

        #region Post methods

        [HttpPost]
        public ActionResult AdminView(string categoryField, string productField, string saveTableField)
        {

            AdminViewModels adminViewModels                         = AdminViewModels.GetInstanceOfObject();

            if (categoryField != null)
			{
				adminViewModels										= adminViewModels.GetCategoryDetails(categoryField, adminViewModels);

				ViewBag.typeOfModel									= Constants.MODEL_CATEGORY;
				typeOfModel											= Constants.MODEL_CATEGORY;
			}
			else if (productField != null)
			{
				adminViewModels										= adminViewModels.GetProductData(productField, adminViewModels);

				ViewBag.typeOfModel									= Constants.MODEL_PRODUCT;
				typeOfModel											= Constants.MODEL_PRODUCT;
			}
			else if (saveTableField != null)
			{
				SessionSingleton.Current.CurrentAdminData.SaveTableToFile(typeOfModel);
			}
			else
            {
                ViewBag.typeOfModel                                 = Constants.CATEGORY_TYPE_NONE;
            }
			return View(adminViewModels);
		}
		#endregion
	}
}