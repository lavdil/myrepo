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
    
    public partial class Driver
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Driver()
        {
            this.BusAssignments = new HashSet<BusAssignment>();
        }
    
        public int DriverID { get; set; }
        public string Name { get; set; }
        public string LicenseNumber { get; set; }
        public string ContactInfo { get; set; }
        public Nullable<System.DateTime> HireDate { get; set; }
        public string Experience { get; set; }
        public string ShiftDetails { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BusAssignment> BusAssignments { get; set; }
    }
}
