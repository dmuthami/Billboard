using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BillboardApp.Models
{
    public class FaceVisibilityRating
    {
       
        public int FaceVisibilityRatingID { get; set; }

        [DisplayName("Vegetation Cover/Obstruction Score")]
        public Nullable<double> VegetationCoverScore { get; set; }

        [DisplayName("Lighting Score")]
        public Nullable<double> FaceLightingScore { get; set; }

        [DisplayName("RunUp Score")]
        public Nullable<double> FaceRunUpScore { get; set; }

        [DisplayName("Traffic Score")]
        public Nullable<double> FaceTrafficScore { get; set; }

        [DisplayName("Clutter Score")]
        public Nullable<double> FaceClutterScore { get; set; }

        //Face relationship with navigation property
        public virtual Face Face { get; set; }

    }
}