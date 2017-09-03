using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace BillboardApp.ViewModels
{
    public class VegetationCoverViewModel
    {
        public int VegetationCoverID { get; set; }

        [DisplayName("Vegetation Type")]
        public string Type { get; set; }

      
        public double Score { get; set; }
    }
}