using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace BillboardApp.Models
{
    public class FaceImage
    {
        public FaceImage()
        {
            
        }
        public int FaceImageID { get; set; }

        [DisplayName("Face URL")]
        public string FaceURL { get; set; }

        [DisplayName("Face Image")]
        public byte[] Content { get; set; }

        [DisplayName("Date")]
        public System.DateTime TimeStamp { get; set; }

        //Face relationship and navigation property
        public int FaceID { get; set; }
        public virtual Face Face { get; set; }

        
        
    }
}