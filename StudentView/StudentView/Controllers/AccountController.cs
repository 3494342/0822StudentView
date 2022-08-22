using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using StudentView.Models;

namespace StudentView.Controllers
{
    public class AccountController : Controller
    {
        // GET: Account
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ViewResult Login(FormCollection values)
        {
            return View();
        }

        public ViewResult Register()
        {
            return View();
        }
        [HttpPost]//需要加载的
        public ViewResult Register(RegisterViewModel model)
        {
            return View();
        }
    }
}