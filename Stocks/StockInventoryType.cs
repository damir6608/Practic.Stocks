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
    
    public partial class StockInventoryType
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public StockInventoryType()
        {
            this.InventoryControlCarts = new HashSet<InventoryControlCart>();
        }
    
        public int Id { get; set; }
        public int StockId { get; set; }
        public int InventoryTypeJournalId { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<InventoryControlCart> InventoryControlCarts { get; set; }
        public virtual InventoryTypeJournal InventoryTypeJournal { get; set; }
        public virtual Stock Stock { get; set; }
    }
}