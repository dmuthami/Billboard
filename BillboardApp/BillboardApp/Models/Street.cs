using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace BillboardApp.Models
{
    public class Street
    {
        public int StreetID { get; set; }

        [DisplayName("Collector Name")]
        public string StreetNameByCollector { get; set; }

        [DisplayName("GIS Name")]
        public string StreetNameByGIS { get; set; }

        //Routes Relation and Navigation Property
        public int RouteID { get; set; }
        public virtual Route Route { get; set; }

    }
}