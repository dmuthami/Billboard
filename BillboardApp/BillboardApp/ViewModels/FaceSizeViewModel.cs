using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BillboardApp.ViewModels
{
    public class FaceSizeViewModel
    {
        public int FaceSizeID { get; set; }

        [StringLength(15)]
        public string Size { get; set; }
    }
}