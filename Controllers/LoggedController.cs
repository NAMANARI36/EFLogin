using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace EFLogin.Controllers
{
    //[Route("[controller]")]
    public class LoggedController : Controller
    {
        //private readonly ILogger<LoggedController> _logger;

        /*public LoggedController(ILogger<LoggedController> logger)
        {
            _logger = logger;
        }*/

        public IActionResult Index()
        {
            return View();
        }




        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }
    }
}