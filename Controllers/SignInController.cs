using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using EFLogin.Models.Services.Application;
using EFLogin.Models.Entities;


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

            
            return View();
        }

        public IActionResult Registrazione(string Nome, string Email, string Password, string Country)
        {
            User user = CreateNewUser(Nome, Email, Password, Country);

            return Content("Registrazione avvenuta yuppie");

        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }
    }
}