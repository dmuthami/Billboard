using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace BillboardApp.ViewModels
{
    public class IndustryViewModel : IndustryTypeViewModel
    {
        public int IndustryID { get; set; }

        [DisplayName("Name")]
        public string Name { get; set; }
    }
}