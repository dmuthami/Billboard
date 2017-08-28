using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BillboardApp.Models
{
    public class Sweep
    {
        public Sweep()
        {
            this.SweepStructures = new HashSet<SweepStructure>();
        }
        public int SweepID { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public virtual ICollection<SweepStructure> SweepStructures { get; set; }
    }
}