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
    
    public partial class TSTTicket
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TSTTicket()
        {
            this.TSTTechNotes = new HashSet<TSTTechNote>();
        }
    
        public int TicketID { get; set; }
        public string Subject { get; set; }
        public string IssueDesc { get; set; }
        public int SubmitByID { get; set; }
        public Nullable<int> TechID { get; set; }
        public System.DateTime DateSubmit { get; set; }
        public Nullable<System.DateTime> DateResolve { get; set; }
        public int TicketStatusID { get; set; }
    
        public virtual TSTEmployee TSTEmployee { get; set; }
        public virtual TSTEmployee TSTEmployee1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSTTechNote> TSTTechNotes { get; set; }
        public virtual TSTTicketStatu TSTTicketStatu { get; set; }
    }
}
