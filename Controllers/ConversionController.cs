using Microsoft.AspNetCore.Mvc;
using MetricSystem.Models; // Use your model namespace

namespace MetricSystem.Controllers
{
    public class ConversionController : Controller
    {
        // GET: /Conversion/Fahrenheit
        [HttpGet]
        public IActionResult Fahrenheit()
        {
            // Create and pass an empty model to the view
            return View(new FahrenheitConversion());
        }

        // POST: /Conversion/Fahrenheit
        [HttpPost]
        public IActionResult Fahrenheit(FahrenheitConversion model)
        {
            // Validate input
            if (!model.FahrenheitValue.HasValue)
            {
                ViewBag.Error = "Please enter a Fahrenheit value.";
                return View(model);
            }
            // Use model's Convert method
            model.Convert();
            return View(model);
        }

        // POST: /Conversion/Clear
        [HttpPost]
        public IActionResult Clear()
        {
            // Return empty model to clear fields
            return RedirectToAction("Fahrenheit");
        }
    }
}
