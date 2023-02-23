using CarRental.Dtos;
using CarRental.Models;
using CarRental.Services;
using FluentAssertions;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System;

namespace CarRental.Tests.Services
{
	[TestClass]
	public class LoginServiceTests
	{

		private readonly Mock<CarRentalDbContext> _mockCarRentalDbContext = new Mock<CarRentalDbContext>();
		private ILoginService _loginService;

		[TestInitialize]
		public void TestInitialize()
		{
			_loginService = new LoginService(_mockCarRentalDbContext.Object);
		}

		[TestMethod]
		public void Login_ShouldReturnFalse_WhenNullDbEmployee()
		{
			// Arrange
			var users = new List<Employee>().AsQueryable();

			var usersMock = new Mock<DbSet<Employee>>();
			usersMock.As<IQueryable<Employee>>().Setup(m => m.Provider).Returns(users.Provider);
			usersMock.As<IQueryable<Employee>>().Setup(m => m.Expression).Returns(users.Expression);
			usersMock.As<IQueryable<Employee>>().Setup(m => m.ElementType).Returns(users.ElementType);
			usersMock.As<IQueryable<Employee>>().Setup(m => m.GetEnumerator()).Returns(users.GetEnumerator());

			_mockCarRentalDbContext.SetupGet(x => x.Employers).Returns(usersMock.Object);

			// Act
			var result = _loginService.Login(new EmployeeLoginDto());

			// Assert
			result.Should().BeFalse();
		}

		[TestMethod]
		public void Login_ShouldReturnTrue_ForValidLoginData()
		{
			// Arrange
			var users = new List<Employee>()
			{
				new Employee
				{
					Id = 1,
					Name = "TestName",
					LastName = "TestLastName",
					Login = "Login",
					Password = "Password"
				}
			}.AsQueryable();

			var usersMock = new Mock<DbSet<Employee>>();
			usersMock.As<IQueryable<Employee>>().Setup(m => m.Provider).Returns(users.Provider);
			usersMock.As<IQueryable<Employee>>().Setup(m => m.Expression).Returns(users.Expression);
			usersMock.As<IQueryable<Employee>>().Setup(m => m.ElementType).Returns(users.ElementType);
			usersMock.As<IQueryable<Employee>>().Setup(m => m.GetEnumerator()).Returns(users.GetEnumerator());

			_mockCarRentalDbContext.SetupGet(x => x.Employers).Returns(usersMock.Object);

			// Act
			var result = _loginService.Login(new EmployeeLoginDto
			{
				Login = "Login",
				Password = "Password"
			});

			// Assert
			result.Should().BeTrue();
		}

	}
}
