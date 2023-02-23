using CarRental.Dtos;

namespace CarRental.Services
{
	public interface ILoginService
	{
		bool Login(EmployeeLoginDto employee);
	}
}