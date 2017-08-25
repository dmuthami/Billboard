using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Billboard.Models
{
    public class Device
    {
        public Device()
        {
            this.CampaignDevices = new HashSet<CampaignDevice>();
        }
        public int DeviceID { get; set; }

        public string IMEI { get; set; }

        public string Name { get; set; }

        public string SerialNo { get; set; }

        public virtual ICollection<CampaignDevice> CampaignDevices { get; set; }

        //Devise status Relationship and Navigation Property
        public int DeviceStatusID { get; set; }
        public virtual DeviceStatus DeviceStatus { get; set; }

    }
}