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
        [Key]
        public int EmployerId { get; set; }

        [Required]
        [StringLength(20)]
        [DisplayName("Employer Name")]
        public string Name { get; set; }
    }
}
