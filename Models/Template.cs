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
        [Key]
        public int TemplateId { get; set; }

        [Required]
        [StringLength(20)]
        [DisplayName("Template Name")]
        public string Name { get; set; }

        [Required]
        [Range(0, 10000)]
        public int Evidence { get; set; }

        //Template contains a collection of KSBs
        public virtual ICollection<KSB> KSBs { get; set; }
    }
}
