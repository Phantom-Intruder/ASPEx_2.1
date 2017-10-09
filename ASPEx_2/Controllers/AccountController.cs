using ASPEx_2.Helpers;
using ASPEx_2.Models;
using ECommerce.Tables.Active.HR;
using System.Web.Mvc;

namespace ASPEx_2.Controllers
{
	[Authorize]
    public class AccountController : Controller
    {
        #region Account login 
        //
        // GET: /Account/Login
        [AllowAnonymous]
        public ActionResult Login(string returnUrl)
        {
            ViewBag.ReturnUrl           = returnUrl;
            ViewBag.LoginMessage        = Constants.ENTER_LOGIN_MESSAGE;
            ViewBag.LoginFailed         = false;
            return View();
        }

        //
        // POST: /Account/Login
        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public ActionResult Login(LoginViewModel model, string returnUrl)
        {
                if (ModelState.IsValid)
                {
					if (Account.ExecuteCreateByEmail(model.Email) != null)
					{
						Account					record							= Account.GetAccountByEmail(model.Email);

                        string					salt							= record.Salt;
                        string					encodingPasswordString			= Helper.EncodePassword(model.Password, salt);
                        

                        if (encodingPasswordString == record.Password)
                        {
                            ViewBag.LoginFailed									= false;
							model.InitialiseUserAndReadyCart(record);

							if (record.Role == 1)
                            {
                                return RedirectToAction(Constants.CONTROLLER_ADMIN, Constants.CONTROLLER_ADMIN);
                            }
                            else
                            {
                                return RedirectToAction(Constants.CONTROLLER_PRODUCT_LIST, Constants.CONTROLLER_PRODUCT);
                            }
                        }
						else
						{
							ViewBag.LoginMessage									= Constants.WRONG_USERNAME;
							ViewBag.LoginFailed										= true;
						}
					}
					else
					{
						ViewBag.LoginMessage										= Constants.WRONG_USERNAME;
						ViewBag.LoginFailed											= true;
						return View();
					}
                }
                return View(model);
        }
        #endregion

        #region Account register
        //
        // GET: /Account/Register
        [AllowAnonymous]
        public ActionResult Register()
        {
            ViewBag.RegistrationMessage         = Constants.REGISTRATION_MESSAGE;
            ViewBag.RegistrationFailed          = false;
            return View();
        }

        //
        // POST: /Account/Register
        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public ActionResult Register(RegisterViewModel model)
        {
            if (ModelState.IsValid)
			{				
				if(Account.ExecuteCreateByEmail(model.Email)== null)
				{
					model.CreateAndInsertAccount();
					ViewBag.RegistrationFailed							= false;

					return RedirectToAction(Constants.CONTROLLER_INDEX, Constants.CONTROLLER_HOME);
				}
				else
				{
					model.Role											= 0;
                    ViewBag.RegistrationMessage							= Constants.EMAIL_IN_USE;
                    ViewBag.RegistrationFailed							= true;
                    return View();
				}
            }
            // If we got this far, something failed, redisplay form
            return View(model);
        }
		#endregion

		#region Helpers


		private ActionResult RedirectToLocal(string returnUrl)
        {
            if (Url.IsLocalUrl(returnUrl))
            {
                return Redirect(returnUrl);
            }
            return RedirectToAction(Constants.CONTROLLER_INDEX, Constants.CONTROLLER_HOME);
        }

        internal class ChallengeResult : HttpUnauthorizedResult
        {
            public ChallengeResult(string provider, string redirectUri)
                : this(provider, redirectUri, null)
            {
            }

            public ChallengeResult(string provider, string redirectUri, string userId)
            {
                LoginProvider		= provider;
                RedirectUri			= redirectUri;
                UserId				= userId;
            }

            public string LoginProvider { get; set; }
            public string RedirectUri { get; set; }
            public string UserId { get; set; }

        }
        #endregion
    }
}