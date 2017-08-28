using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BillboardApp.Models
{
    public class conobjectscaption
    {
        [Key]
        public int objectCaptionId { get; set; }
        public int objectId { get; set; }
        public int industryId { get; set; }
        public string objectCaptionName { get; set; }
        [StringLength(100)]
        public string icons { get; set; }
        [StringLength(50)]
        public string islarge { get; set; }
        public int quicklink { get; set; }
        public string setpath { get; set; }
        public string reportpath { get; set; }
        public int objectCaptionSort { get; set; }
        public int available { get; set; }
        public int life { get; set; }
        public int createbyId { get; set; }
        public DateTime? createdt { get; set; }
        public int writebyId { get; set; }
        public DateTime? writedt { get; set; }
        public int companyId { get; set; }
    }
}