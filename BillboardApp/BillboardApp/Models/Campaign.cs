using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace BillboardApp.Models
{
    public class Campaign
    {
        
        public Campaign()
        {
            //this.CampaignRoutes = new HashSet<CampaignRoute>();
        }

        public int CampaignID { get; set; }

        [DisplayName("Campaign Name")]
        public string CampaignName { get; set; }

        //Many to many relationship(Routes Navigation Property)
        public virtual ICollection<Route> Routes { get; set; }

        //public virtual ICollection<CampaignRoute> CampaignRoutes { get; set; }

        //Agency Relationship and Navigation Property
        public int AgencyID { get; set; }
        public virtual Agency Agency { get; set; }

        //Advertiser Relationship and Navigation Property
        public int AdvertiserID { get; set; }
        public virtual Advertiser Advertiser { get; set; }

        //Industry Relationship and Navigation Property
        public int IndustryID { get; set; }
        public virtual Industry Industry { get; set; }
    }
}
