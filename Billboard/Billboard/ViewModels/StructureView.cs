using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace Billboard.ViewModels
{
    public class StructureView
    {
        public int StructureID { get; set; }
        [DisplayName("Type")]
        public string StructureType { get; set; }
        [DisplayName("Owner")]
        public string StructureOwnerName { get; set; }
        [DisplayName("Face Number")]
        public int StructureFaceNumber { get; set; }
        public string Occupancy { get; set; }
        [DisplayName("Actual Height")]
        public double ActualHeight { get; set; }

        [DisplayName("Actual Width")]
        public double ActualWidth { get; set; }
        [DisplayName("Visibility")]
        public string VisibilityType { get; set; }
        [DisplayName("Cluster")]
        public string StructureClusterType { get; set; }
        [DisplayName("Bound")]
        public string StructureBoundType { get; set; }
        [DisplayName("Position")]
        public string Position { get; set; }
        [DisplayName("Status")]
        public string ConditionStatus { get; set; }
        [DisplayName("Latitude")]
        public Nullable<double> StructureLatitude { get; set; }
        [DisplayName("Longitude")]
        public Nullable<double> StructureLongitude { get; set; }

        [DisplayName("View Map")]
        public System.Data.Entity.Spatial.DbGeometry StructureLocation {get;set;}
    }
}