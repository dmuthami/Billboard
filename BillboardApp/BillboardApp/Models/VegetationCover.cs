﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BillboardApp.Models
{
    public class VegetationCover
    {
        public int VegetationCoverID { get; set; }

        [Required]
        public string Parameter { get; set; }

        [Required]
        public double Score { get; set; }
    }
}