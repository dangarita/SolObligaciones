//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EntitiesLayer
{
    using System;
    using System.Collections.Generic;
    
    public partial class Periodicidad
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Periodicidad()
        {
            this.Entregable = new HashSet<Entregable>();
        }
    
        public int IdPeriodicidad { get; set; }
        public string NomPeriodicidad { get; set; }
        public bool EstadoPeriodicidad { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Entregable> Entregable { get; set; }
    }
}
