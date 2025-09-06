using System.ComponentModel.DataAnnotations;

namespace MetricSystem.Models
{
    public class FahrenheitConversion
    {
        [Required(ErrorMessage = "Fahrenheit value is required.")]
        public double? FahrenheitValue { get; set; }

        public double? CelsiusValue { get; set; }

        public void Convert()
        {
            if (FahrenheitValue.HasValue)
            {
                CelsiusValue = (FahrenheitValue - 32) * 5 / 9;
            }
        }
    }
}
