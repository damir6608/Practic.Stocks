//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Stocks
{
    using System;
    using System.Collections.Generic;
    
    public partial class InventoryTypeJournal
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public InventoryTypeJournal()
        {
            this.InvoiceInventoryTypes = new HashSet<InvoiceInventoryType>();
            this.StockInventoryTypes = new HashSet<StockInventoryType>();
        }
    
        public int Id { get; set; }
        public string Name { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<InvoiceInventoryType> InvoiceInventoryTypes { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<StockInventoryType> StockInventoryTypes { get; set; }
        public override string ToString()
        {
            return $"{this.Id }. {this.Name}";
        }
    }
}
