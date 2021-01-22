﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EnterpriseSystemsDevelopment_EPortfolio.Models
{
    public class Employer
    {
        [StringLength(50)]
        private int employerID { get; set; }

        [Required]
        [StringLength(20)]
        [DisplayName("Employer Name")]
        private String name { get; set; }
    }
}
