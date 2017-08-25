using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Billboard.Models
{
    public class CampaignRoute
    {
        public CampaignRoute()
        {

        }
        public int CampaignRouteID { get; set; }
        //Campaign Relationship and Navigation Property
        public int CampaignID { get; set; }
        public virtual Campaign Campaign { get; set; }

        //Route Relationship and Navigation Property
        public int RouteID { get; set; }
        public virtual Route Route { get; set; }
    }
}