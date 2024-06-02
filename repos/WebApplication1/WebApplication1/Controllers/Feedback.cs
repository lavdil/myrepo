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
    
    public partial class Feedback
    {
        public int FeedbackID { get; set; }
        public Nullable<int> PassengerID { get; set; }
        public Nullable<int> BusID { get; set; }
        public Nullable<int> RouteID { get; set; }
        public Nullable<System.DateTime> FeedbackDate { get; set; }
        public string Comments { get; set; }
        public Nullable<int> Rating { get; set; }
    
        public virtual Bus Bus { get; set; }
        public virtual Passenger Passenger { get; set; }
        public virtual Route Route { get; set; }
    }
}