using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BillboardApp.Models
{
    public class conlife
    {
        [Key]
        public int lifeId { get; set; }
        [StringLength(30)]
        public string descriprion { get; set; }
        public int system { get; set; }
        public int life { get; set; }
    }
}