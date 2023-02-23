using CarRental.Dtos;

namespace CarRental.Services
{
	public interface IClientService
	{
		void Register(RegisterClientDto dto);
	}
}