using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BillboardApp.ViewModels
{
    public class AssignedRoutesData
    {
        public int RouteID { get; set; }
        public string Name { get; set; }
        public bool Assigned { get; set; }
    }
}