using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace BillboardApp.Models
{
    public class StructureOwner
    {
        public StructureOwner()
        {
            this.Structures = new HashSet<Structure>();
        }
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int StructureOwnerID { get; set; }

        public string Name { get; set; }

        [DisplayName("Email")]
        public string Email { get; set; }

        [DisplayName("Mobile No.")]
        public string MobileNumber { get; set; }

        public virtual ICollection<Structure> Structures { get; set; }

    }
}