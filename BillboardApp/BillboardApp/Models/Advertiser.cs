using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace BillboardApp.Models
{
    public class Advertiser
    {
        
        public Advertiser()
        {
            this.Adverts = new HashSet<Advert>();
            this.Campaigns = new HashSet<Campaign>();
            this.Products = new HashSet<Product>();

        }

        public int AdvertiserID { get; set; }

        [DisplayName("Name")]
        public string Name { get; set; }

        [DisplayName("Contact")]
        public string Contact { get; set; }

        [DisplayName("Email")]
        public string Email { get; set; }

        [DisplayName("Phone Number")]
        public string PhoneNumber { get; set; }

        [DisplayName("Detail")]
        public string Detail { get; set; }

        public virtual ICollection<Advert> Adverts { get; set; }
      
        public virtual ICollection<Campaign> Campaigns { get; set; }

        //Navigation property to Products
        public virtual ICollection<Product> Products { get; set; }

    }
}
