﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EnterpriseSystemsDevelopment_EPortfolio.Models
{
    public class Tutor
    {
        [Key]
        public int TutorId { get; set; }

        [Required]
        [StringLength(20)]
        [DisplayName("First Name")]
        public string FirstName { get; set; }

        [Required]
        [StringLength(20)]
        [DisplayName("Last Name")]
        public string LastName { get; set; }

        [Required]
        [StringLength(100)]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required]
        [StringLength(20)]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
