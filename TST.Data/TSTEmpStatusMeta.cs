using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TST.Data
{
    class TSTEmpStatusMeta
    {
        [Display(Name = "Employee Status Name")]
        [StringLength(50, ErrorMessage = "Name must be 50 characters or less.")]
        public string EmpStatName { get; set; }

        [Display(Name = "Status Description")]
        [StringLength(150, ErrorMessage = "Name must be 150 characters or less.")]
        public string EmpStatDescription { get; set; }

    }
}
