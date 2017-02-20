using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCControllerAuthTest.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Index(string ReturnUrl)
        {
            if (Session["UserName"] != null)
            {
                return RedirectToAction("Index", "Home");
            }
            ViewBag.Url = ReturnUrl;
            return View();
        }

        [HttpPost]
        public ActionResult Index(string name, string password, string returnUrl)
        {
            /*
                添加验证用户名密码代码
            */
            Session["UserName"] = name;
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
            Session["UserName"] = null;
            return RedirectToAction("Index", "Home");
        }
    }
}