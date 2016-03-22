using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TST.Data
{
    class TSTTicketMeta
    {
        [Display(Name = "Subject")]
        [Required(ErrorMessage = "* Required *")]
        [StringLength(50, ErrorMessage = "Name must be 50 characters or less.")]
        public string Subject { get; set; }

        [Display(Name = "Description of Issue")]
        [Required(ErrorMessage = "* Required *")]
        public string IssueDesc { get; set; }

        [Display(Name = "Date Submitted")]
        [Required(ErrorMessage = "* Required *")]
        [DisplayFormat(DataFormatString = "MM/dd/yyyy")]
        public System.DateTime DateSubmit { get; set; }

        [Display(Name = "Date Resolved")]
        [DisplayFormat(DataFormatString = "MM/dd/yyyy")]
        public Nullable<System.DateTime> DateResolve { get; set; }

    }
}
