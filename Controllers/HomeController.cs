using ChatbotMaker.BDK;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChatbotTest.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return Ok($@"{ChatbotApp.Current.Description}");
        }
    }
}
