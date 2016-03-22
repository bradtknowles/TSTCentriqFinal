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
    
    public partial class TSTEmployee
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TSTEmployee()
        {
            this.TSTTickets = new HashSet<TSTTicket>();
            this.TSTTickets1 = new HashSet<TSTTicket>();
        }
    
        public int EmpID { get; set; }
        public string EmpFname { get; set; }
        public string EmpLname { get; set; }
        public int DeptID { get; set; }
        public int EmpStatID { get; set; }
        public string EmpAdd1 { get; set; }
        public string EmpAdd2 { get; set; }
        public string Area { get; set; }
        public string Town_City { get; set; }
        public string PostCode { get; set; }
        public string PhoneNbr { get; set; }
        public string UserID { get; set; }
        public System.DateTime DOB { get; set; }
        public System.DateTime DateOfHire { get; set; }
        public Nullable<System.DateTime> DateOfSeparation { get; set; }
        public string Email { get; set; }
        public string Image { get; set; }
        public string Notes { get; set; }
    
        public virtual TSTDepartment TSTDepartment { get; set; }
        public virtual TSTEmpStatu TSTEmpStatu { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSTTicket> TSTTickets { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSTTicket> TSTTickets1 { get; set; }
    }
}