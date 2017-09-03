using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace BillboardApp.ViewModels
{
    public class FaceConditionViewModel
    {
        public int FaceConditionID { get; set; }

        [DisplayName("Condition")]
        public string Condition { get; set; }
    }
}