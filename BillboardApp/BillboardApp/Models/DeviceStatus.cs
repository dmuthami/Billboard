using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BillboardApp.Models
{
    public class DeviceStatus
    {
        public DeviceStatus()
        {
            this.Devices = new HashSet<Device>();
        }
        public int DeviceStatusID { get; set; }

        public string Status { get; set; }

        public virtual ICollection<Device> Devices { get; set; }
    }
}