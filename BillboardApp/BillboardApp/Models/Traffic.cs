using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BillboardApp.Models
{
    public class Traffic
    {
        public int TrafficID { get; set; }
        [Required, DisplayName("Parameter")]
        public int Paramameter { get; set; }
        [Required]
        public int Score { get; set; }
    }
}