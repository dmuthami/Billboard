using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BillboardApp.ViewModels
{
    public class CampaignViewModel
    {
        public int CampaignID { get; set; }

        public string CampaignName { get; set; }

        public string AgencyName { get; set; }

        public string AdvertiserName { get; set; }

        public string IndustryName { get; set; }
    }
}