﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace BillboardApp.Models
{
    public class Industry
    {

        public Industry()
        {
            this.Campaigns = new HashSet<Campaign>();
        }

        public int IndustryID { get; set; }

        [DisplayName("Name")]
        public string Name { get; set; }

        public virtual ICollection<Campaign> Campaigns { get; set; }

        //Industry Type Relationship and Navigation Property
        public int IndustryTypeID { get; set; }
        public  virtual IndustryType IndustryType { get; set; }
    }
}
