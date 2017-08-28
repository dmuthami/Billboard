using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BillboardApp.Models
{
    public class conroles
    {
        [Key]
        public int roleid { get; set; }
        [StringLength(50)]
        public string rolename { get; set; }
        [StringLength(50)]
        public string homepage { get; set; }
        [StringLength(100)]
        public string dashboard { get; set; }
        public int companyId { get; set; }
        public int life { get; set; }
        public int createbyId { get; set; }
        public DateTime? createdt { get; set; }
        public int writebyId { get; set; }
        public DateTime writedt { get; set; }

    }
}