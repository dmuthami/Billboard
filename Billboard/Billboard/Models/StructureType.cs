using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Billboard.Models
{
    public class StructureType
    {
        public StructureType()
        {
            this.Faces = new HashSet<Face>();
        }
        public int StructureTypeID { get; set; }

        public string Type { get; set; }

        public virtual ICollection<Face> Faces { get; set; }
    }
}