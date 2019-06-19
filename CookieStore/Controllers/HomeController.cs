using CookieStore.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CookieStore.Controllers
{
    public class HomeController : Controller
    {
        private readonly IRepository _repository; 
        public HomeController(IRepository repository)
        {
            _repository = repository; 
        }

        public IActionResult Index()
        {
            return View(); 
        }
    }
}
