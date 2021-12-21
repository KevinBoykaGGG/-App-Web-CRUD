using ClassLibrary1.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    public class Cliente2Controller : Controller
    {
        private readonly IClienteRepository _clienteRepository;

        public Cliente2Controller(IClienteRepository clienteRepository)
        {
            _clienteRepository = clienteRepository;
        }

         public async Task< IActionResult > Index()
        {
            ViewBag.Listado = await _clienteRepository.GetClientes();
            return View();
        }
    }
}
