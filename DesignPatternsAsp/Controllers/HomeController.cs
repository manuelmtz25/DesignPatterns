using DesignPatternsAsp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using DesignPatterns.Models.Data;
using DesignPatterns.Repository;
using DesignPatternsAsp.Configuration;
using Microsoft.Extensions.Options;
using Tools;

namespace DesignPatternsAsp.Controllers
{
    public class HomeController : Controller
    {
        private readonly IOptions<MyConfig> _config;

        private readonly IRepository<Beer> _repository;
        public HomeController(IOptions<MyConfig> config, IRepository<Beer> repository)
        {
            _config = config;
            _repository = repository;
        }

        public IActionResult Index()
        {
            //Sin inyección de dependencias
            //Log.GetInstance("log.txt").Save("Entró a Index");

            //Con inyección de dependencias
            //Log.GetInstance(_config.Value.PathLog).Save("Entró a Index");

            IEnumerable<Beer> list = _repository.Get();

            return View("Index", list);
        }

        public IActionResult Privacy()
        {
            Log.GetInstance(_config.Value.PathLog).Save("Entró a Privacy");
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
