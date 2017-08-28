using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity.Spatial;
using System.Linq;
using System.Web;

namespace BillboardApp.Models
{
    public class Ward
    {
        public int WardID { get; set; }

        [DisplayName("Name")]
        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        [DisplayName("Abreviation")]
        [Required]
        [StringLength(3)]
        public string Abbreviation { get; set; }

        [DisplayName("Shape")]
        public DbGeometry Geom { get; set; }
    }
}