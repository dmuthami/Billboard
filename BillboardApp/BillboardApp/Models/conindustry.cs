using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BillboardApp.Models
{
    public class conindustry
    {
        [Key]
        public int industryId { get; set; }
        [StringLength(100)]
        public string industry { get; set; }
        [StringLength(50)]
        public string industryCode { get; set; }
        public int life { get; set; }
        public int createbyId { get; set; }
        public DateTime createdt { get; set; }
        public int writebyId { get; set; }
        public DateTime writedt { get; set; }
        public int companyId { get; set; }
    }
}