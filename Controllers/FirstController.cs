using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace UnitConversionCSharp.Controllers
{
    public class FirstController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }
        public ActionResult AgeConversion()
        {
            return View( viewName: "AgeConversion", model: 0.0);
        }
        public ActionResult TimeConversions()
        {
            return View(viewName: "TimeConversions", model: 0.0);
        }

        [HttpPost]
        public ActionResult convertAge(double inputAge)
        {
            return View(viewName: "AgeConversion", model:inputAge*7);
        }
        [HttpPost]
        public ActionResult ConvertTime(double inputShakes)
        {
            return View(viewName: "TimeConversions", model: inputShakes * 10);
        }
    }
}
