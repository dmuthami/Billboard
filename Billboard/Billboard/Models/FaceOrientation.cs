using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Billboard.Models
{
    public class FaceOrientation
    {
        public FaceOrientation()
        {
            this.Faces = new HashSet<Face>();
        }
        public int FaceOrientationID { get; set; }

        public string Orientation { get; set; }

        public virtual ICollection<Face> Faces { get; set; }
    }
}