using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TST.Data
{
    public class TSTEmployeeMeta
    {
        [Display(Name = "First Name")]
        [Required(ErrorMessage = "* Required *")]
        [StringLength(50, ErrorMessage = "Name must be 50 characters or less.")]
        public string EmpFname { get; set; }

        [Display(Name = "Last Name")]
        [Required(ErrorMessage = "* Required *")]
        [StringLength(50, ErrorMessage = "Name must be 50 characters or less.")]
        public string EmpLname { get; set; }

        [Display(Name = "First Line of Address")]
        [StringLength(100, ErrorMessage = "Please enter 100 characters or less.")]
        public string EmpAdd1 { get; set; }

        [Display(Name = "Second Line of Address")]
        [StringLength(25, ErrorMessage = "Please enter 25 characters or less.")]
        public string EmpAdd2 { get; set; }

        [Display(Name = "Area")]
        [StringLength(50, ErrorMessage = "Please enter 50 characters or less.")]
        public string Area { get; set; }

        [Display(Name = "Town or City")]
        [StringLength(25, ErrorMessage = "Please enter 25 characters or less.")]
        public string Town_City { get; set; }

        [Display(Name = "Post Code")]
        [StringLength(10, ErrorMessage = "Please enter 10 characters or less.")]
        public string PostCode { get; set; }

        [Display(Name = "Phone Number")]
        [StringLength(15, ErrorMessage = "Please enter 15 characters or less.")]
        [Required(ErrorMessage = "* Required *")]
        public string PhoneNbr { get; set; }

        [Display(Name = "Date of Birth")]
        [Required(ErrorMessage = "* Required *")]
        [DisplayFormat(DataFormatString = "MM/dd/yyyy")]
        public System.DateTime DOB { get; set; }

        [Display(Name = "Date of Hire")]
        [Required(ErrorMessage = "* Required *")]
        [DisplayFormat(DataFormatString = "MM/dd/yyyy")]
        public System.DateTime DateOfHire { get; set; }

        [Display(Name = "Date of Separation")]
        [DisplayFormat(DataFormatString = "MM/dd/yyyy")]
        public Nullable<System.DateTime> DateOfSeparation { get; set; }

        [Display(Name = "Email Address")]
        [Required(ErrorMessage = "* Required *")]
        [RegularExpression(@"^[0-9a-zA-Z]+([0-9a-zA-Z]*[-._ +])*[0-9a-zA-Z]+@[0-9a-zA-Z]+([-.]
        [0-9a-zA-Z]+)*([0-9a-zA-Z]*[.])[a-zA-Z]{2,6}$", ErrorMessage="Please Check Email Format")]
        public string Email { get; set; }

        [Display(Name = "Put picture here.")]
        public string Image { get; set; }

        [Display(Name = "Notes on Employee")]
        public string Notes { get; set; }

    }
    [MetadataType(typeof(TSTEmployeeMeta))]
    public partial class TSTEmployee { }

}
