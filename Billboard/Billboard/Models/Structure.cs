using Billboard.Model_Logic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Billboard.Models
{
    public class Structure
    {
        public Structure()
        {
            this.StructureOwners = new HashSet<StructureOwner>();
            this.Faces = new HashSet<Face>();
        }
        public int StructureID { get; set; }

        [Required,DisplayName("No. of Faces")]
        public int FaceCount { get; set; }

        [Required, DisplayName("Comments")]
        public string Comment { get; set; }

        [DisplayName("Latitude")]
        public Nullable<double> Latitude { get; set; }
        [DisplayName("Longitude")]
        public Nullable<double> Longitude { get; set; }

        [DisplayName("View Map")]
        public System.Data.Entity.Spatial.DbGeometry Geom
        {
            get
            {
                StructureLogic structureLogic = new StructureLogic();
                return structureLogic.computedLocation(Longitude, Latitude);
            }
            set { }
        }

        public virtual ICollection<StructureOwner> StructureOwners { get; set; }
        public virtual ICollection<Face> Faces { get; set; }

        //Structure TypeRelationship and Navigation Property
        public int StructureTypeID { get; set; }
        public virtual StructureType StructureType { get; set; }       

    }
}