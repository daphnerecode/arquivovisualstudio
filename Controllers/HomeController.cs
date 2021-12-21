using AgenciaCrud.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace AgenciaCrud.Controllers
{
    public class HomeController : Controller
    {


        public IActionResult Index()
        {
            return View("Index");

        }

        public IActionResult Cadastro()
        {
            return View("Cadastro");
        }

        public IActionResult Promocoes()
        {
            return View("Promocoes");
        }
        public IActionResult Destinos()
        {
            return View("Destinos");
        }
        public IActionResult Contato()
        {
            return View("Contato");
        }
        public IActionResult Reservas()
        {
            return View("Reservas");
        }

    }
}
