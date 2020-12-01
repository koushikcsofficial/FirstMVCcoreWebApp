using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyWebApp2.Controllers
{
    public class HomeController : Controller
    {
        public ViewResult Index()
        {
            var obj = new { name = "Koushik" };
            return View(obj);
        }

        //public string Index()
        //{
        //    return "Hi from Koushik";
        //}

    }
}
