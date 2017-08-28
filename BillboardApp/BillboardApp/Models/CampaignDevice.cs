using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BillboardApp.Models
{
    public class CampaignDevice
    {
        public int CampaignDeviceID { get; set; }

        //Campaign Relationship and Navigation Property
        public int CampaignID { get; set; }
        public virtual Campaign Campaign { get; set; }

        //Device Relationship and Navigation Property
        public int DeviceID { get; set; }
        public virtual Device Device { get; set; }


    }
}