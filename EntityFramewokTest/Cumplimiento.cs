//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EntityFramewokTest
{
    using System;
    using System.Collections.Generic;
    
    public partial class Cumplimiento
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Cumplimiento()
        {
            this.Seguimiento = new HashSet<Seguimiento>();
        }
    
        public int IdCumplimiento { get; set; }
        public string NomCumplimiento { get; set; }
        public bool EstadoCumplimiento { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Seguimiento> Seguimiento { get; set; }
    }
}