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
    public class SignInController : Controller
    {
        //private readonly ILogger<SignInController> _logger;

        /*public SignInController(ILogger<SignInController> logger)
        {
            _logger = logger;
        }*/

        public IActionResult Index()
        {
            CreateNewUser();
            return View();
        }

       

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }
    }
}