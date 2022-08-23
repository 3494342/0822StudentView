using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace StudentView.Models
{
    public class Employee
    {
     

        [Display(Name = "employee id")]//修改显示的名称
        public int EmployeeId { get; set; }
        [DataType(DataType.MultilineText)]//多行
        public string Address { get; set; }
        public string Name { get; set; }
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [DisplayFormat(DataFormatString = "{0:0.00}")]
        public float salary { get; set; }
    }
}