using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace BillboardApp.Models
{
    public class FaceOccupancy
    {
 
        public FaceOccupancy()
        {
            this.Faces = new HashSet<Face>();
        }

        public int FaceOccupancyID { get; set; }

        [DisplayName("Occupancy Type")]
        public string OccupancyType { get; set; }


        public virtual ICollection<Face> Faces { get; set; }
    }
}