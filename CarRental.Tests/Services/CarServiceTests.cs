using AutoMapper;
using CarRental.Dtos.DtosForCars;
using CarRental.Models;
using CarRental.Services;
using CarRental.Utils;
using FluentAssertions;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System;

namespace CarRental.Tests.Services
{
	[TestClass]
	public class CarServiceTests
	{
		private readonly Mock<CarRentalDbContext> _mockCarRentalDbContext = new();
		private readonly Mock<IMapper> _mockMapper = new();
		private ICarService _carService;

		[TestInitialize]
		public void TestInitialize()
		{

			_carService = new CarService(_mockCarRentalDbContext.Object, _mockMapper.Object);
		}

		[TestMethod]
		public void AddCar_ShouldAddCarToDb()
		{
			// Arrange
			var carDto = new NewCarDto
			{
				Name = "Test Car1",
				Description = "Test Car Desc1",
				DailyPrice = 111,
			};
			// Act
			_carService.AddCar(carDto);

			// Assert
			_mockCarRentalDbContext.Verify(x => x.Add(It.IsAny<Car>()), Times.Exactly(1));
			_mockCarRentalDbContext.Verify(x => x.SaveChanges(), Times.Exactly(1));
		}
	}
}
