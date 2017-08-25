using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace Billboard.ViewModels
{
    public class StructureImagesView
    {
        public int StructureImageID { get; set; }

        [DisplayName("Image Path")]
        public string StructureImagePath { get; set; }
        [DisplayName("Type")]
        public string StructureType { get; set; }
        [DisplayName("Date")]
        public System.DateTime TimeStamp { get; set; }
        [DisplayName("Image Closeness Type")]
        public string StructureImageClosenessType { get; set; }
    }
}