using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BillboardApp.Models
{
    public class conuserroles
    {
        [Key]
        public int userroleid { get; set; }
        public int userid { get; set; }

        public int roleid { get; set; }
        [Required]
        public int mainrole { get; set; }

        public int companyId { get; set; }

        public int life { get; set; }

        public int createbyId { get; set; }

        public DateTime? createdt { get; set; }

        public int writebyId { get; set; }

        public DateTime? writedt { get; set; }

    }
}