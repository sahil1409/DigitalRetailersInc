//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DigitalRetailersInc.DAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class laptop
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public laptop()
        {
            this.carts = new HashSet<cart>();
        }
    
        public int laptop_id { get; set; }
        public string laptop_name { get; set; }
        public Nullable<bool> is_active { get; set; }
        public Nullable<bool> is_delete { get; set; }
        public string laptop_image { get; set; }
        public Nullable<int> quantity { get; set; }
        public Nullable<decimal> price { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<cart> carts { get; set; }
    }
}
