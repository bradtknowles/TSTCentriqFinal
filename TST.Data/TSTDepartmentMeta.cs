using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TST.Data
{
    class TSTDepartmentMeta
    {
        [Display(Name = "Department Name")]
        [Required(ErrorMessage = "* Required *")]
        [StringLength(25, ErrorMessage = "Name must be 25 characters or less.")]
        public string DeptName { get; set; }

        [Display(Name = "First Name")]
        [StringLength(150, ErrorMessage = "Name must be 150 characters or less.")]
        public string DeptDescription { get; set; }

    }
}
