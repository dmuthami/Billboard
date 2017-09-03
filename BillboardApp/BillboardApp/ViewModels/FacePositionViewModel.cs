using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace BillboardApp.ViewModels
{
    public class FacePositionViewModel
    {
        public int FacePositionID { get; set; }

        [DisplayName("Position")]
        public string Position { get; set; }
    }
}