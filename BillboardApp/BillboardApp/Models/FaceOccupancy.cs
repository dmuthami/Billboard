using System;
using System.Collections.Generic;
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
        public string Occupancy { get; set; }

        public virtual ICollection<Face> Faces { get; set; }
    }
}