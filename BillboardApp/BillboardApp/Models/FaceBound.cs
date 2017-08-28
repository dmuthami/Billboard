using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace BillboardApp.Models
{
    public class FaceBound
    {
       
        public FaceBound()
        {
            this.Faces = new HashSet<Face>();
        }

        public int FaceBoundID { get; set; }

        [DisplayName("Bound")]
        public string Bound { get; set; }


        public virtual ICollection<Face> Faces { get; set; }
    }
}