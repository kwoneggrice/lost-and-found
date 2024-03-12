using LostAndFound.Forms;
using LostAndFound.Interfaces;
using LostAndFound.Models;
using LostAndFound.Services;
using Microsoft.Extensions.DependencyInjection;

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

			services.AddDbContext<LostAndFoundContext>();

			services.AddSingleton<IQuery<LostInfo>, LostInfoService>();

			services.AddSingleton<FormLostAndFound>();

			using var serviceProvider = services.BuildServiceProvider();

			var formLostAndFound = serviceProvider.GetRequiredService<FormLostAndFound>();

			Application.Run(formLostAndFound);
		}
	}
}