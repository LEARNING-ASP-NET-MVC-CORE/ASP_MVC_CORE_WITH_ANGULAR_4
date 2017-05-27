using Microsoft.AspNetCore.Hosting;

namespace MY_MVC_CORE_APPLICATION
{
	public static class Program
	{
		static Program()
		{
		}

		public static void Main(string[] args)
		{
			var host =
				new Microsoft.AspNetCore.Hosting.WebHostBuilder()
				.UseKestrel()
				.UseContentRoot(System.IO.Directory.GetCurrentDirectory())
				.UseIISIntegration()
				.UseStartup<Startup>()
				.Build();

			host.Run();
		}
	}
}
