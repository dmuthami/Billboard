using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Billboard.Models
{
    public class Street
    {
        public int StreetID { get; set; }
        public string Name { get; set; }
        public System.Data.Entity.Spatial.DbGeometry Geom{get;set;}
    }
}