//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Veterinary_Clinic.Library
{
    using System;
    using System.Collections.Generic;
    
    public partial class Patient
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Patient()
        {
            this.Prescription = new HashSet<Prescription>();
        }
    
        public int PatientID { get; set; }
        public string Name { get; set; }
        public int CompanionID { get; set; }
        public Nullable<bool> IsFeMale { get; set; }
        public int Weight { get; set; }
        public int EmployeeID { get; set; }
        public int BreedsID { get; set; }
        public System.DateTime Birth { get; set; }
    
        public virtual Breeds Breeds { get; set; }
        public virtual Companion Companion { get; set; }
        public virtual Employee Employee { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Prescription> Prescription { get; set; }
    }
}