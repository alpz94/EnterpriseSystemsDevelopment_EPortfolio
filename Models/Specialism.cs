using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EnterpriseSystemsDevelopment_EPortfolio.Models
{
    public class Specialism
    {
        [Key]
        private int SpecialismId { get; set; }

        [Required]
        [StringLength(20)]
        [DisplayName("Specialism Name")]
        private string Name { get; set; }

        [Required]
        [StringLength(4000)]
        [DisplayName("Description")]
        [DataType(DataType.MultilineText)]
        private string Description { get; set; }
    }
}
