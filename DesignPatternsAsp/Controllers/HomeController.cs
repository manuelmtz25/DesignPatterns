using DesignPatternsAsp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using DesignPatternsAsp.Configuration;
using Microsoft.Extensions.Options;
using Tools;

namespace DesignPatternsAsp.Controllers
{
    public class HomeController : Controller
    {
        private readonly IOptions<MyConfig> _config;
        public HomeController(IOptions<MyConfig> config)
        {
            _config = config;
        }

        public IActionResult Index()
        {
            //Sin inyección de dependencias
            //Log.GetInstance("log.txt").Save("Entró a Index");

            //Con inyección de dependencias
            Log.GetInstance(_config.Value.PathLog).Save("Entró a Index");

            return View();
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
