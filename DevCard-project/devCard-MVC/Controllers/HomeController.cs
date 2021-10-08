using devCard_MVC.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace devCard_MVC.Controllers
{
    public class HomeController : Controller
    {
       

        public HomeController()
        {
           
        }

        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Contact()
        {
            var model = new contact();
            return View(model);
        }
         [HttpPost]
        public JsonResult Contact(contact form)
        {
            Console.WriteLine(form.ToString());
            return Json(Ok());
        }               

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
