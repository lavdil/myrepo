//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebApplication1.Controllers
{
    using System;
    using System.Collections.Generic;
    
    public partial class Complaint
    {
        public int ComplaintID { get; set; }
        public Nullable<int> PassengerID { get; set; }
        public Nullable<System.DateTime> ComplaintDate { get; set; }
        public string Description { get; set; }
        public string Status { get; set; }
        public Nullable<System.DateTime> ResolutionDate { get; set; }
    
        public virtual Passenger Passenger { get; set; }
    }
}
