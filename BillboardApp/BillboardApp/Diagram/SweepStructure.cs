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
    
    public partial class SweepStructure
    {
        public int SweepStructureID { get; set; }
        public int StructureID { get; set; }
        public int SweepID { get; set; }
    
        public virtual Structure Structure { get; set; }
        public virtual Sweep Sweep { get; set; }
    }
}