using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EnterpriseSystemsDevelopment_EPortfolio.Models
{
    public class Apprentice
    {
		[Range(0, 15, ErrorMessage = "Can only be between 0 .. 15")]
		private int ApprenticeID { get; set; }

		[Required]
		[StringLength(20)]
		[DisplayName("First Name")]
		private string FirstName { get; set; }

		[Required]
		[StringLength(20)]
		[DisplayName("Last Name")]
		private string LastName { get; set; }

		[Required]
		[StringLength(50)]
		[DisplayName("Specialism")]
		private string SpecialismName { get; set; }

		[Required]
		[StringLength(20)]
		[DisplayName("Job Title")]
		private string JobTitle { get; set; }

		[Required]
		[StringLength(20)]
		[DisplayName("Employer")]
		private string Employer { get; set; }

		[Required]
		[StringLength(20)]
		[DataType(DataType.EmailAddress)]
		private string Email { get; set; }

		[Required]
		[StringLength(20)]
		[DataType(DataType.Password)]
		private string Password { get; set; }

	}

}