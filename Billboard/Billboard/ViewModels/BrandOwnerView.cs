using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace Billboard.ViewModels
{
    public class BrandOwnerView
    {
        public int BrandOwnerID { get; set; }
        [DisplayName("Brand Owner Name")]
        public string BrandOwnerName { get; set; }
        [DisplayName("Brand Owner Contact")]
        public string BrandOwnerContact { get; set; }
        [DisplayName("Industry Name")]
        public string IndustryName { get; set; }
    }
}