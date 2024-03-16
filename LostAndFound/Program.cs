using LostAndFound.Forms;
using LostAndFound.Interfaces;
using LostAndFound.Models;
using LostAndFound.Services;
using Microsoft.Extensions.DependencyInjection;

namespace LostAndFound
{
	public static class Program
	{
		#region PROPERTIES

		public static bool IsLogin { get; set; }

		#endregion

		[STAThread]
		static void Main()
		{
			ApplicationConfiguration.Initialize();

			var services = new ServiceCollection();

			services.AddDbContext<LostAndFoundContext>();

			services.AddSingleton<ILostInfoService<LostInfo>, LostInfoService>();
			services.AddSingleton<IUserService<User>, UserService>();

			services.AddSingleton<FormLostAndFound>();
			services.AddSingleton<FormLogin>();
			services.AddSingleton<FormSignup>();

			using var serviceProvider = services.BuildServiceProvider();

			var formLostAndFound = serviceProvider.GetRequiredService<FormLostAndFound>();
			var formLogin = serviceProvider.GetRequiredService<FormLogin>();
			var formSignup = serviceProvider.GetRequiredService<FormSignup>();

			Application.Run(formLogin);

			if (IsLogin == true)
			{
				Application.Run(formLostAndFound);
			}
		}
	}
}