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
    public class County
    {
        public int CountyID { get; set; }
        //[Key]
        //[DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Code { get; set; }

        [DisplayName("Date Created")]
        public Nullable<DateTime> DateCreated { get; set; }

        [DisplayName("Date Retired")]
        public DateTime? DateRetired { get; set; }

        [DisplayName("Name")]
        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        [DisplayName("County Abreviation")]
        [Required]
        [StringLength(3)]
        public string Abbreviation { get; set; }

        [DisplayName("Geometry")]
        public DbGeometry Geom { get; set; }
    }
}