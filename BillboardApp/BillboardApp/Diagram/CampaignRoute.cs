//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BillboardApp.Diagram
{
    using System;
    using System.Collections.Generic;
    
    public partial class CampaignRoute
    {
        public int CampaignRouteID { get; set; }
        public int CampaignID { get; set; }
        public int RouteID { get; set; }
    
        public virtual Campaign Campaign { get; set; }
        public virtual Route Route { get; set; }
    }
}
