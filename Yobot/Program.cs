using LaunchDarkly.EventSource;
using System;
using System.Diagnostics;

namespace Yobot
{
	public class Program
	{
		public static void Main(string[] args)
		{
			var source = new EventSource(new Configuration(new Uri("https://smee.io/3fUXIBJELWjqgj8Q")));
			source.MessageReceived += (sender, eventArgs) =>
			                          {
				                          Debugger.Break();
			                          };

			source.CommentReceived += (sender, eventArgs) =>
			                          {
				                          Debugger.Break();
			                          };

			source.StartAsync();
			/*

			Host.CreateDefaultBuilder(args)
			    .ConfigureWebHostDefaults(webBuilder => webBuilder.UseStartup<Startup>())
			    .Build()
			    .Run();

			source.Close();*/
			Console.ReadLine();
		}
	}
}