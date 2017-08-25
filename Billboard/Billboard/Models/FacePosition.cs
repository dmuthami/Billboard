using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace Billboard.Models
{
    public class FacePosition
    {
        public FacePosition()
        {
            this.Faces = new HashSet<Face>();
        }

        public int FacePositionID { get; set; }

        [DisplayName("Position")]
        public string Position { get; set; }

        public virtual ICollection<Face> Faces { get; set; }
    }
}