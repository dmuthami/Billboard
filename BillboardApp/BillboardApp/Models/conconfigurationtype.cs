using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BillboardApp.Models
{
    public class conconfigurationtype
    {
        [Key]
        public int configurationTypeId { get; set; }
        [StringLength(50)]
        public string configurationTypeName { get; set; }
        public int life { get; set; }
        public int createbyId { get; set; }
        public DateTime createDt { get; set; }
        public int writebyId { get; set; }
        public DateTime? writedt { get; set; }
        public int companyId { get; set; }
    }
}