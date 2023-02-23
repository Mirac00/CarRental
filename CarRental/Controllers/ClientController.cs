using CarRental.Dtos;
using CarRental.Services;
using Microsoft.AspNetCore.Mvc;

namespace CarRental.Controllers
{
	public class ClientController : Controller
	{
		private readonly IClientService _clientService;

		public ClientController(IClientService clientService)
		{
			_clientService = clientService;
		}

		public IActionResult Index()
		{
			return View();
		}

		public IActionResult Register(RegisterClientDto dto)
		{
			if (ModelState.IsValid)
			{
				_clientService.Register(dto);
			}

			return View("Index");
		}
	}
}
