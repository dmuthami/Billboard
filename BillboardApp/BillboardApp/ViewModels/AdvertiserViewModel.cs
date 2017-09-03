using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace BillboardApp.ViewModels
{
    public class AdvertiserViewModel
    {
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
    }
}