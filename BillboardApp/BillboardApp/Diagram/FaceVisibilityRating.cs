//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BillboardApp.Diagram
{
    using System;
    using System.Collections.Generic;
    
    public partial class FaceVisibilityRating
    {
        public int FaceVisibilityRatingID { get; set; }
        public Nullable<double> VegetationCoverScore { get; set; }
        public Nullable<double> FaceLightingScore { get; set; }
        public Nullable<double> FaceRunUpScore { get; set; }
        public Nullable<double> FaceTrafficScore { get; set; }
        public Nullable<double> FaceClutterScore { get; set; }
    
        public virtual Face Face { get; set; }
    }
}
