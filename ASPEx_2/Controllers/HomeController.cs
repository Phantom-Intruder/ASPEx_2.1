using ASPEx_2.Models;
using ECommerce.Tables.Content;
using System;
using System.Collections.Generic;
using System.Data;
using System.Web.Mvc;

namespace ASPEx_2.Controllers
{
    public class HomeController : Controller
    {
        #region Display views
        public ActionResult Index()
        {
            return View();
        }
        #endregion
    }
}