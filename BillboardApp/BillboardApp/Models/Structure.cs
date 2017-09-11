using BillboardApp.Model_Logic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace BillboardApp.Models
{
    public class Structure
    {
        public Structure()
        {            
            this.Faces = new HashSet<Face>();
        }
        public int StructureID { get; set; }

        [DisplayName("No. of Faces")]
        public int? FaceCount { get; set; }

        [DisplayName("Comments")]
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

        [DisplayName("Ward")]
        [StringLength(80)]
        public string Ward { get; set; }

        [DisplayName("Constituency")]
        [StringLength(80)]
        public string Constituency { get; set; }

        [DisplayName("County")]
        [StringLength(50)]
        public string County { get; set; }
        
        public virtual ICollection<Face> Faces { get; set; }

        //Structure TypeRelationship and Navigation Property
        [DisplayName("Type")]
        public int StructureTypeID { get; set; }
        public virtual StructureType StructureType { get; set; }

        //StructureOwners Relationship and Navigation Property
         [DisplayName("Owner")]
        public int StructureOwnerID { get; set; }

        public virtual StructureOwner StructureOwner { get; set; }

    }
}