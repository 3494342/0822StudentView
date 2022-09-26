using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using StudentView.CheckRequireAttribute;

namespace StudentView.Models
{
    public class Teacher
    {
        [Remote(action: "ChkDuplicate", controller: "Account",ErrorMessage = "Teacher name already exists")]
        [Required(ErrorMessage = "Invalid name")]
        public string Name { get; set; }
        [Range(18,100)]
        public int Age { get; set; }
        [RegularExpression(@"^\d{10}$")]
        public string Tele { get; set; }
        [CheckRequired(ErrorMessage = "Please ")]
        public bool valid { get; set; }
        public DateTime Time { get; set; }
      
    }
}