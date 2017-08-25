using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Billboard.Models
{
    public class VegetationCover
    {
        public int VegetationCoverID { get; set; }

        [Required,DisplayName("Vegetation Type")]
        public string Type { get; set; }

        [Required]
        public double Score { get; set; }
    }
}