//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BillboardApp
{
    using System;
    using System.Collections.Generic;
    
    public partial class Campaign
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Campaign()
        {
            this.Adverts = new HashSet<Advert>();
            this.CampaignDevices = new HashSet<CampaignDevice>();
            this.CampaignRoutes = new HashSet<CampaignRoute>();
        }
    
        public int CampaignID { get; set; }
        public string CampaignName { get; set; }
        public int ProductID { get; set; }
        public int AgencyID { get; set; }
        public Nullable<int> Advertiser_AdvertiserID { get; set; }
        public Nullable<int> Industry_IndustryID { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Advert> Adverts { get; set; }
        public virtual Advertiser Advertiser { get; set; }
        public virtual Agency Agency { get; set; }
        public virtual Industry Industry { get; set; }
        public virtual Product Product { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CampaignDevice> CampaignDevices { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CampaignRoute> CampaignRoutes { get; set; }
    }
}