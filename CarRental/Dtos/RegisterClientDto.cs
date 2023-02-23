using System.ComponentModel.DataAnnotations;

namespace CarRental.Dtos
{
	public class RegisterClientDto
	{
		[Required]
		[MaxLength(255)]
		public string Name { get; set; }
		[Required]
		[MaxLength(255)]
		public string LastName { get; set; }
		[Required]
		[MaxLength(255)]
		public string Email { get; set; }
	}
}
