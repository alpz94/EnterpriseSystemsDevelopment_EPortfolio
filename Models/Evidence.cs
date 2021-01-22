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
        [Range(0, 15, ErrorMessage = "Can only be between 0 .. 15")]
        private int evidenceID { get; set; }

        [Required]
        [StringLength(20)]
        [DisplayName("Evidence Name")]
        private String name { get; set; }

        public FileType FileTypes { get; set; }

        [Required]
        [StringLength(4000)]
        [DisplayName("Description")]
        [DataType(DataType.MultilineText)]
        private String description { get; set; }

    }
}
