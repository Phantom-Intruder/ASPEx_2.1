using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ASPEx_2.Helpers;
using ASPEx_2.Models;

namespace ASPEx_2.Controllers
{
    public class YasaCategoryController : Controller
    {

		#region Properties

		public YasaCategoryModel TempSession
		{
			get
			{
				YasaCategoryModel					result				=  null;

				if(Session[Constants.SESSION_NAME_CATEGORY] != null)
				{
					result												= Session[Constants.SESSION_NAME_CATEGORY] as YasaCategoryModel;
				}

				return  result;
			}
			set
			{
				Session[Constants.SESSION_NAME_CATEGORY]				= value;
			}
		}

		#endregion

		#region Action Methods

		// GET: YasaCategory
		public ActionResult Index()
        {
            return View(YasaCategoryModel.List());
        }

		public ActionResult Editor(int? id)
        {
			YasaCategoryModel				result				= null;

			if(this.TempSession != null &&
				id.HasValue &&
				this.TempSession.ID == id.Value)
			{
				result											= this.TempSession;
			}
			else
			{
				Session.Remove(Constants.SESSION_NAME_CATEGORY);
				result											= YasaCategoryModel.ExecuteCreate(id);
				this.TempSession								= result;
			}

			if(result == null)
			{
				return new HttpNotFoundResult();
			}

            return View(result);
        }

		[ValidateAntiForgeryToken]
		[HttpPost]
		public ActionResult Editor(YasaCategoryModel model)
        {
			if(ModelState.IsValid)
			{
				this.TempSession.Sync(model);

				if(this.TempSession.Validate(ModelState))
				{
					this.TempSession.Save();
					Session.Remove(Constants.SESSION_NAME_CATEGORY);
					return RedirectToAction("Index");
				}
			}
			
            return View(this.TempSession);
        }


		#endregion 
	}
}