using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TST.Data
{
    class TSTTicketStatusMeta
    {
        [Display(Name = "Ticket Status")]
        [Required(ErrorMessage = "* Required *")]
        [StringLength(25, ErrorMessage = "Name must be 25 characters or less.")]
        public string TicketStatusName { get; set; }

        [Display(Name = "Status Description")]
        [StringLength(150, ErrorMessage = "Name must be 150 characters or less.")]
        public string TicketStatusDesc { get; set; }

    }
}
