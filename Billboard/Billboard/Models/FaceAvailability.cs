using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace Billboard.Models
{
    public class FaceAvailability
    {
 
        public FaceAvailability()
        {
            this.Faces = new HashSet<Face>();
        }

        public int FaceAvailabilityID { get; set; }

        [DisplayName("Availability Type")]
        public string AvailabilityType { get; set; }


        public virtual ICollection<Face> Faces { get; set; }
    }
}