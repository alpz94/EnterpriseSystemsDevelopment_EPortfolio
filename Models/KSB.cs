using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EnterpriseSystemsDevelopment_EPortfolio.Models
{
    public class KSB
    {
        [StringLength(20)]
        private int kSBID { get; set; }

        [Required]
        [StringLength(20)]
        [DisplayName("KSB Name")]
        private String name { get; set; }

        [Required]
        [StringLength(4000)]
        [DisplayName("Description")]
        [DataType(DataType.MultilineText)]
        private String description { get; set; }


    }
}
