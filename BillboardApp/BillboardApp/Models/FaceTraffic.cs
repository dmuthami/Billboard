﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BillboardApp.Models
{
    public class FaceTraffic
    {
        public int FaceTrafficID { get; set; }

        [Required, DisplayName("Parameter")]
        public string Parameter { get; set; }

        [Required]
        public int Score { get; set; }
    }
}