using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BillboardApp.Models
{
    public class SweepStructure
    {
        public int SweepStructureID { get; set; }

        //Structure TypeRelationship and Navigation Property
        public int StructureID { get; set; }
        public virtual Structure Structure { get; set; }

        //Sweep TypeRelationship and Navigation Property
        public int SweepID { get; set; }
        public virtual Sweep Sweep { get; set; }

    }
}