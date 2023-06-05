﻿using Microsoft.AspNetCore.Mvc;
using Portafolio.Models;
using Portafolio.Servicios;
using System.Diagnostics;

namespace Portafolio.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IRepositorioProyectos repositorioProyectos;
        private readonly IRepositorioContactos repositorioContactos;
        private readonly ServicioUnico servicioUnico;
        private readonly ServicioTransitorio servicioTransitorio;
        private readonly ServicioDelimitado servicioDelimitado;
        private readonly ServicioUnico servicioUnico2;
        private readonly ServicioTransitorio servicioTransitorio2;
        private readonly ServicioDelimitado servicioDelimitado2;

        public HomeController(ILogger<HomeController> logger, 
            IRepositorioProyectos repositorioProyectos, 
            IRepositorioContactos repositorioContactos, 
            ServicioUnico servicioUnico, 
            ServicioTransitorio servicioTransitorio, 
            ServicioDelimitado servicioDelimitado,
            ServicioUnico servicioUnico2,
            ServicioTransitorio servicioTransitorio2,
            ServicioDelimitado servicioDelimitado2

            )

        {
            _logger = logger;
            this.repositorioProyectos = repositorioProyectos;
            this.repositorioContactos = repositorioContactos;
            this.servicioUnico = servicioUnico;
            this.servicioTransitorio = servicioTransitorio;
            this.servicioDelimitado = servicioDelimitado;
            this.servicioUnico2 = servicioUnico2;
            this.servicioTransitorio2 = servicioTransitorio2;
            this.servicioDelimitado2 = servicioDelimitado2;
        }

        public IActionResult Index()
        {
            var contactos = repositorioContactos.ObtenerContactos().Take(3).ToList();
            var proyectos = repositorioProyectos.ObtenerProyectos().Take(4).ToList();

            var guidViewModel = new EjemploGuidVM()
            {
                Delimitado = servicioDelimitado.ObtenerGuid,
                Transitorio = servicioTransitorio.ObtenerGuid,
                Unico = servicioUnico.ObtenerGuid,
            };

            var guidViewModel2 = new EjemploGuidVM()
            {
                Delimitado = servicioDelimitado2.ObtenerGuid,
                Transitorio = servicioTransitorio2.ObtenerGuid,
                Unico = servicioUnico2.ObtenerGuid,
            };

            var modelo = new HomeIndexVM() { 
                Proyectos = proyectos, 
                Contactos = contactos,
                EjemploGuid_1 = guidViewModel,
                EjemploGuid_2 = guidViewModel2

            };
            return View(modelo);
        }

        public IActionResult Bootstrap()
        {
            return View();
        }

        public IActionResult Inyection()
        {

            var guidViewModel = new EjemploGuidVM()
            {
                Delimitado = servicioDelimitado.ObtenerGuid,
                Transitorio = servicioTransitorio.ObtenerGuid,
                Unico = servicioUnico.ObtenerGuid,
            };

            var guidViewModel2 = new EjemploGuidVM()
            {
                Delimitado = servicioDelimitado2.ObtenerGuid,
                Transitorio = servicioTransitorio2.ObtenerGuid,
                Unico = servicioUnico2.ObtenerGuid,
            };
            var modelo = new HomeIndexVM()
            {
               
                EjemploGuid_1 = guidViewModel,
                EjemploGuid_2 = guidViewModel2

            };
            return View(modelo);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}