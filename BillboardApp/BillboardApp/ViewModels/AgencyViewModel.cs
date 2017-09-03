using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BillboardApp.ViewModels
{
    public class AgencyViewModel
    {
        public int AgencyID { get; set; }

        public string Name { get; set; }

        public string ContactPerson { get; set; }

        public string Email { get; set; }

        public string Phone { get; set; }

        public string Description { get; set; }

        public Nullable<double> Amount { get; set; }

        public Nullable<double> Paid { get; set; }
    }
}