//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TST.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class TSTTicketStatu
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TSTTicketStatu()
        {
            this.TSTTickets = new HashSet<TSTTicket>();
        }
    
        public int TicketStatusID { get; set; }
        public string TicketStatusName { get; set; }
        public string TicketStatusDesc { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSTTicket> TSTTickets { get; set; }
    }
}
