using CarRental.Dtos;
using CarRental.Models;

namespace CarRental.Services
{
	public class ClientService : IClientService
	{
		private readonly CarRentalDbContext _context;

		public ClientService(CarRentalDbContext context)
		{
			_context = context;
		}

		public void Register(RegisterClientDto dto)
		{
			if (dto is not null)
			{
				_context.Add(new Client
				{
					Name = dto.Name,
					LastName = dto.LastName,
					Email = dto.Email
				});
				_context.SaveChanges();
			}
		}
	}
}
