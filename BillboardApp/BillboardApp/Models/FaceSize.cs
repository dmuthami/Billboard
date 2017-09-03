using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
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
  
        public int FaceSizeID { get; set; }

        [StringLength(50)]
        public string Size { get; set; }

        public virtual ICollection<Face> Faces { get; set; }
    }
}