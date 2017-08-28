using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace BillboardApp.Models
{
    public class FaceSize
    {
 
        public FaceSize()
        {
            this.Faces = new HashSet<Face>();
        }

        [DisplayName(" Height & Width")]
        public int FaceSizeID { get; set; }

        [DisplayName("Height")]
        public double Height { get; set; }

        [DisplayName("Width")]
        public double Width { get; set; }

        public virtual ICollection<Face> Faces { get; set; }
    }
}