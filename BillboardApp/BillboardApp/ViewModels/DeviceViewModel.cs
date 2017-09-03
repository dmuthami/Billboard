using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BillboardApp.ViewModels
{
    public class DeviceViewModel
    {
        public int DeviceID { get; set; }

        public string IMEI { get; set; }

        public string Name { get; set; }

        public string SerialNo { get; set; }

        public string Status { get; set; }

    }
}