using CarRental.Dtos;
using CarRental.Models;

namespace CarRental.Services
{
	public class LoginService : ILoginService
	{
		private readonly CarRentalDbContext _context;

		public LoginService(CarRentalDbContext context)
		{
			_context = context;
		}

		public bool Login(EmployeeLoginDto employee)
		{
			var dbEmployee = _context.Employers.FirstOrDefault(e => e.Login == employee.Login);

			if (dbEmployee == null)
				return false;

			if (dbEmployee.Login == employee.Login && dbEmployee.Password == employee.Password)
				return true;

			return false;
		}
	}
}
