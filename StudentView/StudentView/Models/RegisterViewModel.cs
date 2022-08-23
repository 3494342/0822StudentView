using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StudentView.Models
{
    public class RegisterViewModel
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Gender { get; set; }
        public string CityId { get; set; }
        public string Languages { get; set; }
        public bool IsAgree { get; set; }
        public UserStatus userStatus { get; set; }
        public enum UserStatus
        {
            Active= 1,
            Inactive = 2
        }
    }
}