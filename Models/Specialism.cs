﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EnterpriseSystemsDevelopment_EPortfolio.Models
{
    public class Specialism
    {
        [Range(0, 15, ErrorMessage = "Can only be between 0 .. 15")]
        private int specialismID { get; set; }

        [Required]
        [StringLength(20)]
        [DisplayName("Specialism Name")]
        private String name { get; set; }

        [Required]
        [StringLength(4000)]
        [DisplayName("Description")]
        [DataType(DataType.MultilineText)]
        private String description { get; set; }

    }
}
