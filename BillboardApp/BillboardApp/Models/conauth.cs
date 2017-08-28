using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BillboardApp.Models
{
    public class conauth
    {
        [Key]
        public int authId { get; set; }
        [StringLength(200)]
        public string username { get; set; }
        [StringLength(200)]
        public string password { get; set; }
        [StringLength(50)]
        public string loginKey { get; set; }
        public int userId { get; set; }

        public int profileId { get; set; }
        public int statusId { get; set; }

        public int customerId { get; set; }
        public int supplierId { get; set; }

        public int employeeId { get; set; }
        public int branchId { get; set; }

        public int life { get; set; }
        public int createbyId { get; set; }

        public DateTime createdt { get; set; }
        public int writebyId { get; set; }

        public int writedt { get; set; }
        public int companyId { get; set; }
    }
}