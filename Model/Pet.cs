//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace QLThuCung.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class Pet
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Pet()
        {
            this.Contract_Sell = new HashSet<Contract_Sell>();
        }
    
        public string ID_Pet { get; set; }
        public string ID_Spec { get; set; }
        public string Sex { get; set; }
        public Nullable<int> PriceImport { get; set; }
        public string ID_Sup { get; set; }
        public Nullable<double> Weight { get; set; }
        public Nullable<int> Age { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Contract_Sell> Contract_Sell { get; set; }
        public virtual Species Species { get; set; }
        public virtual Supplier Supplier { get; set; }
    }
}