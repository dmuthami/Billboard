using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BillboardApp.Models
{
    public class StructureType
    {
        public StructureType()
        {
            this.Structures = new HashSet<Structure>();
        }
        public int StructureTypeID { get; set; }

        public string Type { get; set; }

        public virtual ICollection<Structure> Structures { get; set; }
    }
}