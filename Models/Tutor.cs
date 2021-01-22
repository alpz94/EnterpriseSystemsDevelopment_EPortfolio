using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EnterpriseSystemsDevelopment_EPortfolio.Models
{
    public class Tutor
    {
        [Range(0, 15, ErrorMessage = "Can only be between 0 .. 15")]
        private int TutorID { get; set; }

        [Required]
        [StringLength(20)]
        [DisplayName("First Name")]
        public string FirstName { get; set; }

        [Required]
        [StringLength(20)]
        [DisplayName("Last Name")]
        private string LastName { get; set; }

        [Required]
        [StringLength(100)]
        [DataType(DataType.EmailAddress)]
        private string Email { get; set; }

        [Required]
        [StringLength(20)]
        [DataType(DataType.Password)]
        private string Password { get; set; }
        

    }
}
