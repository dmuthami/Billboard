using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Billboard.Models
{
    public class Backlight
    {
        public int BacklightID { get; set; }
        [Required, DisplayName("Parameter")]
        public int Parameter { get; set; }
        [Required]
        public int Score { get; set; }
    }
}