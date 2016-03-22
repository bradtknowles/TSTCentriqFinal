using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TST.Data
{
    class TSTTechNoteMeta
    {
        [Display(Name = "Technician's Note")]
        [Required(ErrorMessage = "* Required *")]
        [StringLength(500, ErrorMessage = "Name must be 500 characters or less.")]
        public string TechNote { get; set; }

        [Display(Name = "Updated On")]
        [Required(ErrorMessage = "* Required *")]
        [DisplayFormat(DataFormatString = "MM/dd/yyyy")]
        public System.DateTime TechNoteDate { get; set; }

    }
}
