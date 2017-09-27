using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BillboardApp.Models;

namespace BillboardApp.ViewModels
{
    public class CampaignDetailData
    {
        public IEnumerable<Campaign> Campaigns { get; set; }
        public IEnumerable<Route> Routes { get; set; }
        public Campaign Campaign { get; set; }
    }
}