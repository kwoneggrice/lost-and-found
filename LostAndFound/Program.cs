using LostAndFound.Forms;
using Microsoft.Extensions.DependencyInjection;
using System.ComponentModel.Design;

namespace LostAndFound
{
	internal static class Program
	{
		/// <summary>
		///  The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
			// To customize application configuration such as set high DPI settings or default font,
			// see https://aka.ms/applicationconfiguration.
			ApplicationConfiguration.Initialize();

			var services = new ServiceCollection();

			services.AddSingleton<FormLostAndFound>();

			using var serviceProvider = services.BuildServiceProvider();

			var formLostAndFound = serviceProvider.GetRequiredService<FormLostAndFound>();

			Application.Run(formLostAndFound);
		}
	}
}