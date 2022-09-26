using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.Mvc;
using StudentView.Models;

namespace StudentView.Controllers
{
    public class TeacherController : Controller
    {
        // GET: Teacher
        public ViewResult Index()
        {
            return View();
        }
        //explicit validation
        [HttpPost]
        public ViewResult Index(Teacher obj)//对于传递的数据进行解析
        {
            if (!ModelState.IsValidField("Time"))
            {
                ModelState.AddModelError("Time","Invalid Time");
            }
            if (string.IsNullOrEmpty(obj.Name))
            {
                ModelState.AddModelError("Name", "Empty Name");
            }
            else
            {
                if(obj.Name.Length > 20 )
                    ModelState.AddModelError("Name", "Name is too long");
            }

            Regex conRegex = new Regex(@"^\d{10}$");
            if (!conRegex.IsMatch(obj.Tele))
            {
                ModelState.AddModelError("Tele","Invalid Contact No.");
            }

            if(ModelState.IsValid)
                return View("Success");
            else
            {
                ModelState.AddModelError("","Invalid Teacher");
                return View();
            }
        }
        
        public JsonResult ChkDuplicate(string teacherName)//没有在teacher控制器中？
        {
            string[] teachers = { "chen", "ao" };
            if (teachers.Contains(teacherName))
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
            else
            {
                return Json(true, JsonRequestBehavior.AllowGet);
            }
        }

    }
    
}