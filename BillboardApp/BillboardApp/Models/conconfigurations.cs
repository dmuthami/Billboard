using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BillboardApp.Models
{
    public class conconfigurations
    {
        [Key]
        public int configurationsId { get; set; }
        [StringLength(50)]
        public string configkey { get; set; }
        public string configvalue { get; set; }
        public int configurationTypeId { get; set; }
        public int life { get; set; }
        public int createbyId { get; set; }
        public DateTime? createdt { get; set; }
        public int writebyId { get; set; }
        public DateTime writedt { get; set; }
        public int companyId { get; set; }
    }
}