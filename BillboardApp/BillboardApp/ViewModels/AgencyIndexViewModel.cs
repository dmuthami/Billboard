using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BillboardApp.Models;
using System.ComponentModel.DataAnnotations;

namespace BillboardApp.ViewModels
{
    public class AgencyIndexViewModel
    {
        public int AgencyID { get; set; }

        public string Name { get; set; }

        public string ContactPerson { get; set; }

        public string Email { get; set; }

        public string Phone { get; set; }

        /*
         * Properties below relate to the Subscription
         */

        public int SubscriptionID { get { return this.AgencyID; } set { } }

        public Nullable<double> Amount { get; set; }

        public Nullable<double> Paid { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime StartDate { get; set; }
        
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime ExpiryDate { get; set; }

        public string Description { get; set; }

    }
}