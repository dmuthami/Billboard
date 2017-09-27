using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BillboardApp.Models
{
    public class Advert
    {
        public int AdvertID { get; set; }

        //Face Relationship and Navigation Property
        public int FaceID { get; set; }
        public virtual Face Face { get; set; }

        //Advertiser Relationship and Navigation Property
        public int AdvertiserID { get; set; }
        public virtual Advertiser Advertiser { get; set; }

        ////Campaign Relationship and Navigation Property
        //public int CampaignID { get; set; }
        //public virtual Campaign Campaign { get; set; }
    }
}