using Microsoft.AspNetCore.Mvc;
using MetricSystem.Models;

namespace MetricSystem.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View(new FahrenheitConversion());
        }

        [HttpPost]
        public IActionResult Index(FahrenheitConversion model)
        {
            if (ModelState.IsValid)
            {
                model.Convert();
                ViewBag.CelsiusValue = model.CelsiusValue;
                return View(model);
            }
            return View(model);
        }

        [HttpPost]
        public IActionResult Clear()
        {
            return RedirectToAction("Index");
        }
    }
}
