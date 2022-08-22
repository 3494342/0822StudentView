using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using StudentView.Models;

namespace StudentView.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        public ActionResult WithoutViewModel()
        {
            Student sOBJ = new Student() {Name = "chen",Number = 1};
            Assessment aOBJ = new Assessment() {CsharpMarks = 39,MVCMarks = 35,BootstrapMarks = 45};
            ViewBag.Assessment = aOBJ;//通过ViewBAG传递数据
            return View(sOBJ);//通过强类型传递
        }
        public ActionResult WithViewModel()
        {
            
            Student sOBJ = new Student() { Name = "chen", Number = 1 };
            Assessment aOBJ = new Assessment() { CsharpMarks = 39, MVCMarks = 35, BootstrapMarks = 45 };
            MarkSheet mobj = new MarkSheet();
            mobj.MyStudent = sOBJ;
            mobj.Assessment = aOBJ;
            return View(mobj);
        }

    }
}