using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using StudentView.Models;

namespace StudentView.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        [Route("DropdownHelper")]
        public ViewResult Index()
        {
            return View();
        }

        public ActionResult City()
        {
            List<City> lstCityList = new List<City>()
            {
                new City() {Id = 1, Name = "Delhi"},
                new City() {Id = 2, Name = "Mumbai"},
                new City() {Id = 3, Name = "Shenzhen"}

            };
            ViewBag.CityList = lstCityList;
            return View();
        }
    }
}