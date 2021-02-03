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
        [DisplayName("KSB ID")]
        public KsbKeys KsbKey { get; set; }

        [Required]
        [StringLength(20)]
        [DisplayName("Description")]
        public string Name { get; set; }

        [Required]
        [StringLength(20)]
        [DisplayName("Evidence")]
        public string Evidence { get; set; }

        //Template contains a collection of KSBs
        public virtual ICollection<KSB> KSBs { get; set; }
    }
}
