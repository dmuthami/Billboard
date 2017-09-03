using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace BillboardApp.ViewModels
{
    public class FaceAvailabilityViewModel
    {
        public int FaceAvailabilityID { get; set; }

        [DisplayName("Availability Type")]
        public string AvailabilityType { get; set; }
    }
}