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
    
    public partial class Subscription
    {
        public int SubscriptionID { get; set; }
        public Nullable<double> Amount { get; set; }
        public Nullable<double> Paid { get; set; }
        public System.DateTime StartDate { get; set; }
        public System.DateTime ExpiryDate { get; set; }
        public string Description { get; set; }
    
        public virtual Agency Agency { get; set; }
    }
}
