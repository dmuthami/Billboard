using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace BillboardApp.ViewModels
{
    public class FaceBoundViewModel
    {
        public int FaceBoundID { get; set; }

        [DisplayName("Bound")]
        public string Bound { get; set; }
    }
}