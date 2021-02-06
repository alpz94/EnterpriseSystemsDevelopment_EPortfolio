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
		[Key]
		public int ApprenticeId { get; set; }

		public SpecialismType Specialism { get; set; }

		[Required]
		[StringLength(20)]
		[DisplayName("First Name")]
		public string FirstName { get; set; }

		[Required]
		[StringLength(20)]
		[DisplayName("Last Name")]
		public string LastName { get; set; }

		[Required]
		[StringLength(20)]
		[DisplayName("Job Title")]
		public string JobTitle { get; set; }

		[Required]
		[StringLength(20)]
		[DisplayName("Employer")]
		public string Employer { get; set; }

		[Required]
		[StringLength(20)]
		[DataType(DataType.EmailAddress)]
		public string Email { get; set; }

		//ICollection of template
		public virtual ICollection<Template> Templates { get; set; }
	}

}