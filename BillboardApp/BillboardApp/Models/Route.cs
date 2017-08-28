using System;
using System.Collections.Generic;
using System.Data.Entity.Spatial;
using System.Linq;
using System.Web;

namespace BillboardApp.Models
{
    public class Route
    {
        public Route()
        {
            this.CampaignRoutes = new HashSet<CampaignRoute>();
        }
        public int RouteID { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public virtual ICollection<CampaignRoute> CampaignRoutes { get; set; }
    }
}