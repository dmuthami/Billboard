using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BillboardApp.Models;

namespace BillboardApp.ViewModels
{
    public class AgencyIndexViewModel
    {
        public Agency Agency { get; set; }
        public Subscription Subscription { get; set; }
    }
}