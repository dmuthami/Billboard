using Billboard.Model_Logic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Spatial;
using System.Linq;
using System.Web;

namespace Billboard.Models
{
    public class Face
    {
        public Face()
        {
            this.Adverts = new HashSet<Advert>();
            this.FaceImages = new HashSet<FaceImage>();
        }

        public int FaceID { get; set; }
        public virtual ICollection<Advert> Adverts { get; set; }
        public virtual ICollection<FaceImage> FaceImages { get; set; }

        //Face Occupancy Relationship
        public int FaceOccupancyID { get; set; }
        public virtual FaceOccupancy FaceOccupancy { get; set; }

        //Face Size Relationship
        public int FaceSizeID { get; set; }
        public virtual FaceSize FaceSize { get; set; }

        //Face Condition Relationship
        public int FaceConditionID { get; set; }
        public virtual FaceCondition FaceCondition { get; set; }

        //Face bound Relationship
        public int FaceBoundID { get; set; }
        public virtual FaceBound FaceBound { get; set; }

        //Face Position Relationship
        public int FacePositionID { get; set; }
        public virtual FacePosition FacePosition { get; set; }

        //Face availability Relationship
        public int FaceAvailabilityID { get; set; }
        public virtual FaceAvailability FaceAvailability { get; set; }

        //Structure Relationship
        public int StructureID { get; set; }
        public virtual Structure Structure { get; set; }

        //Face Orientation Relationship and navigation property
        public int FaceOrientationID { get; set; }
        public virtual FaceOrientation FaceOrientation { get; set; }

        //one to one 
        public FaceVisibilityRating FaceVisibilityRating { get; set; }

    }
}