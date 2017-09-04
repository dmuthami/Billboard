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

        public string Parameter { get; set; }

        public double Score { get; set; }
    }
}