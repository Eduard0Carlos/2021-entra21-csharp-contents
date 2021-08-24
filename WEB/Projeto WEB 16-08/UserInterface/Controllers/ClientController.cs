using Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace UserInterface.Controllers
{
    public class ClientController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Register(Client client)
        {
            return View();
        }

        public IActionResult Register2()
        {
            return View();
        }
    }
}
