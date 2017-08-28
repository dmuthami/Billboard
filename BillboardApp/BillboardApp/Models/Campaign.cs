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
            this.CampaignRoutes = new HashSet<CampaignRoute>();
        }

        public int CampaignID { get; set; }

        [DisplayName("Campaign Name")]
        public string CampaignName { get; set; }

        public virtual ICollection<CampaignRoute> CampaignRoutes { get; set; }


        //Product Relationship and Navigation Property
        public int ProductID { get; set; }
        public virtual Product Product { get; set; }

        //Agency Relationship and Navigation Property
        public int AgencyID { get; set; }
        public virtual Agency Agency { get; set; }
    }
}
