using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EnterpriseSystemsDevelopment_EPortfolio.Models
{
    public class Template
    {
        [Range(0, 15, ErrorMessage = "Can only be between 0 .. 15")]
        private int TemplateID { get; set; }

        [Required]
        [StringLength(20)]
        [DisplayName("Template Name")]
        private string Name { get; set; }

        [Required]
        [Range(0, 10000000)]
        private int Evidence { get; set; }

    }
}
