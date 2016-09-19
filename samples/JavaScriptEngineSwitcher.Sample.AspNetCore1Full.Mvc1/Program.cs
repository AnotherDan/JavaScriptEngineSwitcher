﻿using System.IO;

using Microsoft.AspNetCore.Hosting;

namespace JavaScriptEngineSwitcher.Sample.AspNetCore1Full.Mvc1
{
	public class Program
	{
		public static void Main(string[] args)
		{
			var host = new WebHostBuilder()
				.UseKestrel()
				.UseContentRoot(Directory.GetCurrentDirectory())
				.UseIISIntegration()
				.UseStartup<Startup>()
				.Build()
				;

			host.Run();
		}
	}
}