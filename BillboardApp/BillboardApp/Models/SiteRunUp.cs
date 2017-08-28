﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BillboardApp.Models
{
    public class SiteRunUp
    {
        public int SiteRunUpID { get; set; }

        public int DistanceOption { get; set; }

        [Required]
        public int Score { get; set; }
    }
}