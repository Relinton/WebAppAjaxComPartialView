using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using WebAppAjaxComPartialView.Context;
using WebAppAjaxComPartialView.Models;

namespace WebAppAjaxComPartialView.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ProgramadorContext _context;

        public HomeController(ILogger<HomeController> logger, ProgramadorContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index()
        {
            Programador programador = new Programador();
            return View(programador);
        }

        public IActionResult Cadastrar(Programador programador)
        {
            _context.Add(programador);
            _context.SaveChanges();
            return PartialView("Partials/_Mensagem", programador);
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
