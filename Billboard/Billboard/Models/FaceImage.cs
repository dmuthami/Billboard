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
            this.Faces = new HashSet<Face>();
        }
        public int FaceImageID { get; set; }

        [DisplayName("Advert Image")]
        public byte[] Image { get; set; }

        [DisplayName("Date")]
        public System.DateTime TimeStamp { get; set; }
        
        public virtual Face Face { get; set; }

        public virtual ICollection<Face> Faces { get; set; }
        
    }
}