using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace Billboard.Models
{
    public class FaceImage
    {
        public FaceImage()
        {
            
        }
        public int FaceImageID { get; set; }

        [DisplayName("Advert Image")]
        public string Image { get; set; }

        [DisplayName("Date")]
        public System.DateTime TimeStamp { get; set; }

        //Face relationship and navigation property
        public int FaceID { get; set; }
        public virtual Face Face { get; set; }

        
        
    }
}