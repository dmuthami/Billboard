using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace Billboard.ViewModels
{
    public class CampaignView
    {
        public int CampaignID { get; set; }
        [DisplayName("Campaign Name")]
        public string CampaignName { get; set; }
        [DisplayName("Industry Name")]
        public string IndustryName { get; set; }
        [DisplayName("Brand Name")]
        public string BrandName { get; set; }
        [DisplayName("Advertiser Name")]
        public string AdvertiserName { get; set; }
    }
}