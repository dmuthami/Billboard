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
    
    public partial class Advert
    {
        public int AdvertID { get; set; }
        public int FaceID { get; set; }
        public int AdvertiserID { get; set; }
    
        public virtual Advertiser Advertiser { get; set; }
        public virtual Face Face { get; set; }
    }
}
