using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Formdata.Data.Model
{
    public class FormModel
    {
        [Required(ErrorMessage ="First Name Feild is Required")]
        [StringLength(100)]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Last Name Feild is Required")]
        [StringLength(100)]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Email Name Feild is Required")]
        [StringLength(100)]
        public string Email { get; set; }

        [Required(ErrorMessage = "PhoneNumber Name Feild is Required")]
        [StringLength(100)]
        public string PhoneNumber { get; set; }

        [Required(ErrorMessage = "Address Feild is Required")]
        [StringLength(100)]
        public string Address { get; set; }
    }
}
