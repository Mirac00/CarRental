using Microsoft.Build.Framework;

namespace CarRental.Dtos
{
	public class EmployeeLoginDto
	{
		[Required]
		public string Login { get; set; }
		[Required]
		public string Password { get; set; }
	}
}
