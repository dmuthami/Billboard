using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BillboardApp.Models
{
    public class IndustryType
    {

        public IndustryType()
        {
            this.Industrys = new HashSet<Industry>();
        }
        public int IndustryTypeID { get; set; }

        [StringLength(100),Required]
        public string Type { get; set; }

        //Navigation Property towards Industry
        public virtual ICollection<Industry> Industrys { get; set; }

    }
}