using Microsoft.AspNetCore.Mvc;
using MVcMovie.Models;
using System.Diagnostics;

namespace MVcMovie.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Sobre()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Cadastrar(Pessoa p)
        {
           // string Nome = p.Nome;
          //  string Cpf = p.Cpf;
            return View("Pessoa", p);
        }

        public IActionResult Pessoa(Pessoa p)
        {
            return View(p);
        }

        public IActionResult Cadastrar()
        {
           return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}