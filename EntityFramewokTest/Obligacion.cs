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
    
    public partial class Obligacion
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Obligacion()
        {
            this.Entregable = new HashSet<Entregable>();
            this.Seguimiento = new HashSet<Seguimiento>();
        }
    
        public int IdObligacion { get; set; }
        public string NomObligacion { get; set; }
        public Nullable<bool> EstadoObligación { get; set; }
        public Nullable<int> IdCapitulo { get; set; }
    
        public virtual Capitulo Capitulo { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Entregable> Entregable { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Seguimiento> Seguimiento { get; set; }
    }
}
