//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AirplaneTracker.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class pilots
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public pilots()
        {
            this.Airplanes = new HashSet<Airplanes>();
            this.Airplanes1 = new HashSet<Airplanes>();
        }
    
        public int id { get; set; }
        public string name { get; set; }
        public string AirplaneType { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Airplanes> Airplanes { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Airplanes> Airplanes1 { get; set; }
    }
}
