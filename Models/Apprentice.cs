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
		[StringLength(50)]
		private int apprenticeID { get; set; }

		[Required]
		[StringLength(20)]
		[DisplayName("First Name")]
		private String firstName { get; set; }

		[Required]
		[StringLength(20)]
		[DisplayName("Last Name")]
		private String lastName { get; set; }

		[Required]
		[StringLength(50)]
		[DisplayName("Specialism")]
		private String specialismName { get; set; }

		[Required]
		[StringLength(20)]
		[DisplayName("Job Title")]
		private String jobTitle { get; set; }

		[Required]
		[StringLength(20)]
		[DisplayName("Employer")]
		private String employer { get; set; }

		[Required]
		[StringLength(20)]
		[DataType(DataType.EmailAddress)]
		private String email { get; set; }

		[Required]
		[StringLength(20)]
		[DataType(DataType.Password)]
		private String password { get; set; }

	}

}