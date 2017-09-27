using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace BillboardApp.Models
{
    public class Product
    {
       
        public Product()
        {
            //this.Campaigns = new HashSet<Campaign>();
        }

        public int ProductID { get; set; }

        [DisplayName("Product Name")]
        public string Name { get; set; }

        //public virtual ICollection<Campaign> Campaigns { get; set; }

        //Advertiser Relationship and Navigation Property
        public int AdvertiserID { get; set; }
        public virtual Advertiser Advertiser { get; set; }

    }
}
