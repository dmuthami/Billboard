using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace Billboard.ViewModels
{
    public class BrandView
    {
        public int BrandID { get; set; }
        [DisplayName("Brand Name")]
        public string BrandName { get; set; }
        [DisplayName("Brand Owner Name")]
        public string BrandOwnerName { get; set; }
    }
}