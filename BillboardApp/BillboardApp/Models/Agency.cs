using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace BillboardApp.Models
{
    public class Agency
    {
        public  Agency() {
            this.Campaigns = new HashSet<Campaign>();
        }
        public int AgencyID { get; set; }

        public string Name { get; set; }

        [DisplayName("Contact Person")]
        public string ContactPerson { get; set; }

        public string Email { get; set; }

        public string Phone { get; set; }

        public virtual ICollection<Campaign> Campaigns { get; set; }

        public virtual Subscription Subscription { get; set; }
    }
}