﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BillboardApp.ViewModels
{
    public class FaceImageViewModel
    {
        public int FaceImageID { get; set; }

        public string FaceURL { get; set; }

        public System.DateTime TimeStamp { get; set; }

        public byte[] Content { get; set; }
    }
}