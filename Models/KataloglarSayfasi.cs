//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LandeWebProjectV1.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class KataloglarSayfasi
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public KataloglarSayfasi()
        {
            this.Kataloglar = new HashSet<Kataloglar>();
        }
    
        public System.Guid Oid { get; set; }
        public string Baslik { get; set; }
        public Nullable<int> OptimisticLockField { get; set; }
        public Nullable<int> GCRecord { get; set; }
        public string BaslikEng { get; set; }
        public string OlusturanKisi { get; set; }
        public Nullable<System.DateTime> OlusturmaTarihi { get; set; }
        public Nullable<int> Index { get; set; }
        public Nullable<bool> Web { get; set; }
        public Nullable<bool> EngWeb { get; set; }
        public Nullable<System.DateTime> SonGuncellemeTarihi { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Kataloglar> Kataloglar { get; set; }
    }
}
