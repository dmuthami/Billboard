using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Billboard.Models
{
    public class Role
    {
        public Role()
        {
            this.Users = new HashSet<User>();
        }
        public int RoleID { get; set; }

        public int Name { get; set; }

        public virtual ICollection<User> Users { get; set; }
    }
}