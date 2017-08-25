using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace Billboard.Models
{
    public class FaceVisibilityRating
    {
        public FaceVisibilityRating()
        {
            this.Faces = new HashSet<Face>();
        }

        public int FaceVisibilityRatingID { get; set; }

        [DisplayName("Vegetation Score")]
        public Nullable<double> VegetationCoverScore { get; set; }
         [DisplayName("Sight Lighting Score")]
        public Nullable<double> SightLightingScore { get; set; }
         [DisplayName("Back Light Score")]
        public Nullable<double> BacklightScore { get; set; }
         [DisplayName("Unlight Score")]
        public Nullable<double> UnlightScore { get; set; }

         [DisplayName("Trafic Score")]
        public Nullable<double> TrafficScore { get; set; }
         [DisplayName("Clutter Score")]
        public Nullable<double> ClutterScore { get; set; }
        public virtual ICollection<Face> Faces { get; set; }
    }
}