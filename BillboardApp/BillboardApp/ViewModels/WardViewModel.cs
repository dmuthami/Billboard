using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BillboardApp.ViewModels
{
    public class WardViewModel
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
    }
}