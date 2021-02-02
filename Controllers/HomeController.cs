using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MVCResponsiveWebApp.Models;

namespace Ch02FutureValueDecker.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            ViewBag.FV = 0;
            return View();
        }
        [HttpPost]
        public IActionResult Index(ResponsiveModel model)
        {
            if (ModelState.IsValid)
            {
                ViewBag.FV = model.AgeThisYear();
            }
            else
            {
                ViewBag.FV = 0;
            }
            return View(model);
        }

    }
}
