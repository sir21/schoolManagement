using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SMS.Models;

namespace SMS.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message1"] = "Our school is situated at great environment that your son and daughter can experience the world with great pleasure.";
            ViewData["Message2"] = "We like to welcome you to every event organized by school and be there to support your sun/daughter";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Address"] = "1132A, Galle Rd, Colombo 3.";
            ViewData["Telephone"] = "+94674362341";
            ViewData["Email"] = "greatschool@scl.com";

            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
