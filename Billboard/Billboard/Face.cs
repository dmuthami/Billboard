//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Billboard
{
    using System;
    using System.Collections.Generic;
    
    public partial class Face
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Face()
        {
            this.Adverts = new HashSet<Advert>();
            this.FaceImages = new HashSet<FaceImage>();
            this.FaceImages1 = new HashSet<FaceImage>();
        }
    
        public int FaceID { get; set; }
        public int FaceOccupancyID { get; set; }
        public int FaceSizeID { get; set; }
        public int FaceImageID { get; set; }
        public int FaceConditionID { get; set; }
        public int FaceBoundID { get; set; }
        public int FacePositionID { get; set; }
        public int FaceVisibilityRatingID { get; set; }
        public int FaceAvailabilityID { get; set; }
        public int StructureID { get; set; }
        public Nullable<int> FaceImage_FaceImageID { get; set; }
        public Nullable<int> FaceImage_FaceImageID1 { get; set; }
        public Nullable<int> StructureOwner_StructureOwnerID { get; set; }
        public Nullable<int> StructureType_StructureTypeID { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Advert> Adverts { get; set; }
        public virtual FaceAvailability FaceAvailability { get; set; }
        public virtual FaceBound FaceBound { get; set; }
        public virtual FaceCondition FaceCondition { get; set; }
        public virtual FaceImage FaceImage { get; set; }
        public virtual FaceImage FaceImage1 { get; set; }
        public virtual FaceOccupancy FaceOccupancy { get; set; }
        public virtual FacePosition FacePosition { get; set; }
        public virtual FaceSize FaceSize { get; set; }
        public virtual FaceVisibilityRating FaceVisibilityRating { get; set; }
        public virtual Structure Structure { get; set; }
        public virtual StructureOwner StructureOwner { get; set; }
        public virtual StructureType StructureType { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FaceImage> FaceImages { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FaceImage> FaceImages1 { get; set; }
    }
}
