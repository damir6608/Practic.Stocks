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
    
    public partial class InvoiceInventoryType
    {
        public int Id { get; set; }
        public int InvoiceId { get; set; }
        public int InventoryTypeJournalId { get; set; }
        public int Quantity { get; set; }
    
        public virtual InventoryTypeJournal InventoryTypeJournal { get; set; }
        public virtual Invoice Invoice { get; set; }
    }
}