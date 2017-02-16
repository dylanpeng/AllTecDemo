using MVCAuthorizeTest.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCAuthorizeTest.Controllers
{
    public class LoginController : Controller
    {
        [AllowAnonymous]
        // GET: Login
        public ActionResult Index(string returnUrl)
        {
            ViewBag.ReturnUrl = returnUrl;
            return View();
        }

        [HttpPost]
        [AllowAnonymous]
        public ActionResult Index(string name, string password, bool rememberMe, string returnUrl)
        {
            var account = new UserData()
            {
                UserName = name,
                UserId = 110,
                Roles = new List<int>() { 1, 2, 3 }
            };
            HttpFormsAuthentication.SetAuthenticationCoolie(account, rememberMe ? 7 : 0);
            if (Url.IsLocalUrl(returnUrl) && returnUrl.Length > 1 && returnUrl.StartsWith("/") && !returnUrl.StartsWith("//") && !returnUrl.StartsWith("/\\"))
            {
                return Redirect(returnUrl);
            }
            else
            {
                return RedirectToAction("Index", "Home");
            }
        }

        // POST: /Account/LogOff
        [HttpPost]
        public ActionResult LogOff()
        {
            System.Web.Security.FormsAuthentication.SignOut();
            return RedirectToAction("Index", "Home");
        }
    }
}