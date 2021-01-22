using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace EnterpriseSystemsDevelopment_EPortfolio.Models
{
    public class Employer
    {
        [Range(0, 15, ErrorMessage = "Can only be between 0 .. 15")]
        private int EmployerID { get; set; }

        [Required]
        [StringLength(20)]
        [DisplayName("Employer Name")]
        private string Name { get; set; }
    }
}
