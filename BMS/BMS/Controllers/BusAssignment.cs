//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BMS.Controllers
{
    using System;
    using System.Collections.Generic;
    
    public partial class BusAssignment
    {
        public int AssignmentID { get; set; }
        public Nullable<int> BusID { get; set; }
        public Nullable<int> DriverID { get; set; }
        public Nullable<System.DateTime> AssignmentDate { get; set; }
        public string Shift { get; set; }
    
        public virtual Bus Bus { get; set; }
        public virtual Driver Driver { get; set; }
    }
}
