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

        public int ApprenticeId { get; set; }

        //KsbType
        public KsbType KsbType { get; set; }
        
        [Required]
        [DisplayName("KSB ID")]
        public KsbKeys KsbKey { get; set; }

        //Template contains a collection of Evidence
        public virtual ICollection<Evidence> Evidences { get; set; }

        public virtual Apprentice Apprentice { get; set; }


    }
}
