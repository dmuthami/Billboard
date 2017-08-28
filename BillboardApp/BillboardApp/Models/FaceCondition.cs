using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace BillboardApp.Models
{
    public class FaceCondition
    {
        public FaceCondition()
        {
            this.Faces = new HashSet<Face>();
        }

        public int FaceConditionID { get; set; }

        [DisplayName("Condition")]
        public string Condition { get; set; }

        public virtual ICollection<Face> Faces { get; set; }
    }
}