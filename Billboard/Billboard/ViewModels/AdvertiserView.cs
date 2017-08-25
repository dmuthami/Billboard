using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace Billboard.ViewModels
{
    public class AdvertiserView
    {
        public int AdvertiserID { get; set; }

        [DisplayName("Advertiser Name")]
        public string AdvertiserName { get; set; }

        [DisplayName("Advertiser Contact")]
        public string AdvertiserContact { get; set; }

        [DisplayName("Advertiser Email")]
        public string AdvertiserEmail { get; set; }

        [DisplayName("Advertiser Phone Number")]
        public string AdvertiserPhoneNumber { get; set; }

        [DisplayName("Advertiser Detail")]
        public string AdvertiserDetail { get; set; }
    }
}