using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Spatial;
using System.Linq;
using System.Web;

namespace Billboard.Models
{
    public class Constituency
    {

        public int ConstituencyID { get; set; }

        [DisplayName("Name")]
        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        [DisplayName("Abbreviation")]
        [Required]
        [StringLength(3)]
        public string Abbreviation { get; set; }

        [DisplayName("Geometry")]
        public DbGeometry Geom { get; set; }
    }
}