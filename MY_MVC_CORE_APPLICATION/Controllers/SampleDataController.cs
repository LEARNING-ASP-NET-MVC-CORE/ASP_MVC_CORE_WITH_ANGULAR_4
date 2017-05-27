using System.Linq;

namespace MY_MVC_CORE_APPLICATION.Controllers
{
	[Microsoft.AspNetCore.Mvc.Route("api/[controller]")]
	public class SampleDataController : Microsoft.AspNetCore.Mvc.Controller
	{
		public SampleDataController() : base()
		{
		}

		private static string[] Summaries = new[]
		{
			"Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
		};

		[Microsoft.AspNetCore.Mvc.HttpGet("[action]")]
		public System.Collections.Generic.IEnumerable<WeatherForecast> WeatherForecasts()
		{
			var rng = new System.Random();

			return System.Linq.Enumerable.Range(1, 5).Select(index => new WeatherForecast
			{
				DateFormatted =
					System.DateTime.Now.AddDays(index).ToString("d"),
					TemperatureC = rng.Next(-20, 55),
					Summary = Summaries[rng.Next(Summaries.Length)]
			});
		}

		public class WeatherForecast
		{
			public string DateFormatted { get; set; }
			public int TemperatureC { get; set; }
			public string Summary { get; set; }

			public int TemperatureF
			{
				get
				{
					return (32 + (int)(TemperatureC / 0.5556));
				}
			}
		}
	}
}
