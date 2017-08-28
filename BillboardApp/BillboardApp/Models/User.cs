using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BillboardApp.Models
{
    public class User
    {
        public int UserID { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string KRA_Pin { get; set; }

        //Role Relationship and Navigation Property
        public int RoleID { get; set; }

        public virtual Role Role { get; set; }
    }
}