using Microsoft.AspNetCore.Mvc;
using Portafolio.Models;
using Portafolio.Servicios;
using System.Diagnostics;

namespace Portafolio.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly RepositorioProyectos repositorioProyectos;
        private readonly RepositorioContactos repositorioContactos;

        public HomeController(ILogger<HomeController> logger, RepositorioProyectos repositorioProyectos, RepositorioContactos repositorioContactos)
        {
            _logger = logger;
            this.repositorioProyectos = repositorioProyectos;
            this.repositorioContactos = repositorioContactos;
        }

        public IActionResult Index()
        {
            var contactos = repositorioContactos.ObtenerContactos().Take(3).ToList();
            var proyectos = repositorioProyectos.ObtenerProyectos().Take(4).ToList();
            var modelo = new HomeIndexVM() { Proyectos = proyectos , Contactos = contactos };
            return View(modelo);
        }

        public IActionResult Menu()
        {
            return View();
        }

        public IActionResult Privacy()
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