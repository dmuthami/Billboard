using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BillboardApp.ViewModels
{
    public class StreetViewModel
    {
        public int StreetID { get; set; }
        public string StreetNameByCollector { get; set; }

        public string StreetNameByGIS { get; set; }

        public string Route { get; set; }
    }
}