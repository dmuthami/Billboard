using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace BillboardApp.ViewModels
{
    public class StructureOwnerViewModel
    {
        public int StructureOwnerID { get; set; }

        public string Name { get; set; }

        public string Email { get; set; }

        public string MobileNumber { get; set; }
    }
}