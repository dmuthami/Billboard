using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BillboardApp.ViewModels
{
    public class StructureViewModel
    {
        public int StructureID { get; set; }

        public string Name { get; set; }

        public string Type { get; set; }

        [ DisplayName("No. of Faces")]
        public int? FaceCount { get; set; }

        [DisplayName("Comments")]
        public string Comment { get; set; }

        [DisplayName("Latitude")]
        public Nullable<double> Latitude { get; set; }
        [DisplayName("Longitude")]
        public Nullable<double> Longitude { get; set; }

        [DisplayName("View on Map")]
        public string Map { get; set; }

        public string Ward { get; set; }

        public string Constituency { get; set; }

        public string County { get; set; }


    }
}