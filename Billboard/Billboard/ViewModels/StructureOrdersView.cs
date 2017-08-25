using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace Billboard.ViewModels
{
    public class StructureOrdersView
    {
        public int StructureOrderID { get; set; }
        [DisplayName("Type")]
        public string StructureType { get; set; }
        [DisplayName("Advertiser Name")]
        public string AdvertiserName { get; set; }
        [DisplayName("Availability Type")]
        public string AvailabilityType { get; set; }
        [DisplayName("Visibility Rating")]
        public int VisibilityRating { get; set; }
        [DisplayName("Current Face")]
        public string CurrentFace { get; set; }
        [DisplayName("Campaign Name")]
        public string CampaignName { get; set; }
    }
}