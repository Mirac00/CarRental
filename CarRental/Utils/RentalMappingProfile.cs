using AutoMapper;
using CarRental.Dtos;
using CarRental.Dtos.DtosForCars;
using CarRental.Dtos.DtosForRentals;
using CarRental.Models;

namespace CarRental.Utils
{
	public class RentalMappingProfile : Profile
	{
		public RentalMappingProfile()
		{
			CreateMap<RentalDto, Rental>();
			CreateMap<Rental, RentalDto>();
			CreateMap<Rental, RentalCarDto>();
			CreateMap<RentalCarDto, Rental>();
			CreateMap<Client, RentalClientDto>();
			CreateMap<RentalClientDto, Client>();
			CreateMap<Car, CarRentalDto>();
			CreateMap<CarRentalDto, Car>();
			CreateMap<CarDto, Car>();
			CreateMap<Car, CarDto>();
		}
	}
}
