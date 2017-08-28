using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BillboardApp.Models
{
    public class conprofiles
    {
        [Key]
        public int profileId { get; set; }
        [StringLength(30)]
        public string profilename { get; set; }
        public int companyId  { get; set; }
        public int life { get; set; }
        public int createbyId { get; set; }
        public DateTime? createdt { get; set; }
        public int writebyId { get; set; }
        public DateTime? writedt { get; set; }
    }
}