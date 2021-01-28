using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EnterpriseSystemsDevelopment_EPortfolio.Models
{
    public class Evidence
    {
        [Key]
        public int EvidenceId { get; set; }

        [Required]
        [StringLength(20)]
        [DisplayName("Evidence Name")]
        public string Name { get; set; }

        public FileType FileTypes { get; set; }

        [Required]
        [StringLength(4000)]
        [DisplayName("Description")]
        [DataType(DataType.MultilineText)]
        public string Description { get; set; }
    }
}
