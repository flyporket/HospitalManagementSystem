//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataAccessLayer
{
    using System;
    using System.Collections.Generic;
    
    public partial class Patient
    {
        public Patient()
        {
            this.IndoorPatients = new HashSet<IndoorPatient>();
            this.Prescriptions = new HashSet<Prescription>();
        }
    
        public int pat_id { get; set; }
        public string pat_name { get; set; }
        public string pat_gender { get; set; }
        public System.DateTime pat_dob { get; set; }
        public string pat_type { get; set; }
        public Nullable<int> cat_id { get; set; }
        public Nullable<int> doc_id { get; set; }
    
        public virtual Doctor Doctor { get; set; }
        public virtual ICollection<IndoorPatient> IndoorPatients { get; set; }
        public virtual ICollection<Prescription> Prescriptions { get; set; }
        public virtual Category Category { get; set; }
    }
}
