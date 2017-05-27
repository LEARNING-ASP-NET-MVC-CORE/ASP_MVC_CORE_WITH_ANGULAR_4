namespace MY_MVC_CORE_APPLICATION.Controllers
{
	public class HomeController : Microsoft.AspNetCore.Mvc.Controller
	{
		public HomeController() : base()
		{
		}

		public Microsoft.AspNetCore.Mvc.IActionResult Index()
		{
			return (View());
		}

		public Microsoft.AspNetCore.Mvc.IActionResult Error()
		{
			return (View());
		}
	}
}
