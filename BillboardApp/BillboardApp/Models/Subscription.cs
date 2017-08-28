using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace BillboardApp.Models
{
    public class Subscription
    {
        public int SubscriptionID { get; set; }

        public Nullable<double>  Amount { get; set; }

        public Nullable<double> Paid { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime ExpiryDate { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public virtual Agency Agency { get; set; }
    }
}