using CarRental.Dtos;
using CarRental.Models;
using CarRental.Services;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System;

namespace CarRental.Tests.Services
{
	[TestClass]
	public class ClientServiceTests
	{
		private readonly Mock<CarRentalDbContext> _mockCarRentalDbContext = new Mock<CarRentalDbContext>();
		private IClientService _clientService;

		[TestInitialize]
		public void TestInitialize()
		{
			_clientService = new ClientService(_mockCarRentalDbContext.Object);
		}

		[TestMethod]
		public void Register_ShouldNotAddAnythingToDatabase_ForNullClientDto()
		{
			// Arrange
			RegisterClientDto dto = null;

			// Act
			_clientService.Register(dto);

			// Assert
			_mockCarRentalDbContext.Verify(x => x.Add(It.IsAny<RegisterClientDto>()), Times.Never);
		}

		[TestMethod]
		public void Register_ShouldAddClientToDatabase()
		{
			// Arrange
			var dto = new RegisterClientDto
			{
				Email = "email@test.com",
				Name = "TestName",
				LastName = "TestLastName",
			};

			var expectedClient = new Client
			{
				Email = "email@test.com",
				Name = "TestName",
				LastName = "TestLastName",
			};

			// Act
			_clientService.Register(dto);

			// Assert
			_mockCarRentalDbContext.Verify(x => x.Add(It.IsAny<Client>()), Times.Exactly(1));
			_mockCarRentalDbContext.Verify(x => x.SaveChanges(), Times.Exactly(1));
		}
	}
}
